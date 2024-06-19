using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTruongHoc.nhan_su.forms
{
    public partial class UpdateDonVi : Form
    {
        public string Madv { get; set; }

        public UpdateDonVi()
        {
            InitializeComponent();
        }

        public UpdateDonVi(string maDv)
        {
            InitializeComponent();
            Madv = maDv;
            fetchTdv();
            fetchDonViData();
        }

        private void fetchDonViData()
        {
            try
            {
                string sql = $"select madv, tendv from qlth.qlth_donvi where madv = '{this.Madv}'";
                OracleCommand command = new OracleCommand(sql, Session.Instance.OracleConnection);
                OracleDataReader oracleDataReader = command.ExecuteReader();
                if (oracleDataReader.Read())
                {
                    string madv = oracleDataReader["MADV"].ToString();
                    string tendv = oracleDataReader["TENDV"].ToString();
                    textBox1.Text = madv;
                    textBox2.Text = tendv;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchTdv()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string hostname = appSettings["hostname"] ?? "localhost";
                string port = appSettings["port"] ?? "1521";
                string qlth = appSettings["sysdba"] ?? "QLTH";
                string pwd = appSettings["pwd"] ?? "QLTH";
                string connectionString = @$"DATA SOURCE = {hostname}:{port}/XEPDB1; USER ID=" + qlth + ";PASSWORD=" + pwd;

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string sql = $"select mans, hoten from qlth.qlth_nhansu where madv = '{this.Madv}'";
                    using (OracleCommand cmd = new OracleCommand(sql, connection))
                    {
                        OracleDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            int? mans = (int)reader["MANS"];
                            string? hoten = reader["HOTEN"].ToString();

                            string combined = mans.ToString() + " - " + hoten;
                            comboBox1.Items.Add(combined);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string tdv = "CNPM";
                string[] str = comboBox1.SelectedItem.ToString().Split(' ');
                
                if (str.Length > 0 && str[0].Length > 0)
                {
                    tdv = str[0];
                }
                //MessageBox.Show(tdv);
                string sql = $"update qlth.qlth_donvi set trgdv = {tdv} where madv = '{this.Madv}'";
                OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

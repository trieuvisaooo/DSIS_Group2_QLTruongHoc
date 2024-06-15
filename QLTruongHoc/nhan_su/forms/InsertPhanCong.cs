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
    public partial class InsertPhanCong : Form
    {
        public string MaDv { get; set; }

        public InsertPhanCong()
        {
            InitializeComponent();
        }

        public InsertPhanCong(string maDv)
        {
            InitializeComponent();

            MaDv = maDv;
            fetchKhmo();
            fetchGiaoVien();
        }

        public void fetchKhmo()
        {
            try
            {
                string sql = $"select kh.mahp, hp.tenhp, kh.hk, kh.nam, kh.mact " +
                    $"from qlth.qlth_khmo kh " +
                    $"join qlth.qlth_hocphan hp on kh.mahp = hp.mahp " +
                    $"where hp.madv = '{MaDv}'";

                OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string? mahp = reader["MAHP"].ToString();
                    string tenhp = reader["TENHP"].ToString();
                    decimal hk = (decimal)reader["HK"];
                    string nam = reader["NAM"].ToString();
                    string mact = reader["MACT"].ToString();

                    string combinedStr = string.Join("/", new string[] { mahp, tenhp, hk.ToString(), nam, mact });
                    comboBox1.Items.Add(combinedStr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fetchGiaoVien()
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
                    string sql = $"select mans, hoten from qlth.qlth_nhansu where madv = '{MaDv}'";
                    using (OracleCommand cmd = new OracleCommand(sql, connection))
                    {
                        OracleDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string mans = reader["MANS"].ToString();
                            string hoten = reader["HOTEN"].ToString();
                            
                            string combinedStr = string.Join(" - ", new string[] { mans, hoten });
                            comboBox2.Items.Add(combinedStr);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }
    }
}

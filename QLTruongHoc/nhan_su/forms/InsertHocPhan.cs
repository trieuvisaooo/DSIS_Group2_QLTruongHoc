using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTruongHoc.nhan_su.forms
{
    public partial class InsertHocPhan : Form
    {
        public InsertHocPhan()
        {
            InitializeComponent();
            fetchDonVi();
        }

        private void fetchDonVi()
        {
            try
            {
                string sql = $"select madv, tendv from qlth.qlth_donvi";
                OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
                OracleDataReader oracleDataReader = cmd.ExecuteReader();
                while (oracleDataReader.Read())
                {
                    string madv = oracleDataReader["MADV"].ToString();
                    string tendv = oracleDataReader["TENDV"].ToString();

                    if (!string.IsNullOrEmpty(tendv))
                    {
                        madv += " - " + tendv;
                    }
                    comboBox1.Items.Add(madv);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mahp = textBox1.Text;
                string tenhp = textBox2.Text;
                decimal sotc = numericUpDown1.Value;
                decimal stlt = numericUpDown2.Value;
                decimal stth = numericUpDown3.Value;
                decimal sosv = numericUpDown4.Value;
                string[] dv = comboBox1.SelectedItem.ToString().Split(" - ");
                string madv = dv[0];

                string sql = $"insert into qlth.qlth_hocphan (mahp,tenhp,sotc,stlt,stth,sosvtd,madv) values ('{mahp}',N'{tenhp}',{sotc},{stlt},{stth},{sosv},'{madv}')";
                OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tạo mới học phần thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

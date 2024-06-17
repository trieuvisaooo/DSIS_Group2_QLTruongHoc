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
    public partial class UpdateHocPhan : Form
    {
        public string MaHp { get; set; }

        public UpdateHocPhan()
        {
            InitializeComponent();
        }

        public UpdateHocPhan(string MaHp)
        {
            InitializeComponent();
            this.MaHp = MaHp;
            fetchDonVi();
            fetchHocPhanData();
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

        private void fetchHocPhanData()
        {
            
            try
            {
                string sql = $"select * from qlth.qlth_hocphan where mahp = '{this.MaHp}'";
                OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox1.Text = reader.GetString(0);
                    textBox2.Text = reader.GetString(1);

                    numericUpDown1.Value = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                    numericUpDown2.Value = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
                    numericUpDown3.Value = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
                    numericUpDown4.Value = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);

                    comboBox1.SelectedIndex = comboBox1.FindString(reader.GetString(6));
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
                string[] dv = comboBox1.SelectedItem.ToString().Split(" - ");
                string madv = dv[0];

                string sql = $"update qlth.qlth_hocphan set " +
                    $"mahp = '{textBox1.Text}', " +
                    $"tenhp = '{textBox2.Text}', " +
                    $"sotc = {numericUpDown1.Value}, " +
                    $"stlt = {numericUpDown2.Value}, " +
                    $"stth = {numericUpDown3.Value}, " +
                    $"sosvtd = {numericUpDown4.Value}, " +
                    $"madv = '{madv}' " + 
                    $"where mahp = '{this.MaHp}'";
                MessageBox.Show(sql);
                OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cập nhật thất bại");
            }
        }
    }
}

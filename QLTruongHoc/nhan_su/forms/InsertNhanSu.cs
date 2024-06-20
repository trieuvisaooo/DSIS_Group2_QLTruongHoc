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
    public partial class InsertNhanSu : Form
    {
        public InsertNhanSu()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            try
            {
                DbCommand.setDateFormatDb();
                DateTime birthDate = dateTimePicker1.Value;
                string day = birthDate.Day.ToString();
                if (day.Length == 1)
                {
                    day = '0' + day;
                }

                string month = birthDate.Month.ToString();
                if (month.Length == 1)
                {
                    month = "0" + month;
                }
                string year = birthDate.Year.ToString();
                string sql = $"INSERT INTO QLTH.QLTH_NHANSU(MANS, HOTEN, PHAI, NGSINH, DIACHI, DT, VAITRO, MADV, MACS) " +
                    $"VALUES({textBox1.Text}, N'{textBox2.Text}', N'{comboBox1.SelectedItem.ToString()}', '{year}-{month}-{day}', N'{textBox3.Text}', '{textBox4.Text}', '{comboBox2.SelectedItem.ToString()}', '{comboBox3.SelectedItem.ToString()}', '{comboBox4.SelectedItem.ToString()}')";

                //MessageBox.Show(sql);
                OracleCommand command = new OracleCommand(sql, Session.Instance.OracleConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm nhân sự thành công!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

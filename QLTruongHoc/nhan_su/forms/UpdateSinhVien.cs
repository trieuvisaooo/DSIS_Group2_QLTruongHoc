using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTruongHoc.nhan_su.forms
{
    public partial class UpdateSinhVien : Form
    {
        public decimal Mssv { get; set; }

        public UpdateSinhVien()
        {
            InitializeComponent();
        }
        public UpdateSinhVien(int mssv)
        {
            InitializeComponent();
            Mssv = mssv;
            FetchSinhVienData();
        }

        private void FetchSinhVienData()
        {
            //try
            //{
            string sql = $"select * from qlth.qlth_sinhvien where masv = {this.Mssv}";
            OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                textBox1.Text = reader["MASV"].ToString();
                textBox2.Text = reader["HOTEN"].ToString();
                comboBox1.SelectedItem = reader["PHAI"].ToString();

                string birthDateStr = reader["NGSINH"].ToString();
                DateTime birthDate = birthDateStr.Length == 0 ? DateTime.Today : DateTime.Parse(birthDateStr, CultureInfo.InvariantCulture);
                dateTimePicker1.Value = birthDate;

                textBox3.Text = reader["DIACHI"].ToString();
                textBox4.Text = reader["DT"].ToString();
                comboBox2.SelectedItem = reader["MACT"].ToString();
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }
        private void setDateFormatDb()
        {
            string sql = $"ALTER SESSION SET NLS_DATE_FORMAT = 'YYYY-MM-DD'";
            OracleCommand cmd = new OracleCommand( sql, Session.Instance.OracleConnection );
            cmd.ExecuteNonQuery();
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            setDateFormatDb();
            string mssv = textBox1.Text;
            string hoten = textBox2.Text;
            string phai = comboBox1.SelectedItem.ToString();
            DateTime birthDate = dateTimePicker1.Value;
            string day = birthDate.Day.ToString();
            if (day.Length== 1)
            {
                day = '0' + day;
            }
    
            string month = birthDate.Month.ToString();
            if (month.Length == 1)
            {
                month = "0" + month;
            }
            string year = birthDate.Year.ToString();

            string diaChi = textBox3.Text;
            string dt = textBox4.Text;
            string mact = comboBox2.SelectedItem.ToString();

            string sql = $"update qlth.qlth_sinhvien  " +
                $"set hoten = N'{hoten}', phai = N'{phai}', ngsinh = '{year}-{month}-{day}', diachi = N'{diaChi}', dt = '{dt}', mact = '{mact}' " +
                $"where masv = {this.Mssv}";
            //MessageBox.Show(sql);
            OracleCommand command = new OracleCommand(sql, Session.Instance.OracleConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thông tin thành công.");

            this.Close();
        }
    }
}

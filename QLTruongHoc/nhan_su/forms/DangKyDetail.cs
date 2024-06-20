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
    public partial class DangKyDetail : Form
    {

        public DangKyDetail()
        {
            InitializeComponent();
        }
        public DangKyDetail(string? mahp, string? tenhp, string? nam, decimal? hocky, string? chuongtrinh, string? ngayhoc, string? tiet,
            decimal? mssv, string? hoten, decimal? diemqt, decimal? diemthi, decimal? diemck, decimal? diemtk)
        {
            InitializeComponent();
            textBox1.Text = mahp;
            textBox2.Text = tenhp;
            textBox3.Text = nam;
            textBox4.Text = hocky.ToString();
            textBox5.Text = chuongtrinh;
            textBox6.Text = ngayhoc;
            textBox7.Text = tiet;
            textBox9.Text = mssv.ToString();
            textBox8.Text = hoten;
            diemQtTextBox.Text = diemqt.ToString();
            diemThiTextBox.Text = diemthi.ToString();
            diemCkTextBox.Text = diemck.ToString();
            diemTkTextBox.Text = diemtk.ToString();

        }

        private void DangKyDetail_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string diemThi = diemThiTextBox.Text;
                string diemQt = diemQtTextBox.Text;
                string diemCk = diemCkTextBox.Text;
                string diemTk = diemTkTextBox.Text;

                if (string.IsNullOrEmpty(diemThi) || string.IsNullOrEmpty(diemQt) || string.IsNullOrEmpty(diemCk))
                {
                    diemTk = "NULL";    
                } else
                {
                    decimal diemThiDecimal = decimal.Parse(diemThi);
                    decimal diemQtDecimal = decimal.Parse(diemQt); 
                    decimal diemCkDecimal = decimal.Parse(diemCk);
                    decimal diemTkDecimal = (diemThiDecimal + diemQtDecimal + diemCkDecimal) / 3;
                    diemTk = diemTkDecimal.ToString("F2");
                    
                }

                string sql = $"UPDATE QLTH.QLTH_DANGKY " +
                $"SET DIEMTHI = {diemThiTextBox.Text}, DIEMQT = {diemQtTextBox.Text}, DIEMCK = {diemCkTextBox.Text}, DIEMTK = {diemTk} " +
                $"WHERE MASV = {textBox9.Text} " +
                $"AND MAHP = '{textBox1.Text}' " +
                $"AND HK = {textBox4.Text} " +
                $"AND NAM = '{textBox3.Text}' " +
                $"AND MACT = '{textBox5.Text}'";
                //MessageBox.Show( sql );
                OracleCommand command = new OracleCommand(sql, Session.Instance.OracleConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Cập nhật điểm thành công.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

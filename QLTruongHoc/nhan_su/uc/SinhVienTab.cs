using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.nhan_su.forms;
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

namespace QLTruongHoc.nhan_su.uc
{
    public partial class SinhVienTab : UserControl
    {
        public SinhVienTab()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string alterSessionSql = $"ALTER SESSION SET NLS_DATE_FORMAT = 'YYYY-MM-DD'";
            //OracleCommand cmd = new OracleCommand(alterSessionSql, Session.Instance.OracleConnection);
            //cmd.ExecuteNonQuery();
            string sql = "select * from qlth.qlth_sinhvien";
            OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            CustomizeColumnHeaders();
        }

        private void CustomizeColumnHeaders()
        {
            // Change column headers to custom names
            dataGridView1.Columns["MASV"].HeaderText = "Mã SV";
            dataGridView1.Columns["HOTEN"].HeaderText = "Họ và Tên";
            dataGridView1.Columns["PHAI"].HeaderText = "Giới Tính";
            dataGridView1.Columns["NGSINH"].HeaderText = "Ngày Sinh";
            dataGridView1.Columns["DIACHI"].HeaderText = "Địa Chỉ";
            dataGridView1.Columns["DT"].HeaderText = "Điện Thoại";
            dataGridView1.Columns["MACT"].HeaderText = "Mã Chương Trình";
            dataGridView1.Columns["MANGANH"].HeaderText = "Mã Ngành";
            dataGridView1.Columns["SOTCTL"].HeaderText = "Tín Chỉ TL";
            dataGridView1.Columns["DTBTL"].HeaderText = "Điểm TBTL";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            int mssv = (int)row.Cells["MASV"].Value;
            UpdateSinhVien updateSinhVien = new UpdateSinhVien(mssv);
            updateSinhVien.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertSinhVien insertSinhVien = new();
            insertSinhVien.Show();
        }
    }
}

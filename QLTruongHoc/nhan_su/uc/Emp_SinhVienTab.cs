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
    public partial class Emp_SinhVienTab : UserControl
    {
        public Emp_SinhVienTab()
        {
            InitializeComponent();

            if (Session.Instance.Role == "Giáo vụ")
            {
                InsertBtn.Visible = true;
                DKHPBtn.Visible = true;
            }
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

            if (Session.Instance.Role == "Giáo vụ")
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

        }


        private void ViewBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = "select * from qlth.qlth_sinhvien";
                OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                CustomizeColumnHeaders();
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu!");
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            InsertSinhVien insertSinhVien = new();
            insertSinhVien.Show();
        }

        private void DKHPBtn_Click(object sender, EventArgs e)
        {
            DangKyHocPhan dkhp = new DangKyHocPhan();
            dkhp.Show();
        }
    }
}

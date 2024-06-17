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
    public partial class Emp_HocPhanTab : UserControl
    {
        public Emp_HocPhanTab()
        {
            InitializeComponent();

            if (Session.Instance.Role == "Giáo vụ")
            {
                InsertBtn.Visible = true;
                UpdateBtn.Visible = true;
            }
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT hp.mahp, hp.tenhp, hp.sotc, hp.stlt, hp.stth, hp.sosvtd, dv.tendv \r\nFROM QLTH.QLTH_HOCPHAN hp JOIN QLTH.QLTH_DONVI dv on hp.madv = dv.madv";
            OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //CustomizeColumnHeaders();
        }

        private void CustomizeColumnHeaders()
        {
            // Change column headers to custom names
            dataGridView1.Columns["MAHP"].HeaderText = "Mã Học Phần";
            dataGridView1.Columns["TENHP"].HeaderText = "Tên Học Phần";
            dataGridView1.Columns["SOTC"].HeaderText = "Số Tín Chỉ";
            dataGridView1.Columns["STLT"].HeaderText = "Số Tiết Lý Thuyết";
            dataGridView1.Columns["STTH"].HeaderText = "Số Tiết Thực Hành";
            dataGridView1.Columns["SOSVTD"].HeaderText = "Số Lượng Tối Đa";
            dataGridView1.Columns["TENDV"].HeaderText = "Đơn Vị";

            // change column size
            dataGridView1.Columns["MAHP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["TENHP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["SOTC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["STLT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["STTH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["SOSVTD"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["TENDV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string search = searchTextBox.Text;
            search = search.ToLower();
            if (search.Length > 0)
            {
                string sql = $"SELECT hp.mahp, hp.tenhp, hp.sotc, hp.stlt, hp.stth, hp.sosvtd, dv.tendv \r\nFROM QLTH.QLTH_HOCPHAN hp JOIN QLTH.QLTH_DONVI dv on hp.madv = dv.madv WHERE LOWER(hp.mahp) LIKE LOWER('%{search}%') or LOWER(hp.tenhp) LIKE LOWER(N'%{search}%')";
                OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                CustomizeColumnHeaders();
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            InsertHocPhan form = new InsertHocPhan();
            form.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn học phần muốn cập nhật.");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string mahp = row.Cells["MAHP"].Value as string;
            UpdateHocPhan form = new UpdateHocPhan(mahp);
            form.Show();
        }
    }
}

using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.nhan_su.forms;
using QLTruongHoc.utils;
using System.Data;


namespace QLTruongHoc.nhan_su.uc
{
    public partial class Emp_DangKyTab : UserControl
    {
        public Emp_DangKyTab()
        {
            InitializeComponent();
            if (Session.Instance.Role == "Giáo vụ")
            {
                refreshBtn.Visible = false;
                button1.Visible = false;
            }
            else if (Session.Instance.Role == "Giảng viên" || Session.Instance.Role == "Trưởng đơn vị" || Session.Instance.Role == "Trưởng khoa")
            {
                UpdateBtn.Visible = true;
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            string sql = "select dk.mahp, hp.tenhp,dk.hk, dk.nam, dk.mact, dk.ngayhoc, dk.tiet,sv.masv, sv.hoten, dk.diemthi, dk.diemqt, dk.diemck, dk.diemtk\r\nfrom qlth.qlth_dangky dk join qlth.qlth_sinhvien sv on dk.masv = sv.masv\r\njoin qlth.qlth_hocphan hp on dk.mahp = hp.mahp";
            //MessageBox.Show(sql);
            OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            CustomizeColumnHeaders();
        }

        private void CustomizeColumnHeaders()
        {
            // Change column headers to custom names
            dataGridView1.Columns["MAHP"].HeaderText = "Mã Học Phần";
            dataGridView1.Columns["TENHP"].HeaderText = "Tên Học Phần";
            dataGridView1.Columns["NAM"].HeaderText = "Năm";
            dataGridView1.Columns["MACT"].HeaderText = "Chương Trình";
            dataGridView1.Columns["HK"].HeaderText = "Học Kỳ";
            dataGridView1.Columns["NGAYHOC"].HeaderText = "Ngày Học";
            dataGridView1.Columns["TIET"].HeaderText = "Tiết";
            dataGridView1.Columns["DIEMTHI"].HeaderText = "Điểm Thi";
            dataGridView1.Columns["DIEMQT"].HeaderText = "Điểm QT";
            dataGridView1.Columns["DIEMCK"].HeaderText = "Điểm CK";
            dataGridView1.Columns["DIEMTK"].HeaderText = "Điểm TK";
            dataGridView1.Columns["MASV"].HeaderText = "Mã SV";
            dataGridView1.Columns["HOTEN"].HeaderText = "Họ Tên";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select PC.MAGV, PC.MAHP, HP.TENHP, PC.HK, PC.NAM, CT.TENCT, PC.NGAYHOC, PC.TIET\r\nfrom qlth.uv_qlth_xemphanconggiangday PC JOIN QLTH.qlth_hocphan HP ON PC.MAHP = HP.MAHP\r\nJOIN QLTH.QLTH_CHUONGTRINH CT ON CT.MACT = PC.MACT";

            /* listView1.Columns.Clear();
             listView1.Columns.Add("Danh Sách Lớp", -2, HorizontalAlignment.Left);*/  // -2 sets width to fit contents

            listView1.Items.Clear();


            try
            {
                OracleCommand command = new OracleCommand(sql, Session.Instance.OracleConnection);
                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    string combined = string.Join(" / ",
                        reader["TENHP"].ToString(),
                        reader["HK"].ToString(),
                        reader["NAM"].ToString(),
                        reader["TENCT"].ToString(),
                        reader["NGAYHOC"].ToString(),
                        reader["TIET"].ToString());
                    ListViewItem item = new ListViewItem(combined);

                    listView1.Items.Add(item);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Hệ Thống: " + ex.Message);
            }
        }

        private void listView1_MouseMove(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hitTestInfo = listView1.HitTest(e.Location);
            if (hitTestInfo.Item != null)
            {
                listViewToolTip.SetToolTip(listView1, hitTestInfo.Item.Text);
            }
            else
            {
                listViewToolTip.SetToolTip(listView1, ""); // Hide tooltip if not over an item
            }
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Access the selected item(s)
                ListViewItem selectedItem = listView1.SelectedItems[0]; // Access first selected item
                string selectedText = selectedItem.Text;

                // Perform actions based on selection

                string[] items = selectedText.Split(" / ", StringSplitOptions.RemoveEmptyEntries);
                string sql = $"select dk.mahp, hp.tenhp,dk.hk, dk.nam, dk.mact, dk.ngayhoc, dk.tiet,sv.masv, sv.hoten, dk.diemthi, dk.diemqt, dk.diemck, dk.diemtk\r\nfrom qlth.qlth_dangky dk join qlth.qlth_sinhvien sv on dk.masv = sv.masv " +
                    $"join qlth.qlth_hocphan hp on dk.mahp = hp.mahp\r\njoin qlth.qlth_chuongtrinh ct on dk.mact = ct.mact " +
                    $"where hp.tenhp = '{items[0]}' " +
                    $"and dk.hk = {items[1]} " +
                    $"and dk.nam = '{items[2]}' " +
                    $"and ct.tenct = '{items[3]}' " +
                    $"and dk.ngayhoc = '{items[4]}' " +
                    $"and dk.tiet = '{items[5]}' ";

                OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                CustomizeColumnHeaders();

            }
        }

        private void refreshBtn_Click_1(object sender, EventArgs e)
        {
            if (Session.Instance.Role == "Giáo vụ")
            {
                string sql = "select dk.mahp, hp.tenhp,dk.hk, dk.nam, dk.mact, dk.ngayhoc, dk.tiet,sv.masv, sv.hoten, dk.diemthi, dk.diemqt, dk.diemck, dk.diemtk\r\nfrom qlth.qlth_dangky dk join qlth.qlth_sinhvien sv on dk.masv = sv.masv\r\njoin qlth.qlth_hocphan hp on dk.mahp = hp.mahp";
                //MessageBox.Show(sql);
                OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                CustomizeColumnHeaders();
            }

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên để cập nhật điểm.");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            decimal? diemthi = row.Cells["DIEMTHI"].Value == DBNull.Value ? null : (decimal)row.Cells["DIEMTHI"].Value;

            DangKyDetail dangKyDetail = new DangKyDetail(
                mahp: row.Cells["MAHP"].Value.ToString(),
                tenhp: row.Cells["TENHP"].Value.ToString(),
                nam: row.Cells["NAM"].Value.ToString(),
                hocky: row.Cells["HK"].Value == DBNull.Value ? null : (decimal)row.Cells["HK"].Value,
                chuongtrinh: row.Cells["MACT"].Value.ToString(),
                ngayhoc: row.Cells["NGAYHOC"].Value.ToString(),
                tiet: row.Cells["TIET"].Value.ToString(),
                mssv: row.Cells["MASV"].Value == DBNull.Value ? null : (int)row.Cells["MASV"].Value,
                hoten: row.Cells["HOTEN"].Value.ToString(),
                diemqt: row.Cells["DIEMQT"].Value == DBNull.Value ? null : (decimal)row.Cells["DIEMQT"].Value,
                diemthi: row.Cells["DIEMTHI"].Value == DBNull.Value ? null : (decimal)row.Cells["DIEMTHI"].Value,
                diemck: row.Cells["DIEMCK"].Value == DBNull.Value ? null : (decimal)row.Cells["DIEMCK"].Value,
                diemtk: row.Cells["DIEMTK"].Value == DBNull.Value ? null : (decimal)row.Cells["DIEMTK"].Value);

            dangKyDetail.Show();

            dataGridView1.DataSource = new DataTable();
        }
    }
}

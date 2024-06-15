using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.nhan_su.forms;
using QLTruongHoc.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTruongHoc.nhan_su.uc
{
    public partial class PhanCongTab : UserControl
    {
        public PhanCongTab()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select PC.MAGV, PC.MAHP, HP.TENHP, PC.HK, PC.NAM, CT.TENCT, PC.NGAYHOC, PC.TIET\r\nfrom qlth.uv_qlth_xemphanconggiangday PC JOIN QLTH.qlth_hocphan HP ON PC.MAHP = HP.MAHP\r\nJOIN QLTH.QLTH_CHUONGTRINH CT ON CT.MACT = PC.MACT";
            if (Session.Instance.Role == "Giáo vụ" || Session.Instance.Role == "Trưởng đơn vị")
            {
                sql = "select PC.MAGV, PC.MAHP, HP.TENHP, PC.HK, PC.NAM, CT.TENCT, PC.NGAYHOC, PC.TIET\r\nfrom qlth.QLTH_PHANCONG PC JOIN QLTH.qlth_hocphan HP ON PC.MAHP = HP.MAHP\r\nJOIN QLTH.QLTH_CHUONGTRINH CT ON CT.MACT = PC.MACT";
            }

            OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            CustomizeColumnHeaders();
        }

        private void CustomizeColumnHeaders()
        {
            // Change column headers to custom names
            dataGridView1.Columns["MAGV"].HeaderText = "Mã GV";
            dataGridView1.Columns["TENHP"].HeaderText = "Tên Học Phần";
            dataGridView1.Columns["NAM"].HeaderText = "Năm";
            dataGridView1.Columns["TENCT"].HeaderText = "Chương Trình";
            dataGridView1.Columns["HK"].HeaderText = "Học Kỳ";
            dataGridView1.Columns["MAHP"].HeaderText = "Mã Học Phần";
            dataGridView1.Columns["NGAYHOC"].HeaderText = "Lịch Học";
            dataGridView1.Columns["TIET"].HeaderText = "Tiết";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            string chuongTrinh = row.Cells["TENCT"].Value as string;
            string mahp = row.Cells["MAHP"].Value as string;
            decimal hk = (decimal)row.Cells["HK"].Value;
            string nam = row.Cells["NAM"].Value as string;
            string ngayHoc = row.Cells["NGAYHOC"].Value as string;
            string tiet = row.Cells["TIET"].Value as string;

            UpdatePhanCong updatePhanCong = new UpdatePhanCong(mahp, hk, nam, ngayHoc, tiet, chuongTrinh);
            updatePhanCong.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dv = DbCommand.getUserDv();
            MessageBox.Show(dv);
            if (dv != "")
            {
                InsertPhanCong insertPhanCong = new InsertPhanCong(dv);
                insertPhanCong.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            MessageBox.Show(row.Cells["MAHP"].Value as string);

        }
    }
}

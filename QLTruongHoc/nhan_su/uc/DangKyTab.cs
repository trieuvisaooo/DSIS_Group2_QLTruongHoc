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

namespace QLTruongHoc.nhan_su.uc
{
    public partial class DangKyTab : UserControl
    {
        public DangKyTab()
        {
            InitializeComponent();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            string sql = "select dk.mahp, hp.tenhp,dk.hk, dk.nam, dk.mact, dk.ngayhoc, dk.tiet,sv.masv, sv.hoten, dk.diemthi, dk.diemqt, dk.diemck, dk.diemtk\r\nfrom qlth.qlth_dangky dk join qlth.qlth_sinhvien sv on dk.masv = sv.masv\r\njoin qlth.qlth_hocphan hp on dk.mahp = hp.mahp";
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
            
            listView1.Items.Clear();

            try
            {
                using (OracleConnection connection = Session.Instance.OracleConnection)
                {
                    OracleCommand command = new OracleCommand(sql, connection);

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["TENHP"].ToString());
                            item.SubItems.Add(reader["HK"].ToString());
                            item.SubItems.Add(reader["NAM"].ToString());
                            item.SubItems.Add(reader["TENCT"].ToString());
                            item.SubItems.Add(reader["NGAYHOC"].ToString());
                            item.SubItems.Add(reader["TIET"].ToString());

                            // Combine sub-items into a single string to display as one item in the ListView
                            string combined = string.Join(" - ",
                                reader["TENHP"].ToString(),
                                reader["HK"].ToString(),
                                reader["NAM"].ToString(),
                                reader["TENCT"].ToString(),
                                reader["NGAYHOC"].ToString(),
                                reader["TIET"].ToString());

                            item.Text = combined;
                            item.SubItems.Clear();

                            // Add the item to the ListView
                            listView1.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Hệ Thống: " + ex.Message);
            }
        }
    }
}

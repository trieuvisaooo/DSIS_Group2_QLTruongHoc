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
    public partial class PhanCongTab : UserControl
    {
        public PhanCongTab()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select PC.MAGV, PC.MAHP, HP.TENHP, PC.HK, PC.NAM, CT.TENCT, PC.NGAYHOC, PC.TIET\r\nfrom qlth.uv_qlth_xemphanconggiangday PC JOIN QLTH.qlth_hocphan HP ON PC.MAHP = HP.MAHP\r\nJOIN QLTH.QLTH_CHUONGTRINH CT ON CT.MACT = PC.MACT";
            if (Session.Instance.Role == "Giáo vụ")
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
    }
}

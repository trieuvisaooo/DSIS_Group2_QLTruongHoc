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
    public partial class UpdatePhanCong : Form
    {
        public string MaHp { get; set; }
        public decimal Hk { get; set; }
        public string Nam { get; set; }
        public string NgayHoc { get; set; }
        public string Tiet { get; set; }
        public string ChuongTrinh { get; set; }

        public UpdatePhanCong()
        {
            InitializeComponent();
        }

        public UpdatePhanCong(string maHp, decimal hk, string nam, string ngayHoc, string tiet, string chuongTrinh)
        {
            InitializeComponent();

            MaHp = maHp;
            Hk = hk;
            Nam = nam;
            NgayHoc = ngayHoc;
            Tiet = tiet;
            ChuongTrinh = chuongTrinh;

            FetchPhanCongData();
        }

        private void FetchPhanCongData()
        {
            string sql = $"select pc.mahp, hp.tenhp, pc.hk, pc.nam, pc.ngayhoc, pc.tiet, pc.magv, pc.mact " +
                $"from qlth.qlth_phancong pc join qlth.qlth_hocphan hp on pc.mahp = hp.mahp " +
                $"where pc.mact in (select mact from qlth.qlth_chuongtrinh where tenct = '{ChuongTrinh}') " +
                $"and pc.mahp = '{MaHp}' " +
                $"and pc.hk = {Hk} " +
                $"and pc.nam = '{Nam}' " +
                $"and pc.ngayhoc = '{NgayHoc}' " +
                $"and pc.tiet = '{Tiet}'";

            OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                textBox1.Text = reader["MAHP"].ToString();
                textBox2.Text = reader["TENHP"].ToString();
                textBox3.Text = reader["HK"].ToString();
                textBox4.Text = reader["NAM"].ToString();
                textBox5.Text = reader["NGAYHOC"].ToString();
                textBox6.Text = reader["TIET"].ToString();
                textBox7.Text = reader["MAGV"].ToString();
                textBox8.Text = reader["MACT"].ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"update qlth.qlth_phancong pc " +
                $"set pc.magv = {textBox7.Text} " +
                $"where pc.mact = '{textBox8.Text}' " +
                $"and pc.mahp = '{textBox1.Text}' " +
                $"and pc.hk = {textBox3.Text} " +
                $"and pc.nam = '{textBox4.Text}' " +
                $"and pc.ngayhoc = '{textBox5.Text}' " +
                $"and pc.tiet = '{textBox6.Text}'";

                //MessageBox.Show(sql);
                OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập Nhật Thành Công");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

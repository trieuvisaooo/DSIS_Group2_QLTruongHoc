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
    public partial class HocPhanTab : UserControl
    {
        public HocPhanTab()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = searchTextBox.Text;
            search = search.ToLower();
            if (search.Length > 0)
            {
                string sql = $"SELECT hp.mahp, hp.tenhp, hp.sotc, hp.stlt, hp.stth, hp.sosvtd, dv.tendv \r\nFROM QLTH.QLTH_HOCPHAN hp JOIN QLTH.QLTH_DONVI dv on hp.madv = dv.madv WHERE hp.mahp LIKE LOWER('%{search}%') or hp.tenhp LIKE LOWER('%{search}%')";
                OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                CustomizeColumnHeaders();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InsertHocPhan form= new InsertHocPhan();
            form.Show();
        }
    }
}

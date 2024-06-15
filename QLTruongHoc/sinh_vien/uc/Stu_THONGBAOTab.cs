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

namespace QLTruongHoc.sinh_vien.uc
{
    public partial class Stu_THONGBAOTab : UserControl
    {
        public Stu_THONGBAOTab()
        {
            InitializeComponent();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT MATB, NOIDUNG FROM QLTH.QLTH_THONGBAO";
                OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                CustomizeColumnHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CustomizeColumnHeaders()
        {
            // Change column headers to custom names
            dataGridView1.Columns["MATB"].HeaderText = "Mã Thông Báo";
            dataGridView1.Columns["NOIDUNG"].HeaderText = "Nội Dung Thông Báo";
            // Change column width
            dataGridView1.Columns["MATB"].Width = 280;
            //dataGridView1.Columns["NOIDUNG"].Width = ;

        }
    }
}

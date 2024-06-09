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

namespace QLTruongHoc.NhanSu
{
    public partial class NhanSuTab : UserControl
    {

        public NhanSuTab()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NhanSu_tab_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = searchTextBox.Text;
            if (search.Length > 0)
            {
                string sql = $"SELECT * FROM QLTH.qlth_nhansu WHERE HOTEN LIKE '%{search}%'";
                OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                NhanSu_Table.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM QLTH.qlth_nhansu";
            OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            NhanSu_Table.DataSource = dt;
        }
    }
}

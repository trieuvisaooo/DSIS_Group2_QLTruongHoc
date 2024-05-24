using Oracle.ManagedDataAccess.Client;
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
    public partial class NhanSu_tab : UserControl
    {
        private static OracleConnection conNow = Login.con;

        public NhanSu_tab()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NhanSu_tab_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM QLTH.qlth_nhansu";
            OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
            DataTable dt = new DataTable();
            da.Fill(dt);
            NhanSu_Table.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = searchTextBox.Text;
            if (search.Length > 0)
            {
                string sql = $"SELECT * FROM QLTH.qlth_nhansu WHERE HOTEN LIKE '%{search}%'";
                OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
                DataTable dt = new DataTable();
                da.Fill(dt);
                NhanSu_Table.DataSource = dt;
            }
        }
    }
}

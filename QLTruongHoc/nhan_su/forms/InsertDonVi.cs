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
    public partial class InsertDonVi : Form
    {
        public InsertDonVi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string madv = textBox1.Text;
            string tendv = textBox2.Text;

            string sql = $"insert into qlth.qlth_donvi (madv, tendv) " +
                $"values('{madv}', N'{tendv}')";

            OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
            cmd.ExecuteNonQuery();

            MessageBox.Show($"Tạo đơn vị {tendv} thành công");
            this.Close();
        }
    }
}

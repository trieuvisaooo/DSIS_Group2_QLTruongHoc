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
    public partial class InsertKHMO : Form
    {
        public InsertKHMO()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string hocPhanText = comboBox1.SelectedItem.ToString();
            string[] info = hocPhanText.Split('/');
            string ngayHoc = comboBox3.SelectedItem.ToString();
            string tiet = comboBox4.SelectedItem.ToString();
            string giangVien = comboBox2.SelectedItem.ToString();
            string magv = giangVien.Substring(0, 6);

            string sql = $"insert into qlth.qlth_phancong(magv, mahp, hk, nam, mact, ngayhoc, tiet) " +
                $"values ({magv}, '{info[0]}' , {info[2]}, '{info[3]}', '{info[4]}', '{ngayHoc}', '{tiet}')";

            OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Tạo mới phân công thành công");
            this.Close();

        }
    }
}

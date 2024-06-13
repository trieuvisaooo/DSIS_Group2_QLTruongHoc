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
    public partial class DangKyDetail : Form
    {

        public DangKyDetail()
        {
            InitializeComponent();
        }
        public DangKyDetail(string? mahp, string? tenhp, string? nam, decimal? hocky, string? chuongtrinh, string? ngayhoc, string? tiet,
            decimal? diemqt, decimal? diemthi, decimal? diemck, decimal? diemtk)
        {
            InitializeComponent();
            textBox1.Text = mahp;
            textBox2.Text = tenhp;
            textBox3.Text = nam;
            textBox4.Text = hocky.ToString();
            textBox5.Text = chuongtrinh;
            textBox6.Text = ngayhoc;
            textBox7.Text = tiet;
            diemQtTextBox.Text = diemqt.ToString();
            diemThiTextBox.Text = diemthi.ToString();
            diemCkTextBox.Text = diemck.ToString();
            diemTkTextBox.Text = diemtk.ToString();
        }

        private void DangKyDetail_Load(object sender, EventArgs e)
        {
            MessageBox.Show(diemThiTextBox.Text);
        }
    }
}

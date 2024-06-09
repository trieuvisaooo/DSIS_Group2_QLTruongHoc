using QLTruongHoc.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTruongHoc.nhan_su
{
    public partial class EmpHome : Form
    {

        public EmpHome()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            DialogResult dg = MessageBox.Show("Bạn có muốn kết thúc chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dg)
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default: break;
            }
        }

        private void EmpHome_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage2);
        }

        private void EmpHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

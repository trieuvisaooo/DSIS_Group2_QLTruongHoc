using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void EmpHome_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}

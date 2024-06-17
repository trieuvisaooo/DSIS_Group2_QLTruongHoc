using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTruongHoc.sinh_vien
{
    public partial class StuHome : Form
    {
        Login CurLogin = new Login();
        bool isLogout = false;
        public StuHome(Login curLogin)
        {
            InitializeComponent();
            CurLogin = curLogin;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            isLogout = true;
            this.Close();

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            DialogResult dg;
            if (isLogout)
            {
                dg = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                dg = MessageBox.Show("Bạn có muốn kết thúc chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            switch (dg)
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default: 
                    if (isLogout)
                    {
                        CurLogin.con.Close();
                        CurLogin.Show();
                    }
                    break;
            }
        }

        private void StuHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isLogout)
            {
                Application.Exit();
            }
        }
    }
}
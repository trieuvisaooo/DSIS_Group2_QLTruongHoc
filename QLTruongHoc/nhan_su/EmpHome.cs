
using QLTruongHoc.utils;

namespace QLTruongHoc.nhan_su
{
    public partial class EmpHome : Form
    {
        Login CurLogin = new Login();
        bool isLogout = false;
        public EmpHome(Login curLogin)
        {
            InitializeComponent();
            CurLogin = curLogin;

            if (Session.Instance.Role == "Nhân viên cơ bản")
            {
                NhanSuTabControl.TabPages.Remove(dangKyTabPage);
                NhanSuTabControl.TabPages.Remove(phanCongTab);
                NhanSuTabControl.TabPages.Remove(nhanSuTabpage);
                NhanSuTabControl.TabPages.Remove(xemCSDLTabpage);
            }
            else if (Session.Instance.Role == "Giảng viên" || Session.Instance.Role == "Giáo vụ" || Session.Instance.Role == "Trưởng đơn vị")
            {
                NhanSuTabControl.TabPages.Remove(nhanSuTabpage);
                NhanSuTabControl.TabPages.Remove(xemCSDLTabpage);
            }
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

        private void EmpHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isLogout)
            {
                Application.Exit();
            }
        }

    }
}
namespace QLTruongHoc
{
    public partial class DBAHome : Form
    {
        Login CurLogin = new Login();
        bool isLogout = false;
        public DBAHome(Login curLogin)
        {
            InitializeComponent();
            CurLogin = curLogin;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            DialogResult dg;
            if (isLogout)
            {
                dg = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            } else {
                dg = MessageBox.Show("Bạn có muốn kết thúc chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            switch (dg)
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default: break;
            }
        }


        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            isLogout = true;
            this.Close();
            CurLogin.con.Close();
            CurLogin.Show();
        }

        private void DBAHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isLogout)
            {
                Application.Exit();
            }
        }
    }
}

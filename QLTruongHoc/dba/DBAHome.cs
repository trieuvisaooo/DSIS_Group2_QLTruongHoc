namespace QLTruongHoc
{
    public partial class DBAHome : Form
    {
        public DBAHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void sysPrivs1_Load(object sender, EventArgs e)
        {

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



        private void DBA_Home_Closing(object sender, FormClosingEventArgs e)
        {

        }

        private void tablesViewsTab_Click(object sender, EventArgs e)
        {

        }

        private void tablesViewsTab_Click_1(object sender, EventArgs e)
        {

        }

        private void DBA_Home_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

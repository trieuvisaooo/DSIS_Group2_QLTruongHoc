namespace QLTruongHoc
{
    public partial class DBA_Home : Form
    {
        public DBA_Home()
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



        private void DBA_Home_Closing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn kết thúc chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tablesViewsTab_Click(object sender, EventArgs e)
        {

        }

        private void tablesViewsTab_Click_1(object sender, EventArgs e)
        {

        }
    }
}

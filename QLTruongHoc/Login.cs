using Oracle.ManagedDataAccess.Client;


namespace QLTruongHoc
{
    public partial class Login : Form
    {
        public static OracleConnection con;
        public static string username;
        public static string password;
        public static string role;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (username_txtbox.Text.Length == 0)
            {
                MessageBox.Show("TÊN ĐĂNG NHẬP không được để trống.");
                return;
            }
            if (psw_txtbox.Text.Length == 0)
            {
                MessageBox.Show("MẬT KHẨU không được để trống.");
                return;
            }
            if (role_combox.Text.Length == 0)
            {
                MessageBox.Show("VAI TRÒ không được để trống.");
                return;
            }
            username = username_txtbox.Text;
            //Check username, password and role
            try
            {
                string connectionString = "";
                if (role_combox.Text == "Quản trị viên")
                    connectionString = @"DATA SOURCE = localhost:1522/xe;DBA Privilege=SYSDBA; USER ID=" + username_txtbox.Text + ";PASSWORD=" + psw_txtbox.Text;
                
                    /*connectionString = @"DATA SOURCE = 172.16.112.128:1521/xe; USER ID=" + username_txtbox.Text + ";PASSWORD=" + psw_txtbox.Text;*/
                
                    connectionString = @"DATA SOURCE = localhost:1522/xe; USER ID=" + username_txtbox.Text + ";PASSWORD=" + psw_txtbox.Text;


                con = new OracleConnection();
                con.ConnectionString = connectionString;
                con.Open();


                if (role_combox.Text == "Quản trị viên")
                {

                    OracleCommand command = new OracleCommand("alter session set \"_ORACLE_SCRIPT\"=true", con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Connect với Oracle thành công!");
                    DBA_Home dba = new DBA_Home();
                    dba.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hiện tại chỉ kết nối với role là DBA!");
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}

using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.nhan_su;
using System.Configuration;


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
            con = new OracleConnection();
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
                var appSettings = ConfigurationManager.AppSettings;
                string hostname = appSettings["hostname"] ?? "localhost";
                string port = appSettings["port"] ?? "1521";

                if (role_combox.Text == "Quản trị viên")
                    /*connectionString = @"DATA SOURCE = localhost:1522/xe;DBA Privilege=SYSDBA; USER ID=" + username_txtbox.Text + ";PASSWORD=" + psw_txtbox.Text;*/

                    connectionString = @$"DATA SOURCE = {hostname}:{port}/XEPDB1;DBA Privilege=SYSDBA; USER ID=" + username_txtbox.Text + ";PASSWORD=" + psw_txtbox.Text;
                    
                else
                {
                    connectionString = @$"DATA SOURCE = {hostname}:{port}/XEPDB1; USER ID=" + username_txtbox.Text + ";PASSWORD=" + psw_txtbox.Text;
                    /*MessageBox.Show("Hiện tại chỉ đăng nhập với tư cách quản trị viên!");
                    return;*/
                }

                con.ConnectionString = connectionString;
                con.Open();


                if (role_combox.Text == "Quản trị viên")
                {

                    OracleCommand command = new OracleCommand("alter session set \"_ORACLE_SCRIPT\"=true", con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Connect với tư cách là quản trị viên thành công!");
                    DBAHome dba = new DBAHome();
                    dba.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Connect với tư cách là nhân viên thành công!");
                    EmpHome empHome = new EmpHome();
                    empHome.Show();
                    this.Hide();
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void role_combox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

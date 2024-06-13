using Microsoft.EntityFrameworkCore.Query.Internal;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using QLTruongHoc.nhan_su;
using QLTruongHoc.sinh_vien;
using QLTruongHoc.utils;
using System.Configuration;
using System.DirectoryServices.Protocols;


namespace QLTruongHoc
{
    public partial class Login : Form
    {
        private OracleConnection con;
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
                string qlth = appSettings["sysdba"] ?? "QLTH";
                string pwd = appSettings["pwd"] ?? "QLTH";

                string qlthConnectionString = @$"DATA SOURCE = {hostname}:{port}/XEPDB1;DBA Privilege=SYSDBA; USER ID=" + qlth + ";PASSWORD=" + pwd;

                if (role_combox.Text == "Quản trị viên")
                {
                    connectionString = @$"DATA SOURCE = {hostname}:{port}/XEPDB1;DBA Privilege=SYSDBA; USER ID=" + username_txtbox.Text + ";PASSWORD=" + psw_txtbox.Text;
                    con.ConnectionString = connectionString;
                    con.Open();
                    Session.Instance.OracleConnection = con;
                    MessageBox.Show("Connect với tư cách là quản trị viên thành công!");
                    DBAHome dba = new DBAHome();
                    dba.Show();
                    this.Hide();
                }
                else
                {
                    connectionString = @$"DATA SOURCE = {hostname}:{port}/XEPDB1; USER ID=" + username_txtbox.Text + ";PASSWORD=" + psw_txtbox.Text;
                    var cmd = new OracleCommand();
                    var qlthOracleConnection = new OracleConnection();
                    qlthOracleConnection.ConnectionString = qlthConnectionString;
                    qlthOracleConnection.Open();
                    cmd.Connection = qlthOracleConnection;
                    cmd.CommandText = "QLTH.USER_LOGIN";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("USRNAME", username_txtbox.Text);
                    cmd.Parameters.Add("USR_ROLE", OracleDbType.NVarchar2).Value = role_combox.Text;
                    var outputParam = cmd.Parameters.Add("CNT", OracleDbType.Int64);
                    outputParam.Direction = System.Data.ParameterDirection.Output;

                    cmd.ExecuteNonQuery();
                    
                    OracleDecimal oracleDecimal = (OracleDecimal)cmd.Parameters["CNT"].Value;
                    int result = oracleDecimal.ToInt32();

                    qlthOracleConnection.Close();  

                    if (result == 0)
                    {
                        MessageBox.Show("Tài khoản không tồn tại!");
                    }
                    else if (result == 1)
                    {
                        MessageBox.Show("Login NS");
                        con.ConnectionString = connectionString;
                        con.Open();

                        Session.Instance.Username = username_txtbox.Text;
                        Session.Instance.Password = psw_txtbox.Text;
                        Session.Instance.Role = role_combox.Text;
                        Session.Instance.OracleConnection = con;

                        MessageBox.Show("Connect với tư cách là nhân sự thành công!");
                        EmpHome empHome = new EmpHome();
                        empHome.Show();
                        this.Hide();
                    } 
                    else if (result == 2)
                    {
                        MessageBox.Show("Login SV");
                        con.ConnectionString = connectionString;
                        con.Open();

                        Session.Instance.Username = username_txtbox.Text;
                        Session.Instance.Password = psw_txtbox.Text;
                        Session.Instance.Role = role_combox.Text;
                        Session.Instance.OracleConnection = con;

                        MessageBox.Show("Connect với tư cách là sinh viên thành công!");
                        StuHome stuHome = new StuHome();
                        stuHome.Show();
                        this.Hide();

                    }

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

using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace QLTruongHoc
{
    public partial class DBA_CreateUser : Form
    {
        public static OracleConnection conNow = Login.con;

        public DBA_CreateUser()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string username = userbox.Text.ToString();
            string password = passbox.Text.ToString();
            string confirm_psw = confirm_psw_txtbox.Text.ToString();

            if (username.Length == 0)
            {
                MessageBox.Show("TÊN ĐĂNG NHẬP không được để trống.");
                return;
            } else if (password.Length == 0)
            {
                MessageBox.Show("MẬT KHẨU không được để trống.");
                return;
            } else if (confirm_psw.Length == 0)
            {
                MessageBox.Show("Chưa xác nhận lại MẬT KHẨU.");
                return;
            } else if(password != confirm_psw)
            {
                MessageBox.Show("MẬT KHẨU không trùng khớp.");
                return;
            } else
            {
                try
                {
                    var cmd = new OracleCommand();
                    cmd.Connection = conNow;
                    cmd.CommandText = "QLTH.AddUser_Proc";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("u_username", username);
                    cmd.Parameters.Add("u_password", password);

                    cmd.ExecuteNonQuery();

                    string sql = "SELECT USERNAME, USER_ID, CREATED FROM ALL_USERS ORDER BY USERNAME";
                    OracleDataAdapter adapter = new OracleDataAdapter(sql, conNow) { SuppressGetDecimalInvalidCastException = true };
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    UserandRole.grid1.DataSource = dataTable;
                    MessageBox.Show("Tạo mới thành công user " + username + ".");
                    this.Close();
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

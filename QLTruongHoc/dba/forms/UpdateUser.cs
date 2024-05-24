using Microsoft.VisualBasic.ApplicationServices;
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

namespace QLTruongHoc
{
    public partial class UpdateUser : Form
    {
        private static OracleConnection conNow = Login.con;
        public UpdateUser()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (rolebox.Text.Length == 0 || passbox.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập đủ username, password mới.");
                    return;
                } else if (passbox.Text != confirm_psw_txtbox.Text)
                {
                    MessageBox.Show("MẬT KHẨU không trùng khớp.");
                }
                else
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conNow;
                    cmd.CommandText = "QLTH.check_user_role_exist";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("user_role", rolebox.Text.ToString());
                    cmd.Parameters.Add("res", OracleDbType.Int32).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    var result = Convert.ToString(cmd.Parameters["res"].Value);
                    if (result != "1")
                    {
                        MessageBox.Show("User không tồn tại trong hệ thống.");
                        return;
                    } else
                    {
                        var cmd1 = new OracleCommand();

                        cmd1.Connection = conNow;
                        cmd1.CommandText = "QLTH.change_password";
                        cmd1.CommandType = CommandType.StoredProcedure;

                        cmd1.Parameters.Add("p_username", rolebox.Text.ToString());
                        cmd1.Parameters.Add("p_newpassword", passbox.Text.ToString());
                        cmd1.ExecuteNonQuery();


                        string sql = "SELECT USERNAME, USER_ID, CREATED FROM ALL_USERS";

                        OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
                        DataTable dt1 = new DataTable();
                        da.Fill(dt1);
                        UserAndRoleTab.grid1.DataSource = dt1;
                        MessageBox.Show("Đổi mật khẩu thành công!");
                        this.Close();

                    }

                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rolebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

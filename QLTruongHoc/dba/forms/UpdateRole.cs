using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System.Data;

namespace QLTruongHoc
{
    public partial class UpdateRole : Form
    {
        public UpdateRole()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (rolebox.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập VAI TRÒ muốn cập nhật.");
                    return;
                } else if (passbox.Text != confirm_psw_txtbox.Text)
                {
                    MessageBox.Show("MẬT KHẨU không trùng khớp.");
                    return;
                }
                else
                {

                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = Session.Instance.OracleConnection;
                    cmd.CommandText = "QLTH.check_user_role_exist";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("user_role", rolebox.Text.ToString());
                    cmd.Parameters.Add("res", OracleDbType.Int32).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    var result = Convert.ToString(cmd.Parameters["res"].Value);
                    if (result != "2")
                    {
                        MessageBox.Show("Role không tồn tại trong hệ thống.");
                        return;
                    } else
                    {
                        var cmd1 = new OracleCommand();

                        cmd1.Connection = Session.Instance.OracleConnection;
                        cmd1.CommandText = "QLTH.change_role_password";
                        cmd1.CommandType = CommandType.StoredProcedure;

                        cmd1.Parameters.Add("p_role_name", rolebox.Text.ToString());
                        cmd1.Parameters.Add("p_new_password", passbox.Text.ToString());
                        cmd1.ExecuteNonQuery();


                        string sql = "SELECT ROLE, ROLE_ID, PASSWORD_REQUIRED FROM DBA_ROLES";

                        OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
                        DataTable dt1 = new DataTable();
                        da.Fill(dt1);
                        UserAndRoleTab.grid2.DataSource = dt1;
                        MessageBox.Show($"Role {rolebox.Text} đã được cập nhật thành công");
                        this.Close();
                    }


                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

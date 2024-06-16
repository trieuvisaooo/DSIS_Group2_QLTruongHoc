using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System.Data;

namespace QLTruongHoc
{
    public partial class RevokeRole : Form
    {

        public RevokeRole()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (userRoleBox.Text.Length == 0)
                {
                    MessageBox.Show("User/Role cần thu hồi không dược để trống.");
                }

                if (roleBox.Text.Length == 0)
                {
                    MessageBox.Show("Role muốn thu hồi của User/Role không được để trống");
                }

                var cmd = new OracleCommand();
                cmd.Connection = Session.Instance.OracleConnection;
                cmd.CommandText = "QLTH.revoke_role";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("userOrRole", userRoleBox.Text);
                cmd.Parameters.Add("role_name", roleBox.Text);
                cmd.Parameters.Add("res", OracleDbType.Int32).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();


                var result_roleuser = Convert.ToString(cmd.Parameters["res"].Value);

                if (result_roleuser == "-1")
                {
                    MessageBox.Show("User/Role cần thu hồi role không tồn tại");
                }
                else if (result_roleuser == "-2")
                {
                    MessageBox.Show("Role không tồn tại");
                }
                else if (result_roleuser == "-3")
                {
                    MessageBox.Show("Role này chưa được cấp cho user");
                }
                else if (result_roleuser == "3")
                {
                    MessageBox.Show("Hủy role " + roleBox.Text.ToString() + " của user/role " + userRoleBox.Text.ToString() + " thành công");
                    this.Hide();

                    string sql = "select * from dba_role_privs";

                    OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    RoleTab.roleUserGrid.DataSource = dt;
                }

            }
            catch (Exception ex)
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

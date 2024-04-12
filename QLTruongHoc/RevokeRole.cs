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
    public partial class RevokeRole : Form
    {
        private static OracleConnection conNow = Login.con;

        public RevokeRole()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                cmd.Connection = conNow;
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

                    OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DBA_RoleUI.roleUserGrid.DataSource = dt;
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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
    public partial class DBA_GrantRole : Form
    {
        private static OracleConnection conNow = Login.con;

        public DBA_GrantRole()
        {
            InitializeComponent();
        }

        private void grant_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string role = role_txtbox.Text.ToString();
                string userOrRole = userOrrole_txtbox.Text.ToString();
                string withAdminOption = (isAdminCheckBox.Checked) ? "WITH ADMIN OPTION" : "";

             

                if (role.Length == 0 || userOrRole.Length == 0)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                }
                else
                {
                    var cmd = new OracleCommand();
                    cmd.Connection = conNow;
                    cmd.CommandText = "QLTH.grant_role";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("user_name", userOrRole);
                    cmd.Parameters.Add("role_name", role);
                    cmd.Parameters.Add("withadminoption", withAdminOption);
                    cmd.Parameters.Add("res", OracleDbType.Int32).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    var result_roleuser = Convert.ToString(cmd.Parameters["res"].Value);

                    if(result_roleuser == "-1")
                {
                        MessageBox.Show("User/Role cần cấp role không tồn tại");
                    }
                else if (result_roleuser == "-2")
                    {
                        MessageBox.Show("Role cần cấp cho User không tồn tại");
                    }
                    else if (result_roleuser == "3")
                    {
                        MessageBox.Show("Cấp role " + role + " cho user/role " + userOrRole + " thành công");
                        this.Hide();

                        string sql = "select * from dba_role_privs";

                        OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DBA_RoleUI.roleUserGrid.DataSource = dt;

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

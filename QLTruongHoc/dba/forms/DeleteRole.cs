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
    public partial class DeleteRole : Form
    {
        private OracleConnection conNow = Login.con;

        public DeleteRole()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string role = userbox.Text.ToString();
                if (string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("VAI TRÒ không được để trống.");
                }
                else
                {

                    OracleCommand cmd1 = new OracleCommand();
                    cmd1.Connection = conNow;
                    cmd1.CommandText = "QLTH.check_user_role_exist";
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("user_role", role);
                    cmd1.Parameters.Add("res", OracleDbType.Int32).Direction = ParameterDirection.Output;

                    cmd1.ExecuteNonQuery();

                    var result = Convert.ToString(cmd1.Parameters["res"].Value);
                    if (result != "2")
                    {
                        MessageBox.Show("Role không tồn tại trong hệ thống.");
                        return;
                    }
                    else
                    {
                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = conNow;
                        cmd.CommandText = "QLTH.delete_role";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_role_name", role);

                        cmd.ExecuteNonQuery();

                        string sql = "SELECT role, role_id, password_required FROM DBA_ROLES";
                        OracleDataAdapter da = new OracleDataAdapter(sql, conNow) { SuppressGetDecimalInvalidCastException = true };
                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);
                        UserAndRoleTab.grid2.DataSource = dataTable;
                        MessageBox.Show("Xóa Role thành công");
                        this.Close();
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

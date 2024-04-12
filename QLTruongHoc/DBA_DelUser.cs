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
    public partial class DBA_DelUser : Form
    {

        private OracleConnection conNow = Login.con;

        public DBA_DelUser()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string user = userbox.Text.ToString();
                if (string.IsNullOrEmpty(user))
                {
                    MessageBox.Show("VAI TRÒ không được để trống.");
                }
                else
                {

                    OracleCommand cmd1 = new OracleCommand();
                    cmd1.Connection = conNow;
                    cmd1.CommandText = "QLTH.check_user_role_exist";
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("user_role", user);
                    cmd1.Parameters.Add("res", OracleDbType.Int32).Direction = ParameterDirection.Output;

                    cmd1.ExecuteNonQuery();

                    var result = Convert.ToString(cmd1.Parameters["res"].Value);
                    if (result != "1")
                    {
                        MessageBox.Show("User không tồn tại trong hệ thống.");
                        return;
                    }
                    else
                    {
                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = conNow;
                        cmd.CommandText = "QLTH.delete_user";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_username", user);

                        cmd.ExecuteNonQuery();

                        string sql = "SELECT USERNAME, USER_ID, CREATED FROM ALL_USERS ORDER BY USERNAME";
                        OracleDataAdapter adapter = new OracleDataAdapter(sql, conNow) { SuppressGetDecimalInvalidCastException = true };
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        UseransRole.grid1.DataSource = dataTable;
                        this.Close();
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

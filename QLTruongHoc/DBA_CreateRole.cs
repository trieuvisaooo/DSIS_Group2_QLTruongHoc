using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTruongHoc
{
    public partial class DBA_CreateRole : Form
    {

        public static OracleConnection conNow = Login.con;

        public DBA_CreateRole()
        {
            InitializeComponent();
        }

        private void rolebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string role = rolebox.Text.ToString();
            string password = passbox.Text.ToString();

            try
            {
                if (string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("VAI TRÒ không được để trống");
                    return;
                }

                var cmd = new OracleCommand();
                cmd.Connection = conNow;
                cmd.CommandText = "QLTH.create_role";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_role_name", role);
                cmd.Parameters.Add("p_password", password);
                
                cmd.ExecuteNonQuery();

                string sql = "SELECT role, role_id, password_required FROM DBA_ROLES";
                OracleDataAdapter da = new OracleDataAdapter(sql, conNow) { SuppressGetDecimalInvalidCastException = true};
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                UseransRole.grid2.DataSource = dataTable;
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                this.Close();
               
            }
        }
    }
}

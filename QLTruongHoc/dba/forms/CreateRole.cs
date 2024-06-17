using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System.Data;

namespace QLTruongHoc
{
    public partial class CreateRole : Form
    {

        public CreateRole()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string role = rolebox.Text.ToString();
            string password = passbox.Text.ToString();
            string confirm_psw = confirm_psw_txtbox.Text.ToString();

            try
            {
                if (string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("VAI TRÒ không được để trống");
                    return;
                } else if (password != confirm_psw)
                {
                    MessageBox.Show("Password không trùng khớp với nhau");
                    return;
                } else
                {
                    var cmd = new OracleCommand();
                    cmd.Connection = Session.Instance.OracleConnection;
                    cmd.CommandText = "QLTH.create_role";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_role_name", role);
                    cmd.Parameters.Add("p_password", password);

                    cmd.ExecuteNonQuery();

                    string sql = "SELECT role, role_id, password_required FROM DBA_ROLES";
                    OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection) { SuppressGetDecimalInvalidCastException = true };
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);
                    DBA_UserAndRoleTab.grid2.DataSource = dataTable;
                    MessageBox.Show("Tạo mới thành công role " + role + "!");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

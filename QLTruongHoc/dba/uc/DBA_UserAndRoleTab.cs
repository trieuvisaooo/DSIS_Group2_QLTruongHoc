using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System.Data;

namespace QLTruongHoc
{
    public partial class DBA_UserAndRoleTab : UserControl
    {
        public static DataGridView grid1;
        public static DataGridView grid2;

        public DBA_UserAndRoleTab()
        {
            InitializeComponent();
        }


        private void DBA_load_UserAndRole()
        {
            try
            {
                // Select table
                string selectTableSql = "SELECT USERNAME, USER_ID, CREATED FROM ALL_USERS ORDER BY USERNAME";
                OracleCommand command = new OracleCommand(selectTableSql, Session.Instance.OracleConnection);
                command.BindByName = true;
                command.Parameters.Add(new OracleParameter("owner", Login.username));
                OracleDataAdapter adapter = new OracleDataAdapter(command) { SuppressGetDecimalInvalidCastException = true };
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                userGrid.DataSource = dataTable;
                grid1 = userGrid;

                // Select View
                string selectViewSql = "SELECT role, role_id, password_required FROM DBA_ROLES";
                OracleCommand command1 = new OracleCommand(selectViewSql, Session.Instance.OracleConnection);
                command1.BindByName = true;
                command1.Parameters.Add(new OracleParameter("owner", Login.username));
                OracleDataAdapter adapter1 = new OracleDataAdapter(command1) { SuppressGetDecimalInvalidCastException = true };
                DataTable dataTable1 = new DataTable();
                adapter1.Fill(dataTable1);
                roleGrid.DataSource = dataTable1;
                grid2 = roleGrid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {

                string role_search_text = textBox2.Text.ToString();

                // Select View
                string selectViewSql = $"SELECT role, role_id, password_required FROM DBA_ROLES WHERE role LIKE '%{role_search_text}%' ";
                OracleCommand command1 = new OracleCommand(selectViewSql, Session.Instance.OracleConnection);
                command1.BindByName = true;
                command1.Parameters.Add(new OracleParameter("owner", Login.username));
                OracleDataAdapter adapter1 = new OracleDataAdapter(command1) { SuppressGetDecimalInvalidCastException = true };
                DataTable dataTable1 = new DataTable();
                adapter1.Fill(dataTable1);
                roleGrid.DataSource = dataTable1;
                grid2 = roleGrid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // CREATE USER
            CreateUser dBA_CreateUser = new CreateUser();
            dBA_CreateUser.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CreateRole dBA_CreateRole = new CreateRole();
            dBA_CreateRole.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteUser dBA_DelUser = new DeleteUser();
            dBA_DelUser.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DeleteRole dBA_DelRole = new DeleteRole();
            dBA_DelRole.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateUser dBA_UpdateUser = new UpdateUser();
            dBA_UpdateUser.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateRole dBA_UpdateRole = new UpdateRole();
            dBA_UpdateRole.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {

                string user_search_text = textBox1.Text.ToString();

                // Select table
                string selectTableSql = $"SELECT USERNAME, USER_ID, CREATED FROM ALL_USERS WHERE USERNAME LIKE \'%{user_search_text}%\' ORDER BY USERNAME";
                OracleCommand command = new OracleCommand(selectTableSql, Session.Instance.OracleConnection);
                command.BindByName = true;
                command.Parameters.Add(new OracleParameter("owner", Login.username));
                OracleDataAdapter adapter = new OracleDataAdapter(command) { SuppressGetDecimalInvalidCastException = true };
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                userGrid.DataSource = dataTable;
                grid1 = userGrid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            DBA_load_UserAndRole();
        }
    }
}
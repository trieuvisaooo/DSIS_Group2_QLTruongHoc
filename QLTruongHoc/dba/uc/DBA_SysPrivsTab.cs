using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System.Data;

namespace QLTruongHoc
{
    public partial class DBA_SysPrivsTab : UserControl
    {
        public DBA_SysPrivsTab()
        {
            InitializeComponent();
        }

        private void searchGrantee_Click(object sender, EventArgs e)
        {
            try
            {
                string selectSql = "select * from dba_sys_privs where grantee like \'%" + searchTextBox.Text + "%\' order by grantee asc";
                //MessageBox.Show(selectSql); // debug line
                OracleCommand cmd = new OracleCommand(selectSql, Session.Instance.OracleConnection);
                cmd.BindByName = true;
                //cmd.Parameters.Add(new OracleParameter("grantee", searchTextBox.Text));
                OracleDataAdapter adapter = new OracleDataAdapter(cmd) { SuppressGetDecimalInvalidCastException = true };
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                grantView.DataSource = dataTable;
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void grantRevokeButton_Click(object sender, EventArgs e)
        {
            GrantRevokeSysPrivs grant_revoke_form = new GrantRevokeSysPrivs();
            grant_revoke_form.Show();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                string selectSql = "select * from dba_sys_privs order by grantee asc";
                OracleCommand cmd = new OracleCommand(selectSql, Session.Instance.OracleConnection);
                cmd.BindByName = true;
                OracleDataAdapter adapter = new OracleDataAdapter(cmd) { SuppressGetDecimalInvalidCastException = true };
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                grantView.DataSource = dataTable;
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
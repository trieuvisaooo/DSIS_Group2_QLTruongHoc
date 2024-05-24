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
    public partial class SysPrivsTab : UserControl
    {
        public static OracleConnection conNow = Login.con;
        public SysPrivsTab()
        {
            InitializeComponent();
        }

        private void searchGrantee_Click(object sender, EventArgs e)
        {
            try
            {
                string selectSql = "select * from dba_sys_privs where grantee like \'%" + searchTextBox.Text + "%\' order by grantee asc";
                //MessageBox.Show(selectSql); // debug line
                OracleCommand cmd = new OracleCommand(selectSql, conNow);
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
                OracleCommand cmd = new OracleCommand(selectSql, conNow);
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

        private void SysPrivs_Load(object sender, EventArgs e)
        {

        }
    }
}

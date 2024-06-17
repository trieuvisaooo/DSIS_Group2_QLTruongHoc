using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System.Data;

namespace QLTruongHoc
{
    public partial class DBA_PrivilegeTab : UserControl
    {
        public DBA_PrivilegeTab()
        {
            InitializeComponent();
        }

        private void tableColumn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void view_table_privil()
        {
            string sql = "select * from DBA_TAB_PRIVS dba_tab_privs where owner =  \'QLTH\' order by grantee asc";

            OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            TableDataGridView.DataSource = dt1;
        }

        public void view_col_privil()
        {
            string sql = "select * from dba_col_privs where owner =  \'QLTH\' order by grantee asc";

            OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            ColDataGridView.DataSource = dt2;
        }

        private void grantBtn_Click(object sender, EventArgs e)
        {
            GrantPrivs grantPrivForm = new GrantPrivs();
            grantPrivForm.Show();
        }

        private void revokeBtn_Click(object sender, EventArgs e)
        {
            RevokePrivs revokePrivForm = new RevokePrivs();
            revokePrivForm.Show();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string sql1 = "select * from DBA_TAB_PRIVS dba_tab_privs where owner =  \'QLTH\' and grantee like " + "\'" + search_txtbox.Text + "\' order by grantee asc";

            OracleDataAdapter da1 = new OracleDataAdapter(sql1, Session.Instance.OracleConnection);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            TableDataGridView.DataSource = dt1;

            string sql2 = "select * from dba_col_privs where owner =  \'QLTH\' and grantee like " + "\'" + search_txtbox.Text + "\'";

            OracleDataAdapter da2 = new OracleDataAdapter(sql2, Session.Instance.OracleConnection);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            ColDataGridView.DataSource = dt2;

        }

        private void Privilege_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            view_table_privil();
            view_col_privil();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            view_table_privil();
            view_col_privil();
        }
    }
}
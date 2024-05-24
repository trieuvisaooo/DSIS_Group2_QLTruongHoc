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
    public partial class Privilege : UserControl
    {
        public static OracleConnection con_current = Login.con;
        public Privilege()
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

            OracleDataAdapter da = new OracleDataAdapter(sql, con_current);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            TableDataGridView.DataSource = dt1;
        }

        public void view_col_privil()
        {
            string sql = "select * from dba_col_privs where owner =  \'QLTH\' order by grantee asc";

            OracleDataAdapter da = new OracleDataAdapter(sql, con_current);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            ColDataGridView.DataSource = dt2;
        }

        private void grantBtn_Click(object sender, EventArgs e)
        {
            DBA_GrantPrivs grantPrivForm = new DBA_GrantPrivs();
            grantPrivForm.Show();
        }

        private void revokeBtn_Click(object sender, EventArgs e)
        {
            DBA_RevokePrivs revokePrivForm = new DBA_RevokePrivs();
            revokePrivForm.Show();
        }


        private void load_btn_Click(object sender, EventArgs e)
        {
            view_table_privil();
            view_col_privil();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string sql1 = "select * from DBA_TAB_PRIVS dba_tab_privs where owner =  \'QLTH\' and grantee = " + "\'" + search_txtbox.Text + "\' order by grantee asc";

            OracleDataAdapter da1 = new OracleDataAdapter(sql1, con_current);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            TableDataGridView.DataSource = dt1;

            string sql2 = "select * from dba_col_privs where owner =  \'QLTH\' and grantee = " + "\'" + search_txtbox.Text + "\'";

            OracleDataAdapter da2 = new OracleDataAdapter(sql2, con_current);
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
    }
}

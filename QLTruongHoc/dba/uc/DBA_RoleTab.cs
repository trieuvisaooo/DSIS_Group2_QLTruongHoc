using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System.Data;

namespace QLTruongHoc
{
    public partial class DBA_RoleTab : UserControl
    {
        public static DataGridView roleUserGrid;

        public DBA_RoleTab()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GrantRole dBA_GrantRole = new GrantRole();
            dBA_GrantRole.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                if (textBox1.Text.Length == 0)
                    sql = "select * from dba_role_privs";
                else
                    sql = "select * from dba_role_privs where GRANTEE LIKE \'%" + textBox1.Text + "%\'";

                //MessageBox.Show(sql); // debug line
                OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                roleUserGrid = dataGridView1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                string sql;
                if (textBox2.Text.Length == 0)
                    sql = "select * from dba_role_privs";
                else
                    sql = "select * from dba_role_privs where GRANTED_ROLE LIKE \'%" + textBox2.Text + "%\'";

                //MessageBox.Show(sql); // debug line
                OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                roleUserGrid = dataGridView1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RevokeRole revokeRole = new RevokeRole();
            revokeRole.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {


            try
            {
                string sql = "select * from dba_role_privs";

                OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                roleUserGrid = dataGridView1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
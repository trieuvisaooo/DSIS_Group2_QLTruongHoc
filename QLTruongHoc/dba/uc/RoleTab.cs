using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QLTruongHoc
{
    public partial class RoleTab : UserControl
    {
        private static OracleConnection conNow = Login.con;
        public static DataGridView roleUserGrid;

        public RoleTab()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GrantRole dBA_GrantRole = new GrantRole();
            dBA_GrantRole.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DBA_RoleUI_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql;
            if (textBox1.Text.Length == 0)
                sql = "select * from dba_role_privs";
            else
                sql = "select * from dba_role_privs where GRANTEE LIKE \'%" + textBox1.Text + "%\'";

            //MessageBox.Show(sql); // debug line
            OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            roleUserGrid = dataGridView1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql;
            if (textBox2.Text.Length == 0)
                sql = "select * from dba_role_privs";
            else
                sql = "select * from dba_role_privs where GRANTED_ROLE LIKE \'%" + textBox2.Text + "%\'";

            //MessageBox.Show(sql); // debug line
            OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            roleUserGrid = dataGridView1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RevokeRole revokeRole = new RevokeRole();
            revokeRole.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "select * from dba_role_privs";

            OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            roleUserGrid = dataGridView1;
        }
    }
}

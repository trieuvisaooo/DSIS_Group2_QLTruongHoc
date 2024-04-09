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
    public partial class SysPrivs : UserControl
    {
        public static OracleConnection conNow = Login.con;
        public SysPrivs()
        {
            InitializeComponent();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
		/*
            try
            {
                string selectTsql = "select * from dba_sys_privs";
                OracleCommand cmd = new OracleCommand(selectTsql, conNow);
                cmd.BindByName = true;
                //cmd.Parameters.Add(new OracleParameter("owner", LoginUI.userUser));
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
		*/
        }

        private void searchGrantee_Click(object sender, EventArgs e)
        {

        }

        private void grantRevokeButton_Click(object sender, EventArgs e)
        {

        }
    }
}

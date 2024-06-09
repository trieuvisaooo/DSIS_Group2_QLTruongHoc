using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTruongHoc.dba.uc
{
    public partial class AuditTab : UserControl
    {

        public AuditTab()
        {
            InitializeComponent();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            string sql = "select AUDIT_TYPE, DBUSERNAME, EVENT_TIMESTAMP, ACTION_NAME, OBJECT_NAME, SQL_TEXT, FGA_POLICY_NAME, OBJECT_TYPE, RETURN_CODE from unified_audit_trail";
            OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }
    }
}

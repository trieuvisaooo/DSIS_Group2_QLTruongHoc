using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System.Data;


namespace QLTruongHoc.dba.uc
{
    public partial class AuditTab : UserControl
    {
        string audit_type;
        public AuditTab()
        {
            InitializeComponent();
        }

        private void StandardAuditComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            audit_type = StandardAuditComBox.Text.ToString();
            string sql_statement;
            if (audit_type == "DBA_AUDIT")
            {
                try
                {
                    sql_statement = "SELECT AUDIT_TYPE, DBUSERNAME, EVENT_TIMESTAMP, ACTION_NAME, OBJECT_NAME, SQL_TEXT, SYSTEM_PRIVILEGE_USED, RETURN_CODE" +
                                    "\r\nFROM UNIFIED_AUDIT_TRAIL" +
                                    "\r\nWHERE UNIFIED_AUDIT_POLICIES LIKE '%DBA_ON_QLTH_AUDIT_POL%' AND DBUSERNAME != 'SYS'" +
                                    "\r\nORDER BY EVENT_TIMESTAMP DESC";
                    //MessageBox.Show(sql_statement);
                    OracleDataAdapter da = new OracleDataAdapter(sql_statement, Session.Instance.OracleConnection);
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    dataGridView1.DataSource = dt1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (audit_type == "NHANSU_AUDIT")
            {
                try
                {
                    sql_statement = "SELECT AUDIT_TYPE, DBUSERNAME, EVENT_TIMESTAMP, ACTION_NAME, OBJECT_NAME, SQL_TEXT, SYSTEM_PRIVILEGE_USED, RETURN_CODE" +
                                "\r\nFROM UNIFIED_AUDIT_TRAIL" +
                                "\r\nWHERE OBJECT_NAME = 'QLTH_NHANSU' AND ACTION_NAME != 'SELECT'" +
                                "\r\nORDER BY EVENT_TIMESTAMP DESC";
                    OracleDataAdapter da = new OracleDataAdapter(sql_statement, Session.Instance.OracleConnection);
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    dataGridView1.DataSource = dt1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (audit_type == "DANGKY_AUDIT")
            {
                try
                {
                    sql_statement = "SELECT AUDIT_TYPE, DBUSERNAME, EVENT_TIMESTAMP, ACTION_NAME, OBJECT_NAME, SQL_TEXT, SYSTEM_PRIVILEGE_USED, RETURN_CODE" +
                                    "\r\nFROM UNIFIED_AUDIT_TRAIL" +
                                    "\r\nWHERE OBJECT_NAME = 'QLTH_DANGKY' AND ACTION_NAME != 'SELECT'" +
                                    "\r\nORDER BY EVENT_TIMESTAMP DESC";
                    OracleDataAdapter da = new OracleDataAdapter(sql_statement, Session.Instance.OracleConnection);
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    dataGridView1.DataSource = dt1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void FGAComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            audit_type = FGAComBox.Text.ToString();
            string sql_statement;
            if (audit_type == "SELECT_NHANSU")
            {
                try
                {
                    sql_statement = "SELECT AUDIT_TYPE, FGA_POLICY_NAME, DBUSERNAME, EVENT_TIMESTAMP, ACTION_NAME, OBJECT_NAME, SQL_TEXT, RETURN_CODE" +
                                    "\r\nFROM UNIFIED_AUDIT_TRAIL" +
                                    "\r\nWHERE FGA_POLICY_NAME = 'SELECT_PHUCAP_NHANSU'" +
                                    "\r\nORDER BY EVENT_TIMESTAMP DESC";
                    //MessageBox.Show(sql_statement);
                    OracleDataAdapter da = new OracleDataAdapter(sql_statement, Session.Instance.OracleConnection);
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    dataGridView1.DataSource = dt1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (audit_type == "UPDATE_DANGKY")
            {
                try
                {
                    sql_statement = "SELECT AUDIT_TYPE, FGA_POLICY_NAME, DBUSERNAME, EVENT_TIMESTAMP, ACTION_NAME, OBJECT_NAME, SQL_TEXT, RETURN_CODE" +
                                    "\r\nFROM UNIFIED_AUDIT_TRAIL" +
                                    "\r\nWHERE FGA_POLICY_NAME = 'UPDATE_DANGKY_DIEM'" +
                                    "\r\nORDER BY EVENT_TIMESTAMP DESC";
                    OracleDataAdapter da = new OracleDataAdapter(sql_statement, Session.Instance.OracleConnection);
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    dataGridView1.DataSource = dt1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }
    }
}

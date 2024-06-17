using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System.Data;

namespace QLTruongHoc
{
    public partial class DBA_TablesViewsTab : UserControl
    {

        public DBA_TablesViewsTab()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Select table
                string selectTableSql = "select * from dba_tables where owner = :owner";
                OracleCommand command = new OracleCommand(selectTableSql, Session.Instance.OracleConnection);
                command.BindByName = true;
                command.Parameters.Add(new OracleParameter("owner", Login.username));
                OracleDataAdapter adapter = new OracleDataAdapter(command) { SuppressGetDecimalInvalidCastException = true };
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                tableGrid.DataSource = dataTable;

                // Select View
                string selectViewSql = "select * from dba_views where owner = :owner";
                OracleCommand command1 = new OracleCommand(selectViewSql, Session.Instance.OracleConnection);
                command1.BindByName = true;
                command1.Parameters.Add(new OracleParameter("owner", Login.username));
                OracleDataAdapter adapter1 = new OracleDataAdapter(command1) { SuppressGetDecimalInvalidCastException = true };
                DataTable dataTable1 = new DataTable();
                adapter1.Fill(dataTable1);
                viewGrid.DataSource = dataTable1;

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;

            }
        }
    }
}
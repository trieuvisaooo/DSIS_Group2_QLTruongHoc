using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTruongHoc
{
    public partial class DBA_TablesAndViews_UC : UserControl
    {
        public static OracleConnection conNow = Login.con;

        public DBA_TablesAndViews_UC()
        {
            InitializeComponent();
            DBA_TablesAndViews_UC_load();
        }

        private void DBA_TablesAndViews_UC_load()
        {
            try {
                // Select table
                string selectTableSql = "select * from dba_tables where owner = :owner";
                OracleCommand command = new OracleCommand(selectTableSql, conNow);
                command.BindByName = true;
                command.Parameters.Add(new OracleParameter("owner", Login.username));
                OracleDataAdapter adapter = new OracleDataAdapter(command) { SuppressGetDecimalInvalidCastException = true };
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                tableGrid.DataSource = dataTable;

                // Select View
                string selectViewSql = "select * from dba_views where owner = :owner";
                OracleCommand command1 = new OracleCommand(selectViewSql, conNow);
                command1.BindByName = true;
                command1.Parameters.Add(new OracleParameter("owner", Login.username));
                OracleDataAdapter adapter1 = new OracleDataAdapter(command1) { SuppressGetDecimalInvalidCastException = true };
                DataTable dataTable1 = new DataTable();
                adapter1.Fill(dataTable1);
                viewGrid.DataSource = dataTable1;

            }
            catch(OracleException ex) {
                MessageBox.Show(ex.Message);
                return;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

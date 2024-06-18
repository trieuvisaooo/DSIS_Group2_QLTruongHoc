using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System.Data;


namespace QLTruongHoc.nhan_su.uc
{
    public partial class Emp_XemQLTHTab : UserControl
    {
        public Emp_XemQLTHTab()
        {
            InitializeComponent();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            string sql_statement;
            string tab_name = TabComBox.Text.ToString();
            try
            {
                sql_statement = "SELECT * FROM QLTH.QLTH_" + tab_name;
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

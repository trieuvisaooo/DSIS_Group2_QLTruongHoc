using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.nhan_su.forms;
using QLTruongHoc.utils;
using System.Data;


namespace QLTruongHoc.nhan_su.uc
{
    public partial class Emp_KhmoTab : UserControl
    {
        public Emp_KhmoTab()
        {
            InitializeComponent();
            if (Session.Instance.Role == "Giáo vụ")
            {
                InsertBtn.Visible = true;
                DeleteBtn.Visible = true;
            }
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {

            string sql = "select * from QLTH.UV_QLTH_KHMO_FORM";
            OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            CustomizeColumnHeaders();
        }

        private void CustomizeColumnHeaders()
        {
            // Change column headers to custom names
            dataGridView1.Columns["MAHP"].HeaderText = "Mã Học Phần";
            dataGridView1.Columns["TENHP"].HeaderText = "Tên Học Phần";
            dataGridView1.Columns["NAM"].HeaderText = "Năm";
            dataGridView1.Columns["MACT"].HeaderText = "Chương Trình";
            dataGridView1.Columns["HK"].HeaderText = "Học Kỳ";
            dataGridView1.Columns["TENDV"].HeaderText = "Đơn Vị";
            // change column size
            dataGridView1.Columns["TENHP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void KhmoTab_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string sql = "select distinct nam from QLTH.UV_QLTH_KHMO_FORM order by nam";

            // Create a DataTable object
            DataTable dt = new DataTable();

            // Create an OracleDataAdapter and fill the DataTable
            using (OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection))
            {
                da.Fill(dt);
            }
            DataRow newRow = dt.NewRow();
            newRow["nam"] = "--";
            dt.Rows.Add(newRow);
            // Set the ComboBox's DataSource (the DataTable)
            comboBox1.DataSource = dt;
            // Set the ValueMember and DisplayMember properties
            comboBox1.ValueMember = "nam"; // Assuming "nam" is the column for storing values
            comboBox1.DisplayMember = "nam";
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            string sql = "select distinct HK from QLTH.UV_QLTH_KHMO_FORM order by HK";

            // Create a DataTable object
            DataTable dt = new DataTable();

            // Create an OracleDataAdapter and fill the DataTable
            using (OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection))
            {
                da.Fill(dt);
            }
            DataRow newRow = dt.NewRow();
            newRow["HK"] = -1;
            dt.Rows.Add(newRow);
            // Set the ComboBox's DataSource (the DataTable)
            comboBox2.DataSource = dt;
            // Set the ValueMember and DisplayMember properties
            comboBox2.ValueMember = "HK"; // Assuming "nam" is the column for storing values
            comboBox2.DisplayMember = "HK";
        }

        private void comboBox2_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem != null && e.ListItem is DataRowView)
            {
                DataRowView rowView = (DataRowView)e.ListItem;
                if (rowView["HK"] is decimal && (decimal)rowView["HK"] == -1)
                {
                    e.Value = "--";
                }
            }
        }

        private void comboBox3_DropDown(object sender, EventArgs e)
        {
            string sql = "select distinct MACT from QLTH.UV_QLTH_KHMO_FORM";

            // Create a DataTable object
            DataTable dt = new DataTable();

            // Create an OracleDataAdapter and fill the DataTable
            using (OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection))
            {
                da.Fill(dt);
            }
            DataRow newRow = dt.NewRow();
            newRow["MACT"] = "--";
            dt.Rows.Add(newRow);
            // Set the ComboBox's DataSource (the DataTable)
            comboBox3.DataSource = dt;
            // Set the ValueMember and DisplayMember properties
            comboBox3.ValueMember = "MACT"; // Assuming "nam" is the column for storing values
            comboBox3.DisplayMember = "MACT";
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string sql = "select * from QLTH.UV_QLTH_KHMO_FORM ";

            string nam = comboBox1.Text;
            string hk = comboBox2.Text;
            string ct = comboBox3.Text;
            string hp = textBox1.Text.ToLower();

            string namClause = $" NAM = '{nam}' ";
            string hkClause = $" HK = {hk} ";
            string ctClause = $" MACT = '{ct}' ";
            string hpClause = $" LOWER(tenhp) LIKE LOWER('%{hp}%') ";

            if (nam == "Năm học" || nam == "--")
            {
                namClause = null;
            }
            if (hk == "Học Kỳ" || hk == "--")
            {
                hkClause = null;
            }
            if (ct == "Chương trình" || ct == "--")
            {
                ctClause = null;
            }
            if (hp.Length == 0)
            {
                hpClause = null;
            }

            List<string> words = new List<string> { namClause, hkClause, ctClause, hpClause };
            string whereClasue = "where " + string.Join(" and ", words.Where(s => s != null));

            if (namClause != null || hkClause != null || ctClause != null || hpClause != null)
            {
                sql = sql + whereClasue;
            }

            OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            CustomizeColumnHeaders();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khóa học mở muốn xóa.");
                return;
            }

            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khóa học mở này?", "Xóa KH mở", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.Yes:
                        DataGridViewRow row = dataGridView1.SelectedRows[0];
                        string mahp = row.Cells["MAHP"].Value as string;
                        string tenhp = row.Cells["TENHP"].Value as string;
                        string hp = mahp + " - " + tenhp;
                        string nam = row.Cells["NAM"].Value as string;
                        decimal hk = (decimal)row.Cells["HK"].Value;
                        string mact = row.Cells["MACT"].Value as string;

                        string sql = $"delete from qlth.qlth_khmo " +
                                       $"where mahp = '{mahp}' AND nam = '{nam}' AND hk = {hk} AND mact = '{mact}'";

                        OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa Thành Công");
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa khóa học mở này!");
                return;
                //MessageBox.Show(ex.Message);
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            InsertKHMO insertKHMO = new InsertKHMO();
            insertKHMO.Show();
        }
    }
}

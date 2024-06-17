using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System.Data;


namespace QLTruongHoc.sinh_vien.uc
{
    public partial class Stu_KQHTTab : UserControl
    {
        public Stu_KQHTTab()
        {
            InitializeComponent();
        }

        private void CustomizeColumnHeaders()
        {
            // Change column headers to custom names
            dataGridView1.Columns["MAHP"].HeaderText = "Mã HP";
            dataGridView1.Columns["TENHP"].HeaderText = "Tên Học Phần";
            dataGridView1.Columns["NAM"].HeaderText = "Năm";
            //dataGridView1.Columns["MACT"].HeaderText = "CT";
            dataGridView1.Columns["HK"].HeaderText = "Học Kỳ";
            //dataGridView1.Columns["MADV"].HeaderText = "Đơn Vị";
            //dataGridView1.Columns["NGAYHOC"].HeaderText = "Ngày";
            //dataGridView1.Columns["TIET"].HeaderText = "Tiết";
            dataGridView1.Columns["SOTC"].HeaderText = "Số TC";
            dataGridView1.Columns["DIEMTHI"].HeaderText = "Điểm Thi";
            dataGridView1.Columns["DIEMQT"].HeaderText = "Điểm QT";
            dataGridView1.Columns["DIEMCK"].HeaderText = "Điểm CK";
            dataGridView1.Columns["DIEMTK"].HeaderText = "Điểm TK";
            // Change column size
            dataGridView1.Columns["TENHP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void YearComBox_DropDown(object sender, EventArgs e)
        {
            try
            {
                string sql = "select distinct nam from QLTH.UV_QLTH_KQHT_SV";

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
                YearComBox.DataSource = dt;
                // Set the ValueMember and DisplayMember properties
                YearComBox.ValueMember = "nam"; // Assuming "nam" is the column for storing values
                YearComBox.DisplayMember = "nam";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SemComBox_Format(object sender, ListControlConvertEventArgs e)
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

        private void SemComBox_DropDown(object sender, EventArgs e)
        {
            try
            {
                string sql = "select distinct HK from QLTH.UV_QLTH_KQHT_SV";

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
                SemComBox.DataSource = dt;
                // Set the ValueMember and DisplayMember properties
                SemComBox.ValueMember = "HK"; // Assuming "nam" is the column for storing values
                SemComBox.DisplayMember = "HK";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM QLTH.UV_QLTH_KQHT_SV";

            string nam = YearComBox.Text;
            string hk = SemComBox.Text;
            string hp = CourseTxtBox.Text.ToLower();

            string namClause = null;
            string hkClause = null;
            string hpClause = null;

            if (nam != "Năm Học" && nam != "--")
            {
                namClause = $" NAM = '{nam}' ";
            }
            if (hk != "Học Kỳ" && hk != "--")
            {
                hkClause = $" HK = {hk} ";
            }
            if (hp.Length > 0)
            {
                hpClause = $" LOWER(tenhp) LIKE LOWER(N'%{hp}%') ";
            }

            List<string> words = new List<string> { namClause, hkClause, hpClause };
            string whereClasue = " where " + string.Join(" and ", words.Where(s => s != null));

            if (namClause != null || hkClause != null || hpClause != null)
            {
                sql = sql + whereClasue;
            }

            //MessageBox.Show(sql);
            OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            CustomizeColumnHeaders();
        }
    }
}
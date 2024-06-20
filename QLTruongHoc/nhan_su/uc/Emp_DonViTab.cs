using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.nhan_su.forms;
using QLTruongHoc.utils;
using System.Data;


namespace QLTruongHoc.nhan_su.uc
{
    public partial class Emp_DonViTab : UserControl
    {
        public Emp_DonViTab()
        {
            InitializeComponent();

            if (Session.Instance.Role == "Giáo vụ")
            {
                InsertBtn.Visible = true;
                UpdateBtn.Visible = true;
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM QLTH.QLTH_DONVI";
                OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                CustomizeColumnHeaders();
            } catch
            {
                MessageBox.Show("Không thể tải dữ liệu!");
            }
        }

        private void CustomizeColumnHeaders()
        {
            // Change column headers to custom names
            dataGridView1.Columns["MADV"].HeaderText = "Mã Đơn Vị";
            dataGridView1.Columns["TENDV"].HeaderText = "Tên Đơn Vị";
            dataGridView1.Columns["TRGDV"].HeaderText = "Trưởng Đơn Vị";

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string search = searchTextBox.Text;
                search = search.ToLower();
                if (search.Length > 0)
                {
                    string sql = $"SELECT * FROM QLTH.QLTH_DONVI WHERE LOWER(TENDV) LIKE LOWER('%{search}%')";
                    OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    CustomizeColumnHeaders();
                }
            }
            catch
            {
                MessageBox.Show("Không thể tải dữ liệu!");
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            InsertDonVi form = new InsertDonVi();
            form.Show();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng đơn vị muốn cập nhật.");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            MessageBox.Show(row.Cells["MADV"].Value as string); 
            string madv = row.Cells["MADV"].Value as string;
            UpdateDonVi form = new UpdateDonVi(madv);
            form.Show();
        }
    }
}

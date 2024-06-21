using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System.Data;


namespace QLTruongHoc.nhan_su.forms
{
    public partial class ThoiGianDK : Form
    {
        public ThoiGianDK()
        {
            InitializeComponent();
        }

        private void CustomizeColumnHeaders()
        {
            // Change column headers to custom names
            dataGridView1.Columns["NAM"].HeaderText = "Năm";
            dataGridView1.Columns["MACT"].HeaderText = "Chương Trình";
            dataGridView1.Columns["HK"].HeaderText = "Học Kỳ";
            dataGridView1.Columns["NGAYBD"].HeaderText = "Ngày bắt đầu";
            dataGridView1.Columns["NGAYKT"].HeaderText = "Ngày kết thúc";
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            string sql = "select * from qlth.qlth_thoigiandk";

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
                MessageBox.Show("Vui lòng chọn thời gian muốn xóa.");
                return;
            }

            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa TGDK này?", "Xóa TGDK", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.Yes:
                        DataGridViewRow row = dataGridView1.SelectedRows[0];
                        string mact = row.Cells["MACT"].Value as string;
                        decimal hk = (decimal)row.Cells["HK"].Value;
                        string nam = row.Cells["NAM"].Value as string;
                        string ngaybd = row.Cells["NGAYBD"].Value as string;
                        string ngaykt = row.Cells["NGAYKT"].Value as string;

                        string sql = $"delete from qlth.qlth_thoigiandk " +
                            $"where nam = '{nam}' " +
                            $"and hk = {hk} " +
                            $"and mact = '{mact}' ";

                        //MessageBox.Show(sql);

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
                MessageBox.Show("Không thể xóa TGDK này.");
                //MessageBox.Show(ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thời gian muốn cập nhật.");
                return;
            }
            //DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string mact = row.Cells["MACT"].Value as string;
            string nam = row.Cells["NAM"].Value as string;
            decimal hk = (decimal)row.Cells["HK"].Value;

            UpdateTGDK updateTGDK = new UpdateTGDK(nam, hk, mact);
            updateTGDK.Show();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            InsertTGDK insertTGDK = new InsertTGDK();
            insertTGDK.Show();
        }
    }
}

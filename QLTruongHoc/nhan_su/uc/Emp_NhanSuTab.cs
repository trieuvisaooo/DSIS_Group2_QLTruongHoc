using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.nhan_su.forms;
using QLTruongHoc.utils;
using System.Data;
using System.Windows.Forms;


namespace QLTruongHoc.nhan_su.uc
{
    public partial class Emp_NhanSuTab : UserControl
    {

        public Emp_NhanSuTab()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string search = searchTextBox.Text;
                if (search.Length > 0)
                {
                    string sql = $"SELECT * FROM QLTH.qlth_nhansu WHERE HOTEN LIKE N'%{search}%' OR TO_CHAR(MANS) LIKE '%{search}%' ";
                    OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    NhanSu_Table.DataSource = dt;
                    CustomizeColumnHeaders();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu!");
            }
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = "SELECT * FROM QLTH.qlth_nhansu";
                OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                NhanSu_Table.DataSource = dt;
                CustomizeColumnHeaders();
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu!");
            }
        }

        private void CustomizeColumnHeaders()
        {
            // Change column headers to custom names
            NhanSu_Table.Columns["MANS"].HeaderText = "Mã Nhân Sự";
            NhanSu_Table.Columns["HOTEN"].HeaderText = "Họ Tên";
            NhanSu_Table.Columns["PHAI"].HeaderText = "Phái";
            NhanSu_Table.Columns["NGSINH"].HeaderText = "Ngày Sinh";
            NhanSu_Table.Columns["NGSINH"].DefaultCellStyle.Format = "dd/MM/yyyy";
            NhanSu_Table.Columns["DIACHI"].HeaderText = "Địa Chỉ";
            NhanSu_Table.Columns["DT"].HeaderText = "SĐT";
            NhanSu_Table.Columns["PHUCAP"].HeaderText = "Phụ Cấp";
            NhanSu_Table.Columns["VAITRO"].HeaderText = "Vai Trò";
            NhanSu_Table.Columns["MADV"].HeaderText = "Mã Đơn Vị";
            NhanSu_Table.Columns["MACS"].HeaderText = "Cơ sở";

        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            InsertNhanSu insertNhanSu = new InsertNhanSu();
            insertNhanSu.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (NhanSu_Table.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân sự muốn xóa.");
                return;
            }

            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phân sự này?", "Xóa Nhân Sự", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.Yes:
                        DataGridViewRow row = NhanSu_Table.SelectedRows[0];
                        int mans = (int)row.Cells["MANS"].Value;

                        string sql = $"delete from qlth.qlth_nhansu " +
                            "where mans = " + mans;


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
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (NhanSu_Table.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân sự muốn cập nhật.");
                return;
            }

            try
            {
                DataGridViewRow row = NhanSu_Table.SelectedRows[0];
                int mans = (int)row.Cells["MANS"].Value;

                UpdateNhanSu updateNhanSu = new UpdateNhanSu(mans);
                updateNhanSu.Show();

            } catch (Exception ex)
            {
                //MessageBox.Show("Loi open update");
                MessageBox.Show(ex.Message);
            }
        }
    }
}

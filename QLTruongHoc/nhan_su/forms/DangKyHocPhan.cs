using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.sinh_vien;
using QLTruongHoc.utils;
using System.Data;


namespace QLTruongHoc.nhan_su.forms
{
    public partial class DangKyHocPhan : Form
    {
        DateTime curtime = DateTime.Now;
        ThoiGianDK tgdk = new ThoiGianDK();
        //SinhVien sv = new SinhVien();

        public DangKyHocPhan()
        {
            InitializeComponent();
            getSinhVienList();
        }

        private void getSinhVienList()
        {
            string sql = @"SELECT TO_CHAR(MASV), HOTEN AS SV FROM QLTH.QLTH_SINHVIEN";
            OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string masv = dr.GetString(0);
                string ten = dr.GetString(1);

                if (!string.IsNullOrEmpty(ten))
                {
                    masv += " - " + ten;
                }
                //MessageBox.Show(masv.Split(' ')[0]); // debug line
                SinhVienCombox.Items.Add(masv);
            }

        }

        private void getRegisterCourse(int masv)
        {
            try
            {
                string sql = "SELECT MAHP, TENHP, NAM||'/'||HK AS \"NAM/HK\", NGAYHOC, TIET, SOTC, SOSVTD, SOSVDK, MADV FROM QLTH.UV_QLTH_KEHOACHMOHP " +
                             "\r\nWHERE NAM = '" + tgdk.getYear() + "' AND HK = " + tgdk.getSem() +
                             "\r\n AND MAHP NOT IN (SELECT MAHP FROM QLTH.QLTH_DANGKY WHERE NAM = '" + tgdk.getYear() + "' AND HK = " + tgdk.getSem() + " AND MASV = " + masv + ")";
                OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                RegisterDataGridView.DataSource = dt;
                CustomizeRegisterDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getResult(int masv)
        {
            try
            {
                //string sql = "SELECT DK.MAHP, HP.TENHP, DK.NAM||'/'||DK.HK AS \"NAM/HK\", DK.NGAYHOC, DK.TIET, HP.SOTC, HP.SOSVTD, HP.MADV " +
                //            "\r\nFROM QLTH.QLTH_DANGKY DK JOIN QLTH.QLTH_HOCPHAN HP ON DK.MAHP = HP.MAHP " +
                //             "\r\nWHERE NAM = '" + tgdk.getYear() + "' AND HK = " + tgdk.getSem();
                string sql = "SELECT KHMO.MAHP, KHMO.TENHP, KHMO.NAM||'/'||KHMO.HK AS \"NAM/HK\", KHMO.NGAYHOC, KHMO.TIET, KHMO.SOTC, KHMO.SOSVTD, KHMO.SOSVDK, KHMO.MADV FROM QLTH.UV_QLTH_KEHOACHMOHP KHMO" +
                            "\r\nWHERE NAM = '" + tgdk.getYear() + "' AND HK = " + tgdk.getSem() +
                            "\r\n AND MAHP IN (SELECT MAHP FROM QLTH.QLTH_DANGKY DK WHERE DK.MASV = " + masv + " AND DK.NAM = '" + tgdk.getYear() + "' AND DK.HK = " + tgdk.getSem() + " AND DK.NGAYHOC = KHMO.NGAYHOC AND DK.TIET = KHMO.TIET)";
                OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ResultGridView.DataSource = dt;
                CustomizeResultDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            if (SinhVienCombox.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên.");
                return;
            }
            int masv = int.Parse(SinhVienCombox.Text.Split(' ')[0]);
            tgdk.getSemeterToRegister();
            if (curtime < tgdk.getStartTime())
            {
                NotiLabel.Text = "(*) Chưa đến thời gian đăng ký học phần!";
                MessageBox.Show("(*) Chưa đến thời gian đăng ký học phần!");
            }
            else if (curtime > tgdk.getEndTime())
            {
                NotiLabel.Text = "(*) Thời gian đăng ký học phần đã kết thúc từ " + tgdk.getEndTime().ToString("HH:mm:ss dd/MM/yyyy");
                MessageBox.Show("(*) Thời gian đăng ký học phần đã kết thúc từ " + tgdk.getEndTime().ToString("HH:mm:ss dd/MM/yyyy"));
            }
            else if (curtime >= tgdk.getStartTime() && curtime <= tgdk.getEndTime())
            {
                NotiLabel.Text = "(*) Đang trong thời gian đăng ký (" + tgdk.getStartTime().ToString("HH:mm:ss dd/MM/yyyy") + "-" + tgdk.getEndTime().ToString("HH:mm:ss dd/MM/yyyy") + "), chọn những học phần muốn đăng ký!";
                MessageBox.Show("(*) Đang trong thời gian đăng ký, bạn có thể đăng ký học phần!");
                getRegisterCourse(masv);
                getResult(masv);
            }
        }

        private void CustomizeRegisterDataGrid()
        {
            // Change column headers to custom names
            RegisterDataGridView.Columns["MAHP"].HeaderText = "Mã HP";
            RegisterDataGridView.Columns["TENHP"].HeaderText = "Tên Học Phần";
            RegisterDataGridView.Columns["NAM/HK"].HeaderText = "Năm/HK";
            RegisterDataGridView.Columns["NGAYHOC"].HeaderText = "Ngày Học";
            RegisterDataGridView.Columns["TIET"].HeaderText = "Tiết Học";
            RegisterDataGridView.Columns["SOTC"].HeaderText = "Số TC";
            RegisterDataGridView.Columns["SOSVTD"].HeaderText = "Số SVTD";
            RegisterDataGridView.Columns["SOSVTD"].HeaderText = "Số SVDK";
            RegisterDataGridView.Columns["MADV"].HeaderText = "Mã Đơn Vị";
            // Change column width
            RegisterDataGridView.Columns["TENHP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            foreach (DataGridViewColumn column in RegisterDataGridView.Columns)
            {
                if (column.Name == "Đăng Ký")
                {
                    return; // Column already exists, no need to add it
                }
            }

            DataGridViewColumn reg_column = new DataGridViewCheckBoxColumn();
            reg_column.DataPropertyName = "IsRegistered";
            reg_column.Name = "Đăng Ký";
            RegisterDataGridView.Columns.Add(reg_column);
        }

        private void CustomizeResultDataGrid()
        {
            // Change column headers to custom names
            ResultGridView.Columns["MAHP"].HeaderText = "Mã HP";
            ResultGridView.Columns["TENHP"].HeaderText = "Tên Học Phần";
            ResultGridView.Columns["NAM/HK"].HeaderText = "Năm/HK";
            ResultGridView.Columns["NGAYHOC"].HeaderText = "Ngày Học";
            ResultGridView.Columns["TIET"].HeaderText = "Tiết Học";
            ResultGridView.Columns["SOTC"].HeaderText = "Số TC";
            ResultGridView.Columns["SOSVTD"].HeaderText = "Số SVTD";
            ResultGridView.Columns["SOSVDK"].HeaderText = "Số SVDK";
            ResultGridView.Columns["MADV"].HeaderText = "Mã Đơn Vị";
            // Change column width
            ResultGridView.Columns["TENHP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            foreach (DataGridViewColumn column in ResultGridView.Columns)
            {
                if (column.Name == "Hủy Đăng Ký")
                {
                    return; // Column already exists, no need to add it
                }
            }

            DataGridViewColumn cancel_column = new DataGridViewCheckBoxColumn();
            cancel_column.DataPropertyName = "IsCanceled";
            cancel_column.Name = "Hủy Đăng Ký";
            ResultGridView.Columns.Add(cancel_column);
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            int masv = int.Parse(SinhVienCombox.Text.Split(' ')[0]);
            // Get the checked rows
            List<DataGridViewRow> checkedRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in RegisterDataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Đăng Ký"].Value))
                {
                    checkedRows.Add(row);
                }
            }

            OracleTransaction trans = Session.Instance.OracleConnection.BeginTransaction();

            try
            {
                foreach (DataGridViewRow row in checkedRows)
                {
                    //int masv = int.Parse(sv.id);
                    string mahp = row.Cells["MAHP"].Value.ToString();
                    int hk = tgdk.getSem();
                    string nam = tgdk.getYear();
                    string mact = tgdk.getProgram();
                    string ngayhoc = row.Cells["NGAYHOC"].Value.ToString();
                    string tiet = row.Cells["TIET"].Value.ToString();

                    string sql = "INSERT INTO QLTH.QLTH_DANGKY (MASV, MAHP, HK, NAM, MACT, NGAYHOC, TIET) VALUES (:MASV, :MAHP, :HK, :NAM, :MACT, :NGAYHOC, :TIET)";
                    OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
                    cmd.Parameters.Add("MASV", masv);
                    cmd.Parameters.Add("MAHP", mahp);
                    cmd.Parameters.Add("HK", hk);
                    cmd.Parameters.Add("NAM", nam);
                    cmd.Parameters.Add("MACT", mact);
                    cmd.Parameters.Add("NGAYHOC", ngayhoc);
                    cmd.Parameters.Add("TIET", tiet);
                    cmd.ExecuteNonQuery();
                }

                trans.Commit();
                MessageBox.Show("Đăng ký học phần thành công!");
            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show("Lỗi đăng ký học phần: " + ex.Message);
            }

            getRegisterCourse(masv);
            getResult(masv);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            int masv = int.Parse(SinhVienCombox.Text.Split(' ')[0]);
            // Get the checked rows
            List<DataGridViewRow> checkedRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in ResultGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Hủy Đăng Ký"].Value))
                {
                    checkedRows.Add(row);
                }
            }

            OracleTransaction trans = Session.Instance.OracleConnection.BeginTransaction();

            try
            {
                foreach (DataGridViewRow row in checkedRows)
                {
                    //int masv = int.Parse(sv.id);
                    string mahp = row.Cells["MAHP"].Value.ToString();
                    int hk = tgdk.getSem();
                    string nam = tgdk.getYear();
                    string mact = tgdk.getProgram();
                    string ngayhoc = row.Cells["NGAYHOC"].Value.ToString();
                    string tiet = row.Cells["TIET"].Value.ToString();

                    string sql = "DELETE FROM QLTH.QLTH_DANGKY WHERE MASV = :MASV AND MAHP = :MAHP AND HK = :HK AND NAM = :NAM AND MACT = :MACT AND NGAYHOC = :NGAYHOC AND TIET = :TIET";
                    OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
                    cmd.Parameters.Add("MASV", masv);
                    cmd.Parameters.Add("MAHP", mahp);
                    cmd.Parameters.Add("HK", hk);
                    cmd.Parameters.Add("NAM", nam);
                    cmd.Parameters.Add("MACT", mact);
                    cmd.Parameters.Add("NGAYHOC", ngayhoc);
                    cmd.Parameters.Add("TIET", tiet);
                    cmd.ExecuteNonQuery();
                }

                trans.Commit();
                MessageBox.Show("Hủy đăng ký học phần thành công!");
            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show("Lỗi hủy đăng ký học phần: " + ex.Message);
            }

            getRegisterCourse(masv);
            getResult(masv);
        }
    }
}

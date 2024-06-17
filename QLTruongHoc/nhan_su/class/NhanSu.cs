using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;

namespace QLTruongHoc.nhan_su
{
    public class NhanSu
    {
        public string id;
        public string name;
        public string gender;
        public string birthday;
        public string addr;
        public string phonenum;
        public string allowance;
        public string role;
        public string department;
        public string location;
        public NhanSu()
        {
            id = "";
            name = "";
            birthday = "";
            addr = "";
            phonenum = "";
            allowance = "";
            role = "";
            department = "";
            location = "";
        }
        public void getEmpInfo()
        {
            string query_sql = "SELECT TO_CHAR(MANS), HOTEN, PHAI, TO_CHAR(NGSINH), DIACHI, DT, TO_CHAR(PHUCAP), VAITRO, MADV, MACS FROM QLTH.QLTH_NHANSU";
            if (Session.Instance.Role == "Trưởng khoa")
            {
                query_sql = "SELECT TO_CHAR(MANS), HOTEN, PHAI, TO_CHAR(NGSINH), DIACHI, DT, TO_CHAR(PHUCAP), VAITRO, MADV, MACS FROM QLTH.QLTH_NHANSU WHERE TO_CHAR(MANS) = " + Session.Instance.Username;
            }
            OracleCommand cmd = new OracleCommand(query_sql, Session.Instance.OracleConnection);
            try
            {
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        this.id = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(MANS)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(MANS)"));
                        this.name = reader.IsDBNull(reader.GetOrdinal("HOTEN")) ? "" : reader.GetString(reader.GetOrdinal("HOTEN"));
                        this.gender = reader.IsDBNull(reader.GetOrdinal("PHAI")) ? "" : reader.GetString(reader.GetOrdinal("PHAI"));
                        this.birthday = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(NGSINH)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(NGSINH)"));
                        this.addr = reader.IsDBNull(reader.GetOrdinal("DIACHI")) ? "" : reader.GetString(reader.GetOrdinal("DIACHI"));
                        this.phonenum = reader.IsDBNull(reader.GetOrdinal("DT")) ? "" : reader.GetString(reader.GetOrdinal("DT"));
                        this.allowance = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(PHUCAP)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(PHUCAP)"));
                        this.role = reader.IsDBNull(reader.GetOrdinal("VAITRO")) ? "" : reader.GetString(reader.GetOrdinal("VAITRO"));
                        this.department = reader.IsDBNull(reader.GetOrdinal("MADV")) ? "" : reader.GetString(reader.GetOrdinal("MADV"));
                        this.location = reader.IsDBNull(reader.GetOrdinal("MACS")) ? "" : reader.GetString(reader.GetOrdinal("MACS"));
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}

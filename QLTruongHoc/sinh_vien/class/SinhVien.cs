using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;


namespace QLTruongHoc.sinh_vien
{
    public class SinhVien
    {
        public string id;
        public string name;
        public string gender;
        public string birthday;
        public string addr;
        public string phonenum;
        public string program;
        public string major;
        public string credit;
        public string grade;
        public SinhVien()
        {
            id = "";
            name = "";
            birthday = "";
            addr = "";
            phonenum = "";
            program = "";
            major = "";
            credit = "";
            grade = "";
        }
        public void getStuInfo()
        {
            string query_sql = "SELECT TO_CHAR(MASV), HOTEN, PHAI, TO_CHAR(NGSINH), DIACHI, DT, MACT, MANGANH, TO_CHAR(SOTCTL), TO_CHAR(DTBTL) FROM QLTH.QLTH_SINHVIEN";
            OracleCommand cmd = new OracleCommand(query_sql, Session.Instance.OracleConnection);
            try
            {
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        this.id = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(MASV)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(MASV)"));
                        this.name = reader.IsDBNull(reader.GetOrdinal("HOTEN")) ? "" : reader.GetString(reader.GetOrdinal("HOTEN"));
                        this.gender = reader.IsDBNull(reader.GetOrdinal("PHAI")) ? "" : reader.GetString(reader.GetOrdinal("PHAI"));
                        this.birthday = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(NGSINH)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(NGSINH)"));
                        this.addr = reader.IsDBNull(reader.GetOrdinal("DIACHI")) ? "" : reader.GetString(reader.GetOrdinal("DIACHI"));
                        this.phonenum = reader.IsDBNull(reader.GetOrdinal("DT")) ? "" : reader.GetString(reader.GetOrdinal("DT"));
                        this.program = reader.IsDBNull(reader.GetOrdinal("MACT")) ? "" : reader.GetString(reader.GetOrdinal("MACT"));
                        this.major = reader.IsDBNull(reader.GetOrdinal("MANGANH")) ? "" : reader.GetString(reader.GetOrdinal("MANGANH"));
                        this.credit = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(SOTCTL)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(SOTCTL)"));
                        this.grade = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(DTBTL)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(DTBTL)"));
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu!");
                MessageBox.Show(ex.Message);
                return;
            }
        }

    }
}
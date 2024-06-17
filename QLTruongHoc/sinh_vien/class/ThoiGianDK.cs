using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;

namespace QLTruongHoc.sinh_vien
{
    public class ThoiGianDK
    {
        DateTime start_time;
        DateTime end_time;
        string year;
        int sem;
        string program;

        public ThoiGianDK()
        {
            start_time = new DateTime();
            end_time = new DateTime();
            year = "";
            sem = 0;
        }
        public DateTime getStartTime()
        {
            return start_time;
        }
        public DateTime getEndTime()
        {
            return end_time;
        }
        public string getYear()
        {
            return year;
        }
        public int getSem()
        {
            return sem;
        }

        public string getProgram()
        {
            return program;
        }

        public void getSemeterToRegister()
        {
            string query_sql = "SELECT NAM, HK, MACT, NGAYBD, NGAYKT FROM (SELECT * FROM QLTH.QLTH_THOIGIANDK ORDER BY NGAYBD DESC) WHERE ROWNUM = 1";
            OracleCommand cmd = new OracleCommand(query_sql, Session.Instance.OracleConnection);
            try
            {
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        year = reader.IsDBNull(reader.GetOrdinal("NAM")) ? "" : reader.GetString(reader.GetOrdinal("NAM"));
                        sem = reader.IsDBNull(reader.GetOrdinal("HK")) ? 0 : reader.GetInt32(reader.GetOrdinal("HK"));
                        program = reader.IsDBNull(reader.GetOrdinal("MACT")) ? "" : reader.GetString(reader.GetOrdinal("MACT"));
                        start_time = reader.IsDBNull(reader.GetOrdinal("NGAYBD")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("NGAYBD"));
                        end_time = reader.IsDBNull(reader.GetOrdinal("NGAYKT")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("NGAYKT"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi getSem");
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
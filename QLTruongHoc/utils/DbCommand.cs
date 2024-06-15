using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTruongHoc.utils
{
    public partial class DbCommand
    {
        static public void setDateFormatDb()
        {
            string sql = $"ALTER SESSION SET NLS_DATE_FORMAT = 'YYYY-MM-DD'";
            OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
            cmd.ExecuteNonQuery();
        }

        static public string getUserDv()
        {
            string sql = $"select madv " +
                $"from qlth.qlth_nhansu " +
                $"where mans = SYS_CONTEXT('USERENV', 'SESSION_USER')";

            OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string madv = reader["MADV"].ToString();
                return madv;
            }

            return "";
            
        }
    }
}

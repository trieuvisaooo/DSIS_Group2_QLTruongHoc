using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System.Drawing;

namespace QLTruongHoc.nhan_su.forms
{
    public partial class InsertKHMO : Form
    {
        public InsertKHMO()
        {
            InitializeComponent();
            getCourses();
            getProgram();
        }

        private void getCourses()
        {
            string sql = "select mahp, tenhp from qlth.qlth_hocphan";
            OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string mahp = dr.GetString(0);
                string tenhp = dr.GetString(1);

                if (!string.IsNullOrEmpty(tenhp))
                {
                    mahp += " - " + tenhp;
                }

                CourseCombox.Items.Add(mahp);
            }
        }

        private void getProgram()
        {
            string sql = "select mact from qlth.qlth_chuongtrinh";
            OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string mact = dr.GetString(0);

                ProgramCombox.Items.Add(mact);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string hocPhan = CourseCombox.SelectedItem.ToString().Split(' ')[0];
            string nam = comboBox3.SelectedItem.ToString();
            int hk = int.Parse(comboBox4.SelectedItem.ToString());
            string mact = ProgramCombox.SelectedItem.ToString();

            string sql = $"insert into qlth.qlth_khmo(mahp, nam, hk, mact) " +
                $"values ('{hocPhan}' , '{nam}', {hk}, '{mact}')";

            OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Tạo mới khóa học mở thành công");
            this.Close();

        }
    }
}

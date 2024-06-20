using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void getProgram()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
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
            } catch (Exception ex)
            {
                MessageBox.Show("Tạo mới khóa học mở thất bại.");
            }

        }
    }
}

using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;

namespace QLTruongHoc.nhan_su.forms
{
    public partial class InsertTGDK : Form
    {
        public InsertTGDK()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string sql = "insert into qlth.qlth_thoigiandk(nam, hk, mact, ngaybd, ngaykt) values (" +
                        $"'{YearTxtBox.Text}', {SemComBox.Text}, '{ProgramComBox.Text}', TO_TIMESTAMP('{StartTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss")}', 'YYYY-MM-DD HH24:MI:SS'), TO_TIMESTAMP('{EndTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss")}', 'YYYY-MM-DD HH24:MI:SS') )";
            //MessageBox.Show(sql);
            
            try
            {
                OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tạo mới thành công!");
                this.Close();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

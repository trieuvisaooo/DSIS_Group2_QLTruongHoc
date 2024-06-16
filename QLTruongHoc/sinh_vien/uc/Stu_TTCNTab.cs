using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;

namespace QLTruongHoc.sinh_vien.uc
{
    public partial class Stu_TTCNTab : UserControl
    {
        SinhVien sv = new SinhVien();
        public Stu_TTCNTab()
        {
            InitializeComponent();
        }

        private void TTCNSVTab_Load(object sender, EventArgs e)
        {

            IdTxtBox.Visible = false;
            NameTxtBox.Visible = false;
            GenderTxtBox.Visible = false;
            BirthDayTxtBox.Visible = false;
            AddrTxtBox.Visible = false;
            PhoneNumTxtBox.Visible = false;
            ProgramTxtBox.Visible = false;
            MajorTxtBox.Visible = false;
            CreditTxtBox.Visible = false;
            GradeTxtBox.Visible = false;
            ModifyBtn.Visible = false;
            SaveBtn.Visible = false;
            CancelBtn.Visible = false;
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            ViewBtn.Visible = false;
            sv.getStuInfo();
            IdTxtBox.Text = sv.id;
            NameTxtBox.Text = sv.name;
            GenderTxtBox.Text = sv.gender;
            BirthDayTxtBox.Text = sv.birthday;
            AddrTxtBox.Text = sv.addr;
            PhoneNumTxtBox.Text = sv.phonenum;
            ProgramTxtBox.Text = sv.program;
            MajorTxtBox.Text = sv.major;
            CreditTxtBox.Text = sv.credit;
            GradeTxtBox.Text = sv.grade;

            IdTxtBox.Visible = true;
            NameTxtBox.Visible = true;
            GenderTxtBox.Visible = true;
            BirthDayTxtBox.Visible = true;
            AddrTxtBox.Visible = true;
            PhoneNumTxtBox.Visible = true;
            ProgramTxtBox.Visible = true;
            MajorTxtBox.Visible = true;
            CreditTxtBox.Visible = true;
            GradeTxtBox.Visible = true;
            ModifyBtn.Visible = true;

            IdTxtBox.ReadOnly = true;
            NameTxtBox.ReadOnly = true;
            GenderTxtBox.ReadOnly = true;
            BirthDayTxtBox.ReadOnly = true;
            AddrTxtBox.ReadOnly = true;
            PhoneNumTxtBox.ReadOnly = true;
            ProgramTxtBox.ReadOnly = true;
            MajorTxtBox.ReadOnly = true;
            CreditTxtBox.ReadOnly = true;
            GradeTxtBox.ReadOnly = true;
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            AddrTxtBox.ReadOnly = false;
            PhoneNumTxtBox.ReadOnly = false;
            ModifyBtn.Visible = false;
            SaveBtn.Visible = true;
            CancelBtn.Visible = true;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ModifyBtn.Visible = true;
            AddrTxtBox.Text = sv.addr;
            PhoneNumTxtBox.Text = sv.phonenum;
            AddrTxtBox.ReadOnly = true;
            PhoneNumTxtBox.ReadOnly = true;
            SaveBtn.Visible = false;
            CancelBtn.Visible = false;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string update_sql = "UPDATE QLTH.QLTH_SINHVIEN SET DIACHI = N'" + AddrTxtBox.Text.ToString() + "', DT = '" + PhoneNumTxtBox.Text.ToString() + "'";
                OracleCommand cmd = new OracleCommand(update_sql, Session.Instance.OracleConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thông tin thành công!");
                AddrTxtBox.ReadOnly = true;
                PhoneNumTxtBox.ReadOnly = true;
                SaveBtn.Visible = false;
                CancelBtn.Visible = false;
                ModifyBtn.Visible = true;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
    }
}

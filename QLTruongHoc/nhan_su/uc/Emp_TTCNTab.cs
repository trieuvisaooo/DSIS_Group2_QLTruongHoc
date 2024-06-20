using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;

namespace QLTruongHoc.nhan_su.uc
{
    public partial class Emp_TTCNTab : UserControl
    {
        NhanSu ns = new NhanSu();
        public Emp_TTCNTab()
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
            AllowanceTxtBox.Visible = false;
            RoleTxtBox.Visible = false;
            DepartmentTxtBox.Visible = false;
            LocationTxtBox.Visible = false;
            ModifyBtn.Visible = false;
            SaveBtn.Visible = false;
            CancelBtn.Visible = false;
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            ViewBtn.Visible = false;
            ns.getEmpInfo();
            IdTxtBox.Text = ns.id;
            NameTxtBox.Text = ns.name;
            GenderTxtBox.Text = ns.gender;
            DateTime birthday;
            if (DateTime.TryParse(ns.birthday, out birthday))
            {
                BirthDayTxtBox.Text = birthday.ToString("dd/MM/yyyy");
            }
            else
            {
                BirthDayTxtBox.Text = "";
            }
            AddrTxtBox.Text = ns.addr;
            PhoneNumTxtBox.Text = ns.phonenum;
            AllowanceTxtBox.Text = ns.allowance;
            RoleTxtBox.Text = ns.role;
            DepartmentTxtBox.Text = ns.department;
            LocationTxtBox.Text = ns.location;

            IdTxtBox.Visible = true;
            NameTxtBox.Visible = true;
            GenderTxtBox.Visible = true;
            BirthDayTxtBox.Visible = true;
            AddrTxtBox.Visible = true;
            PhoneNumTxtBox.Visible = true;
            AllowanceTxtBox.Visible = true;
            RoleTxtBox.Visible = true;
            DepartmentTxtBox.Visible = true;
            LocationTxtBox.Visible = true;
            ModifyBtn.Visible = true;


            IdTxtBox.ReadOnly = true;
            NameTxtBox.ReadOnly = true;
            GenderTxtBox.ReadOnly = true;
            BirthDayTxtBox.ReadOnly = true;
            AddrTxtBox.ReadOnly = true;
            PhoneNumTxtBox.ReadOnly = true;
            AllowanceTxtBox.ReadOnly = true;
            RoleTxtBox.ReadOnly = true;
            DepartmentTxtBox.ReadOnly = true;
            LocationTxtBox.ReadOnly = true;
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            if (Session.Instance.Role == "Trưởng khoa")
            {
                NameTxtBox.ReadOnly = false;
                GenderTxtBox.ReadOnly = false;
                BirthDayTxtBox.ReadOnly = false;
                AddrTxtBox.ReadOnly = false;
                PhoneNumTxtBox.ReadOnly = false;
            }
            else
            {
                //AddrTxtBox.ReadOnly = false;
                PhoneNumTxtBox.ReadOnly = false;
            }
            ModifyBtn.Visible = false;
            SaveBtn.Visible = true;
            CancelBtn.Visible = true;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ns.getEmpInfo();
            if (Session.Instance.Role == "Trưởng khoa")
            {
                NameTxtBox.ReadOnly = true;
                GenderTxtBox.ReadOnly = true;
                BirthDayTxtBox.ReadOnly = true;
                AddrTxtBox.ReadOnly = true;
                PhoneNumTxtBox.ReadOnly = true;

                NameTxtBox.Text = ns.name;
                GenderTxtBox.Text = ns.gender;
                DateTime birthday;
                if (DateTime.TryParse(ns.birthday, out birthday))
                {
                    BirthDayTxtBox.Text = birthday.ToString("dd/MM/yyyy");
                }
                else
                {
                    BirthDayTxtBox.Text = "";
                }
                AddrTxtBox.Text = ns.addr;
                PhoneNumTxtBox.Text = ns.phonenum;
            }
            else
            {
                //ModifyBtn.Visible = true;
                PhoneNumTxtBox.Text = ns.phonenum;
                PhoneNumTxtBox.ReadOnly = true;
                //SaveBtn.Visible = false;
                //CancelBtn.Visible = false;
            }

            ModifyBtn.Visible = true;
            SaveBtn.Visible = false;
            CancelBtn.Visible = false;

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (Session.Instance.Role == "Trưởng khoa")
            {
                try
                {
                    string update_sql = "UPDATE QLTH.QLTH_NHANSU " 
                                        + $"SET HOTEN = N'{NameTxtBox.Text}', PHAI = N'{GenderTxtBox.Text}', NGSINH = TO_DATE('{BirthDayTxtBox.Text}', 'DD/MM/YYYY'), DIACHI = N'{AddrTxtBox.Text}',DT = '{PhoneNumTxtBox.Text}'"
                                        + $"WHERE MANS = TO_NUMBER({IdTxtBox.Text})";
                    OracleCommand cmd = new OracleCommand(update_sql, Session.Instance.OracleConnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin thành công!");
                    NameTxtBox.ReadOnly = true;
                    GenderTxtBox.ReadOnly = true;
                    BirthDayTxtBox.ReadOnly = true;
                    AddrTxtBox.ReadOnly = true;
                    PhoneNumTxtBox.ReadOnly = true;

                    SaveBtn.Visible = false;
                    CancelBtn.Visible = false;
                    ModifyBtn.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật thông tin thất bại!");
                    //MessageBox.Show(ex.Message);
                }
            } else
            {
                try
                {
                    string update_sql = "UPDATE QLTH.QLTH_NHANSU SET DT = '" + PhoneNumTxtBox.Text.ToString() + "'";
                    OracleCommand cmd = new OracleCommand(update_sql, Session.Instance.OracleConnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin thành công!");
                    PhoneNumTxtBox.ReadOnly = true;
                    SaveBtn.Visible = false;
                    CancelBtn.Visible = false;
                    ModifyBtn.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật thông tin thất bại!");
                    //MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
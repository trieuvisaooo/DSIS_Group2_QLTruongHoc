using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.nhan_su.uc;
using QLTruongHoc.utils;
using System.Data;

namespace QLTruongHoc.nhan_su.forms
{
    public partial class UpdateNhanSu : Form
    {
        NhanSu ns = new NhanSu();
        public UpdateNhanSu(int mans)
        {
            InitializeComponent();
            ns.getEmpInfo(mans);
            fetchData();
        }

        private void fetchData()
        {
            IdTxtBox.Text = ns.id.ToString();
            IdTxtBox.ReadOnly = true;
            NameTxtBox.Text = ns.name;
            GenderComBox.Text = ns.gender;
            DateTime birthday;
            if (DateTime.TryParse(ns.birthday, out birthday))
            {
                DateOfBirthPicker.Value = birthday;
            }
            AddrTxtbox.Text = ns.addr;
            PhoneTxtBox.Text = ns.phonenum;
            AllowanceNumericUpDown.Value = ns.allowance == "" ? 0 : int.Parse(ns.allowance);
            RoleComBox.Text = ns.role;
            DepartmentCombox.Text = ns.department;
            LocationCombox.Text = ns.location;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "update qlth.qlth_nhansu"
                            + $" set hoten = N'{NameTxtBox.Text}', phai = N'{GenderComBox.SelectedItem.ToString()}', ngsinh = TO_DATE('{DateOfBirthPicker.Value.ToString("dd/MM/yyyy")}', 'dd/mm/yyyy'), diachi = N'{AddrTxtbox.Text}', dt = '{PhoneTxtBox.Text}', phucap = {AllowanceNumericUpDown.Value}, vaitro = N'{RoleComBox.SelectedItem.ToString()}', madv = '{DepartmentCombox.SelectedItem.ToString()}', macs = '{LocationCombox.SelectedItem.ToString()}' "
                            + $"where mans = TO_NUMBER({ns.id})";
                OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
                //MessageBox.Show(sql);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cập nhật thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                // Consider logging the exception details here
                MessageBox.Show(ex.Message);
            }
        }

    }
}

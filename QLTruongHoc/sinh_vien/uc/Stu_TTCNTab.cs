using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTruongHoc.sinh_vien.uc
{
    public partial class Stu_TTCNTab : UserControl
    {
        SinhVien sv = new SinhVien();
        public Stu_TTCNTab()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //private void getStuInfo(SinhVien sv)
        //{
        //    string query_sql = "SELECT TO_CHAR(MASV), HOTEN, PHAI, TO_CHAR(NGSINH), DIACHI, DT, MACT, MANGANH, TO_CHAR(SOTCTL), TO_CHAR(DTBTL) FROM QLTH.QLTH_SINHVIEN";
        //    OracleCommand cmd = new OracleCommand(query_sql, Session.Instance.OracleConnection);
        //    try
        //    {
        //        using (OracleDataReader reader = cmd.ExecuteReader())
        //        {
        //            if (reader.Read())
        //            {
        //                sv.id = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(MASV)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(MASV)"));
        //                sv.name = reader.IsDBNull(reader.GetOrdinal("HOTEN")) ? "" : reader.GetString(reader.GetOrdinal("HOTEN"));
        //                sv.gender = reader.IsDBNull(reader.GetOrdinal("PHAI")) ? "" : reader.GetString(reader.GetOrdinal("PHAI"));
        //                sv.birthday = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(NGSINH)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(NGSINH)"));
        //                sv.addr = reader.IsDBNull(reader.GetOrdinal("DIACHI")) ? "" : reader.GetString(reader.GetOrdinal("DIACHI"));
        //                sv.phonenum = reader.IsDBNull(reader.GetOrdinal("DT")) ? "" : reader.GetString(reader.GetOrdinal("DT"));
        //                sv.program = reader.IsDBNull(reader.GetOrdinal("MACT")) ? "" : reader.GetString(reader.GetOrdinal("MACT"));
        //                sv.major = reader.IsDBNull(reader.GetOrdinal("MANGANH")) ? "" : reader.GetString(reader.GetOrdinal("MANGANH"));
        //                sv.credit = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(SOTCTL)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(SOTCTL)"));
        //                sv.grade = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(DTBTL)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(DTBTL)"));
        //                return;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return;
        //    }

        //}

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

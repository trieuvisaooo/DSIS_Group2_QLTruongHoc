using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTruongHoc.nhan_su.forms
{
    public partial class UpdateTGDK : Form
    {
        public UpdateTGDK()
        {
            InitializeComponent();
        }
        string nam;
        decimal hk;
        string mact;
        public UpdateTGDK(string nam, decimal hk, string mact)
        {
            InitializeComponent();
            this.nam = nam;
            this.hk = hk;
            this.mact = mact;
            fetchTGDK();
        }

        private void fetchTGDK()
        {
            SemTxtBox.Text = hk.ToString();
            SemTxtBox.ReadOnly = true;
            ProgramTxtBox.Text = mact;
            ProgramTxtBox.ReadOnly = true;
            YearTxtBox.Text = nam;
            YearTxtBox.ReadOnly = true;
            try
            {
                string sql = $"select ngaybd, ngaykt from qlth.qlth_thoigiandk where nam = '{this.nam}' and hk = {this.hk} and mact = '{this.mact}'";
                OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string startDateStr = reader["NGAYBD"].ToString();
                    DateTime startDate = startDateStr.Length == 0 ? DateTime.Today : DateTime.Parse(startDateStr, CultureInfo.InvariantCulture);
                    StartTimePicker.Value = startDate;

                    string endDateStr = reader["NGAYKT"].ToString();
                    DateTime endDate = endDateStr.Length == 0 ? DateTime.Today : DateTime.Parse(endDateStr, CultureInfo.InvariantCulture);
                    EndTimePicker.Value = endDate;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string sql = "update qlth.qlth_thoigiandk " +
                        $"set ngaybd = TO_TIMESTAMP('{StartTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss")}', 'YYYY-MM-DD HH24:MI:SS'), ngaykt = TO_TIMESTAMP('{EndTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss")}', 'YYYY-MM-DD HH24:MI:SS') " +
                        $"where nam = '{this.nam}' and hk = {this.hk} and mact = '{this.mact}'";

            //MessageBox.Show(sql);
            try
            {
                OracleCommand cmd = new OracleCommand(sql, Session.Instance.OracleConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thông tin thành công!");
                this.Close();
            } catch
            {
                MessageBox.Show("Cập nhật không thành công!");
            }
        }
    }
}

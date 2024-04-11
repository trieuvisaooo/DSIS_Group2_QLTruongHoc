using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTruongHoc
{
    public partial class DBA_GrantRevokeSysPrivs : Form
    {
        public DBA_GrantRevokeSysPrivs()
        {
            InitializeComponent();
        }

        private void SysPrivs_combox_DataContextChanged(object sender, EventArgs e)
        {

        }

        private void SysPrivs_combox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DBA_GrantRevokeSysPrivs_Load(object sender, EventArgs e)
        {
            try
            {
                string selectSysPrivsSql = "select * from session_privs order by PRIVILEGE ASC";
                OracleCommand comm = new OracleCommand(selectSysPrivsSql, Login.con);
                OracleDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    SysPrivs_combox.Items.Add(reader[0]);
                };
                reader.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            if (grant_revoke_combox == null)
            {
                MessageBox.Show("Không được để trống hành động muốn thực hiện!");
            } else if (SysPrivs_combox == null)
            {
                MessageBox.Show("Vui lòng điền quyền hệ thống muốn cấp/thu hồi!");
            } else if (user_role_txtbox == null)
            {
                MessageBox.Show("Vui lòng điền tên user/role muốn cấp/thu hồi quyền!");
            }
            else
            {
                try
                {
                    string sqlStatement;
                    if (grant_revoke_combox.Text == "GRANT")
                    {
                        sqlStatement = grant_revoke_combox.Text + " " + SysPrivs_combox.Text + " TO " + user_role_txtbox.Text;
                    }
                    else
                    {
                        sqlStatement = grant_revoke_combox.Text + " " + SysPrivs_combox.Text + " FROM " + user_role_txtbox.Text;
                    }

                    OracleCommand cmd = new OracleCommand(sqlStatement, Login.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thực hiện thao tác " + grant_revoke_combox.Text + " thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

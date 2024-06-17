using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;

namespace QLTruongHoc
{
    public partial class GrantRevokeSysPrivs : Form
    {

        public GrantRevokeSysPrivs()
        {
            InitializeComponent();
        }

        public void getGrantSysPrivs()
        {
            SysPrivs_combox.Items.Clear();
            try
            {
                string selectSysPrivsSql = "select * from session_privs order by PRIVILEGE ASC";
                OracleCommand cmd = new OracleCommand(selectSysPrivsSql, Session.Instance.OracleConnection);
                OracleDataReader reader = cmd.ExecuteReader();
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

        public void getRevokeSysPrivs()
        {
            SysPrivs_combox.Items.Clear();
            try
            {
                string selectSysPrivsSql = "select privilege from dba_sys_privs where grantee =  " + "\'" + user_role_txtbox.Text + "\'" + " order by privilege asc";
                //MessageBox.Show(selectSysPrivsSql); // debug line
                OracleCommand cmd = new OracleCommand(selectSysPrivsSql, Session.Instance.OracleConnection);
                OracleDataReader reader = cmd.ExecuteReader();
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


        private void DBA_GrantRevokeSysPrivs_Load(object sender, EventArgs e)
        {
            SysPrivs_combox.Enabled = false;
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            if (grant_revoke_combox == null)
            {
                MessageBox.Show("Không được để trống hành động muốn thực hiện!");
            }
            else if (SysPrivs_combox == null)
            {
                MessageBox.Show("Vui lòng điền quyền hệ thống muốn cấp/thu hồi!");
            }
            else if (user_role_txtbox == null)
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

                    OracleCommand cmd = new OracleCommand(sqlStatement, Session.Instance.OracleConnection);
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

        private void grant_revoke_combox_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectSysPrivsSql;
            OracleCommand cmd;
            OracleDataReader reader;
            if (grant_revoke_combox.Text == "GRANT" && (check_result.Text == "Valid User!" || check_result.Text == "Valid Role!"))
            {
                SysPrivs_combox.Enabled = true;
                getGrantSysPrivs();
            }

            if (grant_revoke_combox.Text == "REVOKE" && (check_result.Text == "Valid User!" || check_result.Text == "Valid Role!"))
            {
                getRevokeSysPrivs();
                if (SysPrivs_combox.Items.Count == 0)
                {
                    MessageBox.Show("User/Role vừa nhập không có quyền hệ thống nào cần thu hồi!");
                    SysPrivs_combox.Enabled = false;
                }

            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            // kiem tra tinh hop le cua user
            try
            {
                string checkUserStatement = "select count(*) from dba_users where username = \'" + user_role_txtbox.Text + "\'";
                string checkRoleStatement = "select count(*) from dba_roles where role = \'" + user_role_txtbox.Text + "\'";
                OracleCommand cmd1 = new OracleCommand(checkUserStatement, Session.Instance.OracleConnection);
                OracleCommand cmd2 = new OracleCommand(checkRoleStatement, Session.Instance.OracleConnection);
                OracleDataReader reader1 = cmd1.ExecuteReader();
                OracleDataReader reader2 = cmd2.ExecuteReader();
                reader1.Read();
                reader2.Read();
                if (reader1.GetInt32(0) == 0 && reader2.GetInt32(0) == 0)
                {
                    check_result.Text = "Invalid User/Role!";
                    SysPrivs_combox.Enabled = false;
                }
                else if (reader1.GetInt32(0) == 1)
                {
                    check_result.Text = "Valid User!";
                    SysPrivs_combox.Enabled = true;

                }
                else if (reader2.GetInt32(0) == 1)
                {
                    check_result.Text = "Valid Role!";
                    SysPrivs_combox.Enabled = true;

                }
                reader1.Close();
                reader2.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // hien thi cap quyen muon revoke
            if ((check_result.Text == "Valid User!" || check_result.Text == "Valid Role!") && (grant_revoke_combox.Text == "REVOKE"))
            {
                getRevokeSysPrivs();
                if (SysPrivs_combox.Items.Count == 0)
                {
                    MessageBox.Show("User/Role vừa nhập không có quyền hệ thống nào cần thu hồi!");
                    SysPrivs_combox.Enabled = false;
                }
            }

            if ((check_result.Text == "Valid User!" || check_result.Text == "Valid Role!") && (grant_revoke_combox.Text == "GRANT"))
            {
                getGrantSysPrivs();
            }
        }
    }
}

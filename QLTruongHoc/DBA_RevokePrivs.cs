using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTruongHoc
{
    public partial class DBA_RevokePrivs : Form
    {
        public static OracleConnection con_current = Login.con;
        public DBA_RevokePrivs()
        {
            InitializeComponent();
        }

        private void DBA_RevokePrivs_Load(object sender, EventArgs e)
        {
            table_view_combox.Enabled = false;
            privs_combox.Enabled = false;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            // kiem tra user
            try
            {
                string checkUserStatement = "select count(*) from dba_users where username = \'" + user_role_txtbox.Text + "\'";
                string checkRoleStatement = "select count(*) from dba_roles where role = \'" + user_role_txtbox.Text + "\'";
                OracleCommand cmd1 = new OracleCommand(checkUserStatement, con_current);
                OracleCommand cmd2 = new OracleCommand(checkRoleStatement, con_current);
                OracleDataReader reader1 = cmd1.ExecuteReader();
                OracleDataReader reader2 = cmd2.ExecuteReader();
                reader1.Read();
                reader2.Read();
                if (reader1.GetInt32(0) == 0 && reader2.GetInt32(0) == 0)
                {
                    check_result.Text = "Invalid User/Role!";
                }
                else if (reader1.GetInt32(0) == 1)
                {
                    check_result.Text = "Valid User!";
                }
                else if (reader2.GetInt32(0) == 1)
                {
                    check_result.Text = "Valid Role!";
                }
                reader1.Close();
                reader2.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // kiem tra cac quyen tren bang hien co cua user
            table_view_combox.Items.Clear();
            if (check_result.Text != "Unchecked!" && check_result.Text != "Invalid User/Role!")
            {
                table_view_combox.Enabled = true;
                privs_combox.Enabled = true;
                string getTableStatement;
                OracleCommand getTableCmd;
                OracleDataReader reader3;
                if (check_result.Text == "Valid User!")
                {
                    try
                    {
                        getTableStatement = "select table_name from dba_tab_privs where owner = \'QLTH\'" + " and grantee = " + "\'" + user_role_txtbox.Text + "\'";
                        getTableCmd = new OracleCommand(getTableStatement, con_current);
                        reader3 = getTableCmd.ExecuteReader();
                        while (reader3.Read())
                        {
                            table_view_combox.Items.Add(reader3.GetString(0));
                        }
                        reader3.Close();
                        if (table_view_combox.Items.Count == 0)
                        {
                            MessageBox.Show("Không có object privilege nào trên user này. Vui lòng chọn user/role khác!");
                            table_view_combox.Enabled = false;
                            privs_combox.Enabled = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                if (check_result.Text == "Valid Role!")
                {
                    try
                    {
                        getTableStatement = "select table_name from dba_tab_privs where owner = \'QLTH\'" + " and grantee = " + "\'" + user_role_txtbox.Text + "\'";
                        //MessageBox.Show(getTableStatement); // debug line
                        getTableCmd = new OracleCommand(getTableStatement, con_current);
                        reader3 = getTableCmd.ExecuteReader();
                        while (reader3.Read())
                        {
                            table_view_combox.Items.Add(reader3.GetString(0));
                        }
                        reader3.Close();
                        if (table_view_combox.Items.Count == 0)
                        {
                            MessageBox.Show("Không có object privilege nào trên role này. Vui lòng chọn user/role khác!");
                            table_view_combox.Enabled = false;
                            privs_combox.Enabled = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            else if (check_result.Text == "Unchecked!" || check_result.Text == "Invalid User/Role!")
            {
                table_view_combox.Enabled = false;
                privs_combox.Enabled = false;
            }
        }

        private void table_view_combox_SelectedValueChanged(object sender, EventArgs e)
        {
            privs_combox.Items.Clear();
            string getPrivsStatement;
            OracleCommand cmd;
            OracleDataReader reader;
            if (check_result.Text == "Valid User!")
            {
                try
                {
                    getPrivsStatement = "select privilege from dba_tab_privs where owner = 'QLTH' and grantee = " + "\'" + user_role_txtbox.Text + "\' and table_name = " + "\'" + table_view_combox.Text + "\'";
                    cmd = new OracleCommand(getPrivsStatement, con_current);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        privs_combox.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            if (check_result.Text == "Valid Role!")
            {
                privs_combox.Items.Clear();
                try
                {
                    getPrivsStatement = "select privilege from dba_tab_privs where owner = 'QLTH' and grantee = " + "\'" + user_role_txtbox.Text + "\' and table_name = " + "\'" + table_view_combox.Text + "\'";
                    cmd = new OracleCommand(getPrivsStatement, con_current);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        privs_combox.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

        }

        private void revoke_btn_Click(object sender, EventArgs e)
        {
            if (user_role_txtbox.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập Username hoặc Role");
                return;
            }
            if (table_view_combox.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập Table hoặc View");
                return;
            }
            if (privs_combox.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập chọn quyền cần thu hồi");
                return;
            } else
            {
                try
                {
                    string revokeStetament = "revoke " + privs_combox.Text + " on QLTH." + table_view_combox.Text + " from " + user_role_txtbox.Text;
                    //MessageBox.Show(revokeStetament); // debug line
                    OracleCommand cmd = new OracleCommand(revokeStetament, con_current);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thực hiện thu hồi quyền " + privs_combox.Text + " trên " + table_view_combox.Text + " từ " + user_role_txtbox.Text + " thành công!");

                } catch (OracleException ex)
                {
                    //MessageBox.Show(ex.Message); // debug line
                    MessageBox.Show("Thực hiện thu hồi quyền " + privs_combox.Text + " trên " + table_view_combox.Text + " từ " + user_role_txtbox.Text + " thất bại!");
                    return;
                }
            }

        }
    }
}

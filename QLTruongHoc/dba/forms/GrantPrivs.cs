using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System.Data;

namespace QLTruongHoc
{
    public partial class GrantPrivs : Form
    {
        public GrantPrivs()
        {
            InitializeComponent();
        }

        private void DBA_GrantPrivs_Load(object sender, EventArgs e)
        {
            try
            {
                string selectTableStatement = "select object_name from all_objects where (object_type = \'VIEW\' or object_type = \'TABLE\') and owner = \'QLTH\'";
                OracleCommand cmd = new OracleCommand(selectTableStatement, Session.Instance.OracleConnection);
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    table_view_combox.Items.Add(reader[0]);
                }
                reader.Close();

                table_view_combox.Enabled = false;
                ColumnName_list.Enabled = false;
                withgrantoption_chkbox.Enabled = false;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
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
                    checkResult_txt.Text = "Invalid User/Role!";
                    withgrantoption_chkbox.Checked = false;
                    withgrantoption_chkbox.Enabled = false;
                }
                else if (reader1.GetInt32(0) == 1)
                {
                    checkResult_txt.Text = "Valid User!";
                    withgrantoption_chkbox.Enabled = true;
                }
                else if (reader2.GetInt32(0) == 1)
                {
                    checkResult_txt.Text = "Valid Role!";
                    withgrantoption_chkbox.Checked = false;
                    withgrantoption_chkbox.Enabled = false;
                }
                reader1.Close();
                reader2.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getColName(object sender, EventArgs e)
        {
            ColumnName_list.Items.Clear();
            try
            {
                ComboBox cb = sender as ComboBox;
                if (cb != null)
                {
                    string getColNameStatement = "select column_name from dba_tab_columns where owner = \'QLTH\' and table_name = \'" + cb.Text + "\'";
                    OracleCommand cmd = new OracleCommand(getColNameStatement, Session.Instance.OracleConnection);
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ColumnName_list.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void table_view_combox_SelectedValueChanged(object sender, EventArgs e)
        {
            getColName(sender, e);
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            user_role_txtbox.Clear();
            checkResult_txt.Text = "Unchecked!";
            privs_combox.SelectedIndex = -1;
            table_view_combox.SelectedIndex = -1;
            table_view_combox.Enabled = false;
            ColumnName_list.Items.Clear();
            ColumnName_list.Enabled = false;
            withgrantoption_chkbox.Checked = false;
            withgrantoption_chkbox.Enabled = false;
        }

        private void privs_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (privs_combox.Text != null)
            {
                table_view_combox.Enabled = true;
            }

            if (privs_combox.Text == "SELECT" || privs_combox.Text == "UPDATE")
            {
                ColumnName_list.Enabled = true;
                for (int i = 0; i < ColumnName_list.Items.Count; i++)
                {
                    ColumnName_list.SetItemChecked(i, false);
                }
            }

            if (privs_combox.Text == "INSERT" || privs_combox.Text == "DELETE")
            {
                ColumnName_list.Enabled = true;
                for (int i = 0; i < ColumnName_list.Items.Count; i++)
                {
                    ColumnName_list.SetItemChecked(i, false);
                }
                ColumnName_list.Enabled = false;
            }
        }

        private void grant_btn_Click(object sender, EventArgs e)
        {
            if (checkResult_txt.Text == "Unchecked!")
            {
                MessageBox.Show("Vui lòng nhập và kiểm tra user/role trước khi cấp quyền");
            } else if (checkResult_txt.Text == "Invalid User/Role!")
            {
                MessageBox.Show("User/Role không hợp lệ!");
            } else if (user_role_txtbox.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập và kiểm tra user/role!");
            } else if (privs_combox.Text.Length == 0)
            {
                MessageBox.Show("Chưa chọn quyền muốn cấp!");
            } else if (table_view_combox.Text.Length == 0)
            {
                MessageBox.Show("Chưa chọn bảng muốn cấp quyền!");
            } else
            {
                try
                {
                    string grantStatement = "";

                    string withgrantoption = (withgrantoption_chkbox.Checked) ? "with grant option" : "";
                    
                    // cấp quyền insert và delete
                    if (privs_combox.Text == "INSERT" || privs_combox.Text == "DELETE")
                    {
                        grantStatement = "grant " + privs_combox.Text + " on QLTH." + table_view_combox.Text + @" to """ + user_role_txtbox.Text + @""" " + withgrantoption;
                    }

                    // cấp quyền update
                    if (privs_combox.Text == "UPDATE")
                    {
                        string colOption = "";
                        string column_list = "";
                        for (int i = 0; i < ColumnName_list.Items.Count; i++)
                        {
                            if (ColumnName_list.GetItemChecked(i) == true)
                            {
                                column_list += ColumnName_list.Items[i].ToString() + ",";
                            }
                        }
                        if (column_list.Length > 0)
                        {
                            column_list = column_list.Substring(0, column_list.Length - 1);
                            colOption = "(" + column_list + ")";
                        }

                        grantStatement = "grant " + privs_combox.Text + colOption + " on QLTH." + table_view_combox.Text + @" to """ + user_role_txtbox.Text + @""" " + withgrantoption;
                    }

                    // cấp quyền select
                    if (privs_combox.Text == "SELECT")
                    {
                        var grantSelectCmd = new OracleCommand();
                        grantSelectCmd.Connection = Session.Instance.OracleConnection;

                        //string colOption;
                        string column_list = "";
                        for (int i = 0; i < ColumnName_list.Items.Count; i++)
                        {
                            if (ColumnName_list.GetItemChecked(i) == true)
                            {
                                column_list += ColumnName_list.Items[i].ToString() + ",";
                            }
                        }
                        if (column_list.Length > 0)
                        {
                            column_list = column_list.Substring(0, column_list.Length - 1);
                            try
                            {
                                //grantStatement = "grant " + privs_combox.Text + " on QLTH.V_" + table_view_combox.Text + "_" + user_role_txtbox.Text;
                                grantSelectCmd.BindByName = true;
                                grantSelectCmd.CommandText = "QLTH.grantSelectPriv";
                                grantSelectCmd.CommandType = CommandType.StoredProcedure;
                                grantSelectCmd.Parameters.Add("user_role", user_role_txtbox.Text);
                                grantSelectCmd.Parameters.Add("schema_name", "QLTH");
                                grantSelectCmd.Parameters.Add("table_name", table_view_combox.Text);
                                //MessageBox.Show(column_list); // debug line
                                grantSelectCmd.Parameters.Add("column_name", column_list);
                                grantSelectCmd.Parameters.Add("withgrantoption", withgrantoption);
                                //MessageBox.Show(grantSelectCmd.CommandText); // debug line
                                grantSelectCmd.ExecuteNonQuery();
                                MessageBox.Show("Thực hiện cấp quyền thành công!");
                                this.Close();
                                return;
                            }
                            catch (OracleException ex)
                            {
                                MessageBox.Show("Cấp quyền thất bại");
                                //MessageBox.Show(ex.Message);
                                return;
                            }
                        }
                        else
                        {
                            grantStatement = "grant " + privs_combox.Text + " on QLTH." + table_view_combox.Text + @" to """ + user_role_txtbox.Text + @""" " + withgrantoption;
                        }

                    }

                    //MessageBox.Show(grantStatement); // debug line

                    OracleCommand cmd = new OracleCommand(grantStatement, Session.Instance.OracleConnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thực hiện cấp quyền thành công!");

                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Cấp quyền thất bại");
                    //MessageBox.Show($"Error: {ex.Message}");
                    return;
                }
            }
        }
    }
}

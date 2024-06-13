using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace QLTruongHoc.dba.forms
{
    public partial class Recovery : Form
    {
        public Recovery()
        {
            InitializeComponent();
        }

        private void Recovery_Load(object sender, EventArgs e)
        {
            TabCombox.Enabled = false;
            dateTimePicker.Enabled = false;
            RecoveryBtn.Enabled = false;
        }

        private void RecoveryType_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = RecoveryType_combox.Text.ToString();
            if (type != null)
            {
                RecoveryBtn.Enabled = true;
                if (type == "Table")
                {
                    TabCombox.Enabled = true;
                    dateTimePicker.Enabled = true;
                }
                else
                {
                    TabCombox.Enabled = false;
                    dateTimePicker.Enabled = false;
                }
            }
        }

        private void RecoveryBtn_Click(object sender, EventArgs e)
        {
            string type = RecoveryType_combox.Text.ToString();
            string tab_name = "QLTH." + TabCombox.Text.ToString();
            string recover_time = dateTimePicker.Value.ToString();
            //MessageBox.Show(recover_time);
            if (type == null)
            {
                MessageBox.Show("Vui lòng chọn loại recovery!");
            } else
            {
                if (type == "Full Database")
                {
                    MessageBox.Show("Đang tiến hành recovery, vui lòng đợi!");
                    Process cmd = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "cmd.exe";
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardInput = true;
                    startInfo.RedirectStandardOutput = true;

                    cmd.StartInfo = startInfo;
                    cmd.Start();

                    using (StreamWriter writer = cmd.StandardInput)
                    {
                        writer.WriteLine("cd \\");
                        writer.WriteLine("rman target /"); // connect to RMAN
                        writer.WriteLine("startup force mount;"); // get list backup
                        writer.WriteLine("restore database;"); // get list backup
                        writer.WriteLine("recover database;"); // get list backup
                        writer.WriteLine("alter database open;"); // get list backup
                        writer.WriteLine("exit"); // exit RMAN
                        writer.WriteLine("exit"); // exit the Command Prompt
                    }

                    cmd.StandardInput.Close();
                    // Read the output of the command
                    string line;
                    bool showOutput = false;
                    StringBuilder resultBuilder = new StringBuilder();

                    while ((line = cmd.StandardOutput.ReadLine()) != null)
                    {
                        resultBuilder.AppendLine(line);
                    }

                    cmd.WaitForExit();

                    //MessageBox.Show(resultBuilder.ToString());
                    if (resultBuilder.Length > 50)
                    {
                        int firstindex;
                        for (int i = 1; i < 27; i++)
                        {
                            firstindex = resultBuilder.ToString().IndexOf("\n");
                            resultBuilder.Remove(0, firstindex + 1);
                        }

                        int lastindex;
                        for (int i = 1; i < 11; i++)
                        {
                            lastindex = resultBuilder.ToString().LastIndexOf("\n");
                            resultBuilder.Remove(lastindex, resultBuilder.Length - lastindex);
                        }
                    }

                    string output = resultBuilder.ToString();
                    // format output
                    Form outputForm = new Form();
                    outputForm.Text = "Quá trình khôi phục";
                    outputForm.Size = new Size(800, 600); // adjust the size as needed

                    RichTextBox richTextBox = new RichTextBox();
                    richTextBox.Dock = DockStyle.Fill;
                    richTextBox.ReadOnly = true;
                    richTextBox.Text = output;

                    outputForm.Controls.Add(richTextBox);
                    outputForm.ShowDialog();
                }
                else if (type == "Table")
                {
                    if (TabCombox.Text.ToString() == "")
                    {
                        MessageBox.Show("Vui lòng chọn bảng muốn khôi phục!");
                    } else
                    {
                        try
                        {
                            var cmd = new OracleCommand();
                            cmd.Connection = Session.Instance.OracleConnection;
                            cmd.CommandText = "SYS.USP_RECOVER_TABLE";
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("TAB_NAME", tab_name);
                            cmd.Parameters.Add("RECOVER_TIME", recover_time);
                            cmd.Parameters.Add("RES", OracleDbType.Int32).Direction = ParameterDirection.Output;
                            cmd.ExecuteNonQuery();

                            var recover_res = Convert.ToString(cmd.Parameters["res"].Value);
                            if (recover_res == "0")
                            {
                                MessageBox.Show("Khôi phục thành công!");
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Khôi phục thất bại!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Khôi phục thất bại!");
                            //MessageBox.Show(ex.Message);
                        }
                    }

                }
            }


        }
    }
}

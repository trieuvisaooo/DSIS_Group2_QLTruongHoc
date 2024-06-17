using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.dba.forms;
using QLTruongHoc.utils;
using System.Data;
using System.Diagnostics;
using System.Text;


namespace QLTruongHoc.dba.uc
{
    public partial class DBA_BackupAndRecoveryTab : UserControl
    {
        public DBA_BackupAndRecoveryTab()
        {
            InitializeComponent();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            string sql_statement;
            string tab_name = TabComBox.Text.ToString();
            try
            {
                sql_statement = "SELECT * FROM QLTH." + tab_name;
                OracleDataAdapter da = new OracleDataAdapter(sql_statement, Session.Instance.OracleConnection);
                DataTable dt1 = new DataTable();
                da.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RecoveryBtn_Click(object sender, EventArgs e)
        {
            Recovery recoveryFrom = new Recovery();
            recoveryFrom.Show();
        }

        private void ViewBackupBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hệ thống sẽ hiển thị kết quả trong giây lát!");
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
                writer.WriteLine("list backup of database summary;"); // get list backup
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
                if (line.StartsWith("List of Backups"))
                {
                    showOutput = true;
                }

                if (showOutput)
                {
                    resultBuilder.AppendLine(line);
                }

                if (line.StartsWith("RMAN>"))
                {
                    showOutput = false;
                }
            }

            cmd.WaitForExit();

            //MessageBox.Show(resultBuilder.ToString());
            if (resultBuilder.Length > 5)
            {
                int index;
                for (int i = 1; i < 3; i++)
                {
                    index = resultBuilder.ToString().LastIndexOf("\n");
                    resultBuilder.Remove(index, resultBuilder.Length - index);
                }
            }
            else if (resultBuilder.Length == 0)
            {
                resultBuilder.AppendLine("Không tồn tại bản sao lưu nào!");
            }

            string output = resultBuilder.ToString();
            // format output
            Form outputForm = new Form();
            outputForm.Text = "Danh sách các bản sao lưu";
            outputForm.Size = new Size(800, 600); // adjust the size as needed

            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.ReadOnly = true;
            richTextBox.Text = output;

            outputForm.Controls.Add(richTextBox);
            outputForm.ShowDialog();
        }

        private void BackupBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hệ thống đang tiến hành sao lưu, vui lòng đợi!");
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
                writer.WriteLine("shutdown immediate;"); // convert log mode
                writer.WriteLine("startup mount;");
                writer.WriteLine("alter database archivelog;");
                writer.WriteLine("alter database open;");
                writer.WriteLine("backup database;"); // get list backup
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

            int firstindex;
            for (int i = 1; i < 40; i++)
            {
                firstindex = resultBuilder.ToString().IndexOf("\n");
                resultBuilder.Remove(0, firstindex + 1);
            }

            int lastindex;
            for (int i = 1; i < 8; i++)
            {
                lastindex = resultBuilder.ToString().LastIndexOf("\n");
                resultBuilder.Remove(lastindex, resultBuilder.Length - lastindex);
            }
            string output = resultBuilder.ToString();

            Form outputForm = new Form();
            outputForm.Text = "Quá trình và kết quả sao lưu";
            outputForm.Size = new Size(800, 600); // adjust the size as needed

            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.ReadOnly = true;
            richTextBox.Text = output;

            outputForm.Controls.Add(richTextBox);
            outputForm.ShowDialog();
        }
    }
}
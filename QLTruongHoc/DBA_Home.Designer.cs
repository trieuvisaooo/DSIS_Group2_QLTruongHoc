using Oracle.ManagedDataAccess.Client;
using System.Data.OracleClient;

namespace QLTruongHoc
{
    partial class DBA_Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        /// 
        private OracleConnection connection;
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {   
            string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=172.16.112.128)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));User Id=QLTH;Password=QLTH;";

            try
            {
                connection = new OracleConnection(connectionString);
                connection.Open();
                MessageBox.Show("Connection to Oracle database successful!");
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error connecting to Oracle database: " + ex.Message);
            }
            finally
            {
                // Ensure proper connection closure
                if (connection != null)
                {
                    connection.Close();
                }
            }

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            UsersRolesPage = new TabPage();
            button1 = new Button();
            RolesPage = new TabPage();
            privilegesPage = new TabPage();
            tablesViewsTab = new TabPage();
            SysPrivilegesPage = new TabPage();
            auditPage = new TabPage();
            useransRole1 = new UseransRole();
            tabControl1.SuspendLayout();
            UsersRolesPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(UsersRolesPage);
            tabControl1.Controls.Add(RolesPage);
            tabControl1.Controls.Add(privilegesPage);
            tabControl1.Controls.Add(tablesViewsTab);
            tabControl1.Controls.Add(SysPrivilegesPage);
            tabControl1.Controls.Add(auditPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1277, 673);
            tabControl1.TabIndex = 0;
            // 
            // UsersRolesPage
            // 
            UsersRolesPage.Controls.Add(useransRole1);
            UsersRolesPage.Controls.Add(button1);
            UsersRolesPage.Location = new Point(4, 24);
            UsersRolesPage.Name = "UsersRolesPage";
            UsersRolesPage.Padding = new Padding(3);
            UsersRolesPage.Size = new Size(1269, 645);
            UsersRolesPage.TabIndex = 0;
            UsersRolesPage.Text = "Users & Roles";
            UsersRolesPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(1191, 619);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Sign Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RolesPage
            // 
            RolesPage.Location = new Point(4, 24);
            RolesPage.Name = "RolesPage";
            RolesPage.Padding = new Padding(3);
            RolesPage.Size = new Size(1269, 645);
            RolesPage.TabIndex = 1;
            RolesPage.Text = "Roles";
            RolesPage.UseVisualStyleBackColor = true;
            // 
            // privilegesPage
            // 
            privilegesPage.Location = new Point(4, 24);
            privilegesPage.Name = "privilegesPage";
            privilegesPage.Padding = new Padding(3);
            privilegesPage.Size = new Size(1269, 645);
            privilegesPage.TabIndex = 2;
            privilegesPage.Text = "Privileges";
            privilegesPage.UseVisualStyleBackColor = true;
            // 
            // tablesViewsTab
            // 
            tablesViewsTab.Location = new Point(4, 24);
            tablesViewsTab.Name = "tablesViewsTab";
            tablesViewsTab.Padding = new Padding(3);
            tablesViewsTab.Size = new Size(1269, 645);
            tablesViewsTab.TabIndex = 3;
            tablesViewsTab.Text = "Tables & Views";
            tablesViewsTab.UseVisualStyleBackColor = true;
            // 
            // SysPrivilegesPage
            // 
            SysPrivilegesPage.Location = new Point(4, 24);
            SysPrivilegesPage.Name = "SysPrivilegesPage";
            SysPrivilegesPage.Padding = new Padding(3);
            SysPrivilegesPage.Size = new Size(1269, 645);
            SysPrivilegesPage.TabIndex = 4;
            SysPrivilegesPage.Text = "System Privileges";
            SysPrivilegesPage.UseVisualStyleBackColor = true;
            // 
            // auditPage
            // 
            auditPage.Location = new Point(4, 24);
            auditPage.Name = "auditPage";
            auditPage.Padding = new Padding(3);
            auditPage.Size = new Size(1269, 645);
            auditPage.TabIndex = 5;
            auditPage.Text = "Audit";
            auditPage.UseVisualStyleBackColor = true;
            // 
            // useransRole1
            // 
            useransRole1.Location = new Point(0, 5);
            useransRole1.Margin = new Padding(3, 2, 3, 2);
            useransRole1.Name = "useransRole1";
            useransRole1.Size = new Size(1261, 620);
            useransRole1.TabIndex = 1;
            // 
            // DBA_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 673);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            Name = "DBA_Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QLTH";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            UsersRolesPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage UsersRolesPage;
        private TabPage RolesPage;
        private TabPage privilegesPage;
        private TabControl tabControl1;
        private Button button1;
        private TabPage tablesViewsTab;
        private TabPage SysPrivilegesPage;
        private TabPage auditPage;
        private UseransRole useransRole1;
    }
}

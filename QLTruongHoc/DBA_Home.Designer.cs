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
            useransRole1 = new UseransRole();
            button1 = new Button();
            RolesPage = new TabPage();
            privilegesPage = new TabPage();
            tablesViewsTab = new TabPage();
            SysPrivilegesPage = new TabPage();
            auditPage = new TabPage();
            sysPrivs1 = new SysPrivs();
            tabControl1.SuspendLayout();
            UsersRolesPage.SuspendLayout();
            SysPrivilegesPage.SuspendLayout();
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
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1824, 1050);
            tabControl1.TabIndex = 0;
            // 
            // UsersRolesPage
            // 
            UsersRolesPage.Controls.Add(useransRole1);
            UsersRolesPage.Controls.Add(button1);
            UsersRolesPage.Location = new Point(4, 34);
            UsersRolesPage.Margin = new Padding(4, 5, 4, 5);
            UsersRolesPage.Name = "UsersRolesPage";
            UsersRolesPage.Padding = new Padding(4, 5, 4, 5);
            UsersRolesPage.Size = new Size(1816, 1012);
            UsersRolesPage.TabIndex = 0;
            UsersRolesPage.Text = "Users & Roles";
            UsersRolesPage.UseVisualStyleBackColor = true;
            // 
            // useransRole1
            // 
            useransRole1.Location = new Point(0, 8);
            useransRole1.Margin = new Padding(4, 3, 4, 3);
            useransRole1.Name = "useransRole1";
            useransRole1.Size = new Size(1801, 1033);
            useransRole1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(1701, 1032);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 0;
            button1.Text = "Sign Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RolesPage
            // 
            RolesPage.Location = new Point(4, 34);
            RolesPage.Margin = new Padding(4, 5, 4, 5);
            RolesPage.Name = "RolesPage";
            RolesPage.Padding = new Padding(4, 5, 4, 5);
            RolesPage.Size = new Size(1816, 1012);
            RolesPage.TabIndex = 1;
            RolesPage.Text = "Roles";
            RolesPage.UseVisualStyleBackColor = true;
            // 
            // privilegesPage
            // 
            privilegesPage.Location = new Point(4, 34);
            privilegesPage.Margin = new Padding(4, 5, 4, 5);
            privilegesPage.Name = "privilegesPage";
            privilegesPage.Padding = new Padding(4, 5, 4, 5);
            privilegesPage.Size = new Size(1816, 1012);
            privilegesPage.TabIndex = 2;
            privilegesPage.Text = "Privileges";
            privilegesPage.UseVisualStyleBackColor = true;
            // 
            // tablesViewsTab
            // 
            tablesViewsTab.Location = new Point(4, 34);
            tablesViewsTab.Margin = new Padding(4, 5, 4, 5);
            tablesViewsTab.Name = "tablesViewsTab";
            tablesViewsTab.Padding = new Padding(4, 5, 4, 5);
            tablesViewsTab.Size = new Size(1816, 1012);
            tablesViewsTab.TabIndex = 3;
            tablesViewsTab.Text = "Tables & Views";
            tablesViewsTab.UseVisualStyleBackColor = true;
            // 
            // SysPrivilegesPage
            // 
            SysPrivilegesPage.Controls.Add(sysPrivs1);
            SysPrivilegesPage.Location = new Point(4, 34);
            SysPrivilegesPage.Margin = new Padding(4, 5, 4, 5);
            SysPrivilegesPage.Name = "SysPrivilegesPage";
            SysPrivilegesPage.Padding = new Padding(4, 5, 4, 5);
            SysPrivilegesPage.Size = new Size(1816, 1012);
            SysPrivilegesPage.TabIndex = 4;
            SysPrivilegesPage.Text = "System Privileges";
            SysPrivilegesPage.UseVisualStyleBackColor = true;
            // 
            // auditPage
            // 
            auditPage.Location = new Point(4, 34);
            auditPage.Margin = new Padding(4, 5, 4, 5);
            auditPage.Name = "auditPage";
            auditPage.Padding = new Padding(4, 5, 4, 5);
            auditPage.Size = new Size(1816, 1012);
            auditPage.TabIndex = 5;
            auditPage.Text = "Audit";
            auditPage.UseVisualStyleBackColor = true;
            // 
            // sysPrivs1
            // 
            sysPrivs1.Location = new Point(-4, 0);
            sysPrivs1.Margin = new Padding(4, 5, 4, 5);
            sysPrivs1.Name = "sysPrivs1";
            sysPrivs1.Padding = new Padding(4, 5, 4, 5);
            sysPrivs1.Size = new Size(2724, 1518);
            sysPrivs1.TabIndex = 0;
            // 
            // DBA_Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1824, 1050);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "DBA_Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ TRƯỜNG HỌC";
            FormClosed += Home_Closed;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            UsersRolesPage.ResumeLayout(false);
            SysPrivilegesPage.ResumeLayout(false);
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
        private SysPrivs sysPrivs1;
    }
}

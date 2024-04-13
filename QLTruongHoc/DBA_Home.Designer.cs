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
            //string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=172.16.112.128)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));User Id=QLTH;Password=QLTH;";

            //try
            //{
            //    connection = new OracleConnection(connectionString);
            //    connection.Open();
            //    MessageBox.Show("Connection to Oracle database successful!");
            //}
            //catch (OracleException ex)
            //{
            //    MessageBox.Show("Error connecting to Oracle database: " + ex.Message);
            //}
            //finally
            //{
            //    // Ensure proper connection closure
            //    if (connection != null)
            //    {
            //        connection.Close();
            //    }
            //}

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBA_Home));
            tabControl1 = new TabControl();
            UsersRolesPage = new TabPage();
            useransRole1 = new UserandRole();
            RolesPage = new TabPage();
            dbA_Roleui1 = new DBA_RoleUI();
            privilegesPage = new TabPage();
            privilege1 = new Privilege();
            SysPrivilegesPage = new TabPage();
            sysPrivs1 = new SysPrivs();
            tablesViewsTab = new TabPage();
            tablesViewsPage1 = new TablesViewsPage();
            auditPage = new TabPage();
            button1 = new Button();
            tabControl1.SuspendLayout();
            UsersRolesPage.SuspendLayout();
            RolesPage.SuspendLayout();
            privilegesPage.SuspendLayout();
            SysPrivilegesPage.SuspendLayout();
            tablesViewsTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(UsersRolesPage);
            tabControl1.Controls.Add(RolesPage);
            tabControl1.Controls.Add(privilegesPage);
            tabControl1.Controls.Add(SysPrivilegesPage);
            tabControl1.Controls.Add(tablesViewsTab);
            tabControl1.Controls.Add(auditPage);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1277, 634);
            tabControl1.TabIndex = 0;
            // 
            // UsersRolesPage
            // 
            UsersRolesPage.Controls.Add(useransRole1);
            UsersRolesPage.Location = new Point(4, 24);
            UsersRolesPage.Name = "UsersRolesPage";
            UsersRolesPage.Padding = new Padding(3);
            UsersRolesPage.Size = new Size(1269, 606);
            UsersRolesPage.TabIndex = 0;
            UsersRolesPage.Text = "Users & Roles";
            UsersRolesPage.UseVisualStyleBackColor = true;
            // 
            // useransRole1
            // 
            useransRole1.Location = new Point(6, 0);
            useransRole1.Margin = new Padding(3, 2, 3, 2);
            useransRole1.Name = "useransRole1";
            useransRole1.Size = new Size(1261, 597);
            useransRole1.TabIndex = 0;
            // 
            // RolesPage
            // 
            RolesPage.Controls.Add(dbA_Roleui1);
            RolesPage.Location = new Point(4, 24);
            RolesPage.Name = "RolesPage";
            RolesPage.Padding = new Padding(3);
            RolesPage.Size = new Size(1269, 606);
            RolesPage.TabIndex = 1;
            RolesPage.Text = "Roles of User";
            RolesPage.UseVisualStyleBackColor = true;
            // 
            // dbA_Roleui1
            // 
            dbA_Roleui1.Location = new Point(0, 0);
            dbA_Roleui1.Margin = new Padding(3, 2, 3, 2);
            dbA_Roleui1.Name = "dbA_Roleui1";
            dbA_Roleui1.Size = new Size(1891, 931);
            dbA_Roleui1.TabIndex = 0;
            // 
            // privilegesPage
            // 
            privilegesPage.Controls.Add(privilege1);
            privilegesPage.Location = new Point(4, 24);
            privilegesPage.Name = "privilegesPage";
            privilegesPage.Padding = new Padding(3);
            privilegesPage.Size = new Size(1269, 606);
            privilegesPage.TabIndex = 2;
            privilegesPage.Text = "Object Privileges";
            privilegesPage.UseVisualStyleBackColor = true;
            // 
            // privilege1
            // 
            privilege1.Location = new Point(0, 0);
            privilege1.Margin = new Padding(3, 2, 3, 2);
            privilege1.Name = "privilege1";
            privilege1.Size = new Size(1900, 1024);
            privilege1.TabIndex = 0;
            // 
            // SysPrivilegesPage
            // 
            SysPrivilegesPage.Controls.Add(sysPrivs1);
            SysPrivilegesPage.Location = new Point(4, 24);
            SysPrivilegesPage.Name = "SysPrivilegesPage";
            SysPrivilegesPage.Padding = new Padding(3);
            SysPrivilegesPage.Size = new Size(1269, 606);
            SysPrivilegesPage.TabIndex = 4;
            SysPrivilegesPage.Text = "System Privileges";
            SysPrivilegesPage.UseVisualStyleBackColor = true;
            // 
            // sysPrivs1
            // 
            sysPrivs1.Location = new Point(-3, 0);
            sysPrivs1.Margin = new Padding(4, 5, 4, 5);
            sysPrivs1.Name = "sysPrivs1";
            sysPrivs1.Padding = new Padding(3, 3, 3, 3);
            sysPrivs1.Size = new Size(1907, 911);
            sysPrivs1.TabIndex = 0;
            sysPrivs1.Load += sysPrivs1_Load;
            // 
            // tablesViewsTab
            // 
            tablesViewsTab.Controls.Add(tablesViewsPage1);
            tablesViewsTab.Location = new Point(4, 24);
            tablesViewsTab.Name = "tablesViewsTab";
            tablesViewsTab.Padding = new Padding(3);
            tablesViewsTab.Size = new Size(1269, 606);
            tablesViewsTab.TabIndex = 3;
            tablesViewsTab.Text = "Tables & Views";
            tablesViewsTab.UseVisualStyleBackColor = true;
            // 
            // tablesViewsPage1
            // 
            tablesViewsPage1.Location = new Point(3, 0);
            tablesViewsPage1.Name = "tablesViewsPage1";
            tablesViewsPage1.Size = new Size(1260, 620);
            tablesViewsPage1.TabIndex = 0;
            // 
            // auditPage
            // 
            auditPage.Location = new Point(4, 24);
            auditPage.Name = "auditPage";
            auditPage.Padding = new Padding(3);
            auditPage.Size = new Size(1269, 606);
            auditPage.TabIndex = 5;
            auditPage.Text = "Audit";
            auditPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(1181, 636);
            button1.Name = "button1";
            button1.Size = new Size(84, 35);
            button1.TabIndex = 1;
            button1.Text = "Sign Out";
            button1.UseVisualStyleBackColor = false;
            // 
            // DBA_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 503);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DBA_Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ TRƯỜNG HỌC";
            FormClosing += DBA_Home_Closing;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            UsersRolesPage.ResumeLayout(false);
            RolesPage.ResumeLayout(false);
            privilegesPage.ResumeLayout(false);
            SysPrivilegesPage.ResumeLayout(false);
            tablesViewsTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage UsersRolesPage;
        private TabPage privilegesPage;
        private TabControl tabControl1;
        private TabPage tablesViewsTab;
        private TabPage SysPrivilegesPage;
        private TabPage auditPage;
        private SysPrivs sysPrivs1;
        private Button button1;
        private UserandRole useransRole1;
        private Privilege privilege1;
        private TabPage RolesPage;
        private DBA_RoleUI dbA_Roleui1;
        private TablesViewsPage tablesViewsPage1;
    }
}

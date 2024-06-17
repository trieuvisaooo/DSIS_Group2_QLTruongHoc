using Oracle.ManagedDataAccess.Client;
using System.Data.OracleClient;

namespace QLTruongHoc
{
    partial class DBAHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBAHome));
            tabControl1 = new TabControl();
            UsersRolesPage = new TabPage();
            userAndRoleTab1 = new UserAndRoleTab();
            RolesPage = new TabPage();
            roleTab1 = new RoleTab();
            privilegesPage = new TabPage();
            privilegeTab1 = new PrivilegeTab();
            SysPrivilegesPage = new TabPage();
            sysPrivsTab1 = new SysPrivsTab();
            tablesViewsTab = new TabPage();
            tablesViewsPage1 = new TablesViewsTab();
            auditPage = new TabPage();
            auditTab1 = new dba.uc.AuditTab();
            backup_recovery_tab = new TabPage();
            backupAndRecoveryTab1 = new dba.uc.BackupAndRecoveryTab();
            LogoutBtn = new Button();
            tabControl1.SuspendLayout();
            UsersRolesPage.SuspendLayout();
            RolesPage.SuspendLayout();
            privilegesPage.SuspendLayout();
            SysPrivilegesPage.SuspendLayout();
            tablesViewsTab.SuspendLayout();
            auditPage.SuspendLayout();
            backup_recovery_tab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(UsersRolesPage);
            tabControl1.Controls.Add(RolesPage);
            tabControl1.Controls.Add(privilegesPage);
            tabControl1.Controls.Add(SysPrivilegesPage);
            tabControl1.Controls.Add(tablesViewsTab);
            tabControl1.Controls.Add(auditPage);
            tabControl1.Controls.Add(backup_recovery_tab);
            tabControl1.Location = new Point(1, 1);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1446, 791);
            tabControl1.TabIndex = 0;
            // 
            // UsersRolesPage
            // 
            UsersRolesPage.Controls.Add(userAndRoleTab1);
            UsersRolesPage.Location = new Point(4, 29);
            UsersRolesPage.Margin = new Padding(3, 4, 3, 4);
            UsersRolesPage.Name = "UsersRolesPage";
            UsersRolesPage.Padding = new Padding(3, 4, 3, 4);
            UsersRolesPage.Size = new Size(1438, 758);
            UsersRolesPage.TabIndex = 0;
            UsersRolesPage.Text = "Users & Roles";
            UsersRolesPage.UseVisualStyleBackColor = true;
            // 
            // userAndRoleTab1
            // 
            userAndRoleTab1.Dock = DockStyle.Fill;
            userAndRoleTab1.Location = new Point(4, 5);
            userAndRoleTab1.Margin = new Padding(5, 4, 5, 4);
            userAndRoleTab1.MinimumSize = new Size(1432, 800);
            userAndRoleTab1.Name = "userAndRoleTab1";
            userAndRoleTab1.Size = new Size(1792, 941);
            userAndRoleTab1.TabIndex = 0;
            // 
            // RolesPage
            // 
            RolesPage.Controls.Add(roleTab1);
            RolesPage.Location = new Point(4, 29);
            RolesPage.Margin = new Padding(3, 4, 3, 4);
            RolesPage.Name = "RolesPage";
            RolesPage.Padding = new Padding(3, 4, 3, 4);
            RolesPage.Size = new Size(1438, 758);
            RolesPage.TabIndex = 1;
            RolesPage.Text = "Roles of User";
            RolesPage.UseVisualStyleBackColor = true;
            // 
            // roleTab1
            // 
            roleTab1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roleTab1.Location = new Point(0, 0);
            roleTab1.Margin = new Padding(5, 4, 5, 4);
            roleTab1.MinimumSize = new Size(1432, 800);
            roleTab1.Name = "roleTab1";
            roleTab1.Size = new Size(1795, 850);
            roleTab1.TabIndex = 0;
            // 
            // privilegesPage
            // 
            privilegesPage.Controls.Add(privilegeTab1);
            privilegesPage.Location = new Point(4, 29);
            privilegesPage.Margin = new Padding(3, 4, 3, 4);
            privilegesPage.Name = "privilegesPage";
            privilegesPage.Padding = new Padding(3, 4, 3, 4);
            privilegesPage.Size = new Size(1438, 758);
            privilegesPage.TabIndex = 2;
            privilegesPage.Text = "Object Privileges";
            privilegesPage.UseVisualStyleBackColor = true;
            // 
            // privilegeTab1
            // 
            privilegeTab1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            privilegeTab1.Location = new Point(0, 0);
            privilegeTab1.Margin = new Padding(5, 4, 5, 4);
            privilegeTab1.MinimumSize = new Size(1432, 800);
            privilegeTab1.Name = "privilegeTab1";
            privilegeTab1.Size = new Size(1795, 850);
            privilegeTab1.TabIndex = 0;
            // 
            // SysPrivilegesPage
            // 
            SysPrivilegesPage.Controls.Add(sysPrivsTab1);
            SysPrivilegesPage.Location = new Point(4, 29);
            SysPrivilegesPage.Margin = new Padding(3, 4, 3, 4);
            SysPrivilegesPage.Name = "SysPrivilegesPage";
            SysPrivilegesPage.Padding = new Padding(3, 4, 3, 4);
            SysPrivilegesPage.Size = new Size(1438, 758);
            SysPrivilegesPage.TabIndex = 4;
            SysPrivilegesPage.Text = "System Privileges";
            SysPrivilegesPage.UseVisualStyleBackColor = true;
            // 
            // sysPrivsTab1
            // 
            sysPrivsTab1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sysPrivsTab1.Location = new Point(0, 0);
            sysPrivsTab1.Margin = new Padding(4, 6, 4, 6);
            sysPrivsTab1.MinimumSize = new Size(1432, 800);
            sysPrivsTab1.Name = "sysPrivsTab1";
            sysPrivsTab1.Padding = new Padding(4, 5, 4, 5);
            sysPrivsTab1.Size = new Size(1795, 850);
            sysPrivsTab1.TabIndex = 0;
            // 
            // tablesViewsTab
            // 
            tablesViewsTab.Controls.Add(tablesViewsPage1);
            tablesViewsTab.Location = new Point(4, 29);
            tablesViewsTab.Margin = new Padding(3, 4, 3, 4);
            tablesViewsTab.Name = "tablesViewsTab";
            tablesViewsTab.Padding = new Padding(3, 4, 3, 4);
            tablesViewsTab.Size = new Size(1438, 758);
            tablesViewsTab.TabIndex = 3;
            tablesViewsTab.Text = "Tables & Views";
            tablesViewsTab.UseVisualStyleBackColor = true;
            // 
            // tablesViewsPage1
            // 
            tablesViewsPage1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tablesViewsPage1.Location = new Point(0, 0);
            tablesViewsPage1.Margin = new Padding(6, 9, 6, 9);
            tablesViewsPage1.MinimumSize = new Size(1432, 800);
            tablesViewsPage1.Name = "tablesViewsPage1";
            tablesViewsPage1.Size = new Size(1795, 850);
            tablesViewsPage1.TabIndex = 0;
            // 
            // auditPage
            // 
            auditPage.Controls.Add(auditTab1);
            auditPage.Location = new Point(4, 29);
            auditPage.Margin = new Padding(3, 4, 3, 4);
            auditPage.Name = "auditPage";
            auditPage.Padding = new Padding(3, 4, 3, 4);
            auditPage.Size = new Size(1438, 758);
            auditPage.TabIndex = 5;
            auditPage.Text = "Audit";
            auditPage.UseVisualStyleBackColor = true;
            // 
            // auditTab1
            // 
            auditTab1.Dock = DockStyle.Fill;
            auditTab1.Location = new Point(4, 5);
            auditTab1.Margin = new Padding(4, 6, 4, 6);
            auditTab1.MinimumSize = new Size(1432, 800);
            auditTab1.Name = "auditTab1";
            auditTab1.Size = new Size(1792, 941);
            auditTab1.TabIndex = 0;
            // 
            // backup_recovery_tab
            // 
            backup_recovery_tab.Controls.Add(backupAndRecoveryTab1);
            backup_recovery_tab.Location = new Point(4, 29);
            backup_recovery_tab.Margin = new Padding(3, 4, 3, 4);
            backup_recovery_tab.Name = "backup_recovery_tab";
            backup_recovery_tab.Padding = new Padding(3, 4, 3, 4);
            backup_recovery_tab.Size = new Size(1438, 758);
            backup_recovery_tab.TabIndex = 6;
            backup_recovery_tab.Text = "Backup & Recovery";
            backup_recovery_tab.UseVisualStyleBackColor = true;
            // 
            // backupAndRecoveryTab1
            // 
            backupAndRecoveryTab1.Dock = DockStyle.Fill;
            backupAndRecoveryTab1.Location = new Point(4, 5);
            backupAndRecoveryTab1.MinimumSize = new Size(1432, 800);
            backupAndRecoveryTab1.Name = "backupAndRecoveryTab1";
            backupAndRecoveryTab1.Size = new Size(1792, 941);
            backupAndRecoveryTab1.TabIndex = 0;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LogoutBtn.BackColor = Color.Crimson;
            LogoutBtn.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutBtn.ForeColor = Color.WhiteSmoke;
            LogoutBtn.Location = new Point(1671, 989);
            LogoutBtn.Margin = new Padding(4, 5, 4, 5);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(136, 59);
            LogoutBtn.TabIndex = 1;
            LogoutBtn.Text = "Đăng xuất";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // DBAHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1810, 1050);
            Controls.Add(LogoutBtn);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1463, 814);
            Name = "DBAHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ TRƯỜNG HỌC";
            FormClosed += DBAHome_FormClosed;
            tabControl1.ResumeLayout(false);
            UsersRolesPage.ResumeLayout(false);
            RolesPage.ResumeLayout(false);
            privilegesPage.ResumeLayout(false);
            SysPrivilegesPage.ResumeLayout(false);
            tablesViewsTab.ResumeLayout(false);
            auditPage.ResumeLayout(false);
            backup_recovery_tab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage UsersRolesPage;
        private TabPage privilegesPage;
        private TabControl tabControl1;
        private TabPage tablesViewsTab;
        private TabPage SysPrivilegesPage;
        private TabPage auditPage;
        private Button LogoutBtn;
        private TabPage RolesPage;
        private TablesViewsTab tablesViewsPage1;
        private UserAndRoleTab userAndRoleTab1;
        private RoleTab roleTab1;
        private PrivilegeTab privilegeTab1;
        private SysPrivsTab sysPrivsTab1;
        private dba.uc.AuditTab auditTab1;
        private TabPage backup_recovery_tab;
        private dba.uc.BackupAndRecoveryTab backupAndRecoveryTab1;
    }
}

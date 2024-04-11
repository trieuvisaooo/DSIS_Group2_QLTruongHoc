namespace QLTruongHoc
{
    partial class UsersAndRolesUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelUser = new Label();
            tableUsers = new DataGridView();
            tableRoles = new DataGridView();
            labelRole = new Label();
            buttonCreateUser = new Button();
            buttonDeleteUser = new Button();
            button1 = new Button();
            searchUserTextBox = new TextBox();
            buttonFindUser = new Button();
            labelSearchUser = new Label();
            labelSearchRole = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            buttonUpdateRole = new Button();
            buttonDeleteRole = new Button();
            buttonCreateRole = new Button();
            ((System.ComponentModel.ISupportInitialize)tableUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableRoles).BeginInit();
            SuspendLayout();
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelUser.Location = new Point(17, 23);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(90, 35);
            labelUser.TabIndex = 0;
            labelUser.Text = "USERS";
            labelUser.Click += label1_Click;
            // 
            // tableUsers
            // 
            tableUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableUsers.Location = new Point(17, 60);
            tableUsers.Margin = new Padding(3, 4, 3, 4);
            tableUsers.Name = "tableUsers";
            tableUsers.RowHeadersWidth = 51;
            tableUsers.Size = new Size(1088, 335);
            tableUsers.TabIndex = 1;
            tableUsers.CellContentClick += tableUsers_CellContentClick;
            // 
            // tableRoles
            // 
            tableRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableRoles.Location = new Point(17, 467);
            tableRoles.Margin = new Padding(3, 4, 3, 4);
            tableRoles.Name = "tableRoles";
            tableRoles.RowHeadersWidth = 51;
            tableRoles.Size = new Size(1088, 335);
            tableRoles.TabIndex = 3;
            tableRoles.CellContentClick += tableRoles_CellContentClick;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelRole.Location = new Point(17, 429);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(90, 35);
            labelRole.TabIndex = 2;
            labelRole.Text = "ROLES";
            // 
            // buttonCreateUser
            // 
            buttonCreateUser.Font = new Font("Segoe UI", 13F);
            buttonCreateUser.Location = new Point(1130, 112);
            buttonCreateUser.Margin = new Padding(3, 4, 3, 4);
            buttonCreateUser.Name = "buttonCreateUser";
            buttonCreateUser.Size = new Size(144, 51);
            buttonCreateUser.TabIndex = 4;
            buttonCreateUser.Text = "Create User";
            buttonCreateUser.UseVisualStyleBackColor = true;
            buttonCreateUser.Click += buttonCreateUser_Click;
            // 
            // buttonDeleteUser
            // 
            buttonDeleteUser.Font = new Font("Segoe UI", 13F);
            buttonDeleteUser.Location = new Point(1130, 171);
            buttonDeleteUser.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.Size = new Size(144, 51);
            buttonDeleteUser.TabIndex = 6;
            buttonDeleteUser.Text = "Delete User";
            buttonDeleteUser.UseVisualStyleBackColor = true;
            buttonDeleteUser.Click += button1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(1130, 229);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(144, 51);
            button1.TabIndex = 7;
            button1.Text = "Update User";
            button1.UseVisualStyleBackColor = true;
            // 
            // searchUserTextBox
            // 
            searchUserTextBox.Font = new Font("Segoe UI", 13F);
            searchUserTextBox.Location = new Point(1130, 352);
            searchUserTextBox.Margin = new Padding(3, 4, 3, 4);
            searchUserTextBox.Name = "searchUserTextBox";
            searchUserTextBox.Size = new Size(205, 36);
            searchUserTextBox.TabIndex = 8;
            searchUserTextBox.TextChanged += searchUserTextBox_TextChanged;
            // 
            // buttonFindUser
            // 
            buttonFindUser.Font = new Font("Segoe UI", 13F);
            buttonFindUser.Location = new Point(1330, 352);
            buttonFindUser.Margin = new Padding(3, 4, 3, 4);
            buttonFindUser.Name = "buttonFindUser";
            buttonFindUser.Size = new Size(53, 41);
            buttonFindUser.TabIndex = 10;
            buttonFindUser.Text = "Go";
            buttonFindUser.UseVisualStyleBackColor = true;
            buttonFindUser.Click += button2_Click;
            // 
            // labelSearchUser
            // 
            labelSearchUser.AutoSize = true;
            labelSearchUser.Font = new Font("Segoe UI", 13F);
            labelSearchUser.Location = new Point(1217, 315);
            labelSearchUser.Name = "labelSearchUser";
            labelSearchUser.Size = new Size(128, 30);
            labelSearchUser.TabIndex = 16;
            labelSearchUser.Text = "Search User";
            // 
            // labelSearchRole
            // 
            labelSearchRole.AutoSize = true;
            labelSearchRole.Font = new Font("Segoe UI", 13F);
            labelSearchRole.Location = new Point(1217, 721);
            labelSearchRole.Name = "labelSearchRole";
            labelSearchRole.Size = new Size(126, 30);
            labelSearchRole.TabIndex = 22;
            labelSearchRole.Text = "Search Role";
            labelSearchRole.Click += label1_Click_3;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13F);
            button2.Location = new Point(1330, 759);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(53, 41);
            button2.TabIndex = 21;
            button2.Text = "Go";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(1130, 759);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 36);
            textBox1.TabIndex = 20;
            // 
            // buttonUpdateRole
            // 
            buttonUpdateRole.Font = new Font("Segoe UI", 13F);
            buttonUpdateRole.Location = new Point(1130, 636);
            buttonUpdateRole.Margin = new Padding(3, 4, 3, 4);
            buttonUpdateRole.Name = "buttonUpdateRole";
            buttonUpdateRole.Size = new Size(144, 51);
            buttonUpdateRole.TabIndex = 19;
            buttonUpdateRole.Text = "Update Role";
            buttonUpdateRole.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteRole
            // 
            buttonDeleteRole.Font = new Font("Segoe UI", 13F);
            buttonDeleteRole.Location = new Point(1130, 577);
            buttonDeleteRole.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteRole.Name = "buttonDeleteRole";
            buttonDeleteRole.Size = new Size(144, 51);
            buttonDeleteRole.TabIndex = 18;
            buttonDeleteRole.Text = "Delete Role";
            buttonDeleteRole.UseVisualStyleBackColor = true;
            // 
            // buttonCreateRole
            // 
            buttonCreateRole.Font = new Font("Segoe UI", 13F);
            buttonCreateRole.Location = new Point(1130, 519);
            buttonCreateRole.Margin = new Padding(3, 4, 3, 4);
            buttonCreateRole.Name = "buttonCreateRole";
            buttonCreateRole.Size = new Size(144, 51);
            buttonCreateRole.TabIndex = 17;
            buttonCreateRole.Text = "Create Role";
            buttonCreateRole.UseVisualStyleBackColor = true;
            // 
            // UsersAndRolesUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(labelSearchRole);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(buttonUpdateRole);
            Controls.Add(buttonDeleteRole);
            Controls.Add(buttonCreateRole);
            Controls.Add(labelSearchUser);
            Controls.Add(buttonFindUser);
            Controls.Add(searchUserTextBox);
            Controls.Add(button1);
            Controls.Add(buttonDeleteUser);
            Controls.Add(buttonCreateUser);
            Controls.Add(tableRoles);
            Controls.Add(labelRole);
            Controls.Add(tableUsers);
            Controls.Add(labelUser);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UsersAndRolesUI";
            Size = new Size(1441, 827);
            ((System.ComponentModel.ISupportInitialize)tableUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableRoles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUser;
        private DataGridView tableUsers;
        private DataGridView tableRoles;
        private Label labelRole;
        private Button buttonCreateUser;
        private Button buttonDeleteUser;
        private Button button1;
        private TextBox searchUserTextBox;
        private Button buttonFindUser;
        private Label labelSearchUser;
        private Label labelSearchRole;
        private Button button2;
        private TextBox textBox1;
        private Button buttonUpdateRole;
        private Button buttonDeleteRole;
        private Button buttonCreateRole;
    }
}

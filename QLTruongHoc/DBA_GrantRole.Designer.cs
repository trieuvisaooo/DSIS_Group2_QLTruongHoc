namespace QLTruongHoc
{
    partial class DBA_GrantRole
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            role_txt = new Label();
            label1 = new Label();
            role_txtbox = new TextBox();
            userOrrole_txtbox = new TextBox();
            grant_btn = new Button();
            exit_btn = new Button();
            isAdminCheckBox = new CheckBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // role_txt
            // 
            role_txt.AutoSize = true;
            role_txt.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            role_txt.Location = new Point(31, 52);
            role_txt.Name = "role_txt";
            role_txt.Size = new Size(51, 28);
            role_txt.TabIndex = 0;
            role_txt.Text = "Role";
            role_txt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(31, 133);
            label1.Name = "label1";
            label1.Size = new Size(87, 28);
            label1.TabIndex = 1;
            label1.Text = "Grant to";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // role_txtbox
            // 
            role_txtbox.Location = new Point(179, 52);
            role_txtbox.Name = "role_txtbox";
            role_txtbox.Size = new Size(258, 31);
            role_txtbox.TabIndex = 2;
            // 
            // userOrrole_txtbox
            // 
            userOrrole_txtbox.Location = new Point(179, 133);
            userOrrole_txtbox.Name = "userOrrole_txtbox";
            userOrrole_txtbox.Size = new Size(258, 31);
            userOrrole_txtbox.TabIndex = 3;
            // 
            // grant_btn
            // 
            grant_btn.Anchor = AnchorStyles.None;
            grant_btn.BackColor = SystemColors.ActiveCaption;
            grant_btn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grant_btn.Location = new Point(179, 260);
            grant_btn.Name = "grant_btn";
            grant_btn.Size = new Size(111, 47);
            grant_btn.TabIndex = 4;
            grant_btn.Text = "Grant Role";
            grant_btn.UseVisualStyleBackColor = false;
            grant_btn.Click += grant_btn_Click;
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.IndianRed;
            exit_btn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit_btn.Location = new Point(327, 260);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(111, 47);
            exit_btn.TabIndex = 5;
            exit_btn.Text = "Cancel";
            exit_btn.UseVisualStyleBackColor = false;
            // 
            // isAdminCheckBox
            // 
            isAdminCheckBox.AutoSize = true;
            isAdminCheckBox.Location = new Point(179, 204);
            isAdminCheckBox.Margin = new Padding(4, 5, 4, 5);
            isAdminCheckBox.Name = "isAdminCheckBox";
            isAdminCheckBox.Size = new Size(22, 21);
            isAdminCheckBox.TabIndex = 6;
            isAdminCheckBox.UseVisualStyleBackColor = true;
            isAdminCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(208, 204);
            label2.Name = "label2";
            label2.Size = new Size(177, 21);
            label2.TabIndex = 7;
            label2.Text = "WITH ADMIN OPTION";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DBA_GrantRole
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 312);
            Controls.Add(label2);
            Controls.Add(isAdminCheckBox);
            Controls.Add(exit_btn);
            Controls.Add(grant_btn);
            Controls.Add(userOrrole_txtbox);
            Controls.Add(role_txtbox);
            Controls.Add(label1);
            Controls.Add(role_txt);
            Name = "DBA_GrantRole";
            Text = "CẤP ROLE CHO USER/ROLE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label role_txt;
        private Label label1;
        private TextBox role_txtbox;
        private TextBox userOrrole_txtbox;
        private Button grant_btn;
        private Button exit_btn;
        private CheckBox isAdminCheckBox;
        private Label label2;
    }
}
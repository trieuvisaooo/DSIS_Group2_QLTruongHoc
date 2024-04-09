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
            SuspendLayout();
            // 
            // role_txt
            // 
            role_txt.AutoSize = true;
            role_txt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 163);
            role_txt.Location = new Point(31, 51);
            role_txt.Name = "role_txt";
            role_txt.Size = new Size(142, 28);
            role_txt.TabIndex = 0;
            role_txt.Text = "Role muốn cấp";
            role_txt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(31, 133);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 1;
            label1.Text = "Cấp cho User/Role";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // role_txtbox
            // 
            role_txtbox.Location = new Point(225, 51);
            role_txtbox.Name = "role_txtbox";
            role_txtbox.Size = new Size(212, 31);
            role_txtbox.TabIndex = 2;
            // 
            // userOrrole_txtbox
            // 
            userOrrole_txtbox.Location = new Point(225, 133);
            userOrrole_txtbox.Name = "userOrrole_txtbox";
            userOrrole_txtbox.Size = new Size(212, 31);
            userOrrole_txtbox.TabIndex = 3;
            // 
            // grant_btn
            // 
            grant_btn.Location = new Point(225, 217);
            grant_btn.Name = "grant_btn";
            grant_btn.Size = new Size(112, 34);
            grant_btn.TabIndex = 4;
            grant_btn.Text = "Cấp role";
            grant_btn.UseVisualStyleBackColor = true;
            // 
            // exit_btn
            // 
            exit_btn.Location = new Point(437, 217);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(112, 34);
            exit_btn.TabIndex = 5;
            exit_btn.Text = "Thoát";
            exit_btn.UseVisualStyleBackColor = true;
            // 
            // DBA_GrantRole
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 287);
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
    }
}
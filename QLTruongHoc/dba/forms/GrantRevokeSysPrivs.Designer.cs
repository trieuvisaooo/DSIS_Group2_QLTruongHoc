namespace QLTruongHoc
{
    partial class GrantRevokeSysPrivs
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
            grant_revoke_txt = new Label();
            label1 = new Label();
            label2 = new Label();
            user_role_txtbox = new TextBox();
            grant_revoke_combox = new ComboBox();
            SysPrivs_combox = new ComboBox();
            apply_btn = new Button();
            cancel_btn = new Button();
            label3 = new Label();
            check_result = new Label();
            check_btn = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // grant_revoke_txt
            // 
            grant_revoke_txt.AutoSize = true;
            grant_revoke_txt.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            grant_revoke_txt.Location = new Point(39, 43);
            grant_revoke_txt.Name = "grant_revoke_txt";
            grant_revoke_txt.Size = new Size(169, 28);
            grant_revoke_txt.TabIndex = 0;
            grant_revoke_txt.Text = "Grant Or Revoke";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(39, 244);
            label1.Name = "label1";
            label1.Size = new Size(178, 28);
            label1.TabIndex = 1;
            label1.Text = "System Privileges";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(39, 115);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 2;
            label2.Text = "User/Role";
            // 
            // user_role_txtbox
            // 
            user_role_txtbox.Location = new Point(264, 116);
            user_role_txtbox.Name = "user_role_txtbox";
            user_role_txtbox.Size = new Size(292, 31);
            user_role_txtbox.TabIndex = 3;
            // 
            // grant_revoke_combox
            // 
            grant_revoke_combox.FormattingEnabled = true;
            grant_revoke_combox.Items.AddRange(new object[] { "GRANT", "REVOKE" });
            grant_revoke_combox.Location = new Point(264, 43);
            grant_revoke_combox.Name = "grant_revoke_combox";
            grant_revoke_combox.Size = new Size(292, 33);
            grant_revoke_combox.TabIndex = 4;
            grant_revoke_combox.SelectedValueChanged += grant_revoke_combox_SelectedValueChanged;
            // 
            // SysPrivs_combox
            // 
            SysPrivs_combox.FormattingEnabled = true;
            SysPrivs_combox.Location = new Point(264, 244);
            SysPrivs_combox.Name = "SysPrivs_combox";
            SysPrivs_combox.Size = new Size(292, 33);
            SysPrivs_combox.TabIndex = 5;
            // 
            // apply_btn
            // 
            apply_btn.BackColor = SystemColors.ActiveCaption;
            apply_btn.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            apply_btn.Location = new Point(264, 329);
            apply_btn.Name = "apply_btn";
            apply_btn.Size = new Size(112, 39);
            apply_btn.TabIndex = 6;
            apply_btn.Text = "Apply";
            apply_btn.UseVisualStyleBackColor = false;
            apply_btn.Click += apply_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.IndianRed;
            cancel_btn.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel_btn.Location = new Point(444, 329);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(112, 39);
            cancel_btn.TabIndex = 7;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(39, 174);
            label3.Name = "label3";
            label3.Size = new Size(133, 28);
            label3.TabIndex = 8;
            label3.Text = "Check Result";
            // 
            // check_result
            // 
            check_result.AutoSize = true;
            check_result.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            check_result.ForeColor = Color.Red;
            check_result.Location = new Point(264, 171);
            check_result.Name = "check_result";
            check_result.Size = new Size(119, 28);
            check_result.TabIndex = 9;
            check_result.Text = "Unchecked!";
            // 
            // check_btn
            // 
            check_btn.BackColor = SystemColors.ActiveCaption;
            check_btn.Font = new Font("Book Antiqua", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            check_btn.Location = new Point(577, 116);
            check_btn.Name = "check_btn";
            check_btn.Size = new Size(112, 31);
            check_btn.TabIndex = 10;
            check_btn.Text = "Check";
            check_btn.UseVisualStyleBackColor = false;
            check_btn.Click += check_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(264, 289);
            label4.Name = "label4";
            label4.Size = new Size(397, 25);
            label4.TabIndex = 11;
            label4.Text = "(*) Vui lòng kiểm tra user/role trước khi thực hiện";
            // 
            // DBA_GrantRevokeSysPrivs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 380);
            Controls.Add(label4);
            Controls.Add(check_btn);
            Controls.Add(check_result);
            Controls.Add(label3);
            Controls.Add(cancel_btn);
            Controls.Add(apply_btn);
            Controls.Add(SysPrivs_combox);
            Controls.Add(grant_revoke_combox);
            Controls.Add(user_role_txtbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grant_revoke_txt);
            Name = "DBA_GrantRevokeSysPrivs";
            Text = "CẤP/THU HỒI QUYỀN HỆ THỐNG CHO USER/ROLE";
            Load += DBA_GrantRevokeSysPrivs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label grant_revoke_txt;
        private Label label1;
        private Label label2;
        private TextBox user_role_txtbox;
        private ComboBox grant_revoke_combox;
        private ComboBox SysPrivs_combox;
        private Button apply_btn;
        private Button cancel_btn;
        private Label label3;
        private Label check_result;
        private Button check_btn;
        private Label label4;
    }
}
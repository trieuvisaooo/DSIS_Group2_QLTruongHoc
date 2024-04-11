namespace QLTruongHoc
{
    partial class DBA_GrantRevokeSysPrivs
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
            SuspendLayout();
            // 
            // grant_revoke_txt
            // 
            grant_revoke_txt.AutoSize = true;
            grant_revoke_txt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            grant_revoke_txt.Location = new Point(48, 69);
            grant_revoke_txt.Name = "grant_revoke_txt";
            grant_revoke_txt.Size = new Size(196, 32);
            grant_revoke_txt.TabIndex = 0;
            grant_revoke_txt.Text = "Grant Or Revoke";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(48, 140);
            label1.Name = "label1";
            label1.Size = new Size(201, 32);
            label1.TabIndex = 1;
            label1.Text = "System Privileges";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(48, 222);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 2;
            label2.Text = "User/Role";
            // 
            // user_role_txtbox
            // 
            user_role_txtbox.Location = new Point(264, 225);
            user_role_txtbox.Name = "user_role_txtbox";
            user_role_txtbox.Size = new Size(292, 31);
            user_role_txtbox.TabIndex = 3;
            // 
            // grant_revoke_combox
            // 
            grant_revoke_combox.FormattingEnabled = true;
            grant_revoke_combox.Items.AddRange(new object[] { "GRANT", "REVOKE" });
            grant_revoke_combox.Location = new Point(264, 72);
            grant_revoke_combox.Name = "grant_revoke_combox";
            grant_revoke_combox.Size = new Size(292, 33);
            grant_revoke_combox.TabIndex = 4;
            // 
            // SysPrivs_combox
            // 
            SysPrivs_combox.FormattingEnabled = true;
            SysPrivs_combox.Location = new Point(264, 143);
            SysPrivs_combox.Name = "SysPrivs_combox";
            SysPrivs_combox.Size = new Size(292, 33);
            SysPrivs_combox.TabIndex = 5;
            SysPrivs_combox.SelectedIndexChanged += SysPrivs_combox_SelectedIndexChanged;
            SysPrivs_combox.DataContextChanged += SysPrivs_combox_DataContextChanged;
            // 
            // apply_btn
            // 
            apply_btn.BackColor = SystemColors.ActiveCaption;
            apply_btn.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            apply_btn.Location = new Point(264, 298);
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
            cancel_btn.Location = new Point(444, 298);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(112, 39);
            cancel_btn.TabIndex = 7;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // DBA_GrantRevokeSysPrivs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 380);
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
    }
}
namespace QLTruongHoc
{
    partial class DBA_RevokePrivs
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
            label1 = new Label();
            user_role_txtbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            revoke_btn = new Button();
            cancel_btn = new Button();
            table_view_combox = new ComboBox();
            label4 = new Label();
            check_result = new Label();
            check_btn = new Button();
            privs_combox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 0;
            label1.Text = "User/Role";
            // 
            // user_role_txtbox
            // 
            user_role_txtbox.Location = new Point(239, 47);
            user_role_txtbox.Margin = new Padding(4);
            user_role_txtbox.Name = "user_role_txtbox";
            user_role_txtbox.Size = new Size(208, 31);
            user_role_txtbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 146);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 2;
            label2.Text = "Table/View";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 204);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 4;
            label3.Text = "Privilege";
            // 
            // revoke_btn
            // 
            revoke_btn.BackColor = SystemColors.ActiveCaption;
            revoke_btn.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            revoke_btn.ForeColor = SystemColors.ActiveCaptionText;
            revoke_btn.Location = new Point(175, 266);
            revoke_btn.Margin = new Padding(4);
            revoke_btn.Name = "revoke_btn";
            revoke_btn.Size = new Size(118, 36);
            revoke_btn.TabIndex = 9;
            revoke_btn.Text = "Revoke";
            revoke_btn.UseVisualStyleBackColor = false;
            revoke_btn.Click += revoke_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.IndianRed;
            cancel_btn.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel_btn.Location = new Point(320, 266);
            cancel_btn.Margin = new Padding(4);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(118, 36);
            cancel_btn.TabIndex = 10;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // table_view_combox
            // 
            table_view_combox.FormattingEnabled = true;
            table_view_combox.Location = new Point(239, 143);
            table_view_combox.Margin = new Padding(4);
            table_view_combox.Name = "table_view_combox";
            table_view_combox.Size = new Size(208, 33);
            table_view_combox.TabIndex = 11;
            table_view_combox.SelectedValueChanged += table_view_combox_SelectedValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 96);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 12;
            label4.Text = "Check Result";
            // 
            // check_result
            // 
            check_result.AutoSize = true;
            check_result.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            check_result.ForeColor = Color.Red;
            check_result.Location = new Point(239, 96);
            check_result.Margin = new Padding(4, 0, 4, 0);
            check_result.Name = "check_result";
            check_result.Size = new Size(112, 25);
            check_result.TabIndex = 13;
            check_result.Text = "Unchecked!";
            // 
            // check_btn
            // 
            check_btn.BackColor = SystemColors.ActiveCaption;
            check_btn.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            check_btn.ForeColor = SystemColors.ActiveCaptionText;
            check_btn.Location = new Point(468, 47);
            check_btn.Margin = new Padding(4);
            check_btn.Name = "check_btn";
            check_btn.Size = new Size(98, 31);
            check_btn.TabIndex = 14;
            check_btn.Text = "Check";
            check_btn.UseVisualStyleBackColor = false;
            check_btn.Click += check_btn_Click;
            // 
            // privs_combox
            // 
            privs_combox.FormattingEnabled = true;
            privs_combox.Location = new Point(239, 201);
            privs_combox.Margin = new Padding(4);
            privs_combox.Name = "privs_combox";
            privs_combox.Size = new Size(208, 33);
            privs_combox.TabIndex = 15;
            // 
            // DBA_RevokePrivs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 379);
            Controls.Add(privs_combox);
            Controls.Add(check_btn);
            Controls.Add(check_result);
            Controls.Add(label4);
            Controls.Add(table_view_combox);
            Controls.Add(cancel_btn);
            Controls.Add(revoke_btn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(user_role_txtbox);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "DBA_RevokePrivs";
            Text = "THU HỒI QUYỀN TRÊN TABLE/VIEW";
            Load += DBA_RevokePrivs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox user_role_txtbox;
        private Label label2;
        private Label label3;
        private Button revoke_btn;
        private Button cancel_btn;
        private ComboBox table_view_combox;
        private Label label4;
        private Label check_result;
        private Button check_btn;
        private ComboBox privs_combox;
    }
}
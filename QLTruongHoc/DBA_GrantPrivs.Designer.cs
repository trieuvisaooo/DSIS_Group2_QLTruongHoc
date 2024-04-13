namespace QLTruongHoc
{
    partial class DBA_GrantPrivs
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
            label2 = new Label();
            user_role_txtbox = new TextBox();
            check_btn = new Button();
            reset_btn = new Button();
            ColumnName_list = new CheckedListBox();
            label3 = new Label();
            checkResult_txt = new Label();
            label5 = new Label();
            label6 = new Label();
            privs_combox = new ComboBox();
            table_view_combox = new ComboBox();
            label7 = new Label();
            grant_btn = new Button();
            cancel_btn = new Button();
            withgrantoption_chkbox = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(14, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 0;
            label1.Text = "User/Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(434, 26);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 1;
            label2.Text = "Attributes";
            label2.Click += label2_Click;
            // 
            // user_role_txtbox
            // 
            user_role_txtbox.Location = new Point(120, 22);
            user_role_txtbox.Margin = new Padding(4);
            user_role_txtbox.Name = "user_role_txtbox";
            user_role_txtbox.Size = new Size(233, 31);
            user_role_txtbox.TabIndex = 2;
            // 
            // check_btn
            // 
            check_btn.BackColor = SystemColors.ActiveCaption;
            check_btn.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            check_btn.Location = new Point(134, 79);
            check_btn.Margin = new Padding(4);
            check_btn.Name = "check_btn";
            check_btn.Size = new Size(99, 35);
            check_btn.TabIndex = 3;
            check_btn.Text = "Check";
            check_btn.UseVisualStyleBackColor = false;
            check_btn.Click += check_btn_Click;
            // 
            // reset_btn
            // 
            reset_btn.BackColor = Color.LightCoral;
            reset_btn.Font = new Font("Book Antiqua", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            reset_btn.ForeColor = SystemColors.ButtonFace;
            reset_btn.Location = new Point(240, 79);
            reset_btn.Margin = new Padding(4);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(99, 35);
            reset_btn.TabIndex = 4;
            reset_btn.Text = "Reset";
            reset_btn.UseVisualStyleBackColor = false;
            reset_btn.Click += reset_btn_Click;
            // 
            // ColumnName_list
            // 
            ColumnName_list.FormattingEnabled = true;
            ColumnName_list.Location = new Point(405, 55);
            ColumnName_list.Margin = new Padding(4);
            ColumnName_list.Name = "ColumnName_list";
            ColumnName_list.Size = new Size(244, 228);
            ColumnName_list.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(13, 130);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 6;
            label3.Text = "Check result:";
            label3.Click += label3_Click;
            // 
            // checkResult_txt
            // 
            checkResult_txt.AutoSize = true;
            checkResult_txt.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            checkResult_txt.ForeColor = Color.Red;
            checkResult_txt.Location = new Point(133, 130);
            checkResult_txt.Margin = new Padding(4, 0, 4, 0);
            checkResult_txt.Name = "checkResult_txt";
            checkResult_txt.Size = new Size(100, 21);
            checkResult_txt.TabIndex = 7;
            checkResult_txt.Text = "Unchecked!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(14, 168);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 8;
            label5.Text = "Privilege";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(14, 218);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 9;
            label6.Text = "Table/View";
            label6.Click += label6_Click;
            // 
            // privs_combox
            // 
            privs_combox.FormattingEnabled = true;
            privs_combox.Items.AddRange(new object[] { "SELECT", "INSERT", "UPDATE", "DELETE" });
            privs_combox.Location = new Point(120, 164);
            privs_combox.Margin = new Padding(4);
            privs_combox.Name = "privs_combox";
            privs_combox.Size = new Size(233, 33);
            privs_combox.TabIndex = 10;
            privs_combox.SelectedIndexChanged += privs_combox_SelectedIndexChanged;
            // 
            // table_view_combox
            // 
            table_view_combox.FormattingEnabled = true;
            table_view_combox.Location = new Point(120, 214);
            table_view_combox.Margin = new Padding(4);
            table_view_combox.Name = "table_view_combox";
            table_view_combox.Size = new Size(233, 33);
            table_view_combox.TabIndex = 11;
            table_view_combox.SelectedValueChanged += table_view_combox_SelectedValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(13, 294);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(411, 25);
            label7.TabIndex = 12;
            label7.Text = "(*) Vui lòng kiểm tra User/Role trước khi cấp quyền";
            label7.Click += label7_Click;
            // 
            // grant_btn
            // 
            grant_btn.BackColor = SystemColors.GradientInactiveCaption;
            grant_btn.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grant_btn.ForeColor = SystemColors.HotTrack;
            grant_btn.Location = new Point(120, 337);
            grant_btn.Margin = new Padding(4);
            grant_btn.Name = "grant_btn";
            grant_btn.Size = new Size(189, 39);
            grant_btn.TabIndex = 13;
            grant_btn.Text = "Gant Privilege";
            grant_btn.UseVisualStyleBackColor = false;
            grant_btn.Click += grant_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.LightCoral;
            cancel_btn.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel_btn.ForeColor = SystemColors.ButtonFace;
            cancel_btn.Location = new Point(550, 339);
            cancel_btn.Margin = new Padding(4);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(99, 35);
            cancel_btn.TabIndex = 14;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // withgrantoption_chkbox
            // 
            withgrantoption_chkbox.AutoSize = true;
            withgrantoption_chkbox.Location = new Point(120, 261);
            withgrantoption_chkbox.Margin = new Padding(4);
            withgrantoption_chkbox.Name = "withgrantoption_chkbox";
            withgrantoption_chkbox.Size = new Size(214, 29);
            withgrantoption_chkbox.TabIndex = 15;
            withgrantoption_chkbox.Text = "WITH GRANT OPTION";
            withgrantoption_chkbox.UseVisualStyleBackColor = true;
            // 
            // DBA_GrantPrivs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 379);
            Controls.Add(withgrantoption_chkbox);
            Controls.Add(cancel_btn);
            Controls.Add(grant_btn);
            Controls.Add(label7);
            Controls.Add(table_view_combox);
            Controls.Add(privs_combox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(checkResult_txt);
            Controls.Add(label3);
            Controls.Add(ColumnName_list);
            Controls.Add(reset_btn);
            Controls.Add(check_btn);
            Controls.Add(user_role_txtbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "DBA_GrantPrivs";
            Text = "CẤP QUYỀN TRÊN TABLE/VIEW CHO USER/ROLE";
            Load += DBA_GrantPrivs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox user_role_txtbox;
        private Button check_btn;
        private Button reset_btn;
        private CheckedListBox ColumnName_list;
        private Label label3;
        private Label checkResult_txt;
        private Label label5;
        private Label label6;
        private ComboBox privs_combox;
        private ComboBox table_view_combox;
        private Label label7;
        private Button grant_btn;
        private Button cancel_btn;
        private CheckBox withgrantoption_chkbox;

    }
}
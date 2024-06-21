namespace QLTruongHoc
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            title_label = new Label();
            usn_label = new Label();
            psw_label = new Label();
            username_txtbox = new TextBox();
            psw_txtbox = new TextBox();
            role_label = new Label();
            login_btn = new Button();
            role_combox = new ComboBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
            title_label.ForeColor = SystemColors.MenuHighlight;
            title_label.Location = new Point(202, 20);
            title_label.Margin = new Padding(2, 0, 2, 0);
            title_label.Name = "title_label";
            title_label.Size = new Size(382, 45);
            title_label.TabIndex = 0;
            title_label.Text = "QUẢN LÝ TRƯỜNG HỌC";
            title_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // usn_label
            // 
            usn_label.AutoSize = true;
            usn_label.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            usn_label.Location = new Point(61, 119);
            usn_label.Margin = new Padding(2, 0, 2, 0);
            usn_label.Name = "usn_label";
            usn_label.Size = new Size(148, 28);
            usn_label.TabIndex = 1;
            usn_label.Text = "Tên đăng nhập";
            // 
            // psw_label
            // 
            psw_label.AutoSize = true;
            psw_label.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            psw_label.Location = new Point(111, 199);
            psw_label.Margin = new Padding(2, 0, 2, 0);
            psw_label.Name = "psw_label";
            psw_label.Size = new Size(98, 28);
            psw_label.TabIndex = 3;
            psw_label.Text = "Mật khẩu";
            // 
            // username_txtbox
            // 
            username_txtbox.Location = new Point(216, 119);
            username_txtbox.Margin = new Padding(2, 4, 2, 4);
            username_txtbox.Name = "username_txtbox";
            username_txtbox.Size = new Size(338, 31);
            username_txtbox.TabIndex = 4;
            // 
            // psw_txtbox
            // 
            psw_txtbox.Location = new Point(216, 199);
            psw_txtbox.Margin = new Padding(2, 4, 2, 4);
            psw_txtbox.Name = "psw_txtbox";
            psw_txtbox.Size = new Size(338, 31);
            psw_txtbox.TabIndex = 5;
            psw_txtbox.UseSystemPasswordChar = true;
            // 
            // role_label
            // 
            role_label.AutoSize = true;
            role_label.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            role_label.Location = new Point(139, 286);
            role_label.Margin = new Padding(2, 0, 2, 0);
            role_label.Name = "role_label";
            role_label.Size = new Size(71, 28);
            role_label.TabIndex = 7;
            role_label.Text = "Vai trò";
            // 
            // login_btn
            // 
            login_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            login_btn.ForeColor = SystemColors.MenuHighlight;
            login_btn.Location = new Point(216, 359);
            login_btn.Margin = new Padding(2, 4, 2, 4);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(152, 40);
            login_btn.TabIndex = 8;
            login_btn.Text = "Đăng nhập";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // role_combox
            // 
            role_combox.FormattingEnabled = true;
            role_combox.Items.AddRange(new object[] { "Quản trị viên", "Nhân viên cơ bản", "Giảng viên", "Giáo vụ", "Trưởng đơn vị", "Trưởng khoa", "Sinh viên" });
            role_combox.Location = new Point(216, 281);
            role_combox.Margin = new Padding(2, 4, 2, 4);
            role_combox.Name = "role_combox";
            role_combox.Size = new Size(203, 33);
            role_combox.TabIndex = 9;
            role_combox.SelectedIndexChanged += role_combox_SelectedIndexChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(584, 419);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(200, 25);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Database Configuration";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(linkLabel1);
            Controls.Add(role_combox);
            Controls.Add(login_btn);
            Controls.Add(role_label);
            Controls.Add(psw_txtbox);
            Controls.Add(username_txtbox);
            Controls.Add(psw_label);
            Controls.Add(usn_label);
            Controls.Add(title_label);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 4, 2, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            Text = "ĐĂNG NHẬP";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title_label;
        private Label usn_label;
        private Label psw_label;
        private TextBox username_txtbox;
        private TextBox psw_txtbox;
        private Label role_label;
        private Button login_btn;
        private ComboBox role_combox;
        private LinkLabel linkLabel1;
    }
}
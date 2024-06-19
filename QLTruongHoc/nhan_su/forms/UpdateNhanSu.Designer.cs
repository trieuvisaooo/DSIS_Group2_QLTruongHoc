namespace QLTruongHoc.nhan_su.forms
{
    partial class UpdateNhanSu
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
            tableLayoutPanel1 = new TableLayoutPanel();
            NameTxtBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            IdTxtBox = new TextBox();
            AddrTxtbox = new TextBox();
            PhoneTxtBox = new TextBox();
            GenderComBox = new ComboBox();
            DateOfBirthPicker = new DateTimePicker();
            SaveBtn = new Button();
            LocationCombox = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            DepartmentCombox = new ComboBox();
            label7 = new Label();
            RoleComBox = new ComboBox();
            label10 = new Label();
            AllowanceNumericUpDown = new NumericUpDown();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllowanceNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.79176F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.2082443F));
            tableLayoutPanel1.Controls.Add(NameTxtBox, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(IdTxtBox, 1, 0);
            tableLayoutPanel1.Controls.Add(AddrTxtbox, 1, 4);
            tableLayoutPanel1.Controls.Add(PhoneTxtBox, 1, 5);
            tableLayoutPanel1.Controls.Add(GenderComBox, 1, 2);
            tableLayoutPanel1.Controls.Add(DateOfBirthPicker, 1, 3);
            tableLayoutPanel1.Controls.Add(SaveBtn, 1, 10);
            tableLayoutPanel1.Controls.Add(LocationCombox, 1, 9);
            tableLayoutPanel1.Controls.Add(label9, 0, 9);
            tableLayoutPanel1.Controls.Add(label8, 0, 8);
            tableLayoutPanel1.Controls.Add(DepartmentCombox, 1, 8);
            tableLayoutPanel1.Controls.Add(label7, 0, 7);
            tableLayoutPanel1.Controls.Add(RoleComBox, 1, 7);
            tableLayoutPanel1.Controls.Add(label10, 0, 6);
            tableLayoutPanel1.Controls.Add(AllowanceNumericUpDown, 1, 6);
            tableLayoutPanel1.Location = new Point(43, 50);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.Size = new Size(576, 644);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // NameTxtBox
            // 
            NameTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTxtBox.Location = new Point(210, 66);
            NameTxtBox.Margin = new Padding(4);
            NameTxtBox.Name = "NameTxtBox";
            NameTxtBox.Size = new Size(362, 31);
            NameTxtBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(112, 62);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 62);
            label2.TabIndex = 2;
            label2.Text = "Họ và Tên";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(137, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 62);
            label1.TabIndex = 0;
            label1.Text = "Mã NS";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(121, 124);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 62);
            label3.TabIndex = 3;
            label3.Text = "Giới Tính";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(109, 186);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 62);
            label4.TabIndex = 4;
            label4.Text = "Ngày Sinh";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(134, 248);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 62);
            label5.TabIndex = 5;
            label5.Text = "Địa Chỉ";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(106, 310);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(96, 62);
            label6.TabIndex = 6;
            label6.Text = "Điện Thoại";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // IdTxtBox
            // 
            IdTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IdTxtBox.Location = new Point(210, 4);
            IdTxtBox.Margin = new Padding(4);
            IdTxtBox.Name = "IdTxtBox";
            IdTxtBox.Size = new Size(362, 31);
            IdTxtBox.TabIndex = 1;
            // 
            // AddrTxtbox
            // 
            AddrTxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddrTxtbox.Location = new Point(210, 252);
            AddrTxtbox.Margin = new Padding(4);
            AddrTxtbox.Name = "AddrTxtbox";
            AddrTxtbox.Size = new Size(362, 31);
            AddrTxtbox.TabIndex = 9;
            // 
            // PhoneTxtBox
            // 
            PhoneTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PhoneTxtBox.Location = new Point(210, 314);
            PhoneTxtBox.Margin = new Padding(4);
            PhoneTxtBox.Name = "PhoneTxtBox";
            PhoneTxtBox.Size = new Size(362, 31);
            PhoneTxtBox.TabIndex = 10;
            // 
            // GenderComBox
            // 
            GenderComBox.FormattingEnabled = true;
            GenderComBox.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            GenderComBox.Location = new Point(210, 128);
            GenderComBox.Margin = new Padding(4);
            GenderComBox.Name = "GenderComBox";
            GenderComBox.Size = new Size(122, 33);
            GenderComBox.TabIndex = 11;
            // 
            // DateOfBirthPicker
            // 
            DateOfBirthPicker.Format = DateTimePickerFormat.Short;
            DateOfBirthPicker.Location = new Point(210, 190);
            DateOfBirthPicker.Margin = new Padding(4);
            DateOfBirthPicker.Name = "DateOfBirthPicker";
            DateOfBirthPicker.Size = new Size(362, 31);
            DateOfBirthPicker.TabIndex = 12;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.MediumSeaGreen;
            SaveBtn.Location = new Point(210, 600);
            SaveBtn.Margin = new Padding(4);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(118, 40);
            SaveBtn.TabIndex = 14;
            SaveBtn.Text = "Lưu";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // LocationCombox
            // 
            LocationCombox.FormattingEnabled = true;
            LocationCombox.Items.AddRange(new object[] { "CS1", "CS2" });
            LocationCombox.Location = new Point(210, 554);
            LocationCombox.Margin = new Padding(4);
            LocationCombox.Name = "LocationCombox";
            LocationCombox.Size = new Size(162, 33);
            LocationCombox.TabIndex = 18;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(144, 550);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(58, 46);
            label9.TabIndex = 17;
            label9.Text = "Cơ sở";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(138, 492);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(64, 58);
            label8.TabIndex = 15;
            label8.Text = "Đơn vị";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // DepartmentCombox
            // 
            DepartmentCombox.FormattingEnabled = true;
            DepartmentCombox.Items.AddRange(new object[] { "VPK", "HTTT", "KHMT", "CNPM", "CNTT", "TGMT", "MMT" });
            DepartmentCombox.Location = new Point(210, 496);
            DepartmentCombox.Margin = new Padding(4);
            DepartmentCombox.Name = "DepartmentCombox";
            DepartmentCombox.Size = new Size(162, 33);
            DepartmentCombox.TabIndex = 16;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(139, 434);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(63, 58);
            label7.TabIndex = 7;
            label7.Text = "Vai trò";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // RoleComBox
            // 
            RoleComBox.FormattingEnabled = true;
            RoleComBox.Items.AddRange(new object[] { "Nhân viên cơ bản", "Giảng viên", "Giáo vụ", "Trưởng đơn vị" });
            RoleComBox.Location = new Point(210, 438);
            RoleComBox.Margin = new Padding(4);
            RoleComBox.Name = "RoleComBox";
            RoleComBox.Size = new Size(192, 33);
            RoleComBox.TabIndex = 13;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(127, 372);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(75, 62);
            label10.TabIndex = 19;
            label10.Text = "Phụ cấp";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // AllowanceNumericUpDown
            // 
            AllowanceNumericUpDown.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            AllowanceNumericUpDown.Location = new Point(209, 375);
            AllowanceNumericUpDown.Maximum = new decimal(new int[] { 50000000, 0, 0, 0 });
            AllowanceNumericUpDown.Name = "AllowanceNumericUpDown";
            AllowanceNumericUpDown.Size = new Size(193, 31);
            AllowanceNumericUpDown.TabIndex = 20;
            // 
            // UpdateNhanSu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 707);
            Controls.Add(tableLayoutPanel1);
            Name = "UpdateNhanSu";
            Text = "Cập Nhật Nhân Sự";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AllowanceNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox RoleComBox;
        private TextBox NameTxtBox;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox IdTxtBox;
        private TextBox AddrTxtbox;
        private TextBox PhoneTxtBox;
        private ComboBox GenderComBox;
        private DateTimePicker DateOfBirthPicker;
        private Label label8;
        private ComboBox DepartmentCombox;
        private Label label9;
        private ComboBox LocationCombox;
        private Button SaveBtn;
        private Label label10;
        private NumericUpDown AllowanceNumericUpDown;
    }
}
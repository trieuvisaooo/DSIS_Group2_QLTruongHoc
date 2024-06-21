namespace QLTruongHoc.nhan_su.forms
{
    partial class InsertTGDK
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
            SaveBtn = new Button();
            EndTimePicker = new DateTimePicker();
            StartTimePicker = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            YearTxtBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SemComBox = new ComboBox();
            ProgramComBox = new ComboBox();
            SuspendLayout();
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.MediumSeaGreen;
            SaveBtn.Location = new Point(245, 380);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(121, 47);
            SaveBtn.TabIndex = 26;
            SaveBtn.Text = "Tạo";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // EndTimePicker
            // 
            EndTimePicker.Format = DateTimePickerFormat.Time;
            EndTimePicker.Location = new Point(245, 334);
            EndTimePicker.Name = "EndTimePicker";
            EndTimePicker.Size = new Size(192, 31);
            EndTimePicker.TabIndex = 25;
            // 
            // StartTimePicker
            // 
            StartTimePicker.Format = DateTimePickerFormat.Time;
            StartTimePicker.Location = new Point(245, 260);
            StartTimePicker.Name = "StartTimePicker";
            StartTimePicker.Size = new Size(192, 31);
            StartTimePicker.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(31, 334);
            label5.Name = "label5";
            label5.Size = new Size(106, 32);
            label5.TabIndex = 23;
            label5.Text = "Ngày KT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(31, 259);
            label4.Name = "label4";
            label4.Size = new Size(110, 32);
            label4.TabIndex = 22;
            label4.Text = "Ngày BD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(31, 186);
            label3.Name = "label3";
            label3.Size = new Size(160, 32);
            label3.TabIndex = 20;
            label3.Text = "Chương trình";
            // 
            // YearTxtBox
            // 
            YearTxtBox.Location = new Point(245, 13);
            YearTxtBox.Name = "YearTxtBox";
            YearTxtBox.Size = new Size(192, 31);
            YearTxtBox.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(31, 13);
            label2.Name = "label2";
            label2.Size = new Size(66, 32);
            label2.TabIndex = 18;
            label2.Text = "Năm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(31, 95);
            label1.Name = "label1";
            label1.Size = new Size(89, 32);
            label1.TabIndex = 16;
            label1.Text = "Học kỳ";
            // 
            // SemComBox
            // 
            SemComBox.FormattingEnabled = true;
            SemComBox.Items.AddRange(new object[] { "1", "2", "3" });
            SemComBox.Location = new Point(245, 94);
            SemComBox.Name = "SemComBox";
            SemComBox.Size = new Size(192, 33);
            SemComBox.TabIndex = 27;
            // 
            // ProgramComBox
            // 
            ProgramComBox.FormattingEnabled = true;
            ProgramComBox.Items.AddRange(new object[] { "CQ", "CLC", "TT", "VP" });
            ProgramComBox.Location = new Point(245, 185);
            ProgramComBox.Name = "ProgramComBox";
            ProgramComBox.Size = new Size(192, 33);
            ProgramComBox.TabIndex = 28;
            // 
            // InsertTGDK
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProgramComBox);
            Controls.Add(SemComBox);
            Controls.Add(SaveBtn);
            Controls.Add(EndTimePicker);
            Controls.Add(StartTimePicker);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(YearTxtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InsertTGDK";
            Text = "Thêm Thời Gian DKHP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveBtn;
        private DateTimePicker EndTimePicker;
        private DateTimePicker StartTimePicker;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox YearTxtBox;
        private Label label2;
        private Label label1;
        private ComboBox SemComBox;
        private ComboBox ProgramComBox;
    }
}
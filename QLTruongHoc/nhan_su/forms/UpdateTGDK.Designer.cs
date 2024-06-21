namespace QLTruongHoc.nhan_su.forms
{
    partial class UpdateTGDK
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
            SemTxtBox = new TextBox();
            YearTxtBox = new TextBox();
            label2 = new Label();
            ProgramTxtBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            StartTimePicker = new DateTimePicker();
            EndTimePicker = new DateTimePicker();
            SaveBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(39, 107);
            label1.Name = "label1";
            label1.Size = new Size(89, 32);
            label1.TabIndex = 0;
            label1.Text = "Học kỳ";
            // 
            // SemTxtBox
            // 
            SemTxtBox.Location = new Point(253, 110);
            SemTxtBox.Name = "SemTxtBox";
            SemTxtBox.Size = new Size(192, 31);
            SemTxtBox.TabIndex = 1;
            // 
            // YearTxtBox
            // 
            YearTxtBox.Location = new Point(253, 22);
            YearTxtBox.Name = "YearTxtBox";
            YearTxtBox.Size = new Size(192, 31);
            YearTxtBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(39, 19);
            label2.Name = "label2";
            label2.Size = new Size(66, 32);
            label2.TabIndex = 2;
            label2.Text = "Năm";
            // 
            // ProgramTxtBox
            // 
            ProgramTxtBox.Location = new Point(253, 199);
            ProgramTxtBox.Name = "ProgramTxtBox";
            ProgramTxtBox.Size = new Size(192, 31);
            ProgramTxtBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(39, 197);
            label3.Name = "label3";
            label3.Size = new Size(160, 32);
            label3.TabIndex = 4;
            label3.Text = "Chương trình";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(39, 270);
            label4.Name = "label4";
            label4.Size = new Size(110, 32);
            label4.TabIndex = 6;
            label4.Text = "Ngày BD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(39, 345);
            label5.Name = "label5";
            label5.Size = new Size(106, 32);
            label5.TabIndex = 7;
            label5.Text = "Ngày KT";
            // 
            // StartTimePicker
            // 
            StartTimePicker.Format = DateTimePickerFormat.Time;
            StartTimePicker.Location = new Point(253, 271);
            StartTimePicker.Name = "StartTimePicker";
            StartTimePicker.Size = new Size(192, 31);
            StartTimePicker.TabIndex = 8;
            // 
            // EndTimePicker
            // 
            EndTimePicker.Format = DateTimePickerFormat.Time;
            EndTimePicker.Location = new Point(253, 345);
            EndTimePicker.Name = "EndTimePicker";
            EndTimePicker.Size = new Size(192, 31);
            EndTimePicker.TabIndex = 9;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.MediumSeaGreen;
            SaveBtn.Location = new Point(253, 391);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(121, 47);
            SaveBtn.TabIndex = 15;
            SaveBtn.Text = "Lưu";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // UpdateTGDK
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveBtn);
            Controls.Add(EndTimePicker);
            Controls.Add(StartTimePicker);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ProgramTxtBox);
            Controls.Add(label3);
            Controls.Add(YearTxtBox);
            Controls.Add(label2);
            Controls.Add(SemTxtBox);
            Controls.Add(label1);
            Name = "UpdateTGDK";
            Text = "Chỉnh Sửa Thời Gian Đăng Ký";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SemTxtBox;
        private TextBox YearTxtBox;
        private Label label2;
        private TextBox ProgramTxtBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker StartTimePicker;
        private DateTimePicker EndTimePicker;
        private Button SaveBtn;
    }
}
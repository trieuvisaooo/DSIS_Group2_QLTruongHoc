namespace QLTruongHoc.dba.forms
{
    partial class Recovery
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
            RecoveryType_combox = new ComboBox();
            grant_revoke_txt = new Label();
            label1 = new Label();
            TabCombox = new ComboBox();
            label2 = new Label();
            dateTimePicker = new DateTimePicker();
            RecoveryBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // RecoveryType_combox
            // 
            RecoveryType_combox.FormattingEnabled = true;
            RecoveryType_combox.Items.AddRange(new object[] { "Full Database", "Table" });
            RecoveryType_combox.Location = new Point(319, 52);
            RecoveryType_combox.Name = "RecoveryType_combox";
            RecoveryType_combox.Size = new Size(292, 33);
            RecoveryType_combox.TabIndex = 6;
            RecoveryType_combox.SelectedIndexChanged += RecoveryType_combox_SelectedIndexChanged;
            // 
            // grant_revoke_txt
            // 
            grant_revoke_txt.AutoSize = true;
            grant_revoke_txt.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            grant_revoke_txt.Location = new Point(37, 52);
            grant_revoke_txt.Name = "grant_revoke_txt";
            grant_revoke_txt.Size = new Size(145, 28);
            grant_revoke_txt.TabIndex = 5;
            grant_revoke_txt.Text = "Loại Recovery";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(37, 170);
            label1.Name = "label1";
            label1.Size = new Size(60, 28);
            label1.TabIndex = 7;
            label1.Text = "Bảng";
            // 
            // TabCombox
            // 
            TabCombox.FormattingEnabled = true;
            TabCombox.Items.AddRange(new object[] { "QLTH_NHANSU", "QLTH_SINHVIEN", "QLTH_CHUONGTRINH", "QLTH_NGANH", "QLTH_THONGBAO", "QLTH_COSO", "QLTH_THOIGIANDK", "QLTH_DONVI", "QLTH_HOCPHAN", "QLTH_KHMO", "QLTH_PHANCONG", "QLTH_DANGKY" });
            TabCombox.Location = new Point(319, 170);
            TabCombox.Name = "TabCombox";
            TabCombox.Size = new Size(292, 33);
            TabCombox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(37, 258);
            label2.Name = "label2";
            label2.Size = new Size(268, 28);
            label2.TabIndex = 9;
            label2.Text = "Thời điểm muốn khôi phục";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Time;
            dateTimePicker.Location = new Point(319, 258);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(292, 31);
            dateTimePicker.TabIndex = 10;
            // 
            // RecoveryBtn
            // 
            RecoveryBtn.BackColor = Color.DarkSlateBlue;
            RecoveryBtn.ForeColor = SystemColors.ButtonFace;
            RecoveryBtn.Location = new Point(319, 400);
            RecoveryBtn.Name = "RecoveryBtn";
            RecoveryBtn.Size = new Size(114, 38);
            RecoveryBtn.TabIndex = 11;
            RecoveryBtn.Text = "Khôi phục";
            RecoveryBtn.UseVisualStyleBackColor = false;
            RecoveryBtn.Click += RecoveryBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(37, 331);
            label3.Name = "label3";
            label3.Size = new Size(564, 25);
            label3.TabIndex = 12;
            label3.Text = "(*) Khôi phục toàn bộ CSDL sẽ khôi phục từ bản sao lưu gần nhất";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(62, 367);
            label4.Name = "label4";
            label4.Size = new Size(392, 25);
            label4.TabIndex = 13;
            label4.Text = "Vui lòng xem backup list trước khi khôi phục";
            // 
            // Recovery
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(RecoveryBtn);
            Controls.Add(dateTimePicker);
            Controls.Add(label2);
            Controls.Add(TabCombox);
            Controls.Add(label1);
            Controls.Add(RecoveryType_combox);
            Controls.Add(grant_revoke_txt);
            Name = "Recovery";
            Text = "RECOVERY";
            Load += Recovery_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox RecoveryType_combox;
        private Label grant_revoke_txt;
        private Label label1;
        private ComboBox TabCombox;
        private Label label2;
        private DateTimePicker dateTimePicker;
        private Button RecoveryBtn;
        private Label label3;
        private Label label4;
    }
}
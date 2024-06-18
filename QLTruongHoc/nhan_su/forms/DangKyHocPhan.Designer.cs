namespace QLTruongHoc.nhan_su.forms
{
    partial class DangKyHocPhan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CancelBtn = new Button();
            label7 = new Label();
            ResultGridView = new DataGridView();
            NotiLabel = new Label();
            RegisterBtn = new Button();
            ViewBtn = new Button();
            RegisterDataGridView = new DataGridView();
            label1 = new Label();
            SinhVienCombox = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)ResultGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RegisterDataGridView).BeginInit();
            SuspendLayout();
            // 
            // CancelBtn
            // 
            CancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelBtn.BackColor = Color.Crimson;
            CancelBtn.ForeColor = SystemColors.ActiveCaptionText;
            CancelBtn.Location = new Point(1277, 798);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(138, 47);
            CancelBtn.TabIndex = 40;
            CancelBtn.Text = "Hủy Đăng Ký";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label7.Location = new Point(40, 471);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(344, 38);
            label7.TabIndex = 39;
            label7.Text = "HỌC PHẦN ĐÃ ĐĂNG KÝ";
            // 
            // ResultGridView
            // 
            ResultGridView.AllowUserToAddRows = false;
            ResultGridView.AllowUserToDeleteRows = false;
            ResultGridView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ResultGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ResultGridView.BackgroundColor = SystemColors.Control;
            ResultGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ResultGridView.Location = new Point(40, 512);
            ResultGridView.Name = "ResultGridView";
            ResultGridView.RowHeadersWidth = 62;
            ResultGridView.Size = new Size(1375, 269);
            ResultGridView.TabIndex = 38;
            // 
            // NotiLabel
            // 
            NotiLabel.AutoSize = true;
            NotiLabel.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 163);
            NotiLabel.ForeColor = Color.Red;
            NotiLabel.Location = new Point(40, 76);
            NotiLabel.Name = "NotiLabel";
            NotiLabel.Size = new Size(409, 28);
            NotiLabel.TabIndex = 37;
            NotiLabel.Text = "(*) Bấm \"Xem\" để tiến hành đăng kí học phần";
            // 
            // RegisterBtn
            // 
            RegisterBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RegisterBtn.BackColor = Color.MediumSeaGreen;
            RegisterBtn.ForeColor = SystemColors.ActiveCaptionText;
            RegisterBtn.Location = new Point(1294, 428);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(121, 47);
            RegisterBtn.TabIndex = 36;
            RegisterBtn.Text = "Đăng Ký";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // ViewBtn
            // 
            ViewBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ViewBtn.BackColor = Color.DarkSlateBlue;
            ViewBtn.ForeColor = SystemColors.ButtonHighlight;
            ViewBtn.Location = new Point(1294, 101);
            ViewBtn.Name = "ViewBtn";
            ViewBtn.Size = new Size(121, 47);
            ViewBtn.TabIndex = 35;
            ViewBtn.Text = "Xem";
            ViewBtn.UseVisualStyleBackColor = false;
            ViewBtn.Click += ViewBtn_Click;
            // 
            // RegisterDataGridView
            // 
            RegisterDataGridView.AllowUserToAddRows = false;
            RegisterDataGridView.AllowUserToDeleteRows = false;
            RegisterDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegisterDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RegisterDataGridView.BackgroundColor = SystemColors.Control;
            RegisterDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RegisterDataGridView.Location = new Point(40, 154);
            RegisterDataGridView.Name = "RegisterDataGridView";
            RegisterDataGridView.RowHeadersWidth = 51;
            RegisterDataGridView.Size = new Size(1375, 268);
            RegisterDataGridView.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(523, 45);
            label1.TabIndex = 33;
            label1.Text = "ĐĂNG KÝ HỌC PHẦN SINH VIÊN";
            // 
            // SinhVienCombox
            // 
            SinhVienCombox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SinhVienCombox.DropDownStyle = ComboBoxStyle.DropDownList;
            SinhVienCombox.FormattingEnabled = true;
            SinhVienCombox.Location = new Point(951, 109);
            SinhVienCombox.Name = "SinhVienCombox";
            SinhVienCombox.Size = new Size(314, 33);
            SinhVienCombox.TabIndex = 41;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(801, 113);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 42;
            label2.Text = "Chọn sinh viên:";
            // 
            // DangKyHocPhan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 847);
            Controls.Add(label2);
            Controls.Add(SinhVienCombox);
            Controls.Add(CancelBtn);
            Controls.Add(label7);
            Controls.Add(ResultGridView);
            Controls.Add(NotiLabel);
            Controls.Add(RegisterBtn);
            Controls.Add(ViewBtn);
            Controls.Add(RegisterDataGridView);
            Controls.Add(label1);
            MinimumSize = new Size(1432, 800);
            Name = "DangKyHocPhan";
            Text = "Đăng Ký Học Phần Sinh Viên";
            ((System.ComponentModel.ISupportInitialize)ResultGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)RegisterDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelBtn;
        private Label label7;
        private DataGridView ResultGridView;
        private Label NotiLabel;
        private Button RegisterBtn;
        private Button ViewBtn;
        private DataGridView RegisterDataGridView;
        private Label label1;
        private ComboBox SinhVienCombox;
        private Label label2;
    }
}
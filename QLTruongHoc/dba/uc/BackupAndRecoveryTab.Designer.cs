namespace QLTruongHoc.dba.uc
{
    partial class BackupAndRecoveryTab
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            BackupBtn = new Button();
            label6 = new Label();
            ViewBackupBtn = new Button();
            label2 = new Label();
            panel3 = new Panel();
            splitter1 = new Splitter();
            ViewBtn = new Button();
            RecoveryBtn = new Button();
            label5 = new Label();
            TabComBox = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1801, 1000);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 167F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1801, 1000);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 2);
            dataGridView1.Location = new Point(4, 172);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1793, 823);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(BackupBtn);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(ViewBackupBtn);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(4, 5);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(892, 157);
            panel2.TabIndex = 1;
            // 
            // BackupBtn
            // 
            BackupBtn.BackColor = Color.SpringGreen;
            BackupBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            BackupBtn.ForeColor = SystemColors.ControlText;
            BackupBtn.Location = new Point(22, 76);
            BackupBtn.Name = "BackupBtn";
            BackupBtn.Size = new Size(120, 44);
            BackupBtn.TabIndex = 17;
            BackupBtn.Text = "Sao lưu";
            BackupBtn.UseVisualStyleBackColor = false;
            BackupBtn.Click += BackupBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(626, 35);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(166, 38);
            label6.TabIndex = 16;
            label6.Text = "Backup List";
            // 
            // ViewBackupBtn
            // 
            ViewBackupBtn.BackColor = Color.SpringGreen;
            ViewBackupBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            ViewBackupBtn.ForeColor = SystemColors.ControlText;
            ViewBackupBtn.Location = new Point(626, 80);
            ViewBackupBtn.Name = "ViewBackupBtn";
            ViewBackupBtn.Size = new Size(120, 44);
            ViewBackupBtn.TabIndex = 15;
            ViewBackupBtn.Text = "Xem";
            ViewBackupBtn.UseVisualStyleBackColor = false;
            ViewBackupBtn.Click += ViewBackupBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 5);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(160, 48);
            label2.TabIndex = 2;
            label2.Text = "BACKUP";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(splitter1);
            panel3.Controls.Add(ViewBtn);
            panel3.Controls.Add(RecoveryBtn);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(TabComBox);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(904, 5);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(893, 157);
            panel3.TabIndex = 2;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 155);
            splitter1.TabIndex = 15;
            splitter1.TabStop = false;
            // 
            // ViewBtn
            // 
            ViewBtn.BackColor = Color.DarkSlateBlue;
            ViewBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            ViewBtn.ForeColor = SystemColors.ButtonFace;
            ViewBtn.Location = new Point(753, 80);
            ViewBtn.Name = "ViewBtn";
            ViewBtn.Size = new Size(120, 44);
            ViewBtn.TabIndex = 14;
            ViewBtn.Text = "Xem";
            ViewBtn.UseVisualStyleBackColor = false;
            ViewBtn.Click += ViewBtn_Click;
            // 
            // RecoveryBtn
            // 
            RecoveryBtn.BackColor = Color.DarkSlateBlue;
            RecoveryBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            RecoveryBtn.ForeColor = SystemColors.ButtonFace;
            RecoveryBtn.Location = new Point(36, 80);
            RecoveryBtn.Name = "RecoveryBtn";
            RecoveryBtn.Size = new Size(120, 44);
            RecoveryBtn.TabIndex = 13;
            RecoveryBtn.Text = "Khôi phục";
            RecoveryBtn.UseVisualStyleBackColor = false;
            RecoveryBtn.Click += RecoveryBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 4);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(201, 48);
            label5.TabIndex = 12;
            label5.Text = "RECOVERY";
            // 
            // TabComBox
            // 
            TabComBox.FormattingEnabled = true;
            TabComBox.Items.AddRange(new object[] { "QLTH_NHANSU", "QLTH_SINHVIEN", "QLTH_CHUONGTRINH", "QLTH_NGANH", "QLTH_THONGBAO", "QLTH_COSO", "QLTH_THOIGIANDK", "QLTH_DONVI", "QLTH_HOCPHAN", "QLTH_KHMO", "QLTH_PHANCONG", "QLTH_DANGKY" });
            TabComBox.Location = new Point(479, 87);
            TabComBox.Margin = new Padding(2, 4, 2, 4);
            TabComBox.Name = "TabComBox";
            TabComBox.Size = new Size(249, 33);
            TabComBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(479, 35);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 38);
            label3.TabIndex = 4;
            label3.Text = "Table";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(356, 48);
            label1.TabIndex = 2;
            label1.Text = "BACKUP-RECOVERY";
            // 
            // BackupAndRecoveryTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            MinimumSize = new Size(1801, 1000);
            Name = "BackupAndRecoveryTab";
            Size = new Size(1801, 1000);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private ComboBox StandardAuditComBox;
        private ComboBox TabComBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button ViewBtn;
        private Button RecoveryBtn;
        private Label label6;
        private Button ViewBackupBtn;
        private Button BackupBtn;
        private Splitter splitter1;
    }
}

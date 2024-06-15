namespace QLTruongHoc.nhan_su.forms
{
    partial class InsertPhanCong
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
            comboBox1 = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            saveBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(164, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(936, 31);
            comboBox1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.5965548F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.40344F));
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(saveBtn, 1, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 117F));
            tableLayoutPanel1.Size = new Size(1103, 374);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(70, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 2;
            label1.Text = "Học Phần";
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.Chocolate;
            saveBtn.Location = new Point(164, 176);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(128, 39);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "Thêm";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(61, 100);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 3;
            label2.Text = "Giảng Viên";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(79, 50);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 5;
            label3.Text = "Lịch Học";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(comboBox4);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(164, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 44);
            panel1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(339, 0);
            label5.Name = "label5";
            label5.Size = new Size(40, 25);
            label5.TabIndex = 3;
            label5.Text = "Tiết";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 2;
            label4.Text = "Ngày Học";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(comboBox2);
            panel2.Location = new Point(164, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(936, 67);
            panel2.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.Font = new Font("Segoe UI", 10.8F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(0, -3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(933, 33);
            comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox3.Font = new Font("Segoe UI", 10.8F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "T2", "T3", "T4", "T5", "T6", "T7" });
            comboBox3.Location = new Point(144, -2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(125, 33);
            comboBox3.TabIndex = 4;
            // 
            // comboBox4
            // 
            comboBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox4.Font = new Font("Segoe UI", 10.8F);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "1-4", "6-9", "1-2", "1-3", "3-4", "3-5", "6-7", "6-8", "8-9", "8-10" });
            comboBox4.Location = new Point(398, 0);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(125, 33);
            comboBox4.TabIndex = 5;
            // 
            // InsertPhanCong
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 398);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "InsertPhanCong";
            Text = "Phân Công Giảng Dạy";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label1;
        private Button saveBtn;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
    }
}
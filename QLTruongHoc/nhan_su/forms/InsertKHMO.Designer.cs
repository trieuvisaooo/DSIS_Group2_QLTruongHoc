namespace QLTruongHoc.nhan_su.forms
{
    partial class InsertKHMO
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
            label1 = new Label();
            saveBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(53, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 30);
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
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(18, 100);
            label2.Name = "label2";
            label2.Size = new Size(140, 30);
            label2.TabIndex = 3;
            label2.Text = "Chương trình";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(61, 50);
            label3.Name = "label3";
            label3.Size = new Size(97, 30);
            label3.TabIndex = 5;
            label3.Text = "Năm/HK";
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
            label5.Size = new Size(81, 30);
            label5.TabIndex = 3;
            label5.Text = "Học Kỳ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 30);
            label4.TabIndex = 2;
            label4.Text = "Năm học";
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
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(164, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(936, 36);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.Font = new Font("Segoe UI", 10.8F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(0, -3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(1669, 38);
            comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox3.Font = new Font("Segoe UI", 10.8F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "T2", "T3", "T4", "T5", "T6", "T7" });
            comboBox3.Location = new Point(139, 0);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(194, 38);
            comboBox3.TabIndex = 4;
            // 
            // comboBox4
            // 
            comboBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox4.Font = new Font("Segoe UI", 10.8F);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "1-4", "6-9", "1-2", "1-3", "3-4", "3-5", "6-7", "6-8", "8-9", "8-10" });
            comboBox4.Location = new Point(426, -3);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(513, 38);
            comboBox4.TabIndex = 5;
            // 
            // InsertKHMO
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 398);
            Controls.Add(tableLayoutPanel1);
            Name = "InsertKHMO";
            Text = "Tạo mới KHMO";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button saveBtn;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private ComboBox comboBox1;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
    }
}
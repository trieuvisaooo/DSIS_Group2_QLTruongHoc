namespace QLTruongHoc.nhan_su.uc
{
    partial class KhmoTab
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            refreshBtn = new Button();
            button1 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(370, 38);
            label1.TabIndex = 0;
            label1.Text = "KẾ HOẠCH MỞ HỌC PHẦN";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1404, 698);
            dataGridView1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 33);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "Năm học";
            comboBox1.DropDown += comboBox1_DropDown;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(160, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 33);
            comboBox2.TabIndex = 3;
            comboBox2.Text = "Học Kỳ";
            comboBox2.DropDown += comboBox2_DropDown;
            comboBox2.Format += comboBox2_Format;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(317, 3);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 33);
            comboBox3.TabIndex = 4;
            comboBox3.Text = "Chương trình";
            comboBox3.DropDown += comboBox3_DropDown;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(494, 7);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 5;
            label2.Text = "Tìm Kiếm";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(574, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 31);
            textBox1.TabIndex = 6;
            // 
            // refreshBtn
            // 
            refreshBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refreshBtn.BackColor = Color.DarkSlateBlue;
            refreshBtn.ForeColor = SystemColors.ButtonHighlight;
            refreshBtn.Location = new Point(904, 3);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(94, 33);
            refreshBtn.TabIndex = 7;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.MediumVioletRed;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(775, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 33);
            button1.TabIndex = 8;
            button1.Text = "Tìm Kiếm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(refreshBtn);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(420, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(998, 39);
            panel1.TabIndex = 9;
            // 
            // KhmoTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(1432, 800);
            Name = "KhmoTab";
            Size = new Size(1432, 800);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label2;
        private TextBox textBox1;
        private Button refreshBtn;
        private Button button1;
        private Panel panel1;
    }
}

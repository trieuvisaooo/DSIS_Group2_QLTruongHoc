namespace QLTruongHoc.sinh_vien.uc
{
    partial class HPSVTab
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
            ViewAllBtn = new Button();
            CourseTxtBox = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            SearchBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ViewAllBtn
            // 
            ViewAllBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ViewAllBtn.BackColor = Color.DarkSlateBlue;
            ViewAllBtn.ForeColor = SystemColors.ButtonHighlight;
            ViewAllBtn.Location = new Point(602, 2);
            ViewAllBtn.Margin = new Padding(2);
            ViewAllBtn.Name = "ViewAllBtn";
            ViewAllBtn.Size = new Size(64, 38);
            ViewAllBtn.TabIndex = 29;
            ViewAllBtn.Text = "Xem tất cả";
            ViewAllBtn.UseVisualStyleBackColor = false;
            ViewAllBtn.Click += ViewAllBtn_Click;
            // 
            // CourseTxtBox
            // 
            CourseTxtBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 163);
            CourseTxtBox.Location = new Point(2, 6);
            CourseTxtBox.Margin = new Padding(2);
            CourseTxtBox.Name = "CourseTxtBox";
            CourseTxtBox.PlaceholderText = "tìm kiếm theo mã hoặc tên học phần";
            CourseTxtBox.Size = new Size(262, 30);
            CourseTxtBox.TabIndex = 28;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 102);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1123, 507);
            dataGridView1.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 32);
            label1.Name = "label1";
            label1.Size = new Size(232, 38);
            label1.TabIndex = 24;
            label1.Text = "XEM HỌC PHẦN";
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SearchBtn.BackColor = Color.DeepPink;
            SearchBtn.ForeColor = SystemColors.ButtonHighlight;
            SearchBtn.Location = new Point(2, 2);
            SearchBtn.Margin = new Padding(2);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(79, 38);
            SearchBtn.TabIndex = 30;
            SearchBtn.Text = "Tìm";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(ViewAllBtn, 2, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Location = new Point(466, 48);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(668, 49);
            tableLayoutPanel1.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.Controls.Add(SearchBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(303, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 43);
            panel1.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.Controls.Add(CourseTxtBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(294, 43);
            panel2.TabIndex = 32;
            // 
            // HPSVTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(2);
            MinimumSize = new Size(1146, 640);
            Name = "HPSVTab";
            Size = new Size(1146, 640);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ViewAllBtn;
        private TextBox CourseTxtBox;
        private DataGridView dataGridView1;
        private Label label1;
        private Button SearchBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
    }
}

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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ViewAllBtn
            // 
            ViewAllBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ViewAllBtn.BackColor = Color.DarkSlateBlue;
            ViewAllBtn.ForeColor = SystemColors.ButtonHighlight;
            ViewAllBtn.Location = new Point(1297, 64);
            ViewAllBtn.Name = "ViewAllBtn";
            ViewAllBtn.Size = new Size(121, 47);
            ViewAllBtn.TabIndex = 29;
            ViewAllBtn.Text = "Xem tất cả";
            ViewAllBtn.UseVisualStyleBackColor = false;
            ViewAllBtn.Click += ViewAllBtn_Click;
            // 
            // CourseTxtBox
            // 
            CourseTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CourseTxtBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 163);
            CourseTxtBox.Location = new Point(637, 71);
            CourseTxtBox.Name = "CourseTxtBox";
            CourseTxtBox.PlaceholderText = "tìm kiếm theo mã hoặc tên học phần";
            CourseTxtBox.Size = new Size(326, 34);
            CourseTxtBox.TabIndex = 28;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1404, 634);
            dataGridView1.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(275, 45);
            label1.TabIndex = 24;
            label1.Text = "XEM HỌC PHẦN";
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchBtn.BackColor = Color.DeepPink;
            SearchBtn.ForeColor = SystemColors.ButtonHighlight;
            SearchBtn.Location = new Point(979, 64);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(121, 47);
            SearchBtn.TabIndex = 30;
            SearchBtn.Text = "Tìm";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // HPSVTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SearchBtn);
            Controls.Add(ViewAllBtn);
            Controls.Add(CourseTxtBox);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            MinimumSize = new Size(1432, 800);
            Name = "HPSVTab";
            Size = new Size(1432, 800);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ViewAllBtn;
        private TextBox CourseTxtBox;
        private DataGridView dataGridView1;
        private Label label1;
        private Button SearchBtn;
    }
}

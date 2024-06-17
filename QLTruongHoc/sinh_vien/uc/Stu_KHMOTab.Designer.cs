namespace QLTruongHoc.sinh_vien.uc
{
    partial class Stu_KHMOTab
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
            SearchBtn = new Button();
            refreshBtn = new Button();
            CourseTxtBox = new TextBox();
            SemComBox = new ComboBox();
            YearComBox = new ComboBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchBtn.BackColor = Color.MediumVioletRed;
            SearchBtn.ForeColor = SystemColors.ButtonHighlight;
            SearchBtn.Location = new Point(1115, 64);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(121, 47);
            SearchBtn.TabIndex = 17;
            SearchBtn.Text = "Tìm Kiếm";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // refreshBtn
            // 
            refreshBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refreshBtn.BackColor = Color.DarkSlateBlue;
            refreshBtn.ForeColor = SystemColors.ButtonHighlight;
            refreshBtn.Location = new Point(1297, 64);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(121, 47);
            refreshBtn.TabIndex = 16;
            refreshBtn.Text = "Xem";
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // CourseTxtBox
            // 
            CourseTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CourseTxtBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 163);
            CourseTxtBox.Location = new Point(894, 71);
            CourseTxtBox.Name = "CourseTxtBox";
            CourseTxtBox.PlaceholderText = "học phần muốn tìm";
            CourseTxtBox.Size = new Size(215, 34);
            CourseTxtBox.TabIndex = 15;
            // 
            // SemComBox
            // 
            SemComBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SemComBox.FormattingEnabled = true;
            SemComBox.Location = new Point(725, 72);
            SemComBox.Name = "SemComBox";
            SemComBox.Size = new Size(151, 33);
            SemComBox.TabIndex = 12;
            SemComBox.Text = "Học Kỳ";
            SemComBox.DropDown += SemComBox_DropDown;
            SemComBox.Format += SemComBox_Format;
            // 
            // YearComBox
            // 
            YearComBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            YearComBox.FormattingEnabled = true;
            YearComBox.Location = new Point(552, 72);
            YearComBox.Name = "YearComBox";
            YearComBox.Size = new Size(151, 33);
            YearComBox.TabIndex = 11;
            YearComBox.Text = "Năm Học";
            YearComBox.DropDown += YearComBox_DropDown;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1404, 634);
            dataGridView1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(437, 45);
            label1.TabIndex = 9;
            label1.Text = "KẾ HOẠCH MỞ HỌC PHẦN";
            // 
            // Stu_KHMOTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SearchBtn);
            Controls.Add(refreshBtn);
            Controls.Add(CourseTxtBox);
            Controls.Add(SemComBox);
            Controls.Add(YearComBox);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            MinimumSize = new Size(1432, 800);
            Name = "Stu_KHMOTab";
            Size = new Size(1432, 800);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchBtn;
        private Button refreshBtn;
        private TextBox CourseTxtBox;
        private ComboBox SemComBox;
        private ComboBox YearComBox;
        private DataGridView dataGridView1;
        private Label label1;
    }
}
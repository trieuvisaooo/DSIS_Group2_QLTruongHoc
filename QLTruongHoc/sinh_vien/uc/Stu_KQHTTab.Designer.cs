namespace QLTruongHoc.sinh_vien.uc
{
    partial class Stu_KQHTTab
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
            viewBtn = new Button();
            CourseTxtBox = new TextBox();
            SemComBox = new ComboBox();
            YearComBox = new ComboBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // viewBtn
            // 
            viewBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            viewBtn.BackColor = Color.DarkSlateBlue;
            viewBtn.ForeColor = SystemColors.ButtonHighlight;
            viewBtn.Location = new Point(1297, 64);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new Size(121, 47);
            viewBtn.TabIndex = 23;
            viewBtn.Text = "Xem";
            viewBtn.UseVisualStyleBackColor = false;
            viewBtn.Click += ViewBtn_Click;
            // 
            // CourseTxtBox
            // 
            CourseTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CourseTxtBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 163);
            CourseTxtBox.Location = new Point(1076, 71);
            CourseTxtBox.Name = "CourseTxtBox";
            CourseTxtBox.PlaceholderText = "học phần muốn xem";
            CourseTxtBox.Size = new Size(215, 34);
            CourseTxtBox.TabIndex = 22;
            // 
            // SemComBox
            // 
            SemComBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SemComBox.FormattingEnabled = true;
            SemComBox.Location = new Point(907, 72);
            SemComBox.Name = "SemComBox";
            SemComBox.Size = new Size(151, 33);
            SemComBox.TabIndex = 21;
            SemComBox.Text = "Học Kỳ";
            SemComBox.DropDown += SemComBox_DropDown;
            SemComBox.Format += SemComBox_Format;
            // 
            // YearComBox
            // 
            YearComBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            YearComBox.FormattingEnabled = true;
            YearComBox.Location = new Point(734, 72);
            YearComBox.Name = "YearComBox";
            YearComBox.Size = new Size(151, 33);
            YearComBox.TabIndex = 20;
            YearComBox.Text = "Năm Học";
            YearComBox.DropDown += YearComBox_DropDown;
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
            dataGridView1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(310, 45);
            label1.TabIndex = 18;
            label1.Text = "KẾT QUẢ HỌC TẬP";
            // 
            // KQHTTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(viewBtn);
            Controls.Add(CourseTxtBox);
            Controls.Add(SemComBox);
            Controls.Add(YearComBox);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            MinimumSize = new Size(1432, 800);
            Name = "KQHTTab";
            Size = new Size(1432, 800);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button viewBtn;
        private TextBox CourseTxtBox;
        private ComboBox SemComBox;
        private ComboBox YearComBox;
        private DataGridView dataGridView1;
        private Label label1;
    }
}

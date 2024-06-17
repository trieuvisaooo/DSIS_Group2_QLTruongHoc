namespace QLTruongHoc.nhan_su.uc
{
    partial class Emp_HocPhanTab
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
            searchTextBox = new TextBox();
            SearchBtn = new Button();
            ViewBtn = new Button();
            panel1 = new Panel();
            InsertBtn = new Button();
            UpdateBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(317, 45);
            label1.TabIndex = 0;
            label1.Text = "TẤT CẢ HỌC PHẦN";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1252, 920);
            dataGridView1.TabIndex = 1;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchTextBox.Location = new Point(3, 8);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "tìm theo mã hoặc tên";
            searchTextBox.Size = new Size(312, 36);
            searchTextBox.TabIndex = 3;
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchBtn.BackColor = Color.MediumVioletRed;
            SearchBtn.ForeColor = SystemColors.ButtonHighlight;
            SearchBtn.Location = new Point(332, 0);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(121, 47);
            SearchBtn.TabIndex = 4;
            SearchBtn.Text = "Tìm kiếm";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // ViewBtn
            // 
            ViewBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ViewBtn.BackColor = Color.DarkSlateBlue;
            ViewBtn.ForeColor = SystemColors.ButtonHighlight;
            ViewBtn.Location = new Point(486, 0);
            ViewBtn.Name = "ViewBtn";
            ViewBtn.Size = new Size(121, 47);
            ViewBtn.TabIndex = 5;
            ViewBtn.Text = "Xem";
            ViewBtn.UseVisualStyleBackColor = false;
            ViewBtn.Click += ViewBtn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(ViewBtn);
            panel1.Controls.Add(searchTextBox);
            panel1.Controls.Add(SearchBtn);
            panel1.Location = new Point(664, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(609, 47);
            panel1.TabIndex = 6;
            // 
            // InsertBtn
            // 
            InsertBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            InsertBtn.BackColor = Color.MediumSeaGreen;
            InsertBtn.ForeColor = SystemColors.ActiveCaptionText;
            InsertBtn.Location = new Point(1308, 77);
            InsertBtn.Name = "InsertBtn";
            InsertBtn.Size = new Size(121, 47);
            InsertBtn.TabIndex = 7;
            InsertBtn.Text = "Tạo Mới";
            InsertBtn.UseVisualStyleBackColor = false;
            InsertBtn.Visible = false;
            InsertBtn.Click += InsertBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UpdateBtn.BackColor = Color.PaleGoldenrod;
            UpdateBtn.ForeColor = SystemColors.ActiveCaptionText;
            UpdateBtn.Location = new Point(1308, 129);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(121, 47);
            UpdateBtn.TabIndex = 8;
            UpdateBtn.Text = "Cập Nhật";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Visible = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // Emp_HocPhanTab
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UpdateBtn);
            Controls.Add(InsertBtn);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(1432, 1000);
            Name = "Emp_HocPhanTab";
            Size = new Size(1432, 1000);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox searchTextBox;
        private Button SearchBtn;
        private Button ViewBtn;
        private Panel panel1;
        private Button InsertBtn;
        private Button UpdateBtn;
    }
}

namespace QLTruongHoc.nhan_su.uc
{
    partial class Emp_DonViTab
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
            dataGridView1 = new DataGridView();
            refreshBtn = new Button();
            searchTextBox = new TextBox();
            label2 = new Label();
            SearchBtn = new Button();
            InsertBtn = new Button();
            UpdateBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 86);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1606, 910);
            dataGridView1.TabIndex = 0;
            // 
            // refreshBtn
            // 
            refreshBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refreshBtn.BackColor = Color.DarkSlateBlue;
            refreshBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshBtn.ForeColor = Color.Snow;
            refreshBtn.Location = new Point(1501, 26);
            refreshBtn.Margin = new Padding(4);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(121, 47);
            refreshBtn.TabIndex = 1;
            refreshBtn.Text = "Xem";
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(993, 31);
            searchTextBox.Margin = new Padding(4);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "tìm kiếm theo mã hoặc tên";
            searchTextBox.Size = new Size(339, 36);
            searchTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 22);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 45);
            label2.TabIndex = 4;
            label2.Text = "ĐƠN VỊ";
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchBtn.BackColor = Color.MediumVioletRed;
            SearchBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBtn.ForeColor = Color.Snow;
            SearchBtn.Location = new Point(1340, 26);
            SearchBtn.Margin = new Padding(4);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(121, 47);
            SearchBtn.TabIndex = 5;
            SearchBtn.Text = "Tìm kiếm";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // InsertBtn
            // 
            InsertBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            InsertBtn.BackColor = Color.SeaGreen;
            InsertBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InsertBtn.ForeColor = SystemColors.ActiveCaptionText;
            InsertBtn.Location = new Point(1665, 86);
            InsertBtn.Margin = new Padding(4);
            InsertBtn.Name = "InsertBtn";
            InsertBtn.Size = new Size(121, 47);
            InsertBtn.TabIndex = 6;
            InsertBtn.Text = "Thêm";
            InsertBtn.UseVisualStyleBackColor = false;
            InsertBtn.Visible = false;
            InsertBtn.Click += InsertBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UpdateBtn.BackColor = Color.PaleGoldenrod;
            UpdateBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = SystemColors.ActiveCaptionText;
            UpdateBtn.Location = new Point(1665, 141);
            UpdateBtn.Margin = new Padding(4);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(121, 47);
            UpdateBtn.TabIndex = 7;
            UpdateBtn.Text = "Cập Nhật";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Visible = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // Emp_DonViTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UpdateBtn);
            Controls.Add(InsertBtn);
            Controls.Add(SearchBtn);
            Controls.Add(label2);
            Controls.Add(searchTextBox);
            Controls.Add(refreshBtn);
            Controls.Add(dataGridView1);
            Margin = new Padding(4);
            MinimumSize = new Size(1790, 1000);
            Name = "Emp_DonViTab";
            Size = new Size(1790, 1000);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button refreshBtn;
        private TextBox searchTextBox;
        private Label label1;
        private Label label2;
        private Button SearchBtn;
        private Button InsertBtn;
        private Button UpdateBtn;
    }
}

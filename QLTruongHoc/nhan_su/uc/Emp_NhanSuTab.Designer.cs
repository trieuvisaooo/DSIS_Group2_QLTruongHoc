namespace QLTruongHoc.nhan_su.uc
{
    partial class Emp_NhanSuTab
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
            NhanSu_Table = new DataGridView();
            searchTextBox = new TextBox();
            label1 = new Label();
            SearchBtn = new Button();
            ViewBtn = new Button();
            InsertBtn = new Button();
            DeleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)NhanSu_Table).BeginInit();
            SuspendLayout();
            // 
            // NhanSu_Table
            // 
            NhanSu_Table.AllowUserToOrderColumns = true;
            NhanSu_Table.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NhanSu_Table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            NhanSu_Table.BackgroundColor = SystemColors.ButtonFace;
            NhanSu_Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NhanSu_Table.Location = new Point(4, 94);
            NhanSu_Table.Margin = new Padding(4, 5, 4, 5);
            NhanSu_Table.Name = "NhanSu_Table";
            NhanSu_Table.RowHeadersWidth = 51;
            NhanSu_Table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            NhanSu_Table.Size = new Size(1778, 878);
            NhanSu_Table.TabIndex = 0;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Microsoft Sans Serif", 11.25F);
            searchTextBox.Location = new Point(131, 33);
            searchTextBox.Margin = new Padding(4, 5, 4, 5);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(418, 33);
            searchTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F);
            label1.Location = new Point(10, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 29);
            label1.TabIndex = 2;
            label1.Text = "Tìm kiếm";
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.MediumVioletRed;
            SearchBtn.Font = new Font("Microsoft Sans Serif", 11.25F);
            SearchBtn.ForeColor = SystemColors.ButtonFace;
            SearchBtn.Location = new Point(553, 25);
            SearchBtn.Margin = new Padding(0);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(130, 47);
            SearchBtn.TabIndex = 3;
            SearchBtn.Text = "Tìm Kiếm";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // ViewBtn
            // 
            ViewBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ViewBtn.BackColor = Color.DarkSlateBlue;
            ViewBtn.Font = new Font("Microsoft Sans Serif", 11.25F);
            ViewBtn.ForeColor = SystemColors.ButtonFace;
            ViewBtn.Location = new Point(1661, 25);
            ViewBtn.Margin = new Padding(0);
            ViewBtn.Name = "ViewBtn";
            ViewBtn.Size = new Size(121, 47);
            ViewBtn.TabIndex = 4;
            ViewBtn.Text = "Xem";
            ViewBtn.UseVisualStyleBackColor = false;
            ViewBtn.Click += ViewBtn_Click;
            // 
            // InsertBtn
            // 
            InsertBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            InsertBtn.BackColor = Color.MediumSpringGreen;
            InsertBtn.ForeColor = SystemColors.ActiveCaptionText;
            InsertBtn.Location = new Point(1044, 25);
            InsertBtn.Name = "InsertBtn";
            InsertBtn.Size = new Size(121, 47);
            InsertBtn.TabIndex = 5;
            InsertBtn.Text = "Thêm";
            InsertBtn.UseVisualStyleBackColor = false;
            InsertBtn.Click += InsertBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteBtn.BackColor = Color.Crimson;
            DeleteBtn.ForeColor = SystemColors.ActiveCaptionText;
            DeleteBtn.Location = new Point(1171, 26);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(121, 47);
            DeleteBtn.TabIndex = 6;
            DeleteBtn.Text = "Xóa";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // Emp_NhanSuTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteBtn);
            Controls.Add(InsertBtn);
            Controls.Add(ViewBtn);
            Controls.Add(SearchBtn);
            Controls.Add(label1);
            Controls.Add(searchTextBox);
            Controls.Add(NhanSu_Table);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1804, 1000);
            Name = "Emp_NhanSuTab";
            Size = new Size(1804, 1000);
            ((System.ComponentModel.ISupportInitialize)NhanSu_Table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView NhanSu_Table;
        private TextBox searchTextBox;
        private Label label1;
        private Button SearchBtn;
        private Button ViewBtn;
        private Button InsertBtn;
        private Button DeleteBtn;
    }
}

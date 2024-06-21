namespace QLTruongHoc.nhan_su.forms
{
    partial class ThoiGianDK
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
            dataGridView1 = new DataGridView();
            ViewBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            InsertBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(837, 394);
            dataGridView1.TabIndex = 0;
            // 
            // ViewBtn
            // 
            ViewBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ViewBtn.BackColor = Color.DarkSlateBlue;
            ViewBtn.ForeColor = SystemColors.HighlightText;
            ViewBtn.Location = new Point(734, 24);
            ViewBtn.Name = "ViewBtn";
            ViewBtn.Size = new Size(121, 47);
            ViewBtn.TabIndex = 3;
            ViewBtn.Text = "Xem";
            ViewBtn.UseVisualStyleBackColor = false;
            ViewBtn.Click += ViewBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UpdateBtn.BackColor = Color.PaleGoldenrod;
            UpdateBtn.ForeColor = SystemColors.ActiveCaptionText;
            UpdateBtn.Location = new Point(480, 24);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(121, 47);
            UpdateBtn.TabIndex = 8;
            UpdateBtn.Text = "Cập Nhật";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteBtn.BackColor = Color.Crimson;
            DeleteBtn.ForeColor = SystemColors.ActiveCaptionText;
            DeleteBtn.Location = new Point(607, 24);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(121, 47);
            DeleteBtn.TabIndex = 7;
            DeleteBtn.Text = "Xóa";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // InsertBtn
            // 
            InsertBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            InsertBtn.BackColor = Color.MediumSeaGreen;
            InsertBtn.ForeColor = SystemColors.ActiveCaptionText;
            InsertBtn.Location = new Point(353, 24);
            InsertBtn.Name = "InsertBtn";
            InsertBtn.Size = new Size(121, 47);
            InsertBtn.TabIndex = 6;
            InsertBtn.Text = "Tạo Mới";
            InsertBtn.UseVisualStyleBackColor = false;
            InsertBtn.Click += InsertBtn_Click;
            // 
            // ThoiGianDK
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 499);
            Controls.Add(UpdateBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(InsertBtn);
            Controls.Add(ViewBtn);
            Controls.Add(dataGridView1);
            Name = "ThoiGianDK";
            Text = "Chỉnh Sửa Thời Gian DKHP";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button ViewBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button InsertBtn;
    }
}
namespace QLTruongHoc.nhan_su.uc
{
    partial class Emp_PhanCongTab
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
            label1 = new Label();
            ViewBtn = new Button();
            InsertBtn = new Button();
            DeleteBtn = new Button();
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
            dataGridView1.Location = new Point(16, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1396, 696);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 9);
            label1.Name = "label1";
            label1.Size = new Size(217, 45);
            label1.TabIndex = 1;
            label1.Text = "PHÂN CÔNG";
            // 
            // ViewBtn
            // 
            ViewBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ViewBtn.BackColor = Color.DarkSlateBlue;
            ViewBtn.ForeColor = SystemColors.ButtonHighlight;
            ViewBtn.Location = new Point(1291, 34);
            ViewBtn.Name = "ViewBtn";
            ViewBtn.Size = new Size(121, 47);
            ViewBtn.TabIndex = 2;
            ViewBtn.Text = "Xem";
            ViewBtn.UseVisualStyleBackColor = false;
            ViewBtn.Click += ViewBtn_Click;
            // 
            // InsertBtn
            // 
            InsertBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            InsertBtn.BackColor = Color.MediumSpringGreen;
            InsertBtn.ForeColor = SystemColors.ActiveCaptionText;
            InsertBtn.Location = new Point(812, 34);
            InsertBtn.Name = "InsertBtn";
            InsertBtn.Size = new Size(121, 47);
            InsertBtn.TabIndex = 3;
            InsertBtn.Text = "Tạo Mới";
            InsertBtn.UseVisualStyleBackColor = false;
            InsertBtn.Click += InsertBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteBtn.BackColor = Color.Crimson;
            DeleteBtn.ForeColor = SystemColors.ActiveCaptionText;
            DeleteBtn.Location = new Point(1066, 34);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(121, 47);
            DeleteBtn.TabIndex = 4;
            DeleteBtn.Text = "Xóa";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UpdateBtn.BackColor = Color.PaleGoldenrod;
            UpdateBtn.ForeColor = SystemColors.ActiveCaptionText;
            UpdateBtn.Location = new Point(939, 34);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(121, 47);
            UpdateBtn.TabIndex = 5;
            UpdateBtn.Text = "Cập Nhật";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // Emp_PhanCongTab
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UpdateBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(InsertBtn);
            Controls.Add(ViewBtn);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(1432, 800);
            Name = "Emp_PhanCongTab";
            Size = new Size(1432, 800);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button ViewBtn;
        private Button InsertBtn;
        private Button DeleteBtn;
        private Button UpdateBtn;
    }
}

namespace QLTruongHoc.nhan_su.uc
{
    partial class Emp_SinhVienTab
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
            DKHPBtn = new Button();
            EditTimeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1399, 683);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 0);
            label1.Name = "label1";
            label1.Size = new Size(336, 45);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // ViewBtn
            // 
            ViewBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ViewBtn.BackColor = Color.DarkSlateBlue;
            ViewBtn.ForeColor = SystemColors.ButtonFace;
            ViewBtn.Location = new Point(1295, 50);
            ViewBtn.Name = "ViewBtn";
            ViewBtn.Size = new Size(121, 47);
            ViewBtn.TabIndex = 2;
            ViewBtn.Text = "Xem";
            ViewBtn.UseVisualStyleBackColor = false;
            ViewBtn.Click += ViewBtn_Click;
            // 
            // InsertBtn
            // 
            InsertBtn.BackColor = Color.MediumSeaGreen;
            InsertBtn.Location = new Point(17, 49);
            InsertBtn.Name = "InsertBtn";
            InsertBtn.Size = new Size(121, 47);
            InsertBtn.TabIndex = 3;
            InsertBtn.Text = "Tạo Mới";
            InsertBtn.UseVisualStyleBackColor = false;
            InsertBtn.Visible = false;
            InsertBtn.Click += InsertBtn_Click;
            // 
            // DKHPBtn
            // 
            DKHPBtn.BackColor = Color.MediumSeaGreen;
            DKHPBtn.ForeColor = SystemColors.ActiveCaptionText;
            DKHPBtn.Location = new Point(144, 50);
            DKHPBtn.Name = "DKHPBtn";
            DKHPBtn.Size = new Size(140, 47);
            DKHPBtn.TabIndex = 6;
            DKHPBtn.Text = "Đăng Ký HP";
            DKHPBtn.UseVisualStyleBackColor = false;
            DKHPBtn.Visible = false;
            DKHPBtn.Click += DKHPBtn_Click;
            // 
            // EditTimeBtn
            // 
            EditTimeBtn.BackColor = Color.PaleGoldenrod;
            EditTimeBtn.ForeColor = SystemColors.ActiveCaptionText;
            EditTimeBtn.Location = new Point(290, 50);
            EditTimeBtn.Name = "EditTimeBtn";
            EditTimeBtn.Size = new Size(168, 47);
            EditTimeBtn.TabIndex = 7;
            EditTimeBtn.Text = "Chỉnh sử TGDK";
            EditTimeBtn.UseVisualStyleBackColor = false;
            EditTimeBtn.Visible = false;
            EditTimeBtn.Click += EditTimeBtn_Click;
            // 
            // Emp_SinhVienTab
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EditTimeBtn);
            Controls.Add(DKHPBtn);
            Controls.Add(InsertBtn);
            Controls.Add(ViewBtn);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(1432, 800);
            Name = "Emp_SinhVienTab";
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
        private Button DKHPBtn;
        private Button EditTimeBtn;
    }
}

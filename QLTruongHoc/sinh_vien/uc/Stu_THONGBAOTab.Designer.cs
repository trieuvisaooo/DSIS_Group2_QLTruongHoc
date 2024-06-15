namespace QLTruongHoc.sinh_vien.uc
{
    partial class Stu_THONGBAOTab
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            dataGridView1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(390, 45);
            label1.TabIndex = 11;
            label1.Text = "THÔNG BÁO SINH VIÊN";
            // 
            // ViewBtn
            // 
            ViewBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ViewBtn.BackColor = Color.DarkSlateBlue;
            ViewBtn.ForeColor = SystemColors.ButtonHighlight;
            ViewBtn.Location = new Point(1297, 65);
            ViewBtn.Name = "ViewBtn";
            ViewBtn.Size = new Size(121, 47);
            ViewBtn.TabIndex = 17;
            ViewBtn.Text = "Xem";
            ViewBtn.UseVisualStyleBackColor = false;
            ViewBtn.Click += ViewBtn_Click;
            // 
            // THONGBAOTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ViewBtn);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            MinimumSize = new Size(1432, 800);
            Name = "THONGBAOTab";
            Size = new Size(1432, 800);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button ViewBtn;
    }
}

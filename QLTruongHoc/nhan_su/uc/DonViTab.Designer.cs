namespace QLTruongHoc.nhan_su.uc
{
    partial class DonViTab
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
            label1 = new Label();
            label2 = new Label();
            searchBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1434, 728);
            dataGridView1.TabIndex = 0;
            // 
            // refreshBtn
            // 
            refreshBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refreshBtn.BackColor = Color.DarkSlateBlue;
            refreshBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshBtn.ForeColor = Color.Snow;
            refreshBtn.Location = new Point(1343, 24);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(94, 39);
            refreshBtn.TabIndex = 1;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(939, 28);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(272, 31);
            searchTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(849, 31);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 3;
            label1.Text = "Tìm kiếm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 18);
            label2.Name = "label2";
            label2.Size = new Size(118, 38);
            label2.TabIndex = 4;
            label2.Text = "ĐƠN VỊ";
            // 
            // searchBtn
            // 
            searchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchBtn.BackColor = Color.MediumVioletRed;
            searchBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBtn.ForeColor = Color.Snow;
            searchBtn.Location = new Point(1211, 24);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 39);
            searchBtn.TabIndex = 5;
            searchBtn.Text = "Tìm kiếm";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // DonViTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(searchBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(searchTextBox);
            Controls.Add(refreshBtn);
            Controls.Add(dataGridView1);
            MinimumSize = new Size(1432, 800);
            Name = "DonViTab";
            Size = new Size(1440, 800);
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
        private Button searchBtn;
    }
}

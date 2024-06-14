namespace QLTruongHoc.nhan_su.uc
{
    partial class HocPhanTab
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
            label2 = new Label();
            searchTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
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
            label1.Size = new Size(269, 38);
            label1.TabIndex = 0;
            label1.Text = "TẤT CẢ HỌC PHẦN";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1425, 920);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 2;
            label2.Text = "Tìm kiếm";
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchTextBox.Location = new Point(93, 7);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(194, 31);
            searchTextBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.MediumVioletRed;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(293, 7);
            button1.Name = "button1";
            button1.Size = new Size(94, 34);
            button1.TabIndex = 4;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.DarkSlateBlue;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(446, 5);
            button2.Name = "button2";
            button2.Size = new Size(94, 36);
            button2.TabIndex = 5;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(searchTextBox);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(886, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 47);
            panel1.TabIndex = 6;
            // 
            // HocPhanTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(1432, 1000);
            Name = "HocPhanTab";
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
        private Button button1;
        private Button button2;
        private Panel panel1;
    }
}

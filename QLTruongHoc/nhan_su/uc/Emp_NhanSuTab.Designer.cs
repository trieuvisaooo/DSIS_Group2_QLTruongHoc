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
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)NhanSu_Table).BeginInit();
            SuspendLayout();
            // 
            // NhanSu_Table
            // 
            NhanSu_Table.AllowUserToOrderColumns = true;
            NhanSu_Table.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NhanSu_Table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            NhanSu_Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NhanSu_Table.Location = new Point(3, 75);
            NhanSu_Table.Margin = new Padding(3, 4, 3, 4);
            NhanSu_Table.Name = "NhanSu_Table";
            NhanSu_Table.RowHeadersWidth = 51;
            NhanSu_Table.Size = new Size(1422, 721);
            NhanSu_Table.TabIndex = 0;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Microsoft Sans Serif", 11.25F);
            searchTextBox.Location = new Point(105, 16);
            searchTextBox.Margin = new Padding(3, 4, 3, 4);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(335, 29);
            searchTextBox.TabIndex = 1;
            searchTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F);
            label1.Location = new Point(7, 20);
            label1.Name = "label1";
            label1.Size = new Size(87, 24);
            label1.TabIndex = 2;
            label1.Text = "Tìm kiếm";
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Microsoft Sans Serif", 11.25F);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(445, 16);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(110, 35);
            button1.TabIndex = 3;
            button1.Text = "Tìm Kiếm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.DarkSlateBlue;
            button2.Font = new Font("Microsoft Sans Serif", 11.25F);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(1328, 20);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(97, 51);
            button2.TabIndex = 4;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // NhanSuTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(searchTextBox);
            Controls.Add(NhanSu_Table);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1443, 800);
            Name = "NhanSuTab";
            Size = new Size(1443, 800);
            Load += NhanSu_tab_Load;
            ((System.ComponentModel.ISupportInitialize)NhanSu_Table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView NhanSu_Table;
        private TextBox searchTextBox;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}

namespace QLTruongHoc.NhanSu
{
    partial class NhanSu_tab
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
            ((System.ComponentModel.ISupportInitialize)NhanSu_Table).BeginInit();
            SuspendLayout();
            // 
            // NhanSu_Table
            // 
            NhanSu_Table.AllowUserToOrderColumns = true;
            NhanSu_Table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            NhanSu_Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NhanSu_Table.Location = new Point(3, 95);
            NhanSu_Table.Name = "NhanSu_Table";
            NhanSu_Table.Size = new Size(1269, 558);
            NhanSu_Table.TabIndex = 0;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(899, 35);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(294, 26);
            searchTextBox.TabIndex = 1;
            searchTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(813, 38);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 2;
            label1.Text = "Tìm kiếm";
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(1196, 35);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 3;
            button1.Text = "Tìm Kiếm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // NhanSu_tab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(searchTextBox);
            Controls.Add(NhanSu_Table);
            Name = "NhanSu_tab";
            Size = new Size(1278, 653);
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
    }
}

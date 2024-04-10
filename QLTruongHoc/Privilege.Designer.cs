namespace QLTruongHoc
{
    partial class Privilege
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            tableColumn = new DataGridView();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)tableColumn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(48, 27);
            button1.Name = "button1";
            button1.Size = new Size(194, 53);
            button1.TabIndex = 0;
            button1.Text = "CẤP QUYỀN CHO ROLE/USER";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(291, 27);
            button2.Name = "button2";
            button2.Size = new Size(191, 52);
            button2.TabIndex = 1;
            button2.Text = "HỦY QUYỀN CỦA ROLE/USER";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(54, 113);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 3;
            label1.Text = "TABLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 502);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 4;
            label2.Text = "COLUMN";
            label2.Click += label2_Click;
            // 
            // tableColumn
            // 
            tableColumn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableColumn.Location = new Point(48, 533);
            tableColumn.Name = "tableColumn";
            tableColumn.RowHeadersWidth = 51;
            tableColumn.Size = new Size(1324, 335);
            tableColumn.TabIndex = 5;
            tableColumn.CellContentClick += tableColumn_CellContentClick;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1324, 335);
            dataGridView1.TabIndex = 6;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button3.Location = new Point(1240, 27);
            button3.Name = "button3";
            button3.Size = new Size(110, 52);
            button3.TabIndex = 7;
            button3.Text = "Select";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1107, 52);
            button4.Name = "button4";
            button4.Size = new Size(70, 26);
            button4.TabIndex = 8;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(959, 27);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 9;
            label3.Text = "Tìm kiếm Guarantee";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(959, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 27);
            textBox1.TabIndex = 10;
            // 
            // Privilege
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(tableColumn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Privilege";
            Size = new Size(1448, 910);
            ((System.ComponentModel.ISupportInitialize)tableColumn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private DataGridView tableColumn;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private Label label3;
        private TextBox textBox1;
    }
}

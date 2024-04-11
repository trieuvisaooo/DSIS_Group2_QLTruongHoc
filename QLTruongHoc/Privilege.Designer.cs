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
            grantBtn = new Button();
            revokeBtn = new Button();
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
            // grantBtn
            // 
            grantBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grantBtn.Location = new Point(60, 34);
            grantBtn.Margin = new Padding(4);
            grantBtn.Name = "grantBtn";
            grantBtn.Size = new Size(242, 66);
            grantBtn.TabIndex = 0;
            grantBtn.Text = "CẤP QUYỀN CHO ROLE/USER";
            grantBtn.UseVisualStyleBackColor = true;
            grantBtn.Click += grantBtn_Click;
            // 
            // revokeBtn
            // 
            revokeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            revokeBtn.Location = new Point(364, 34);
            revokeBtn.Margin = new Padding(4);
            revokeBtn.Name = "revokeBtn";
            revokeBtn.Size = new Size(239, 65);
            revokeBtn.TabIndex = 1;
            revokeBtn.Text = "HỦY QUYỀN CỦA ROLE/USER";
            revokeBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(68, 141);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 3;
            label1.Text = "TABLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 628);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 4;
            label2.Text = "COLUMN";
            label2.Click += label2_Click;
            // 
            // tableColumn
            // 
            tableColumn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableColumn.Location = new Point(60, 666);
            tableColumn.Margin = new Padding(4);
            tableColumn.Name = "tableColumn";
            tableColumn.RowHeadersWidth = 51;
            tableColumn.Size = new Size(1655, 419);
            tableColumn.TabIndex = 5;
            tableColumn.CellContentClick += tableColumn_CellContentClick;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(60, 180);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1655, 419);
            dataGridView1.TabIndex = 6;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button3.Location = new Point(1550, 34);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(138, 65);
            button3.TabIndex = 7;
            button3.Text = "Load";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1384, 65);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(88, 32);
            button4.TabIndex = 8;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1199, 34);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 9;
            label3.Text = "Tìm kiếm Grantee";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1199, 65);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 31);
            textBox1.TabIndex = 10;
            // 
            // Privilege
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(tableColumn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(revokeBtn);
            Controls.Add(grantBtn);
            Margin = new Padding(4);
            Name = "Privilege";
            Size = new Size(1810, 1138);
            ((System.ComponentModel.ISupportInitialize)tableColumn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button grantBtn;
        private Button revokeBtn;
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

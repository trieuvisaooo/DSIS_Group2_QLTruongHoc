namespace QLTruongHoc
{
    partial class DBA_RoleUI
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1385, 637);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(16, 26);
            button1.Name = "button1";
            button1.Size = new Size(169, 67);
            button1.TabIndex = 1;
            button1.Text = "CẤP ROLE CHO USER/ROLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(191, 26);
            button2.Name = "button2";
            button2.Size = new Size(163, 67);
            button2.TabIndex = 2;
            button2.Text = "HỦY ROLE CỦA USER/ROLE";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(370, 26);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 3;
            label1.Text = "Tìm kiếm User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(839, 26);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 4;
            label2.Text = "Tìm kiếm Role";
            label2.Click += label2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(661, 62);
            button3.Name = "button3";
            button3.Size = new Size(96, 34);
            button3.TabIndex = 5;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLight;
            button4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            button4.Location = new Point(1146, 62);
            button4.Name = "button4";
            button4.Size = new Size(96, 34);
            button4.TabIndex = 6;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F);
            textBox1.Location = new Point(370, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 31);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.8F);
            textBox2.Location = new Point(850, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 31);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLight;
            button5.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(1309, 60);
            button5.Name = "button5";
            button5.Size = new Size(101, 39);
            button5.TabIndex = 9;
            button5.Text = "SELECT";
            button5.UseVisualStyleBackColor = false;
            // 
            // DBA_RoleUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "DBA_RoleUI";
            Size = new Size(1441, 827);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button5;
    }
}

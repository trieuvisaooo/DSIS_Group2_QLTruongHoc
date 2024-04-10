namespace QLTruongHoc
{
    partial class UseransRole
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
            label2 = new Label();
            userGrid = new DataGridView();
            roleGrid = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)userGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roleGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold);
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(62, 27);
            label1.TabIndex = 0;
            label1.Text = "USER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold);
            label2.Location = new Point(18, 320);
            label2.Name = "label2";
            label2.Size = new Size(64, 27);
            label2.TabIndex = 1;
            label2.Text = "ROLE";
            // 
            // userGrid
            // 
            userGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userGrid.Location = new Point(18, 57);
            userGrid.Margin = new Padding(3, 2, 3, 2);
            userGrid.Name = "userGrid";
            userGrid.RowHeadersWidth = 51;
            userGrid.Size = new Size(860, 239);
            userGrid.TabIndex = 2;
            userGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // roleGrid
            // 
            roleGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roleGrid.Location = new Point(18, 354);
            roleGrid.Margin = new Padding(3, 2, 3, 2);
            roleGrid.Name = "roleGrid";
            roleGrid.RowHeadersWidth = 51;
            roleGrid.Size = new Size(860, 239);
            roleGrid.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(1084, 132);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(116, 32);
            button2.TabIndex = 5;
            button2.Text = "Create User";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.PeachPuff;
            button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(1084, 170);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(116, 32);
            button3.TabIndex = 6;
            button3.Text = "Delete User";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Info;
            button4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            button4.Location = new Point(1084, 211);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(116, 32);
            button4.TabIndex = 7;
            button4.Text = "Update User";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Info;
            button5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            button5.Location = new Point(1084, 513);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(116, 32);
            button5.TabIndex = 10;
            button5.Text = "Update Role";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.PeachPuff;
            button6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            button6.Location = new Point(1084, 468);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(116, 32);
            button6.TabIndex = 9;
            button6.Text = "Delete Role";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.GradientInactiveCaption;
            button7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            button7.Location = new Point(1084, 420);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(116, 32);
            button7.TabIndex = 8;
            button7.Text = "Create Role";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Lavender;
            button8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            button8.Location = new Point(1119, 266);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(82, 30);
            button8.TabIndex = 11;
            button8.Text = "Search";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Lavender;
            button9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            button9.Location = new Point(1119, 563);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(82, 30);
            button9.TabIndex = 12;
            button9.Text = "Search";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            textBox1.Location = new Point(908, 268);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 28);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            textBox2.Location = new Point(908, 563);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 28);
            textBox2.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(936, 255);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 15;
            label3.Text = "Search user";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(934, 550);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 16;
            label4.Text = "Search role";
            // 
            // UseransRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(roleGrid);
            Controls.Add(userGrid);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UseransRole";
            Size = new Size(1261, 620);
            Load += UseransRole_Load;
            ((System.ComponentModel.ISupportInitialize)userGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)roleGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView userGrid;
        private DataGridView roleGrid;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
    }
}

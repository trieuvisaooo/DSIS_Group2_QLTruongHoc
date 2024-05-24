namespace QLTruongHoc
{
    partial class UserAndRoleTab
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
            refreshButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)userGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roleGrid).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold);
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(62, 27);
            label1.TabIndex = 0;
            label1.Text = "USER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 27);
            label2.TabIndex = 1;
            label2.Text = "ROLE";
            // 
            // userGrid
            // 
            userGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userGrid.BackgroundColor = SystemColors.Control;
            userGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userGrid.Location = new Point(3, 35);
            userGrid.Margin = new Padding(3, 2, 3, 2);
            userGrid.Name = "userGrid";
            userGrid.RowHeadersWidth = 51;
            userGrid.Size = new Size(886, 257);
            userGrid.TabIndex = 2;
            userGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // roleGrid
            // 
            roleGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roleGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            roleGrid.BackgroundColor = SystemColors.Control;
            roleGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roleGrid.Location = new Point(0, 22);
            roleGrid.Margin = new Padding(3, 2, 3, 2);
            roleGrid.Name = "roleGrid";
            roleGrid.RowHeadersWidth = 51;
            roleGrid.Size = new Size(889, 268);
            roleGrid.TabIndex = 3;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(239, 74);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(116, 32);
            button2.TabIndex = 5;
            button2.Text = "Create User";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.PeachPuff;
            button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(239, 112);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(116, 32);
            button3.TabIndex = 6;
            button3.Text = "Delete User";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = SystemColors.Info;
            button4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            button4.Location = new Point(239, 153);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(116, 32);
            button4.TabIndex = 7;
            button4.Text = "Update User";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.BackColor = SystemColors.Info;
            button5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            button5.Location = new Point(240, 157);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(116, 32);
            button5.TabIndex = 10;
            button5.Text = "Update Role";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button6.BackColor = Color.PeachPuff;
            button6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            button6.Location = new Point(240, 112);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(116, 32);
            button6.TabIndex = 9;
            button6.Text = "Delete Role";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button7.BackColor = SystemColors.GradientInactiveCaption;
            button7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            button7.Location = new Point(240, 64);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(116, 32);
            button7.TabIndex = 8;
            button7.Text = "Create Role";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button8.BackColor = Color.Lavender;
            button8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            button8.Location = new Point(274, 208);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(82, 30);
            button8.TabIndex = 11;
            button8.Text = "Search";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button9.BackColor = Color.Lavender;
            button9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            button9.Location = new Point(275, 207);
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
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            textBox1.Location = new Point(63, 210);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 28);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            textBox2.Location = new Point(64, 207);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 28);
            textBox2.TabIndex = 14;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(91, 197);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 15;
            label3.Text = "Search user";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(90, 194);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 16;
            label4.Text = "Search role";
            // 
            // refreshButton
            // 
            refreshButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refreshButton.BackColor = Color.DarkSlateBlue;
            refreshButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            refreshButton.ForeColor = SystemColors.ButtonHighlight;
            refreshButton.Location = new Point(807, -1);
            refreshButton.Margin = new Padding(3, 2, 3, 2);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(82, 38);
            refreshButton.TabIndex = 17;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.99032F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.00968F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1261, 610);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(userGrid);
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 299);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(roleGrid);
            panel2.Location = new Point(3, 308);
            panel2.Name = "panel2";
            panel2.Size = new Size(889, 299);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(textBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(898, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(360, 299);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(button7);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(button9);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(898, 308);
            panel4.Name = "panel4";
            panel4.Size = new Size(360, 299);
            panel4.TabIndex = 3;
            // 
            // UserAndRoleTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1261, 600);
            Name = "UserAndRoleTab";
            Size = new Size(1261, 600);
            Load += UseransRole_Load;
            ((System.ComponentModel.ISupportInitialize)userGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)roleGrid).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        public DataGridView userGrid;
        public DataGridView roleGrid;
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
        private Button refreshButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}

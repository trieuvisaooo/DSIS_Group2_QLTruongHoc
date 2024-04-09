namespace QLTruongHoc
{
    partial class DBA_GrantPrivs
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            Column = new CheckedListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label7 = new Label();
            button3 = new Button();
            button4 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(11, 21);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "User/Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(347, 21);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "Attributes";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(107, 63);
            button1.Name = "button1";
            button1.Size = new Size(79, 28);
            button1.TabIndex = 3;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(192, 63);
            button2.Name = "button2";
            button2.Size = new Size(79, 28);
            button2.TabIndex = 4;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            // 
            // Column
            // 
            Column.FormattingEnabled = true;
            Column.Location = new Point(324, 44);
            Column.Name = "Column";
            Column.Size = new Size(196, 202);
            Column.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(11, 101);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 6;
            label3.Text = "Result:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(96, 101);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 7;
            label4.Text = "Unchecked";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(11, 134);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 8;
            label5.Text = "Privilege";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(11, 174);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 9;
            label6.Text = "Table/View";
            label6.Click += label6_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(96, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 28);
            comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(96, 171);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(187, 28);
            comboBox2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(11, 274);
            label7.Name = "label7";
            label7.Size = new Size(422, 20);
            label7.TabIndex = 12;
            label7.Text = "(*) Vui lòng nhấn nút \"Check\" bên trên để có thể cấp quyền.";
            label7.Click += label7_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.HotTrack;
            button3.Location = new Point(96, 242);
            button3.Name = "button3";
            button3.Size = new Size(151, 31);
            button3.TabIndex = 13;
            button3.Text = "Gant Privilege";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightCoral;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(449, 270);
            button4.Name = "button4";
            button4.Size = new Size(79, 28);
            button4.TabIndex = 14;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(96, 209);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(177, 24);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "WITH GRANT OPTION";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // DBA_GrantPrivs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 303);
            Controls.Add(checkBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Column);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DBA_GrantPrivs";
            Text = "DBA_GrantPrivs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private CheckedListBox Column;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label7;
        private Button button3;
        private Button button4;
        private CheckBox checkBox1;

    }
}
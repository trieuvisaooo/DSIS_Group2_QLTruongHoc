namespace QLTruongHoc.nhan_su.forms
{
    partial class UpdateDonVi
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
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.5785961F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.4214F));
            tableLayoutPanel1.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 1, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 2);
            tableLayoutPanel1.Location = new Point(31, 51);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(598, 286);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(144, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(451, 36);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(22, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 30);
            label1.TabIndex = 0;
            label1.Text = "Mã Đơn Vị";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(90, 62);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 30);
            label2.TabIndex = 1;
            label2.Text = "Tên";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(144, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(451, 36);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Location = new Point(144, 189);
            button1.Name = "button1";
            button1.Size = new Size(121, 47);
            button1.TabIndex = 4;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(9, 124);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(128, 60);
            label3.TabIndex = 5;
            label3.Text = "Trưởng Đơn Vị";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(144, 127);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(451, 38);
            comboBox1.TabIndex = 6;
            // 
            // UpdateDonVi
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 388);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "UpdateDonVi";
            Text = "Cập Nhật Đơn Vị";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private ComboBox comboBox1;
    }
}
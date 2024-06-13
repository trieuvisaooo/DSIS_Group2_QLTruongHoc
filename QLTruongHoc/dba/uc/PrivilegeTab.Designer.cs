namespace QLTruongHoc
{
    partial class PrivilegeTab
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
            ColDataGridView = new DataGridView();
            TableDataGridView = new DataGridView();
            label3 = new Label();
            search_txtbox = new TextBox();
            search_btn = new Button();
            button5 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            loadButton = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)ColDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TableDataGridView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // grantBtn
            // 
            grantBtn.BackColor = SystemColors.ActiveCaption;
            grantBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grantBtn.Location = new Point(0, 32);
            grantBtn.Margin = new Padding(4, 3, 4, 3);
            grantBtn.Name = "grantBtn";
            grantBtn.Size = new Size(241, 67);
            grantBtn.TabIndex = 0;
            grantBtn.Text = "CẤP QUYỀN CHO ROLE/USER";
            grantBtn.UseVisualStyleBackColor = false;
            grantBtn.Click += grantBtn_Click;
            // 
            // revokeBtn
            // 
            revokeBtn.BackColor = Color.LightCoral;
            revokeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            revokeBtn.Location = new Point(304, 32);
            revokeBtn.Margin = new Padding(4, 3, 4, 3);
            revokeBtn.Name = "revokeBtn";
            revokeBtn.Size = new Size(239, 65);
            revokeBtn.TabIndex = 1;
            revokeBtn.Text = "HỦY QUYỀN CỦA ROLE/USER";
            revokeBtn.UseVisualStyleBackColor = false;
            revokeBtn.Click += revokeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(4, 0);
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
            label2.Location = new Point(4, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 4;
            label2.Text = "COLUMN";
            label2.Click += label2_Click;
            // 
            // ColDataGridView
            // 
            ColDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ColDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ColDataGridView.BackgroundColor = SystemColors.Control;
            ColDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ColDataGridView.Location = new Point(0, 38);
            ColDataGridView.Margin = new Padding(4, 3, 4, 3);
            ColDataGridView.Name = "ColDataGridView";
            ColDataGridView.RowHeadersWidth = 51;
            ColDataGridView.Size = new Size(1791, 348);
            ColDataGridView.TabIndex = 5;
            ColDataGridView.CellContentClick += tableColumn_CellContentClick;
            // 
            // TableDataGridView
            // 
            TableDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TableDataGridView.BackgroundColor = SystemColors.Control;
            TableDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableDataGridView.Location = new Point(4, 38);
            TableDataGridView.Margin = new Padding(4, 3, 4, 3);
            TableDataGridView.Name = "TableDataGridView";
            TableDataGridView.RowHeadersWidth = 51;
            TableDataGridView.Size = new Size(1787, 348);
            TableDataGridView.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label3.Location = new Point(636, 28);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(172, 28);
            label3.TabIndex = 9;
            label3.Text = "Search By Grantee";
            // 
            // search_txtbox
            // 
            search_txtbox.Location = new Point(636, 60);
            search_txtbox.Margin = new Padding(4, 3, 4, 3);
            search_txtbox.Name = "search_txtbox";
            search_txtbox.Size = new Size(205, 31);
            search_txtbox.TabIndex = 10;
            // 
            // search_btn
            // 
            search_btn.BackColor = Color.DarkSlateBlue;
            search_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            search_btn.ForeColor = SystemColors.ButtonFace;
            search_btn.Location = new Point(849, 53);
            search_btn.Margin = new Padding(4, 3, 4, 3);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(120, 44);
            search_btn.TabIndex = 8;
            search_btn.Text = "Tìm";
            search_btn.UseVisualStyleBackColor = false;
            search_btn.Click += search_btn_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSlateBlue;
            button5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(1380, -100);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(111, 58);
            button5.TabIndex = 11;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1804, 1000);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Controls.Add(loadButton);
            panel2.Controls.Add(grantBtn);
            panel2.Controls.Add(search_txtbox);
            panel2.Controls.Add(revokeBtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(search_btn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(4, 5);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1796, 190);
            panel2.TabIndex = 1;
            // 
            // loadButton
            // 
            loadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            loadButton.BackColor = Color.DarkSlateBlue;
            loadButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            loadButton.ForeColor = SystemColors.ButtonFace;
            loadButton.Location = new Point(1671, 141);
            loadButton.Margin = new Padding(4, 5, 4, 5);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(120, 44);
            loadButton.TabIndex = 11;
            loadButton.Text = "Refresh";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(ColDataGridView);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(4, 605);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1796, 390);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(TableDataGridView);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(4, 205);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1796, 390);
            panel3.TabIndex = 2;
            // 
            // PrivilegeTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1804, 1000);
            Name = "PrivilegeTab";
            Size = new Size(1804, 1000);
            Load += Privilege_Load;
            ((System.ComponentModel.ISupportInitialize)ColDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)TableDataGridView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button grantBtn;
        private Button revokeBtn;
        private Label label1;
        private Label label2;
        private DataGridView ColDataGridView;
        private DataGridView TableDataGridView;
        private Label label3;
        private TextBox search_txtbox;
        private Button search_btn;
        private Button button5;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Button loadButton;
    }
}

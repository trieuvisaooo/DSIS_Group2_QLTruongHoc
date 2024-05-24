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
            ColDataGridView = new DataGridView();
            TableDataGridView = new DataGridView();
            label3 = new Label();
            search_txtbox = new TextBox();
            search_btn = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)ColDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TableDataGridView).BeginInit();
            SuspendLayout();
            // 
            // grantBtn
            // 
            grantBtn.BackColor = SystemColors.ActiveCaption;
            grantBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grantBtn.Location = new Point(42, 20);
            grantBtn.Margin = new Padding(3, 2, 3, 2);
            grantBtn.Name = "grantBtn";
            grantBtn.Size = new Size(169, 40);
            grantBtn.TabIndex = 0;
            grantBtn.Text = "CẤP QUYỀN CHO ROLE/USER";
            grantBtn.UseVisualStyleBackColor = false;
            grantBtn.Click += grantBtn_Click;
            // 
            // revokeBtn
            // 
            revokeBtn.BackColor = Color.LightCoral;
            revokeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            revokeBtn.Location = new Point(255, 20);
            revokeBtn.Margin = new Padding(3, 2, 3, 2);
            revokeBtn.Name = "revokeBtn";
            revokeBtn.Size = new Size(167, 39);
            revokeBtn.TabIndex = 1;
            revokeBtn.Text = "HỦY QUYỀN CỦA ROLE/USER";
            revokeBtn.UseVisualStyleBackColor = false;
            revokeBtn.Click += revokeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(42, 70);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 3;
            label1.Text = "TABLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 346);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 4;
            label2.Text = "COLUMN";
            label2.Click += label2_Click;
            // 
            // ColDataGridView
            // 
            ColDataGridView.BackgroundColor = SystemColors.Control;
            ColDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ColDataGridView.Location = new Point(41, 370);
            ColDataGridView.Margin = new Padding(3, 2, 3, 2);
            ColDataGridView.Name = "ColDataGridView";
            ColDataGridView.RowHeadersWidth = 51;
            ColDataGridView.Size = new Size(1081, 249);
            ColDataGridView.TabIndex = 5;
            ColDataGridView.CellContentClick += tableColumn_CellContentClick;
            // 
            // TableDataGridView
            // 
            TableDataGridView.BackgroundColor = SystemColors.Control;
            TableDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableDataGridView.Location = new Point(42, 92);
            TableDataGridView.Margin = new Padding(3, 2, 3, 2);
            TableDataGridView.Name = "TableDataGridView";
            TableDataGridView.RowHeadersWidth = 51;
            TableDataGridView.Size = new Size(1080, 251);
            TableDataGridView.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label3.Location = new Point(709, 18);
            label3.Name = "label3";
            label3.Size = new Size(123, 19);
            label3.TabIndex = 9;
            label3.Text = "Search By Grantee";
            // 
            // search_txtbox
            // 
            search_txtbox.Location = new Point(709, 37);
            search_txtbox.Margin = new Padding(3, 2, 3, 2);
            search_txtbox.Name = "search_txtbox";
            search_txtbox.Size = new Size(124, 23);
            search_txtbox.TabIndex = 10;
            // 
            // search_btn
            // 
            search_btn.BackColor = SystemColors.ButtonShadow;
            search_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            search_btn.Location = new Point(838, 35);
            search_btn.Margin = new Padding(3, 2, 3, 2);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(62, 21);
            search_btn.TabIndex = 8;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = false;
            search_btn.Click += search_btn_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSlateBlue;
            button5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(1044, 56);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(78, 35);
            button5.TabIndex = 11;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Privilege
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button5);
            Controls.Add(search_txtbox);
            Controls.Add(label3);
            Controls.Add(search_btn);
            Controls.Add(TableDataGridView);
            Controls.Add(ColDataGridView);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(revokeBtn);
            Controls.Add(grantBtn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Privilege";
            Size = new Size(1267, 659);
            Load += Privilege_Load;
            ((System.ComponentModel.ISupportInitialize)ColDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)TableDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}

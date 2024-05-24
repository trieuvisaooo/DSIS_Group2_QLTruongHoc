namespace QLTruongHoc
{
    partial class TablesViewsTab
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
            tableGrid = new DataGridView();
            viewGrid = new DataGridView();
            button5 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)tableGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewGrid).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 0;
            label1.Text = "TABLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 1;
            label2.Text = "VIEW";
            // 
            // tableGrid
            // 
            tableGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableGrid.BackgroundColor = SystemColors.Control;
            tableGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableGrid.Location = new Point(0, 39);
            tableGrid.Name = "tableGrid";
            tableGrid.RowHeadersWidth = 62;
            tableGrid.Size = new Size(974, 255);
            tableGrid.TabIndex = 2;
            // 
            // viewGrid
            // 
            viewGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            viewGrid.BackgroundColor = SystemColors.Control;
            viewGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewGrid.Location = new Point(3, 55);
            viewGrid.Name = "viewGrid";
            viewGrid.RowHeadersWidth = 62;
            viewGrid.Size = new Size(971, 236);
            viewGrid.TabIndex = 3;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.DarkSlateBlue;
            button5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(902, 2);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(72, 35);
            button5.TabIndex = 10;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 280F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1263, 600);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tableGrid);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(977, 294);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(viewGrid);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 303);
            panel2.Name = "panel2";
            panel2.Size = new Size(977, 294);
            panel2.TabIndex = 1;
            // 
            // TablesViewsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(1263, 600);
            Name = "TablesViewsTab";
            Size = new Size(1263, 600);
            Load += TablesViewsPage_Load;
            ((System.ComponentModel.ISupportInitialize)tableGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewGrid).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView tableGrid;
        private DataGridView viewGrid;
        private Button button5;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
    }
}

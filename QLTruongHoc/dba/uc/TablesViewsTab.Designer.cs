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
            ((System.ComponentModel.ISupportInitialize)tableGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 43);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 0;
            label1.Text = "TABLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 340);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 1;
            label2.Text = "VIEW";
            // 
            // tableGrid
            // 
            tableGrid.BackgroundColor = SystemColors.Control;
            tableGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableGrid.Location = new Point(23, 78);
            tableGrid.Name = "tableGrid";
            tableGrid.RowHeadersWidth = 62;
            tableGrid.Size = new Size(980, 236);
            tableGrid.TabIndex = 2;
            // 
            // viewGrid
            // 
            viewGrid.BackgroundColor = SystemColors.Control;
            viewGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewGrid.Location = new Point(23, 381);
            viewGrid.Name = "viewGrid";
            viewGrid.RowHeadersWidth = 62;
            viewGrid.Size = new Size(980, 236);
            viewGrid.TabIndex = 3;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSlateBlue;
            button5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(925, 43);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(78, 35);
            button5.TabIndex = 10;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // TablesViewsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button5);
            Controls.Add(viewGrid);
            Controls.Add(tableGrid);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TablesViewsPage";
            Size = new Size(1260, 620);
            Load += TablesViewsPage_Load;
            ((System.ComponentModel.ISupportInitialize)tableGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView tableGrid;
        private DataGridView viewGrid;
        private Button button5;
    }
}

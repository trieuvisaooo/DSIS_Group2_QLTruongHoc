namespace QLTruongHoc
{
    partial class TableViews_UC
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
            ((System.ComponentModel.ISupportInitialize)tableGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 5);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 0;
            label1.Text = "TABLE";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 309);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 1;
            label2.Text = "VIEW";
            // 
            // tableGrid
            // 
            tableGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableGrid.Location = new Point(29, 36);
            tableGrid.Name = "tableGrid";
            tableGrid.Size = new Size(979, 260);
            tableGrid.TabIndex = 2;
            // 
            // viewGrid
            // 
            viewGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewGrid.Location = new Point(29, 340);
            viewGrid.Name = "viewGrid";
            viewGrid.Size = new Size(979, 260);
            viewGrid.TabIndex = 3;
            // 
            // TableViews_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(viewGrid);
            Controls.Add(tableGrid);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TableViews_UC";
            Size = new Size(1260, 620);
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
    }
}

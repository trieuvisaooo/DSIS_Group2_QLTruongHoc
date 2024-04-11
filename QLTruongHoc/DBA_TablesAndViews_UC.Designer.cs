namespace QLTruongHoc
{
    partial class DBA_TablesAndViews_UC
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
            viewGrid = new DataGridView();
            tableGrid = new DataGridView();
            viewLabel = new Label();
            tableLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)viewGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableGrid).BeginInit();
            SuspendLayout();
            // 
            // viewGrid
            // 
            viewGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewGrid.Location = new Point(26, 588);
            viewGrid.Margin = new Padding(4, 3, 4, 3);
            viewGrid.Name = "viewGrid";
            viewGrid.RowHeadersWidth = 51;
            viewGrid.Size = new Size(1417, 398);
            viewGrid.TabIndex = 7;
            // 
            // tableGrid
            // 
            tableGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableGrid.Location = new Point(26, 93);
            tableGrid.Margin = new Padding(4, 3, 4, 3);
            tableGrid.Name = "tableGrid";
            tableGrid.RowHeadersWidth = 51;
            tableGrid.Size = new Size(1816, 1019);
            tableGrid.TabIndex = 6;
            // 
            // viewLabel
            // 
            viewLabel.AutoSize = true;
            viewLabel.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold);
            viewLabel.Location = new Point(26, 532);
            viewLabel.Margin = new Padding(4, 0, 4, 0);
            viewLabel.Name = "viewLabel";
            viewLabel.Size = new Size(92, 40);
            viewLabel.TabIndex = 5;
            viewLabel.Text = "VIEW";
            // 
            // tableLabel
            // 
            tableLabel.AutoSize = true;
            tableLabel.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold);
            tableLabel.Location = new Point(27, 37);
            tableLabel.Margin = new Padding(4, 0, 4, 0);
            tableLabel.Name = "tableLabel";
            tableLabel.Size = new Size(109, 40);
            tableLabel.TabIndex = 4;
            tableLabel.Text = "TABLE";
            tableLabel.Click += label1_Click;
            // 
            // DBA_TablesAndViews_UC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(viewGrid);
            Controls.Add(tableGrid);
            Controls.Add(viewLabel);
            Controls.Add(tableLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DBA_TablesAndViews_UC";
            Size = new Size(1801, 1033);
            ((System.ComponentModel.ISupportInitialize)viewGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView viewGrid;
        private DataGridView tableGrid;
        private Label viewLabel;
        private Label tableLabel;
    }
}

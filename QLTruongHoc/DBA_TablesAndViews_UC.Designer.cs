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
            viewGrid.Location = new Point(18, 353);
            viewGrid.Margin = new Padding(3, 2, 3, 2);
            viewGrid.Name = "viewGrid";
            viewGrid.RowHeadersWidth = 51;
            viewGrid.Size = new Size(992, 239);
            viewGrid.TabIndex = 7;
            // 
            // tableGrid
            // 
            tableGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableGrid.Location = new Point(18, 56);
            tableGrid.Margin = new Padding(3, 2, 3, 2);
            tableGrid.Name = "tableGrid";
            tableGrid.RowHeadersWidth = 51;
            tableGrid.Size = new Size(992, 239);
            tableGrid.TabIndex = 6;
            // 
            // viewLabel
            // 
            viewLabel.AutoSize = true;
            viewLabel.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold);
            viewLabel.Location = new Point(18, 319);
            viewLabel.Name = "viewLabel";
            viewLabel.Size = new Size(64, 27);
            viewLabel.TabIndex = 5;
            viewLabel.Text = "VIEW";
            // 
            // tableLabel
            // 
            tableLabel.AutoSize = true;
            tableLabel.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold);
            tableLabel.Location = new Point(19, 22);
            tableLabel.Name = "tableLabel";
            tableLabel.Size = new Size(73, 27);
            tableLabel.TabIndex = 4;
            tableLabel.Text = "TABLE";
            tableLabel.Click += label1_Click;
            // 
            // DBA_TablesAndViews_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(viewGrid);
            Controls.Add(tableGrid);
            Controls.Add(viewLabel);
            Controls.Add(tableLabel);
            Name = "DBA_TablesAndViews_UC";
            Size = new Size(1261, 620);
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

﻿namespace QLTruongHoc
{
    partial class TablesViewsPage
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
            label1.Location = new Point(29, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 41);
            label1.TabIndex = 0;
            label1.Text = "TABLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 507);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 41);
            label2.TabIndex = 1;
            label2.Text = "VIEW";
            // 
            // tableGrid
            // 
            tableGrid.BackgroundColor = SystemColors.Control;
            tableGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableGrid.Location = new Point(29, 82);
            tableGrid.Margin = new Padding(4, 5, 4, 5);
            tableGrid.Name = "tableGrid";
            tableGrid.RowHeadersWidth = 62;
            tableGrid.Size = new Size(1400, 393);
            tableGrid.TabIndex = 2;
            // 
            // viewGrid
            // 
            viewGrid.BackgroundColor = SystemColors.Control;
            viewGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewGrid.Location = new Point(29, 578);
            viewGrid.Margin = new Padding(4, 5, 4, 5);
            viewGrid.Name = "viewGrid";
            viewGrid.RowHeadersWidth = 62;
            viewGrid.Size = new Size(1400, 393);
            viewGrid.TabIndex = 3;
            // 
            // TablesViewsPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(viewGrid);
            Controls.Add(tableGrid);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "TablesViewsPage";
            Size = new Size(1800, 1033);
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
    }
}

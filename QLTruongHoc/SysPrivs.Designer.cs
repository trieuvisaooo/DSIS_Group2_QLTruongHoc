﻿
namespace QLTruongHoc
{
    partial class SysPrivs
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
            grantView = new DataGridView();
            label1 = new Label();
            searchTextBox = new TextBox();
            selectButton = new Button();
            grantRevokeButton = new Button();
            searchGrantee = new Button();
            ((System.ComponentModel.ISupportInitialize)grantView).BeginInit();
            SuspendLayout();
            // 
            // grantView
            // 
            grantView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grantView.Location = new Point(40, 94);
            grantView.Margin = new Padding(4, 5, 4, 5);
            grantView.Name = "grantView";
            grantView.RowHeadersWidth = 51;
            grantView.RowTemplate.Height = 24;
            grantView.Size = new Size(1491, 830);
            grantView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(40, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 1;
            label1.Text = "Search Grantee";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(194, 36);
            searchTextBox.Margin = new Padding(4, 5, 4, 5);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(200, 31);
            searchTextBox.TabIndex = 2;
            // 
            // selectButton
            // 
            selectButton.Font = new Font("Book Antiqua", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectButton.Location = new Point(1109, 27);
            selectButton.Margin = new Padding(4, 5, 4, 5);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(162, 52);
            selectButton.TabIndex = 3;
            selectButton.Text = "SELECT";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += selectButton_Click;
            // 
            // grantRevokeButton
            // 
            grantRevokeButton.Font = new Font("Book Antiqua", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grantRevokeButton.Location = new Point(1279, 27);
            grantRevokeButton.Margin = new Padding(4, 5, 4, 5);
            grantRevokeButton.Name = "grantRevokeButton";
            grantRevokeButton.Size = new Size(252, 52);
            grantRevokeButton.TabIndex = 4;
            grantRevokeButton.Text = "GRANT/REVOKE";
            grantRevokeButton.UseVisualStyleBackColor = true;
            grantRevokeButton.Click += grantRevokeButton_Click;
            // 
            // searchGrantee
            // 
            searchGrantee.BackColor = SystemColors.ActiveCaption;
            searchGrantee.Location = new Point(402, 31);
            searchGrantee.Margin = new Padding(4, 5, 4, 5);
            searchGrantee.Name = "searchGrantee";
            searchGrantee.Size = new Size(109, 41);
            searchGrantee.TabIndex = 5;
            searchGrantee.Text = "Search";
            searchGrantee.UseVisualStyleBackColor = false;
            searchGrantee.Click += searchGrantee_Click;
            // 
            // SysPrivs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(searchGrantee);
            Controls.Add(grantRevokeButton);
            Controls.Add(selectButton);
            Controls.Add(searchTextBox);
            Controls.Add(label1);
            Controls.Add(grantView);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SysPrivs";
            Padding = new Padding(4, 5, 4, 5);
            Size = new Size(1816, 1012);
            ((System.ComponentModel.ISupportInitialize)grantView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView grantView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button grantRevokeButton;
        private System.Windows.Forms.Button searchGrantee;
    }
}
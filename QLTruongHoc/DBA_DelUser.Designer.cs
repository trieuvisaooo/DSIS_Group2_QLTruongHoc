﻿namespace QLTruongHoc
{
    partial class DBA_DelUser
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
            Cancel = new Button();
            Delete = new Button();
            userbox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.IndianRed;
            Cancel.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancel.Location = new Point(494, 324);
            Cancel.Margin = new Padding(4, 4, 4, 4);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(129, 49);
            Cancel.TabIndex = 17;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            Delete.BackColor = SystemColors.ActiveCaption;
            Delete.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.Location = new Point(331, 324);
            Delete.Margin = new Padding(4, 4, 4, 4);
            Delete.Name = "Delete";
            Delete.Size = new Size(140, 49);
            Delete.TabIndex = 16;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            // 
            // userbox
            // 
            userbox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userbox.Location = new Point(376, 140);
            userbox.Margin = new Padding(4, 4, 4, 4);
            userbox.Name = "userbox";
            userbox.Size = new Size(460, 51);
            userbox.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(163, 143);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 45);
            label1.TabIndex = 12;
            label1.Text = "User:";
            // 
            // DBA_DelUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 441);
            Controls.Add(Cancel);
            Controls.Add(Delete);
            Controls.Add(userbox);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "DBA_DelUser";
            Text = "DBA_DelUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancel;
        private Button Delete;
        private TextBox userbox;
        private Label label1;
    }
}
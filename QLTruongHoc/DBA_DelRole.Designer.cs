﻿namespace QLTruongHoc
{
    partial class DBA_DelRole
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
            Role = new Label();
            SuspendLayout();
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.IndianRed;
            Cancel.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancel.Location = new Point(494, 349);
            Cancel.Margin = new Padding(4);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(129, 49);
            Cancel.TabIndex = 21;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            Delete.BackColor = SystemColors.ActiveCaption;
            Delete.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.Location = new Point(331, 349);
            Delete.Margin = new Padding(4);
            Delete.Name = "Delete";
            Delete.Size = new Size(140, 49);
            Delete.TabIndex = 20;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            // 
            // userbox
            // 
            userbox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userbox.Location = new Point(376, 165);
            userbox.Margin = new Padding(4);
            userbox.Name = "userbox";
            userbox.Size = new Size(460, 51);
            userbox.TabIndex = 19;
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Role.Location = new Point(167, 168);
            Role.Margin = new Padding(4, 0, 4, 0);
            Role.Name = "Role";
            Role.Size = new Size(91, 45);
            Role.TabIndex = 18;
            Role.Text = "Role:";
            // 
            // DBA_DelRole
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 441);
            Controls.Add(Cancel);
            Controls.Add(Delete);
            Controls.Add(userbox);
            Controls.Add(Role);
            Margin = new Padding(4);
            Name = "DBA_DelRole";
            Text = "XÓA ROLE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancel;
        private Button Delete;
        private TextBox userbox;
        private Label Role;
    }
}
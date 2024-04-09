namespace QLTruongHoc
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
            Cancel.Location = new Point(395, 279);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(103, 39);
            Cancel.TabIndex = 21;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            Delete.BackColor = SystemColors.ActiveCaption;
            Delete.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.Location = new Point(265, 279);
            Delete.Name = "Delete";
            Delete.Size = new Size(112, 39);
            Delete.TabIndex = 20;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            // 
            // userbox
            // 
            userbox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userbox.Location = new Point(301, 132);
            userbox.Name = "userbox";
            userbox.Size = new Size(369, 43);
            userbox.TabIndex = 19;
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Role.Location = new Point(130, 132);
            Role.Name = "Role";
            Role.Size = new Size(81, 39);
            Role.TabIndex = 18;
            Role.Text = "Role:";
            // 
            // DBA_DelRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 353);
            Controls.Add(Cancel);
            Controls.Add(Delete);
            Controls.Add(userbox);
            Controls.Add(Role);
            Name = "DBA_DelRole";
            Text = "DBA_DelRole";
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
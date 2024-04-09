namespace QLTruongHoc
{
    partial class DBA_UpdateRole
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
            button1 = new Button();
            Update = new Button();
            passbox = new TextBox();
            rolebox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(470, 250);
            button1.Name = "button1";
            button1.Size = new Size(103, 39);
            button1.TabIndex = 11;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            // 
            // Update
            // 
            Update.BackColor = SystemColors.ActiveCaption;
            Update.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update.Location = new Point(338, 250);
            Update.Name = "Update";
            Update.Size = new Size(112, 39);
            Update.TabIndex = 10;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            // 
            // passbox
            // 
            passbox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passbox.Location = new Point(292, 163);
            passbox.Name = "passbox";
            passbox.Size = new Size(369, 43);
            passbox.TabIndex = 9;
            // 
            // rolebox
            // 
            rolebox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rolebox.Location = new Point(292, 63);
            rolebox.Name = "rolebox";
            rolebox.Size = new Size(369, 43);
            rolebox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(121, 163);
            label2.Name = "label2";
            label2.Size = new Size(149, 39);
            label2.TabIndex = 7;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(121, 63);
            label1.Name = "label1";
            label1.Size = new Size(81, 39);
            label1.TabIndex = 6;
            label1.Text = "Role:";
            // 
            // DBA_UpdateRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 353);
            Controls.Add(button1);
            Controls.Add(Update);
            Controls.Add(passbox);
            Controls.Add(rolebox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DBA_UpdateRole";
            Text = "DBA_UpdateRole";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button Update;
        private TextBox passbox;
        private TextBox rolebox;
        private Label label2;
        private Label label1;
    }
}
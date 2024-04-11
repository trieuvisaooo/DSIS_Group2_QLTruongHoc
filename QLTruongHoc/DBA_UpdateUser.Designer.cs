namespace QLTruongHoc
{
    partial class DBA_UpdateUser
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
            button1.Location = new Point(551, 340);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(129, 49);
            button1.TabIndex = 17;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            // 
            // Update
            // 
            Update.BackColor = SystemColors.ActiveCaption;
            Update.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update.Location = new Point(386, 340);
            Update.Margin = new Padding(4);
            Update.Name = "Update";
            Update.Size = new Size(140, 49);
            Update.TabIndex = 16;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            // 
            // passbox
            // 
            passbox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passbox.Location = new Point(329, 231);
            passbox.Margin = new Padding(4);
            passbox.Name = "passbox";
            passbox.Size = new Size(460, 51);
            passbox.TabIndex = 15;
            // 
            // rolebox
            // 
            rolebox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rolebox.Location = new Point(329, 106);
            rolebox.Margin = new Padding(4);
            rolebox.Name = "rolebox";
            rolebox.Size = new Size(460, 51);
            rolebox.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(115, 234);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(165, 45);
            label2.TabIndex = 13;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(115, 109);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 45);
            label1.TabIndex = 12;
            label1.Text = "User:";
            // 
            // DBA_UpdateUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 441);
            Controls.Add(button1);
            Controls.Add(Update);
            Controls.Add(passbox);
            Controls.Add(rolebox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "DBA_UpdateUser";
            Text = "CẬP NHẬT MẬT KHẨU CHO USER";
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
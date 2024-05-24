namespace QLTruongHoc
{
    partial class UpdateUser
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
            confirm_psw_txtbox = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(494, 340);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(129, 48);
            button1.TabIndex = 17;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Update
            // 
            Update.BackColor = SystemColors.ActiveCaption;
            Update.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update.Location = new Point(329, 340);
            Update.Margin = new Padding(4, 3, 4, 3);
            Update.Name = "Update";
            Update.Size = new Size(140, 48);
            Update.TabIndex = 16;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // passbox
            // 
            passbox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passbox.Location = new Point(329, 167);
            passbox.Margin = new Padding(4, 3, 4, 3);
            passbox.Name = "passbox";
            passbox.Size = new Size(460, 51);
            passbox.TabIndex = 15;
            passbox.UseSystemPasswordChar = true;
            // 
            // rolebox
            // 
            rolebox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rolebox.Location = new Point(329, 59);
            rolebox.Margin = new Padding(4, 3, 4, 3);
            rolebox.Name = "rolebox";
            rolebox.Size = new Size(460, 51);
            rolebox.TabIndex = 14;
            rolebox.TextChanged += rolebox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(59, 175);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(214, 38);
            label2.TabIndex = 13;
            label2.Text = "New Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(59, 67);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 38);
            label1.TabIndex = 12;
            label1.Text = "User:";
            // 
            // confirm_psw_txtbox
            // 
            confirm_psw_txtbox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirm_psw_txtbox.Location = new Point(329, 264);
            confirm_psw_txtbox.Margin = new Padding(4, 3, 4, 3);
            confirm_psw_txtbox.Name = "confirm_psw_txtbox";
            confirm_psw_txtbox.Size = new Size(460, 51);
            confirm_psw_txtbox.TabIndex = 19;
            confirm_psw_txtbox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(59, 272);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(262, 38);
            label3.TabIndex = 18;
            label3.Text = "Confirm Password:";
            // 
            // DBA_UpdateUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 442);
            Controls.Add(confirm_psw_txtbox);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(Update);
            Controls.Add(passbox);
            Controls.Add(rolebox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
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
        private TextBox confirm_psw_txtbox;
        private Label label3;
    }
}
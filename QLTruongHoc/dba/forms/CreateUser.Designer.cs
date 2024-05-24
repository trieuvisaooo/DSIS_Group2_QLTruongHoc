namespace QLTruongHoc
{
    partial class CreateUser
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
            Submit = new Button();
            passbox = new TextBox();
            userbox = new TextBox();
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
            button1.Location = new Point(534, 338);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(129, 48);
            button1.TabIndex = 11;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Submit
            // 
            Submit.BackColor = SystemColors.ActiveCaption;
            Submit.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Submit.Location = new Point(371, 338);
            Submit.Margin = new Padding(4, 3, 4, 3);
            Submit.Name = "Submit";
            Submit.Size = new Size(140, 48);
            Submit.TabIndex = 10;
            Submit.Text = "Apply";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // passbox
            // 
            passbox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passbox.Location = new Point(304, 159);
            passbox.Margin = new Padding(4, 3, 4, 3);
            passbox.Name = "passbox";
            passbox.Size = new Size(460, 51);
            passbox.TabIndex = 9;
            passbox.UseSystemPasswordChar = true;
            // 
            // userbox
            // 
            userbox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userbox.Location = new Point(304, 50);
            userbox.Margin = new Padding(4, 3, 4, 3);
            userbox.Name = "userbox";
            userbox.Size = new Size(460, 51);
            userbox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(34, 167);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 38);
            label2.TabIndex = 7;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(34, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 38);
            label1.TabIndex = 6;
            label1.Text = "User:";
            // 
            // confirm_psw_txtbox
            // 
            confirm_psw_txtbox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirm_psw_txtbox.Location = new Point(304, 253);
            confirm_psw_txtbox.Margin = new Padding(4, 3, 4, 3);
            confirm_psw_txtbox.Name = "confirm_psw_txtbox";
            confirm_psw_txtbox.Size = new Size(460, 51);
            confirm_psw_txtbox.TabIndex = 13;
            confirm_psw_txtbox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(34, 261);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(262, 38);
            label3.TabIndex = 12;
            label3.Text = "Confirm Password:";
            // 
            // DBA_CreateUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 442);
            Controls.Add(confirm_psw_txtbox);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(Submit);
            Controls.Add(passbox);
            Controls.Add(userbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DBA_CreateUser";
            Text = "TẠO MỚI USER";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button Submit;
        private TextBox passbox;
        private TextBox userbox;
        private Label label2;
        private Label label1;
        private TextBox confirm_psw_txtbox;
        private Label label3;
    }
}
namespace QLTruongHoc
{
    partial class DBA_CreateUser
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(374, 203);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(90, 29);
            button1.TabIndex = 11;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            // 
            // Submit
            // 
            Submit.BackColor = SystemColors.ActiveCaption;
            Submit.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Submit.Location = new Point(260, 203);
            Submit.Margin = new Padding(3, 2, 3, 2);
            Submit.Name = "Submit";
            Submit.Size = new Size(98, 29);
            Submit.TabIndex = 10;
            Submit.Text = "Apply";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // passbox
            // 
            passbox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passbox.Location = new Point(220, 138);
            passbox.Margin = new Padding(3, 2, 3, 2);
            passbox.Name = "passbox";
            passbox.Size = new Size(323, 36);
            passbox.TabIndex = 9;
            // 
            // userbox
            // 
            userbox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userbox.Location = new Point(220, 63);
            userbox.Margin = new Padding(3, 2, 3, 2);
            userbox.Name = "userbox";
            userbox.Size = new Size(323, 36);
            userbox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(71, 140);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 7;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(71, 65);
            label1.Name = "label1";
            label1.Size = new Size(63, 30);
            label1.TabIndex = 6;
            label1.Text = "User:";
            // 
            // DBA_CreateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 265);
            Controls.Add(button1);
            Controls.Add(Submit);
            Controls.Add(passbox);
            Controls.Add(userbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}
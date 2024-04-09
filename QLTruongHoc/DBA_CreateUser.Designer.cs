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
            button1.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(428, 271);
            button1.Name = "button1";
            button1.Size = new Size(103, 39);
            button1.TabIndex = 11;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            // 
            // Submit
            // 
            Submit.BackColor = SystemColors.ActiveCaption;
            Submit.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Submit.Location = new Point(298, 271);
            Submit.Name = "Submit";
            Submit.Size = new Size(112, 39);
            Submit.TabIndex = 10;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            // 
            // passbox
            // 
            passbox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passbox.Location = new Point(252, 184);
            passbox.Name = "passbox";
            passbox.Size = new Size(369, 43);
            passbox.TabIndex = 9;
            // 
            // userbox
            // 
            userbox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userbox.Location = new Point(252, 84);
            userbox.Name = "userbox";
            userbox.Size = new Size(369, 43);
            userbox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 184);
            label2.Name = "label2";
            label2.Size = new Size(149, 39);
            label2.TabIndex = 7;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 84);
            label1.Name = "label1";
            label1.Size = new Size(85, 39);
            label1.TabIndex = 6;
            label1.Text = "User:";
            // 
            // DBA_CreateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 353);
            Controls.Add(button1);
            Controls.Add(Submit);
            Controls.Add(passbox);
            Controls.Add(userbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DBA_CreateUser";
            Text = "DBA_CreateUser";
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
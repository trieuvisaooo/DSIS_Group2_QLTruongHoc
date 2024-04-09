namespace QLTruongHoc
{
    partial class DBA_CreateRole
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
            label1 = new Label();
            label2 = new Label();
            rolebox = new TextBox();
            passbox = new TextBox();
            Submit = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 78);
            label1.Name = "label1";
            label1.Size = new Size(81, 39);
            label1.TabIndex = 0;
            label1.Text = "Role:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(87, 178);
            label2.Name = "label2";
            label2.Size = new Size(149, 39);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // rolebox
            // 
            rolebox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rolebox.Location = new Point(258, 78);
            rolebox.Name = "rolebox";
            rolebox.Size = new Size(369, 43);
            rolebox.TabIndex = 2;
            rolebox.TextChanged += rolebox_TextChanged;
            // 
            // passbox
            // 
            passbox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passbox.Location = new Point(258, 178);
            passbox.Name = "passbox";
            passbox.Size = new Size(369, 43);
            passbox.TabIndex = 3;
            // 
            // Submit
            // 
            Submit.BackColor = SystemColors.ActiveCaption;
            Submit.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Submit.Location = new Point(304, 265);
            Submit.Name = "Submit";
            Submit.Size = new Size(112, 39);
            Submit.TabIndex = 4;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(436, 265);
            button1.Name = "button1";
            button1.Size = new Size(103, 39);
            button1.TabIndex = 5;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            // 
            // DBA_CreateRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 353);
            Controls.Add(button1);
            Controls.Add(Submit);
            Controls.Add(passbox);
            Controls.Add(rolebox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DBA_CreateRole";
            Text = "DBA_CreateRole";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox rolebox;
        private TextBox passbox;
        private Button Submit;
        private Button button1;
    }
}
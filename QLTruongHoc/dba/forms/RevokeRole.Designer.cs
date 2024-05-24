namespace QLTruongHoc
{
    partial class RevokeRole
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
            userRoleBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            roleBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(590, 315);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(129, 67);
            button1.TabIndex = 11;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Submit
            // 
            Submit.BackColor = SystemColors.ActiveCaption;
            Submit.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Submit.Location = new Point(424, 315);
            Submit.Margin = new Padding(4, 3, 4, 3);
            Submit.Name = "Submit";
            Submit.Size = new Size(140, 67);
            Submit.TabIndex = 10;
            Submit.Text = "Revoke";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // userRoleBox
            // 
            userRoleBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userRoleBox.Location = new Point(424, 90);
            userRoleBox.Margin = new Padding(4, 3, 4, 3);
            userRoleBox.Name = "userRoleBox";
            userRoleBox.Size = new Size(460, 51);
            userRoleBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(134, 225);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(259, 38);
            label2.TabIndex = 7;
            label2.Text = "Role muốn thu hồi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(97, 102);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(298, 38);
            label1.TabIndex = 6;
            label1.Text = "User/Role cần thu hồi:";
            label1.Click += label1_Click;
            // 
            // roleBox
            // 
            roleBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roleBox.Location = new Point(424, 213);
            roleBox.Margin = new Padding(4, 3, 4, 3);
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(460, 51);
            roleBox.TabIndex = 9;
            // 
            // RevokeRole
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 460);
            Controls.Add(button1);
            Controls.Add(Submit);
            Controls.Add(roleBox);
            Controls.Add(userRoleBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "RevokeRole";
            Text = "RevokeRole";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button Submit;
        private TextBox userRoleBox;
        private Label label2;
        private Label label1;
        private TextBox roleBox;
    }
}
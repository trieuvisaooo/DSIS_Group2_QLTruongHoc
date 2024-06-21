namespace QLTruongHoc.others
{
    partial class ConfigForm
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
            HostnameTxtBox = new TextBox();
            PortTxtBox = new TextBox();
            SaveBtn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(74, 125);
            label1.Name = "label1";
            label1.Size = new Size(149, 38);
            label1.TabIndex = 0;
            label1.Text = "Hostname:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(74, 223);
            label2.Name = "label2";
            label2.Size = new Size(73, 38);
            label2.TabIndex = 1;
            label2.Text = "Port:";
            // 
            // HostnameTxtBox
            // 
            HostnameTxtBox.Location = new Point(278, 133);
            HostnameTxtBox.Name = "HostnameTxtBox";
            HostnameTxtBox.Size = new Size(308, 31);
            HostnameTxtBox.TabIndex = 2;
            // 
            // PortTxtBox
            // 
            PortTxtBox.Location = new Point(278, 231);
            PortTxtBox.Name = "PortTxtBox";
            PortTxtBox.Size = new Size(308, 31);
            PortTxtBox.TabIndex = 3;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.MediumSeaGreen;
            SaveBtn.Location = new Point(278, 298);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(121, 47);
            SaveBtn.TabIndex = 4;
            SaveBtn.Text = "Lưu";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(74, 32);
            label3.Name = "label3";
            label3.Size = new Size(563, 45);
            label3.TabIndex = 5;
            label3.Text = "ORACLE DATABASE CONFIGURATION";
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 368);
            Controls.Add(label3);
            Controls.Add(SaveBtn);
            Controls.Add(PortTxtBox);
            Controls.Add(HostnameTxtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfigForm";
            Text = "Cấu Hình Database";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox HostnameTxtBox;
        private TextBox PortTxtBox;
        private Button SaveBtn;
        private Label label3;
    }
}
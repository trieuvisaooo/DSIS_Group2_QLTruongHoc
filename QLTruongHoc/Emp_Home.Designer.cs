namespace QLTruongHoc
{
    partial class Emp_Home
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
            tabControl1 = new TabControl();
            NhanSuTab = new TabPage();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(NhanSuTab);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 3);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1652, 1037);
            tabControl1.TabIndex = 0;
            // 
            // NhanSuTab
            // 
            NhanSuTab.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NhanSuTab.Location = new Point(4, 32);
            NhanSuTab.Margin = new Padding(4, 5, 4, 5);
            NhanSuTab.Name = "NhanSuTab";
            NhanSuTab.Padding = new Padding(4, 5, 4, 5);
            NhanSuTab.Size = new Size(1644, 1001);
            NhanSuTab.TabIndex = 0;
            NhanSuTab.Text = "Nhân Sự";
            NhanSuTab.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 5, 4, 5);
            tabPage2.Size = new Size(1644, 1009);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Emp_Home
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1655, 842);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Emp_Home";
            Text = "Emp_Home";
            WindowState = FormWindowState.Maximized;
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage NhanSuTab;
        private TabPage tabPage2;
    }
}
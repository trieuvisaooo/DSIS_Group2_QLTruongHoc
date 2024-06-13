namespace QLTruongHoc.sinh_vien
{
    partial class StuHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuHome));
            tabControl1 = new TabControl();
            TTCNTabPage = new TabPage();
            hocPhanTabpage = new TabPage();
            hocPhanTab1 = new nhan_su.uc.HocPhanTab();
            khmoTabpage = new TabPage();
            khmoTab1 = new nhan_su.uc.KhmoTab();
            dangKyTabPage = new TabPage();
            dangKyTab1 = new nhan_su.uc.DangKyTab();
            donViTabpage = new TabPage();
            donViTab1 = new nhan_su.uc.DonViTab();
            ttcnsvTab1 = new uc.TTCNSVTab();
            tabControl1.SuspendLayout();
            TTCNTabPage.SuspendLayout();
            hocPhanTabpage.SuspendLayout();
            khmoTabpage.SuspendLayout();
            dangKyTabPage.SuspendLayout();
            donViTabpage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(TTCNTabPage);
            tabControl1.Controls.Add(hocPhanTabpage);
            tabControl1.Controls.Add(khmoTabpage);
            tabControl1.Controls.Add(dangKyTabPage);
            tabControl1.Controls.Add(donViTabpage);
            tabControl1.Location = new Point(4, 0);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1803, 1024);
            tabControl1.TabIndex = 1;
            // 
            // TTCNTabPage
            // 
            TTCNTabPage.Controls.Add(ttcnsvTab1);
            TTCNTabPage.Location = new Point(4, 34);
            TTCNTabPage.Margin = new Padding(4, 5, 4, 5);
            TTCNTabPage.Name = "TTCNTabPage";
            TTCNTabPage.Padding = new Padding(4, 5, 4, 5);
            TTCNTabPage.Size = new Size(1795, 986);
            TTCNTabPage.TabIndex = 0;
            TTCNTabPage.Text = "Thông Tin Cá Nhân";
            TTCNTabPage.UseVisualStyleBackColor = true;
            // 
            // hocPhanTabpage
            // 
            hocPhanTabpage.Controls.Add(hocPhanTab1);
            hocPhanTabpage.Location = new Point(4, 34);
            hocPhanTabpage.Margin = new Padding(4);
            hocPhanTabpage.Name = "hocPhanTabpage";
            hocPhanTabpage.Padding = new Padding(4);
            hocPhanTabpage.Size = new Size(1795, 986);
            hocPhanTabpage.TabIndex = 2;
            hocPhanTabpage.Text = "Học Phần";
            hocPhanTabpage.UseVisualStyleBackColor = true;
            // 
            // hocPhanTab1
            // 
            hocPhanTab1.Dock = DockStyle.Fill;
            hocPhanTab1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hocPhanTab1.Location = new Point(4, 4);
            hocPhanTab1.Margin = new Padding(5, 5, 5, 5);
            hocPhanTab1.MinimumSize = new Size(1790, 1250);
            hocPhanTab1.Name = "hocPhanTab1";
            hocPhanTab1.Size = new Size(1790, 1250);
            hocPhanTab1.TabIndex = 0;
            // 
            // khmoTabpage
            // 
            khmoTabpage.Controls.Add(khmoTab1);
            khmoTabpage.Location = new Point(4, 34);
            khmoTabpage.Margin = new Padding(4);
            khmoTabpage.Name = "khmoTabpage";
            khmoTabpage.Padding = new Padding(4);
            khmoTabpage.Size = new Size(1795, 986);
            khmoTabpage.TabIndex = 3;
            khmoTabpage.Text = "Kế Hoạch Mở";
            khmoTabpage.UseVisualStyleBackColor = true;
            // 
            // khmoTab1
            // 
            khmoTab1.Dock = DockStyle.Fill;
            khmoTab1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            khmoTab1.Location = new Point(4, 4);
            khmoTab1.Margin = new Padding(5, 5, 5, 5);
            khmoTab1.MinimumSize = new Size(1790, 1000);
            khmoTab1.Name = "khmoTab1";
            khmoTab1.Size = new Size(1790, 1000);
            khmoTab1.TabIndex = 0;
            // 
            // dangKyTabPage
            // 
            dangKyTabPage.Controls.Add(dangKyTab1);
            dangKyTabPage.Location = new Point(4, 34);
            dangKyTabPage.Margin = new Padding(4);
            dangKyTabPage.Name = "dangKyTabPage";
            dangKyTabPage.Padding = new Padding(4);
            dangKyTabPage.Size = new Size(1795, 986);
            dangKyTabPage.TabIndex = 5;
            dangKyTabPage.Text = "Lớp Học";
            dangKyTabPage.UseVisualStyleBackColor = true;
            // 
            // dangKyTab1
            // 
            dangKyTab1.Dock = DockStyle.Fill;
            dangKyTab1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dangKyTab1.Location = new Point(4, 4);
            dangKyTab1.Margin = new Padding(5, 5, 5, 5);
            dangKyTab1.MinimumSize = new Size(1790, 1000);
            dangKyTab1.Name = "dangKyTab1";
            dangKyTab1.Size = new Size(1790, 1000);
            dangKyTab1.TabIndex = 0;
            // 
            // donViTabpage
            // 
            donViTabpage.Controls.Add(donViTab1);
            donViTabpage.Location = new Point(4, 34);
            donViTabpage.Margin = new Padding(4, 5, 4, 5);
            donViTabpage.Name = "donViTabpage";
            donViTabpage.Padding = new Padding(4, 5, 4, 5);
            donViTabpage.Size = new Size(1795, 986);
            donViTabpage.TabIndex = 1;
            donViTabpage.Text = "Đơn Vị";
            donViTabpage.UseVisualStyleBackColor = true;
            // 
            // donViTab1
            // 
            donViTab1.Dock = DockStyle.Fill;
            donViTab1.Location = new Point(4, 5);
            donViTab1.Margin = new Padding(5);
            donViTab1.MinimumSize = new Size(1790, 1000);
            donViTab1.Name = "donViTab1";
            donViTab1.Size = new Size(1790, 1000);
            donViTab1.TabIndex = 0;
            // 
            // ttcnsvTab1
            // 
            ttcnsvTab1.Location = new Point(-4, 0);
            ttcnsvTab1.Name = "ttcnsvTab1";
            ttcnsvTab1.Size = new Size(1799, 986);
            ttcnsvTab1.TabIndex = 0;
            // 
            // StuHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1808, 1050);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1824, 1006);
            Name = "StuHome";
            Text = "QUẢN LÝ TRƯỜNG HỌC";
            tabControl1.ResumeLayout(false);
            TTCNTabPage.ResumeLayout(false);
            hocPhanTabpage.ResumeLayout(false);
            khmoTabpage.ResumeLayout(false);
            dangKyTabPage.ResumeLayout(false);
            donViTabpage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TTCNTabPage;
        private TabPage donViTabpage;
        private nhan_su.uc.DonViTab donViTab1;
        private TabPage hocPhanTabpage;
        private nhan_su.uc.HocPhanTab hocPhanTab1;
        private TabPage khmoTabpage;
        private nhan_su.uc.KhmoTab khmoTab1;
        private TabPage dangKyTabPage;
        private nhan_su.uc.DangKyTab dangKyTab1;
        private uc.TTCNSVTab ttcnsvTab1;
    }
}
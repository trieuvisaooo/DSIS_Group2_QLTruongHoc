namespace QLTruongHoc.nhan_su
{
    partial class EmpHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpHome));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            nhanSuTab1 = new NhanSu.NhanSuTab();
            donViTabpage = new TabPage();
            donViTab1 = new uc.DonViTab();
            hocPhanTabpage = new TabPage();
            hocPhanTab1 = new uc.HocPhanTab();
            khmoTabpage = new TabPage();
            khmoTab1 = new uc.KhmoTab();
            phanCongTab = new TabPage();
            phanCongTab1 = new uc.PhanCongTab();
            dangKyTabPage = new TabPage();
            dangKyTab1 = new uc.DangKyTab();
            sinhVienTab = new TabPage();
            sinhVienTab1 = new uc.SinhVienTab();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            donViTabpage.SuspendLayout();
            hocPhanTabpage.SuspendLayout();
            khmoTabpage.SuspendLayout();
            phanCongTab.SuspendLayout();
            dangKyTabPage.SuspendLayout();
            sinhVienTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(donViTabpage);
            tabControl1.Controls.Add(hocPhanTabpage);
            tabControl1.Controls.Add(khmoTabpage);
            tabControl1.Controls.Add(phanCongTab);
            tabControl1.Controls.Add(dangKyTabPage);
            tabControl1.Controls.Add(sinhVienTab);
            tabControl1.Location = new Point(2, 1);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1443, 791);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(nhanSuTab1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1435, 758);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Nhân Sự";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // nhanSuTab1
            // 
            nhanSuTab1.Dock = DockStyle.Fill;
            nhanSuTab1.Location = new Point(3, 4);
            nhanSuTab1.Margin = new Padding(3, 4, 3, 4);
            nhanSuTab1.MinimumSize = new Size(1443, 800);
            nhanSuTab1.Name = "nhanSuTab1";
            nhanSuTab1.Size = new Size(1443, 800);
            nhanSuTab1.TabIndex = 0;
            // 
            // donViTabpage
            // 
            donViTabpage.Controls.Add(donViTab1);
            donViTabpage.Location = new Point(4, 29);
            donViTabpage.Margin = new Padding(3, 4, 3, 4);
            donViTabpage.Name = "donViTabpage";
            donViTabpage.Padding = new Padding(3, 4, 3, 4);
            donViTabpage.Size = new Size(1435, 758);
            donViTabpage.TabIndex = 1;
            donViTabpage.Text = "Đơn Vị";
            donViTabpage.UseVisualStyleBackColor = true;
            // 
            // donViTab1
            // 
            donViTab1.Dock = DockStyle.Fill;
            donViTab1.Location = new Point(3, 4);
            donViTab1.Margin = new Padding(4);
            donViTab1.MinimumSize = new Size(1432, 800);
            donViTab1.Name = "donViTab1";
            donViTab1.Size = new Size(1432, 800);
            donViTab1.TabIndex = 0;
            // 
            // hocPhanTabpage
            // 
            hocPhanTabpage.Controls.Add(hocPhanTab1);
            hocPhanTabpage.Location = new Point(4, 29);
            hocPhanTabpage.Name = "hocPhanTabpage";
            hocPhanTabpage.Padding = new Padding(3);
            hocPhanTabpage.Size = new Size(1435, 758);
            hocPhanTabpage.TabIndex = 2;
            hocPhanTabpage.Text = "Học Phần";
            hocPhanTabpage.UseVisualStyleBackColor = true;
            // 
            // hocPhanTab1
            // 
            hocPhanTab1.Dock = DockStyle.Fill;
            hocPhanTab1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hocPhanTab1.Location = new Point(3, 3);
            hocPhanTab1.Margin = new Padding(4);
            hocPhanTab1.MinimumSize = new Size(1432, 1000);
            hocPhanTab1.Name = "hocPhanTab1";
            hocPhanTab1.Size = new Size(1432, 1000);
            hocPhanTab1.TabIndex = 0;
            // 
            // khmoTabpage
            // 
            khmoTabpage.Controls.Add(khmoTab1);
            khmoTabpage.Location = new Point(4, 29);
            khmoTabpage.Name = "khmoTabpage";
            khmoTabpage.Padding = new Padding(3);
            khmoTabpage.Size = new Size(1435, 758);
            khmoTabpage.TabIndex = 3;
            khmoTabpage.Text = "Kế Hoạch Mở";
            khmoTabpage.UseVisualStyleBackColor = true;
            // 
            // khmoTab1
            // 
            khmoTab1.Dock = DockStyle.Fill;
            khmoTab1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            khmoTab1.Location = new Point(3, 3);
            khmoTab1.Margin = new Padding(4);
            khmoTab1.MinimumSize = new Size(1432, 800);
            khmoTab1.Name = "khmoTab1";
            khmoTab1.Size = new Size(1432, 800);
            khmoTab1.TabIndex = 0;
            // 
            // phanCongTab
            // 
            phanCongTab.Controls.Add(phanCongTab1);
            phanCongTab.Location = new Point(4, 29);
            phanCongTab.Name = "phanCongTab";
            phanCongTab.Padding = new Padding(3);
            phanCongTab.Size = new Size(1435, 758);
            phanCongTab.TabIndex = 4;
            phanCongTab.Text = "Phân Công";
            phanCongTab.UseVisualStyleBackColor = true;
            // 
            // phanCongTab1
            // 
            phanCongTab1.Dock = DockStyle.Fill;
            phanCongTab1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phanCongTab1.Location = new Point(3, 3);
            phanCongTab1.Margin = new Padding(4);
            phanCongTab1.MinimumSize = new Size(1432, 800);
            phanCongTab1.Name = "phanCongTab1";
            phanCongTab1.Size = new Size(1432, 800);
            phanCongTab1.TabIndex = 0;
            // 
            // dangKyTabPage
            // 
            dangKyTabPage.Controls.Add(dangKyTab1);
            dangKyTabPage.Location = new Point(4, 29);
            dangKyTabPage.Name = "dangKyTabPage";
            dangKyTabPage.Padding = new Padding(3);
            dangKyTabPage.Size = new Size(1435, 758);
            dangKyTabPage.TabIndex = 5;
            dangKyTabPage.Text = "Lớp Học";
            dangKyTabPage.UseVisualStyleBackColor = true;
            // 
            // dangKyTab1
            // 
            dangKyTab1.Dock = DockStyle.Fill;
            dangKyTab1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dangKyTab1.Location = new Point(3, 3);
            dangKyTab1.Margin = new Padding(4);
            dangKyTab1.MinimumSize = new Size(1432, 800);
            dangKyTab1.Name = "dangKyTab1";
            dangKyTab1.Size = new Size(1432, 800);
            dangKyTab1.TabIndex = 0;
            // 
            // sinhVienTab
            // 
            sinhVienTab.Controls.Add(sinhVienTab1);
            sinhVienTab.Location = new Point(4, 29);
            sinhVienTab.Name = "sinhVienTab";
            sinhVienTab.Padding = new Padding(3);
            sinhVienTab.Size = new Size(1435, 758);
            sinhVienTab.TabIndex = 6;
            sinhVienTab.Text = "Sinh Viên";
            sinhVienTab.UseVisualStyleBackColor = true;
            // 
            // sinhVienTab1
            // 
            sinhVienTab1.Dock = DockStyle.Fill;
            sinhVienTab1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sinhVienTab1.Location = new Point(3, 3);
            sinhVienTab1.Margin = new Padding(4);
            sinhVienTab1.MinimumSize = new Size(1432, 800);
            sinhVienTab1.Name = "sinhVienTab1";
            sinhVienTab1.Size = new Size(1432, 800);
            sinhVienTab1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(1344, 951);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(96, 47);
            button1.TabIndex = 2;
            button1.Text = "Sign Out";
            button1.UseVisualStyleBackColor = false;
            // 
            // EmpHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 840);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1463, 814);
            Name = "EmpHome";
            Text = "QUẢN LÝ TRƯỜNG HỌC";
            FormClosed += EmpHome_FormClosed;
            Load += EmpHome_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            donViTabpage.ResumeLayout(false);
            hocPhanTabpage.ResumeLayout(false);
            khmoTabpage.ResumeLayout(false);
            phanCongTab.ResumeLayout(false);
            dangKyTabPage.ResumeLayout(false);
            sinhVienTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage donViTabpage;
        private Button button1;
        private NhanSu.NhanSuTab nhanSuTab1;
        private uc.DonViTab donViTab1;
        private TabPage hocPhanTabpage;
        private uc.HocPhanTab hocPhanTab1;
        private TabPage khmoTabpage;
        private uc.KhmoTab khmoTab1;
        private TabPage phanCongTab;
        private TabPage dangKyTabPage;
        private uc.DangKyTab dangKyTab1;
        private TabPage sinhVienTab;
        private uc.SinhVienTab sinhVienTab1;
        private uc.PhanCongTab phanCongTab1;
    }
}
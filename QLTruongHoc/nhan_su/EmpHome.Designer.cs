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
            NhanSuTabControl = new TabControl();
            TTCNTabpage = new TabPage();
            emp_ttcnTab1 = new uc.Emp_TTCNTab();
            nhanSuTabpage = new TabPage();
            nhanSuTab1 = new uc.Emp_NhanSuTab();
            donViTabpage = new TabPage();
            donViTab1 = new uc.Emp_DonViTab();
            hocPhanTabpage = new TabPage();
            hocPhanTab1 = new uc.Emp_HocPhanTab();
            khmoTabpage = new TabPage();
            khmoTab1 = new uc.Emp_KhmoTab();
            phanCongTab = new TabPage();
            phanCongTab1 = new uc.Emp_PhanCongTab();
            dangKyTabPage = new TabPage();
            dangKyTab1 = new uc.Emp_DangKyTab();
            sinhVienTab = new TabPage();
            sinhVienTab1 = new uc.Emp_SinhVienTab();
            xemCSDLTabpage = new TabPage();
            emp_XemqlthTab1 = new uc.Emp_XemQLTHTab();
            thongBaoTabpage = new TabPage();
            emp_ThongBaoTab1 = new uc.Emp_ThongBaoTab();
            button1 = new Button();
            LogoutBtn = new Button();
            NhanSuTabControl.SuspendLayout();
            TTCNTabpage.SuspendLayout();
            nhanSuTabpage.SuspendLayout();
            donViTabpage.SuspendLayout();
            hocPhanTabpage.SuspendLayout();
            khmoTabpage.SuspendLayout();
            phanCongTab.SuspendLayout();
            dangKyTabPage.SuspendLayout();
            sinhVienTab.SuspendLayout();
            xemCSDLTabpage.SuspendLayout();
            thongBaoTabpage.SuspendLayout();
            SuspendLayout();
            // 
            // NhanSuTabControl
            // 
            NhanSuTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NhanSuTabControl.Controls.Add(TTCNTabpage);
            NhanSuTabControl.Controls.Add(nhanSuTabpage);
            NhanSuTabControl.Controls.Add(donViTabpage);
            NhanSuTabControl.Controls.Add(hocPhanTabpage);
            NhanSuTabControl.Controls.Add(khmoTabpage);
            NhanSuTabControl.Controls.Add(phanCongTab);
            NhanSuTabControl.Controls.Add(dangKyTabPage);
            NhanSuTabControl.Controls.Add(sinhVienTab);
            NhanSuTabControl.Controls.Add(thongBaoTabpage);
            NhanSuTabControl.Controls.Add(xemCSDLTabpage);
            NhanSuTabControl.Location = new Point(2, 1);
            NhanSuTabControl.Margin = new Padding(4, 5, 4, 5);
            NhanSuTabControl.Name = "NhanSuTabControl";
            NhanSuTabControl.SelectedIndex = 0;
            NhanSuTabControl.Size = new Size(1804, 979);
            NhanSuTabControl.TabIndex = 0;
            // 
            // TTCNTabpage
            // 
            TTCNTabpage.Controls.Add(emp_ttcnTab1);
            TTCNTabpage.Location = new Point(4, 34);
            TTCNTabpage.Name = "TTCNTabpage";
            TTCNTabpage.Size = new Size(1796, 941);
            TTCNTabpage.TabIndex = 7;
            TTCNTabpage.Text = "Thông Tin Cá Nhân";
            TTCNTabpage.UseVisualStyleBackColor = true;
            // 
            // emp_ttcnTab1
            // 
            emp_ttcnTab1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            emp_ttcnTab1.Location = new Point(198, 0);
            emp_ttcnTab1.MinimumSize = new Size(1432, 800);
            emp_ttcnTab1.Name = "emp_ttcnTab1";
            emp_ttcnTab1.Size = new Size(1432, 938);
            emp_ttcnTab1.TabIndex = 0;
            // 
            // nhanSuTabpage
            // 
            nhanSuTabpage.Controls.Add(nhanSuTab1);
            nhanSuTabpage.Location = new Point(4, 34);
            nhanSuTabpage.Margin = new Padding(4, 5, 4, 5);
            nhanSuTabpage.Name = "nhanSuTabpage";
            nhanSuTabpage.Padding = new Padding(4, 5, 4, 5);
            nhanSuTabpage.Size = new Size(1796, 941);
            nhanSuTabpage.TabIndex = 0;
            nhanSuTabpage.Text = "Nhân Sự";
            nhanSuTabpage.UseVisualStyleBackColor = true;
            // 
            // nhanSuTab1
            // 
            nhanSuTab1.Dock = DockStyle.Fill;
            nhanSuTab1.Location = new Point(4, 5);
            nhanSuTab1.Margin = new Padding(4, 5, 4, 5);
            nhanSuTab1.MinimumSize = new Size(1787, 845);
            nhanSuTab1.Name = "nhanSuTab1";
            nhanSuTab1.Size = new Size(1788, 931);
            nhanSuTab1.TabIndex = 0;
            // 
            // donViTabpage
            // 
            donViTabpage.Controls.Add(donViTab1);
            donViTabpage.Location = new Point(4, 34);
            donViTabpage.Margin = new Padding(4, 5, 4, 5);
            donViTabpage.Name = "donViTabpage";
            donViTabpage.Padding = new Padding(4, 5, 4, 5);
            donViTabpage.Size = new Size(1796, 941);
            donViTabpage.TabIndex = 1;
            donViTabpage.Text = "Đơn Vị";
            donViTabpage.UseVisualStyleBackColor = true;
            // 
            // donViTab1
            // 
            donViTab1.Dock = DockStyle.Fill;
            donViTab1.Location = new Point(4, 5);
            donViTab1.Margin = new Padding(5);
            donViTab1.MinimumSize = new Size(1787, 845);
            donViTab1.Name = "donViTab1";
            donViTab1.Size = new Size(1788, 931);
            donViTab1.TabIndex = 0;
            // 
            // hocPhanTabpage
            // 
            hocPhanTabpage.Controls.Add(hocPhanTab1);
            hocPhanTabpage.Location = new Point(4, 34);
            hocPhanTabpage.Margin = new Padding(4);
            hocPhanTabpage.Name = "hocPhanTabpage";
            hocPhanTabpage.Padding = new Padding(4);
            hocPhanTabpage.Size = new Size(1796, 941);
            hocPhanTabpage.TabIndex = 2;
            hocPhanTabpage.Text = "Học Phần";
            hocPhanTabpage.UseVisualStyleBackColor = true;
            // 
            // hocPhanTab1
            // 
            hocPhanTab1.Dock = DockStyle.Fill;
            hocPhanTab1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hocPhanTab1.Location = new Point(4, 4);
            hocPhanTab1.Margin = new Padding(5);
            hocPhanTab1.MinimumSize = new Size(1787, 845);
            hocPhanTab1.Name = "hocPhanTab1";
            hocPhanTab1.Size = new Size(1788, 933);
            hocPhanTab1.TabIndex = 0;
            // 
            // khmoTabpage
            // 
            khmoTabpage.Controls.Add(khmoTab1);
            khmoTabpage.Location = new Point(4, 34);
            khmoTabpage.Margin = new Padding(4);
            khmoTabpage.Name = "khmoTabpage";
            khmoTabpage.Padding = new Padding(4);
            khmoTabpage.Size = new Size(1796, 941);
            khmoTabpage.TabIndex = 3;
            khmoTabpage.Text = "Kế Hoạch Mở";
            khmoTabpage.UseVisualStyleBackColor = true;
            // 
            // khmoTab1
            // 
            khmoTab1.Dock = DockStyle.Fill;
            khmoTab1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            khmoTab1.Location = new Point(4, 4);
            khmoTab1.Margin = new Padding(5);
            khmoTab1.MinimumSize = new Size(1787, 845);
            khmoTab1.Name = "khmoTab1";
            khmoTab1.Size = new Size(1788, 933);
            khmoTab1.TabIndex = 0;
            // 
            // phanCongTab
            // 
            phanCongTab.Controls.Add(phanCongTab1);
            phanCongTab.Location = new Point(4, 34);
            phanCongTab.Margin = new Padding(4);
            phanCongTab.Name = "phanCongTab";
            phanCongTab.Padding = new Padding(4);
            phanCongTab.Size = new Size(1796, 941);
            phanCongTab.TabIndex = 4;
            phanCongTab.Text = "Phân Công";
            phanCongTab.UseVisualStyleBackColor = true;
            // 
            // phanCongTab1
            // 
            phanCongTab1.Dock = DockStyle.Fill;
            phanCongTab1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phanCongTab1.Location = new Point(4, 4);
            phanCongTab1.Margin = new Padding(5);
            phanCongTab1.MinimumSize = new Size(1787, 845);
            phanCongTab1.Name = "phanCongTab1";
            phanCongTab1.Size = new Size(1788, 933);
            phanCongTab1.TabIndex = 0;
            // 
            // dangKyTabPage
            // 
            dangKyTabPage.Controls.Add(dangKyTab1);
            dangKyTabPage.Location = new Point(4, 34);
            dangKyTabPage.Margin = new Padding(4);
            dangKyTabPage.Name = "dangKyTabPage";
            dangKyTabPage.Padding = new Padding(4);
            dangKyTabPage.Size = new Size(1796, 941);
            dangKyTabPage.TabIndex = 5;
            dangKyTabPage.Text = "Lớp Học";
            dangKyTabPage.UseVisualStyleBackColor = true;
            // 
            // dangKyTab1
            // 
            dangKyTab1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dangKyTab1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dangKyTab1.Location = new Point(4, 4);
            dangKyTab1.Margin = new Padding(5);
            dangKyTab1.MinimumSize = new Size(1787, 845);
            dangKyTab1.Name = "dangKyTab1";
            dangKyTab1.Size = new Size(1788, 933);
            dangKyTab1.TabIndex = 0;
            // 
            // sinhVienTab
            // 
            sinhVienTab.Controls.Add(sinhVienTab1);
            sinhVienTab.Location = new Point(4, 34);
            sinhVienTab.Margin = new Padding(4);
            sinhVienTab.Name = "sinhVienTab";
            sinhVienTab.Padding = new Padding(4);
            sinhVienTab.Size = new Size(1796, 941);
            sinhVienTab.TabIndex = 6;
            sinhVienTab.Text = "Sinh Viên";
            sinhVienTab.UseVisualStyleBackColor = true;
            // 
            // sinhVienTab1
            // 
            sinhVienTab1.Dock = DockStyle.Fill;
            sinhVienTab1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sinhVienTab1.Location = new Point(4, 4);
            sinhVienTab1.Margin = new Padding(5);
            sinhVienTab1.MinimumSize = new Size(1787, 845);
            sinhVienTab1.Name = "sinhVienTab1";
            sinhVienTab1.Size = new Size(1788, 933);
            sinhVienTab1.TabIndex = 0;
            // 
            // xemCSDLTabpage
            // 
            xemCSDLTabpage.Controls.Add(emp_XemqlthTab1);
            xemCSDLTabpage.Location = new Point(4, 34);
            xemCSDLTabpage.Name = "xemCSDLTabpage";
            xemCSDLTabpage.Size = new Size(1796, 941);
            xemCSDLTabpage.TabIndex = 8;
            xemCSDLTabpage.Text = "Xem CSDL";
            xemCSDLTabpage.UseVisualStyleBackColor = true;
            // 
            // emp_XemqlthTab1
            // 
            emp_XemqlthTab1.Location = new Point(0, 0);
            emp_XemqlthTab1.MinimumSize = new Size(1432, 800);
            emp_XemqlthTab1.Name = "emp_XemqlthTab1";
            emp_XemqlthTab1.Size = new Size(1788, 900);
            emp_XemqlthTab1.TabIndex = 0;
            // 
            // thongBaoTabpage
            // 
            thongBaoTabpage.Controls.Add(emp_ThongBaoTab1);
            thongBaoTabpage.Location = new Point(4, 34);
            thongBaoTabpage.Name = "thongBaoTabpage";
            thongBaoTabpage.Size = new Size(1796, 941);
            thongBaoTabpage.TabIndex = 9;
            thongBaoTabpage.Text = "Thông báo";
            thongBaoTabpage.UseVisualStyleBackColor = true;
            // 
            // emp_ThongBaoTab1
            // 
            emp_ThongBaoTab1.Location = new Point(0, 0);
            emp_ThongBaoTab1.MinimumSize = new Size(1432, 800);
            emp_ThongBaoTab1.Name = "emp_ThongBaoTab1";
            emp_ThongBaoTab1.Size = new Size(1788, 900);
            emp_ThongBaoTab1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(1680, 1189);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(120, 59);
            button1.TabIndex = 2;
            button1.Text = "Sign Out";
            button1.UseVisualStyleBackColor = false;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LogoutBtn.BackColor = Color.Crimson;
            LogoutBtn.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutBtn.ForeColor = Color.WhiteSmoke;
            LogoutBtn.Location = new Point(1668, 984);
            LogoutBtn.Margin = new Padding(4, 5, 4, 5);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(136, 59);
            LogoutBtn.TabIndex = 3;
            LogoutBtn.Text = "Đăng xuất";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // EmpHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1806, 1050);
            Controls.Add(LogoutBtn);
            Controls.Add(button1);
            Controls.Add(NhanSuTabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1823, 1004);
            Name = "EmpHome";
            Text = "QUẢN LÝ TRƯỜNG HỌC";
            FormClosed += EmpHome_FormClosed;
            NhanSuTabControl.ResumeLayout(false);
            TTCNTabpage.ResumeLayout(false);
            nhanSuTabpage.ResumeLayout(false);
            donViTabpage.ResumeLayout(false);
            hocPhanTabpage.ResumeLayout(false);
            khmoTabpage.ResumeLayout(false);
            phanCongTab.ResumeLayout(false);
            dangKyTabPage.ResumeLayout(false);
            sinhVienTab.ResumeLayout(false);
            xemCSDLTabpage.ResumeLayout(false);
            thongBaoTabpage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl NhanSuTabControl;
        private TabPage nhanSuTabpage;
        private TabPage donViTabpage;
        private Button button1;
        private uc.Emp_NhanSuTab nhanSuTab1;
        private uc.Emp_DonViTab donViTab1;
        private TabPage hocPhanTabpage;
        private uc.Emp_HocPhanTab hocPhanTab1;
        private TabPage khmoTabpage;
        private uc.Emp_KhmoTab khmoTab1;
        private TabPage phanCongTab;
        private TabPage dangKyTabPage;
        private uc.Emp_DangKyTab dangKyTab1;
        private TabPage sinhVienTab;
        private uc.Emp_SinhVienTab sinhVienTab1;
        private uc.Emp_PhanCongTab phanCongTab1;
        private TabPage TTCNTabpage;
        private uc.Emp_TTCNTab emp_ttcnTab1;
        private Button LogoutBtn;
        private TabPage xemCSDLTabpage;
        private uc.Emp_XemQLTHTab emp_Xemqlth1;
        private TabPage thongBaoTabpage;
        private uc.Emp_ThongBaoTab emp_ThongBaoTab1;
        private uc.Emp_XemQLTHTab emp_XemqlthTab1;
    }
}
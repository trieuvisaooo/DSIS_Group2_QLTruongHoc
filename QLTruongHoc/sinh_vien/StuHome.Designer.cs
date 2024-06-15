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
            TBTabpage = new TabPage();
            thongbaoTab1 = new uc.Stu_THONGBAOTab();
            KQHTTabPage = new TabPage();
            kqhtTab1 = new uc.Stu_KQHTTab();
            KHMoTabpage = new TabPage();
            khmO_sv1 = new uc.Stu_KHMOTab();
            HPTabpage = new TabPage();
            hpsvTab1 = new uc.HPSVTab();
            TTCNTabPage = new TabPage();
            ttcnsvTab1 = new uc.Stu_TTCNTab();
            tabControl1 = new TabControl();
            DangKyTabPage = new TabPage();
            LogoutBtn = new Button();
            TBTabpage.SuspendLayout();
            KQHTTabPage.SuspendLayout();
            KHMoTabpage.SuspendLayout();
            HPTabpage.SuspendLayout();
            TTCNTabPage.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // TBTabpage
            // 
            TBTabpage.Controls.Add(thongbaoTab1);
            TBTabpage.Location = new Point(4, 34);
            TBTabpage.Margin = new Padding(4, 5, 4, 5);
            TBTabpage.Name = "TBTabpage";
            TBTabpage.Padding = new Padding(4, 5, 4, 5);
            TBTabpage.Size = new Size(1795, 855);
            TBTabpage.TabIndex = 1;
            TBTabpage.Text = "Thông Báo";
            TBTabpage.UseVisualStyleBackColor = true;
            // 
            // thongbaoTab1
            // 
            thongbaoTab1.Location = new Point(0, 0);
            thongbaoTab1.MinimumSize = new Size(1432, 800);
            thongbaoTab1.Name = "thongbaoTab1";
            thongbaoTab1.Size = new Size(1795, 850);
            thongbaoTab1.TabIndex = 0;
            // 
            // KQHTTabPage
            // 
            KQHTTabPage.Controls.Add(kqhtTab1);
            KQHTTabPage.Location = new Point(4, 34);
            KQHTTabPage.Margin = new Padding(4);
            KQHTTabPage.Name = "KQHTTabPage";
            KQHTTabPage.Padding = new Padding(4);
            KQHTTabPage.Size = new Size(1795, 855);
            KQHTTabPage.TabIndex = 5;
            KQHTTabPage.Text = "Kết Quả Học Tập";
            KQHTTabPage.UseVisualStyleBackColor = true;
            // 
            // kqhtTab1
            // 
            kqhtTab1.Location = new Point(0, 0);
            kqhtTab1.MinimumSize = new Size(1432, 800);
            kqhtTab1.Name = "kqhtTab1";
            kqhtTab1.Size = new Size(1795, 850);
            kqhtTab1.TabIndex = 0;
            // 
            // KHMoTabpage
            // 
            KHMoTabpage.Controls.Add(khmO_sv1);
            KHMoTabpage.Location = new Point(4, 34);
            KHMoTabpage.Margin = new Padding(4);
            KHMoTabpage.Name = "KHMoTabpage";
            KHMoTabpage.Padding = new Padding(4);
            KHMoTabpage.Size = new Size(1795, 855);
            KHMoTabpage.TabIndex = 3;
            KHMoTabpage.Text = "Kế Hoạch Mở";
            KHMoTabpage.UseVisualStyleBackColor = true;
            // 
            // khmO_sv1
            // 
            khmO_sv1.Location = new Point(0, 0);
            khmO_sv1.MinimumSize = new Size(1432, 800);
            khmO_sv1.Name = "khmO_sv1";
            khmO_sv1.Size = new Size(1795, 850);
            khmO_sv1.TabIndex = 0;
            // 
            // HPTabpage
            // 
            HPTabpage.Controls.Add(hpsvTab1);
            HPTabpage.Location = new Point(4, 34);
            HPTabpage.Margin = new Padding(4);
            HPTabpage.Name = "HPTabpage";
            HPTabpage.Padding = new Padding(4);
            HPTabpage.Size = new Size(1795, 855);
            HPTabpage.TabIndex = 2;
            HPTabpage.Text = "Học Phần";
            HPTabpage.UseVisualStyleBackColor = true;
            // 
            // hpsvTab1
            // 
            hpsvTab1.Location = new Point(0, 0);
            hpsvTab1.MinimumSize = new Size(1432, 800);
            hpsvTab1.Name = "hpsvTab1";
            hpsvTab1.Size = new Size(1795, 850);
            hpsvTab1.TabIndex = 0;
            // 
            // TTCNTabPage
            // 
            TTCNTabPage.Controls.Add(ttcnsvTab1);
            TTCNTabPage.Location = new Point(4, 34);
            TTCNTabPage.Margin = new Padding(4, 5, 4, 5);
            TTCNTabPage.Name = "TTCNTabPage";
            TTCNTabPage.Padding = new Padding(4, 5, 4, 5);
            TTCNTabPage.Size = new Size(1795, 855);
            TTCNTabPage.TabIndex = 0;
            TTCNTabPage.Text = "Thông Tin Cá Nhân";
            TTCNTabPage.UseVisualStyleBackColor = true;
            // 
            // ttcnsvTab1
            // 
            ttcnsvTab1.Location = new Point(-4, 0);
            ttcnsvTab1.MinimumSize = new Size(1432, 800);
            ttcnsvTab1.Name = "ttcnsvTab1";
            ttcnsvTab1.Size = new Size(1799, 886);
            ttcnsvTab1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(TTCNTabPage);
            tabControl1.Controls.Add(KQHTTabPage);
            tabControl1.Controls.Add(HPTabpage);
            tabControl1.Controls.Add(KHMoTabpage);
            tabControl1.Controls.Add(DangKyTabPage);
            tabControl1.Controls.Add(TBTabpage);
            tabControl1.Location = new Point(4, 0);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1803, 893);
            tabControl1.TabIndex = 1;
            // 
            // DangKyTabPage
            // 
            DangKyTabPage.Location = new Point(4, 34);
            DangKyTabPage.Name = "DangKyTabPage";
            DangKyTabPage.Size = new Size(1795, 855);
            DangKyTabPage.TabIndex = 6;
            DangKyTabPage.Text = "Đăng Ký HP";
            DangKyTabPage.UseVisualStyleBackColor = true;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LogoutBtn.BackColor = Color.Crimson;
            LogoutBtn.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutBtn.ForeColor = Color.WhiteSmoke;
            LogoutBtn.Location = new Point(1669, 889);
            LogoutBtn.Margin = new Padding(4, 5, 4, 5);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(136, 59);
            LogoutBtn.TabIndex = 2;
            LogoutBtn.Text = "Đăng xuất";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // StuHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1808, 950);
            Controls.Add(LogoutBtn);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1824, 1006);
            Name = "StuHome";
            Text = "QUẢN LÝ TRƯỜNG HỌC";
            FormClosed += StuHome_FormClosed;
            TBTabpage.ResumeLayout(false);
            KQHTTabPage.ResumeLayout(false);
            KHMoTabpage.ResumeLayout(false);
            HPTabpage.ResumeLayout(false);
            TTCNTabPage.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage TBTabpage;
        private TabPage KQHTTabPage;
        private TabPage KHMoTabpage;
        private TabPage HPTabpage;
        private TabPage TTCNTabPage;
        private uc.Stu_TTCNTab ttcnsvTab1;
        private TabControl tabControl1;
        private TabPage DangKyTabPage;
        private uc.Stu_KHMOTab khmO_sv1;
        private uc.Stu_THONGBAOTab thongbaoTab1;
        private uc.Stu_KQHTTab kqhtTab1;
        private uc.HPSVTab hpsvTab1;
        private Button LogoutBtn;
    }
}
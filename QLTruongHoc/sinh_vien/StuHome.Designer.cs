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
            TTCNTabPage = new TabPage();
            ttcnsvTab1 = new uc.Stu_TTCNTab();
            tabControl1 = new TabControl();
            DangKyTabPage = new TabPage();
            stu_dangkyTab1 = new uc.Stu_DANGKYTab();
            LogoutBtn = new Button();
            hpsvTab1 = new uc.HPSVTab();
            TBTabpage.SuspendLayout();
            KQHTTabPage.SuspendLayout();
            KHMoTabpage.SuspendLayout();
            HPTabpage.SuspendLayout();
            TTCNTabPage.SuspendLayout();
            tabControl1.SuspendLayout();
            DangKyTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // TBTabpage
            // 
            TBTabpage.Controls.Add(thongbaoTab1);
            TBTabpage.Location = new Point(4, 29);
            TBTabpage.Margin = new Padding(3, 4, 3, 4);
            TBTabpage.Name = "TBTabpage";
            TBTabpage.Padding = new Padding(3, 4, 3, 4);
            TBTabpage.Size = new Size(1434, 681);
            TBTabpage.TabIndex = 1;
            TBTabpage.Text = "Thông Báo";
            TBTabpage.UseVisualStyleBackColor = true;
            // 
            // thongbaoTab1
            // 
            thongbaoTab1.Location = new Point(0, 0);
            thongbaoTab1.Margin = new Padding(2, 2, 2, 2);
            thongbaoTab1.MinimumSize = new Size(1146, 640);
            thongbaoTab1.Name = "thongbaoTab1";
            thongbaoTab1.Size = new Size(1436, 680);
            thongbaoTab1.TabIndex = 0;
            // 
            // KQHTTabPage
            // 
            KQHTTabPage.Controls.Add(kqhtTab1);
            KQHTTabPage.Location = new Point(4, 29);
            KQHTTabPage.Name = "KQHTTabPage";
            KQHTTabPage.Padding = new Padding(3);
            KQHTTabPage.Size = new Size(1434, 681);
            KQHTTabPage.TabIndex = 5;
            KQHTTabPage.Text = "Kết Quả Học Tập";
            KQHTTabPage.UseVisualStyleBackColor = true;
            // 
            // kqhtTab1
            // 
            kqhtTab1.Location = new Point(0, 0);
            kqhtTab1.Margin = new Padding(2, 2, 2, 2);
            kqhtTab1.MinimumSize = new Size(1146, 640);
            kqhtTab1.Name = "kqhtTab1";
            kqhtTab1.Size = new Size(1436, 680);
            kqhtTab1.TabIndex = 0;
            // 
            // KHMoTabpage
            // 
            KHMoTabpage.Controls.Add(khmO_sv1);
            KHMoTabpage.Location = new Point(4, 29);
            KHMoTabpage.Name = "KHMoTabpage";
            KHMoTabpage.Padding = new Padding(3);
            KHMoTabpage.Size = new Size(1434, 681);
            KHMoTabpage.TabIndex = 3;
            KHMoTabpage.Text = "Kế Hoạch Mở";
            KHMoTabpage.UseVisualStyleBackColor = true;
            // 
            // khmO_sv1
            // 
            khmO_sv1.Location = new Point(0, 0);
            khmO_sv1.Margin = new Padding(2, 2, 2, 2);
            khmO_sv1.MinimumSize = new Size(1146, 640);
            khmO_sv1.Name = "khmO_sv1";
            khmO_sv1.Size = new Size(1436, 680);
            khmO_sv1.TabIndex = 0;
            // 
            // HPTabpage
            // 
            HPTabpage.Controls.Add(hpsvTab1);
            HPTabpage.Location = new Point(4, 29);
            HPTabpage.Name = "HPTabpage";
            HPTabpage.Padding = new Padding(3);
            HPTabpage.Size = new Size(1434, 681);
            HPTabpage.TabIndex = 2;
            HPTabpage.Text = "Học Phần";
            HPTabpage.UseVisualStyleBackColor = true;
            // 
            // TTCNTabPage
            // 
            TTCNTabPage.Controls.Add(ttcnsvTab1);
            TTCNTabPage.Location = new Point(4, 29);
            TTCNTabPage.Margin = new Padding(3, 4, 3, 4);
            TTCNTabPage.Name = "TTCNTabPage";
            TTCNTabPage.Padding = new Padding(3, 4, 3, 4);
            TTCNTabPage.Size = new Size(1434, 681);
            TTCNTabPage.TabIndex = 0;
            TTCNTabPage.Text = "Thông Tin Cá Nhân";
            TTCNTabPage.UseVisualStyleBackColor = true;
            // 
            // ttcnsvTab1
            // 
            ttcnsvTab1.Location = new Point(-3, 0);
            ttcnsvTab1.Margin = new Padding(2, 2, 2, 2);
            ttcnsvTab1.MinimumSize = new Size(1146, 640);
            ttcnsvTab1.Name = "ttcnsvTab1";
            ttcnsvTab1.Size = new Size(1439, 709);
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
            tabControl1.Location = new Point(3, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1442, 714);
            tabControl1.TabIndex = 1;
            // 
            // DangKyTabPage
            // 
            DangKyTabPage.Controls.Add(stu_dangkyTab1);
            DangKyTabPage.Location = new Point(4, 29);
            DangKyTabPage.Margin = new Padding(2);
            DangKyTabPage.Name = "DangKyTabPage";
            DangKyTabPage.Size = new Size(1434, 681);
            DangKyTabPage.TabIndex = 6;
            DangKyTabPage.Text = "Đăng Ký HP";
            DangKyTabPage.UseVisualStyleBackColor = true;
            // 
            // stu_dangkyTab1
            // 
            stu_dangkyTab1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stu_dangkyTab1.Location = new Point(0, 0);
            stu_dangkyTab1.Margin = new Padding(2, 2, 2, 2);
            stu_dangkyTab1.MinimumSize = new Size(1146, 640);
            stu_dangkyTab1.Name = "stu_dangkyTab1";
            stu_dangkyTab1.Size = new Size(1436, 680);
            stu_dangkyTab1.TabIndex = 0;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LogoutBtn.BackColor = Color.Crimson;
            LogoutBtn.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutBtn.ForeColor = Color.WhiteSmoke;
            LogoutBtn.Location = new Point(1335, 711);
            LogoutBtn.Margin = new Padding(3, 4, 3, 4);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(109, 47);
            LogoutBtn.TabIndex = 2;
            LogoutBtn.Text = "Đăng xuất";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // hpsvTab1
            // 
            hpsvTab1.Dock = DockStyle.Fill;
            hpsvTab1.Location = new Point(3, 3);
            hpsvTab1.Margin = new Padding(2);
            hpsvTab1.MinimumSize = new Size(1146, 640);
            hpsvTab1.Name = "hpsvTab1";
            hpsvTab1.Size = new Size(1428, 675);
            hpsvTab1.TabIndex = 0;
            // 
            // StuHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1446, 767);
            Controls.Add(LogoutBtn);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MinimumSize = new Size(1463, 814);
            Name = "StuHome";
            Text = "QUẢN LÝ TRƯỜNG HỌC";
            FormClosed += StuHome_FormClosed;
            TBTabpage.ResumeLayout(false);
            KQHTTabPage.ResumeLayout(false);
            KHMoTabpage.ResumeLayout(false);
            HPTabpage.ResumeLayout(false);
            TTCNTabPage.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            DangKyTabPage.ResumeLayout(false);
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
        private Button LogoutBtn;
        private uc.Stu_DANGKYTab stu_dangkyTab1;
        private uc.HPSVTab hpsvTab1;
    }
}
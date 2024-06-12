namespace QLTruongHoc.nhan_su.uc
{
    partial class DangKyTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            refreshBtn = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            listView1 = new ListView();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 38);
            label1.TabIndex = 0;
            label1.Text = "LỚP HỌC";
            // 
            // refreshBtn
            // 
            refreshBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refreshBtn.BackColor = Color.DarkSlateBlue;
            refreshBtn.ForeColor = SystemColors.ButtonFace;
            refreshBtn.Location = new Point(1332, 3);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(94, 39);
            refreshBtn.TabIndex = 2;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(3, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(1429, 725);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.1224613F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.87754F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(refreshBtn, 1, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Controls.Add(listView1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.3920455F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 93.6079559F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1429, 725);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.DarkOliveGreen;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(261, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 4;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(361, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(dataGridView1, 2);
            dataGridView1.Size = new Size(1065, 674);
            dataGridView1.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Location = new Point(3, 48);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            tableLayoutPanel1.SetRowSpan(listView1, 2);
            listView1.Size = new Size(352, 674);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Tile;
            listView1.ItemChecked += listView1_ItemChecked;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.MouseMove += listView1_MouseMove;
            // 
            // DangKyTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(1432, 800);
            Name = "DangKyTab";
            Size = new Size(1432, 800);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button refreshBtn;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private Button button1;
        private ListView listView1;
        private ToolTip listViewToolTip = new ToolTip();
        
    }
}

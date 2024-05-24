
namespace QLTruongHoc
{
    partial class SysPrivsTab
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
            grantView = new DataGridView();
            label1 = new Label();
            searchTextBox = new TextBox();
            loadButton = new Button();
            grantRevokeButton = new Button();
            searchGrantee = new Button();
            ((System.ComponentModel.ISupportInitialize)grantView).BeginInit();
            SuspendLayout();
            // 
            // grantView
            // 
            grantView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grantView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grantView.BackgroundColor = SystemColors.Control;
            grantView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grantView.Location = new Point(6, 55);
            grantView.Name = "grantView";
            grantView.RowHeadersWidth = 51;
            grantView.RowTemplate.Height = 24;
            grantView.Size = new Size(1251, 539);
            grantView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(28, 22);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 1;
            label1.Text = "Search By Grantee";
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 11.25F);
            searchTextBox.Location = new Point(163, 19);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(158, 27);
            searchTextBox.TabIndex = 2;
            // 
            // loadButton
            // 
            loadButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loadButton.Font = new Font("Segoe UI", 11.25F);
            loadButton.Location = new Point(1178, 20);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(79, 31);
            loadButton.TabIndex = 3;
            loadButton.Text = "Refresh";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // grantRevokeButton
            // 
            grantRevokeButton.BackColor = Color.LightGreen;
            grantRevokeButton.Font = new Font("Segoe UI", 11.25F);
            grantRevokeButton.Location = new Point(470, 6);
            grantRevokeButton.Name = "grantRevokeButton";
            grantRevokeButton.Size = new Size(130, 43);
            grantRevokeButton.TabIndex = 4;
            grantRevokeButton.Text = "GRANT/REVOKE";
            grantRevokeButton.UseVisualStyleBackColor = false;
            grantRevokeButton.Click += grantRevokeButton_Click;
            // 
            // searchGrantee
            // 
            searchGrantee.BackColor = Color.Cyan;
            searchGrantee.Font = new Font("Segoe UI", 11.25F);
            searchGrantee.Location = new Point(327, 16);
            searchGrantee.Name = "searchGrantee";
            searchGrantee.Size = new Size(76, 32);
            searchGrantee.TabIndex = 5;
            searchGrantee.Text = "Search";
            searchGrantee.UseVisualStyleBackColor = false;
            searchGrantee.Click += searchGrantee_Click;
            // 
            // SysPrivsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(searchGrantee);
            Controls.Add(grantRevokeButton);
            Controls.Add(loadButton);
            Controls.Add(searchTextBox);
            Controls.Add(label1);
            Controls.Add(grantView);
            MinimumSize = new Size(1263, 600);
            Name = "SysPrivsTab";
            Padding = new Padding(3);
            Size = new Size(1263, 600);
            Load += SysPrivs_Load;
            ((System.ComponentModel.ISupportInitialize)grantView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView grantView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button grantRevokeButton;
        private System.Windows.Forms.Button searchGrantee;
    }
}

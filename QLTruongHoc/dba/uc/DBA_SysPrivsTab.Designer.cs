
namespace QLTruongHoc
{
    partial class DBA_SysPrivsTab
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
            grantView.Location = new Point(9, 92);
            grantView.Margin = new Padding(4, 5, 4, 5);
            grantView.Name = "grantView";
            grantView.RowHeadersWidth = 51;
            grantView.RowTemplate.Height = 24;
            grantView.Size = new Size(1415, 698);
            grantView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(34, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 31);
            label1.TabIndex = 1;
            label1.Text = "Tìm theo Grantee";
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 11.25F);
            searchTextBox.Location = new Point(233, 32);
            searchTextBox.Margin = new Padding(4, 5, 4, 5);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(224, 37);
            searchTextBox.TabIndex = 2;
            // 
            // loadButton
            // 
            loadButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loadButton.BackColor = Color.DarkSlateBlue;
            loadButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            loadButton.ForeColor = SystemColors.ButtonFace;
            loadButton.Location = new Point(1304, 30);
            loadButton.Margin = new Padding(4, 5, 4, 5);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(120, 44);
            loadButton.TabIndex = 3;
            loadButton.Text = "Xem";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_Click;
            // 
            // grantRevokeButton
            // 
            grantRevokeButton.BackColor = SystemColors.ActiveCaption;
            grantRevokeButton.Font = new Font("Segoe UI", 11.25F);
            grantRevokeButton.Location = new Point(667, 23);
            grantRevokeButton.Margin = new Padding(4, 5, 4, 5);
            grantRevokeButton.Name = "grantRevokeButton";
            grantRevokeButton.Size = new Size(188, 55);
            grantRevokeButton.TabIndex = 4;
            grantRevokeButton.Text = "GRANT/REVOKE";
            grantRevokeButton.UseVisualStyleBackColor = false;
            grantRevokeButton.Click += grantRevokeButton_Click;
            // 
            // searchGrantee
            // 
            searchGrantee.BackColor = Color.DarkSlateBlue;
            searchGrantee.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            searchGrantee.ForeColor = SystemColors.ButtonFace;
            searchGrantee.Location = new Point(465, 30);
            searchGrantee.Margin = new Padding(4, 5, 4, 5);
            searchGrantee.Name = "searchGrantee";
            searchGrantee.Size = new Size(120, 44);
            searchGrantee.TabIndex = 5;
            searchGrantee.Text = "Tìm";
            searchGrantee.UseVisualStyleBackColor = false;
            searchGrantee.Click += searchGrantee_Click;
            // 
            // SysPrivsTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(searchGrantee);
            Controls.Add(grantRevokeButton);
            Controls.Add(loadButton);
            Controls.Add(searchTextBox);
            Controls.Add(label1);
            Controls.Add(grantView);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1432, 800);
            Name = "SysPrivsTab";
            Padding = new Padding(4, 5, 4, 5);
            Size = new Size(1432, 800);
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
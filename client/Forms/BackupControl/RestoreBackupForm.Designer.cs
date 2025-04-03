namespace client.Forms.BackupControl
{
    partial class RestoreBackupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestoreBackupForm));
            panel1 = new Panel();
            btnRemoveBrowsed = new Button();
            lblSelectedPath = new Label();
            btnBrowse = new Button();
            flpAvailableBackups = new FlowLayoutPanel();
            label2 = new Label();
            btnClose = new PictureBox();
            btnCancel = new Button();
            btnRestore = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnRemoveBrowsed);
            panel1.Controls.Add(lblSelectedPath);
            panel1.Controls.Add(btnBrowse);
            panel1.Controls.Add(flpAvailableBackups);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnRestore);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 483);
            panel1.TabIndex = 0;
            // 
            // btnRemoveBrowsed
            // 
            btnRemoveBrowsed.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveBrowsed.Location = new Point(446, 346);
            btnRemoveBrowsed.Name = "btnRemoveBrowsed";
            btnRemoveBrowsed.Size = new Size(84, 40);
            btnRemoveBrowsed.TabIndex = 54;
            btnRemoveBrowsed.Text = "Remove";
            btnRemoveBrowsed.UseVisualStyleBackColor = true;
            btnRemoveBrowsed.Visible = false;
            btnRemoveBrowsed.Click += btnRemoveBrowsed_Click;
            // 
            // lblSelectedPath
            // 
            lblSelectedPath.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectedPath.Location = new Point(191, 346);
            lblSelectedPath.Name = "lblSelectedPath";
            lblSelectedPath.Size = new Size(249, 40);
            lblSelectedPath.TabIndex = 53;
            lblSelectedPath.Text = "path";
            lblSelectedPath.TextAlign = ContentAlignment.MiddleLeft;
            lblSelectedPath.Visible = false;
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowse.Location = new Point(41, 346);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(144, 40);
            btnBrowse.TabIndex = 52;
            btnBrowse.Text = "Browse Files";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // flpAvailableBackups
            // 
            flpAvailableBackups.AutoScroll = true;
            flpAvailableBackups.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpAvailableBackups.BackColor = Color.FromArgb(232, 232, 232);
            flpAvailableBackups.BorderStyle = BorderStyle.FixedSingle;
            flpAvailableBackups.FlowDirection = FlowDirection.TopDown;
            flpAvailableBackups.Location = new Point(41, 134);
            flpAvailableBackups.Name = "flpAvailableBackups";
            flpAvailableBackups.Size = new Size(489, 194);
            flpAvailableBackups.TabIndex = 51;
            flpAvailableBackups.WrapContents = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(41, 93);
            label2.Name = "label2";
            label2.Size = new Size(269, 31);
            label2.TabIndex = 50;
            label2.Text = "Available Local Backups";
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.CloseX32;
            btnClose.Location = new Point(522, 14);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 49;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(161, 136, 127);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(141, 110, 99);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(238, 424);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(143, 43);
            btnCancel.TabIndex = 48;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRestore
            // 
            btnRestore.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRestore.BackColor = Color.FromArgb(141, 110, 99);
            btnRestore.FlatAppearance.BorderSize = 0;
            btnRestore.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 76, 65);
            btnRestore.FlatStyle = FlatStyle.Flat;
            btnRestore.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestore.ForeColor = Color.White;
            btnRestore.Location = new Point(387, 424);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(143, 43);
            btnRestore.TabIndex = 47;
            btnRestore.Text = "Restore";
            btnRestore.UseVisualStyleBackColor = false;
            btnRestore.Click += btnRestore_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Location = new Point(-1, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(573, 1);
            panel2.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(62, 39, 35);
            label1.Location = new Point(37, 14);
            label1.Name = "label1";
            label1.Size = new Size(296, 38);
            label1.TabIndex = 45;
            label1.Text = "Restore From Backup";
            // 
            // RestoreBackupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(573, 483);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RestoreBackupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += RestoreBackupForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRemoveBrowsed;
        private Label lblSelectedPath;
        private Button btnBrowse;
        private FlowLayoutPanel flpAvailableBackups;
        private Label label2;
        private PictureBox btnClose;
        private Button btnCancel;
        private Button btnRestore;
        private Panel panel2;
        private Label label1;
    }
}
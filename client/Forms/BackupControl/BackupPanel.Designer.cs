namespace client.Forms.BackupControl
{
    partial class BackupPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupPanel));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cboTime = new ComboBox();
            label7 = new Label();
            cbEncrypt = new CheckBox();
            label6 = new Label();
            cboLocation = new ComboBox();
            label5 = new Label();
            cboPolicy = new ComboBox();
            label4 = new Label();
            cboFrequency = new ComboBox();
            label3 = new Label();
            cbAutoBackup = new CheckBox();
            groupBox2 = new GroupBox();
            btnBackup = new Button();
            panel3 = new Panel();
            rbSelectedBackup = new RadioButton();
            panel2 = new Panel();
            rbFullBackup = new RadioButton();
            groupBox3 = new GroupBox();
            txtEmail = new TextBox();
            label9 = new Label();
            cbEmailNotif = new CheckBox();
            label8 = new Label();
            groupBox4 = new GroupBox();
            btnValidateRestore = new Button();
            btnRestoreDrive = new Button();
            btnRestoreLocal = new Button();
            cboRestorePoint = new ComboBox();
            label14 = new Label();
            panel4 = new Panel();
            lblDescription = new Label();
            progressBar = new ProgressBar();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(761, 94);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(62, 39, 35);
            label2.Location = new Point(16, 56);
            label2.Name = "label2";
            label2.Size = new Size(288, 20);
            label2.TabIndex = 1;
            label2.Text = "Manage and configure the backup system.";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(62, 39, 35);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(436, 38);
            label1.TabIndex = 0;
            label1.Text = "Backup && Restore Control Panel";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(cboTime);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbEncrypt);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cboLocation);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboPolicy);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboFrequency);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbAutoBackup);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(62, 39, 35);
            groupBox1.Location = new Point(12, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(761, 202);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Auto Backup Configuration";
            // 
            // cboTime
            // 
            cboTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTime.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            cboTime.FormattingEnabled = true;
            cboTime.Location = new Point(448, 42);
            cboTime.Name = "cboTime";
            cboTime.Size = new Size(200, 31);
            cboTime.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label7.Location = new Point(391, 45);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 9;
            label7.Text = "Time:";
            // 
            // cbEncrypt
            // 
            cbEncrypt.AutoSize = true;
            cbEncrypt.Checked = true;
            cbEncrypt.CheckState = CheckState.Checked;
            cbEncrypt.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbEncrypt.Location = new Point(173, 160);
            cbEncrypt.Name = "cbEncrypt";
            cbEncrypt.Size = new Size(18, 17);
            cbEncrypt.TabIndex = 8;
            cbEncrypt.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(12, 156);
            label6.Name = "label6";
            label6.Size = new Size(141, 23);
            label6.TabIndex = 7;
            label6.Text = "Encrypt Backups:";
            // 
            // cboLocation
            // 
            cboLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocation.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            cboLocation.FormattingEnabled = true;
            cboLocation.Items.AddRange(new object[] { "Local Storage", "Googledrive Storage", "Local and Googledrive Storage (Recommended)" });
            cboLocation.Location = new Point(170, 116);
            cboLocation.Name = "cboLocation";
            cboLocation.Size = new Size(582, 31);
            cboLocation.TabIndex = 6;
            cboLocation.SelectedIndexChanged += cboLocation_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(12, 119);
            label5.Name = "label5";
            label5.Size = new Size(140, 23);
            label5.TabIndex = 5;
            label5.Text = "Backup Location:";
            // 
            // cboPolicy
            // 
            cboPolicy.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPolicy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            cboPolicy.FormattingEnabled = true;
            cboPolicy.Items.AddRange(new object[] { "7 Days", "30 Days", "90 Days", "1 Year", "Forever" });
            cboPolicy.Location = new Point(173, 79);
            cboPolicy.Name = "cboPolicy";
            cboPolicy.Size = new Size(200, 31);
            cboPolicy.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(12, 82);
            label4.Name = "label4";
            label4.Size = new Size(138, 23);
            label4.TabIndex = 3;
            label4.Text = "Retention Policy:";
            // 
            // cboFrequency
            // 
            cboFrequency.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFrequency.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            cboFrequency.FormattingEnabled = true;
            cboFrequency.Items.AddRange(new object[] { "Real-Time", "Every 15 Minutes", "Hourly", "Daily", "Weekly", "Monthly" });
            cboFrequency.Location = new Point(173, 42);
            cboFrequency.Name = "cboFrequency";
            cboFrequency.Size = new Size(200, 31);
            cboFrequency.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(12, 45);
            label3.Name = "label3";
            label3.Size = new Size(155, 23);
            label3.TabIndex = 1;
            label3.Text = "Backup Frequency:";
            // 
            // cbAutoBackup
            // 
            cbAutoBackup.AutoSize = true;
            cbAutoBackup.Checked = true;
            cbAutoBackup.CheckState = CheckState.Checked;
            cbAutoBackup.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbAutoBackup.Location = new Point(533, 2);
            cbAutoBackup.Name = "cbAutoBackup";
            cbAutoBackup.Size = new Size(200, 27);
            cbAutoBackup.TabIndex = 0;
            cbAutoBackup.Text = "Auto Backup Disabled";
            cbAutoBackup.UseVisualStyleBackColor = true;
            cbAutoBackup.CheckedChanged += cbAutoBackup_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnBackup);
            groupBox2.Controls.Add(panel3);
            groupBox2.Controls.Add(panel2);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(62, 39, 35);
            groupBox2.Location = new Point(12, 331);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(373, 210);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Manual Backups";
            // 
            // btnBackup
            // 
            btnBackup.Anchor = AnchorStyles.Top;
            btnBackup.BackColor = Color.FromArgb(121, 85, 72);
            btnBackup.FlatAppearance.BorderSize = 0;
            btnBackup.FlatStyle = FlatStyle.Flat;
            btnBackup.ForeColor = Color.White;
            btnBackup.Location = new Point(37, 158);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(298, 39);
            btnBackup.TabIndex = 6;
            btnBackup.Text = "Backup Now";
            btnBackup.UseVisualStyleBackColor = false;
            btnBackup.Click += btnBackup_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(rbSelectedBackup);
            panel3.Location = new Point(37, 104);
            panel3.Name = "panel3";
            panel3.Size = new Size(298, 37);
            panel3.TabIndex = 5;
            // 
            // rbSelectedBackup
            // 
            rbSelectedBackup.Anchor = AnchorStyles.None;
            rbSelectedBackup.BackColor = Color.White;
            rbSelectedBackup.Enabled = false;
            rbSelectedBackup.FlatAppearance.BorderColor = Color.Black;
            rbSelectedBackup.FlatAppearance.BorderSize = 2;
            rbSelectedBackup.FlatStyle = FlatStyle.Flat;
            rbSelectedBackup.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            rbSelectedBackup.ForeColor = Color.FromArgb(62, 39, 35);
            rbSelectedBackup.Location = new Point(1, 1);
            rbSelectedBackup.Name = "rbSelectedBackup";
            rbSelectedBackup.Padding = new Padding(10, 0, 0, 0);
            rbSelectedBackup.Size = new Size(296, 35);
            rbSelectedBackup.TabIndex = 3;
            rbSelectedBackup.Text = "Selected Data Only";
            rbSelectedBackup.UseVisualStyleBackColor = false;
            rbSelectedBackup.MouseClick += rbSelectedBackup_MouseClick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(rbFullBackup);
            panel2.Location = new Point(38, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 37);
            panel2.TabIndex = 4;
            // 
            // rbFullBackup
            // 
            rbFullBackup.Anchor = AnchorStyles.None;
            rbFullBackup.BackColor = Color.White;
            rbFullBackup.Checked = true;
            rbFullBackup.FlatAppearance.BorderColor = Color.Black;
            rbFullBackup.FlatAppearance.BorderSize = 2;
            rbFullBackup.FlatStyle = FlatStyle.Flat;
            rbFullBackup.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            rbFullBackup.ForeColor = Color.FromArgb(62, 39, 35);
            rbFullBackup.Location = new Point(1, 1);
            rbFullBackup.Name = "rbFullBackup";
            rbFullBackup.Padding = new Padding(10, 0, 0, 0);
            rbFullBackup.Size = new Size(296, 35);
            rbFullBackup.TabIndex = 3;
            rbFullBackup.TabStop = true;
            rbFullBackup.Text = "Full System Backup";
            rbFullBackup.UseVisualStyleBackColor = false;
            rbFullBackup.MouseClick += rbFullBackup_MouseClick;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(txtEmail);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(cbEmailNotif);
            groupBox3.Controls.Add(label8);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.FromArgb(62, 39, 35);
            groupBox3.Location = new Point(400, 331);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(373, 210);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Notification Settings";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(6, 130);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(358, 34);
            txtEmail.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.Location = new Point(6, 104);
            label9.Name = "label9";
            label9.Size = new Size(120, 23);
            label9.TabIndex = 10;
            label9.Text = "Email Address:";
            // 
            // cbEmailNotif
            // 
            cbEmailNotif.AutoSize = true;
            cbEmailNotif.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbEmailNotif.Location = new Point(170, 56);
            cbEmailNotif.Name = "cbEmailNotif";
            cbEmailNotif.Size = new Size(18, 17);
            cbEmailNotif.TabIndex = 9;
            cbEmailNotif.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.Location = new Point(6, 52);
            label8.Name = "label8";
            label8.Size = new Size(157, 23);
            label8.TabIndex = 2;
            label8.Text = "Email Notifications:";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(btnValidateRestore);
            groupBox4.Controls.Add(btnRestoreDrive);
            groupBox4.Controls.Add(btnRestoreLocal);
            groupBox4.Controls.Add(cboRestorePoint);
            groupBox4.Controls.Add(label14);
            groupBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.FromArgb(62, 39, 35);
            groupBox4.Location = new Point(12, 553);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(761, 181);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "Restore Options";
            // 
            // btnValidateRestore
            // 
            btnValidateRestore.Anchor = AnchorStyles.Top;
            btnValidateRestore.BackColor = Color.Crimson;
            btnValidateRestore.FlatAppearance.BorderSize = 0;
            btnValidateRestore.FlatStyle = FlatStyle.Flat;
            btnValidateRestore.ForeColor = Color.White;
            btnValidateRestore.Location = new Point(388, 113);
            btnValidateRestore.Name = "btnValidateRestore";
            btnValidateRestore.Size = new Size(364, 41);
            btnValidateRestore.TabIndex = 7;
            btnValidateRestore.Text = "Validate && Restore Data";
            btnValidateRestore.UseVisualStyleBackColor = false;
            // 
            // btnRestoreDrive
            // 
            btnRestoreDrive.Location = new Point(37, 113);
            btnRestoreDrive.Name = "btnRestoreDrive";
            btnRestoreDrive.Size = new Size(297, 41);
            btnRestoreDrive.TabIndex = 4;
            btnRestoreDrive.Text = "Restore From Google Drive";
            btnRestoreDrive.UseVisualStyleBackColor = true;
            // 
            // btnRestoreLocal
            // 
            btnRestoreLocal.Location = new Point(37, 55);
            btnRestoreLocal.Name = "btnRestoreLocal";
            btnRestoreLocal.Size = new Size(297, 41);
            btnRestoreLocal.TabIndex = 3;
            btnRestoreLocal.Text = "Restore From Local Backup";
            btnRestoreLocal.UseVisualStyleBackColor = true;
            btnRestoreLocal.Click += btnRestoreLocal_Click;
            // 
            // cboRestorePoint
            // 
            cboRestorePoint.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRestorePoint.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            cboRestorePoint.FormattingEnabled = true;
            cboRestorePoint.Items.AddRange(new object[] { "Most Recent", "Specific Date & Time", "Custom (show list of saved backups)" });
            cboRestorePoint.Location = new Point(510, 63);
            cboRestorePoint.Name = "cboRestorePoint";
            cboRestorePoint.Size = new Size(242, 31);
            cboRestorePoint.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label14.Location = new Point(388, 66);
            label14.Name = "label14";
            label14.Size = new Size(116, 23);
            label14.TabIndex = 1;
            label14.Text = "Restore Point:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblDescription);
            panel4.Controls.Add(progressBar);
            panel4.ImeMode = ImeMode.Off;
            panel4.Location = new Point(1000, 1000);
            panel4.Name = "panel4";
            panel4.Size = new Size(356, 125);
            panel4.TabIndex = 7;
            panel4.Visible = false;
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.Black;
            lblDescription.Location = new Point(12, 32);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(332, 25);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "label";
            lblDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 64);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(332, 29);
            progressBar.TabIndex = 0;
            // 
            // BackupPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 232, 232);
            ClientSize = new Size(785, 754);
            Controls.Add(panel4);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BackupPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ELICIAS GARDEN FOOD PARK";
            Load += BackupPanel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private CheckBox cbAutoBackup;
        private CheckBox cbEncrypt;
        private Label label6;
        private ComboBox cboLocation;
        private Label label5;
        private ComboBox cboPolicy;
        private Label label4;
        private ComboBox cboFrequency;
        private ComboBox cboTime;
        private Label label7;
        private GroupBox groupBox2;
        private RadioButton rbFullBackup;
        private Panel panel2;
        private Panel panel3;
        private RadioButton rbSelectedBackup;
        private Button btnBackup;
        private GroupBox groupBox3;
        private TextBox txtEmail;
        private Label label9;
        private CheckBox cbEmailNotif;
        private Label label8;
        private GroupBox groupBox4;
        private Button btnRestoreDrive;
        private Button btnRestoreLocal;
        private ComboBox cboRestorePoint;
        private Label label14;
        private Button btnValidateRestore;
        private Panel panel4;
        private ProgressBar progressBar;
        private Label lblDescription;
    }
}
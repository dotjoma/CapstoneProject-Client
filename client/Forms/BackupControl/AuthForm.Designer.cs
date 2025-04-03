namespace client.Forms.BackupControl
{
    partial class AuthForm
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
            btnClose = new PictureBox();
            btnCancel = new Button();
            btnAuthenticate = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.Image = Properties.Resources.CloseX32;
            btnClose.Location = new Point(523, 18);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 40;
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
            btnCancel.Location = new Point(219, 252);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(143, 43);
            btnCancel.TabIndex = 33;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAuthenticate
            // 
            btnAuthenticate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAuthenticate.BackColor = Color.FromArgb(141, 110, 99);
            btnAuthenticate.FlatAppearance.BorderSize = 0;
            btnAuthenticate.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 76, 65);
            btnAuthenticate.FlatStyle = FlatStyle.Flat;
            btnAuthenticate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAuthenticate.ForeColor = Color.White;
            btnAuthenticate.Location = new Point(368, 252);
            btnAuthenticate.Name = "btnAuthenticate";
            btnAuthenticate.Size = new Size(143, 43);
            btnAuthenticate.TabIndex = 31;
            btnAuthenticate.Text = "Authenticate";
            btnAuthenticate.UseVisualStyleBackColor = false;
            btnAuthenticate.Click += btnAuthenticate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(0, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 1);
            panel1.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(62, 102);
            label2.Name = "label2";
            label2.Size = new Size(449, 28);
            label2.TabIndex = 23;
            label2.Text = "This action requires administrator verification";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(62, 39, 35);
            label1.Location = new Point(38, 18);
            label1.Name = "label1";
            label1.Size = new Size(406, 38);
            label1.TabIndex = 22;
            label1.Text = "Administrator Authentication";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(62, 150);
            label3.Name = "label3";
            label3.Size = new Size(169, 28);
            label3.TabIndex = 42;
            label3.Text = "Admin Password";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtPassword);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(573, 307);
            panel2.TabIndex = 43;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(61, 188);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(449, 34);
            txtPassword.TabIndex = 0;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(573, 307);
            Controls.Add(label3);
            Controls.Add(btnClose);
            Controls.Add(btnCancel);
            Controls.Add(btnAuthenticate);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AuthForm_Load;
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnClose;
        private Button btnCancel;
        private Button btnAuthenticate;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel2;
        private TextBox txtPassword;
    }
}
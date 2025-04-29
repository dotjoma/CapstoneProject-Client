namespace client.Forms
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            lblCredits = new Label();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnCreateAccount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            btnSignIn = new Guna.UI2.WinForms.Guna2Button();
            cbRememberMe = new Guna.UI2.WinForms.Guna2CheckBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            btnForgotPass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2Panel2.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.elicia_s_logo;
            pictureBox1.Location = new Point(202, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Controls.Add(lblCredits);
            guna2Panel2.CustomizableEdges = customizableEdges11;
            guna2Panel2.Dock = DockStyle.Bottom;
            guna2Panel2.FillColor = Color.FromArgb(98, 87, 87);
            guna2Panel2.Location = new Point(0, 481);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Panel2.Size = new Size(488, 40);
            guna2Panel2.TabIndex = 10;
            guna2Panel2.MouseDown += guna2Panel2_MouseDown;
            guna2Panel2.MouseMove += guna2Panel2_MouseMove;
            guna2Panel2.MouseUp += guna2Panel2_MouseUp;
            // 
            // lblCredits
            // 
            lblCredits.BackColor = Color.Transparent;
            lblCredits.Dock = DockStyle.Fill;
            lblCredits.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCredits.ForeColor = Color.White;
            lblCredits.Location = new Point(0, 0);
            lblCredits.Name = "lblCredits";
            lblCredits.Size = new Size(488, 40);
            lblCredits.TabIndex = 0;
            lblCredits.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel5.ForeColor = Color.FromArgb(98, 87, 87);
            guna2HtmlLabel5.IsSelectionEnabled = false;
            guna2HtmlLabel5.Location = new Point(96, 454);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(158, 19);
            guna2HtmlLabel5.TabIndex = 11;
            guna2HtmlLabel5.Text = "New to Elicia's Garden?";
            guna2HtmlLabel5.Visible = false;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.Transparent;
            btnCreateAccount.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAccount.ForeColor = Color.FromArgb(98, 87, 87);
            btnCreateAccount.IsSelectionEnabled = false;
            btnCreateAccount.Location = new Point(260, 454);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(133, 20);
            btnCreateAccount.TabIndex = 12;
            btnCreateAccount.Text = "Create an Account";
            btnCreateAccount.Visible = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            btnCreateAccount.MouseEnter += btnCreateAccount_MouseEnter;
            btnCreateAccount.MouseLeave += btnCreateAccount_MouseLeave;
            // 
            // timer1
            // 
            timer1.Interval = 60;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold);
            label1.Location = new Point(112, 104);
            label1.Name = "label1";
            label1.Size = new Size(264, 28);
            label1.TabIndex = 13;
            label1.Text = "Elicia's Garden Food Park";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.Location = new Point(130, 141);
            label2.Name = "label2";
            label2.Size = new Size(228, 18);
            label2.TabIndex = 14;
            label2.Text = "POS And Inventory System";
            // 
            // btnSignIn
            // 
            btnSignIn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSignIn.BorderRadius = 5;
            btnSignIn.CustomizableEdges = customizableEdges13;
            btnSignIn.DisabledState.BorderColor = Color.DarkGray;
            btnSignIn.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSignIn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSignIn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSignIn.FillColor = Color.FromArgb(98, 87, 87);
            btnSignIn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(29, 183);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnSignIn.Size = new Size(380, 43);
            btnSignIn.TabIndex = 3;
            btnSignIn.Text = "Sign In";
            btnSignIn.Click += btnSignIn_Click;
            btnSignIn.KeyDown += btnSignIn_KeyDown;
            // 
            // cbRememberMe
            // 
            cbRememberMe.AutoSize = true;
            cbRememberMe.BackColor = Color.White;
            cbRememberMe.CheckedState.BorderColor = Color.FromArgb(98, 87, 87);
            cbRememberMe.CheckedState.BorderRadius = 0;
            cbRememberMe.CheckedState.BorderThickness = 0;
            cbRememberMe.CheckedState.FillColor = Color.FromArgb(98, 87, 87);
            cbRememberMe.ForeColor = Color.Black;
            cbRememberMe.Location = new Point(29, 232);
            cbRememberMe.Name = "cbRememberMe";
            cbRememberMe.Size = new Size(117, 20);
            cbRememberMe.TabIndex = 2;
            cbRememberMe.Text = "Remember Me";
            cbRememberMe.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cbRememberMe.UncheckedState.BorderRadius = 2;
            cbRememberMe.UncheckedState.BorderThickness = 1;
            cbRememberMe.UncheckedState.FillColor = Color.White;
            cbRememberMe.UseVisualStyleBackColor = false;
            cbRememberMe.Visible = false;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BorderColor = Color.Black;
            txtPassword.BorderRadius = 5;
            txtPassword.CustomizableEdges = customizableEdges15;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(98, 87, 87);
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.HoverState.BorderColor = Color.FromArgb(98, 87, 87);
            txtPassword.IconLeft = Properties.Resources.Key;
            txtPassword.IconLeftSize = new Size(25, 25);
            txtPassword.IconRight = Properties.Resources.Eye;
            txtPassword.IconRightSize = new Size(25, 25);
            txtPassword.Location = new Point(29, 124);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtPassword.Size = new Size(380, 43);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.IconRightClick += txtPassword_IconRightClick;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.BackgroundImageLayout = ImageLayout.Center;
            txtUsername.BorderColor = Color.Black;
            txtUsername.BorderRadius = 5;
            txtUsername.CustomizableEdges = customizableEdges17;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FocusedState.BorderColor = Color.FromArgb(98, 87, 87);
            txtUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.HoverState.BorderColor = Color.FromArgb(98, 87, 87);
            txtUsername.IconLeft = Properties.Resources.User;
            txtUsername.IconLeftSize = new Size(25, 25);
            txtUsername.Location = new Point(29, 68);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderText = "Username";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtUsername.Size = new Size(380, 43);
            txtUsername.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 18F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(62, 39, 35);
            label3.Location = new Point(97, 11);
            label3.Name = "label3";
            label3.Size = new Size(245, 29);
            label3.TabIndex = 15;
            label3.Text = "Sign In to Elicia's";
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel1.BorderRadius = 5;
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(txtUsername);
            guna2Panel1.Controls.Add(txtPassword);
            guna2Panel1.Controls.Add(cbRememberMe);
            guna2Panel1.Controls.Add(btnSignIn);
            guna2Panel1.CustomizableEdges = customizableEdges19;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(25, 187);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges20;
            guna2Panel1.Size = new Size(438, 264);
            guna2Panel1.TabIndex = 7;
            // 
            // btnForgotPass
            // 
            btnForgotPass.BackColor = Color.Transparent;
            btnForgotPass.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnForgotPass.ForeColor = Color.Black;
            btnForgotPass.IsSelectionEnabled = false;
            btnForgotPass.Location = new Point(201, 232);
            btnForgotPass.Name = "btnForgotPass";
            btnForgotPass.Size = new Size(117, 16);
            btnForgotPass.TabIndex = 3;
            btnForgotPass.Text = "Forgot Password?";
            btnForgotPass.Visible = false;
            btnForgotPass.MouseEnter += btnForgotPass_MouseEnter;
            btnForgotPass.MouseLeave += btnForgotPass_MouseLeave;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 521);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCreateAccount);
            Controls.Add(guna2HtmlLabel5);
            Controls.Add(pictureBox1);
            Controls.Add(guna2Panel2);
            Controls.Add(guna2Panel1);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += Login_FormClosing;
            Load += Login_Load;
            KeyDown += Login_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2Panel2.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel btnCreateAccount;
        private System.Windows.Forms.Timer timer1;
        private Label lblCredits;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSignIn;
        private Guna.UI2.WinForms.Guna2CheckBox cbRememberMe;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel btnForgotPass;
    }
}
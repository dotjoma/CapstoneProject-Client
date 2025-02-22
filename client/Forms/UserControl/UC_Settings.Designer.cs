namespace client.Forms.UserControll
{
    partial class UC_Settings
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnLogout = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BorderColor = Color.FromArgb(98, 87, 87);
            btnLogout.BorderThickness = 1;
            btnLogout.CustomizableEdges = customizableEdges1;
            btnLogout.DisabledState.BorderColor = Color.DarkGray;
            btnLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogout.FillColor = Color.FromArgb(214, 192, 179);
            btnLogout.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Black;
            btnLogout.Image = Properties.Resources.Logout;
            btnLogout.ImageSize = new Size(30, 30);
            btnLogout.Location = new Point(16, 18);
            btnLogout.Name = "btnLogout";
            btnLogout.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogout.Size = new Size(131, 45);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // UC_Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnLogout);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UC_Settings";
            Size = new Size(1444, 760);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnLogout;
    }
}

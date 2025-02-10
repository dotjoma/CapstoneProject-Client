namespace client.Forms.POS
{
    partial class POS_MainMenu
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS_MainMenu));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panel2 = new Panel();
            btnProducts = new Guna.UI2.WinForms.Guna2Button();
            btnOrders = new Guna.UI2.WinForms.Guna2Button();
            btnPos = new Guna.UI2.WinForms.Guna2Button();
            pnlContainer = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(98, 87, 87);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1444, 64);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnProducts);
            panel2.Controls.Add(btnOrders);
            panel2.Controls.Add(btnPos);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(89, 817);
            panel2.TabIndex = 4;
            // 
            // btnProducts
            // 
            btnProducts.CheckedState.BorderColor = Color.FromArgb(98, 87, 87);
            btnProducts.CheckedState.CustomBorderColor = Color.FromArgb(98, 87, 87);
            btnProducts.CheckedState.FillColor = Color.Transparent;
            btnProducts.CustomBorderThickness = new Padding(5, 0, 0, 0);
            btnProducts.CustomizableEdges = customizableEdges1;
            btnProducts.DisabledState.BorderColor = Color.DarkGray;
            btnProducts.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProducts.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProducts.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProducts.Dock = DockStyle.Top;
            btnProducts.FillColor = Color.Transparent;
            btnProducts.Font = new Font("Segoe UI", 9F);
            btnProducts.ForeColor = Color.White;
            btnProducts.HoverState.FillColor = Color.Transparent;
            btnProducts.Image = (Image)resources.GetObject("btnProducts.Image");
            btnProducts.ImageSize = new Size(35, 35);
            btnProducts.Location = new Point(0, 130);
            btnProducts.Name = "btnProducts";
            btnProducts.PressedColor = Color.Transparent;
            btnProducts.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnProducts.Size = new Size(89, 65);
            btnProducts.TabIndex = 7;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnOrders
            // 
            btnOrders.CheckedState.BorderColor = Color.FromArgb(98, 87, 87);
            btnOrders.CheckedState.CustomBorderColor = Color.FromArgb(98, 87, 87);
            btnOrders.CheckedState.FillColor = Color.Transparent;
            btnOrders.CustomBorderThickness = new Padding(5, 0, 0, 0);
            btnOrders.CustomizableEdges = customizableEdges3;
            btnOrders.DisabledState.BorderColor = Color.DarkGray;
            btnOrders.DisabledState.CustomBorderColor = Color.DarkGray;
            btnOrders.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnOrders.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnOrders.Dock = DockStyle.Top;
            btnOrders.FillColor = Color.Transparent;
            btnOrders.Font = new Font("Segoe UI", 9F);
            btnOrders.ForeColor = Color.White;
            btnOrders.HoverState.FillColor = Color.Transparent;
            btnOrders.Image = (Image)resources.GetObject("btnOrders.Image");
            btnOrders.ImageSize = new Size(35, 35);
            btnOrders.Location = new Point(0, 65);
            btnOrders.Name = "btnOrders";
            btnOrders.PressedColor = Color.Transparent;
            btnOrders.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnOrders.Size = new Size(89, 65);
            btnOrders.TabIndex = 6;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnPos
            // 
            btnPos.CheckedState.BorderColor = Color.FromArgb(98, 87, 87);
            btnPos.CheckedState.CustomBorderColor = Color.FromArgb(98, 87, 87);
            btnPos.CheckedState.FillColor = Color.Transparent;
            btnPos.CustomBorderThickness = new Padding(5, 0, 0, 0);
            btnPos.CustomizableEdges = customizableEdges5;
            btnPos.DisabledState.BorderColor = Color.DarkGray;
            btnPos.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPos.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPos.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPos.Dock = DockStyle.Top;
            btnPos.FillColor = Color.Transparent;
            btnPos.Font = new Font("Segoe UI", 9F);
            btnPos.ForeColor = Color.White;
            btnPos.HoverState.FillColor = Color.Transparent;
            btnPos.Image = (Image)resources.GetObject("btnPos.Image");
            btnPos.ImageSize = new Size(35, 35);
            btnPos.Location = new Point(0, 0);
            btnPos.Name = "btnPos";
            btnPos.PressedColor = Color.Transparent;
            btnPos.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnPos.Size = new Size(89, 65);
            btnPos.TabIndex = 5;
            btnPos.Click += btnPos_Click;
            // 
            // pnlContainer
            // 
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(89, 64);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1355, 817);
            pnlContainer.TabIndex = 5;
            // 
            // POS_MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1444, 881);
            Controls.Add(pnlContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "POS_MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            TopMost = true;
            Load += POS_MainMenu_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnPos;
        private Guna.UI2.WinForms.Guna2Button btnProducts;
        private Guna.UI2.WinForms.Guna2Button btnOrders;
        private Panel pnlContainer;
    }
}
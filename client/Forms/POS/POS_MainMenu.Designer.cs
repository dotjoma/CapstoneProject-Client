﻿namespace client.Forms.POS
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlHeader = new Panel();
            btnReturn = new Guna.UI2.WinForms.Guna2Button();
            btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            btnCloseWindow = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            btnProducts = new Guna.UI2.WinForms.Guna2Button();
            btnOrders = new Guna.UI2.WinForms.Guna2Button();
            btnPos = new Guna.UI2.WinForms.Guna2Button();
            pnlContainer = new Panel();
            pnlHeader.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(98, 87, 87);
            pnlHeader.Controls.Add(btnReturn);
            pnlHeader.Controls.Add(btnMinimize);
            pnlHeader.Controls.Add(btnCloseWindow);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1024, 64);
            pnlHeader.TabIndex = 3;
            pnlHeader.MouseDown += pnlHeader_MouseDown;
            pnlHeader.MouseMove += pnlHeader_MouseMove;
            pnlHeader.MouseUp += pnlHeader_MouseUp;
            // 
            // btnReturn
            // 
            btnReturn.CustomizableEdges = customizableEdges1;
            btnReturn.DisabledState.BorderColor = Color.DarkGray;
            btnReturn.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReturn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReturn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReturn.FillColor = Color.FromArgb(98, 87, 87);
            btnReturn.Font = new Font("Segoe UI", 9F);
            btnReturn.ForeColor = Color.White;
            btnReturn.Image = Properties.Resources.Left;
            btnReturn.ImageSize = new Size(30, 30);
            btnReturn.Location = new Point(23, 17);
            btnReturn.Name = "btnReturn";
            btnReturn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnReturn.Size = new Size(48, 30);
            btnReturn.TabIndex = 3;
            btnReturn.TextAlign = HorizontalAlignment.Left;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.CustomizableEdges = customizableEdges3;
            btnMinimize.DisabledState.BorderColor = Color.DarkGray;
            btnMinimize.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMinimize.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMinimize.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMinimize.FillColor = Color.FromArgb(98, 87, 87);
            btnMinimize.Font = new Font("Segoe UI", 9F);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Image = Properties.Resources.Minimize_Window;
            btnMinimize.ImageSize = new Size(30, 30);
            btnMinimize.Location = new Point(946, 17);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.TabIndex = 2;
            btnMinimize.TextAlign = HorizontalAlignment.Left;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnCloseWindow
            // 
            btnCloseWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseWindow.CustomizableEdges = customizableEdges5;
            btnCloseWindow.DisabledState.BorderColor = Color.DarkGray;
            btnCloseWindow.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCloseWindow.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCloseWindow.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCloseWindow.FillColor = Color.FromArgb(98, 87, 87);
            btnCloseWindow.Font = new Font("Segoe UI", 9F);
            btnCloseWindow.ForeColor = Color.White;
            btnCloseWindow.Image = Properties.Resources.Close_Window;
            btnCloseWindow.ImageSize = new Size(30, 30);
            btnCloseWindow.Location = new Point(982, 17);
            btnCloseWindow.Name = "btnCloseWindow";
            btnCloseWindow.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCloseWindow.Size = new Size(30, 30);
            btnCloseWindow.TabIndex = 1;
            btnCloseWindow.TextAlign = HorizontalAlignment.Left;
            btnCloseWindow.Click += btnCloseWindow_Click;
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
            panel2.Size = new Size(89, 704);
            panel2.TabIndex = 4;
            // 
            // btnProducts
            // 
            btnProducts.CheckedState.BorderColor = Color.FromArgb(98, 87, 87);
            btnProducts.CheckedState.CustomBorderColor = Color.FromArgb(98, 87, 87);
            btnProducts.CheckedState.FillColor = Color.Transparent;
            btnProducts.CustomBorderThickness = new Padding(5, 0, 0, 0);
            btnProducts.CustomizableEdges = customizableEdges7;
            btnProducts.DisabledState.BorderColor = Color.DarkGray;
            btnProducts.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProducts.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProducts.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProducts.Dock = DockStyle.Top;
            btnProducts.FillColor = Color.Transparent;
            btnProducts.Font = new Font("Segoe UI", 9F);
            btnProducts.ForeColor = Color.White;
            btnProducts.HoverState.FillColor = Color.Transparent;
            btnProducts.Image = Properties.Resources.Product;
            btnProducts.ImageSize = new Size(35, 35);
            btnProducts.Location = new Point(0, 130);
            btnProducts.Name = "btnProducts";
            btnProducts.PressedColor = Color.Transparent;
            btnProducts.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnProducts.Size = new Size(89, 65);
            btnProducts.TabIndex = 7;
            btnProducts.Visible = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnOrders
            // 
            btnOrders.CheckedState.BorderColor = Color.FromArgb(98, 87, 87);
            btnOrders.CheckedState.CustomBorderColor = Color.FromArgb(98, 87, 87);
            btnOrders.CheckedState.FillColor = Color.Transparent;
            btnOrders.CustomBorderThickness = new Padding(5, 0, 0, 0);
            btnOrders.CustomizableEdges = customizableEdges9;
            btnOrders.DisabledState.BorderColor = Color.DarkGray;
            btnOrders.DisabledState.CustomBorderColor = Color.DarkGray;
            btnOrders.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnOrders.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnOrders.Dock = DockStyle.Top;
            btnOrders.FillColor = Color.Transparent;
            btnOrders.Font = new Font("Segoe UI", 9F);
            btnOrders.ForeColor = Color.White;
            btnOrders.HoverState.FillColor = Color.Transparent;
            btnOrders.Image = Properties.Resources.List1;
            btnOrders.ImageSize = new Size(35, 35);
            btnOrders.Location = new Point(0, 65);
            btnOrders.Name = "btnOrders";
            btnOrders.PressedColor = Color.Transparent;
            btnOrders.ShadowDecoration.CustomizableEdges = customizableEdges10;
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
            btnPos.CustomizableEdges = customizableEdges11;
            btnPos.DisabledState.BorderColor = Color.DarkGray;
            btnPos.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPos.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPos.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPos.Dock = DockStyle.Top;
            btnPos.FillColor = Color.Transparent;
            btnPos.Font = new Font("Segoe UI", 9F);
            btnPos.ForeColor = Color.White;
            btnPos.HoverState.FillColor = Color.Transparent;
            btnPos.ImageSize = new Size(35, 35);
            btnPos.Location = new Point(0, 0);
            btnPos.Name = "btnPos";
            btnPos.PressedColor = Color.Transparent;
            btnPos.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnPos.Size = new Size(89, 65);
            btnPos.TabIndex = 5;
            btnPos.Click += btnPos_Click;
            // 
            // pnlContainer
            // 
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(89, 64);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(935, 704);
            pnlContainer.TabIndex = 5;
            // 
            // POS_MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 768);
            Controls.Add(pnlContainer);
            Controls.Add(panel2);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "POS_MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            TopMost = true;
            Load += POS_MainMenu_Load;
            pnlHeader.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlHeader;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnPos;
        private Guna.UI2.WinForms.Guna2Button btnProducts;
        private Guna.UI2.WinForms.Guna2Button btnOrders;
        private Panel pnlContainer;
        private Guna.UI2.WinForms.Guna2Button btnCloseWindow;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnReturn;
    }
}
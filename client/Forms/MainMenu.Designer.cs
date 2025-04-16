namespace client.Forms
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            tsSettings = new ToolStripMenuItem();
            tsLogout = new ToolStripMenuItem();
            tsExit = new ToolStripMenuItem();
            reservationToolStripMenuItem = new ToolStripMenuItem();
            newReservationToolStripMenuItem = new ToolStripMenuItem();
            viewReservationToolStripMenuItem = new ToolStripMenuItem();
            manageReservationToolStripMenuItem = new ToolStripMenuItem();
            reservationCalendarToolStripMenuItem = new ToolStripMenuItem();
            administrationToolStripMenuItem = new ToolStripMenuItem();
            categoryManagementToolStripMenuItem = new ToolStripMenuItem();
            discountManagementToolStripMenuItem = new ToolStripMenuItem();
            systemSettingsToolStripMenuItem = new ToolStripMenuItem();
            storeConfigurationToolStripMenuItem = new ToolStripMenuItem();
            taxSettingsToolStripMenuItem = new ToolStripMenuItem();
            paymentMethodsToolStripMenuItem = new ToolStripMenuItem();
            printerSetupToolStripMenuItem = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            msBackupControlPanel = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            bgwDashboard = new System.ComponentModel.BackgroundWorker();
            toolTip1 = new ToolTip(components);
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            lblUser = new Label();
            toolStrip1 = new ToolStrip();
            tlbDashboard = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbTransaction = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbManageMenu = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbManageInventory = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            tsbSalesReport = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            tsbBestSelling = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            tsbAuditTrial = new ToolStripButton();
            pnlContainer = new Panel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, reservationToolStripMenuItem, administrationToolStripMenuItem, refreshToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1352, 30);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsSettings, tsLogout, tsExit });
            fileToolStripMenuItem.ForeColor = Color.Black;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(55, 26);
            fileToolStripMenuItem.Text = "File";
            // 
            // tsSettings
            // 
            tsSettings.Name = "tsSettings";
            tsSettings.Size = new Size(167, 26);
            tsSettings.Text = "Settings";
            tsSettings.Click += tsSettings_Click;
            // 
            // tsLogout
            // 
            tsLogout.Name = "tsLogout";
            tsLogout.Size = new Size(167, 26);
            tsLogout.Text = "Logout";
            tsLogout.Click += tsLogout_Click;
            // 
            // tsExit
            // 
            tsExit.Name = "tsExit";
            tsExit.Size = new Size(167, 26);
            tsExit.Text = "Exit";
            tsExit.Click += tsExit_Click;
            // 
            // reservationToolStripMenuItem
            // 
            reservationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newReservationToolStripMenuItem, viewReservationToolStripMenuItem, manageReservationToolStripMenuItem, reservationCalendarToolStripMenuItem });
            reservationToolStripMenuItem.ForeColor = Color.Black;
            reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            reservationToolStripMenuItem.Size = new Size(141, 26);
            reservationToolStripMenuItem.Text = "Reservations";
            // 
            // newReservationToolStripMenuItem
            // 
            newReservationToolStripMenuItem.Name = "newReservationToolStripMenuItem";
            newReservationToolStripMenuItem.Size = new Size(289, 26);
            newReservationToolStripMenuItem.Text = "New Reservation";
            // 
            // viewReservationToolStripMenuItem
            // 
            viewReservationToolStripMenuItem.Name = "viewReservationToolStripMenuItem";
            viewReservationToolStripMenuItem.Size = new Size(289, 26);
            viewReservationToolStripMenuItem.Text = "View Reservations";
            // 
            // manageReservationToolStripMenuItem
            // 
            manageReservationToolStripMenuItem.Name = "manageReservationToolStripMenuItem";
            manageReservationToolStripMenuItem.Size = new Size(289, 26);
            manageReservationToolStripMenuItem.Text = "Manage Reservations";
            // 
            // reservationCalendarToolStripMenuItem
            // 
            reservationCalendarToolStripMenuItem.Name = "reservationCalendarToolStripMenuItem";
            reservationCalendarToolStripMenuItem.Size = new Size(289, 26);
            reservationCalendarToolStripMenuItem.Text = "Reservation Calendar";
            // 
            // administrationToolStripMenuItem
            // 
            administrationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoryManagementToolStripMenuItem, discountManagementToolStripMenuItem, systemSettingsToolStripMenuItem, msBackupControlPanel });
            administrationToolStripMenuItem.ForeColor = Color.Black;
            administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            administrationToolStripMenuItem.Size = new Size(155, 26);
            administrationToolStripMenuItem.Text = "Administration";
            // 
            // categoryManagementToolStripMenuItem
            // 
            categoryManagementToolStripMenuItem.Name = "categoryManagementToolStripMenuItem";
            categoryManagementToolStripMenuItem.Size = new Size(286, 26);
            categoryManagementToolStripMenuItem.Text = "Manage Category";
            // 
            // discountManagementToolStripMenuItem
            // 
            discountManagementToolStripMenuItem.Name = "discountManagementToolStripMenuItem";
            discountManagementToolStripMenuItem.Size = new Size(286, 26);
            discountManagementToolStripMenuItem.Text = "Manage Discounts";
            discountManagementToolStripMenuItem.Click += discountManagementToolStripMenuItem_Click;
            // 
            // systemSettingsToolStripMenuItem
            // 
            systemSettingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { storeConfigurationToolStripMenuItem, taxSettingsToolStripMenuItem, paymentMethodsToolStripMenuItem, printerSetupToolStripMenuItem, themeToolStripMenuItem });
            systemSettingsToolStripMenuItem.Name = "systemSettingsToolStripMenuItem";
            systemSettingsToolStripMenuItem.Size = new Size(286, 26);
            systemSettingsToolStripMenuItem.Text = "System Settings";
            // 
            // storeConfigurationToolStripMenuItem
            // 
            storeConfigurationToolStripMenuItem.Name = "storeConfigurationToolStripMenuItem";
            storeConfigurationToolStripMenuItem.Size = new Size(270, 26);
            storeConfigurationToolStripMenuItem.Text = "Store Configuration";
            // 
            // taxSettingsToolStripMenuItem
            // 
            taxSettingsToolStripMenuItem.Name = "taxSettingsToolStripMenuItem";
            taxSettingsToolStripMenuItem.Size = new Size(270, 26);
            taxSettingsToolStripMenuItem.Text = "Tax Settings";
            // 
            // paymentMethodsToolStripMenuItem
            // 
            paymentMethodsToolStripMenuItem.Name = "paymentMethodsToolStripMenuItem";
            paymentMethodsToolStripMenuItem.Size = new Size(270, 26);
            paymentMethodsToolStripMenuItem.Text = "Payment Methods";
            // 
            // printerSetupToolStripMenuItem
            // 
            printerSetupToolStripMenuItem.Name = "printerSetupToolStripMenuItem";
            printerSetupToolStripMenuItem.Size = new Size(270, 26);
            printerSetupToolStripMenuItem.Text = "Printer Setup";
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(270, 26);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // msBackupControlPanel
            // 
            msBackupControlPanel.Name = "msBackupControlPanel";
            msBackupControlPanel.Size = new Size(286, 26);
            msBackupControlPanel.Text = "Backup Control Panel";
            msBackupControlPanel.Click += msBackupControlPanel_Click;
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.ForeColor = Color.Black;
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(93, 26);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.ForeColor = Color.Black;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 26);
            helpToolStripMenuItem.Text = "Help";
            // 
            // bgwDashboard
            // 
            bgwDashboard.DoWork += bgwDashboard_DoWork;
            bgwDashboard.RunWorkerCompleted += bgwDashboard_RunWorkerCompleted;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 100;
            toolTip1.Tag = "";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(121, 85, 72);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblUser);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 627);
            panel2.Name = "panel2";
            panel2.Size = new Size(1352, 34);
            panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Left;
            pictureBox2.Image = Properties.Resources.Name;
            pictureBox2.Location = new Point(3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(36, 9);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(45, 20);
            lblUser.TabIndex = 0;
            lblUser.Text = "- - -";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ControlLight;
            toolStrip1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tlbDashboard, toolStripSeparator1, tsbTransaction, toolStripSeparator2, tsbManageMenu, toolStripSeparator3, tsbManageInventory, toolStripSeparator6, toolStripButton1, toolStripSeparator7, tsbSalesReport, toolStripSeparator4, tsbBestSelling, toolStripSeparator5, tsbAuditTrial });
            toolStrip1.Location = new Point(0, 30);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1352, 77);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tlbDashboard
            // 
            tlbDashboard.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tlbDashboard.ForeColor = Color.FromArgb(62, 39, 35);
            tlbDashboard.Image = Properties.Resources.Control_PanelDB;
            tlbDashboard.ImageScaling = ToolStripItemImageScaling.None;
            tlbDashboard.ImageTransparentColor = Color.Magenta;
            tlbDashboard.Name = "tlbDashboard";
            tlbDashboard.Size = new Size(133, 74);
            tlbDashboard.Text = "DASHBOARD";
            tlbDashboard.TextAlign = ContentAlignment.BottomCenter;
            tlbDashboard.TextImageRelation = TextImageRelation.ImageAboveText;
            tlbDashboard.Click += tlbDashboard_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 77);
            // 
            // tsbTransaction
            // 
            tsbTransaction.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsbTransaction.ForeColor = Color.FromArgb(62, 39, 35);
            tsbTransaction.Image = Properties.Resources.Cash_RegisterDB;
            tsbTransaction.ImageScaling = ToolStripItemImageScaling.None;
            tsbTransaction.ImageTransparentColor = Color.Magenta;
            tsbTransaction.Name = "tsbTransaction";
            tsbTransaction.Size = new Size(151, 74);
            tsbTransaction.Text = "TRANSACTION";
            tsbTransaction.TextAlign = ContentAlignment.BottomCenter;
            tsbTransaction.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbTransaction.Click += tsbTransaction_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 77);
            // 
            // tsbManageMenu
            // 
            tsbManageMenu.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsbManageMenu.ForeColor = Color.FromArgb(62, 39, 35);
            tsbManageMenu.Image = Properties.Resources.RestaurantMenu;
            tsbManageMenu.ImageScaling = ToolStripItemImageScaling.None;
            tsbManageMenu.ImageTransparentColor = Color.Magenta;
            tsbManageMenu.Name = "tsbManageMenu";
            tsbManageMenu.Size = new Size(157, 74);
            tsbManageMenu.Text = "MANAGE MENU";
            tsbManageMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbManageMenu.Click += tsbManageMenu_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 77);
            // 
            // tsbManageInventory
            // 
            tsbManageInventory.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsbManageInventory.ForeColor = Color.FromArgb(62, 39, 35);
            tsbManageInventory.Image = Properties.Resources.inventory_501;
            tsbManageInventory.ImageScaling = ToolStripItemImageScaling.None;
            tsbManageInventory.ImageTransparentColor = Color.Magenta;
            tsbManageInventory.Name = "tsbManageInventory";
            tsbManageInventory.Size = new Size(215, 74);
            tsbManageInventory.Text = "MANAGE INVENTORY";
            tsbManageInventory.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbManageInventory.Click += tsbManageInventory_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 77);
            // 
            // toolStripButton1
            // 
            toolStripButton1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripButton1.ForeColor = Color.FromArgb(62, 39, 35);
            toolStripButton1.Image = Properties.Resources.manage_user1;
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(152, 74);
            toolStripButton1.Text = "MANAGE USER";
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton1.ToolTipText = "Audit Trail";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 77);
            // 
            // tsbSalesReport
            // 
            tsbSalesReport.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsbSalesReport.ForeColor = Color.FromArgb(62, 39, 35);
            tsbSalesReport.Image = Properties.Resources.Health_Graph2;
            tsbSalesReport.ImageScaling = ToolStripItemImageScaling.None;
            tsbSalesReport.ImageTransparentColor = Color.Magenta;
            tsbSalesReport.Name = "tsbSalesReport";
            tsbSalesReport.Size = new Size(155, 74);
            tsbSalesReport.Text = "SALES REPORT";
            tsbSalesReport.TextAlign = ContentAlignment.BottomCenter;
            tsbSalesReport.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalesReport.Click += tsbSalesReport_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 77);
            // 
            // tsbBestSelling
            // 
            tsbBestSelling.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsbBestSelling.ForeColor = Color.FromArgb(62, 39, 35);
            tsbBestSelling.Image = Properties.Resources.Best_Seller1;
            tsbBestSelling.ImageScaling = ToolStripItemImageScaling.None;
            tsbBestSelling.ImageTransparentColor = Color.Magenta;
            tsbBestSelling.Name = "tsbBestSelling";
            tsbBestSelling.Size = new Size(151, 74);
            tsbBestSelling.Text = "BEST SELLING";
            tsbBestSelling.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBestSelling.Click += tsbBestSelling_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 77);
            // 
            // tsbAuditTrial
            // 
            tsbAuditTrial.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsbAuditTrial.ForeColor = Color.FromArgb(62, 39, 35);
            tsbAuditTrial.Image = Properties.Resources.Audit2;
            tsbAuditTrial.ImageScaling = ToolStripItemImageScaling.None;
            tsbAuditTrial.ImageTransparentColor = Color.Magenta;
            tsbAuditTrial.Name = "tsbAuditTrial";
            tsbAuditTrial.Size = new Size(139, 74);
            tsbAuditTrial.Text = "AUDIT TRAIL";
            tsbAuditTrial.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbAuditTrial.ToolTipText = "Audit Trail";
            tsbAuditTrial.Click += tsbAuditTrial_Click;
            // 
            // pnlContainer
            // 
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 107);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1352, 520);
            pnlContainer.TabIndex = 9;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1352, 661);
            Controls.Add(pnlContainer);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(panel2);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ELICIA'S GARDEN FOOD PARK";
            FormClosing += MainMenu_FormClosing;
            Shown += MainMenu_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker bgwDashboard;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem tsSettings;
        private ToolStripMenuItem tsLogout;
        private ToolStripMenuItem tsExit;
        private ToolStripMenuItem reservationToolStripMenuItem;
        private ToolStripMenuItem newReservationToolStripMenuItem;
        private ToolStripMenuItem viewReservationToolStripMenuItem;
        private ToolStripMenuItem manageReservationToolStripMenuItem;
        private ToolStripMenuItem reservationCalendarToolStripMenuItem;
        private ToolStripMenuItem administrationToolStripMenuItem;
        private ToolStripMenuItem systemSettingsToolStripMenuItem;
        private ToolStripMenuItem storeConfigurationToolStripMenuItem;
        private ToolStripMenuItem taxSettingsToolStripMenuItem;
        private ToolStripMenuItem paymentMethodsToolStripMenuItem;
        private ToolStripMenuItem printerSetupToolStripMenuItem;
        private ToolStripMenuItem msBackupControlPanel;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolTip toolTip1;
        private Panel panel2;
        private Label lblUser;
        private ToolStripMenuItem categoryManagementToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbTransaction;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tlbDashboard;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbAuditTrial;
        private Panel pnlContainer;
        private ToolStripButton tsbSalesReport;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton tsbManageInventory;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton tsbBestSelling;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton tsbManageMenu;
        private ToolStripMenuItem discountManagementToolStripMenuItem;
        private ToolStripMenuItem themeToolStripMenuItem;
        private PictureBox pictureBox2;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator7;
    }
}
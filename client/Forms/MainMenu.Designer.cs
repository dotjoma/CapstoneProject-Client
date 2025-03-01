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
            viewToolStripMenuItem = new ToolStripMenuItem();
            reservationToolStripMenuItem = new ToolStripMenuItem();
            newReservationToolStripMenuItem = new ToolStripMenuItem();
            viewReservationToolStripMenuItem = new ToolStripMenuItem();
            manageReservationToolStripMenuItem = new ToolStripMenuItem();
            reservationCalendarToolStripMenuItem = new ToolStripMenuItem();
            administrationToolStripMenuItem = new ToolStripMenuItem();
            userManagementToolStripMenuItem = new ToolStripMenuItem();
            createNewUserToolStripMenuItem = new ToolStripMenuItem();
            manageUserRolesToolStripMenuItem = new ToolStripMenuItem();
            categoryManagementToolStripMenuItem = new ToolStripMenuItem();
            createEditDeleteCategoriesToolStripMenuItem = new ToolStripMenuItem();
            subcategoriesSupportToolStripMenuItem = new ToolStripMenuItem();
            assignProductsToCategoriesToolStripMenuItem = new ToolStripMenuItem();
            categoryAvailabilityToggleToolStripMenuItem = new ToolStripMenuItem();
            systemSettingsToolStripMenuItem = new ToolStripMenuItem();
            storeConfigurationToolStripMenuItem = new ToolStripMenuItem();
            taxSettingsToolStripMenuItem = new ToolStripMenuItem();
            paymentMethodsToolStripMenuItem = new ToolStripMenuItem();
            printerSetupToolStripMenuItem = new ToolStripMenuItem();
            databaseToolStripMenuItem = new ToolStripMenuItem();
            backupDatabaseToolStripMenuItem = new ToolStripMenuItem();
            restoreDatabaseToolStripMenuItem = new ToolStripMenuItem();
            clearTransactionLogsToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            bgwDashboard = new System.ComponentModel.BackgroundWorker();
            toolTip1 = new ToolTip(components);
            panel2 = new Panel();
            lblUser = new Label();
            toolStrip1 = new ToolStrip();
            tlbDashboard = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbTransaction = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            tsbSalesReport = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            pnlContainer = new Panel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, reservationToolStripMenuItem, administrationToolStripMenuItem, refreshToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1024, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsSettings, tsLogout, tsExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(41, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // tsSettings
            // 
            tsSettings.Name = "tsSettings";
            tsSettings.Size = new Size(129, 22);
            tsSettings.Text = "Settings";
            tsSettings.Click += tsSettings_Click;
            // 
            // tsLogout
            // 
            tsLogout.Name = "tsLogout";
            tsLogout.Size = new Size(129, 22);
            tsLogout.Text = "Logout";
            tsLogout.Click += tsLogout_Click;
            // 
            // tsExit
            // 
            tsExit.Name = "tsExit";
            tsExit.Size = new Size(129, 22);
            tsExit.Text = "Exit";
            tsExit.Click += tsExit_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(50, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // reservationToolStripMenuItem
            // 
            reservationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newReservationToolStripMenuItem, viewReservationToolStripMenuItem, manageReservationToolStripMenuItem, reservationCalendarToolStripMenuItem });
            reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            reservationToolStripMenuItem.Size = new Size(103, 20);
            reservationToolStripMenuItem.Text = "Reservations";
            // 
            // newReservationToolStripMenuItem
            // 
            newReservationToolStripMenuItem.Name = "newReservationToolStripMenuItem";
            newReservationToolStripMenuItem.Size = new Size(214, 22);
            newReservationToolStripMenuItem.Text = "New Reservation";
            // 
            // viewReservationToolStripMenuItem
            // 
            viewReservationToolStripMenuItem.Name = "viewReservationToolStripMenuItem";
            viewReservationToolStripMenuItem.Size = new Size(214, 22);
            viewReservationToolStripMenuItem.Text = "View Reservations";
            // 
            // manageReservationToolStripMenuItem
            // 
            manageReservationToolStripMenuItem.Name = "manageReservationToolStripMenuItem";
            manageReservationToolStripMenuItem.Size = new Size(214, 22);
            manageReservationToolStripMenuItem.Text = "Manage Reservations";
            // 
            // reservationCalendarToolStripMenuItem
            // 
            reservationCalendarToolStripMenuItem.Name = "reservationCalendarToolStripMenuItem";
            reservationCalendarToolStripMenuItem.Size = new Size(214, 22);
            reservationCalendarToolStripMenuItem.Text = "Reservation Calendar";
            // 
            // administrationToolStripMenuItem
            // 
            administrationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userManagementToolStripMenuItem, categoryManagementToolStripMenuItem, systemSettingsToolStripMenuItem, databaseToolStripMenuItem });
            administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            administrationToolStripMenuItem.Size = new Size(112, 20);
            administrationToolStripMenuItem.Text = "Administration";
            // 
            // userManagementToolStripMenuItem
            // 
            userManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createNewUserToolStripMenuItem, manageUserRolesToolStripMenuItem });
            userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            userManagementToolStripMenuItem.Size = new Size(223, 22);
            userManagementToolStripMenuItem.Text = "User Management";
            // 
            // createNewUserToolStripMenuItem
            // 
            createNewUserToolStripMenuItem.Name = "createNewUserToolStripMenuItem";
            createNewUserToolStripMenuItem.Size = new Size(198, 22);
            createNewUserToolStripMenuItem.Text = "Create New User";
            // 
            // manageUserRolesToolStripMenuItem
            // 
            manageUserRolesToolStripMenuItem.Name = "manageUserRolesToolStripMenuItem";
            manageUserRolesToolStripMenuItem.Size = new Size(198, 22);
            manageUserRolesToolStripMenuItem.Text = "Manage User Roles";
            // 
            // categoryManagementToolStripMenuItem
            // 
            categoryManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createEditDeleteCategoriesToolStripMenuItem, subcategoriesSupportToolStripMenuItem, assignProductsToCategoriesToolStripMenuItem, categoryAvailabilityToggleToolStripMenuItem });
            categoryManagementToolStripMenuItem.Name = "categoryManagementToolStripMenuItem";
            categoryManagementToolStripMenuItem.Size = new Size(223, 22);
            categoryManagementToolStripMenuItem.Text = "Category Management";
            // 
            // createEditDeleteCategoriesToolStripMenuItem
            // 
            createEditDeleteCategoriesToolStripMenuItem.Name = "createEditDeleteCategoriesToolStripMenuItem";
            createEditDeleteCategoriesToolStripMenuItem.Size = new Size(273, 22);
            createEditDeleteCategoriesToolStripMenuItem.Text = "Create/Edit/Delete Categories";
            // 
            // subcategoriesSupportToolStripMenuItem
            // 
            subcategoriesSupportToolStripMenuItem.Name = "subcategoriesSupportToolStripMenuItem";
            subcategoriesSupportToolStripMenuItem.Size = new Size(273, 22);
            subcategoriesSupportToolStripMenuItem.Text = "Subcategories Support";
            // 
            // assignProductsToCategoriesToolStripMenuItem
            // 
            assignProductsToCategoriesToolStripMenuItem.Name = "assignProductsToCategoriesToolStripMenuItem";
            assignProductsToCategoriesToolStripMenuItem.Size = new Size(273, 22);
            assignProductsToCategoriesToolStripMenuItem.Text = "Assign Products to Categories";
            // 
            // categoryAvailabilityToggleToolStripMenuItem
            // 
            categoryAvailabilityToggleToolStripMenuItem.Name = "categoryAvailabilityToggleToolStripMenuItem";
            categoryAvailabilityToggleToolStripMenuItem.Size = new Size(273, 22);
            categoryAvailabilityToggleToolStripMenuItem.Text = "Category Availability Toggle";
            // 
            // systemSettingsToolStripMenuItem
            // 
            systemSettingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { storeConfigurationToolStripMenuItem, taxSettingsToolStripMenuItem, paymentMethodsToolStripMenuItem, printerSetupToolStripMenuItem });
            systemSettingsToolStripMenuItem.Name = "systemSettingsToolStripMenuItem";
            systemSettingsToolStripMenuItem.Size = new Size(223, 22);
            systemSettingsToolStripMenuItem.Text = "System Settings";
            // 
            // storeConfigurationToolStripMenuItem
            // 
            storeConfigurationToolStripMenuItem.Name = "storeConfigurationToolStripMenuItem";
            storeConfigurationToolStripMenuItem.Size = new Size(202, 22);
            storeConfigurationToolStripMenuItem.Text = "Store Configuration";
            // 
            // taxSettingsToolStripMenuItem
            // 
            taxSettingsToolStripMenuItem.Name = "taxSettingsToolStripMenuItem";
            taxSettingsToolStripMenuItem.Size = new Size(202, 22);
            taxSettingsToolStripMenuItem.Text = "Tax Settings";
            // 
            // paymentMethodsToolStripMenuItem
            // 
            paymentMethodsToolStripMenuItem.Name = "paymentMethodsToolStripMenuItem";
            paymentMethodsToolStripMenuItem.Size = new Size(202, 22);
            paymentMethodsToolStripMenuItem.Text = "Payment Methods";
            // 
            // printerSetupToolStripMenuItem
            // 
            printerSetupToolStripMenuItem.Name = "printerSetupToolStripMenuItem";
            printerSetupToolStripMenuItem.Size = new Size(202, 22);
            printerSetupToolStripMenuItem.Text = "Printer Setup";
            // 
            // databaseToolStripMenuItem
            // 
            databaseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { backupDatabaseToolStripMenuItem, restoreDatabaseToolStripMenuItem, clearTransactionLogsToolStripMenuItem });
            databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            databaseToolStripMenuItem.Size = new Size(223, 22);
            databaseToolStripMenuItem.Text = "Database";
            // 
            // backupDatabaseToolStripMenuItem
            // 
            backupDatabaseToolStripMenuItem.Name = "backupDatabaseToolStripMenuItem";
            backupDatabaseToolStripMenuItem.Size = new Size(224, 22);
            backupDatabaseToolStripMenuItem.Text = "Backup Database";
            // 
            // restoreDatabaseToolStripMenuItem
            // 
            restoreDatabaseToolStripMenuItem.Name = "restoreDatabaseToolStripMenuItem";
            restoreDatabaseToolStripMenuItem.Size = new Size(224, 22);
            restoreDatabaseToolStripMenuItem.Text = "Restore Database";
            // 
            // clearTransactionLogsToolStripMenuItem
            // 
            clearTransactionLogsToolStripMenuItem.Name = "clearTransactionLogsToolStripMenuItem";
            clearTransactionLogsToolStripMenuItem.Size = new Size(224, 22);
            clearTransactionLogsToolStripMenuItem.Text = "Clear Transaction Logs";
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(68, 20);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(47, 20);
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
            panel2.BackColor = Color.FromArgb(98, 87, 87);
            panel2.Controls.Add(lblUser);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 627);
            panel2.Name = "panel2";
            panel2.Size = new Size(1024, 34);
            panel2.TabIndex = 3;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.ForeColor = Color.FromArgb(214, 192, 179);
            lblUser.Location = new Point(12, 9);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(38, 16);
            lblUser.TabIndex = 0;
            lblUser.Text = "- - -";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Gainsboro;
            toolStrip1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tlbDashboard, toolStripSeparator1, tsbTransaction, toolStripSeparator2, toolStripButton4, toolStripSeparator3, toolStripButton2, toolStripSeparator6, tsbSalesReport, toolStripSeparator4, toolStripButton3, toolStripSeparator5, toolStripButton1 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1024, 73);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tlbDashboard
            // 
            tlbDashboard.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tlbDashboard.ForeColor = Color.FromArgb(98, 87, 87);
            tlbDashboard.Image = Properties.Resources.Control_Panel;
            tlbDashboard.ImageScaling = ToolStripItemImageScaling.None;
            tlbDashboard.ImageTransparentColor = Color.Magenta;
            tlbDashboard.Name = "tlbDashboard";
            tlbDashboard.Size = new Size(101, 70);
            tlbDashboard.Text = "DASHBOARD";
            tlbDashboard.TextAlign = ContentAlignment.BottomCenter;
            tlbDashboard.TextImageRelation = TextImageRelation.ImageAboveText;
            tlbDashboard.Click += tlbDashboard_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 73);
            // 
            // tsbTransaction
            // 
            tsbTransaction.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsbTransaction.ForeColor = Color.FromArgb(98, 87, 87);
            tsbTransaction.Image = Properties.Resources.Cash_Register_outlined;
            tsbTransaction.ImageScaling = ToolStripItemImageScaling.None;
            tsbTransaction.ImageTransparentColor = Color.Magenta;
            tsbTransaction.Name = "tsbTransaction";
            tsbTransaction.Size = new Size(112, 70);
            tsbTransaction.Text = "TRANSACTION";
            tsbTransaction.TextAlign = ContentAlignment.BottomCenter;
            tsbTransaction.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbTransaction.Click += tsbTransaction_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 73);
            // 
            // toolStripButton4
            // 
            toolStripButton4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripButton4.ForeColor = Color.FromArgb(98, 87, 87);
            toolStripButton4.Image = Properties.Resources.Restaurant_Menu;
            toolStripButton4.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(117, 70);
            toolStripButton4.Text = "MANAGE MENU";
            toolStripButton4.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 73);
            // 
            // toolStripButton2
            // 
            toolStripButton2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripButton2.ForeColor = Color.FromArgb(98, 87, 87);
            toolStripButton2.Image = Properties.Resources.Product;
            toolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(159, 70);
            toolStripButton2.Text = "MANAGE INVENTORY";
            toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 73);
            // 
            // tsbSalesReport
            // 
            tsbSalesReport.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsbSalesReport.ForeColor = Color.FromArgb(98, 87, 87);
            tsbSalesReport.Image = Properties.Resources.Health_Graph;
            tsbSalesReport.ImageScaling = ToolStripItemImageScaling.None;
            tsbSalesReport.ImageTransparentColor = Color.Magenta;
            tsbSalesReport.Name = "tsbSalesReport";
            tsbSalesReport.Size = new Size(115, 70);
            tsbSalesReport.Text = "SALES REPORT";
            tsbSalesReport.TextAlign = ContentAlignment.BottomCenter;
            tsbSalesReport.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 73);
            // 
            // toolStripButton3
            // 
            toolStripButton3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripButton3.ForeColor = Color.FromArgb(98, 87, 87);
            toolStripButton3.Image = Properties.Resources.Best_Seller;
            toolStripButton3.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(111, 70);
            toolStripButton3.Text = "BEST SELLING";
            toolStripButton3.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 73);
            // 
            // toolStripButton1
            // 
            toolStripButton1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripButton1.ForeColor = Color.FromArgb(98, 87, 87);
            toolStripButton1.Image = Properties.Resources.Audit;
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(100, 70);
            toolStripButton1.Text = "AUDIT TRAIL";
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton1.ToolTipText = "Audit Trail";
            // 
            // pnlContainer
            // 
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 97);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1024, 530);
            pnlContainer.TabIndex = 9;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1024, 661);
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
        private ToolStripMenuItem userManagementToolStripMenuItem;
        private ToolStripMenuItem createNewUserToolStripMenuItem;
        private ToolStripMenuItem manageUserRolesToolStripMenuItem;
        private ToolStripMenuItem systemSettingsToolStripMenuItem;
        private ToolStripMenuItem storeConfigurationToolStripMenuItem;
        private ToolStripMenuItem taxSettingsToolStripMenuItem;
        private ToolStripMenuItem paymentMethodsToolStripMenuItem;
        private ToolStripMenuItem printerSetupToolStripMenuItem;
        private ToolStripMenuItem databaseToolStripMenuItem;
        private ToolStripMenuItem backupDatabaseToolStripMenuItem;
        private ToolStripMenuItem restoreDatabaseToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem clearTransactionLogsToolStripMenuItem;
        private ToolTip toolTip1;
        private Panel panel2;
        private Label lblUser;
        private ToolStripMenuItem categoryManagementToolStripMenuItem;
        private ToolStripMenuItem createEditDeleteCategoriesToolStripMenuItem;
        private ToolStripMenuItem subcategoriesSupportToolStripMenuItem;
        private ToolStripMenuItem assignProductsToCategoriesToolStripMenuItem;
        private ToolStripMenuItem categoryAvailabilityToggleToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbTransaction;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tlbDashboard;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton1;
        private Panel pnlContainer;
        private ToolStripButton tsbSalesReport;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolStripButton4;
        private ToolStripMenuItem viewToolStripMenuItem;
    }
}
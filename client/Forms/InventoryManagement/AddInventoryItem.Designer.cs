namespace client.Forms.InventoryManagement
{
    partial class AddInventoryItem
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
            lblTitle = new Label();
            lblItemName = new Label();
            txtItemName = new TextBox();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            lblQuantity = new Label();
            lblMinStock = new Label();
            lblUnitType = new Label();
            txtMaximumStock = new TextBox();
            lblMaxStock = new Label();
            label11 = new Label();
            label14 = new Label();
            txtBatchNumber = new TextBox();
            label15 = new Label();
            lblPurchaseDate = new Label();
            dtpPurchase = new DateTimePicker();
            dtpExpiration = new DateTimePicker();
            lblExpirationDate = new Label();
            txtBatchQuantity = new TextBox();
            txtMinimumStock = new TextBox();
            cboUnitType = new ComboBox();
            cboUnitMeasure = new ComboBox();
            lblMeasure = new Label();
            txtRestorePoint = new TextBox();
            lblReorder = new Label();
            txtLeadTime = new TextBox();
            lblLeadTime = new Label();
            txtTargetTurnover = new TextBox();
            lblTurnover = new Label();
            lblCost = new Label();
            lblSupplier = new Label();
            pnlHeader = new Panel();
            cboSubcategory = new ComboBox();
            lblSubcateogry = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            btnSaveAndNew = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            txtCurrentQuantity = new TextBox();
            lblCurrentQuantity = new Label();
            panel5 = new Panel();
            cboSupplier = new ComboBox();
            txtUnitCost = new TextBox();
            cbLowStockAlerts = new CheckBox();
            pnlHeader.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Left;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.FromArgb(121, 85, 72);
            lblTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(13, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(358, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Inventory Management - Add New Item";
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.BackColor = Color.White;
            lblItemName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblItemName.Location = new Point(13, 82);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(98, 21);
            lblItemName.TabIndex = 17;
            lblItemName.Text = "Item Name*";
            // 
            // txtItemName
            // 
            txtItemName.BackColor = Color.FromArgb(232, 232, 232);
            txtItemName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtItemName.Location = new Point(13, 107);
            txtItemName.Margin = new Padding(3, 2, 3, 2);
            txtItemName.Name = "txtItemName";
            txtItemName.PlaceholderText = "Enter item name";
            txtItemName.Size = new Size(259, 26);
            txtItemName.TabIndex = 0;
            txtItemName.TextChanged += txtItemName_TextChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.White;
            lblCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCategory.Location = new Point(312, 82);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(85, 21);
            lblCategory.TabIndex = 21;
            lblCategory.Text = "Category*";
            // 
            // cboCategory
            // 
            cboCategory.BackColor = Color.FromArgb(232, 232, 232);
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Font = new Font("Segoe UI", 10.2F);
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(312, 107);
            cboCategory.Margin = new Padding(3, 2, 3, 2);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(197, 27);
            cboCategory.TabIndex = 1;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label5.Location = new Point(13, 51);
            label5.Name = "label5";
            label5.Size = new Size(169, 24);
            label5.TabIndex = 24;
            label5.Text = "Basic Information";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label6.Location = new Point(13, 248);
            label6.Name = "label6";
            label6.Size = new Size(197, 24);
            label6.TabIndex = 25;
            label6.Text = "Quantity && Inventory";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.White;
            lblQuantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(13, 278);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(123, 21);
            lblQuantity.TabIndex = 26;
            lblQuantity.Text = "Initial Quantity*";
            // 
            // lblMinStock
            // 
            lblMinStock.AutoSize = true;
            lblMinStock.BackColor = Color.White;
            lblMinStock.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblMinStock.Location = new Point(13, 332);
            lblMinStock.Name = "lblMinStock";
            lblMinStock.Size = new Size(168, 21);
            lblMinStock.TabIndex = 28;
            lblMinStock.Text = "Minimun Stock Level*";
            // 
            // lblUnitType
            // 
            lblUnitType.AutoSize = true;
            lblUnitType.BackColor = Color.White;
            lblUnitType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnitType.Location = new Point(312, 278);
            lblUnitType.Name = "lblUnitType";
            lblUnitType.Size = new Size(86, 21);
            lblUnitType.TabIndex = 30;
            lblUnitType.Text = "Unit Type*";
            // 
            // txtMaximumStock
            // 
            txtMaximumStock.BackColor = Color.FromArgb(232, 232, 232);
            txtMaximumStock.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaximumStock.Location = new Point(314, 358);
            txtMaximumStock.Margin = new Padding(3, 2, 3, 2);
            txtMaximumStock.Name = "txtMaximumStock";
            txtMaximumStock.PlaceholderText = "0.00";
            txtMaximumStock.Size = new Size(195, 26);
            txtMaximumStock.TabIndex = 10;
            txtMaximumStock.TextAlign = HorizontalAlignment.Right;
            txtMaximumStock.Click += txtMaximumStock_Click;
            // 
            // lblMaxStock
            // 
            lblMaxStock.AutoSize = true;
            lblMaxStock.BackColor = Color.White;
            lblMaxStock.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaxStock.Location = new Point(312, 332);
            lblMaxStock.Name = "lblMaxStock";
            lblMaxStock.Size = new Size(176, 21);
            lblMaxStock.TabIndex = 32;
            lblMaxStock.Text = "Maximum Stock Level*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label11.Location = new Point(10, 458);
            label11.Name = "label11";
            label11.Size = new Size(142, 24);
            label11.TabIndex = 34;
            label11.Text = "Cost && Pricing";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label14.Location = new Point(13, 158);
            label14.Name = "label14";
            label14.Size = new Size(171, 24);
            label14.TabIndex = 39;
            label14.Text = "Batch Information";
            // 
            // txtBatchNumber
            // 
            txtBatchNumber.BackColor = Color.FromArgb(232, 232, 232);
            txtBatchNumber.Enabled = false;
            txtBatchNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBatchNumber.Location = new Point(13, 208);
            txtBatchNumber.Margin = new Padding(3, 2, 3, 2);
            txtBatchNumber.Name = "txtBatchNumber";
            txtBatchNumber.PlaceholderText = "Enter batch number";
            txtBatchNumber.Size = new Size(259, 26);
            txtBatchNumber.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.Location = new Point(13, 183);
            label15.Name = "label15";
            label15.Size = new Size(115, 21);
            label15.TabIndex = 40;
            label15.Text = "Batch Number";
            // 
            // lblPurchaseDate
            // 
            lblPurchaseDate.AutoSize = true;
            lblPurchaseDate.BackColor = Color.White;
            lblPurchaseDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPurchaseDate.Location = new Point(312, 183);
            lblPurchaseDate.Name = "lblPurchaseDate";
            lblPurchaseDate.Size = new Size(120, 21);
            lblPurchaseDate.TabIndex = 42;
            lblPurchaseDate.Text = "Purchase Date*";
            // 
            // dtpPurchase
            // 
            dtpPurchase.Font = new Font("Segoe UI", 10.2F);
            dtpPurchase.Format = DateTimePickerFormat.Short;
            dtpPurchase.Location = new Point(314, 208);
            dtpPurchase.Margin = new Padding(3, 2, 3, 2);
            dtpPurchase.Name = "dtpPurchase";
            dtpPurchase.Size = new Size(195, 26);
            dtpPurchase.TabIndex = 4;
            dtpPurchase.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dtpExpiration
            // 
            dtpExpiration.Font = new Font("Segoe UI", 10.2F);
            dtpExpiration.Format = DateTimePickerFormat.Short;
            dtpExpiration.Location = new Point(551, 208);
            dtpExpiration.Margin = new Padding(3, 2, 3, 2);
            dtpExpiration.Name = "dtpExpiration";
            dtpExpiration.Size = new Size(259, 26);
            dtpExpiration.TabIndex = 5;
            // 
            // lblExpirationDate
            // 
            lblExpirationDate.AutoSize = true;
            lblExpirationDate.BackColor = Color.White;
            lblExpirationDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblExpirationDate.Location = new Point(551, 183);
            lblExpirationDate.Name = "lblExpirationDate";
            lblExpirationDate.Size = new Size(128, 21);
            lblExpirationDate.TabIndex = 44;
            lblExpirationDate.Text = "Expiration Date*";
            // 
            // txtBatchQuantity
            // 
            txtBatchQuantity.BackColor = Color.FromArgb(232, 232, 232);
            txtBatchQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBatchQuantity.Location = new Point(13, 303);
            txtBatchQuantity.Margin = new Padding(3, 2, 3, 2);
            txtBatchQuantity.Name = "txtBatchQuantity";
            txtBatchQuantity.PlaceholderText = "0.00";
            txtBatchQuantity.Size = new Size(259, 26);
            txtBatchQuantity.TabIndex = 6;
            txtBatchQuantity.TextAlign = HorizontalAlignment.Right;
            txtBatchQuantity.Click += txtBatchQuantity_Click;
            // 
            // txtMinimumStock
            // 
            txtMinimumStock.BackColor = Color.FromArgb(232, 232, 232);
            txtMinimumStock.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMinimumStock.Location = new Point(13, 358);
            txtMinimumStock.Margin = new Padding(3, 2, 3, 2);
            txtMinimumStock.Name = "txtMinimumStock";
            txtMinimumStock.PlaceholderText = "0.00";
            txtMinimumStock.Size = new Size(259, 26);
            txtMinimumStock.TabIndex = 9;
            txtMinimumStock.TextAlign = HorizontalAlignment.Right;
            txtMinimumStock.Click += txtMinimumStock_Click;
            // 
            // cboUnitType
            // 
            cboUnitType.BackColor = Color.FromArgb(232, 232, 232);
            cboUnitType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUnitType.Font = new Font("Segoe UI", 10.2F);
            cboUnitType.FormattingEnabled = true;
            cboUnitType.Location = new Point(314, 303);
            cboUnitType.Margin = new Padding(3, 2, 3, 2);
            cboUnitType.Name = "cboUnitType";
            cboUnitType.Size = new Size(195, 27);
            cboUnitType.TabIndex = 7;
            cboUnitType.SelectedIndexChanged += cboUnitType_SelectedIndexChanged;
            // 
            // cboUnitMeasure
            // 
            cboUnitMeasure.BackColor = Color.FromArgb(232, 232, 232);
            cboUnitMeasure.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUnitMeasure.Font = new Font("Segoe UI", 10.2F);
            cboUnitMeasure.FormattingEnabled = true;
            cboUnitMeasure.Location = new Point(554, 303);
            cboUnitMeasure.Margin = new Padding(3, 2, 3, 2);
            cboUnitMeasure.Name = "cboUnitMeasure";
            cboUnitMeasure.Size = new Size(256, 27);
            cboUnitMeasure.TabIndex = 8;
            cboUnitMeasure.SelectedIndexChanged += cboUnitMeasure_SelectedIndexChanged;
            // 
            // lblMeasure
            // 
            lblMeasure.AutoSize = true;
            lblMeasure.BackColor = Color.White;
            lblMeasure.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMeasure.Location = new Point(551, 278);
            lblMeasure.Name = "lblMeasure";
            lblMeasure.Size = new Size(134, 21);
            lblMeasure.TabIndex = 49;
            lblMeasure.Text = "Unit of Measure*";
            // 
            // txtRestorePoint
            // 
            txtRestorePoint.BackColor = Color.FromArgb(232, 232, 232);
            txtRestorePoint.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRestorePoint.Location = new Point(554, 358);
            txtRestorePoint.Margin = new Padding(3, 2, 3, 2);
            txtRestorePoint.Name = "txtRestorePoint";
            txtRestorePoint.PlaceholderText = "0.00";
            txtRestorePoint.Size = new Size(256, 26);
            txtRestorePoint.TabIndex = 11;
            txtRestorePoint.TextAlign = HorizontalAlignment.Right;
            txtRestorePoint.Click += txtRestorePoint_Click;
            // 
            // lblReorder
            // 
            lblReorder.AutoSize = true;
            lblReorder.BackColor = Color.White;
            lblReorder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReorder.Location = new Point(551, 332);
            lblReorder.Name = "lblReorder";
            lblReorder.Size = new Size(118, 21);
            lblReorder.TabIndex = 51;
            lblReorder.Text = "Reorder Point*";
            // 
            // txtLeadTime
            // 
            txtLeadTime.BackColor = Color.FromArgb(232, 232, 232);
            txtLeadTime.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLeadTime.Location = new Point(13, 412);
            txtLeadTime.Margin = new Padding(3, 2, 3, 2);
            txtLeadTime.Name = "txtLeadTime";
            txtLeadTime.PlaceholderText = "0";
            txtLeadTime.Size = new Size(259, 26);
            txtLeadTime.TabIndex = 12;
            txtLeadTime.TextAlign = HorizontalAlignment.Right;
            txtLeadTime.Click += txtLeadTime_Click;
            // 
            // lblLeadTime
            // 
            lblLeadTime.AutoSize = true;
            lblLeadTime.BackColor = Color.White;
            lblLeadTime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblLeadTime.Location = new Point(10, 386);
            lblLeadTime.Name = "lblLeadTime";
            lblLeadTime.Size = new Size(139, 21);
            lblLeadTime.TabIndex = 53;
            lblLeadTime.Text = "Lead Time (days)*";
            // 
            // txtTargetTurnover
            // 
            txtTargetTurnover.BackColor = Color.FromArgb(232, 232, 232);
            txtTargetTurnover.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTargetTurnover.Location = new Point(312, 412);
            txtTargetTurnover.Margin = new Padding(3, 2, 3, 2);
            txtTargetTurnover.Name = "txtTargetTurnover";
            txtTargetTurnover.PlaceholderText = "0";
            txtTargetTurnover.Size = new Size(197, 26);
            txtTargetTurnover.TabIndex = 13;
            txtTargetTurnover.TextAlign = HorizontalAlignment.Right;
            txtTargetTurnover.Click += txtTargetTurnover_Click;
            // 
            // lblTurnover
            // 
            lblTurnover.AutoSize = true;
            lblTurnover.BackColor = Color.White;
            lblTurnover.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTurnover.Location = new Point(312, 386);
            lblTurnover.Name = "lblTurnover";
            lblTurnover.Size = new Size(179, 21);
            lblTurnover.TabIndex = 55;
            lblTurnover.Text = "Target Turnover (days)*";
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.BackColor = Color.White;
            lblCost.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCost.Location = new Point(5, 31);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(84, 21);
            lblCost.TabIndex = 57;
            lblCost.Text = "Unit Cost*";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.BackColor = Color.White;
            lblSupplier.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSupplier.Location = new Point(304, 31);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(71, 21);
            lblSupplier.TabIndex = 59;
            lblSupplier.Text = "Supplier";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(121, 85, 72);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 2, 3, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(821, 34);
            pnlHeader.TabIndex = 61;
            // 
            // cboSubcategory
            // 
            cboSubcategory.BackColor = Color.FromArgb(232, 232, 232);
            cboSubcategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSubcategory.Font = new Font("Segoe UI", 10.2F);
            cboSubcategory.FormattingEnabled = true;
            cboSubcategory.Location = new Point(551, 107);
            cboSubcategory.Margin = new Padding(3, 2, 3, 2);
            cboSubcategory.Name = "cboSubcategory";
            cboSubcategory.Size = new Size(259, 27);
            cboSubcategory.TabIndex = 2;
            cboSubcategory.SelectedIndexChanged += cboSubcategory_SelectedIndexChanged;
            // 
            // lblSubcateogry
            // 
            lblSubcateogry.AutoSize = true;
            lblSubcateogry.BackColor = Color.White;
            lblSubcateogry.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSubcateogry.Location = new Point(551, 82);
            lblSubcateogry.Name = "lblSubcateogry";
            lblSubcateogry.Size = new Size(111, 21);
            lblSubcateogry.TabIndex = 62;
            lblSubcateogry.Text = "Subcategory*";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(161, 136, 127);
            btnCancel.FlatAppearance.BorderColor = Color.Gray;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(141, 110, 99);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(485, 548);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 32);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(141, 110, 99);
            btnSave.FlatAppearance.BorderColor = Color.Gray;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 76, 65);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(578, 548);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 32);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnSaveAndNew
            // 
            btnSaveAndNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveAndNew.BackColor = Color.FromArgb(141, 110, 99);
            btnSaveAndNew.FlatAppearance.BorderColor = Color.Gray;
            btnSaveAndNew.FlatAppearance.BorderSize = 0;
            btnSaveAndNew.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 76, 65);
            btnSaveAndNew.FlatStyle = FlatStyle.Flat;
            btnSaveAndNew.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveAndNew.ForeColor = Color.White;
            btnSaveAndNew.Location = new Point(697, 548);
            btnSaveAndNew.Margin = new Padding(3, 2, 3, 2);
            btnSaveAndNew.Name = "btnSaveAndNew";
            btnSaveAndNew.Size = new Size(117, 32);
            btnSaveAndNew.TabIndex = 17;
            btnSaveAndNew.Text = "Save && New";
            btnSaveAndNew.UseVisualStyleBackColor = false;
            btnSaveAndNew.Click += btnSaveAndNew_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(8, 46);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(806, 93);
            panel2.TabIndex = 63;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(8, 148);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(806, 92);
            panel3.TabIndex = 64;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(txtCurrentQuantity);
            panel4.Controls.Add(lblCurrentQuantity);
            panel4.Location = new Point(8, 248);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(806, 196);
            panel4.TabIndex = 64;
            // 
            // txtCurrentQuantity
            // 
            txtCurrentQuantity.BackColor = Color.FromArgb(232, 232, 232);
            txtCurrentQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrentQuantity.Location = new Point(546, 164);
            txtCurrentQuantity.Margin = new Padding(3, 2, 3, 2);
            txtCurrentQuantity.Name = "txtCurrentQuantity";
            txtCurrentQuantity.PlaceholderText = "0.00";
            txtCurrentQuantity.Size = new Size(256, 26);
            txtCurrentQuantity.TabIndex = 27;
            txtCurrentQuantity.TextAlign = HorizontalAlignment.Right;
            txtCurrentQuantity.Visible = false;
            txtCurrentQuantity.Click += txtCurrentQuantity_Click;
            // 
            // lblCurrentQuantity
            // 
            lblCurrentQuantity.AutoSize = true;
            lblCurrentQuantity.BackColor = Color.White;
            lblCurrentQuantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentQuantity.Location = new Point(546, 139);
            lblCurrentQuantity.Name = "lblCurrentQuantity";
            lblCurrentQuantity.Size = new Size(138, 21);
            lblCurrentQuantity.TabIndex = 28;
            lblCurrentQuantity.Text = "Current Quantity*";
            lblCurrentQuantity.Visible = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(cboSupplier);
            panel5.Controls.Add(txtUnitCost);
            panel5.Controls.Add(lblCost);
            panel5.Controls.Add(lblSupplier);
            panel5.Location = new Point(8, 452);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(806, 88);
            panel5.TabIndex = 64;
            // 
            // cboSupplier
            // 
            cboSupplier.BackColor = Color.FromArgb(232, 232, 232);
            cboSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSupplier.Font = new Font("Segoe UI", 10.2F);
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(306, 54);
            cboSupplier.Margin = new Padding(3, 2, 3, 2);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(195, 27);
            cboSupplier.TabIndex = 15;
            cboSupplier.SelectedIndexChanged += cboSupplier_SelectedIndexChanged;
            // 
            // txtUnitCost
            // 
            txtUnitCost.BackColor = Color.FromArgb(232, 232, 232);
            txtUnitCost.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitCost.Location = new Point(5, 54);
            txtUnitCost.Margin = new Padding(3, 2, 3, 2);
            txtUnitCost.Name = "txtUnitCost";
            txtUnitCost.PlaceholderText = "0";
            txtUnitCost.Size = new Size(259, 26);
            txtUnitCost.TabIndex = 14;
            txtUnitCost.TextAlign = HorizontalAlignment.Right;
            txtUnitCost.Click += txtUnitCost_Click;
            // 
            // cbLowStockAlerts
            // 
            cbLowStockAlerts.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbLowStockAlerts.AutoSize = true;
            cbLowStockAlerts.Checked = true;
            cbLowStockAlerts.CheckState = CheckState.Checked;
            cbLowStockAlerts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cbLowStockAlerts.Location = new Point(13, 550);
            cbLowStockAlerts.Margin = new Padding(3, 2, 3, 2);
            cbLowStockAlerts.Name = "cbLowStockAlerts";
            cbLowStockAlerts.Size = new Size(187, 25);
            cbLowStockAlerts.TabIndex = 16;
            cbLowStockAlerts.Text = "Enable low stock alert";
            cbLowStockAlerts.UseVisualStyleBackColor = true;
            // 
            // AddInventoryItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 232, 232);
            ClientSize = new Size(821, 590);
            Controls.Add(cbLowStockAlerts);
            Controls.Add(btnSaveAndNew);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboSubcategory);
            Controls.Add(lblSubcateogry);
            Controls.Add(txtTargetTurnover);
            Controls.Add(lblTurnover);
            Controls.Add(txtLeadTime);
            Controls.Add(lblLeadTime);
            Controls.Add(txtRestorePoint);
            Controls.Add(lblReorder);
            Controls.Add(cboUnitMeasure);
            Controls.Add(lblMeasure);
            Controls.Add(cboUnitType);
            Controls.Add(txtMinimumStock);
            Controls.Add(txtBatchQuantity);
            Controls.Add(dtpExpiration);
            Controls.Add(lblExpirationDate);
            Controls.Add(dtpPurchase);
            Controls.Add(lblPurchaseDate);
            Controls.Add(txtBatchNumber);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label11);
            Controls.Add(txtMaximumStock);
            Controls.Add(lblMaxStock);
            Controls.Add(lblUnitType);
            Controls.Add(lblMinStock);
            Controls.Add(lblQuantity);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cboCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtItemName);
            Controls.Add(lblItemName);
            Controls.Add(pnlHeader);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddInventoryItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddInventoryItem";
            Load += AddInventoryItem_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblItemName;
        private TextBox txtItemName;
        private Label lblCategory;
        private ComboBox cboCategory;
        private Label label5;
        private Label label6;
        private Label lblQuantity;
        private Label lblMinStock;
        private Label lblUnitType;
        private TextBox txtMaximumStock;
        private Label lblMaxStock;
        private Label label11;
        private Label label14;
        private TextBox txtBatchNumber;
        private Label label15;
        private Label lblPurchaseDate;
        private DateTimePicker dtpPurchase;
        private DateTimePicker dtpExpiration;
        private Label lblExpirationDate;
        private TextBox txtBatchQuantity;
        private TextBox txtMinimumStock;
        private ComboBox cboUnitType;
        private ComboBox cboUnitMeasure;
        private Label lblMeasure;
        private TextBox txtRestorePoint;
        private Label lblReorder;
        private TextBox txtLeadTime;
        private Label lblLeadTime;
        private TextBox txtTargetTurnover;
        private Label lblTurnover;
        private Label lblCost;
        private Label lblSupplier;
        private Panel pnlHeader;
        private ComboBox cboSubcategory;
        private Label lblSubcateogry;
        private Button btnCancel;
        private Button btnSave;
        private Button btnSaveAndNew;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private CheckBox cbLowStockAlerts;
        private TextBox txtUnitCost;
        private ComboBox cboSupplier;
        private TextBox txtCurrentQuantity;
        private Label lblCurrentQuantity;
    }
}
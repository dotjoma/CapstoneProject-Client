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
            label1 = new Label();
            label2 = new Label();
            txtItemName = new TextBox();
            label4 = new Label();
            cboCategory = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtMaximumStock = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label14 = new Label();
            txtBatchNumber = new TextBox();
            label15 = new Label();
            label16 = new Label();
            dtpPurchase = new DateTimePicker();
            dtpExpiration = new DateTimePicker();
            label17 = new Label();
            txtBatchQuantity = new TextBox();
            txtMinimumStock = new TextBox();
            cboUnitType = new ComboBox();
            cboUnitMeasure = new ComboBox();
            label18 = new Label();
            txtRestorePoint = new TextBox();
            label19 = new Label();
            txtLeadTime = new TextBox();
            label20 = new Label();
            txtTargetTurnover = new TextBox();
            label21 = new Label();
            txtUnitCost = new TextBox();
            label22 = new Label();
            cboSupplier = new ComboBox();
            label23 = new Label();
            pnlHeader = new Panel();
            cboSubcategory = new ComboBox();
            label13 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            btnSaveAndNew = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            cbLowStockAlerts = new CheckBox();
            pnlHeader.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(121, 85, 72);
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 8);
            label1.Name = "label1";
            label1.Size = new Size(428, 31);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management - Add New Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(15, 109);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 17;
            label2.Text = "Item Name*";
            // 
            // txtItemName
            // 
            txtItemName.BackColor = Color.FromArgb(232, 232, 232);
            txtItemName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtItemName.Location = new Point(15, 143);
            txtItemName.Name = "txtItemName";
            txtItemName.PlaceholderText = "Enter item name";
            txtItemName.Size = new Size(295, 30);
            txtItemName.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(356, 109);
            label4.Name = "label4";
            label4.Size = new Size(94, 28);
            label4.TabIndex = 21;
            label4.Text = "Category";
            // 
            // cboCategory
            // 
            cboCategory.BackColor = Color.FromArgb(232, 232, 232);
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Font = new Font("Segoe UI", 10.2F);
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(356, 143);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(225, 31);
            cboCategory.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label5.Location = new Point(15, 68);
            label5.Name = "label5";
            label5.Size = new Size(214, 29);
            label5.TabIndex = 24;
            label5.Text = "Basic Information";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label6.Location = new Point(15, 331);
            label6.Name = "label6";
            label6.Size = new Size(244, 29);
            label6.TabIndex = 25;
            label6.Text = "Quantity && Inventory";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 370);
            label7.Name = "label7";
            label7.Size = new Size(155, 28);
            label7.TabIndex = 26;
            label7.Text = "Batch Quantity*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(15, 443);
            label8.Name = "label8";
            label8.Size = new Size(211, 28);
            label8.TabIndex = 28;
            label8.Text = "Minimun Stock Level*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(356, 370);
            label9.Name = "label9";
            label9.Size = new Size(108, 28);
            label9.TabIndex = 30;
            label9.Text = "Unit Type*";
            // 
            // txtMaximumStock
            // 
            txtMaximumStock.BackColor = Color.FromArgb(232, 232, 232);
            txtMaximumStock.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaximumStock.Location = new Point(359, 477);
            txtMaximumStock.Name = "txtMaximumStock";
            txtMaximumStock.PlaceholderText = "0.00";
            txtMaximumStock.Size = new Size(222, 30);
            txtMaximumStock.TabIndex = 11;
            txtMaximumStock.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(356, 443);
            label10.Name = "label10";
            label10.Size = new Size(220, 28);
            label10.TabIndex = 32;
            label10.Text = "Maximum Stock Level*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label11.Location = new Point(12, 610);
            label11.Name = "label11";
            label11.Size = new Size(179, 29);
            label11.TabIndex = 34;
            label11.Text = "Cost && Pricing";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label14.Location = new Point(15, 210);
            label14.Name = "label14";
            label14.Size = new Size(215, 29);
            label14.TabIndex = 39;
            label14.Text = "Batch Information";
            // 
            // txtBatchNumber
            // 
            txtBatchNumber.BackColor = Color.FromArgb(232, 232, 232);
            txtBatchNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBatchNumber.Location = new Point(15, 278);
            txtBatchNumber.Name = "txtBatchNumber";
            txtBatchNumber.PlaceholderText = "Enter batch number";
            txtBatchNumber.Size = new Size(295, 30);
            txtBatchNumber.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.Location = new Point(15, 244);
            label15.Name = "label15";
            label15.Size = new Size(152, 28);
            label15.TabIndex = 40;
            label15.Text = "Batch Number*";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label16.Location = new Point(356, 244);
            label16.Name = "label16";
            label16.Size = new Size(151, 28);
            label16.TabIndex = 42;
            label16.Text = "Purchase Date*";
            // 
            // dtpPurchase
            // 
            dtpPurchase.Font = new Font("Segoe UI", 10.2F);
            dtpPurchase.Format = DateTimePickerFormat.Short;
            dtpPurchase.Location = new Point(359, 278);
            dtpPurchase.Name = "dtpPurchase";
            dtpPurchase.Size = new Size(222, 30);
            dtpPurchase.TabIndex = 5;
            dtpPurchase.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dtpExpiration
            // 
            dtpExpiration.Font = new Font("Segoe UI", 10.2F);
            dtpExpiration.Format = DateTimePickerFormat.Short;
            dtpExpiration.Location = new Point(630, 278);
            dtpExpiration.Name = "dtpExpiration";
            dtpExpiration.Size = new Size(295, 30);
            dtpExpiration.TabIndex = 6;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.White;
            label17.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label17.Location = new Point(630, 244);
            label17.Name = "label17";
            label17.Size = new Size(159, 28);
            label17.TabIndex = 44;
            label17.Text = "Expiration Date*";
            // 
            // txtBatchQuantity
            // 
            txtBatchQuantity.BackColor = Color.FromArgb(232, 232, 232);
            txtBatchQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBatchQuantity.Location = new Point(15, 404);
            txtBatchQuantity.Name = "txtBatchQuantity";
            txtBatchQuantity.PlaceholderText = "0.00";
            txtBatchQuantity.Size = new Size(295, 30);
            txtBatchQuantity.TabIndex = 7;
            txtBatchQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMinimumStock
            // 
            txtMinimumStock.BackColor = Color.FromArgb(232, 232, 232);
            txtMinimumStock.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMinimumStock.Location = new Point(15, 477);
            txtMinimumStock.Name = "txtMinimumStock";
            txtMinimumStock.PlaceholderText = "0.00";
            txtMinimumStock.Size = new Size(295, 30);
            txtMinimumStock.TabIndex = 10;
            txtMinimumStock.TextAlign = HorizontalAlignment.Right;
            // 
            // cboUnitType
            // 
            cboUnitType.BackColor = Color.FromArgb(232, 232, 232);
            cboUnitType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUnitType.Font = new Font("Segoe UI", 10.2F);
            cboUnitType.FormattingEnabled = true;
            cboUnitType.Location = new Point(359, 404);
            cboUnitType.Name = "cboUnitType";
            cboUnitType.Size = new Size(222, 31);
            cboUnitType.TabIndex = 8;
            // 
            // cboUnitMeasure
            // 
            cboUnitMeasure.BackColor = Color.FromArgb(232, 232, 232);
            cboUnitMeasure.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUnitMeasure.Font = new Font("Segoe UI", 10.2F);
            cboUnitMeasure.FormattingEnabled = true;
            cboUnitMeasure.Location = new Point(633, 404);
            cboUnitMeasure.Name = "cboUnitMeasure";
            cboUnitMeasure.Size = new Size(292, 31);
            cboUnitMeasure.TabIndex = 9;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.White;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(630, 370);
            label18.Name = "label18";
            label18.Size = new Size(168, 28);
            label18.TabIndex = 49;
            label18.Text = "Unit of Measure*";
            // 
            // txtRestorePoint
            // 
            txtRestorePoint.BackColor = Color.FromArgb(232, 232, 232);
            txtRestorePoint.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRestorePoint.Location = new Point(633, 477);
            txtRestorePoint.Name = "txtRestorePoint";
            txtRestorePoint.PlaceholderText = "0.00";
            txtRestorePoint.Size = new Size(292, 30);
            txtRestorePoint.TabIndex = 12;
            txtRestorePoint.TextAlign = HorizontalAlignment.Right;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.White;
            label19.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(630, 443);
            label19.Name = "label19";
            label19.Size = new Size(145, 28);
            label19.TabIndex = 51;
            label19.Text = "Reorder Point*";
            // 
            // txtLeadTime
            // 
            txtLeadTime.BackColor = Color.FromArgb(232, 232, 232);
            txtLeadTime.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLeadTime.Location = new Point(15, 549);
            txtLeadTime.Name = "txtLeadTime";
            txtLeadTime.PlaceholderText = "0";
            txtLeadTime.Size = new Size(295, 30);
            txtLeadTime.TabIndex = 13;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.White;
            label20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label20.Location = new Point(12, 515);
            label20.Name = "label20";
            label20.Size = new Size(167, 28);
            label20.TabIndex = 53;
            label20.Text = "Lead Time (days)";
            // 
            // txtTargetTurnover
            // 
            txtTargetTurnover.BackColor = Color.FromArgb(232, 232, 232);
            txtTargetTurnover.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTargetTurnover.Location = new Point(356, 549);
            txtTargetTurnover.Name = "txtTargetTurnover";
            txtTargetTurnover.PlaceholderText = "0";
            txtTargetTurnover.Size = new Size(225, 30);
            txtTargetTurnover.TabIndex = 14;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.White;
            label21.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label21.Location = new Point(356, 515);
            label21.Name = "label21";
            label21.Size = new Size(215, 28);
            label21.TabIndex = 55;
            label21.Text = "Target Turnover (days)";
            // 
            // txtUnitCost
            // 
            txtUnitCost.BackColor = Color.FromArgb(232, 232, 232);
            txtUnitCost.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitCost.Location = new Point(6, 72);
            txtUnitCost.Name = "txtUnitCost";
            txtUnitCost.PlaceholderText = "0.00";
            txtUnitCost.Size = new Size(295, 30);
            txtUnitCost.TabIndex = 16;
            txtUnitCost.TextAlign = HorizontalAlignment.Right;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.White;
            label22.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(6, 41);
            label22.Name = "label22";
            label22.Size = new Size(105, 28);
            label22.TabIndex = 57;
            label22.Text = "Unit Cost*";
            // 
            // cboSupplier
            // 
            cboSupplier.BackColor = Color.FromArgb(232, 232, 232);
            cboSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSupplier.Font = new Font("Segoe UI", 10.2F);
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(347, 72);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(225, 31);
            cboSupplier.TabIndex = 17;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.White;
            label23.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(347, 41);
            label23.Name = "label23";
            label23.Size = new Size(96, 28);
            label23.TabIndex = 59;
            label23.Text = "Supplier*";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(121, 85, 72);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(938, 46);
            pnlHeader.TabIndex = 61;
            // 
            // cboSubcategory
            // 
            cboSubcategory.BackColor = Color.FromArgb(232, 232, 232);
            cboSubcategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSubcategory.Font = new Font("Segoe UI", 10.2F);
            cboSubcategory.FormattingEnabled = true;
            cboSubcategory.Location = new Point(630, 143);
            cboSubcategory.Name = "cboSubcategory";
            cboSubcategory.Size = new Size(295, 31);
            cboSubcategory.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label13.Location = new Point(630, 109);
            label13.Name = "label13";
            label13.Size = new Size(126, 28);
            label13.TabIndex = 62;
            label13.Text = "Subcategory";
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
            btnCancel.Location = new Point(552, 731);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(99, 43);
            btnCancel.TabIndex = 20;
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
            btnSave.Location = new Point(797, 731);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 43);
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
            btnSaveAndNew.Location = new Point(657, 731);
            btnSaveAndNew.Name = "btnSaveAndNew";
            btnSaveAndNew.Size = new Size(134, 43);
            btnSaveAndNew.TabIndex = 19;
            btnSaveAndNew.Text = "Save && New";
            btnSaveAndNew.UseVisualStyleBackColor = false;
            btnSaveAndNew.Click += btnSaveAndNew_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(9, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(921, 124);
            panel2.TabIndex = 63;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(9, 197);
            panel3.Name = "panel3";
            panel3.Size = new Size(921, 122);
            panel3.TabIndex = 64;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(9, 330);
            panel4.Name = "panel4";
            panel4.Size = new Size(921, 262);
            panel4.TabIndex = 64;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label22);
            panel5.Controls.Add(txtUnitCost);
            panel5.Controls.Add(label23);
            panel5.Controls.Add(cboSupplier);
            panel5.Location = new Point(9, 603);
            panel5.Name = "panel5";
            panel5.Size = new Size(921, 117);
            panel5.TabIndex = 64;
            // 
            // cbLowStockAlerts
            // 
            cbLowStockAlerts.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbLowStockAlerts.AutoSize = true;
            cbLowStockAlerts.Checked = true;
            cbLowStockAlerts.CheckState = CheckState.Checked;
            cbLowStockAlerts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cbLowStockAlerts.Location = new Point(15, 735);
            cbLowStockAlerts.Name = "cbLowStockAlerts";
            cbLowStockAlerts.Size = new Size(233, 32);
            cbLowStockAlerts.TabIndex = 65;
            cbLowStockAlerts.Text = "Enable low stock alert";
            cbLowStockAlerts.UseVisualStyleBackColor = true;
            // 
            // AddInventoryItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 232, 232);
            ClientSize = new Size(938, 786);
            Controls.Add(cbLowStockAlerts);
            Controls.Add(btnSaveAndNew);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboSubcategory);
            Controls.Add(label13);
            Controls.Add(txtTargetTurnover);
            Controls.Add(label21);
            Controls.Add(txtLeadTime);
            Controls.Add(label20);
            Controls.Add(txtRestorePoint);
            Controls.Add(label19);
            Controls.Add(cboUnitMeasure);
            Controls.Add(label18);
            Controls.Add(cboUnitType);
            Controls.Add(txtMinimumStock);
            Controls.Add(txtBatchQuantity);
            Controls.Add(dtpExpiration);
            Controls.Add(label17);
            Controls.Add(dtpPurchase);
            Controls.Add(label16);
            Controls.Add(txtBatchNumber);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label11);
            Controls.Add(txtMaximumStock);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cboCategory);
            Controls.Add(label4);
            Controls.Add(txtItemName);
            Controls.Add(label2);
            Controls.Add(pnlHeader);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddInventoryItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddInventoryItem";
            Load += AddInventoryItem_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtItemName;
        private Label label4;
        private ComboBox cboCategory;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtMaximumStock;
        private Label label10;
        private Label label11;
        private Label label14;
        private TextBox txtBatchNumber;
        private Label label15;
        private Label label16;
        private DateTimePicker dtpPurchase;
        private DateTimePicker dtpExpiration;
        private Label label17;
        private TextBox txtBatchQuantity;
        private TextBox txtMinimumStock;
        private ComboBox cboUnitType;
        private ComboBox cboUnitMeasure;
        private Label label18;
        private TextBox txtRestorePoint;
        private Label label19;
        private TextBox txtLeadTime;
        private Label label20;
        private TextBox txtTargetTurnover;
        private Label label21;
        private TextBox txtUnitCost;
        private Label label22;
        private ComboBox cboSupplier;
        private Label label23;
        private Panel pnlHeader;
        private ComboBox cboSubcategory;
        private Label label13;
        private Button btnCancel;
        private Button btnSave;
        private Button btnSaveAndNew;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private CheckBox cbLowStockAlerts;
    }
}
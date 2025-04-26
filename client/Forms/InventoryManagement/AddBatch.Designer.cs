namespace client.Forms.InventoryManagement
{
    partial class AddBatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBatch));
            pnlHeader = new Panel();
            lblTitle = new Label();
            label1 = new Label();
            txtQuantity = new TextBox();
            dtpPurchase = new DateTimePicker();
            label16 = new Label();
            dtExpiration = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtUnitCost = new TextBox();
            label7 = new Label();
            cbIsActive = new CheckBox();
            panel3 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            cboSupplier = new ComboBox();
            panel1 = new Panel();
            pnlHeader.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(121, 85, 72);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 2, 3, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(429, 34);
            pnlHeader.TabIndex = 62;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Left;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.FromArgb(121, 85, 72);
            lblTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(144, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Add New Batch";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(121, 85, 72);
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, -27);
            label1.Name = "label1";
            label1.Size = new Size(358, 25);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management - Add New Item";
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.FromArgb(232, 232, 232);
            txtQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(178, 148);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "0.00";
            txtQuantity.Size = new Size(231, 26);
            txtQuantity.TabIndex = 2;
            txtQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // dtpPurchase
            // 
            dtpPurchase.Font = new Font("Segoe UI", 10.2F);
            dtpPurchase.Format = DateTimePickerFormat.Short;
            dtpPurchase.Location = new Point(178, 58);
            dtpPurchase.Margin = new Padding(3, 2, 3, 2);
            dtpPurchase.Name = "dtpPurchase";
            dtpPurchase.Size = new Size(231, 26);
            dtpPurchase.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(19, 59);
            label16.Name = "label16";
            label16.Size = new Size(140, 25);
            label16.TabIndex = 66;
            label16.Text = "Purchase Date:";
            // 
            // dtExpiration
            // 
            dtExpiration.Font = new Font("Segoe UI", 10.2F);
            dtExpiration.Format = DateTimePickerFormat.Short;
            dtExpiration.Location = new Point(178, 103);
            dtExpiration.Margin = new Padding(3, 2, 3, 2);
            dtExpiration.Name = "dtExpiration";
            dtExpiration.Size = new Size(231, 26);
            dtExpiration.TabIndex = 1;
            dtExpiration.ValueChanged += dtExpiration_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 104);
            label4.Name = "label4";
            label4.Size = new Size(150, 25);
            label4.TabIndex = 68;
            label4.Text = "Expiration Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 149);
            label5.Name = "label5";
            label5.Size = new Size(146, 25);
            label5.TabIndex = 69;
            label5.Text = "Initial Quantity:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 194);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 71;
            label6.Text = "Unit Cost:";
            // 
            // txtUnitCost
            // 
            txtUnitCost.BackColor = Color.FromArgb(232, 232, 232);
            txtUnitCost.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitCost.Location = new Point(178, 193);
            txtUnitCost.Margin = new Padding(3, 2, 3, 2);
            txtUnitCost.Name = "txtUnitCost";
            txtUnitCost.PlaceholderText = "0.00";
            txtUnitCost.Size = new Size(231, 26);
            txtUnitCost.TabIndex = 3;
            txtUnitCost.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 239);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 73;
            label7.Text = "Supplier:";
            // 
            // cbIsActive
            // 
            cbIsActive.AutoSize = true;
            cbIsActive.Checked = true;
            cbIsActive.CheckState = CheckState.Checked;
            cbIsActive.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cbIsActive.Location = new Point(178, 283);
            cbIsActive.Margin = new Padding(3, 2, 3, 2);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(87, 25);
            cbIsActive.TabIndex = 5;
            cbIsActive.Text = "IsActive";
            cbIsActive.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(232, 232, 232);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnSave);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 320);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(427, 40);
            panel3.TabIndex = 75;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(239, 5);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 30);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(327, 5);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 30);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cboSupplier
            // 
            cboSupplier.BackColor = Color.FromArgb(232, 232, 232);
            cboSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSupplier.Font = new Font("Segoe UI", 10.2F);
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(178, 239);
            cboSupplier.Margin = new Padding(3, 2, 3, 2);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(231, 27);
            cboSupplier.TabIndex = 4;
            cboSupplier.SelectedIndexChanged += cboSupplier_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 362);
            panel1.TabIndex = 78;
            // 
            // AddBatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(429, 362);
            Controls.Add(cboSupplier);
            Controls.Add(cbIsActive);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtUnitCost);
            Controls.Add(label5);
            Controls.Add(dtExpiration);
            Controls.Add(label4);
            Controls.Add(dtpPurchase);
            Controls.Add(label16);
            Controls.Add(txtQuantity);
            Controls.Add(pnlHeader);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddBatch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBatch";
            Load += AddBatch_Load;
            KeyDown += AddBatch_KeyDown;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private Label lblTitle;
        private TextBox txtQuantity;
        private DateTimePicker dtpPurchase;
        private Label label16;
        private DateTimePicker dtExpiration;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtUnitCost;
        private Label label7;
        private CheckBox cbIsActive;
        private Panel panel3;
        private ComboBox cboSupplier;
        private Button btnCancel;
        private Button btnSave;
        private Panel panel1;
    }
}
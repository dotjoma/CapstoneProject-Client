namespace client.Forms.InventoryManagement
{
    partial class EditBatch
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
            cboSupplier = new ComboBox();
            btnCancel = new Button();
            panel3 = new Panel();
            btnSave = new Button();
            cbIsActive = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            txtUnitCost = new TextBox();
            dtExpiration = new DateTimePicker();
            label4 = new Label();
            dtpPurchase = new DateTimePicker();
            label16 = new Label();
            lblTitle = new Label();
            label1 = new Label();
            pnlHeader = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            txtInitialQuantity = new TextBox();
            label5 = new Label();
            txtCurrentQuantity = new TextBox();
            panel3.SuspendLayout();
            pnlHeader.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cboSupplier
            // 
            cboSupplier.BackColor = Color.FromArgb(232, 232, 232);
            cboSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSupplier.Font = new Font("Segoe UI", 10.2F);
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(181, 263);
            cboSupplier.Margin = new Padding(3, 2, 3, 2);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(231, 27);
            cboSupplier.TabIndex = 83;
            cboSupplier.SelectedIndexChanged += cboSupplier_SelectedIndexChanged;
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(232, 232, 232);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnSave);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 338);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(427, 40);
            panel3.TabIndex = 75;
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
            // cbIsActive
            // 
            cbIsActive.AutoSize = true;
            cbIsActive.Checked = true;
            cbIsActive.CheckState = CheckState.Checked;
            cbIsActive.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cbIsActive.Location = new Point(181, 303);
            cbIsActive.Margin = new Padding(3, 2, 3, 2);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(87, 25);
            cbIsActive.TabIndex = 84;
            cbIsActive.Text = "IsActive";
            cbIsActive.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 263);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 90;
            label7.Text = "Supplier:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 223);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 89;
            label6.Text = "Unit Cost:";
            // 
            // txtUnitCost
            // 
            txtUnitCost.BackColor = Color.FromArgb(232, 232, 232);
            txtUnitCost.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitCost.Location = new Point(181, 222);
            txtUnitCost.Margin = new Padding(3, 2, 3, 2);
            txtUnitCost.Name = "txtUnitCost";
            txtUnitCost.PlaceholderText = "0.00";
            txtUnitCost.Size = new Size(231, 26);
            txtUnitCost.TabIndex = 82;
            txtUnitCost.TextAlign = HorizontalAlignment.Right;
            // 
            // dtExpiration
            // 
            dtExpiration.Font = new Font("Segoe UI", 10.2F);
            dtExpiration.Format = DateTimePickerFormat.Short;
            dtExpiration.Location = new Point(182, 103);
            dtExpiration.Margin = new Padding(3, 2, 3, 2);
            dtExpiration.Name = "dtExpiration";
            dtExpiration.Size = new Size(231, 26);
            dtExpiration.TabIndex = 80;
            dtExpiration.ValueChanged += dtExpiration_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 104);
            label4.Name = "label4";
            label4.Size = new Size(150, 25);
            label4.TabIndex = 87;
            label4.Text = "Expiration Date:";
            // 
            // dtpPurchase
            // 
            dtpPurchase.Font = new Font("Segoe UI", 10.2F);
            dtpPurchase.Format = DateTimePickerFormat.Short;
            dtpPurchase.Location = new Point(182, 58);
            dtpPurchase.Margin = new Padding(3, 2, 3, 2);
            dtpPurchase.Name = "dtpPurchase";
            dtpPurchase.Size = new Size(231, 26);
            dtpPurchase.TabIndex = 79;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(16, 59);
            label16.Name = "label16";
            label16.Size = new Size(140, 25);
            label16.TabIndex = 86;
            label16.Text = "Purchase Date:";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Left;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.FromArgb(121, 85, 72);
            lblTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, -28);
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
            label1.Location = new Point(13, -60);
            label1.Name = "label1";
            label1.Size = new Size(358, 25);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management - Add New Item";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(121, 85, 72);
            pnlHeader.Controls.Add(label2);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 2, 3, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(429, 34);
            pnlHeader.TabIndex = 85;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(121, 85, 72);
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(4, 5);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 2;
            label2.Text = "Edit Batch";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cboSupplier);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbIsActive);
            panel1.Controls.Add(txtInitialQuantity);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtUnitCost);
            panel1.Controls.Add(txtCurrentQuantity);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 380);
            panel1.TabIndex = 91;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 143);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 90;
            label3.Text = "Initial Quantity:";
            // 
            // txtInitialQuantity
            // 
            txtInitialQuantity.BackColor = Color.FromArgb(232, 232, 232);
            txtInitialQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInitialQuantity.Location = new Point(181, 142);
            txtInitialQuantity.Margin = new Padding(3, 2, 3, 2);
            txtInitialQuantity.Name = "txtInitialQuantity";
            txtInitialQuantity.PlaceholderText = "0.00";
            txtInitialQuantity.Size = new Size(231, 26);
            txtInitialQuantity.TabIndex = 89;
            txtInitialQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 183);
            label5.Name = "label5";
            label5.Size = new Size(162, 25);
            label5.TabIndex = 88;
            label5.Text = "Current Quantity:";
            // 
            // txtCurrentQuantity
            // 
            txtCurrentQuantity.BackColor = Color.FromArgb(232, 232, 232);
            txtCurrentQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrentQuantity.Location = new Point(181, 182);
            txtCurrentQuantity.Margin = new Padding(3, 2, 3, 2);
            txtCurrentQuantity.Name = "txtCurrentQuantity";
            txtCurrentQuantity.PlaceholderText = "0.00";
            txtCurrentQuantity.Size = new Size(231, 26);
            txtCurrentQuantity.TabIndex = 81;
            txtCurrentQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // EditBatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 379);
            Controls.Add(dtExpiration);
            Controls.Add(label4);
            Controls.Add(dtpPurchase);
            Controls.Add(label16);
            Controls.Add(pnlHeader);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditBatch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditBatch";
            Load += EditBatch_Load;
            KeyDown += EditBatch_KeyDown;
            panel3.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSupplier;
        private Button btnCancel;
        private Panel panel3;
        private Button btnSave;
        private CheckBox cbIsActive;
        private Label label7;
        private Label label6;
        private TextBox txtUnitCost;
        private DateTimePicker dtExpiration;
        private Label label4;
        private DateTimePicker dtpPurchase;
        private Label label16;
        private Label lblTitle;
        private Label label1;
        private Panel pnlHeader;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private TextBox txtInitialQuantity;
        private Label label5;
        private TextBox txtCurrentQuantity;
    }
}
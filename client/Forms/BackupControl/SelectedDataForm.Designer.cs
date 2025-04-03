namespace client.Forms.BackupControl
{
    partial class SelectedDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectedDataForm));
            cbSelectAll = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            cbTransaction = new CheckBox();
            cbProducts = new CheckBox();
            cbUsers = new CheckBox();
            cbInventory = new CheckBox();
            cbSystemSettings = new CheckBox();
            btnApply = new Button();
            label3 = new Label();
            btnCancel = new Button();
            lblSales = new Label();
            lblInventory = new Label();
            lblEmployees = new Label();
            lblReservation = new Label();
            lblSystemSettings = new Label();
            lblEstimatedTotal = new Label();
            btnClose = new PictureBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // cbSelectAll
            // 
            cbSelectAll.AutoSize = true;
            cbSelectAll.BackColor = Color.White;
            cbSelectAll.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbSelectAll.Location = new Point(42, 97);
            cbSelectAll.Name = "cbSelectAll";
            cbSelectAll.Size = new Size(136, 35);
            cbSelectAll.TabIndex = 0;
            cbSelectAll.Text = "Select All";
            cbSelectAll.UseVisualStyleBackColor = false;
            cbSelectAll.CheckedChanged += cbSelectAll_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(62, 39, 35);
            label1.Location = new Point(38, 18);
            label1.Name = "label1";
            label1.Size = new Size(305, 38);
            label1.TabIndex = 1;
            label1.Text = "Select Data to Backup";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(42, 56);
            label2.Name = "label2";
            label2.Size = new Size(440, 23);
            label2.TabIndex = 2;
            label2.Text = "Choose which data categories to include in your backup";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(0, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 1);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Location = new Point(41, 138);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.Yes;
            panel2.Size = new Size(490, 1);
            panel2.TabIndex = 4;
            // 
            // cbTransaction
            // 
            cbTransaction.AutoSize = true;
            cbTransaction.BackColor = Color.White;
            cbTransaction.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbTransaction.Location = new Point(42, 159);
            cbTransaction.Name = "cbTransaction";
            cbTransaction.Size = new Size(165, 35);
            cbTransaction.TabIndex = 5;
            cbTransaction.Text = "Transactions";
            cbTransaction.UseVisualStyleBackColor = false;
            // 
            // cbProducts
            // 
            cbProducts.AutoSize = true;
            cbProducts.BackColor = Color.White;
            cbProducts.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbProducts.Location = new Point(41, 200);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(128, 35);
            cbProducts.TabIndex = 6;
            cbProducts.Text = "Products";
            cbProducts.UseVisualStyleBackColor = false;
            // 
            // cbUsers
            // 
            cbUsers.AutoSize = true;
            cbUsers.BackColor = Color.White;
            cbUsers.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbUsers.Location = new Point(42, 241);
            cbUsers.Name = "cbUsers";
            cbUsers.Size = new Size(93, 35);
            cbUsers.TabIndex = 7;
            cbUsers.Text = "Users";
            cbUsers.UseVisualStyleBackColor = false;
            // 
            // cbInventory
            // 
            cbInventory.AutoSize = true;
            cbInventory.BackColor = Color.White;
            cbInventory.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbInventory.Location = new Point(41, 282);
            cbInventory.Name = "cbInventory";
            cbInventory.Size = new Size(137, 35);
            cbInventory.TabIndex = 8;
            cbInventory.Text = "Inventory";
            cbInventory.UseVisualStyleBackColor = false;
            // 
            // cbSystemSettings
            // 
            cbSystemSettings.AutoSize = true;
            cbSystemSettings.BackColor = Color.White;
            cbSystemSettings.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbSystemSettings.Location = new Point(42, 323);
            cbSystemSettings.Name = "cbSystemSettings";
            cbSystemSettings.Size = new Size(200, 35);
            cbSystemSettings.TabIndex = 9;
            cbSystemSettings.Text = "System Settings";
            cbSystemSettings.UseVisualStyleBackColor = false;
            // 
            // btnApply
            // 
            btnApply.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnApply.BackColor = Color.FromArgb(141, 110, 99);
            btnApply.FlatAppearance.BorderSize = 0;
            btnApply.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 76, 65);
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApply.ForeColor = Color.White;
            btnApply.Location = new Point(388, 428);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(143, 43);
            btnApply.TabIndex = 10;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(42, 379);
            label3.Name = "label3";
            label3.Size = new Size(181, 25);
            label3.TabIndex = 11;
            label3.Text = "Estimated Total Size:";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(161, 136, 127);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(141, 110, 99);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(239, 428);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(143, 43);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblSales
            // 
            lblSales.BackColor = Color.White;
            lblSales.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSales.ForeColor = Color.Gray;
            lblSales.Location = new Point(336, 159);
            lblSales.Name = "lblSales";
            lblSales.Size = new Size(155, 35);
            lblSales.TabIndex = 13;
            lblSales.Text = "0 MB";
            lblSales.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblInventory
            // 
            lblInventory.BackColor = Color.White;
            lblInventory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInventory.ForeColor = Color.Gray;
            lblInventory.Location = new Point(336, 203);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(155, 35);
            lblInventory.TabIndex = 14;
            lblInventory.Text = "0 MB";
            lblInventory.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEmployees
            // 
            lblEmployees.BackColor = Color.White;
            lblEmployees.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmployees.ForeColor = Color.Gray;
            lblEmployees.Location = new Point(336, 285);
            lblEmployees.Name = "lblEmployees";
            lblEmployees.Size = new Size(155, 35);
            lblEmployees.TabIndex = 15;
            lblEmployees.Text = "0 MB";
            lblEmployees.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblReservation
            // 
            lblReservation.BackColor = Color.White;
            lblReservation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblReservation.ForeColor = Color.Gray;
            lblReservation.Location = new Point(336, 244);
            lblReservation.Name = "lblReservation";
            lblReservation.Size = new Size(155, 35);
            lblReservation.TabIndex = 16;
            lblReservation.Text = "0 MB";
            lblReservation.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSystemSettings
            // 
            lblSystemSettings.BackColor = Color.White;
            lblSystemSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSystemSettings.ForeColor = Color.Gray;
            lblSystemSettings.Location = new Point(336, 326);
            lblSystemSettings.Name = "lblSystemSettings";
            lblSystemSettings.Size = new Size(155, 35);
            lblSystemSettings.TabIndex = 17;
            lblSystemSettings.Text = "0 MB";
            lblSystemSettings.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEstimatedTotal
            // 
            lblEstimatedTotal.BackColor = Color.White;
            lblEstimatedTotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstimatedTotal.Location = new Point(336, 379);
            lblEstimatedTotal.Name = "lblEstimatedTotal";
            lblEstimatedTotal.Size = new Size(155, 25);
            lblEstimatedTotal.TabIndex = 18;
            lblEstimatedTotal.Text = "0 MB";
            lblEstimatedTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.Image = Properties.Resources.CloseX32;
            btnClose.Location = new Point(523, 18);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 19;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(573, 483);
            panel3.TabIndex = 20;
            // 
            // SelectedDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 483);
            Controls.Add(btnClose);
            Controls.Add(lblEstimatedTotal);
            Controls.Add(lblSystemSettings);
            Controls.Add(lblReservation);
            Controls.Add(lblEmployees);
            Controls.Add(lblInventory);
            Controls.Add(lblSales);
            Controls.Add(btnCancel);
            Controls.Add(label3);
            Controls.Add(btnApply);
            Controls.Add(cbSystemSettings);
            Controls.Add(cbInventory);
            Controls.Add(cbUsers);
            Controls.Add(cbProducts);
            Controls.Add(cbTransaction);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbSelectAll);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SelectedDataForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += SelectedDataForm_Load;
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbSelectAll;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private CheckBox cbTransaction;
        private CheckBox cbProducts;
        private CheckBox cbUsers;
        private CheckBox cbInventory;
        private CheckBox cbSystemSettings;
        private Button btnApply;
        private Label label3;
        private Button btnCancel;
        private Label lblSales;
        private Label lblInventory;
        private Label lblEmployees;
        private Label lblReservation;
        private Label lblSystemSettings;
        private Label lblEstimatedTotal;
        private PictureBox btnClose;
        private Panel panel3;
    }
}
namespace client.Forms.InventoryManagement
{
    partial class NewSupplier
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
            panel1 = new Panel();
            lblTitle = new Label();
            panel2 = new Panel();
            cbIsActive = new CheckBox();
            rtbAddress = new RichTextBox();
            label6 = new Label();
            label4 = new Label();
            txtEmailAddress = new TextBox();
            label5 = new Label();
            txtPhoneNumber = new TextBox();
            label3 = new Label();
            txtContactPerson = new TextBox();
            panel3 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            txtSupplierName = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(121, 85, 72);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 38);
            panel1.TabIndex = 11;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(3, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(143, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create Supplier";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cbIsActive);
            panel2.Controls.Add(rtbAddress);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtEmailAddress);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtPhoneNumber);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtContactPerson);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtSupplierName);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(436, 504);
            panel2.TabIndex = 12;
            // 
            // cbIsActive
            // 
            cbIsActive.AutoSize = true;
            cbIsActive.Checked = true;
            cbIsActive.CheckState = CheckState.Checked;
            cbIsActive.Font = new Font("Segoe UI", 11.25F);
            cbIsActive.Location = new Point(23, 428);
            cbIsActive.Margin = new Padding(3, 2, 3, 2);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(79, 24);
            cbIsActive.TabIndex = 5;
            cbIsActive.Text = "isActive";
            cbIsActive.UseVisualStyleBackColor = true;
            // 
            // rtbAddress
            // 
            rtbAddress.BorderStyle = BorderStyle.FixedSingle;
            rtbAddress.Location = new Point(21, 363);
            rtbAddress.Margin = new Padding(3, 2, 3, 2);
            rtbAddress.Name = "rtbAddress";
            rtbAddress.Size = new Size(392, 52);
            rtbAddress.TabIndex = 4;
            rtbAddress.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label6.Location = new Point(21, 338);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 17;
            label6.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label4.Location = new Point(21, 196);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 16;
            label4.Text = "Phone:";
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            txtEmailAddress.ForeColor = Color.Black;
            txtEmailAddress.Location = new Point(20, 292);
            txtEmailAddress.Margin = new Padding(3, 2, 3, 2);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.PlaceholderText = "Enter email address";
            txtEmailAddress.Size = new Size(391, 32);
            txtEmailAddress.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label5.Location = new Point(21, 267);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 15;
            label5.Text = "Email:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            txtPhoneNumber.ForeColor = Color.Black;
            txtPhoneNumber.Location = new Point(21, 221);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Enter phone number";
            txtPhoneNumber.Size = new Size(390, 32);
            txtPhoneNumber.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.Location = new Point(23, 54);
            label3.Name = "label3";
            label3.Size = new Size(157, 25);
            label3.TabIndex = 12;
            label3.Text = "Supplier Name: *";
            // 
            // txtContactPerson
            // 
            txtContactPerson.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            txtContactPerson.ForeColor = Color.Black;
            txtContactPerson.Location = new Point(22, 150);
            txtContactPerson.Margin = new Padding(3, 2, 3, 2);
            txtContactPerson.Name = "txtContactPerson";
            txtContactPerson.PlaceholderText = "Enter contact person name";
            txtContactPerson.Size = new Size(391, 32);
            txtContactPerson.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(232, 232, 232);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnSave);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 462);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(434, 40);
            panel3.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Right;
            btnCancel.Location = new Point(242, 5);
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
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.Location = new Point(330, 5);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 30);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label1.Location = new Point(23, 125);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 11;
            label1.Text = "Contact Person:";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            txtSupplierName.ForeColor = Color.Black;
            txtSupplierName.Location = new Point(23, 80);
            txtSupplierName.Margin = new Padding(3, 2, 3, 2);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.PlaceholderText = "Enter supplier name";
            txtSupplierName.Size = new Size(390, 32);
            txtSupplierName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.Location = new Point(22, 55);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 10;
            label2.Text = "Name:";
            // 
            // NewSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 504);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "NewSupplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewSupplier";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Panel panel2;
        private TextBox txtContactPerson;
        private Panel panel3;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtSupplierName;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private TextBox txtEmailAddress;
        private Label label5;
        private TextBox txtPhoneNumber;
        private Label label6;
        private RichTextBox rtbAddress;
        private CheckBox cbIsActive;
    }
}
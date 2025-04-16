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
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 51);
            panel1.TabIndex = 11;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(3, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(174, 31);
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
            panel2.Name = "panel2";
            panel2.Size = new Size(498, 672);
            panel2.TabIndex = 12;
            // 
            // cbIsActive
            // 
            cbIsActive.AutoSize = true;
            cbIsActive.Font = new Font("Segoe UI", 11.25F);
            cbIsActive.Location = new Point(26, 570);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(98, 29);
            cbIsActive.TabIndex = 19;
            cbIsActive.Text = "isActive";
            cbIsActive.UseVisualStyleBackColor = true;
            // 
            // rtbAddress
            // 
            rtbAddress.BorderStyle = BorderStyle.FixedSingle;
            rtbAddress.Location = new Point(24, 484);
            rtbAddress.Name = "rtbAddress";
            rtbAddress.Size = new Size(447, 68);
            rtbAddress.TabIndex = 18;
            rtbAddress.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label6.Location = new Point(24, 450);
            label6.Name = "label6";
            label6.Size = new Size(104, 31);
            label6.TabIndex = 17;
            label6.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label4.Location = new Point(24, 261);
            label4.Name = "label4";
            label4.Size = new Size(85, 31);
            label4.TabIndex = 16;
            label4.Text = "Phone:";
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Enabled = false;
            txtEmailAddress.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            txtEmailAddress.ForeColor = Color.Black;
            txtEmailAddress.Location = new Point(23, 389);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.PlaceholderText = "Enter email address";
            txtEmailAddress.Size = new Size(446, 38);
            txtEmailAddress.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label5.Location = new Point(24, 356);
            label5.Name = "label5";
            label5.Size = new Size(76, 31);
            label5.TabIndex = 15;
            label5.Text = "Email:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            txtPhoneNumber.ForeColor = Color.Black;
            txtPhoneNumber.Location = new Point(24, 295);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Enter phone number";
            txtPhoneNumber.Size = new Size(445, 38);
            txtPhoneNumber.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.Location = new Point(26, 72);
            label3.Name = "label3";
            label3.Size = new Size(175, 31);
            label3.TabIndex = 12;
            label3.Text = "Supplier Name:";
            // 
            // txtContactPerson
            // 
            txtContactPerson.Enabled = false;
            txtContactPerson.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            txtContactPerson.ForeColor = Color.Black;
            txtContactPerson.Location = new Point(25, 200);
            txtContactPerson.Name = "txtContactPerson";
            txtContactPerson.PlaceholderText = "Enter contact person name";
            txtContactPerson.Size = new Size(446, 38);
            txtContactPerson.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(232, 232, 232);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnSave);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 616);
            panel3.Name = "panel3";
            panel3.Size = new Size(496, 54);
            panel3.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Right;
            btnCancel.Location = new Point(277, 7);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 40);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.Location = new Point(377, 7);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 40);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label1.Location = new Point(26, 167);
            label1.Name = "label1";
            label1.Size = new Size(176, 31);
            label1.TabIndex = 11;
            label1.Text = "Contact Person:";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            txtSupplierName.ForeColor = Color.Black;
            txtSupplierName.Location = new Point(26, 106);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.PlaceholderText = "Enter supplier name";
            txtSupplierName.Size = new Size(445, 38);
            txtSupplierName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.Location = new Point(25, 73);
            label2.Name = "label2";
            label2.Size = new Size(82, 31);
            label2.TabIndex = 10;
            label2.Text = "Name:";
            // 
            // NewSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 672);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
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
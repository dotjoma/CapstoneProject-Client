namespace client.Forms.DiscountManagement
{
    partial class AddDiscount
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
            cbIsActive = new CheckBox();
            btnCancel = new Button();
            btnSave = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            cboType = new ComboBox();
            txtName = new TextBox();
            label2 = new Label();
            rbVatExemptYes = new RadioButton();
            rbVatExemptNo = new RadioButton();
            txtValue = new TextBox();
            label3 = new Label();
            btnCategoryList = new Button();
            txtApplicableTo = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbIsActive
            // 
            cbIsActive.AutoSize = true;
            cbIsActive.Checked = true;
            cbIsActive.CheckState = CheckState.Checked;
            cbIsActive.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbIsActive.Location = new Point(174, 273);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(79, 24);
            cbIsActive.TabIndex = 45;
            cbIsActive.Text = "isActive";
            cbIsActive.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Image = Properties.Resources.Cancel;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(120, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(156, 37);
            btnCancel.TabIndex = 23;
            btnCancel.TabStop = false;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = Color.White;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnSave.FlatAppearance.MouseOverBackColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Image = Properties.Resources.Save;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(282, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(136, 37);
            btnSave.TabIndex = 22;
            btnSave.TabStop = false;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(98, 87, 87);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 315);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 56);
            panel1.TabIndex = 43;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Discount;
            pictureBox1.Location = new Point(12, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(98, 87, 87);
            label1.Location = new Point(58, 10);
            label1.Name = "label1";
            label1.Size = new Size(196, 32);
            label1.TabIndex = 41;
            label1.Text = "ADD DISCOUNT";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(28, 186);
            label7.Name = "label7";
            label7.Size = new Size(105, 21);
            label7.TabIndex = 40;
            label7.Text = "VAT Exempt:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(28, 106);
            label6.Name = "label6";
            label6.Size = new Size(50, 21);
            label6.TabIndex = 39;
            label6.Text = "Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 231);
            label5.Name = "label5";
            label5.Size = new Size(118, 21);
            label5.TabIndex = 38;
            label5.Text = "Applicable To:";
            // 
            // cboType
            // 
            cboType.BackColor = Color.White;
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.Font = new Font("Segoe UI", 12F);
            cboType.FormattingEnabled = true;
            cboType.Items.AddRange(new object[] { "Percentage", "Fixed" });
            cboType.Location = new Point(174, 103);
            cboType.Name = "cboType";
            cboType.Size = new Size(242, 29);
            cboType.TabIndex = 32;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(174, 61);
            txtName.Name = "txtName";
            txtName.Size = new Size(242, 33);
            txtName.TabIndex = 36;
            txtName.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 66);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 34;
            label2.Text = "Name:";
            // 
            // rbVatExemptYes
            // 
            rbVatExemptYes.AutoSize = true;
            rbVatExemptYes.Checked = true;
            rbVatExemptYes.Location = new Point(174, 189);
            rbVatExemptYes.Name = "rbVatExemptYes";
            rbVatExemptYes.Size = new Size(42, 19);
            rbVatExemptYes.TabIndex = 46;
            rbVatExemptYes.TabStop = true;
            rbVatExemptYes.Text = "Yes";
            rbVatExemptYes.UseVisualStyleBackColor = true;
            // 
            // rbVatExemptNo
            // 
            rbVatExemptNo.AutoSize = true;
            rbVatExemptNo.Location = new Point(222, 189);
            rbVatExemptNo.Name = "rbVatExemptNo";
            rbVatExemptNo.Size = new Size(41, 19);
            rbVatExemptNo.TabIndex = 47;
            rbVatExemptNo.Text = "No";
            rbVatExemptNo.UseVisualStyleBackColor = true;
            // 
            // txtValue
            // 
            txtValue.BorderStyle = BorderStyle.FixedSingle;
            txtValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValue.Location = new Point(174, 143);
            txtValue.Name = "txtValue";
            txtValue.PlaceholderText = "0.00";
            txtValue.Size = new Size(242, 33);
            txtValue.TabIndex = 49;
            txtValue.TabStop = false;
            txtValue.TextAlign = HorizontalAlignment.Right;
            txtValue.KeyPress += txtValue_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 148);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 48;
            label3.Text = "Value:";
            // 
            // btnCategoryList
            // 
            btnCategoryList.FlatStyle = FlatStyle.Flat;
            btnCategoryList.Image = Properties.Resources.List_View;
            btnCategoryList.Location = new Point(374, 226);
            btnCategoryList.Name = "btnCategoryList";
            btnCategoryList.Size = new Size(42, 33);
            btnCategoryList.TabIndex = 51;
            btnCategoryList.UseVisualStyleBackColor = true;
            btnCategoryList.Click += btnCategoryList_Click;
            // 
            // txtApplicableTo
            // 
            txtApplicableTo.BackColor = Color.White;
            txtApplicableTo.BorderStyle = BorderStyle.FixedSingle;
            txtApplicableTo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApplicableTo.Location = new Point(174, 226);
            txtApplicableTo.Name = "txtApplicableTo";
            txtApplicableTo.ReadOnly = true;
            txtApplicableTo.Size = new Size(194, 33);
            txtApplicableTo.TabIndex = 52;
            txtApplicableTo.TabStop = false;
            txtApplicableTo.KeyPress += txtApplicableTo_KeyPress;
            // 
            // AddDiscount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(430, 371);
            Controls.Add(txtApplicableTo);
            Controls.Add(btnCategoryList);
            Controls.Add(txtValue);
            Controls.Add(label3);
            Controls.Add(rbVatExemptNo);
            Controls.Add(rbVatExemptYes);
            Controls.Add(cbIsActive);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cboType);
            Controls.Add(txtName);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddDiscount";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ELICIAS GARDEN FOOD PARK";
            Load += AddDiscount_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbIsActive;
        private Button btnCancel;
        private Button btnSave;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox cboType;
        private TextBox txtName;
        private Label label2;
        private RadioButton rbVatExemptYes;
        private RadioButton rbVatExemptNo;
        private TextBox txtValue;
        private Label label3;
        private Button btnCategoryList;
        private TextBox txtApplicableTo;
    }
}
namespace client.Forms.ProductManagement
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            pbImage = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            cboSubCategory = new ComboBox();
            cboCategory = new ComboBox();
            txtName = new TextBox();
            cboUnit = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            btnUploadImage = new Button();
            cbIsActive = new CheckBox();
            txtPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.BorderStyle = BorderStyle.FixedSingle;
            pbImage.Image = Properties.Resources.ImageFileAdd;
            pbImage.Location = new Point(436, 67);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(186, 140);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 12;
            pbImage.TabStop = false;
            pbImage.Click += pbImage_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 153);
            label7.Name = "label7";
            label7.Size = new Size(119, 21);
            label7.TabIndex = 24;
            label7.Text = "Sub-Category:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 112);
            label6.Name = "label6";
            label6.Size = new Size(84, 21);
            label6.TabIndex = 23;
            label6.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 198);
            label5.Name = "label5";
            label5.Size = new Size(47, 21);
            label5.TabIndex = 22;
            label5.Text = "Unit:";
            // 
            // cboSubCategory
            // 
            cboSubCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSubCategory.Font = new Font("Segoe UI", 12F);
            cboSubCategory.FormattingEnabled = true;
            cboSubCategory.Location = new Point(171, 150);
            cboSubCategory.Name = "cboSubCategory";
            cboSubCategory.Size = new Size(242, 29);
            cboSubCategory.TabIndex = 13;
            cboSubCategory.SelectedIndexChanged += cboSubCategory_SelectedIndexChanged;
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Font = new Font("Segoe UI", 12F);
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(171, 109);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(242, 29);
            cboCategory.TabIndex = 14;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(171, 67);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter menu name";
            txtName.Size = new Size(242, 33);
            txtName.TabIndex = 18;
            txtName.TabStop = false;
            // 
            // cboUnit
            // 
            cboUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboUnit.FormattingEnabled = true;
            cboUnit.Location = new Point(171, 195);
            cboUnit.Name = "cboUnit";
            cboUnit.Size = new Size(242, 29);
            cboUnit.TabIndex = 15;
            cboUnit.SelectedIndexChanged += cboUnit_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 238);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 17;
            label4.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 72);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 16;
            label2.Text = "Menu Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Restaurant_Menu;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(98, 87, 87);
            label1.Location = new Point(58, 16);
            label1.Name = "label1";
            label1.Size = new Size(146, 32);
            label1.TabIndex = 25;
            label1.Text = "ADD MENU";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(98, 87, 87);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 313);
            panel1.Name = "panel1";
            panel1.Size = new Size(647, 56);
            panel1.TabIndex = 27;
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
            btnCancel.Image = Properties.Resources.Cancel222;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(324, 10);
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
            btnSave.Image = Properties.Resources.Save12;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(486, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(136, 37);
            btnSave.TabIndex = 22;
            btnSave.TabStop = false;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUploadImage
            // 
            btnUploadImage.FlatStyle = FlatStyle.Popup;
            btnUploadImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUploadImage.Location = new Point(436, 233);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(186, 33);
            btnUploadImage.TabIndex = 28;
            btnUploadImage.Text = "UPLOAD IMAGE";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // cbIsActive
            // 
            cbIsActive.AutoSize = true;
            cbIsActive.Checked = true;
            cbIsActive.CheckState = CheckState.Checked;
            cbIsActive.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbIsActive.Location = new Point(171, 279);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(79, 24);
            cbIsActive.TabIndex = 29;
            cbIsActive.Text = "isActive";
            cbIsActive.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(171, 233);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "0.00";
            txtPrice.Size = new Size(242, 33);
            txtPrice.TabIndex = 30;
            txtPrice.TabStop = false;
            txtPrice.TextAlign = HorizontalAlignment.Right;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(647, 369);
            Controls.Add(txtPrice);
            Controls.Add(cbIsActive);
            Controls.Add(btnUploadImage);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pbImage);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cboSubCategory);
            Controls.Add(cboCategory);
            Controls.Add(txtName);
            Controls.Add(cboUnit);
            Controls.Add(label4);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ELICIAS GARDEN FOOD PARK";
            Activated += AddProduct_Activated;
            Load += AddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImage;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox cboSubCategory;
        private ComboBox cboCategory;
        private TextBox txtName;
        private ComboBox cboUnit;
        private Label label4;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Button btnSave;
        private Button btnCancel;
        private Button btnUploadImage;
        private CheckBox cbIsActive;
        private TextBox txtPrice;
    }
}
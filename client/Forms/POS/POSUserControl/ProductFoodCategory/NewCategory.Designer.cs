namespace client.Forms.POS.POSUserControl.ProductFoodCategory
{
    partial class NewCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCategory));
            panel1 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            txtTitle = new Label();
            lblLabel = new Label();
            txtName = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(98, 87, 87);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 56);
            panel1.TabIndex = 0;
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
            btnCancel.Location = new Point(21, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(151, 37);
            btnCancel.TabIndex = 25;
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
            btnSave.Location = new Point(191, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 37);
            btnSave.TabIndex = 24;
            btnSave.TabStop = false;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitle.ForeColor = Color.FromArgb(98, 87, 87);
            txtTitle.Location = new Point(56, 17);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(72, 29);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "Title";
            // 
            // lblLabel
            // 
            lblLabel.AutoSize = true;
            lblLabel.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLabel.Location = new Point(12, 82);
            lblLabel.Name = "lblLabel";
            lblLabel.Size = new Size(62, 18);
            lblLabel.TabIndex = 20;
            lblLabel.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(101, 75);
            txtName.Name = "txtName";
            txtName.Size = new Size(217, 31);
            txtName.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.category;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // NewCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(343, 193);
            Controls.Add(pictureBox1);
            Controls.Add(txtTitle);
            Controls.Add(txtName);
            Controls.Add(lblLabel);
            Controls.Add(panel1);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ELICIAS GARDEN FOOD PARK";
            TopMost = true;
            Load += NewCategory_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label txtTitle;
        private Label lblLabel;
        private TextBox txtName;
        private Button btnCancel;
        private Button btnSave;
        private PictureBox pictureBox1;
    }
}
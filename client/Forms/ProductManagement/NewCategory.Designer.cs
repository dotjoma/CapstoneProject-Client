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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(239, 235, 233);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 162);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 56);
            panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.FromArgb(161, 136, 127);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(141, 110, 99);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(96, 10);
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
            btnSave.BackColor = Color.FromArgb(141, 110, 99);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 76, 65);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(266, 10);
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
            txtTitle.ForeColor = Color.FromArgb(62, 39, 35);
            txtTitle.Location = new Point(12, 9);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(89, 36);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "Title";
            // 
            // lblLabel
            // 
            lblLabel.AutoSize = true;
            lblLabel.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLabel.Location = new Point(12, 82);
            lblLabel.Name = "lblLabel";
            lblLabel.Size = new Size(80, 23);
            lblLabel.TabIndex = 20;
            lblLabel.Text = "Name:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(232, 232, 232);
            txtName.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(101, 75);
            txtName.Name = "txtName";
            txtName.Size = new Size(275, 36);
            txtName.TabIndex = 21;
            // 
            // NewCategory
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(408, 218);
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
    }
}
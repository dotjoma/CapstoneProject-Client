namespace client.Forms.ProductManagement
{
    partial class NewUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUnit));
            txtName = new TextBox();
            lblLabel = new Label();
            label1 = new Label();
            rtbDescription = new RichTextBox();
            btnCancel = new Button();
            btnSave = new Button();
            txtTitle = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(161, 75);
            txtName.Name = "txtName";
            txtName.Size = new Size(307, 29);
            txtName.TabIndex = 28;
            // 
            // lblLabel
            // 
            lblLabel.AutoSize = true;
            lblLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLabel.Location = new Point(12, 78);
            lblLabel.Name = "lblLabel";
            lblLabel.Size = new Size(97, 21);
            lblLabel.TabIndex = 27;
            lblLabel.Text = "Unit Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 117);
            label1.Name = "label1";
            label1.Size = new Size(139, 21);
            label1.TabIndex = 31;
            label1.Text = "Unit Description:";
            // 
            // rtbDescription
            // 
            rtbDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbDescription.Location = new Point(161, 117);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(307, 45);
            rtbDescription.TabIndex = 32;
            rtbDescription.Text = "";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Image = Properties.Resources.Cancel221;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(204, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(151, 37);
            btnCancel.TabIndex = 34;
            btnCancel.TabStop = false;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.White;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnSave.FlatAppearance.MouseOverBackColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Image = Properties.Resources.Save11;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(361, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 37);
            btnSave.TabIndex = 33;
            btnSave.TabStop = false;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Left;
            txtTitle.AutoSize = true;
            txtTitle.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitle.ForeColor = Color.FromArgb(98, 87, 87);
            txtTitle.Location = new Point(56, 17);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(184, 32);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "Create Unit";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(98, 87, 87);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCancel);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 181);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 56);
            panel1.TabIndex = 36;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.unit;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // NewUnit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(504, 237);
            Controls.Add(pictureBox1);
            Controls.Add(txtTitle);
            Controls.Add(rtbDescription);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(lblLabel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewUnit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ELICIAS GARDEN FOOD PARK";
            Load += NewUnit_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtName;
        private Label lblLabel;
        private Label label1;
        private RichTextBox rtbDescription;
        private Button btnCancel;
        private Button btnSave;
        private Label txtTitle;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
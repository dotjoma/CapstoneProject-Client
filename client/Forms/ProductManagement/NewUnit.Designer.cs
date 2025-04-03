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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(232, 232, 232);
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(184, 100);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(350, 34);
            txtName.TabIndex = 28;
            // 
            // lblLabel
            // 
            lblLabel.AutoSize = true;
            lblLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLabel.Location = new Point(14, 104);
            lblLabel.Name = "lblLabel";
            lblLabel.Size = new Size(119, 28);
            lblLabel.TabIndex = 27;
            lblLabel.Text = "Unit Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(14, 156);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 31;
            label1.Text = "Unit Description:";
            // 
            // rtbDescription
            // 
            rtbDescription.BackColor = Color.FromArgb(232, 232, 232);
            rtbDescription.BorderStyle = BorderStyle.FixedSingle;
            rtbDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbDescription.Location = new Point(184, 156);
            rtbDescription.Margin = new Padding(3, 4, 3, 4);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(350, 59);
            rtbDescription.TabIndex = 32;
            rtbDescription.Text = "";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(161, 136, 127);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(141, 110, 99);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(233, 13);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(173, 49);
            btnCancel.TabIndex = 34;
            btnCancel.TabStop = false;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(141, 110, 99);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 76, 65);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(413, 13);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 49);
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
            txtTitle.ForeColor = Color.FromArgb(62, 39, 35);
            txtTitle.Location = new Point(171, 23);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(235, 41);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "Create Unit";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(239, 235, 233);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCancel);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 241);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 75);
            panel1.TabIndex = 36;
            // 
            // NewUnit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(576, 316);
            Controls.Add(txtTitle);
            Controls.Add(rtbDescription);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(lblLabel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "NewUnit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ELICIAS GARDEN FOOD PARK";
            Load += NewUnit_Load;
            panel1.ResumeLayout(false);
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
    }
}
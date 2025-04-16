namespace client.Forms.InventoryManagement
{
    partial class NewInventoryCategory
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
            lblTitle = new Label();
            label2 = new Label();
            txtName = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(3, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(59, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.Location = new Point(25, 102);
            label2.Name = "label2";
            label2.Size = new Size(82, 31);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(24, 135);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter category name";
            txtName.Size = new Size(449, 38);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(279, 7);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 40);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(379, 7);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(121, 85, 72);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 51);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(txtName);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(497, 275);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(232, 232, 232);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnSave);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 219);
            panel3.Name = "panel3";
            panel3.Size = new Size(495, 54);
            panel3.TabIndex = 5;
            // 
            // NewInventoryCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 275);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewInventoryCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewInventoryCategory";
            Load += NewInventoryCategory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label2;
        private TextBox txtName;
        private Button btnCancel;
        private Button btnSave;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}
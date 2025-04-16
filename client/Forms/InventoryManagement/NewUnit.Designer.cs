namespace client.Forms.InventoryManagement
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
            panel2 = new Panel();
            txtSymbol = new TextBox();
            panel3 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            txtName = new TextBox();
            lblTitle = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtSymbol);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtName);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(497, 298);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // txtSymbol
            // 
            txtSymbol.Enabled = false;
            txtSymbol.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            txtSymbol.ForeColor = Color.Black;
            txtSymbol.Location = new Point(23, 185);
            txtSymbol.Name = "txtSymbol";
            txtSymbol.PlaceholderText = "Enter symbol";
            txtSymbol.Size = new Size(449, 38);
            txtSymbol.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(232, 232, 232);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnSave);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 242);
            panel3.Name = "panel3";
            panel3.Size = new Size(495, 54);
            panel3.TabIndex = 5;
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
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label1.Location = new Point(24, 152);
            label1.Name = "label1";
            label1.Size = new Size(98, 31);
            label1.TabIndex = 11;
            label1.Text = "Symbol:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(24, 106);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter unit type name";
            txtName.Size = new Size(449, 38);
            txtName.TabIndex = 0;
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
            label2.Location = new Point(25, 73);
            label2.Name = "label2";
            label2.Size = new Size(82, 31);
            label2.TabIndex = 7;
            label2.Text = "Name:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(121, 85, 72);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 51);
            panel1.TabIndex = 8;
            // 
            // NewUnit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 298);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewUnit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewUnit";
            Load += NewUnit_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtName;
        private Label lblTitle;
        private Label label2;
        private Panel panel1;
        private TextBox txtSymbol;
        private Label label1;
    }
}
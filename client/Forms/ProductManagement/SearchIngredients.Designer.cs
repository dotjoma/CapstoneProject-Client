namespace client.Forms.ProductManagement
{
    partial class SearchIngredients
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
            lbIngredients = new ListBox();
            panel2 = new Panel();
            btnCancel = new Button();
            btnSelect = new Button();
            btnSearchIngredient = new PictureBox();
            txtInput = new TextBox();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblHeader = new Label();
            label3 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearchIngredient).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lbIngredients);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnSearchIngredient);
            panel1.Controls.Add(txtInput);
            panel1.Controls.Add(pnlHeader);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 308);
            panel1.TabIndex = 0;
            // 
            // lbIngredients
            // 
            lbIngredients.Font = new Font("Segoe UI", 10F);
            lbIngredients.FormattingEnabled = true;
            lbIngredients.ItemHeight = 17;
            lbIngredients.Location = new Point(18, 98);
            lbIngredients.Name = "lbIngredients";
            lbIngredients.Size = new Size(371, 174);
            lbIngredients.TabIndex = 80;
            lbIngredients.MouseClick += lbIngredients_MouseClick;
            lbIngredients.SelectedIndexChanged += lbIngredients_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSelect);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 270);
            panel2.Name = "panel2";
            panel2.Size = new Size(407, 36);
            panel2.TabIndex = 81;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(233, 7);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 82;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(314, 7);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 23);
            btnSelect.TabIndex = 81;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnSearchIngredient
            // 
            btnSearchIngredient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchIngredient.Image = Properties.Resources.Search;
            btnSearchIngredient.Location = new Point(358, 58);
            btnSearchIngredient.Name = "btnSearchIngredient";
            btnSearchIngredient.Size = new Size(31, 31);
            btnSearchIngredient.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSearchIngredient.TabIndex = 79;
            btnSearchIngredient.TabStop = false;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 13F);
            txtInput.Location = new Point(18, 58);
            txtInput.Name = "txtInput";
            txtInput.PlaceholderText = "Type to search...";
            txtInput.Size = new Size(334, 31);
            txtInput.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(121, 85, 72);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Controls.Add(label3);
            pnlHeader.Controls.Add(label8);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 2, 3, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(407, 38);
            pnlHeader.TabIndex = 66;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(11, 7);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(178, 25);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Search Ingredients";
            // 
            // lblHeader
            // 
            lblHeader.Anchor = AnchorStyles.Left;
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.FromArgb(121, 85, 72);
            lblHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(12, -90);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(241, 21);
            lblHeader.TabIndex = 2;
            lblHeader.Text = "View Batches - Chicken  Breast";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(121, 85, 72);
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, -125);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 1;
            label3.Text = "Add New Batch";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(121, 85, 72);
            label8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(13, -157);
            label8.Name = "label8";
            label8.Size = new Size(358, 25);
            label8.TabIndex = 0;
            label8.Text = "Inventory Management - Add New Item";
            // 
            // SearchIngredients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 308);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchIngredients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchIngredients";
            Load += SearchIngredients_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSearchIngredient).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblHeader;
        private Label label3;
        private Label label8;
        private TextBox txtInput;
        private PictureBox btnSearchIngredient;
        private ListBox lbIngredients;
        private Button btnCancel;
        private Button btnSelect;
        private Panel panel2;
    }
}
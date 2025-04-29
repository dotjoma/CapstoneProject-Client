namespace client.Forms.ProductManagement
{
    partial class AddIngredientToRecipe
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnSearchIngredient = new PictureBox();
            label2 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            dgvIngredients = new DataGridView();
            ingredient = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            action = new DataGridViewImageColumn();
            label7 = new Label();
            btnAdd = new Button();
            txtQuantity = new TextBox();
            label6 = new Label();
            cboIngredient = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblHeader = new Label();
            label3 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearchIngredient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnSearchIngredient);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(dgvIngredients);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cboIngredient);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pnlHeader);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 432);
            panel1.TabIndex = 0;
            // 
            // btnSearchIngredient
            // 
            btnSearchIngredient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchIngredient.Image = Properties.Resources.Search;
            btnSearchIngredient.Location = new Point(218, 138);
            btnSearchIngredient.Name = "btnSearchIngredient";
            btnSearchIngredient.Size = new Size(29, 29);
            btnSearchIngredient.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSearchIngredient.TabIndex = 78;
            btnSearchIngredient.TabStop = false;
            btnSearchIngredient.Click += btnSearchIngredient_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 83);
            label2.Name = "label2";
            label2.Size = new Size(126, 21);
            label2.TabIndex = 68;
            label2.Text = "Chicken Adobo";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Right;
            btnCancel.Location = new Point(315, 397);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 30);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.Location = new Point(403, 397);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 30);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvIngredients
            // 
            dgvIngredients.AllowUserToAddRows = false;
            dgvIngredients.AllowUserToDeleteRows = false;
            dgvIngredients.AllowUserToResizeColumns = false;
            dgvIngredients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvIngredients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIngredients.BackgroundColor = Color.White;
            dgvIngredients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(204, 204, 204);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.2F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(204, 204, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvIngredients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvIngredients.ColumnHeadersHeight = 30;
            dgvIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvIngredients.Columns.AddRange(new DataGridViewColumn[] { ingredient, quantity, action });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvIngredients.DefaultCellStyle = dataGridViewCellStyle5;
            dgvIngredients.EnableHeadersVisualStyles = false;
            dgvIngredients.GridColor = Color.White;
            dgvIngredients.Location = new Point(20, 226);
            dgvIngredients.MultiSelect = false;
            dgvIngredients.Name = "dgvIngredients";
            dgvIngredients.ReadOnly = true;
            dgvIngredients.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(214, 192, 179);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvIngredients.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvIngredients.RowHeadersVisible = false;
            dgvIngredients.RowHeadersWidth = 51;
            dgvIngredients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIngredients.Size = new Size(465, 169);
            dgvIngredients.TabIndex = 77;
            dgvIngredients.TabStop = false;
            dgvIngredients.CellContentClick += dgvIngredients_CellContentClick;
            // 
            // ingredient
            // 
            ingredient.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ingredient.DefaultCellStyle = dataGridViewCellStyle3;
            ingredient.FillWeight = 115.0222F;
            ingredient.HeaderText = "Ingredient";
            ingredient.MinimumWidth = 340;
            ingredient.Name = "ingredient";
            ingredient.ReadOnly = true;
            // 
            // quantity
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            quantity.DefaultCellStyle = dataGridViewCellStyle4;
            quantity.HeaderText = "Quantity";
            quantity.MinimumWidth = 60;
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            // 
            // action
            // 
            action.HeaderText = "Action";
            action.MinimumWidth = 60;
            action.Name = "action";
            action.ReadOnly = true;
            action.Resizable = DataGridViewTriState.True;
            action.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 202);
            label7.Name = "label7";
            label7.Size = new Size(157, 21);
            label7.TabIndex = 76;
            label7.Text = "Current Ingredients:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(351, 173);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 30);
            btnAdd.TabIndex = 74;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtQuantity.Location = new Point(262, 138);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "0.00";
            txtQuantity.Size = new Size(223, 29);
            txtQuantity.TabIndex = 73;
            txtQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(262, 114);
            label6.Name = "label6";
            label6.Size = new Size(76, 21);
            label6.TabIndex = 72;
            label6.Text = "Quantity:";
            // 
            // cboIngredient
            // 
            cboIngredient.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIngredient.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cboIngredient.FormattingEnabled = true;
            cboIngredient.Location = new Point(21, 138);
            cboIngredient.Name = "cboIngredient";
            cboIngredient.Size = new Size(191, 29);
            cboIngredient.TabIndex = 71;
            cboIngredient.SelectedIndexChanged += cboIngredient_SelectedIndexChanged;
            cboIngredient.TextChanged += cboIngredient_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(121, 85, 72);
            label5.Location = new Point(157, 41);
            label5.Name = "label5";
            label5.Size = new Size(190, 30);
            label5.TabIndex = 70;
            label5.Text = "ADD INGREDIENT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 114);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 69;
            label4.Text = "Ingredient:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 83);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 67;
            label1.Text = "Recipe for:";
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
            pnlHeader.Size = new Size(505, 34);
            pnlHeader.TabIndex = 65;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 7);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 21);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Add Ingredient to Recipe";
            // 
            // lblHeader
            // 
            lblHeader.Anchor = AnchorStyles.Left;
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.FromArgb(121, 85, 72);
            lblHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(12, -59);
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
            label3.Location = new Point(12, -94);
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
            label8.Location = new Point(13, -126);
            label8.Name = "label8";
            label8.Size = new Size(358, 25);
            label8.TabIndex = 0;
            label8.Text = "Inventory Management - Add New Item";
            // 
            // AddIngredientToRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 232, 232);
            ClientSize = new Size(507, 432);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddIngredientToRecipe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddIngredientToRecipe";
            FormClosing += AddIngredientToRecipe_FormClosing;
            Load += AddIngredientToRecipe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearchIngredient).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).EndInit();
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
        private Button btnCancel;
        private Button btnSave;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private ComboBox cboIngredient;
        private TextBox txtQuantity;
        private Label label6;
        private Button btnAdd;
        private Label label7;
        private DataGridView dgvIngredients;
        private DataGridViewTextBoxColumn ingredient;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewImageColumn action;
        private PictureBox btnSearchIngredient;
    }
}
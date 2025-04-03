namespace client.Forms.Order
{
    partial class ApplyDiscount
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyDiscount));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnSaveDraft = new Button();
            btnCancel = new Button();
            btnConfirmPayment = new Button();
            dgvCartItem = new DataGridView();
            checkBoxColumn = new DataGridViewCheckBoxColumn();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            unitprice = new DataGridViewTextBoxColumn();
            totalPrice = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCartItem).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(239, 235, 233);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(874, 60);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(62, 39, 35);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(269, 41);
            label1.TabIndex = 27;
            label1.Text = "APPLY DISCOUNT";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(239, 235, 233);
            panel2.Controls.Add(btnSaveDraft);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnConfirmPayment);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 416);
            panel2.Name = "panel2";
            panel2.Size = new Size(874, 65);
            panel2.TabIndex = 7;
            // 
            // btnSaveDraft
            // 
            btnSaveDraft.Anchor = AnchorStyles.Right;
            btnSaveDraft.BackColor = Color.FromArgb(141, 110, 99);
            btnSaveDraft.FlatAppearance.BorderColor = Color.Gray;
            btnSaveDraft.FlatAppearance.BorderSize = 0;
            btnSaveDraft.FlatStyle = FlatStyle.Flat;
            btnSaveDraft.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveDraft.ForeColor = Color.White;
            btnSaveDraft.Location = new Point(593, 11);
            btnSaveDraft.Name = "btnSaveDraft";
            btnSaveDraft.Size = new Size(99, 43);
            btnSaveDraft.TabIndex = 4;
            btnSaveDraft.Text = "Save Draft";
            btnSaveDraft.UseVisualStyleBackColor = false;
            btnSaveDraft.Click += btnSaveDraft_Click;
            btnSaveDraft.MouseEnter += btnSaveDraft_MouseEnter;
            btnSaveDraft.MouseLeave += btnSaveDraft_MouseLeave;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(161, 136, 127);
            btnCancel.FlatAppearance.BorderColor = Color.Gray;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(487, 11);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(99, 43);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            btnCancel.MouseEnter += btnCancel_MouseEnter;
            btnCancel.MouseLeave += btnCancel_MouseLeave;
            // 
            // btnConfirmPayment
            // 
            btnConfirmPayment.Anchor = AnchorStyles.Right;
            btnConfirmPayment.BackColor = Color.FromArgb(141, 110, 99);
            btnConfirmPayment.FlatAppearance.BorderColor = Color.Gray;
            btnConfirmPayment.FlatAppearance.BorderSize = 0;
            btnConfirmPayment.FlatStyle = FlatStyle.Flat;
            btnConfirmPayment.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmPayment.ForeColor = Color.White;
            btnConfirmPayment.Location = new Point(699, 11);
            btnConfirmPayment.Name = "btnConfirmPayment";
            btnConfirmPayment.Size = new Size(163, 43);
            btnConfirmPayment.TabIndex = 2;
            btnConfirmPayment.Text = "Apply Discount";
            btnConfirmPayment.UseVisualStyleBackColor = false;
            btnConfirmPayment.Click += btnConfirmPayment_Click;
            btnConfirmPayment.MouseEnter += btnConfirmPayment_MouseEnter;
            btnConfirmPayment.MouseLeave += btnConfirmPayment_MouseLeave;
            // 
            // dgvCartItem
            // 
            dgvCartItem.AllowUserToAddRows = false;
            dgvCartItem.AllowUserToDeleteRows = false;
            dgvCartItem.AllowUserToResizeColumns = false;
            dgvCartItem.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(245, 242, 237);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(93, 64, 55);
            dgvCartItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCartItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCartItem.BackgroundColor = Color.White;
            dgvCartItem.BorderStyle = BorderStyle.None;
            dgvCartItem.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(121, 85, 72);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(121, 85, 72);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCartItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCartItem.ColumnHeadersHeight = 30;
            dgvCartItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCartItem.Columns.AddRange(new DataGridViewColumn[] { checkBoxColumn, id, name, quantity, unitprice, totalPrice });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(245, 242, 237);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvCartItem.DefaultCellStyle = dataGridViewCellStyle7;
            dgvCartItem.Dock = DockStyle.Fill;
            dgvCartItem.EnableHeadersVisualStyles = false;
            dgvCartItem.GridColor = Color.FromArgb(239, 235, 233);
            dgvCartItem.Location = new Point(0, 60);
            dgvCartItem.Margin = new Padding(3, 4, 3, 4);
            dgvCartItem.MultiSelect = false;
            dgvCartItem.Name = "dgvCartItem";
            dgvCartItem.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(214, 192, 179);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvCartItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvCartItem.RowHeadersVisible = false;
            dgvCartItem.RowHeadersWidth = 51;
            dgvCartItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCartItem.Size = new Size(874, 356);
            dgvCartItem.TabIndex = 8;
            dgvCartItem.TabStop = false;
            dgvCartItem.CellContentClick += dgvCartItem_CellContentClick;
            dgvCartItem.CellValueChanged += dgvCartItem_CellValueChanged;
            // 
            // checkBoxColumn
            // 
            checkBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            checkBoxColumn.DataPropertyName = "checkBoxColumn";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.NullValue = false;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            checkBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            checkBoxColumn.FillWeight = 74.16836F;
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.MinimumWidth = 50;
            checkBoxColumn.Name = "checkBoxColumn";
            checkBoxColumn.Resizable = DataGridViewTriState.True;
            checkBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            checkBoxColumn.Width = 50;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            id.HeaderText = "#";
            id.MinimumWidth = 50;
            id.Name = "id";
            id.Width = 50;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.FillWeight = 114.315689F;
            name.HeaderText = "Name";
            name.MinimumWidth = 180;
            name.Name = "name";
            // 
            // quantity
            // 
            quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            quantity.DefaultCellStyle = dataGridViewCellStyle4;
            quantity.FillWeight = 115.0222F;
            quantity.HeaderText = "Quantity";
            quantity.MinimumWidth = 125;
            quantity.Name = "quantity";
            quantity.Width = 125;
            // 
            // unitprice
            // 
            unitprice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            unitprice.DefaultCellStyle = dataGridViewCellStyle5;
            unitprice.FillWeight = 110.479927F;
            unitprice.HeaderText = "Unit Price";
            unitprice.MinimumWidth = 125;
            unitprice.Name = "unitprice";
            unitprice.Width = 125;
            // 
            // totalPrice
            // 
            totalPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            totalPrice.DefaultCellStyle = dataGridViewCellStyle6;
            totalPrice.HeaderText = "Total";
            totalPrice.MinimumWidth = 125;
            totalPrice.Name = "totalPrice";
            totalPrice.Width = 125;
            // 
            // ApplyDiscount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 481);
            Controls.Add(dgvCartItem);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "ApplyDiscount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ELICIAS GARDEN FOOD PARK";
            TopMost = true;
            FormClosing += ApplyDiscount_FormClosing;
            Load += ApplyDiscount_Load;
            KeyDown += ApplyDiscount_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCartItem).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dgvCartItem;
        private Button btnCancel;
        private DataGridViewCheckBoxColumn checkBoxColumn;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn unitprice;
        private DataGridViewTextBoxColumn totalPrice;
        private Button btnSaveDraft;
        private Button btnConfirmPayment;
    }
}
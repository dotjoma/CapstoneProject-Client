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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyDiscount));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dgvCartItem = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            discount = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCartItem).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 66);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.Discount;
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(98, 87, 87);
            label1.Location = new Point(58, 17);
            label1.Name = "label1";
            label1.Size = new Size(215, 32);
            label1.TabIndex = 27;
            label1.Text = "APPLY DISCOUNT";
            // 
            // dgvCartItem
            // 
            dgvCartItem.AllowUserToAddRows = false;
            dgvCartItem.AllowUserToDeleteRows = false;
            dgvCartItem.AllowUserToResizeColumns = false;
            dgvCartItem.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(214, 192, 179);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(50, 50, 50);
            dgvCartItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCartItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCartItem.BackgroundColor = Color.White;
            dgvCartItem.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(98, 87, 87);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(98, 87, 87);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCartItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCartItem.ColumnHeadersHeight = 35;
            dgvCartItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCartItem.Columns.AddRange(new DataGridViewColumn[] { name, quantity, price, discount });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(214, 192, 179);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvCartItem.DefaultCellStyle = dataGridViewCellStyle6;
            dgvCartItem.Dock = DockStyle.Fill;
            dgvCartItem.EnableHeadersVisualStyles = false;
            dgvCartItem.Location = new Point(0, 66);
            dgvCartItem.MultiSelect = false;
            dgvCartItem.Name = "dgvCartItem";
            dgvCartItem.ReadOnly = true;
            dgvCartItem.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(214, 192, 179);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvCartItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvCartItem.RowHeadersVisible = false;
            dgvCartItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCartItem.Size = new Size(800, 384);
            dgvCartItem.TabIndex = 7;
            dgvCartItem.TabStop = false;
            dgvCartItem.CellClick += dgvCartItem_CellClick;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.FillWeight = 114.315689F;
            name.HeaderText = "Name";
            name.MinimumWidth = 180;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // quantity
            // 
            quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            quantity.DefaultCellStyle = dataGridViewCellStyle3;
            quantity.FillWeight = 115.0222F;
            quantity.HeaderText = "Quantity";
            quantity.MinimumWidth = 100;
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            // 
            // price
            // 
            price.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            price.DefaultCellStyle = dataGridViewCellStyle4;
            price.FillWeight = 110.479927F;
            price.HeaderText = "Price";
            price.MinimumWidth = 120;
            price.Name = "price";
            price.ReadOnly = true;
            price.Width = 120;
            // 
            // discount
            // 
            discount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            discount.DefaultCellStyle = dataGridViewCellStyle5;
            discount.FillWeight = 74.16836F;
            discount.HeaderText = "";
            discount.MinimumWidth = 150;
            discount.Name = "discount";
            discount.ReadOnly = true;
            discount.Resizable = DataGridViewTriState.True;
            discount.SortMode = DataGridViewColumnSortMode.Automatic;
            discount.Width = 150;
            // 
            // ApplyDiscount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCartItem);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ApplyDiscount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ELICIAS GARDEN FOOD PARK";
            TopMost = true;
            FormClosing += ApplyDiscount_FormClosing;
            Load += ApplyDiscount_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCartItem).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgvCartItem;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn price;
        private DataGridViewButtonColumn discount;
    }
}
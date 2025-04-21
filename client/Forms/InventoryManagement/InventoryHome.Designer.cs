namespace client.Forms.InventoryManagement
{
    partial class InventoryHome
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel2 = new Panel();
            comboBox2 = new ComboBox();
            label3 = new Label();
            btnAddNew = new Button();
            pictureBox3 = new PictureBox();
            textBox2 = new TextBox();
            pictureBox4 = new PictureBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            btnRefresh = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            dgvInventory = new DataGridView();
            productName = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            unit = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            minstock = new DataGridViewTextBoxColumn();
            reorderlevel = new DataGridViewTextBoxColumn();
            batches = new DataGridViewTextBoxColumn();
            unitcost = new DataGridViewTextBoxColumn();
            expirydate = new DataGridViewTextBoxColumn();
            stockstatus = new DataGridViewTextBoxColumn();
            suppliername = new DataGridViewTextBoxColumn();
            actions = new DataGridViewButtonColumn();
            viewbatch = new DataGridViewButtonColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(239, 235, 233);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnAddNew);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1110, 59);
            panel2.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Right;
            comboBox2.BackColor = Color.FromArgb(248, 245, 240);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.System;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(690, 19);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(130, 23);
            comboBox2.TabIndex = 14;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(93, 64, 55);
            label3.Location = new Point(624, 20);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 13;
            label3.Text = "Filters:";
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddNew.BackColor = Color.White;
            btnAddNew.FlatAppearance.BorderSize = 0;
            btnAddNew.FlatAppearance.MouseDownBackColor = Color.White;
            btnAddNew.FlatAppearance.MouseOverBackColor = Color.White;
            btnAddNew.FlatStyle = FlatStyle.Flat;
            btnAddNew.Font = new Font("Segoe UI", 12F);
            btnAddNew.ForeColor = Color.Black;
            btnAddNew.Image = Properties.Resources.Add1;
            btnAddNew.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddNew.Location = new Point(184, 14);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(116, 31);
            btnAddNew.TabIndex = 7;
            btnAddNew.TabStop = false;
            btnAddNew.Text = "Add New";
            btnAddNew.TextAlign = ContentAlignment.MiddleRight;
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.Search;
            pictureBox3.Location = new Point(852, 17);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Right;
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(93, 64, 55);
            textBox2.Location = new Point(882, 20);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Search Item(s)";
            textBox2.Size = new Size(208, 22);
            textBox2.TabIndex = 11;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Right;
            pictureBox4.BackColor = Color.FromArgb(232, 232, 232);
            pictureBox4.Image = Properties.Resources.Refresh1;
            pictureBox4.Location = new Point(595, 17);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Right;
            comboBox1.BackColor = Color.FromArgb(248, 245, 240);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1504, 10);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(130, 23);
            comboBox1.TabIndex = 9;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(93, 64, 55);
            label2.Location = new Point(1434, 10);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 8;
            label2.Text = "Filter by:";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.Search;
            pictureBox2.Location = new Point(1667, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Right;
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(93, 64, 55);
            textBox1.Location = new Point(1697, 10);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Item(s)";
            textBox1.Size = new Size(208, 22);
            textBox1.TabIndex = 6;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(232, 232, 232);
            btnRefresh.Image = Properties.Resources.Refresh1;
            btnRefresh.Location = new Point(1390, 9);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(24, 24);
            btnRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRefresh.TabIndex = 3;
            btnRefresh.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(62, 39, 35);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 0;
            label1.Text = "INVENTORY";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(239, 235, 233);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 471);
            panel1.Name = "panel1";
            panel1.Size = new Size(1110, 59);
            panel1.TabIndex = 3;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.AllowUserToResizeColumns = false;
            dgvInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(245, 242, 237);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(93, 64, 55);
            dgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(121, 85, 72);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.2F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(121, 85, 72);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInventory.ColumnHeadersHeight = 30;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { productName, category, unit, stock, minstock, reorderlevel, batches, unitcost, expirydate, stockstatus, suppliername, actions, viewbatch });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(245, 242, 237);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvInventory.DefaultCellStyle = dataGridViewCellStyle10;
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.EnableHeadersVisualStyles = false;
            dgvInventory.GridColor = Color.White;
            dgvInventory.Location = new Point(0, 59);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(214, 192, 179);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(1110, 412);
            dgvInventory.TabIndex = 5;
            dgvInventory.TabStop = false;
            // 
            // productName
            // 
            productName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productName.FillWeight = 115.0222F;
            productName.HeaderText = "Name";
            productName.MinimumWidth = 150;
            productName.Name = "productName";
            productName.ReadOnly = true;
            // 
            // category
            // 
            category.HeaderText = "Category";
            category.MinimumWidth = 89;
            category.Name = "category";
            category.ReadOnly = true;
            // 
            // unit
            // 
            unit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            unit.FillWeight = 114.315689F;
            unit.HeaderText = "Unit";
            unit.MinimumWidth = 150;
            unit.Name = "unit";
            unit.ReadOnly = true;
            unit.Width = 150;
            // 
            // stock
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            stock.DefaultCellStyle = dataGridViewCellStyle3;
            stock.HeaderText = "Stock";
            stock.MinimumWidth = 60;
            stock.Name = "stock";
            stock.ReadOnly = true;
            // 
            // minstock
            // 
            minstock.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            minstock.DefaultCellStyle = dataGridViewCellStyle4;
            minstock.FillWeight = 137.7169F;
            minstock.HeaderText = "Min Stock";
            minstock.MinimumWidth = 100;
            minstock.Name = "minstock";
            minstock.ReadOnly = true;
            // 
            // reorderlevel
            // 
            reorderlevel.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            reorderlevel.DefaultCellStyle = dataGridViewCellStyle5;
            reorderlevel.FillWeight = 178.85527F;
            reorderlevel.HeaderText = "Reorder Level";
            reorderlevel.MinimumWidth = 100;
            reorderlevel.Name = "reorderlevel";
            reorderlevel.ReadOnly = true;
            // 
            // batches
            // 
            batches.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            batches.DefaultCellStyle = dataGridViewCellStyle6;
            batches.FillWeight = 74.16836F;
            batches.HeaderText = "Batches";
            batches.MinimumWidth = 70;
            batches.Name = "batches";
            batches.ReadOnly = true;
            batches.Resizable = DataGridViewTriState.True;
            batches.Width = 70;
            // 
            // unitcost
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            unitcost.DefaultCellStyle = dataGridViewCellStyle7;
            unitcost.HeaderText = "Unit Cost";
            unitcost.MinimumWidth = 75;
            unitcost.Name = "unitcost";
            unitcost.ReadOnly = true;
            // 
            // expirydate
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            expirydate.DefaultCellStyle = dataGridViewCellStyle8;
            expirydate.HeaderText = "Expiry";
            expirydate.MinimumWidth = 6;
            expirydate.Name = "expirydate";
            expirydate.ReadOnly = true;
            // 
            // stockstatus
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            stockstatus.DefaultCellStyle = dataGridViewCellStyle9;
            stockstatus.HeaderText = "Stock Status";
            stockstatus.Name = "stockstatus";
            stockstatus.ReadOnly = true;
            // 
            // suppliername
            // 
            suppliername.HeaderText = "Supplier";
            suppliername.MinimumWidth = 140;
            suppliername.Name = "suppliername";
            suppliername.ReadOnly = true;
            // 
            // actions
            // 
            actions.HeaderText = "Actions";
            actions.MinimumWidth = 80;
            actions.Name = "actions";
            actions.ReadOnly = true;
            actions.Resizable = DataGridViewTriState.True;
            actions.SortMode = DataGridViewColumnSortMode.Automatic;
            actions.Text = "Add Batch";
            // 
            // viewbatch
            // 
            viewbatch.HeaderText = "";
            viewbatch.MinimumWidth = 80;
            viewbatch.Name = "viewbatch";
            viewbatch.ReadOnly = true;
            viewbatch.Resizable = DataGridViewTriState.True;
            viewbatch.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // InventoryHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 530);
            Controls.Add(dgvInventory);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "InventoryHome";
            Text = "InventoryHome";
            Load += InventoryHome_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private ComboBox comboBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private PictureBox btnRefresh;
        private Label label1;
        private ComboBox comboBox2;
        private Label label3;
        private PictureBox pictureBox3;
        private TextBox textBox2;
        private PictureBox pictureBox4;
        private Panel panel1;
        private Button btnAddNew;
        private DataGridView dgvInventory;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn unit;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn minstock;
        private DataGridViewTextBoxColumn reorderlevel;
        private DataGridViewTextBoxColumn batches;
        private DataGridViewTextBoxColumn unitcost;
        private DataGridViewTextBoxColumn expirydate;
        private DataGridViewTextBoxColumn stockstatus;
        private DataGridViewTextBoxColumn suppliername;
        private DataGridViewButtonColumn actions;
        private DataGridViewButtonColumn viewbatch;
    }
}
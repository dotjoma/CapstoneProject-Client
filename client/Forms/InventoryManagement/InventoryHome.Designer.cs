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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle32 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle33 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle31 = new DataGridViewCellStyle();
            panel2 = new Panel();
            comboBox2 = new ComboBox();
            label3 = new Label();
            btnAddNew = new Button();
            pictureBox3 = new PictureBox();
            textBox2 = new TextBox();
            btnRefreshData = new PictureBox();
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
            actions = new DataGridViewImageColumn();
            cmsOptions = new ContextMenuStrip(components);
            cmsAdd = new ToolStripMenuItem();
            cmsEdit = new ToolStripMenuItem();
            cmsView = new ToolStripMenuItem();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRefreshData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            cmsOptions.SuspendLayout();
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
            panel2.Controls.Add(btnRefreshData);
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
            // btnRefreshData
            // 
            btnRefreshData.Anchor = AnchorStyles.Right;
            btnRefreshData.BackColor = Color.FromArgb(232, 232, 232);
            btnRefreshData.Image = Properties.Resources.Refresh1;
            btnRefreshData.Location = new Point(595, 17);
            btnRefreshData.Name = "btnRefreshData";
            btnRefreshData.Size = new Size(24, 24);
            btnRefreshData.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRefreshData.TabIndex = 10;
            btnRefreshData.TabStop = false;
            btnRefreshData.Click += btnRefreshData_Click;
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
            dataGridViewCellStyle23.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle23.ForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle23.SelectionBackColor = Color.FromArgb(245, 242, 237);
            dataGridViewCellStyle23.SelectionForeColor = Color.FromArgb(93, 64, 55);
            dgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle23;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = Color.FromArgb(121, 85, 72);
            dataGridViewCellStyle24.Font = new Font("Segoe UI Semibold", 9.2F, FontStyle.Bold);
            dataGridViewCellStyle24.ForeColor = Color.White;
            dataGridViewCellStyle24.SelectionBackColor = Color.FromArgb(121, 85, 72);
            dataGridViewCellStyle24.SelectionForeColor = Color.White;
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
            dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            dgvInventory.ColumnHeadersHeight = 30;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { productName, category, unit, stock, minstock, reorderlevel, batches, unitcost, expirydate, stockstatus, suppliername, actions });
            dataGridViewCellStyle32.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = Color.White;
            dataGridViewCellStyle32.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle32.ForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle32.SelectionBackColor = Color.FromArgb(245, 242, 237);
            dataGridViewCellStyle32.SelectionForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle32.WrapMode = DataGridViewTriState.False;
            dgvInventory.DefaultCellStyle = dataGridViewCellStyle32;
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.EnableHeadersVisualStyles = false;
            dgvInventory.GridColor = Color.White;
            dgvInventory.Location = new Point(0, 59);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle33.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = SystemColors.Control;
            dataGridViewCellStyle33.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle33.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = Color.FromArgb(214, 192, 179);
            dataGridViewCellStyle33.SelectionForeColor = Color.White;
            dataGridViewCellStyle33.WrapMode = DataGridViewTriState.True;
            dgvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(1110, 412);
            dgvInventory.TabIndex = 5;
            dgvInventory.TabStop = false;
            dgvInventory.CellContentClick += dgvInventory_CellContentClick;
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
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleCenter;
            stock.DefaultCellStyle = dataGridViewCellStyle25;
            stock.HeaderText = "Stock";
            stock.MinimumWidth = 60;
            stock.Name = "stock";
            stock.ReadOnly = true;
            // 
            // minstock
            // 
            minstock.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleCenter;
            minstock.DefaultCellStyle = dataGridViewCellStyle26;
            minstock.FillWeight = 137.7169F;
            minstock.HeaderText = "Min Stock";
            minstock.MinimumWidth = 100;
            minstock.Name = "minstock";
            minstock.ReadOnly = true;
            // 
            // reorderlevel
            // 
            reorderlevel.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleCenter;
            reorderlevel.DefaultCellStyle = dataGridViewCellStyle27;
            reorderlevel.FillWeight = 178.85527F;
            reorderlevel.HeaderText = "Reorder Level";
            reorderlevel.MinimumWidth = 100;
            reorderlevel.Name = "reorderlevel";
            reorderlevel.ReadOnly = true;
            // 
            // batches
            // 
            batches.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleCenter;
            batches.DefaultCellStyle = dataGridViewCellStyle28;
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
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleRight;
            unitcost.DefaultCellStyle = dataGridViewCellStyle29;
            unitcost.HeaderText = "Unit Cost";
            unitcost.MinimumWidth = 75;
            unitcost.Name = "unitcost";
            unitcost.ReadOnly = true;
            // 
            // expirydate
            // 
            dataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleCenter;
            expirydate.DefaultCellStyle = dataGridViewCellStyle30;
            expirydate.HeaderText = "Expiry";
            expirydate.MinimumWidth = 6;
            expirydate.Name = "expirydate";
            expirydate.ReadOnly = true;
            // 
            // stockstatus
            // 
            dataGridViewCellStyle31.Alignment = DataGridViewContentAlignment.MiddleCenter;
            stockstatus.DefaultCellStyle = dataGridViewCellStyle31;
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
            actions.MinimumWidth = 40;
            actions.Name = "actions";
            actions.ReadOnly = true;
            actions.Resizable = DataGridViewTriState.True;
            actions.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // cmsOptions
            // 
            cmsOptions.Items.AddRange(new ToolStripItem[] { cmsAdd, cmsEdit, cmsView });
            cmsOptions.Name = "cmsOptions";
            cmsOptions.Size = new Size(144, 70);
            // 
            // cmsAdd
            // 
            cmsAdd.Name = "cmsAdd";
            cmsAdd.Size = new Size(180, 22);
            cmsAdd.Text = "Add Batch";
            cmsAdd.Click += cmsAdd_Click;
            // 
            // cmsEdit
            // 
            cmsEdit.Name = "cmsEdit";
            cmsEdit.Size = new Size(180, 22);
            cmsEdit.Text = "Edit Item";
            cmsEdit.Click += cmsEdit_Click;
            // 
            // cmsView
            // 
            cmsView.Name = "cmsView";
            cmsView.Size = new Size(180, 22);
            cmsView.Text = "View Batches";
            cmsView.Click += cmsView_Click;
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
            ((System.ComponentModel.ISupportInitialize)btnRefreshData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            cmsOptions.ResumeLayout(false);
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
        private PictureBox btnRefreshData;
        private Panel panel1;
        private Button btnAddNew;
        private DataGridView dgvInventory;
        private ContextMenuStrip cmsOptions;
        private ToolStripMenuItem cmsAdd;
        private ToolStripMenuItem cmsView;
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
        private DataGridViewImageColumn actions;
        private ToolStripMenuItem cmsEdit;
    }
}
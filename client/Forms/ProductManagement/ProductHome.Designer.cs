namespace client.Forms.ProductManagement
{
    partial class ProductHome
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductHome));
            label1 = new Label();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            label2 = new Label();
            btnNew = new Button();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            btnRefresh = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            txtItemsPerPage = new TextBox();
            label3 = new Label();
            btnPrev = new Button();
            btnNext = new Button();
            txtCurrentPage = new TextBox();
            lblPageInfo = new Label();
            lblTotalPage = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            toolTip1 = new ToolTip(components);
            panel3 = new Panel();
            dgvProducts = new DataGridView();
            cmsOptions = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            id = new DataGridViewTextBoxColumn();
            productCategory = new DataGridViewTextBoxColumn();
            productSubcategory = new DataGridViewTextBoxColumn();
            productName = new DataGridViewTextBoxColumn();
            productUnit = new DataGridViewTextBoxColumn();
            productPrice = new DataGridViewTextBoxColumn();
            productStatus = new DataGridViewImageColumn();
            actions = new DataGridViewImageColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            cmsOptions.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(62, 39, 35);
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(199, 32);
            label1.TabIndex = 0;
            label1.Text = "MANAGE MENU";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(239, 235, 233);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1024, 59);
            panel2.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Right;
            comboBox1.BackColor = Color.FromArgb(248, 245, 240);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(614, 19);
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
            label2.Location = new Point(549, 20);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 8;
            label2.Text = "Filters:";
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNew.BackColor = Color.White;
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatAppearance.MouseDownBackColor = Color.White;
            btnNew.FlatAppearance.MouseOverBackColor = Color.White;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Segoe UI", 12F);
            btnNew.ForeColor = Color.Black;
            btnNew.Image = Properties.Resources.Add1;
            btnNew.ImageAlign = ContentAlignment.MiddleLeft;
            btnNew.Location = new Point(234, 14);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(111, 31);
            btnNew.TabIndex = 7;
            btnNew.TabStop = false;
            btnNew.Text = "Add New";
            btnNew.TextAlign = ContentAlignment.MiddleRight;
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.Search;
            pictureBox2.Location = new Point(777, 17);
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
            textBox1.Location = new Point(807, 20);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search menu";
            textBox1.Size = new Size(208, 22);
            textBox1.TabIndex = 6;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(232, 232, 232);
            btnRefresh.Image = Properties.Resources.Refresh1;
            btnRefresh.Location = new Point(520, 17);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(24, 24);
            btnRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRefresh.TabIndex = 3;
            btnRefresh.TabStop = false;
            btnRefresh.Click += btnRefresh_Click;
            btnRefresh.MouseEnter += btnRefresh_MouseEnter;
            btnRefresh.MouseLeave += btnRefresh_MouseLeave;
            // 
            // timer1
            // 
            timer1.Interval = 60;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(239, 235, 233);
            panel1.Controls.Add(txtItemsPerPage);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnPrev);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(txtCurrentPage);
            panel1.Controls.Add(lblPageInfo);
            panel1.Controls.Add(lblTotalPage);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 471);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 59);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // txtItemsPerPage
            // 
            txtItemsPerPage.Location = new Point(119, 18);
            txtItemsPerPage.Name = "txtItemsPerPage";
            txtItemsPerPage.Size = new Size(25, 23);
            txtItemsPerPage.TabIndex = 15;
            txtItemsPerPage.TabStop = false;
            txtItemsPerPage.Text = "100";
            txtItemsPerPage.TextChanged += txtItemsPerPage_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 21);
            label3.Name = "label3";
            label3.Size = new Size(103, 17);
            label3.TabIndex = 14;
            label3.Text = "Items per page:";
            // 
            // btnPrev
            // 
            btnPrev.FlatAppearance.BorderColor = Color.LightGray;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Image = Properties.Resources.previous_16;
            btnPrev.Location = new Point(366, 19);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(28, 23);
            btnPrev.TabIndex = 13;
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.FlatAppearance.BorderColor = Color.LightGray;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Image = Properties.Resources.next_24;
            btnNext.Location = new Point(460, 19);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(28, 23);
            btnNext.TabIndex = 12;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // txtCurrentPage
            // 
            txtCurrentPage.BorderStyle = BorderStyle.FixedSingle;
            txtCurrentPage.Location = new Point(402, 19);
            txtCurrentPage.Name = "txtCurrentPage";
            txtCurrentPage.Size = new Size(25, 23);
            txtCurrentPage.TabIndex = 11;
            txtCurrentPage.TabStop = false;
            txtCurrentPage.Text = "100";
            txtCurrentPage.TextChanged += txtCurrentPage_TextChanged;
            // 
            // lblPageInfo
            // 
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPageInfo.Location = new Point(161, 21);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(156, 17);
            lblPageInfo.TabIndex = 10;
            lblPageInfo.Text = "Showing 1-4 of 4 batches";
            // 
            // lblTotalPage
            // 
            lblTotalPage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPage.Location = new Point(426, 17);
            lblTotalPage.Name = "lblTotalPage";
            lblTotalPage.Size = new Size(36, 23);
            lblTotalPage.TabIndex = 16;
            lblTotalPage.Text = "/100";
            lblTotalPage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.BackColor = Color.White;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.White;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Image = Properties.Resources.Delete1;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(777, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 44);
            btnDelete.TabIndex = 9;
            btnDelete.TabStop = false;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.BackColor = Color.White;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatAppearance.MouseDownBackColor = Color.White;
            btnEdit.FlatAppearance.MouseOverBackColor = Color.White;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 12F);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Image = Properties.Resources.Edit1;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(697, 6);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(74, 44);
            btnEdit.TabIndex = 8;
            btnEdit.TabStop = false;
            btnEdit.Text = "Edit";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Visible = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 100;
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 20;
            toolTip1.Popup += toolTip1_Popup;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvProducts);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(1024, 412);
            panel3.TabIndex = 3;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeColumns = false;
            dgvProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(245, 242, 237);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(93, 64, 55);
            dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(121, 85, 72);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(121, 85, 72);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.ColumnHeadersHeight = 35;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { id, productCategory, productSubcategory, productName, productUnit, productPrice, productStatus, actions });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(245, 242, 237);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle5;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.GridColor = Color.White;
            dgvProducts.Location = new Point(0, 0);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(214, 192, 179);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1024, 412);
            dgvProducts.TabIndex = 4;
            dgvProducts.TabStop = false;
            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick_1;
            dgvProducts.CellMouseClick += dgvProducts_CellMouseClick;
            // 
            // cmsOptions
            // 
            cmsOptions.ImageScalingSize = new Size(20, 20);
            cmsOptions.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            cmsOptions.Name = "cmsOptions";
            cmsOptions.Size = new Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(107, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            id.HeaderText = "ID";
            id.MinimumWidth = 60;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 60;
            // 
            // productCategory
            // 
            productCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            productCategory.FillWeight = 114.315689F;
            productCategory.HeaderText = "Category";
            productCategory.MinimumWidth = 180;
            productCategory.Name = "productCategory";
            productCategory.ReadOnly = true;
            productCategory.Width = 180;
            // 
            // productSubcategory
            // 
            productSubcategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            productSubcategory.FillWeight = 110.479927F;
            productSubcategory.HeaderText = "Sub-Category";
            productSubcategory.MinimumWidth = 180;
            productSubcategory.Name = "productSubcategory";
            productSubcategory.ReadOnly = true;
            productSubcategory.Width = 180;
            // 
            // productName
            // 
            productName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productName.FillWeight = 115.0222F;
            productName.HeaderText = "Name";
            productName.MinimumWidth = 250;
            productName.Name = "productName";
            productName.ReadOnly = true;
            // 
            // productUnit
            // 
            productUnit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            productUnit.FillWeight = 137.7169F;
            productUnit.HeaderText = "Unit";
            productUnit.MinimumWidth = 150;
            productUnit.Name = "productUnit";
            productUnit.ReadOnly = true;
            productUnit.Width = 150;
            // 
            // productPrice
            // 
            productPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            productPrice.DefaultCellStyle = dataGridViewCellStyle3;
            productPrice.FillWeight = 178.85527F;
            productPrice.HeaderText = "Price";
            productPrice.MinimumWidth = 100;
            productPrice.Name = "productPrice";
            productPrice.ReadOnly = true;
            productPrice.Width = 141;
            // 
            // productStatus
            // 
            productStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.NullValue = resources.GetObject("dataGridViewCellStyle4.NullValue");
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            productStatus.DefaultCellStyle = dataGridViewCellStyle4;
            productStatus.FillWeight = 74.16836F;
            productStatus.HeaderText = "isActive";
            productStatus.MinimumWidth = 80;
            productStatus.Name = "productStatus";
            productStatus.ReadOnly = true;
            productStatus.Resizable = DataGridViewTriState.True;
            productStatus.SortMode = DataGridViewColumnSortMode.Automatic;
            productStatus.Width = 80;
            // 
            // actions
            // 
            actions.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            actions.HeaderText = "Actions";
            actions.MinimumWidth = 60;
            actions.Name = "actions";
            actions.ReadOnly = true;
            actions.Resizable = DataGridViewTriState.True;
            actions.SortMode = DataGridViewColumnSortMode.Automatic;
            actions.Width = 60;
            // 
            // ProductHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1024, 530);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductHome";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductHome";
            Load += ProductHome_Load;
            KeyDown += ProductHome_KeyDown;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            cmsOptions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Button btnNew;
        private Button btnDelete;
        private Button btnEdit;
        private PictureBox btnRefresh;
        private ToolTip toolTip1;
        private Panel panel3;
        private ComboBox comboBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private ContextMenuStrip cmsOptions;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private DataGridView dgvProducts;
        private TextBox txtItemsPerPage;
        private Label label3;
        private Button btnPrev;
        private Button btnNext;
        private TextBox txtCurrentPage;
        private Label lblPageInfo;
        private Label lblTotalPage;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn productCategory;
        private DataGridViewTextBoxColumn productSubcategory;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn productUnit;
        private DataGridViewTextBoxColumn productPrice;
        private DataGridViewImageColumn productStatus;
        private DataGridViewImageColumn actions;
    }
}
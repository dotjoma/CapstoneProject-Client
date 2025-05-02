namespace client.Forms.InventoryManagement
{
    partial class ViewBatches
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblHeader = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            lblDescription = new Label();
            lblTitle = new Label();
            panel2 = new Panel();
            btnClose = new Button();
            panel4 = new Panel();
            dgvBatches = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            batchnumber = new DataGridViewTextBoxColumn();
            purchasedate = new DataGridViewTextBoxColumn();
            expirydate = new DataGridViewTextBoxColumn();
            initialquantity = new DataGridViewTextBoxColumn();
            currentquantity = new DataGridViewTextBoxColumn();
            unitcost = new DataGridViewTextBoxColumn();
            supplier = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            actions = new DataGridViewImageColumn();
            panel3 = new Panel();
            txtItemsPerPage = new TextBox();
            label3 = new Label();
            btnPrev = new Button();
            btnNext = new Button();
            txtCurrentPage = new TextBox();
            lblPageInfo = new Label();
            lblTotalPage = new Label();
            cmsOptions = new ContextMenuStrip(components);
            cmsEdit = new ToolStripMenuItem();
            cmsDelete = new ToolStripMenuItem();
            pnlHeader.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBatches).BeginInit();
            panel3.SuspendLayout();
            cmsOptions.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(121, 85, 72);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Controls.Add(label2);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 2, 3, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(962, 34);
            pnlHeader.TabIndex = 63;
            // 
            // lblHeader
            // 
            lblHeader.Anchor = AnchorStyles.Left;
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.FromArgb(121, 85, 72);
            lblHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(12, 7);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(241, 21);
            lblHeader.TabIndex = 2;
            lblHeader.Text = "View Batches - Chicken  Breast";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(121, 85, 72);
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, -28);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 1;
            label2.Text = "Add New Batch";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(121, 85, 72);
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, -60);
            label1.Name = "label1";
            label1.Size = new Size(358, 25);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management - Add New Item";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 78);
            panel1.TabIndex = 64;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.Black;
            lblDescription.Location = new Point(12, 42);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(270, 21);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Category: Meat | Current Stock: 20/30";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(12, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(238, 30);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Chicken Breast Batches";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(232, 232, 232);
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 504);
            panel2.Name = "panel2";
            panel2.Size = new Size(962, 45);
            panel2.TabIndex = 65;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(854, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(97, 31);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dgvBatches);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(pnlHeader);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(964, 551);
            panel4.TabIndex = 68;
            panel4.Paint += panel4_Paint;
            // 
            // dgvBatches
            // 
            dgvBatches.AllowUserToAddRows = false;
            dgvBatches.AllowUserToDeleteRows = false;
            dgvBatches.AllowUserToResizeColumns = false;
            dgvBatches.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(245, 242, 237);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(93, 64, 55);
            dgvBatches.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBatches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBatches.BackgroundColor = Color.White;
            dgvBatches.BorderStyle = BorderStyle.None;
            dgvBatches.CausesValidation = false;
            dgvBatches.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(121, 85, 72);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.2F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(121, 85, 72);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBatches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBatches.ColumnHeadersHeight = 30;
            dgvBatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBatches.Columns.AddRange(new DataGridViewColumn[] { id, batchnumber, purchasedate, expirydate, initialquantity, currentquantity, unitcost, supplier, status, actions });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(245, 242, 237);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvBatches.DefaultCellStyle = dataGridViewCellStyle9;
            dgvBatches.EnableHeadersVisualStyles = false;
            dgvBatches.GridColor = Color.White;
            dgvBatches.Location = new Point(0, 112);
            dgvBatches.MultiSelect = false;
            dgvBatches.Name = "dgvBatches";
            dgvBatches.ReadOnly = true;
            dgvBatches.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(214, 192, 179);
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvBatches.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvBatches.RowHeadersVisible = false;
            dgvBatches.RowHeadersWidth = 51;
            dgvBatches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBatches.Size = new Size(962, 351);
            dgvBatches.TabIndex = 69;
            dgvBatches.TabStop = false;
            dgvBatches.CellContentClick += dgvBatches_CellContentClick;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            id.HeaderText = "ID";
            id.MinimumWidth = 50;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 50;
            // 
            // batchnumber
            // 
            batchnumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            batchnumber.FillWeight = 115.0222F;
            batchnumber.HeaderText = "Batch #";
            batchnumber.MinimumWidth = 100;
            batchnumber.Name = "batchnumber";
            batchnumber.ReadOnly = true;
            // 
            // purchasedate
            // 
            purchasedate.HeaderText = "Purchase Date";
            purchasedate.MinimumWidth = 100;
            purchasedate.Name = "purchasedate";
            purchasedate.ReadOnly = true;
            // 
            // expirydate
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            expirydate.DefaultCellStyle = dataGridViewCellStyle3;
            expirydate.HeaderText = "Expiry Date";
            expirydate.MinimumWidth = 100;
            expirydate.Name = "expirydate";
            expirydate.ReadOnly = true;
            // 
            // initialquantity
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            initialquantity.DefaultCellStyle = dataGridViewCellStyle4;
            initialquantity.HeaderText = "Initial Qty";
            initialquantity.MinimumWidth = 60;
            initialquantity.Name = "initialquantity";
            initialquantity.ReadOnly = true;
            // 
            // currentquantity
            // 
            currentquantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            currentquantity.DefaultCellStyle = dataGridViewCellStyle5;
            currentquantity.FillWeight = 137.7169F;
            currentquantity.HeaderText = "Current Qty";
            currentquantity.MinimumWidth = 100;
            currentquantity.Name = "currentquantity";
            currentquantity.ReadOnly = true;
            // 
            // unitcost
            // 
            unitcost.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            unitcost.DefaultCellStyle = dataGridViewCellStyle6;
            unitcost.HeaderText = "Unit Cost";
            unitcost.MinimumWidth = 70;
            unitcost.Name = "unitcost";
            unitcost.ReadOnly = true;
            unitcost.Width = 70;
            // 
            // supplier
            // 
            supplier.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            supplier.DefaultCellStyle = dataGridViewCellStyle7;
            supplier.FillWeight = 74.16836F;
            supplier.HeaderText = "Supplier";
            supplier.MinimumWidth = 150;
            supplier.Name = "supplier";
            supplier.ReadOnly = true;
            supplier.Resizable = DataGridViewTriState.True;
            // 
            // status
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            status.DefaultCellStyle = dataGridViewCellStyle8;
            status.HeaderText = "Status";
            status.MinimumWidth = 120;
            status.Name = "status";
            status.ReadOnly = true;
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
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtItemsPerPage);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnPrev);
            panel3.Controls.Add(btnNext);
            panel3.Controls.Add(txtCurrentPage);
            panel3.Controls.Add(lblPageInfo);
            panel3.Controls.Add(lblTotalPage);
            panel3.Location = new Point(-10, 465);
            panel3.Name = "panel3";
            panel3.Size = new Size(972, 39);
            panel3.TabIndex = 68;
            // 
            // txtItemsPerPage
            // 
            txtItemsPerPage.Location = new Point(121, 7);
            txtItemsPerPage.Name = "txtItemsPerPage";
            txtItemsPerPage.Size = new Size(25, 23);
            txtItemsPerPage.TabIndex = 5;
            txtItemsPerPage.Text = "100";
            txtItemsPerPage.TextChanged += txtItemsPerPage_TextChanged;
            txtItemsPerPage.Enter += txtItemsPerPage_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 10);
            label3.Name = "label3";
            label3.Size = new Size(103, 17);
            label3.TabIndex = 4;
            label3.Text = "Items per page:";
            // 
            // btnPrev
            // 
            btnPrev.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrev.FlatAppearance.BorderColor = Color.LightGray;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Image = Properties.Resources.previous_16;
            btnPrev.Location = new Point(392, 7);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(28, 23);
            btnPrev.TabIndex = 3;
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNext.FlatAppearance.BorderColor = Color.LightGray;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Image = Properties.Resources.next_24;
            btnNext.Location = new Point(486, 7);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(28, 23);
            btnNext.TabIndex = 2;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // txtCurrentPage
            // 
            txtCurrentPage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCurrentPage.Location = new Point(428, 7);
            txtCurrentPage.Name = "txtCurrentPage";
            txtCurrentPage.Size = new Size(25, 23);
            txtCurrentPage.TabIndex = 1;
            txtCurrentPage.Text = "100";
            txtCurrentPage.TextChanged += txtCurrentPage_TextChanged;
            txtCurrentPage.Enter += txtCurrentPage_Enter;
            // 
            // lblPageInfo
            // 
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPageInfo.Location = new Point(163, 10);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(156, 17);
            lblPageInfo.TabIndex = 0;
            lblPageInfo.Text = "Showing 1-4 of 4 batches";
            // 
            // lblTotalPage
            // 
            lblTotalPage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalPage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPage.Location = new Point(452, 5);
            lblTotalPage.Name = "lblTotalPage";
            lblTotalPage.Size = new Size(36, 23);
            lblTotalPage.TabIndex = 6;
            lblTotalPage.Text = "/100";
            lblTotalPage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmsOptions
            // 
            cmsOptions.Items.AddRange(new ToolStripItem[] { cmsEdit, cmsDelete });
            cmsOptions.Name = "cmsActions";
            cmsOptions.Size = new Size(108, 48);
            // 
            // cmsEdit
            // 
            cmsEdit.Name = "cmsEdit";
            cmsEdit.Size = new Size(107, 22);
            cmsEdit.Text = "Edit";
            cmsEdit.Click += cmsEdit_Click;
            // 
            // cmsDelete
            // 
            cmsDelete.Name = "cmsDelete";
            cmsDelete.Size = new Size(107, 22);
            cmsDelete.Text = "Delete";
            cmsDelete.Click += cmsDelete_Click;
            // 
            // ViewBatches
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 551);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewBatches";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBatches";
            Load += ViewBatches_Load;
            KeyDown += ViewBatches_KeyDown;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBatches).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            cmsOptions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label label2;
        private Label label1;
        private Label lblHeader;
        private Panel panel1;
        private Label lblTitle;
        private Label lblDescription;
        private Panel panel2;
        private Button btnClose;
        private Panel panel4;
        private Panel panel3;
        private Button btnPrev;
        private Button btnNext;
        private TextBox txtCurrentPage;
        private Label lblPageInfo;
        private DataGridView dgvBatches;
        private TextBox txtItemsPerPage;
        private Label label3;
        private Label lblTotalPage;
        private ContextMenuStrip cmsOptions;
        private ToolStripMenuItem cmsEdit;
        private ToolStripMenuItem cmsDelete;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn batchnumber;
        private DataGridViewTextBoxColumn purchasedate;
        private DataGridViewTextBoxColumn expirydate;
        private DataGridViewTextBoxColumn initialquantity;
        private DataGridViewTextBoxColumn currentquantity;
        private DataGridViewTextBoxColumn unitcost;
        private DataGridViewTextBoxColumn supplier;
        private DataGridViewTextBoxColumn status;
        private DataGridViewImageColumn actions;
    }
}
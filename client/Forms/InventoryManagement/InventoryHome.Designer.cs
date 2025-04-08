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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
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
            localname = new DataGridViewTextBoxColumn();
            productCategory = new DataGridViewTextBoxColumn();
            currentstock = new DataGridViewTextBoxColumn();
            unitsymbol = new DataGridViewTextBoxColumn();
            reorderlevel = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            lastdelivery = new DataGridViewTextBoxColumn();
            expirydate = new DataGridViewTextBoxColumn();
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
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1170, 79);
            panel2.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Right;
            comboBox2.BackColor = Color.FromArgb(248, 245, 240);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.System;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(690, 25);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(148, 28);
            comboBox2.TabIndex = 14;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(93, 64, 55);
            label3.Location = new Point(615, 27);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
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
            btnAddNew.Location = new Point(210, 19);
            btnAddNew.Margin = new Padding(3, 4, 3, 4);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(132, 41);
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
            pictureBox3.Location = new Point(876, 23);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 32);
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
            textBox2.Location = new Point(910, 26);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Search Item(s)";
            textBox2.Size = new Size(238, 27);
            textBox2.TabIndex = 11;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Right;
            pictureBox4.BackColor = Color.FromArgb(232, 232, 232);
            pictureBox4.Image = Properties.Resources.Refresh1;
            pictureBox4.Location = new Point(582, 23);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(27, 32);
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
            comboBox1.Location = new Point(1621, 13);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 28);
            comboBox1.TabIndex = 9;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(93, 64, 55);
            label2.Location = new Point(1540, 14);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 8;
            label2.Text = "Filter by:";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.Search;
            pictureBox2.Location = new Point(1807, 12);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 32);
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
            textBox1.Location = new Point(1841, 13);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Item(s)";
            textBox1.Size = new Size(238, 27);
            textBox1.TabIndex = 6;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(232, 232, 232);
            btnRefresh.Image = Properties.Resources.Refresh1;
            btnRefresh.Location = new Point(1490, 12);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(27, 32);
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
            label1.Location = new Point(14, 19);
            label1.Name = "label1";
            label1.Size = new Size(190, 41);
            label1.TabIndex = 0;
            label1.Text = "INVENTORY";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(239, 235, 233);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 628);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1170, 79);
            panel1.TabIndex = 3;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.AllowUserToResizeColumns = false;
            dgvInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(245, 242, 237);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(93, 64, 55);
            dgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(121, 85, 72);
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(121, 85, 72);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvInventory.ColumnHeadersHeight = 30;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { productName, localname, productCategory, currentstock, unitsymbol, reorderlevel, status, lastdelivery, expirydate });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(245, 242, 237);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvInventory.DefaultCellStyle = dataGridViewCellStyle11;
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.EnableHeadersVisualStyles = false;
            dgvInventory.GridColor = Color.White;
            dgvInventory.Location = new Point(0, 79);
            dgvInventory.Margin = new Padding(3, 4, 3, 4);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(214, 192, 179);
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(1170, 549);
            dgvInventory.TabIndex = 5;
            dgvInventory.TabStop = false;
            // 
            // productName
            // 
            productName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            productName.FillWeight = 115.0222F;
            productName.HeaderText = "Name";
            productName.MinimumWidth = 100;
            productName.Name = "productName";
            productName.ReadOnly = true;
            productName.Width = 125;
            // 
            // localname
            // 
            localname.HeaderText = "Local Name";
            localname.MinimumWidth = 6;
            localname.Name = "localname";
            localname.ReadOnly = true;
            // 
            // productCategory
            // 
            productCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            productCategory.FillWeight = 114.315689F;
            productCategory.HeaderText = "Category";
            productCategory.MinimumWidth = 150;
            productCategory.Name = "productCategory";
            productCategory.ReadOnly = true;
            productCategory.Width = 150;
            // 
            // currentstock
            // 
            currentstock.HeaderText = "Current Stock";
            currentstock.MinimumWidth = 6;
            currentstock.Name = "currentstock";
            currentstock.ReadOnly = true;
            // 
            // unitsymbol
            // 
            unitsymbol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            unitsymbol.FillWeight = 137.7169F;
            unitsymbol.HeaderText = "Unit Symbol";
            unitsymbol.MinimumWidth = 150;
            unitsymbol.Name = "unitsymbol";
            unitsymbol.ReadOnly = true;
            unitsymbol.Width = 150;
            // 
            // reorderlevel
            // 
            reorderlevel.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            reorderlevel.DefaultCellStyle = dataGridViewCellStyle9;
            reorderlevel.FillWeight = 178.85527F;
            reorderlevel.HeaderText = "Reorder Level";
            reorderlevel.MinimumWidth = 100;
            reorderlevel.Name = "reorderlevel";
            reorderlevel.ReadOnly = true;
            reorderlevel.Width = 141;
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            status.DefaultCellStyle = dataGridViewCellStyle10;
            status.FillWeight = 74.16836F;
            status.HeaderText = "Status";
            status.MinimumWidth = 100;
            status.Name = "status";
            status.ReadOnly = true;
            status.Resizable = DataGridViewTriState.True;
            status.Width = 125;
            // 
            // lastdelivery
            // 
            lastdelivery.HeaderText = "Last Delivery";
            lastdelivery.MinimumWidth = 6;
            lastdelivery.Name = "lastdelivery";
            lastdelivery.ReadOnly = true;
            // 
            // expirydate
            // 
            expirydate.HeaderText = "Expiry";
            expirydate.MinimumWidth = 6;
            expirydate.Name = "expirydate";
            expirydate.ReadOnly = true;
            // 
            // InventoryHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 707);
            Controls.Add(dgvInventory);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InventoryHome";
            Text = "InventoryHome";
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
        private DataGridViewTextBoxColumn localname;
        private DataGridViewTextBoxColumn productCategory;
        private DataGridViewTextBoxColumn currentstock;
        private DataGridViewTextBoxColumn unitsymbol;
        private DataGridViewTextBoxColumn reorderlevel;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn lastdelivery;
        private DataGridViewTextBoxColumn expirydate;
    }
}
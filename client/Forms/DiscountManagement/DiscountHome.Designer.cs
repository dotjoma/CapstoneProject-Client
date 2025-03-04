namespace client.Forms.DiscountManagement
{
    partial class DiscountHome
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscountHome));
            panel2 = new Panel();
            btnRefreshh = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnRefresh = new PictureBox();
            panel3 = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            btnNew = new Button();
            panel1 = new Panel();
            dgvDiscount = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            value = new DataGridViewTextBoxColumn();
            vat_exempt = new DataGridViewTextBoxColumn();
            applicable_to = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRefreshh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDiscount).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(btnRefreshh);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(964, 59);
            panel2.TabIndex = 1;
            // 
            // btnRefreshh
            // 
            btnRefreshh.Anchor = AnchorStyles.Right;
            btnRefreshh.BackColor = Color.White;
            btnRefreshh.Image = Properties.Resources.Refresh;
            btnRefreshh.Location = new Point(928, 17);
            btnRefreshh.Name = "btnRefreshh";
            btnRefreshh.Size = new Size(24, 24);
            btnRefreshh.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRefreshh.TabIndex = 4;
            btnRefreshh.TabStop = false;
            btnRefreshh.Click += btnRefreshh_Click;
            btnRefreshh.MouseEnter += btnRefreshh_MouseEnter;
            btnRefreshh.MouseLeave += btnRefreshh_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.Discount;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(98, 87, 87);
            label1.Location = new Point(58, 13);
            label1.Name = "label1";
            label1.Size = new Size(149, 32);
            label1.TabIndex = 0;
            label1.Text = "DISCOUNTS";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Right;
            btnRefresh.BackColor = Color.White;
            btnRefresh.Image = Properties.Resources.Refresh;
            btnRefresh.Location = new Point(1793, 132);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(24, 24);
            btnRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRefresh.TabIndex = 3;
            btnRefresh.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(98, 87, 87);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnNew);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 506);
            panel3.Name = "panel3";
            panel3.Size = new Size(964, 55);
            panel3.TabIndex = 4;
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
            btnDelete.Image = Properties.Resources.Delete;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(172, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 44);
            btnDelete.TabIndex = 12;
            btnDelete.TabStop = false;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = false;
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
            btnEdit.Image = Properties.Resources.Edit;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(92, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(74, 44);
            btnEdit.TabIndex = 11;
            btnEdit.TabStop = false;
            btnEdit.Text = "Edit";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.UseVisualStyleBackColor = false;
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
            btnNew.Image = Properties.Resources.Add;
            btnNew.ImageAlign = ContentAlignment.MiddleLeft;
            btnNew.Location = new Point(12, 5);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(74, 44);
            btnNew.TabIndex = 10;
            btnNew.TabStop = false;
            btnNew.Text = "New";
            btnNew.TextAlign = ContentAlignment.MiddleRight;
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvDiscount);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 447);
            panel1.TabIndex = 5;
            // 
            // dgvDiscount
            // 
            dgvDiscount.AllowUserToAddRows = false;
            dgvDiscount.AllowUserToDeleteRows = false;
            dgvDiscount.AllowUserToResizeColumns = false;
            dgvDiscount.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dgvDiscount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDiscount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDiscount.BackgroundColor = Color.White;
            dgvDiscount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(214, 192, 179);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(98, 87, 87);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(214, 192, 179);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(98, 87, 87);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDiscount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDiscount.ColumnHeadersHeight = 35;
            dgvDiscount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDiscount.Columns.AddRange(new DataGridViewColumn[] { id, name, type, value, vat_exempt, applicable_to, status });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvDiscount.DefaultCellStyle = dataGridViewCellStyle5;
            dgvDiscount.Dock = DockStyle.Fill;
            dgvDiscount.EnableHeadersVisualStyles = false;
            dgvDiscount.Location = new Point(0, 0);
            dgvDiscount.MultiSelect = false;
            dgvDiscount.Name = "dgvDiscount";
            dgvDiscount.ReadOnly = true;
            dgvDiscount.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDiscount.RowHeadersVisible = false;
            dgvDiscount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiscount.Size = new Size(964, 447);
            dgvDiscount.TabIndex = 6;
            dgvDiscount.TabStop = false;
            dgvDiscount.CellFormatting += dgvDiscount_CellFormatting;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            id.FillWeight = 114.315689F;
            id.HeaderText = "ID";
            id.MinimumWidth = 60;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 60;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            name.FillWeight = 110.479927F;
            name.HeaderText = "Name";
            name.MinimumWidth = 150;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 171;
            // 
            // type
            // 
            type.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            type.FillWeight = 115.0222F;
            type.HeaderText = "Type";
            type.MinimumWidth = 150;
            type.Name = "type";
            type.ReadOnly = true;
            type.Width = 150;
            // 
            // value
            // 
            value.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            value.DefaultCellStyle = dataGridViewCellStyle3;
            value.FillWeight = 137.7169F;
            value.HeaderText = "Value";
            value.MinimumWidth = 80;
            value.Name = "value";
            value.ReadOnly = true;
            value.Width = 80;
            // 
            // vat_exempt
            // 
            vat_exempt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            vat_exempt.FillWeight = 178.85527F;
            vat_exempt.HeaderText = "VAT Exempt";
            vat_exempt.MinimumWidth = 100;
            vat_exempt.Name = "vat_exempt";
            vat_exempt.ReadOnly = true;
            // 
            // applicable_to
            // 
            applicable_to.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            applicable_to.HeaderText = "Applicable To";
            applicable_to.MinimumWidth = 140;
            applicable_to.Name = "applicable_to";
            applicable_to.ReadOnly = true;
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            status.DefaultCellStyle = dataGridViewCellStyle4;
            status.FillWeight = 74.16836F;
            status.HeaderText = "Status";
            status.MinimumWidth = 80;
            status.Name = "status";
            status.ReadOnly = true;
            status.Width = 80;
            // 
            // DiscountHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(964, 561);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(btnRefresh);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DiscountHome";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ELICIAS GARDEN FOOD PARK";
            FormClosing += DiscountHome_FormClosing;
            Load += DiscountHome_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnRefreshh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDiscount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox btnRefresh;
        private Panel panel3;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnNew;
        private Panel panel1;
        private DataGridView dgvDiscount;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn value;
        private DataGridViewTextBoxColumn vat_exempt;
        private DataGridViewTextBoxColumn applicable_to;
        private DataGridViewTextBoxColumn status;
        private PictureBox btnRefreshh;
    }
}
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
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDiscount).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(239, 235, 233);
            panel2.Controls.Add(btnRefreshh);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1102, 79);
            panel2.TabIndex = 1;
            // 
            // btnRefreshh
            // 
            btnRefreshh.Anchor = AnchorStyles.Right;
            btnRefreshh.BackColor = Color.White;
            btnRefreshh.Image = Properties.Resources.Refresh;
            btnRefreshh.Location = new Point(1061, 23);
            btnRefreshh.Margin = new Padding(3, 4, 3, 4);
            btnRefreshh.Name = "btnRefreshh";
            btnRefreshh.Size = new Size(27, 32);
            btnRefreshh.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRefreshh.TabIndex = 4;
            btnRefreshh.TabStop = false;
            btnRefreshh.Click += btnRefreshh_Click;
            btnRefreshh.MouseEnter += btnRefreshh_MouseEnter;
            btnRefreshh.MouseLeave += btnRefreshh_MouseLeave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(98, 87, 87);
            label1.Location = new Point(14, 19);
            label1.Name = "label1";
            label1.Size = new Size(190, 41);
            label1.TabIndex = 0;
            label1.Text = "DISCOUNTS";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Right;
            btnRefresh.BackColor = Color.White;
            btnRefresh.Image = Properties.Resources.Refresh;
            btnRefresh.Location = new Point(2049, 127);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(27, 32);
            btnRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRefresh.TabIndex = 3;
            btnRefresh.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(239, 235, 233);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnNew);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 577);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1102, 73);
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
            btnDelete.Location = new Point(197, 7);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 59);
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
            btnEdit.Location = new Point(105, 7);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(85, 59);
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
            btnNew.Location = new Point(14, 7);
            btnNew.Margin = new Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(85, 59);
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
            panel1.Location = new Point(0, 79);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1102, 498);
            panel1.TabIndex = 5;
            // 
            // dgvDiscount
            // 
            dgvDiscount.AllowUserToAddRows = false;
            dgvDiscount.AllowUserToDeleteRows = false;
            dgvDiscount.AllowUserToResizeColumns = false;
            dgvDiscount.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(245, 242, 237);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(93, 64, 55);
            dgvDiscount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDiscount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDiscount.BackgroundColor = Color.White;
            dgvDiscount.BorderStyle = BorderStyle.None;
            dgvDiscount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(121, 85, 72);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(121, 85, 72);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDiscount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDiscount.ColumnHeadersHeight = 35;
            dgvDiscount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDiscount.Columns.AddRange(new DataGridViewColumn[] { id, name, type, value, vat_exempt, applicable_to, status });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(245, 242, 237);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvDiscount.DefaultCellStyle = dataGridViewCellStyle5;
            dgvDiscount.Dock = DockStyle.Fill;
            dgvDiscount.EnableHeadersVisualStyles = false;
            dgvDiscount.GridColor = Color.White;
            dgvDiscount.Location = new Point(0, 0);
            dgvDiscount.Margin = new Padding(3, 4, 3, 4);
            dgvDiscount.MultiSelect = false;
            dgvDiscount.Name = "dgvDiscount";
            dgvDiscount.ReadOnly = true;
            dgvDiscount.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDiscount.RowHeadersVisible = false;
            dgvDiscount.RowHeadersWidth = 51;
            dgvDiscount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiscount.Size = new Size(1102, 498);
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
            vat_exempt.Width = 125;
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1102, 650);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(btnRefresh);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "DiscountHome";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ELICIAS GARDEN FOOD PARK";
            FormClosing += DiscountHome_FormClosing;
            Load += DiscountHome_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnRefreshh).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDiscount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
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
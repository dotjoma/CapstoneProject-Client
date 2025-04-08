namespace client.Forms.SalesReport
{
    partial class SalesReportHome
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            btnRefresh = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            dgvOrders = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            transno = new DataGridViewTextBoxColumn();
            cashier = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            discount = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            ordertime = new DataGridViewTextBoxColumn();
            orderdate = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(239, 235, 233);
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
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(136, 41);
            label1.TabIndex = 0;
            label1.Text = "ORDERS";
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
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AllowUserToResizeColumns = false;
            dgvOrders.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(245, 242, 237);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(93, 64, 55);
            dgvOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.BorderStyle = BorderStyle.None;
            dgvOrders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(121, 85, 72);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(121, 85, 72);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvOrders.ColumnHeadersHeight = 35;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { id, transno, cashier, price, quantity, discount, total, ordertime, orderdate });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(245, 242, 237);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvOrders.DefaultCellStyle = dataGridViewCellStyle11;
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.EnableHeadersVisualStyles = false;
            dgvOrders.GridColor = Color.White;
            dgvOrders.Location = new Point(0, 79);
            dgvOrders.Margin = new Padding(3, 4, 3, 4);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(214, 192, 179);
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(1170, 549);
            dgvOrders.TabIndex = 5;
            dgvOrders.TabStop = false;
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
            // transno
            // 
            transno.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            transno.DefaultCellStyle = dataGridViewCellStyle3;
            transno.FillWeight = 114.315689F;
            transno.HeaderText = "Trans No.";
            transno.MinimumWidth = 150;
            transno.Name = "transno";
            transno.ReadOnly = true;
            transno.Width = 150;
            // 
            // cashier
            // 
            cashier.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cashier.DefaultCellStyle = dataGridViewCellStyle4;
            cashier.FillWeight = 110.479927F;
            cashier.HeaderText = "Cashier";
            cashier.MinimumWidth = 100;
            cashier.Name = "cashier";
            cashier.ReadOnly = true;
            // 
            // price
            // 
            price.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            price.DefaultCellStyle = dataGridViewCellStyle5;
            price.FillWeight = 115.0222F;
            price.HeaderText = "Price";
            price.MinimumWidth = 100;
            price.Name = "price";
            price.ReadOnly = true;
            price.Width = 125;
            // 
            // quantity
            // 
            quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            quantity.DefaultCellStyle = dataGridViewCellStyle6;
            quantity.FillWeight = 137.7169F;
            quantity.HeaderText = "Qty.";
            quantity.MinimumWidth = 100;
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            quantity.Width = 125;
            // 
            // discount
            // 
            discount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            discount.DefaultCellStyle = dataGridViewCellStyle7;
            discount.FillWeight = 178.85527F;
            discount.HeaderText = "Discount";
            discount.MinimumWidth = 100;
            discount.Name = "discount";
            discount.ReadOnly = true;
            discount.Width = 125;
            // 
            // total
            // 
            total.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            total.DefaultCellStyle = dataGridViewCellStyle8;
            total.HeaderText = "Total";
            total.MinimumWidth = 100;
            total.Name = "total";
            total.ReadOnly = true;
            total.Width = 125;
            // 
            // ordertime
            // 
            ordertime.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ordertime.DefaultCellStyle = dataGridViewCellStyle9;
            ordertime.HeaderText = "Order Time";
            ordertime.MinimumWidth = 150;
            ordertime.Name = "ordertime";
            ordertime.ReadOnly = true;
            ordertime.Width = 150;
            // 
            // orderdate
            // 
            orderdate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderdate.DefaultCellStyle = dataGridViewCellStyle10;
            orderdate.HeaderText = "Order Date";
            orderdate.MinimumWidth = 150;
            orderdate.Name = "orderdate";
            orderdate.ReadOnly = true;
            orderdate.Width = 150;
            // 
            // SalesReportHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 707);
            Controls.Add(dgvOrders);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalesReportHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalesReportHome";
            Load += SalesReportHome_Load;
            Shown += SalesReportHome_Shown;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
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
        private Panel panel1;
        private DataGridView dgvOrders;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn transno;
        private DataGridViewTextBoxColumn cashier;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn discount;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn ordertime;
        private DataGridViewTextBoxColumn orderdate;
    }
}
namespace client.Forms.Order
{
    partial class OrderEntryForm
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
            cartPanel = new FlowLayoutPanel();
            panel2 = new Panel();
            lblTotal = new Label();
            label10 = new Label();
            lblVat = new Label();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            btnPayment = new Button();
            lblVatable = new Label();
            lblDiscount = new Label();
            lblSubtotal = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            lblDateTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlHeader = new Panel();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            panel4 = new Panel();
            categoriesPanel = new FlowLayoutPanel();
            panel5 = new Panel();
            textBox1 = new TextBox();
            pnlContainer = new Panel();
            btnRefresh = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            pnlHeader.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
            SuspendLayout();
            // 
            // cartPanel
            // 
            cartPanel.AutoScroll = true;
            cartPanel.BackColor = Color.White;
            cartPanel.BorderStyle = BorderStyle.FixedSingle;
            cartPanel.Dock = DockStyle.Fill;
            cartPanel.Location = new Point(0, 56);
            cartPanel.Name = "cartPanel";
            cartPanel.Size = new Size(350, 433);
            cartPanel.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(lblVat);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnPayment);
            panel2.Controls.Add(lblVatable);
            panel2.Controls.Add(lblDiscount);
            panel2.Controls.Add(lblSubtotal);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 489);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 245);
            panel2.TabIndex = 7;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(98, 87, 87);
            lblTotal.Location = new Point(274, 131);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(63, 32);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "0.00";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(98, 87, 87);
            label10.Location = new Point(6, 131);
            label10.Name = "label10";
            label10.Size = new Size(85, 32);
            label10.TabIndex = 12;
            label10.Text = "TOTAL";
            // 
            // lblVat
            // 
            lblVat.AutoSize = true;
            lblVat.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVat.Location = new Point(294, 82);
            lblVat.Name = "lblVat";
            lblVat.Size = new Size(43, 18);
            lblVat.TabIndex = 11;
            lblVat.Text = "0.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 84);
            label8.Name = "label8";
            label8.Size = new Size(67, 17);
            label8.TabIndex = 10;
            label8.Text = "VAT(12%)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 61);
            label6.Name = "label6";
            label6.Size = new Size(58, 17);
            label6.TabIndex = 9;
            label6.Text = "Vat-able";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 39);
            label4.Name = "label4";
            label4.Size = new Size(63, 17);
            label4.TabIndex = 8;
            label4.Text = "Discount";
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.Teal;
            btnPayment.Dock = DockStyle.Bottom;
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = Color.Black;
            btnPayment.Location = new Point(0, 191);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(348, 52);
            btnPayment.TabIndex = 6;
            btnPayment.TabStop = false;
            btnPayment.Text = "PAYMENT";
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Click += btnPayment_Click;
            // 
            // lblVatable
            // 
            lblVatable.AutoSize = true;
            lblVatable.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVatable.Location = new Point(294, 60);
            lblVatable.Name = "lblVatable";
            lblVatable.Size = new Size(43, 18);
            lblVatable.TabIndex = 5;
            lblVatable.Text = "0.00";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscount.Location = new Point(294, 37);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(43, 18);
            lblDiscount.TabIndex = 3;
            lblDiscount.Text = "0.00";
            // 
            // lblSubtotal
            // 
            lblSubtotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(294, 14);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.RightToLeft = RightToLeft.Yes;
            lblSubtotal.Size = new Size(43, 18);
            lblSubtotal.TabIndex = 1;
            lblSubtotal.Text = "0.00";
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 15);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 0;
            label1.Text = "Sub-Total";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 56);
            panel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(98, 87, 87);
            label3.Location = new Point(0, 33);
            label3.Name = "label3";
            label3.Size = new Size(83, 17);
            label3.TabIndex = 14;
            label3.Text = "ORDER NO :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(98, 87, 87);
            label2.Location = new Point(0, 3);
            label2.Name = "label2";
            label2.Size = new Size(159, 21);
            label2.TabIndex = 13;
            label2.Text = "TRANSACTION NO :";
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = AnchorStyles.Right;
            lblDateTime.AutoSize = true;
            lblDateTime.ForeColor = Color.White;
            lblDateTime.Location = new Point(674, 9);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(38, 16);
            lblDateTime.TabIndex = 5;
            lblDateTime.Text = "- - -";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(98, 87, 87);
            pnlHeader.Controls.Add(lblDateTime);
            pnlHeader.Controls.Add(menuStrip1);
            pnlHeader.Dock = DockStyle.Bottom;
            pnlHeader.Location = new Point(0, 734);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1024, 34);
            pnlHeader.TabIndex = 24;
            pnlHeader.MouseDown += pnlHeader_MouseDown;
            pnlHeader.MouseMove += pnlHeader_MouseMove;
            pnlHeader.MouseUp += pnlHeader_MouseUp;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 5);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(63, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.ForeColor = Color.White;
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(55, 20);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(cartPanel);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel2);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(674, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(350, 734);
            panel4.TabIndex = 25;
            // 
            // categoriesPanel
            // 
            categoriesPanel.BackColor = Color.Gainsboro;
            categoriesPanel.Dock = DockStyle.Bottom;
            categoriesPanel.Location = new Point(0, 662);
            categoriesPanel.Name = "categoriesPanel";
            categoriesPanel.Size = new Size(674, 72);
            categoriesPanel.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.Controls.Add(btnRefresh);
            panel5.Controls.Add(textBox1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(674, 56);
            panel5.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Right;
            textBox1.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(438, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 26);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            // 
            // pnlContainer
            // 
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 56);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(674, 606);
            pnlContainer.TabIndex = 30;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Right;
            btnRefresh.BackColor = Color.White;
            btnRefresh.Image = Properties.Resources.icons8_search_24;
            btnRefresh.Location = new Point(630, 17);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(27, 26);
            btnRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRefresh.TabIndex = 4;
            btnRefresh.TabStop = false;
            // 
            // OrderEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 768);
            Controls.Add(pnlContainer);
            Controls.Add(panel5);
            Controls.Add(categoriesPanel);
            Controls.Add(panel4);
            Controls.Add(pnlHeader);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "OrderEntryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderEntryForm";
            FormClosing += OrderEntryForm_FormClosing;
            FormClosed += OrderEntryForm_FormClosed;
            Load += OrderEntryForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel cartPanel;
        private Panel panel2;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private Panel pnlHeader;
        private Panel panel4;
        private Label lblDateTime;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private FlowLayoutPanel categoriesPanel;
        private Label lblSubtotal;
        private Label label1;
        private Label lblVatable;
        private Label lblDiscount;
        private Button btnPayment;
        private Panel panel5;
        private Panel pnlContainer;
        private Label lblTotal;
        private Label label10;
        private Label lblVat;
        private Label label8;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private PictureBox btnRefresh;
    }
}
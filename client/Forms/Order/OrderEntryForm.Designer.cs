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
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            lblDateTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlHeader = new Panel();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            panel4 = new Panel();
            categoriesPanel = new FlowLayoutPanel();
            panel5 = new Panel();
            label7 = new Label();
            pnlContainer = new Panel();
            panel2.SuspendLayout();
            pnlHeader.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // cartPanel
            // 
            cartPanel.AutoScroll = true;
            cartPanel.BackColor = Color.White;
            cartPanel.Dock = DockStyle.Fill;
            cartPanel.Location = new Point(0, 56);
            cartPanel.Name = "cartPanel";
            cartPanel.Size = new Size(350, 391);
            cartPanel.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 447);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 287);
            panel2.TabIndex = 7;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.DimGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(183, 223);
            button2.Name = "button2";
            button2.Size = new Size(163, 52);
            button2.TabIndex = 7;
            button2.TabStop = false;
            button2.Text = "CANCEL";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.MediumSeaGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.MediumSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(5, 223);
            button1.Name = "button1";
            button1.Size = new Size(163, 52);
            button1.TabIndex = 6;
            button1.TabStop = false;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(225, 61);
            label5.Name = "label5";
            label5.Size = new Size(31, 18);
            label5.TabIndex = 5;
            label5.Text = "- - -";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 61);
            label6.Name = "label6";
            label6.Size = new Size(48, 18);
            label6.TabIndex = 4;
            label6.Text = "Total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(225, 38);
            label3.Name = "label3";
            label3.Size = new Size(31, 18);
            label3.TabIndex = 3;
            label3.Text = "- - -";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 38);
            label4.Name = "label4";
            label4.Size = new Size(31, 18);
            label4.TabIndex = 2;
            label4.Text = "Tax";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(225, 15);
            label2.Name = "label2";
            label2.Size = new Size(31, 18);
            label2.TabIndex = 1;
            label2.Text = "- - -";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 15);
            label1.Name = "label1";
            label1.Size = new Size(77, 18);
            label1.TabIndex = 0;
            label1.Text = "Discounts";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 56);
            panel1.TabIndex = 6;
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
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
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
            panel4.Location = new Point(674, 34);
            panel4.Name = "panel4";
            panel4.Size = new Size(350, 734);
            panel4.TabIndex = 25;
            // 
            // categoriesPanel
            // 
            categoriesPanel.BackColor = Color.White;
            categoriesPanel.Dock = DockStyle.Bottom;
            categoriesPanel.Location = new Point(0, 696);
            categoriesPanel.Name = "categoriesPanel";
            categoriesPanel.Size = new Size(674, 72);
            categoriesPanel.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(214, 192, 179);
            panel5.Controls.Add(label7);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 34);
            panel5.Name = "panel5";
            panel5.Size = new Size(674, 56);
            panel5.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(73, 54, 40);
            label7.Location = new Point(12, 16);
            label7.Name = "label7";
            label7.Size = new Size(263, 23);
            label7.TabIndex = 0;
            label7.Text = "Category - Subcategory";
            // 
            // pnlContainer
            // 
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 90);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(674, 606);
            pnlContainer.TabIndex = 30;
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
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "OrderEntryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderEntryForm";
            FormClosed += OrderEntryForm_FormClosed;
            Load += OrderEntryForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private Button button1;
        private Panel panel5;
        private Panel pnlContainer;
        private Label label7;
        private Button button2;
    }
}
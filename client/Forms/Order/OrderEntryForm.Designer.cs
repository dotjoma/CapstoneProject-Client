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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            cartPanel = new FlowLayoutPanel();
            panel2 = new Panel();
            lblDate = new Label();
            lblDateTime = new Label();
            label1 = new Label();
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            pnlContainer = new Panel();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(249, 249, 249);
            guna2Panel1.Controls.Add(cartPanel);
            guna2Panel1.Controls.Add(panel2);
            guna2Panel1.Controls.Add(lblDate);
            guna2Panel1.Controls.Add(lblDateTime);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(panel1);
            guna2Panel1.CustomBorderColor = Color.LightGray;
            guna2Panel1.CustomBorderThickness = new Padding(1, 0, 0, 0);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Right;
            guna2Panel1.Location = new Point(709, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(315, 768);
            guna2Panel1.TabIndex = 19;
            // 
            // cartPanel
            // 
            cartPanel.AutoScroll = true;
            cartPanel.BackColor = Color.LightGray;
            cartPanel.Dock = DockStyle.Fill;
            cartPanel.Location = new Point(0, 119);
            cartPanel.Name = "cartPanel";
            cartPanel.Size = new Size(315, 521);
            cartPanel.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 640);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 128);
            panel2.TabIndex = 7;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(6, 76);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 18);
            lblDate.TabIndex = 5;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateTime.Location = new Point(6, 49);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(0, 16);
            lblDateTime.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(98, 87, 87);
            label1.Location = new Point(6, 12);
            label1.Name = "label1";
            label1.Size = new Size(232, 29);
            label1.TabIndex = 3;
            label1.Text = "Save Menu Item";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 119);
            panel1.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(709, 119);
            panel3.TabIndex = 22;
            // 
            // pnlContainer
            // 
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 119);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(709, 649);
            pnlContainer.TabIndex = 23;
            // 
            // OrderEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 768);
            Controls.Add(pnlContainer);
            Controls.Add(panel3);
            Controls.Add(guna2Panel1);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderEntryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderEntryForm";
            FormClosed += OrderEntryForm_FormClosed;
            Load += OrderEntryForm_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private FlowLayoutPanel cartPanel;
        private Panel panel2;
        private Label lblDate;
        private Label lblDateTime;
        private Label label1;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private Panel panel3;
        private Panel pnlContainer;
    }
}
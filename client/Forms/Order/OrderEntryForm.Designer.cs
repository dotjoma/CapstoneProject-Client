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
            timer1 = new System.Windows.Forms.Timer(components);
            pnlHeader = new Panel();
            label13 = new Label();
            btnClose = new PictureBox();
            panel6 = new Panel();
            btnLogout = new Button();
            btnHome = new PictureBox();
            lblUser = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblDateTime = new Label();
            button3 = new Button();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            button4 = new Button();
            label7 = new Label();
            panel1 = new Panel();
            panel11 = new Panel();
            cartPanel = new FlowLayoutPanel();
            panel2 = new Panel();
            panel12 = new Panel();
            lblOrderNo = new Label();
            lblTransactionNo = new Label();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            panel13 = new Panel();
            lblSubTotal = new Label();
            lblTotal = new Label();
            label11 = new Label();
            lblVat = new Label();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            btnPayment = new Button();
            lblVatable = new Label();
            lblDiscount = new Label();
            label1 = new Label();
            label10 = new Label();
            panel5 = new Panel();
            btnPendingOrders = new Button();
            btnHoldOrder = new Button();
            pictureBox6 = new PictureBox();
            txtSearchInput = new TextBox();
            panel8 = new Panel();
            panel3 = new Panel();
            panel10 = new Panel();
            btnCancelTransaction = new Button();
            btnApplyDiscount = new Button();
            btnNewOrder = new Button();
            panel9 = new Panel();
            categoriesPanel = new FlowLayoutPanel();
            subCategoryPanel = new Panel();
            subCategoriesPanel = new FlowLayoutPanel();
            panel7 = new Panel();
            pnlContainer = new Panel();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            panel11.SuspendLayout();
            panel2.SuspendLayout();
            panel12.SuspendLayout();
            panel4.SuspendLayout();
            panel13.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            subCategoryPanel.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(label13);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1128, 34);
            pnlHeader.TabIndex = 24;
            pnlHeader.MouseDown += pnlHeader_MouseDown;
            pnlHeader.MouseMove += pnlHeader_MouseMove;
            pnlHeader.MouseUp += pnlHeader_MouseUp;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(98, 87, 87);
            label13.Location = new Point(3, 7);
            label13.Name = "label13";
            label13.Size = new Size(208, 20);
            label13.TabIndex = 20;
            label13.Text = "ELICIAS GARDEN FOOD PARK";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Right;
            btnClose.Image = Properties.Resources.CloseX32;
            btnClose.Location = new Point(1096, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 24);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 19;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            btnClose.MouseHover += btnClose_MouseHover;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(98, 87, 87);
            panel6.Controls.Add(btnLogout);
            panel6.Controls.Add(btnHome);
            panel6.Controls.Add(lblUser);
            panel6.Controls.Add(pictureBox2);
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(lblDateTime);
            panel6.Controls.Add(button3);
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(pictureBox5);
            panel6.Controls.Add(button4);
            panel6.Controls.Add(label7);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 734);
            panel6.Name = "panel6";
            panel6.Size = new Size(1128, 34);
            panel6.TabIndex = 25;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Right;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = Properties.Resources.logout_24;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(682, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(85, 26);
            btnLogout.TabIndex = 19;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleRight;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnHome
            // 
            btnHome.Anchor = AnchorStyles.Right;
            btnHome.Image = Properties.Resources.HomeRounded;
            btnHome.Location = new Point(646, 2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(30, 30);
            btnHome.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHome.TabIndex = 18;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left;
            lblUser.AutoSize = true;
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(36, 9);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(38, 16);
            lblUser.TabIndex = 17;
            lblUser.Text = "- - -";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Left;
            pictureBox2.Image = Properties.Resources.Name;
            pictureBox2.Location = new Point(3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.CalendarColored;
            pictureBox1.Location = new Point(773, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = AnchorStyles.Right;
            lblDateTime.AutoSize = true;
            lblDateTime.ForeColor = Color.White;
            lblDateTime.Location = new Point(803, 9);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(38, 16);
            lblDateTime.TabIndex = 14;
            lblDateTime.Text = "- - -";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.logout_24;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(1410, -29);
            button3.Name = "button3";
            button3.Size = new Size(85, 26);
            button3.TabIndex = 13;
            button3.Text = "Logout";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.HomeRounded;
            pictureBox3.Location = new Point(1501, -31);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(36, -24);
            label5.Name = "label5";
            label5.Size = new Size(38, 16);
            label5.TabIndex = 11;
            label5.Text = "- - -";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Left;
            pictureBox4.Image = Properties.Resources.Name;
            pictureBox4.Location = new Point(3, -31);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Right;
            pictureBox5.Image = Properties.Resources.CalendarColored;
            pictureBox5.Location = new Point(1572, -31);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Right;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.CloseWhite;
            button4.Location = new Point(1916, -31);
            button4.Name = "button4";
            button4.Size = new Size(30, 30);
            button4.TabIndex = 8;
            button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(1602, -24);
            label7.Name = "label7";
            label7.Size = new Size(38, 16);
            label7.TabIndex = 5;
            label7.Text = "- - -";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(778, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 700);
            panel1.TabIndex = 35;
            // 
            // panel11
            // 
            panel11.Controls.Add(cartPanel);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(0, 56);
            panel11.Name = "panel11";
            panel11.Size = new Size(350, 399);
            panel11.TabIndex = 11;
            // 
            // cartPanel
            // 
            cartPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartPanel.AutoScroll = true;
            cartPanel.BackColor = Color.FromArgb(232, 232, 232);
            cartPanel.Location = new Point(0, 8);
            cartPanel.Name = "cartPanel";
            cartPanel.Size = new Size(345, 385);
            cartPanel.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel12);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 56);
            panel2.TabIndex = 9;
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel12.BackColor = Color.FromArgb(232, 232, 232);
            panel12.Controls.Add(lblOrderNo);
            panel12.Controls.Add(lblTransactionNo);
            panel12.Controls.Add(label3);
            panel12.Controls.Add(label2);
            panel12.Location = new Point(-1, -1);
            panel12.Name = "panel12";
            panel12.Size = new Size(347, 58);
            panel12.TabIndex = 0;
            // 
            // lblOrderNo
            // 
            lblOrderNo.AutoSize = true;
            lblOrderNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderNo.ForeColor = Color.Black;
            lblOrderNo.Location = new Point(93, 33);
            lblOrderNo.Name = "lblOrderNo";
            lblOrderNo.Size = new Size(0, 20);
            lblOrderNo.TabIndex = 18;
            // 
            // lblTransactionNo
            // 
            lblTransactionNo.AutoSize = true;
            lblTransactionNo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactionNo.ForeColor = Color.Black;
            lblTransactionNo.Location = new Point(169, 2);
            lblTransactionNo.Name = "lblTransactionNo";
            lblTransactionNo.Size = new Size(0, 25);
            lblTransactionNo.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(4, 35);
            label3.Name = "label3";
            label3.Size = new Size(83, 17);
            label3.TabIndex = 16;
            label3.Text = "ORDER NO :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(4, 5);
            label2.Name = "label2";
            label2.Size = new Size(159, 21);
            label2.TabIndex = 15;
            label2.Text = "TRANSACTION NO :";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel13);
            panel4.Controls.Add(label10);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 455);
            panel4.Name = "panel4";
            panel4.Size = new Size(350, 245);
            panel4.TabIndex = 10;
            // 
            // panel13
            // 
            panel13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel13.BackColor = Color.FromArgb(232, 232, 232);
            panel13.Controls.Add(lblSubTotal);
            panel13.Controls.Add(lblTotal);
            panel13.Controls.Add(label11);
            panel13.Controls.Add(lblVat);
            panel13.Controls.Add(label8);
            panel13.Controls.Add(label6);
            panel13.Controls.Add(label4);
            panel13.Controls.Add(btnPayment);
            panel13.Controls.Add(lblVatable);
            panel13.Controls.Add(lblDiscount);
            panel13.Controls.Add(label1);
            panel13.Location = new Point(-1, -1);
            panel13.Name = "panel13";
            panel13.Size = new Size(347, 237);
            panel13.TabIndex = 14;
            // 
            // lblSubTotal
            // 
            lblSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSubTotal.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTotal.Location = new Point(202, 10);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(133, 18);
            lblSubTotal.TabIndex = 27;
            lblSubTotal.Text = "0.00";
            lblSubTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(202, 104);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(133, 22);
            lblTotal.TabIndex = 26;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(3, 102);
            label11.Name = "label11";
            label11.Size = new Size(68, 25);
            label11.TabIndex = 25;
            label11.Text = "TOTAL";
            // 
            // lblVat
            // 
            lblVat.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVat.Location = new Point(202, 78);
            lblVat.Name = "lblVat";
            lblVat.Size = new Size(133, 18);
            lblVat.TabIndex = 24;
            lblVat.Text = "0.00";
            lblVat.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(4, 80);
            label8.Name = "label8";
            label8.Size = new Size(67, 17);
            label8.TabIndex = 23;
            label8.Text = "VAT(12%)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(4, 57);
            label6.Name = "label6";
            label6.Size = new Size(58, 17);
            label6.TabIndex = 22;
            label6.Text = "Vat-able";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 35);
            label4.Name = "label4";
            label4.Size = new Size(63, 17);
            label4.TabIndex = 21;
            label4.Text = "Discount";
            // 
            // btnPayment
            // 
            btnPayment.Anchor = AnchorStyles.Bottom;
            btnPayment.BackColor = Color.White;
            btnPayment.FlatAppearance.BorderColor = Color.Gray;
            btnPayment.FlatAppearance.BorderSize = 2;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = Color.Black;
            btnPayment.Location = new Point(3, 181);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(340, 52);
            btnPayment.TabIndex = 20;
            btnPayment.TabStop = false;
            btnPayment.Text = "PAYMENT - [F2]";
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Click += btnPayment_Click;
            // 
            // lblVatable
            // 
            lblVatable.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVatable.Location = new Point(202, 57);
            lblVatable.Name = "lblVatable";
            lblVatable.Size = new Size(133, 18);
            lblVatable.TabIndex = 19;
            lblVatable.Text = "0.00";
            lblVatable.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            lblDiscount.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscount.Location = new Point(202, 34);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(133, 18);
            lblDiscount.TabIndex = 18;
            lblDiscount.Text = "0.00";
            lblDiscount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 11);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 17;
            label1.Text = "Sub-Total";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(98, 87, 87);
            label10.Location = new Point(6, 276);
            label10.Name = "label10";
            label10.Size = new Size(85, 32);
            label10.TabIndex = 12;
            label10.Text = "TOTAL";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(232, 232, 232);
            panel5.Controls.Add(btnPendingOrders);
            panel5.Controls.Add(btnHoldOrder);
            panel5.Controls.Add(pictureBox6);
            panel5.Controls.Add(txtSearchInput);
            panel5.Location = new Point(6, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(767, 56);
            panel5.TabIndex = 36;
            // 
            // btnPendingOrders
            // 
            btnPendingOrders.Anchor = AnchorStyles.Left;
            btnPendingOrders.BackColor = Color.White;
            btnPendingOrders.FlatAppearance.BorderColor = Color.Gray;
            btnPendingOrders.FlatAppearance.BorderSize = 2;
            btnPendingOrders.FlatStyle = FlatStyle.Flat;
            btnPendingOrders.Image = Properties.Resources.pending_24;
            btnPendingOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnPendingOrders.Location = new Point(174, 3);
            btnPendingOrders.Name = "btnPendingOrders";
            btnPendingOrders.Size = new Size(193, 50);
            btnPendingOrders.TabIndex = 15;
            btnPendingOrders.TabStop = false;
            btnPendingOrders.Text = "Pending Orders - [F6]";
            btnPendingOrders.TextAlign = ContentAlignment.MiddleRight;
            btnPendingOrders.UseVisualStyleBackColor = false;
            // 
            // btnHoldOrder
            // 
            btnHoldOrder.Anchor = AnchorStyles.Left;
            btnHoldOrder.BackColor = Color.White;
            btnHoldOrder.FlatAppearance.BorderColor = Color.Gray;
            btnHoldOrder.FlatAppearance.BorderSize = 2;
            btnHoldOrder.FlatStyle = FlatStyle.Flat;
            btnHoldOrder.Image = Properties.Resources.hold_24;
            btnHoldOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoldOrder.Location = new Point(6, 3);
            btnHoldOrder.Name = "btnHoldOrder";
            btnHoldOrder.Size = new Size(162, 50);
            btnHoldOrder.TabIndex = 14;
            btnHoldOrder.TabStop = false;
            btnHoldOrder.Text = "Hold Order - [F5]";
            btnHoldOrder.TextAlign = ContentAlignment.MiddleRight;
            btnHoldOrder.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Right;
            pictureBox6.Image = Properties.Resources.Search;
            pictureBox6.Location = new Point(730, 13);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(26, 26);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // txtSearchInput
            // 
            txtSearchInput.Anchor = AnchorStyles.Right;
            txtSearchInput.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchInput.Location = new Point(533, 13);
            txtSearchInput.Name = "txtSearchInput";
            txtSearchInput.PlaceholderText = "Search Product(s)";
            txtSearchInput.Size = new Size(188, 26);
            txtSearchInput.TabIndex = 0;
            txtSearchInput.TextChanged += txtSearchInput_TextChanged;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel5);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 34);
            panel8.Name = "panel8";
            panel8.Size = new Size(778, 56);
            panel8.TabIndex = 42;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel10);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 658);
            panel3.Name = "panel3";
            panel3.Size = new Size(778, 76);
            panel3.TabIndex = 49;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel10.BackColor = Color.FromArgb(232, 232, 232);
            panel10.Controls.Add(btnCancelTransaction);
            panel10.Controls.Add(btnApplyDiscount);
            panel10.Controls.Add(btnNewOrder);
            panel10.Location = new Point(6, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(767, 67);
            panel10.TabIndex = 47;
            // 
            // btnCancelTransaction
            // 
            btnCancelTransaction.Anchor = AnchorStyles.Left;
            btnCancelTransaction.BackColor = Color.White;
            btnCancelTransaction.FlatAppearance.BorderColor = Color.Gray;
            btnCancelTransaction.FlatAppearance.BorderSize = 2;
            btnCancelTransaction.FlatStyle = FlatStyle.Flat;
            btnCancelTransaction.Image = Properties.Resources.cancel_24;
            btnCancelTransaction.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelTransaction.Location = new Point(369, 6);
            btnCancelTransaction.Name = "btnCancelTransaction";
            btnCancelTransaction.Size = new Size(217, 54);
            btnCancelTransaction.TabIndex = 4;
            btnCancelTransaction.TabStop = false;
            btnCancelTransaction.Text = "Cancel Transaction - [F4]";
            btnCancelTransaction.TextAlign = ContentAlignment.MiddleRight;
            btnCancelTransaction.UseVisualStyleBackColor = false;
            btnCancelTransaction.Click += btnCancelTransaction_Click;
            // 
            // btnApplyDiscount
            // 
            btnApplyDiscount.Anchor = AnchorStyles.Left;
            btnApplyDiscount.BackColor = Color.White;
            btnApplyDiscount.FlatAppearance.BorderColor = Color.Gray;
            btnApplyDiscount.FlatAppearance.BorderSize = 2;
            btnApplyDiscount.FlatStyle = FlatStyle.Flat;
            btnApplyDiscount.Image = Properties.Resources.icons8_discount_24;
            btnApplyDiscount.ImageAlign = ContentAlignment.MiddleLeft;
            btnApplyDiscount.Location = new Point(174, 6);
            btnApplyDiscount.Name = "btnApplyDiscount";
            btnApplyDiscount.Size = new Size(189, 54);
            btnApplyDiscount.TabIndex = 3;
            btnApplyDiscount.TabStop = false;
            btnApplyDiscount.Text = "Apply Discount - [F3]";
            btnApplyDiscount.TextAlign = ContentAlignment.MiddleRight;
            btnApplyDiscount.UseVisualStyleBackColor = false;
            btnApplyDiscount.Click += btnApplyDiscount_Click;
            // 
            // btnNewOrder
            // 
            btnNewOrder.Anchor = AnchorStyles.Left;
            btnNewOrder.BackColor = Color.White;
            btnNewOrder.FlatAppearance.BorderColor = Color.Gray;
            btnNewOrder.FlatAppearance.BorderSize = 2;
            btnNewOrder.FlatStyle = FlatStyle.Flat;
            btnNewOrder.Image = Properties.Resources.new_order_24;
            btnNewOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewOrder.Location = new Point(6, 6);
            btnNewOrder.Name = "btnNewOrder";
            btnNewOrder.Size = new Size(162, 54);
            btnNewOrder.TabIndex = 2;
            btnNewOrder.TabStop = false;
            btnNewOrder.Text = "New Order - [F1]";
            btnNewOrder.TextAlign = ContentAlignment.MiddleRight;
            btnNewOrder.UseVisualStyleBackColor = false;
            btnNewOrder.Click += btnNewOrder_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(categoriesPanel);
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(0, 90);
            panel9.Name = "panel9";
            panel9.Size = new Size(193, 568);
            panel9.TabIndex = 50;
            // 
            // categoriesPanel
            // 
            categoriesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categoriesPanel.BackColor = Color.FromArgb(232, 232, 232);
            categoriesPanel.Location = new Point(6, 8);
            categoriesPanel.Name = "categoriesPanel";
            categoriesPanel.Size = new Size(181, 553);
            categoriesPanel.TabIndex = 41;
            // 
            // subCategoryPanel
            // 
            subCategoryPanel.Controls.Add(subCategoriesPanel);
            subCategoryPanel.Dock = DockStyle.Bottom;
            subCategoryPanel.Location = new Point(193, 596);
            subCategoryPanel.Name = "subCategoryPanel";
            subCategoryPanel.Size = new Size(585, 62);
            subCategoryPanel.TabIndex = 52;
            // 
            // subCategoriesPanel
            // 
            subCategoriesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            subCategoriesPanel.BackColor = Color.FromArgb(232, 232, 232);
            subCategoriesPanel.Location = new Point(0, 0);
            subCategoriesPanel.Name = "subCategoriesPanel";
            subCategoriesPanel.Size = new Size(580, 55);
            subCategoriesPanel.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(pnlContainer);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(193, 90);
            panel7.Name = "panel7";
            panel7.Size = new Size(585, 506);
            panel7.TabIndex = 53;
            // 
            // pnlContainer
            // 
            pnlContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContainer.Location = new Point(3, 7);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(578, 491);
            pnlContainer.TabIndex = 49;
            // 
            // OrderEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1128, 768);
            Controls.Add(panel7);
            Controls.Add(subCategoryPanel);
            Controls.Add(panel9);
            Controls.Add(panel3);
            Controls.Add(panel8);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Controls.Add(pnlHeader);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderEntryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderEntryForm";
            TopMost = true;
            FormClosing += OrderEntryForm_FormClosing;
            FormClosed += OrderEntryForm_FormClosed;
            Load += OrderEntryForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel8.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel9.ResumeLayout(false);
            subCategoryPanel.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Panel pnlHeader;
        private Panel panel6;
        private Button button3;
        private PictureBox pictureBox3;
        private Label label5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button button4;
        private Label label7;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Label label10;
        private Panel panel5;
        private PictureBox pictureBox6;
        private TextBox txtSearchInput;
        private Button btnLogout;
        private PictureBox btnHome;
        private Label lblUser;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblDateTime;
        private Panel panel8;
        private PictureBox btnClose;
        private Panel panel3;
        private Panel panel10;
        private Button btnApplyDiscount;
        private Button btnNewOrder;
        private Panel panel9;
        private FlowLayoutPanel categoriesPanel;
        private Label label13;
        private Panel panel11;
        private FlowLayoutPanel cartPanel;
        private Panel panel12;
        private Label label3;
        private Label label2;
        private Panel panel13;
        private Label lblSubTotal;
        private Label lblTotal;
        private Label label11;
        private Label lblVat;
        private Label label8;
        private Label label6;
        private Label label4;
        private Button btnPayment;
        private Label lblVatable;
        private Label lblDiscount;
        private Label label1;
        private Label lblTransactionNo;
        private Label lblOrderNo;
        private Panel subCategoryPanel;
        private Panel panel7;
        private Panel pnlContainer;
        private FlowLayoutPanel subCategoriesPanel;
        private Button btnCancelTransaction;
        private Button btnHoldOrder;
        private Button btnPendingOrders;
    }
}
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
            label2 = new Label();
            lblOrderType = new Label();
            label12 = new Label();
            lblOrderNo = new Label();
            lblTransactionNo = new Label();
            label3 = new Label();
            panel4 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            lblTotalDue = new Label();
            label15 = new Label();
            lblSubTotal = new Label();
            lblTotal = new Label();
            label11 = new Label();
            lblVatAmount = new Label();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            btnPayment = new Button();
            lblVatable = new Label();
            lblDiscount = new Label();
            label1 = new Label();
            label10 = new Label();
            panel5 = new Panel();
            btnTakeOut = new Button();
            pictureBox6 = new PictureBox();
            btnDineIn = new Button();
            txtSearchInput = new TextBox();
            label9 = new Label();
            btnPendingOrders = new Button();
            btnHoldOrder = new Button();
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
            pnlHeader.BackColor = Color.FromArgb(121, 85, 72);
            pnlHeader.Controls.Add(label13);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1444, 34);
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
            label13.ForeColor = Color.White;
            label13.Location = new Point(3, 5);
            label13.Name = "label13";
            label13.Size = new Size(208, 20);
            label13.TabIndex = 20;
            label13.Text = "ELICIAS GARDEN FOOD PARK";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Right;
            btnClose.Image = Properties.Resources.CloseWhite;
            btnClose.Location = new Point(1412, 5);
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
            panel6.BackColor = Color.FromArgb(121, 85, 72);
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
            panel6.Location = new Point(0, 778);
            panel6.Name = "panel6";
            panel6.Size = new Size(1444, 34);
            panel6.TabIndex = 25;
            panel6.Paint += panel6_Paint;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Right;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = Properties.Resources.logout_24;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(972, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 26);
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
            btnHome.Location = new Point(934, 2);
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
            pictureBox1.Location = new Point(1078, 2);
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
            lblDateTime.Location = new Point(1108, 9);
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
            button3.Location = new Point(1726, -29);
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
            pictureBox3.Location = new Point(1817, -31);
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
            pictureBox5.Location = new Point(1888, -31);
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
            button4.Location = new Point(2232, -31);
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
            label7.Location = new Point(1918, -24);
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
            panel1.Location = new Point(1004, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 744);
            panel1.TabIndex = 35;
            // 
            // panel11
            // 
            panel11.Controls.Add(cartPanel);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(0, 95);
            panel11.Name = "panel11";
            panel11.Size = new Size(440, 307);
            panel11.TabIndex = 11;
            // 
            // cartPanel
            // 
            cartPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartPanel.AutoScroll = true;
            cartPanel.BackColor = Color.FromArgb(232, 232, 232);
            cartPanel.Location = new Point(0, 8);
            cartPanel.Name = "cartPanel";
            cartPanel.Size = new Size(435, 293);
            cartPanel.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel12);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 95);
            panel2.TabIndex = 9;
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel12.BackColor = Color.FromArgb(232, 232, 232);
            panel12.Controls.Add(label2);
            panel12.Controls.Add(lblOrderType);
            panel12.Controls.Add(label12);
            panel12.Controls.Add(lblOrderNo);
            panel12.Controls.Add(lblTransactionNo);
            panel12.Controls.Add(label3);
            panel12.Location = new Point(-1, -1);
            panel12.Name = "panel12";
            panel12.Size = new Size(437, 96);
            panel12.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(4, 6);
            label2.Name = "label2";
            label2.Size = new Size(201, 28);
            label2.TabIndex = 15;
            label2.Text = "TRANSACTION NO :";
            // 
            // lblOrderType
            // 
            lblOrderType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOrderType.AutoSize = true;
            lblOrderType.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderType.ForeColor = Color.Black;
            lblOrderType.Location = new Point(211, 58);
            lblOrderType.Name = "lblOrderType";
            lblOrderType.Size = new Size(0, 20);
            lblOrderType.TabIndex = 20;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(4, 60);
            label12.Name = "label12";
            label12.Size = new Size(201, 23);
            label12.TabIndex = 19;
            label12.Text = "ORDER TYPE                 :";
            // 
            // lblOrderNo
            // 
            lblOrderNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOrderNo.AutoSize = true;
            lblOrderNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderNo.ForeColor = Color.Black;
            lblOrderNo.Location = new Point(211, 33);
            lblOrderNo.Name = "lblOrderNo";
            lblOrderNo.Size = new Size(0, 20);
            lblOrderNo.TabIndex = 18;
            // 
            // lblTransactionNo
            // 
            lblTransactionNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTransactionNo.AutoSize = true;
            lblTransactionNo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactionNo.ForeColor = Color.Black;
            lblTransactionNo.Location = new Point(211, 2);
            lblTransactionNo.Name = "lblTransactionNo";
            lblTransactionNo.Size = new Size(0, 25);
            lblTransactionNo.TabIndex = 17;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(4, 35);
            label3.Name = "label3";
            label3.Size = new Size(207, 23);
            label3.TabIndex = 16;
            label3.Text = "ORDER NO.                   :";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel13);
            panel4.Controls.Add(label10);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 402);
            panel4.Name = "panel4";
            panel4.Size = new Size(440, 342);
            panel4.TabIndex = 10;
            // 
            // panel13
            // 
            panel13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel13.BackColor = Color.FromArgb(232, 232, 232);
            panel13.Controls.Add(panel14);
            panel13.Controls.Add(btnHoldOrder);
            panel13.Controls.Add(lblTotalDue);
            panel13.Controls.Add(label15);
            panel13.Controls.Add(lblSubTotal);
            panel13.Controls.Add(lblTotal);
            panel13.Controls.Add(label11);
            panel13.Controls.Add(lblVatAmount);
            panel13.Controls.Add(label8);
            panel13.Controls.Add(label6);
            panel13.Controls.Add(label4);
            panel13.Controls.Add(btnPayment);
            panel13.Controls.Add(lblVatable);
            panel13.Controls.Add(lblDiscount);
            panel13.Controls.Add(label1);
            panel13.Location = new Point(-1, 6);
            panel13.Name = "panel13";
            panel13.Size = new Size(437, 327);
            panel13.TabIndex = 14;
            // 
            // panel14
            // 
            panel14.BackColor = Color.Black;
            panel14.Location = new Point(4, 83);
            panel14.Name = "panel14";
            panel14.Size = new Size(424, 1);
            panel14.TabIndex = 30;
            // 
            // lblTotalDue
            // 
            lblTotalDue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalDue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDue.Location = new Point(295, 44);
            lblTotalDue.Name = "lblTotalDue";
            lblTotalDue.Size = new Size(133, 28);
            lblTotalDue.TabIndex = 29;
            lblTotalDue.Text = "0.00";
            lblTotalDue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(4, 44);
            label15.Name = "label15";
            label15.Size = new Size(90, 21);
            label15.TabIndex = 28;
            label15.Text = "TOTAL DUE";
            // 
            // lblSubTotal
            // 
            lblSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSubTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubTotal.Location = new Point(347, 11);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(81, 28);
            lblSubTotal.TabIndex = 27;
            lblSubTotal.Text = "0.00";
            lblSubTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(259, 216);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(170, 30);
            lblTotal.TabIndex = 26;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            lblTotal.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(4, 217);
            label11.Name = "label11";
            label11.Size = new Size(56, 21);
            label11.TabIndex = 25;
            label11.Text = "TOTAL";
            label11.Visible = false;
            // 
            // lblVatAmount
            // 
            lblVatAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblVatAmount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblVatAmount.Location = new Point(296, 130);
            lblVatAmount.Name = "lblVatAmount";
            lblVatAmount.Size = new Size(133, 35);
            lblVatAmount.TabIndex = 24;
            lblVatAmount.Text = "0.00";
            lblVatAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(4, 133);
            label8.Name = "label8";
            label8.Size = new Size(101, 21);
            label8.TabIndex = 23;
            label8.Text = "VAT Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(4, 93);
            label6.Name = "label6";
            label6.Size = new Size(108, 21);
            label6.TabIndex = 22;
            label6.Text = "VATable Sales";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(4, 172);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 21;
            label4.Text = "Discount";
            // 
            // btnPayment
            // 
            btnPayment.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPayment.BackColor = Color.White;
            btnPayment.FlatAppearance.BorderColor = Color.Gray;
            btnPayment.FlatAppearance.BorderSize = 2;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = Color.Black;
            btnPayment.Location = new Point(7, 271);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(208, 52);
            btnPayment.TabIndex = 20;
            btnPayment.TabStop = false;
            btnPayment.Text = "PAYMENT - [ENTER]";
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Click += btnPayment_Click;
            // 
            // lblVatable
            // 
            lblVatable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblVatable.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblVatable.Location = new Point(295, 88);
            lblVatable.Name = "lblVatable";
            lblVatable.Size = new Size(133, 38);
            lblVatable.TabIndex = 19;
            lblVatable.Text = "0.00";
            lblVatable.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            lblDiscount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDiscount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDiscount.Location = new Point(296, 167);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(133, 39);
            lblDiscount.TabIndex = 18;
            lblDiscount.Text = "0.00";
            lblDiscount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 11);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 17;
            label1.Text = "Subtotal";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(98, 87, 87);
            label10.Location = new Point(6, 373);
            label10.Name = "label10";
            label10.Size = new Size(85, 32);
            label10.TabIndex = 12;
            label10.Text = "TOTAL";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(232, 232, 232);
            panel5.Controls.Add(btnTakeOut);
            panel5.Controls.Add(pictureBox6);
            panel5.Controls.Add(btnDineIn);
            panel5.Controls.Add(txtSearchInput);
            panel5.Controls.Add(label9);
            panel5.Location = new Point(6, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(993, 57);
            panel5.TabIndex = 36;
            panel5.Paint += panel5_Paint;
            // 
            // btnTakeOut
            // 
            btnTakeOut.BackColor = Color.White;
            btnTakeOut.Location = new Point(260, 14);
            btnTakeOut.Name = "btnTakeOut";
            btnTakeOut.Size = new Size(104, 28);
            btnTakeOut.TabIndex = 41;
            btnTakeOut.Text = "TAKE OUT";
            btnTakeOut.UseVisualStyleBackColor = false;
            btnTakeOut.Click += btnTakeOut_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox6.Image = Properties.Resources.Search;
            pictureBox6.Location = new Point(956, 13);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(26, 26);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // btnDineIn
            // 
            btnDineIn.BackColor = Color.White;
            btnDineIn.Location = new Point(150, 14);
            btnDineIn.Name = "btnDineIn";
            btnDineIn.Size = new Size(104, 28);
            btnDineIn.TabIndex = 40;
            btnDineIn.Text = "DINE IN";
            btnDineIn.UseVisualStyleBackColor = false;
            btnDineIn.Click += btnDineIn_Click;
            // 
            // txtSearchInput
            // 
            txtSearchInput.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchInput.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchInput.Location = new Point(759, 13);
            txtSearchInput.Name = "txtSearchInput";
            txtSearchInput.PlaceholderText = "Search Product(s)";
            txtSearchInput.Size = new Size(188, 26);
            txtSearchInput.TabIndex = 0;
            txtSearchInput.TextChanged += txtSearchInput_TextChanged;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(6, 14);
            label9.Name = "label9";
            label9.Size = new Size(138, 28);
            label9.TabIndex = 39;
            label9.Text = "ORDER TYPE :";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnPendingOrders
            // 
            btnPendingOrders.BackColor = Color.White;
            btnPendingOrders.FlatAppearance.BorderColor = Color.Gray;
            btnPendingOrders.FlatAppearance.BorderSize = 2;
            btnPendingOrders.FlatStyle = FlatStyle.Flat;
            btnPendingOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnPendingOrders.Location = new Point(540, 8);
            btnPendingOrders.Name = "btnPendingOrders";
            btnPendingOrders.Size = new Size(181, 50);
            btnPendingOrders.TabIndex = 15;
            btnPendingOrders.TabStop = false;
            btnPendingOrders.Text = "Pending Orders";
            btnPendingOrders.UseVisualStyleBackColor = false;
            // 
            // btnHoldOrder
            // 
            btnHoldOrder.BackColor = Color.White;
            btnHoldOrder.FlatAppearance.BorderColor = Color.Gray;
            btnHoldOrder.FlatAppearance.BorderSize = 2;
            btnHoldOrder.FlatStyle = FlatStyle.Flat;
            btnHoldOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoldOrder.Location = new Point(221, 271);
            btnHoldOrder.Name = "btnHoldOrder";
            btnHoldOrder.Size = new Size(208, 52);
            btnHoldOrder.TabIndex = 14;
            btnHoldOrder.TabStop = false;
            btnHoldOrder.Text = "Hold Order";
            btnHoldOrder.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel5);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 34);
            panel8.Name = "panel8";
            panel8.Size = new Size(1004, 68);
            panel8.TabIndex = 42;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel10);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 702);
            panel3.Name = "panel3";
            panel3.Size = new Size(1004, 76);
            panel3.TabIndex = 49;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel10.BackColor = Color.FromArgb(232, 232, 232);
            panel10.Controls.Add(btnPendingOrders);
            panel10.Controls.Add(btnCancelTransaction);
            panel10.Controls.Add(btnApplyDiscount);
            panel10.Controls.Add(btnNewOrder);
            panel10.Location = new Point(6, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(993, 67);
            panel10.TabIndex = 47;
            // 
            // btnCancelTransaction
            // 
            btnCancelTransaction.Anchor = AnchorStyles.Left;
            btnCancelTransaction.BackColor = Color.White;
            btnCancelTransaction.FlatAppearance.BorderColor = Color.Gray;
            btnCancelTransaction.FlatAppearance.BorderSize = 2;
            btnCancelTransaction.FlatStyle = FlatStyle.Flat;
            btnCancelTransaction.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelTransaction.Location = new Point(348, 6);
            btnCancelTransaction.Name = "btnCancelTransaction";
            btnCancelTransaction.Size = new Size(186, 54);
            btnCancelTransaction.TabIndex = 4;
            btnCancelTransaction.TabStop = false;
            btnCancelTransaction.Text = "Cancel Transaction";
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
            btnApplyDiscount.ImageAlign = ContentAlignment.MiddleLeft;
            btnApplyDiscount.Location = new Point(163, 6);
            btnApplyDiscount.Name = "btnApplyDiscount";
            btnApplyDiscount.Size = new Size(179, 54);
            btnApplyDiscount.TabIndex = 3;
            btnApplyDiscount.TabStop = false;
            btnApplyDiscount.Text = "Apply Discount";
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
            btnNewOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewOrder.Location = new Point(6, 6);
            btnNewOrder.Name = "btnNewOrder";
            btnNewOrder.Size = new Size(151, 54);
            btnNewOrder.TabIndex = 2;
            btnNewOrder.TabStop = false;
            btnNewOrder.Text = "New Order";
            btnNewOrder.UseVisualStyleBackColor = false;
            btnNewOrder.Click += btnNewOrder_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(categoriesPanel);
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(0, 102);
            panel9.Name = "panel9";
            panel9.Size = new Size(223, 600);
            panel9.TabIndex = 50;
            // 
            // categoriesPanel
            // 
            categoriesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categoriesPanel.BackColor = Color.FromArgb(232, 232, 232);
            categoriesPanel.Location = new Point(6, 0);
            categoriesPanel.Name = "categoriesPanel";
            categoriesPanel.Size = new Size(211, 593);
            categoriesPanel.TabIndex = 41;
            // 
            // subCategoryPanel
            // 
            subCategoryPanel.Controls.Add(subCategoriesPanel);
            subCategoryPanel.Dock = DockStyle.Top;
            subCategoryPanel.Location = new Point(223, 102);
            subCategoryPanel.Name = "subCategoryPanel";
            subCategoryPanel.Size = new Size(781, 62);
            subCategoryPanel.TabIndex = 52;
            // 
            // subCategoriesPanel
            // 
            subCategoriesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            subCategoriesPanel.BackColor = Color.FromArgb(232, 232, 232);
            subCategoriesPanel.Location = new Point(0, 0);
            subCategoriesPanel.Name = "subCategoriesPanel";
            subCategoriesPanel.Size = new Size(776, 55);
            subCategoriesPanel.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(pnlContainer);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(223, 164);
            panel7.Name = "panel7";
            panel7.Size = new Size(781, 538);
            panel7.TabIndex = 53;
            // 
            // pnlContainer
            // 
            pnlContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContainer.Location = new Point(3, 7);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(774, 523);
            pnlContainer.TabIndex = 49;
            // 
            // OrderEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1444, 812);
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
        private Label lblVatAmount;
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
        private Button btnDineIn;
        private Label label9;
        private Button btnTakeOut;
        private Label lblOrderType;
        private Label label12;
        private Label lblTotalDue;
        private Label label15;
        private Panel panel14;
    }
}
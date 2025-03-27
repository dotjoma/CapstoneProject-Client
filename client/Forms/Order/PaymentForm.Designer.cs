namespace client.Forms.Order
{
    partial class PaymentForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            panel1 = new Panel();
            label1 = new Label();
            panel9 = new Panel();
            btnConfirmPayment = new Button();
            panel2 = new Panel();
            panel6 = new Panel();
            dgvMop = new DataGridView();
            mode = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            refnumber = new DataGridViewTextBoxColumn();
            panel10 = new Panel();
            label2 = new Label();
            btnRemove = new Button();
            btnApply = new Button();
            lblAmountPaid = new Label();
            panel5 = new Panel();
            paymentDetailsPanel = new Panel();
            cboPaymentMethod = new ComboBox();
            label4 = new Label();
            panel7 = new Panel();
            lblAmountToPay = new Label();
            panel3 = new Panel();
            lblChange = new Label();
            label6 = new Label();
            lblBalance = new Label();
            label3 = new Label();
            panel4 = new Panel();
            numpadPanel = new Panel();
            btnDelete = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            postPaymentTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMop).BeginInit();
            panel10.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            numpadPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(232, 232, 232);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(710, 53);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(237, 28);
            label1.TabIndex = 0;
            label1.Text = "TOTAL AMOUNT TO PAY:";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(98, 87, 87);
            panel9.Controls.Add(btnConfirmPayment);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 712);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(710, 55);
            panel9.TabIndex = 3;
            // 
            // btnConfirmPayment
            // 
            btnConfirmPayment.BackColor = Color.FromArgb(121, 85, 72);
            btnConfirmPayment.Dock = DockStyle.Fill;
            btnConfirmPayment.FlatAppearance.BorderSize = 0;
            btnConfirmPayment.FlatStyle = FlatStyle.Flat;
            btnConfirmPayment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmPayment.ForeColor = Color.White;
            btnConfirmPayment.Location = new Point(0, 0);
            btnConfirmPayment.Margin = new Padding(3, 4, 3, 4);
            btnConfirmPayment.Name = "btnConfirmPayment";
            btnConfirmPayment.Size = new Size(710, 55);
            btnConfirmPayment.TabIndex = 0;
            btnConfirmPayment.Text = "CONFIRM PAYMENT - [ENTER]";
            btnConfirmPayment.UseVisualStyleBackColor = false;
            btnConfirmPayment.Click += btnConfirmPayment_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 53);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(369, 659);
            panel2.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Controls.Add(dgvMop);
            panel6.Controls.Add(panel10);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 345);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(369, 314);
            panel6.TabIndex = 3;
            // 
            // dgvMop
            // 
            dgvMop.AllowUserToAddRows = false;
            dgvMop.AllowUserToDeleteRows = false;
            dgvMop.AllowUserToResizeColumns = false;
            dgvMop.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvMop.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMop.BackgroundColor = Color.White;
            dgvMop.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(232, 232, 232);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(232, 232, 232);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMop.ColumnHeadersHeight = 25;
            dgvMop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMop.Columns.AddRange(new DataGridViewColumn[] { mode, amount, refnumber });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(232, 232, 232);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvMop.DefaultCellStyle = dataGridViewCellStyle4;
            dgvMop.EnableHeadersVisualStyles = false;
            dgvMop.Location = new Point(14, 0);
            dgvMop.Margin = new Padding(3, 4, 3, 4);
            dgvMop.MultiSelect = false;
            dgvMop.Name = "dgvMop";
            dgvMop.ReadOnly = true;
            dgvMop.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(214, 192, 179);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvMop.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvMop.RowHeadersVisible = false;
            dgvMop.RowHeadersWidth = 51;
            dgvMop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMop.Size = new Size(355, 185);
            dgvMop.TabIndex = 5;
            dgvMop.TabStop = false;
            dgvMop.CellClick += dgvMop_CellClick;
            // 
            // mode
            // 
            mode.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mode.DataPropertyName = "mode";
            mode.HeaderText = "MODE";
            mode.MinimumWidth = 100;
            mode.Name = "mode";
            mode.ReadOnly = true;
            mode.Width = 125;
            // 
            // amount
            // 
            amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            amount.DataPropertyName = "amount";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            amount.DefaultCellStyle = dataGridViewCellStyle3;
            amount.FillWeight = 114.315689F;
            amount.HeaderText = "AMOUNT";
            amount.MinimumWidth = 80;
            amount.Name = "amount";
            amount.ReadOnly = true;
            amount.Width = 80;
            // 
            // refnumber
            // 
            refnumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            refnumber.DataPropertyName = "refnumber";
            refnumber.FillWeight = 110.479927F;
            refnumber.HeaderText = "REF #";
            refnumber.MinimumWidth = 100;
            refnumber.Name = "refnumber";
            refnumber.ReadOnly = true;
            // 
            // panel10
            // 
            panel10.Controls.Add(label2);
            panel10.Controls.Add(btnRemove);
            panel10.Controls.Add(btnApply);
            panel10.Controls.Add(lblAmountPaid);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 187);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(369, 127);
            panel10.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 19);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 6;
            label2.Text = "AMOUNT PAID:";
            // 
            // btnRemove
            // 
            btnRemove.FlatAppearance.BorderColor = Color.Crimson;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(190, 69);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(179, 39);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "REMOVE - [DELETE]";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnApply
            // 
            btnApply.FlatAppearance.BorderColor = Color.Green;
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApply.Location = new Point(14, 69);
            btnApply.Margin = new Padding(3, 4, 3, 4);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(166, 39);
            btnApply.TabIndex = 4;
            btnApply.Text = "APPLY - [INSERT]";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // lblAmountPaid
            // 
            lblAmountPaid.BackColor = Color.FromArgb(232, 232, 232);
            lblAmountPaid.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmountPaid.Location = new Point(192, 13);
            lblAmountPaid.Name = "lblAmountPaid";
            lblAmountPaid.Size = new Size(177, 39);
            lblAmountPaid.TabIndex = 3;
            lblAmountPaid.Text = "0.00";
            lblAmountPaid.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            panel5.Controls.Add(paymentDetailsPanel);
            panel5.Controls.Add(cboPaymentMethod);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(panel7);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(369, 345);
            panel5.TabIndex = 2;
            // 
            // paymentDetailsPanel
            // 
            paymentDetailsPanel.BackColor = Color.FromArgb(232, 232, 232);
            paymentDetailsPanel.BorderStyle = BorderStyle.FixedSingle;
            paymentDetailsPanel.Location = new Point(14, 175);
            paymentDetailsPanel.Margin = new Padding(3, 4, 3, 4);
            paymentDetailsPanel.Name = "paymentDetailsPanel";
            paymentDetailsPanel.Size = new Size(355, 159);
            paymentDetailsPanel.TabIndex = 3;
            // 
            // cboPaymentMethod
            // 
            cboPaymentMethod.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboPaymentMethod.BackColor = Color.White;
            cboPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaymentMethod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboPaymentMethod.FormattingEnabled = true;
            cboPaymentMethod.Items.AddRange(new object[] { "Cash", "Digital Payment" });
            cboPaymentMethod.Location = new Point(14, 128);
            cboPaymentMethod.Margin = new Padding(3, 4, 3, 4);
            cboPaymentMethod.Name = "cboPaymentMethod";
            cboPaymentMethod.Size = new Size(355, 36);
            cboPaymentMethod.TabIndex = 2;
            cboPaymentMethod.SelectedIndexChanged += cboPaymentMethod_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 96);
            label4.Name = "label4";
            label4.Size = new Size(194, 28);
            label4.TabIndex = 1;
            label4.Text = "PAYMENT METHOD:";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = Color.FromArgb(232, 232, 232);
            panel7.Controls.Add(lblAmountToPay);
            panel7.Location = new Point(14, 8);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(355, 68);
            panel7.TabIndex = 0;
            // 
            // lblAmountToPay
            // 
            lblAmountToPay.Anchor = AnchorStyles.None;
            lblAmountToPay.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmountToPay.Location = new Point(15, 11);
            lblAmountToPay.Name = "lblAmountToPay";
            lblAmountToPay.Size = new Size(326, 47);
            lblAmountToPay.TabIndex = 1;
            lblAmountToPay.Text = "0.00";
            lblAmountToPay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblChange);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(lblBalance);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(369, 53);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(341, 659);
            panel3.TabIndex = 5;
            // 
            // lblChange
            // 
            lblChange.BackColor = Color.FromArgb(232, 232, 232);
            lblChange.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.Location = new Point(16, 601);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(310, 39);
            lblChange.TabIndex = 4;
            lblChange.Text = "0.00";
            lblChange.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(17, 568);
            label6.Name = "label6";
            label6.Size = new Size(94, 25);
            label6.TabIndex = 3;
            label6.Text = "CHANGE:";
            // 
            // lblBalance
            // 
            lblBalance.BackColor = Color.FromArgb(232, 232, 232);
            lblBalance.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(16, 516);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(310, 39);
            lblBalance.TabIndex = 2;
            lblBalance.Text = "0.00";
            lblBalance.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 483);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 1;
            label3.Text = "BALANCE:";
            // 
            // panel4
            // 
            panel4.Controls.Add(numpadPanel);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(341, 467);
            panel4.TabIndex = 0;
            // 
            // numpadPanel
            // 
            numpadPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            numpadPanel.BackColor = Color.FromArgb(232, 232, 232);
            numpadPanel.Controls.Add(btnDelete);
            numpadPanel.Controls.Add(btnDot);
            numpadPanel.Controls.Add(btn0);
            numpadPanel.Controls.Add(btn3);
            numpadPanel.Controls.Add(btn2);
            numpadPanel.Controls.Add(btn1);
            numpadPanel.Controls.Add(btn6);
            numpadPanel.Controls.Add(btn5);
            numpadPanel.Controls.Add(btn4);
            numpadPanel.Controls.Add(btn9);
            numpadPanel.Controls.Add(btn8);
            numpadPanel.Controls.Add(btn7);
            numpadPanel.Location = new Point(16, 7);
            numpadPanel.Margin = new Padding(3, 4, 3, 4);
            numpadPanel.Name = "numpadPanel";
            numpadPanel.Size = new Size(310, 455);
            numpadPanel.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(51, 51, 51);
            btnDelete.CausesValidation = false;
            btnDelete.FlatAppearance.BorderColor = Color.Gray;
            btnDelete.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Image = Properties.Resources.delete_24;
            btnDelete.Location = new Point(214, 344);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 93);
            btnDelete.TabIndex = 11;
            btnDelete.TabStop = false;
            btnDelete.Tag = "delete";
            btnDelete.TextAlign = ContentAlignment.TopLeft;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.White;
            btnDot.CausesValidation = false;
            btnDot.FlatAppearance.BorderColor = Color.Gray;
            btnDot.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDot.Location = new Point(114, 344);
            btnDot.Margin = new Padding(3, 4, 3, 4);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(80, 93);
            btnDot.TabIndex = 10;
            btnDot.TabStop = false;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.BackColor = Color.White;
            btn0.CausesValidation = false;
            btn0.FlatAppearance.BorderColor = Color.Gray;
            btn0.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.Location = new Point(15, 344);
            btn0.Margin = new Padding(3, 4, 3, 4);
            btn0.Name = "btn0";
            btn0.Size = new Size(80, 93);
            btn0.TabIndex = 9;
            btn0.TabStop = false;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += Numpad_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.White;
            btn3.CausesValidation = false;
            btn3.FlatAppearance.BorderColor = Color.Gray;
            btn3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(214, 235);
            btn3.Margin = new Padding(3, 4, 3, 4);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 93);
            btn3.TabIndex = 8;
            btn3.TabStop = false;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.White;
            btn2.CausesValidation = false;
            btn2.FlatAppearance.BorderColor = Color.Gray;
            btn2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(114, 235);
            btn2.Margin = new Padding(3, 4, 3, 4);
            btn2.Name = "btn2";
            btn2.Size = new Size(80, 93);
            btn2.TabIndex = 7;
            btn2.TabStop = false;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = Color.White;
            btn1.CausesValidation = false;
            btn1.FlatAppearance.BorderColor = Color.Gray;
            btn1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(15, 235);
            btn1.Margin = new Padding(3, 4, 3, 4);
            btn1.Name = "btn1";
            btn1.Size = new Size(80, 93);
            btn1.TabIndex = 6;
            btn1.TabStop = false;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = Color.White;
            btn6.CausesValidation = false;
            btn6.FlatAppearance.BorderColor = Color.Gray;
            btn6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(214, 125);
            btn6.Margin = new Padding(3, 4, 3, 4);
            btn6.Name = "btn6";
            btn6.Size = new Size(80, 93);
            btn6.TabIndex = 5;
            btn6.TabStop = false;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = Color.White;
            btn5.CausesValidation = false;
            btn5.FlatAppearance.BorderColor = Color.Gray;
            btn5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(114, 125);
            btn5.Margin = new Padding(3, 4, 3, 4);
            btn5.Name = "btn5";
            btn5.Size = new Size(80, 93);
            btn5.TabIndex = 4;
            btn5.TabStop = false;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.White;
            btn4.CausesValidation = false;
            btn4.FlatAppearance.BorderColor = Color.Gray;
            btn4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(15, 125);
            btn4.Margin = new Padding(3, 4, 3, 4);
            btn4.Name = "btn4";
            btn4.Size = new Size(80, 93);
            btn4.TabIndex = 3;
            btn4.TabStop = false;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.BackColor = Color.White;
            btn9.CausesValidation = false;
            btn9.FlatAppearance.BorderColor = Color.Gray;
            btn9.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(214, 16);
            btn9.Margin = new Padding(3, 4, 3, 4);
            btn9.Name = "btn9";
            btn9.Size = new Size(80, 93);
            btn9.TabIndex = 2;
            btn9.TabStop = false;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            btn8.BackColor = Color.White;
            btn8.CausesValidation = false;
            btn8.FlatAppearance.BorderColor = Color.Gray;
            btn8.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(114, 16);
            btn8.Margin = new Padding(3, 4, 3, 4);
            btn8.Name = "btn8";
            btn8.Size = new Size(80, 93);
            btn8.TabIndex = 1;
            btn8.TabStop = false;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.BackColor = Color.White;
            btn7.CausesValidation = false;
            btn7.FlatAppearance.BorderColor = Color.Gray;
            btn7.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(15, 16);
            btn7.Margin = new Padding(3, 4, 3, 4);
            btn7.Name = "btn7";
            btn7.Size = new Size(80, 93);
            btn7.TabIndex = 0;
            btn7.TabStop = false;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            // 
            // postPaymentTimer
            // 
            postPaymentTimer.Interval = 1000;
            postPaymentTimer.Tick += postPaymentTimer_Tick;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(710, 767);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel9);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ELICIAS GARDEN FOOD PARK";
            TopMost = true;
            Load += PaymentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel9.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMop).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            numpadPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel9;
        private Panel panel2;
        private Panel panel6;
        private Panel panel5;
        private ComboBox cboPaymentMethod;
        private Label label4;
        private Panel panel7;
        private Label lblAmountToPay;
        private Panel panel3;
        private Label lblChange;
        private Label label6;
        private Label lblBalance;
        private Label label3;
        private Panel panel4;
        private Panel numpadPanel;
        private Button btnDelete;
        private Button btnDot;
        private Button btn0;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Panel paymentDetailsPanel;
        private Panel panel10;
        private Button btnConfirmPayment;
        private Button btnApply;
        private Label lblAmountPaid;
        private Button btnRemove;
        private Label label2;
        private DataGridView dgvMop;
        private DataGridViewTextBoxColumn mode;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn refnumber;
        private System.Windows.Forms.Timer postPaymentTimer;
    }
}
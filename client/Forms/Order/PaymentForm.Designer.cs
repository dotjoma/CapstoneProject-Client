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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            panel1 = new Panel();
            label1 = new Label();
            panel9 = new Panel();
            btnConfirmPayment = new Button();
            panel2 = new Panel();
            panel6 = new Panel();
            dgvMop = new DataGridView();
            mode = new DataGridViewTextBoxColumn();
            productCategory = new DataGridViewTextBoxColumn();
            productSubcategory = new DataGridViewTextBoxColumn();
            panel10 = new Panel();
            btnRemove = new Button();
            btnApply = new Button();
            lblTotal = new Label();
            panel5 = new Panel();
            txtAmount = new TextBox();
            label5 = new Label();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(621, 40);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(189, 21);
            label1.TabIndex = 0;
            label1.Text = "TOTAL AMOUNT TO PAY:";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(98, 87, 87);
            panel9.Controls.Add(btnConfirmPayment);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 534);
            panel9.Name = "panel9";
            panel9.Size = new Size(621, 41);
            panel9.TabIndex = 3;
            // 
            // btnConfirmPayment
            // 
            btnConfirmPayment.Dock = DockStyle.Fill;
            btnConfirmPayment.FlatAppearance.BorderSize = 0;
            btnConfirmPayment.FlatStyle = FlatStyle.Flat;
            btnConfirmPayment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmPayment.ForeColor = Color.White;
            btnConfirmPayment.Location = new Point(0, 0);
            btnConfirmPayment.Name = "btnConfirmPayment";
            btnConfirmPayment.Size = new Size(621, 41);
            btnConfirmPayment.TabIndex = 0;
            btnConfirmPayment.Text = "Confirm Payment - [ENTER]";
            btnConfirmPayment.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 494);
            panel2.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Controls.Add(dgvMop);
            panel6.Controls.Add(panel10);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 295);
            panel6.Name = "panel6";
            panel6.Size = new Size(323, 199);
            panel6.TabIndex = 3;
            // 
            // dgvMop
            // 
            dgvMop.AllowUserToAddRows = false;
            dgvMop.AllowUserToDeleteRows = false;
            dgvMop.AllowUserToResizeColumns = false;
            dgvMop.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(215, 204, 200);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(93, 64, 55);
            dgvMop.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMop.BackgroundColor = Color.White;
            dgvMop.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(232, 232, 232);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(232, 232, 232);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(232, 232, 232);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMop.ColumnHeadersHeight = 35;
            dgvMop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMop.Columns.AddRange(new DataGridViewColumn[] { mode, productCategory, productSubcategory });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(215, 204, 200);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMop.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMop.Dock = DockStyle.Fill;
            dgvMop.EnableHeadersVisualStyles = false;
            dgvMop.Location = new Point(0, 0);
            dgvMop.MultiSelect = false;
            dgvMop.Name = "dgvMop";
            dgvMop.ReadOnly = true;
            dgvMop.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(214, 192, 179);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvMop.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvMop.RowHeadersVisible = false;
            dgvMop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMop.Size = new Size(323, 153);
            dgvMop.TabIndex = 5;
            dgvMop.TabStop = false;
            // 
            // mode
            // 
            mode.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mode.HeaderText = "MODE";
            mode.MinimumWidth = 100;
            mode.Name = "mode";
            mode.ReadOnly = true;
            // 
            // productCategory
            // 
            productCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            productCategory.DataPropertyName = "amount";
            productCategory.FillWeight = 114.315689F;
            productCategory.HeaderText = "AMOUNT";
            productCategory.MinimumWidth = 100;
            productCategory.Name = "productCategory";
            productCategory.ReadOnly = true;
            // 
            // productSubcategory
            // 
            productSubcategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productSubcategory.DataPropertyName = "refnumber";
            productSubcategory.FillWeight = 110.479927F;
            productSubcategory.HeaderText = "REF NO";
            productSubcategory.MinimumWidth = 100;
            productSubcategory.Name = "productSubcategory";
            productSubcategory.ReadOnly = true;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnRemove);
            panel10.Controls.Add(btnApply);
            panel10.Controls.Add(lblTotal);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 153);
            panel10.Name = "panel10";
            panel10.Size = new Size(323, 46);
            panel10.TabIndex = 0;
            // 
            // btnRemove
            // 
            btnRemove.FlatAppearance.BorderColor = Color.Crimson;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(107, 9);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(116, 29);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "REMOVE - [DELETE]";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            btnApply.FlatAppearance.BorderColor = Color.Green;
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnApply.Location = new Point(4, 9);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(97, 29);
            btnApply.TabIndex = 4;
            btnApply.Text = "APPLY - [INSERT]";
            btnApply.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.FromArgb(232, 232, 232);
            lblTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(229, 9);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(91, 29);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtAmount);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(paymentDetailsPanel);
            panel5.Controls.Add(cboPaymentMethod);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(panel7);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(323, 295);
            panel5.TabIndex = 2;
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.FromArgb(232, 232, 232);
            txtAmount.BorderStyle = BorderStyle.None;
            txtAmount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(16, 254);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(289, 28);
            txtAmount.TabIndex = 5;
            txtAmount.TextAlign = HorizontalAlignment.Right;
            txtAmount.KeyPress += textBox1_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 230);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 4;
            label5.Text = "AMOUNT:";
            // 
            // paymentDetailsPanel
            // 
            paymentDetailsPanel.BackColor = Color.FromArgb(232, 232, 232);
            paymentDetailsPanel.BorderStyle = BorderStyle.FixedSingle;
            paymentDetailsPanel.Location = new Point(17, 131);
            paymentDetailsPanel.Name = "paymentDetailsPanel";
            paymentDetailsPanel.Size = new Size(289, 81);
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
            cboPaymentMethod.Location = new Point(17, 96);
            cboPaymentMethod.Name = "cboPaymentMethod";
            cboPaymentMethod.Size = new Size(289, 29);
            cboPaymentMethod.TabIndex = 2;
            cboPaymentMethod.SelectedIndexChanged += cboPaymentMethod_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 72);
            label4.Name = "label4";
            label4.Size = new Size(156, 21);
            label4.TabIndex = 1;
            label4.Text = "PAYMENT METHOD:";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = Color.FromArgb(232, 232, 232);
            panel7.Controls.Add(lblAmountToPay);
            panel7.Location = new Point(17, 6);
            panel7.Name = "panel7";
            panel7.Size = new Size(289, 51);
            panel7.TabIndex = 0;
            // 
            // lblAmountToPay
            // 
            lblAmountToPay.Anchor = AnchorStyles.None;
            lblAmountToPay.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmountToPay.Location = new Point(35, 8);
            lblAmountToPay.Name = "lblAmountToPay";
            lblAmountToPay.Size = new Size(219, 35);
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
            panel3.Location = new Point(323, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(298, 494);
            panel3.TabIndex = 5;
            // 
            // lblChange
            // 
            lblChange.BackColor = Color.FromArgb(232, 232, 232);
            lblChange.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.Location = new Point(14, 451);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(271, 29);
            lblChange.TabIndex = 4;
            lblChange.Text = "0.00";
            lblChange.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 426);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 3;
            label6.Text = "CHANGE:";
            // 
            // lblBalance
            // 
            lblBalance.BackColor = Color.FromArgb(232, 232, 232);
            lblBalance.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(14, 387);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(271, 29);
            lblBalance.TabIndex = 2;
            lblBalance.Text = "0.00";
            lblBalance.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 362);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 1;
            label3.Text = "BALANCE:";
            // 
            // panel4
            // 
            panel4.Controls.Add(numpadPanel);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(298, 350);
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
            numpadPanel.Location = new Point(14, 5);
            numpadPanel.Name = "numpadPanel";
            numpadPanel.Size = new Size(271, 341);
            numpadPanel.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(51, 51, 51);
            btnDelete.CausesValidation = false;
            btnDelete.FlatAppearance.BorderColor = Color.Gray;
            btnDelete.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Image = Properties.Resources.delete_24;
            btnDelete.Location = new Point(187, 258);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(70, 70);
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
            btnDot.Location = new Point(100, 258);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(70, 70);
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
            btn0.Location = new Point(13, 258);
            btn0.Name = "btn0";
            btn0.Size = new Size(70, 70);
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
            btn3.Location = new Point(187, 176);
            btn3.Name = "btn3";
            btn3.Size = new Size(70, 70);
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
            btn2.Location = new Point(100, 176);
            btn2.Name = "btn2";
            btn2.Size = new Size(70, 70);
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
            btn1.Location = new Point(13, 176);
            btn1.Name = "btn1";
            btn1.Size = new Size(70, 70);
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
            btn6.Location = new Point(187, 94);
            btn6.Name = "btn6";
            btn6.Size = new Size(70, 70);
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
            btn5.Location = new Point(100, 94);
            btn5.Name = "btn5";
            btn5.Size = new Size(70, 70);
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
            btn4.Location = new Point(13, 94);
            btn4.Name = "btn4";
            btn4.Size = new Size(70, 70);
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
            btn9.Location = new Point(187, 12);
            btn9.Name = "btn9";
            btn9.Size = new Size(70, 70);
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
            btn8.Location = new Point(100, 12);
            btn8.Name = "btn8";
            btn8.Size = new Size(70, 70);
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
            btn7.Location = new Point(13, 12);
            btn7.Name = "btn7";
            btn7.Size = new Size(70, 70);
            btn7.TabIndex = 0;
            btn7.TabStop = false;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(621, 575);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel9);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ELICIAS GARDEN FOOD PARK";
            TopMost = true;
            Load += PaymentForm_Load;
            KeyDown += PaymentForm_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel9.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMop).EndInit();
            panel10.ResumeLayout(false);
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
        private TextBox txtAmount;
        private Label label5;
        private Panel panel10;
        private DataGridView dgvMop;
        private DataGridViewTextBoxColumn mode;
        private DataGridViewTextBoxColumn productCategory;
        private DataGridViewTextBoxColumn productSubcategory;
        private Button btnConfirmPayment;
        private Button btnApply;
        private Label lblTotal;
        private Button btnRemove;
    }
}
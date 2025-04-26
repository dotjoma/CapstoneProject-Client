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
            label1 = new Label();
            btnConfirmPayment = new Button();
            dgvMop = new DataGridView();
            mode = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            refnumber = new DataGridViewTextBoxColumn();
            label2 = new Label();
            btnRemove = new Button();
            btnApply = new Button();
            lblAmountPaid = new Label();
            paymentDetailsPanel = new Panel();
            cboPaymentMethod = new ComboBox();
            label4 = new Label();
            lblAmountToPay = new Label();
            lblChange = new Label();
            label6 = new Label();
            lblBalance = new Label();
            label3 = new Label();
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
            btnCancelPayment = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMop).BeginInit();
            numpadPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 0;
            label1.Text = "TOTAL DUE";
            // 
            // btnConfirmPayment
            // 
            btnConfirmPayment.BackColor = Color.FromArgb(76, 175, 80);
            btnConfirmPayment.FlatAppearance.BorderSize = 0;
            btnConfirmPayment.FlatStyle = FlatStyle.Flat;
            btnConfirmPayment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmPayment.ForeColor = Color.White;
            btnConfirmPayment.Location = new Point(10, 478);
            btnConfirmPayment.Name = "btnConfirmPayment";
            btnConfirmPayment.Size = new Size(311, 41);
            btnConfirmPayment.TabIndex = 0;
            btnConfirmPayment.Text = "CONFIRM PAYMENT - [ENTER]";
            btnConfirmPayment.UseVisualStyleBackColor = false;
            btnConfirmPayment.Click += btnConfirmPayment_Click;
            // 
            // dgvMop
            // 
            dgvMop.AllowUserToAddRows = false;
            dgvMop.AllowUserToDeleteRows = false;
            dgvMop.AllowUserToResizeColumns = false;
            dgvMop.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
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
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvMop.DefaultCellStyle = dataGridViewCellStyle4;
            dgvMop.EnableHeadersVisualStyles = false;
            dgvMop.Location = new Point(10, 233);
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
            dgvMop.Size = new Size(311, 152);
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
            refnumber.HeaderText = "REFERENCE NO";
            refnumber.MinimumWidth = 100;
            refnumber.Name = "refnumber";
            refnumber.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 164);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 6;
            label2.Text = "AMOUNT PAID:";
            // 
            // btnRemove
            // 
            btnRemove.FlatAppearance.BorderColor = Color.Black;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(10, 391);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(312, 29);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "REMOVE PAYMENT";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnApply
            // 
            btnApply.FlatAppearance.BorderColor = Color.Black;
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApply.Location = new Point(352, 166);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(311, 29);
            btnApply.TabIndex = 4;
            btnApply.Text = "ADD PAYMENT";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // lblAmountPaid
            // 
            lblAmountPaid.BackColor = Color.FromArgb(232, 232, 232);
            lblAmountPaid.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmountPaid.Location = new Point(10, 183);
            lblAmountPaid.Name = "lblAmountPaid";
            lblAmountPaid.Size = new Size(311, 29);
            lblAmountPaid.TabIndex = 3;
            lblAmountPaid.Text = "0.00";
            lblAmountPaid.TextAlign = ContentAlignment.MiddleRight;
            // 
            // paymentDetailsPanel
            // 
            paymentDetailsPanel.BackColor = Color.FromArgb(232, 232, 232);
            paymentDetailsPanel.BorderStyle = BorderStyle.FixedSingle;
            paymentDetailsPanel.Location = new Point(349, 61);
            paymentDetailsPanel.Name = "paymentDetailsPanel";
            paymentDetailsPanel.Size = new Size(311, 100);
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
            cboPaymentMethod.Location = new Point(349, 28);
            cboPaymentMethod.Name = "cboPaymentMethod";
            cboPaymentMethod.Size = new Size(311, 29);
            cboPaymentMethod.TabIndex = 2;
            cboPaymentMethod.SelectedIndexChanged += cboPaymentMethod_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(349, 7);
            label4.Name = "label4";
            label4.Size = new Size(156, 21);
            label4.TabIndex = 1;
            label4.Text = "PAYMENT METHOD:";
            // 
            // lblAmountToPay
            // 
            lblAmountToPay.Anchor = AnchorStyles.None;
            lblAmountToPay.BackColor = Color.FromArgb(232, 232, 232);
            lblAmountToPay.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmountToPay.Location = new Point(10, 28);
            lblAmountToPay.Name = "lblAmountToPay";
            lblAmountToPay.Size = new Size(311, 29);
            lblAmountToPay.TabIndex = 1;
            lblAmountToPay.Text = "0.00";
            lblAmountToPay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblChange
            // 
            lblChange.BackColor = Color.FromArgb(232, 232, 232);
            lblChange.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.Location = new Point(10, 131);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(312, 29);
            lblChange.TabIndex = 4;
            lblChange.Text = "0.00";
            lblChange.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 112);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 3;
            label6.Text = "CHANGE:";
            // 
            // lblBalance
            // 
            lblBalance.BackColor = Color.FromArgb(232, 232, 232);
            lblBalance.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(10, 80);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(311, 29);
            lblBalance.TabIndex = 2;
            lblBalance.Text = "0.00";
            lblBalance.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 61);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 1;
            label3.Text = "BALANCE:";
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
            numpadPanel.Location = new Point(352, 233);
            numpadPanel.Name = "numpadPanel";
            numpadPanel.Size = new Size(308, 333);
            numpadPanel.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(51, 51, 51);
            btnDelete.CausesValidation = false;
            btnDelete.FlatAppearance.BorderColor = Color.Gray;
            btnDelete.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Image = Properties.Resources.delete_24;
            btnDelete.Location = new Point(206, 255);
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
            btnDot.Location = new Point(119, 255);
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
            btn0.Location = new Point(32, 255);
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
            btn3.Location = new Point(206, 173);
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
            btn2.Location = new Point(119, 173);
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
            btn1.Location = new Point(32, 173);
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
            btn6.Location = new Point(206, 91);
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
            btn5.Location = new Point(119, 91);
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
            btn4.Location = new Point(32, 91);
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
            btn9.Location = new Point(206, 9);
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
            btn8.Location = new Point(119, 9);
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
            btn7.Location = new Point(32, 9);
            btn7.Name = "btn7";
            btn7.Size = new Size(70, 70);
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
            // btnCancelPayment
            // 
            btnCancelPayment.BackColor = Color.FromArgb(244, 67, 54);
            btnCancelPayment.FlatAppearance.BorderSize = 0;
            btnCancelPayment.FlatStyle = FlatStyle.Flat;
            btnCancelPayment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelPayment.ForeColor = Color.White;
            btnCancelPayment.Location = new Point(10, 525);
            btnCancelPayment.Name = "btnCancelPayment";
            btnCancelPayment.Size = new Size(311, 41);
            btnCancelPayment.TabIndex = 7;
            btnCancelPayment.Text = "CANCEL PAYMENT - [ESC]";
            btnCancelPayment.UseVisualStyleBackColor = false;
            btnCancelPayment.Click += btnCancelPayment_Click;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(673, 576);
            Controls.Add(btnCancelPayment);
            Controls.Add(label2);
            Controls.Add(btnRemove);
            Controls.Add(paymentDetailsPanel);
            Controls.Add(btnApply);
            Controls.Add(lblAmountPaid);
            Controls.Add(lblChange);
            Controls.Add(dgvMop);
            Controls.Add(btnConfirmPayment);
            Controls.Add(label6);
            Controls.Add(cboPaymentMethod);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblAmountToPay);
            Controls.Add(lblBalance);
            Controls.Add(numpadPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ELICIAS GARDEN FOOD PARK";
            TopMost = true;
            Load += PaymentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMop).EndInit();
            numpadPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox cboPaymentMethod;
        private Label label4;
        private Label lblAmountToPay;
        private Label lblChange;
        private Label label6;
        private Label lblBalance;
        private Label label3;
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
        private Button btnConfirmPayment;
        private Button btnApply;
        private Label lblAmountPaid;
        private Button btnRemove;
        private Label label2;
        private DataGridView dgvMop;
        private System.Windows.Forms.Timer postPaymentTimer;
        private Button btnCancelPayment;
        private DataGridViewTextBoxColumn mode;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn refnumber;
    }
}
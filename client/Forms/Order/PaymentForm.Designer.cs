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
            dgvProducts = new DataGridView();
            mode = new DataGridViewTextBoxColumn();
            productCategory = new DataGridViewTextBoxColumn();
            productSubcategory = new DataGridViewTextBoxColumn();
            panel10 = new Panel();
            btnRemove = new Button();
            btnApply = new Button();
            lblTotal = new Label();
            panel5 = new Panel();
            textBox1 = new TextBox();
            label5 = new Label();
            paymentDetailsPanel = new Panel();
            cboPaymentMethod = new ComboBox();
            label4 = new Label();
            panel7 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            lblChange = new Label();
            label6 = new Label();
            lblBalance = new Label();
            label3 = new Label();
            panel4 = new Panel();
            panel8 = new Panel();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panel10.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
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
            panel6.Controls.Add(dgvProducts);
            panel6.Controls.Add(panel10);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 295);
            panel6.Name = "panel6";
            panel6.Size = new Size(323, 199);
            panel6.TabIndex = 3;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeColumns = false;
            dgvProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(215, 204, 200);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(93, 64, 55);
            dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(232, 232, 232);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(232, 232, 232);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(232, 232, 232);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.ColumnHeadersHeight = 35;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { mode, productCategory, productSubcategory });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(215, 204, 200);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.Location = new Point(0, 0);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(214, 192, 179);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(323, 153);
            dgvProducts.TabIndex = 5;
            dgvProducts.TabStop = false;
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
            panel5.Controls.Add(textBox1);
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
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(232, 232, 232);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(16, 254);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 28);
            textBox1.TabIndex = 5;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.KeyPress += textBox1_KeyPress;
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
            panel7.Controls.Add(label2);
            panel7.Location = new Point(17, 6);
            panel7.Name = "panel7";
            panel7.Size = new Size(289, 51);
            panel7.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 8);
            label2.Name = "label2";
            label2.Size = new Size(219, 35);
            label2.TabIndex = 1;
            label2.Text = "0.00";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            panel4.Controls.Add(panel8);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(298, 350);
            panel4.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.FromArgb(232, 232, 232);
            panel8.Controls.Add(button10);
            panel8.Controls.Add(button11);
            panel8.Controls.Add(button12);
            panel8.Controls.Add(button7);
            panel8.Controls.Add(button8);
            panel8.Controls.Add(button9);
            panel8.Controls.Add(button4);
            panel8.Controls.Add(button5);
            panel8.Controls.Add(button6);
            panel8.Controls.Add(button3);
            panel8.Controls.Add(button2);
            panel8.Controls.Add(button1);
            panel8.Location = new Point(14, 5);
            panel8.Name = "panel8";
            panel8.Size = new Size(271, 341);
            panel8.TabIndex = 1;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(51, 51, 51);
            button10.FlatAppearance.BorderColor = Color.Gray;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.Image = Properties.Resources.Clear_Symbol;
            button10.Location = new Point(187, 258);
            button10.Name = "button10";
            button10.Size = new Size(70, 70);
            button10.TabIndex = 11;
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.White;
            button11.FlatAppearance.BorderColor = Color.Gray;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.Location = new Point(100, 258);
            button11.Name = "button11";
            button11.Size = new Size(70, 70);
            button11.TabIndex = 10;
            button11.Text = ".";
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.White;
            button12.FlatAppearance.BorderColor = Color.Gray;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.Location = new Point(13, 258);
            button12.Name = "button12";
            button12.Size = new Size(70, 70);
            button12.TabIndex = 9;
            button12.Text = "0";
            button12.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.FlatAppearance.BorderColor = Color.Gray;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(187, 176);
            button7.Name = "button7";
            button7.Size = new Size(70, 70);
            button7.TabIndex = 8;
            button7.Text = "3";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.FlatAppearance.BorderColor = Color.Gray;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(100, 176);
            button8.Name = "button8";
            button8.Size = new Size(70, 70);
            button8.TabIndex = 7;
            button8.Text = "2";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.FlatAppearance.BorderColor = Color.Gray;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(13, 176);
            button9.Name = "button9";
            button9.Size = new Size(70, 70);
            button9.TabIndex = 6;
            button9.Text = "1";
            button9.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderColor = Color.Gray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(187, 94);
            button4.Name = "button4";
            button4.Size = new Size(70, 70);
            button4.TabIndex = 5;
            button4.Text = "6";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatAppearance.BorderColor = Color.Gray;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(100, 94);
            button5.Name = "button5";
            button5.Size = new Size(70, 70);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.FlatAppearance.BorderColor = Color.Gray;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(13, 94);
            button6.Name = "button6";
            button6.Size = new Size(70, 70);
            button6.TabIndex = 3;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderColor = Color.Gray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(187, 12);
            button3.Name = "button3";
            button3.Size = new Size(70, 70);
            button3.TabIndex = 2;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.Gray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(100, 12);
            button2.Name = "button2";
            button2.Size = new Size(70, 70);
            button2.TabIndex = 1;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(13, 12);
            button1.Name = "button1";
            button1.Size = new Size(70, 70);
            button1.TabIndex = 0;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = false;
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
            KeyDown += PaymentForm_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel9.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panel10.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel8.ResumeLayout(false);
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
        private Label label2;
        private Panel panel3;
        private Label lblChange;
        private Label label6;
        private Label lblBalance;
        private Label label3;
        private Panel panel4;
        private Panel panel8;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel paymentDetailsPanel;
        private TextBox textBox1;
        private Label label5;
        private Panel panel10;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn mode;
        private DataGridViewTextBoxColumn productCategory;
        private DataGridViewTextBoxColumn productSubcategory;
        private Button btnConfirmPayment;
        private Button btnApply;
        private Label lblTotal;
        private Button btnRemove;
    }
}
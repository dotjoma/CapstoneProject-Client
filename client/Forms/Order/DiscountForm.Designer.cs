namespace client.Forms.Order
{
    partial class DiscountForm
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
            label1 = new Label();
            cboType = new ComboBox();
            label2 = new Label();
            txtName = new TextBox();
            txtIdNumber = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            btnConfirmPayment = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 42);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 0;
            label1.Text = "TYPE:";
            // 
            // cboType
            // 
            cboType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboType.BackColor = Color.FromArgb(232, 232, 232);
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboType.FormattingEnabled = true;
            cboType.Location = new Point(155, 39);
            cboType.Name = "cboType";
            cboType.Size = new Size(264, 36);
            cboType.TabIndex = 1;
            cboType.SelectedIndexChanged += cboType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 83);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 2;
            label2.Text = "NAME:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.BackColor = Color.FromArgb(232, 232, 232);
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(155, 83);
            txtName.Name = "txtName";
            txtName.Size = new Size(264, 34);
            txtName.TabIndex = 3;
            // 
            // txtIdNumber
            // 
            txtIdNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIdNumber.BackColor = Color.FromArgb(232, 232, 232);
            txtIdNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdNumber.Location = new Point(155, 124);
            txtIdNumber.Name = "txtIdNumber";
            txtIdNumber.Size = new Size(264, 34);
            txtIdNumber.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 124);
            label3.Name = "label3";
            label3.Size = new Size(130, 28);
            label3.TabIndex = 4;
            label3.Text = "ID NUMBER:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(98, 87, 87);
            panel1.Controls.Add(btnConfirmPayment);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 37);
            panel1.TabIndex = 6;
            // 
            // btnConfirmPayment
            // 
            btnConfirmPayment.BackColor = Color.FromArgb(141, 110, 99);
            btnConfirmPayment.Dock = DockStyle.Fill;
            btnConfirmPayment.FlatAppearance.BorderSize = 0;
            btnConfirmPayment.FlatStyle = FlatStyle.Flat;
            btnConfirmPayment.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmPayment.ForeColor = Color.White;
            btnConfirmPayment.Location = new Point(0, 0);
            btnConfirmPayment.Name = "btnConfirmPayment";
            btnConfirmPayment.Size = new Size(437, 37);
            btnConfirmPayment.TabIndex = 1;
            btnConfirmPayment.Text = "SAVE - [ENTER]";
            btnConfirmPayment.UseVisualStyleBackColor = false;
            btnConfirmPayment.Click += btnConfirmPayment_Click;
            btnConfirmPayment.MouseEnter += btnConfirmPayment_MouseEnter;
            btnConfirmPayment.MouseLeave += btnConfirmPayment_MouseLeave;
            // 
            // DiscountForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(437, 237);
            Controls.Add(panel1);
            Controls.Add(txtIdNumber);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(cboType);
            Controls.Add(label1);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DiscountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DISCOUNT";
            TopMost = true;
            Load += DiscountForm_Load;
            KeyDown += DiscountForm_KeyDown;
            KeyPress += DiscountForm_KeyPress;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboType;
        private Label label2;
        private TextBox txtName;
        private TextBox txtIdNumber;
        private Label label3;
        private Panel panel1;
        private Button btnConfirmPayment;
    }
}
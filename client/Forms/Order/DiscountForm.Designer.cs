﻿namespace client.Forms.Order
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
            label1.Location = new Point(18, 22);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 0;
            label1.Text = "TYPE:";
            // 
            // cboType
            // 
            cboType.BackColor = Color.FromArgb(232, 232, 232);
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboType.FormattingEnabled = true;
            cboType.Location = new Point(146, 19);
            cboType.Name = "cboType";
            cboType.Size = new Size(171, 29);
            cboType.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 63);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 2;
            label2.Text = "NAME:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(232, 232, 232);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(146, 63);
            txtName.Name = "txtName";
            txtName.Size = new Size(171, 22);
            txtName.TabIndex = 3;
            // 
            // txtIdNumber
            // 
            txtIdNumber.BackColor = Color.FromArgb(232, 232, 232);
            txtIdNumber.BorderStyle = BorderStyle.None;
            txtIdNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdNumber.Location = new Point(146, 104);
            txtIdNumber.Name = "txtIdNumber";
            txtIdNumber.Size = new Size(171, 22);
            txtIdNumber.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 104);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 4;
            label3.Text = "ID NUMBER:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(98, 87, 87);
            panel1.Controls.Add(btnConfirmPayment);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 178);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 37);
            panel1.TabIndex = 6;
            // 
            // btnConfirmPayment
            // 
            btnConfirmPayment.Dock = DockStyle.Fill;
            btnConfirmPayment.FlatAppearance.BorderSize = 0;
            btnConfirmPayment.FlatStyle = FlatStyle.Flat;
            btnConfirmPayment.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmPayment.ForeColor = Color.White;
            btnConfirmPayment.Location = new Point(0, 0);
            btnConfirmPayment.Name = "btnConfirmPayment";
            btnConfirmPayment.Size = new Size(335, 37);
            btnConfirmPayment.TabIndex = 1;
            btnConfirmPayment.Text = "CONFIRM PAYMENT - [ENTER]";
            btnConfirmPayment.UseVisualStyleBackColor = true;
            // 
            // DiscountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(335, 215);
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
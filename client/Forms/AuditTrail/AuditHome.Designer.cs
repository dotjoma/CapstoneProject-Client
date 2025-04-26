namespace client.Forms.AuditTrail
{
    partial class AuditHome
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel2 = new Panel();
            comboBox2 = new ComboBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            textBox2 = new TextBox();
            pictureBox4 = new PictureBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            btnRefresh = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            dgvAudit = new DataGridView();
            date = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            action = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            prevvalue = new DataGridViewTextBoxColumn();
            newvalue = new DataGridViewTextBoxColumn();
            entity = new DataGridViewTextBoxColumn();
            entityid = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAudit).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(239, 235, 233);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1024, 59);
            panel2.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Right;
            comboBox2.BackColor = Color.FromArgb(248, 245, 240);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.System;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1452, 10);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(130, 23);
            comboBox2.TabIndex = 14;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(93, 64, 55);
            label3.Location = new Point(1382, 12);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 13;
            label3.Text = "Filter by:";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.Search;
            pictureBox3.Location = new Point(1615, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Right;
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(93, 64, 55);
            textBox2.Location = new Point(1645, 11);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Search Item(s)";
            textBox2.Size = new Size(208, 22);
            textBox2.TabIndex = 11;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Right;
            pictureBox4.BackColor = Color.FromArgb(232, 232, 232);
            pictureBox4.Image = Properties.Resources.Refresh1;
            pictureBox4.Location = new Point(1338, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Right;
            comboBox1.BackColor = Color.FromArgb(248, 245, 240);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(2267, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(130, 23);
            comboBox1.TabIndex = 9;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(93, 64, 55);
            label2.Location = new Point(2196, 2);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 8;
            label2.Text = "Filter by:";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.Search;
            pictureBox2.Location = new Point(2430, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Right;
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(93, 64, 55);
            textBox1.Location = new Point(2460, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Item(s)";
            textBox1.Size = new Size(208, 22);
            textBox1.TabIndex = 6;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(232, 232, 232);
            btnRefresh.Image = Properties.Resources.Refresh1;
            btnRefresh.Location = new Point(2152, 1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(24, 24);
            btnRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRefresh.TabIndex = 3;
            btnRefresh.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(62, 39, 35);
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 0;
            label1.Text = "AUDIT LOGS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(239, 235, 233);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 471);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 59);
            panel1.TabIndex = 4;
            // 
            // dgvAudit
            // 
            dgvAudit.AllowUserToAddRows = false;
            dgvAudit.AllowUserToDeleteRows = false;
            dgvAudit.AllowUserToResizeColumns = false;
            dgvAudit.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(245, 242, 237);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(93, 64, 55);
            dgvAudit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAudit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAudit.BackgroundColor = Color.White;
            dgvAudit.BorderStyle = BorderStyle.None;
            dgvAudit.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(121, 85, 72);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(121, 85, 72);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAudit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAudit.ColumnHeadersHeight = 35;
            dgvAudit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAudit.Columns.AddRange(new DataGridViewColumn[] { date, username, action, description, prevvalue, newvalue, entity, entityid });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(245, 242, 237);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvAudit.DefaultCellStyle = dataGridViewCellStyle4;
            dgvAudit.Dock = DockStyle.Fill;
            dgvAudit.EnableHeadersVisualStyles = false;
            dgvAudit.GridColor = Color.White;
            dgvAudit.Location = new Point(0, 59);
            dgvAudit.MultiSelect = false;
            dgvAudit.Name = "dgvAudit";
            dgvAudit.ReadOnly = true;
            dgvAudit.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(214, 192, 179);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvAudit.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvAudit.RowHeadersVisible = false;
            dgvAudit.RowHeadersWidth = 51;
            dgvAudit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAudit.Size = new Size(1024, 412);
            dgvAudit.TabIndex = 6;
            dgvAudit.TabStop = false;
            dgvAudit.CellContentClick += dgvAudit_CellContentClick;
            // 
            // date
            // 
            date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            date.FillWeight = 114.315689F;
            date.HeaderText = "Date";
            date.MinimumWidth = 120;
            date.Name = "date";
            date.ReadOnly = true;
            date.Width = 120;
            // 
            // username
            // 
            username.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            username.FillWeight = 110.479927F;
            username.HeaderText = "Name";
            username.MinimumWidth = 120;
            username.Name = "username";
            username.ReadOnly = true;
            username.Width = 120;
            // 
            // action
            // 
            action.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            action.FillWeight = 115.0222F;
            action.HeaderText = "Action";
            action.MinimumWidth = 100;
            action.Name = "action";
            action.ReadOnly = true;
            action.Width = 125;
            // 
            // description
            // 
            description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            description.FillWeight = 137.7169F;
            description.HeaderText = "Description";
            description.MinimumWidth = 50;
            description.Name = "description";
            description.ReadOnly = true;
            // 
            // prevvalue
            // 
            prevvalue.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prevvalue.DefaultCellStyle = dataGridViewCellStyle3;
            prevvalue.FillWeight = 178.85527F;
            prevvalue.HeaderText = "Prev Value";
            prevvalue.MinimumWidth = 180;
            prevvalue.Name = "prevvalue";
            prevvalue.ReadOnly = true;
            prevvalue.Width = 180;
            // 
            // newvalue
            // 
            newvalue.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            newvalue.HeaderText = "New Value";
            newvalue.MinimumWidth = 180;
            newvalue.Name = "newvalue";
            newvalue.ReadOnly = true;
            newvalue.Width = 180;
            // 
            // entity
            // 
            entity.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            entity.HeaderText = "Entity";
            entity.MinimumWidth = 100;
            entity.Name = "entity";
            entity.ReadOnly = true;
            entity.Width = 125;
            // 
            // entityid
            // 
            entityid.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            entityid.HeaderText = "Entity ID";
            entityid.MinimumWidth = 80;
            entityid.Name = "entityid";
            entityid.ReadOnly = true;
            entityid.Width = 80;
            // 
            // AuditHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 530);
            Controls.Add(dgvAudit);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AuditHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AuditHome";
            Load += AuditHome_Load;
            Shown += AuditHome_Shown;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAudit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private ComboBox comboBox2;
        private Label label3;
        private PictureBox pictureBox3;
        private TextBox textBox2;
        private PictureBox pictureBox4;
        private ComboBox comboBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private PictureBox btnRefresh;
        private Label label1;
        private Panel panel1;
        private DataGridView dgvAudit;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn action;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn prevvalue;
        private DataGridViewTextBoxColumn newvalue;
        private DataGridViewTextBoxColumn entity;
        private DataGridViewTextBoxColumn entityid;
    }
}
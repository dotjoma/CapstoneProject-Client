namespace client.Forms.Loading
{
    partial class MainMenuLoading
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
            LoadingTimer = new System.Windows.Forms.Timer(components);
            lblLoading = new Label();
            SuspendLayout();
            // 
            // LoadingTimer
            // 
            LoadingTimer.Tick += LoadingTimer_Tick;
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.Font = new Font("Microsoft Sans Serif", 20.25F);
            lblLoading.ForeColor = Color.White;
            lblLoading.Location = new Point(651, 364);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(134, 31);
            lblLoading.TabIndex = 1;
            lblLoading.Text = "Loading...";
            // 
            // MainMenuLoading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1444, 760);
            Controls.Add(lblLoading);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenuLoading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenuLoading";
            Load += MainMenuLoading_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer LoadingTimer;
        private Label lblLoading;
    }
}
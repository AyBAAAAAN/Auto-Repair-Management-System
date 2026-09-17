namespace ARMSProtOne
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.picUserIcon = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.picPasswordIcon = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblDemoAccounts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordIcon)).BeginInit();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();

            // ===== CARD =====
            this.pnlCard.BackColor = System.Drawing.Color.FromArgb(0, 51, 153);
            this.pnlCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCard.Location = new System.Drawing.Point(200, 90);
            this.pnlCard.Size = new System.Drawing.Size(500, 460);
            this.pnlCard.Controls.Add(this.lblBusinessName);
            this.pnlCard.Controls.Add(this.lblSubtitle);
            this.pnlCard.Controls.Add(this.picUserIcon);
            this.pnlCard.Controls.Add(this.txtUsername);
            this.pnlCard.Controls.Add(this.picPasswordIcon);
            this.pnlCard.Controls.Add(this.txtPassword);
            this.pnlCard.Controls.Add(this.btnLogin);
            this.pnlCard.Controls.Add(this.lblDemoAccounts);

            // ===== BUSINESS NAME =====
            this.lblBusinessName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblBusinessName.ForeColor = System.Drawing.Color.White;
            this.lblBusinessName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBusinessName.Location = new System.Drawing.Point(30, 35);
            this.lblBusinessName.Size = new System.Drawing.Size(440, 60);
            this.lblBusinessName.Text = "ARIAS CRUZ\r\nCAR AIRCON AUTO ELECTRICAL";

            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSubtitle.Location = new System.Drawing.Point(30, 100);
            this.lblSubtitle.Size = new System.Drawing.Size(440, 24);
            this.lblSubtitle.Text = "Auto Repair Management System";

            // ===== USERNAME =====
            this.picUserIcon.BackColor = System.Drawing.Color.FromArgb(0, 41, 128);
            this.picUserIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUserIcon.Location = new System.Drawing.Point(60, 165);
            this.picUserIcon.Size = new System.Drawing.Size(36, 36);
            this.picUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;

            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.txtUsername.Location = new System.Drawing.Point(104, 165);
            this.txtUsername.Size = new System.Drawing.Size(336, 28);

            // ===== PASSWORD =====
            this.picPasswordIcon.BackColor = System.Drawing.Color.FromArgb(0, 41, 128);
            this.picPasswordIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPasswordIcon.Location = new System.Drawing.Point(60, 215);
            this.picPasswordIcon.Size = new System.Drawing.Size(36, 36);
            this.picPasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;

            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.txtPassword.Location = new System.Drawing.Point(104, 215);
            this.txtPassword.Size = new System.Drawing.Size(336, 28);
            this.txtPassword.UseSystemPasswordChar = true;

            // ===== LOGIN BUTTON =====
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(0, 51, 153);
            this.btnLogin.Location = new System.Drawing.Point(60, 275);
            this.btnLogin.Size = new System.Drawing.Size(380, 42);
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // ===== DEMO ACCOUNTS =====
            this.lblDemoAccounts.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblDemoAccounts.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDemoAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDemoAccounts.Location = new System.Drawing.Point(30, 345);
            this.lblDemoAccounts.Size = new System.Drawing.Size(440, 60);
            this.lblDemoAccounts.Text = "Demo Accounts (for testing)\r\nAdmin — user: admin  pass: 1234\r\nStaff — user: staff  pass: 1234";

            // ===== ROOT =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Arias Cruz Car Aircon Auto Electrical";
            this.Resize += new System.EventHandler(this.LoginForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordIcon)).EndInit();
            this.pnlCard.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.PictureBox picUserIcon;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox picPasswordIcon;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblDemoAccounts;
    }
}
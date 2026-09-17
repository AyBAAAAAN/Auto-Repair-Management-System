namespace ARMSProtOne
{
    partial class AccountsControlAddEditStaff
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btnCancelSA = new System.Windows.Forms.Button();
            this.btnDeleteSA = new System.Windows.Forms.Button();
            this.btnSaveSA = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // ===== ADD/EDIT ACCOUNT =====
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.Location = new System.Drawing.Point(18, 15);
            this.lblFormTitle.Text = "Add/Edit Account";

            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(20, 60);
            this.lblFullName.Text = "Full Name:";
            this.txtFullName.Location = new System.Drawing.Point(150, 57);
            this.txtFullName.Size = new System.Drawing.Size(400, 24);

            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(20, 100);
            this.lblUsername.Text = "User Name:";
            this.txtUsername.Location = new System.Drawing.Point(150, 97);
            this.txtUsername.Size = new System.Drawing.Size(200, 24);

            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(400, 100);
            this.lblPassword.Text = "Password:";
            this.txtPassword.Location = new System.Drawing.Point(530, 97);
            this.txtPassword.Size = new System.Drawing.Size(150, 24);
            this.txtPassword.UseSystemPasswordChar = true;

            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(20, 140);
            this.lblContact.Text = "Contact Number:";
            this.txtContact.Location = new System.Drawing.Point(150, 137);
            this.txtContact.Size = new System.Drawing.Size(200, 24);

            this.btnCancelSA.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnCancelSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSA.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelSA.ForeColor = System.Drawing.Color.White;
            this.btnCancelSA.Location = new System.Drawing.Point(478, 600);
            this.btnCancelSA.Size = new System.Drawing.Size(100, 35);
            this.btnCancelSA.Text = "Cancel";
            this.btnCancelSA.UseVisualStyleBackColor = false;
            this.btnCancelSA.Click += new System.EventHandler(this.btnCancelSA_Click);

            this.btnDeleteSA.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDeleteSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSA.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDeleteSA.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSA.Location = new System.Drawing.Point(590, 600);
            this.btnDeleteSA.Size = new System.Drawing.Size(110, 35);
            this.btnDeleteSA.Text = "Delete";
            this.btnDeleteSA.UseVisualStyleBackColor = false;
            this.btnDeleteSA.Click += new System.EventHandler(this.btnDeleteSA_Click);

            this.btnSaveSA.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSaveSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSA.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSaveSA.ForeColor = System.Drawing.Color.White;
            this.btnSaveSA.Location = new System.Drawing.Point(714, 600);
            this.btnSaveSA.Size = new System.Drawing.Size(110, 35);
            this.btnSaveSA.Text = "Save Account";
            this.btnSaveSA.UseVisualStyleBackColor = false;
            this.btnSaveSA.Click += new System.EventHandler(this.btnSaveSA_Click);

            // ===== ROOT =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnSaveSA);
            this.Controls.Add(this.btnDeleteSA);
            this.Controls.Add(this.btnCancelSA);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblFormTitle);
            this.Name = "AccountsControlAddEditStaff";
            this.Size = new System.Drawing.Size(844, 655);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Button btnCancelSA;
        private System.Windows.Forms.Button btnDeleteSA;
        private System.Windows.Forms.Button btnSaveSA;
    }
}
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
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.Location = new System.Drawing.Point(15, 13);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(164, 25);
            this.lblFormTitle.TabIndex = 11;
            this.lblFormTitle.Text = "Add/Edit Account";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(17, 52);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(57, 13);
            this.lblFullName.TabIndex = 10;
            this.lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(129, 49);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(343, 20);
            this.txtFullName.TabIndex = 9;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(17, 87);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(63, 13);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "User Name:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(129, 84);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(172, 20);
            this.txtUsername.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(343, 87);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(454, 84);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(129, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(17, 121);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(87, 13);
            this.lblContact.TabIndex = 4;
            this.lblContact.Text = "Contact Number:";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(129, 119);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(172, 20);
            this.txtContact.TabIndex = 3;
            // 
            // btnCancelSA
            // 
            this.btnCancelSA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancelSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSA.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelSA.ForeColor = System.Drawing.Color.White;
            this.btnCancelSA.Location = new System.Drawing.Point(410, 520);
            this.btnCancelSA.Name = "btnCancelSA";
            this.btnCancelSA.Size = new System.Drawing.Size(86, 30);
            this.btnCancelSA.TabIndex = 2;
            this.btnCancelSA.Text = "Cancel";
            this.btnCancelSA.UseVisualStyleBackColor = false;
            this.btnCancelSA.Click += new System.EventHandler(this.btnCancelSA_Click);
            // 
            // btnDeleteSA
            // 
            this.btnDeleteSA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSA.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDeleteSA.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSA.Location = new System.Drawing.Point(506, 520);
            this.btnDeleteSA.Name = "btnDeleteSA";
            this.btnDeleteSA.Size = new System.Drawing.Size(94, 30);
            this.btnDeleteSA.TabIndex = 1;
            this.btnDeleteSA.Text = "Delete";
            this.btnDeleteSA.UseVisualStyleBackColor = false;
            this.btnDeleteSA.Click += new System.EventHandler(this.btnDeleteSA_Click);
            // 
            // btnSaveSA
            // 
            this.btnSaveSA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSaveSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSA.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSaveSA.ForeColor = System.Drawing.Color.White;
            this.btnSaveSA.Location = new System.Drawing.Point(612, 520);
            this.btnSaveSA.Name = "btnSaveSA";
            this.btnSaveSA.Size = new System.Drawing.Size(94, 30);
            this.btnSaveSA.TabIndex = 0;
            this.btnSaveSA.Text = "Save Account";
            this.btnSaveSA.UseVisualStyleBackColor = false;
            this.btnSaveSA.Click += new System.EventHandler(this.btnSaveSA_Click);
            // 
            // AccountsControlAddEditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Size = new System.Drawing.Size(723, 568);
            this.Load += new System.EventHandler(this.AccountsControlAddEditStaff_Load);
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
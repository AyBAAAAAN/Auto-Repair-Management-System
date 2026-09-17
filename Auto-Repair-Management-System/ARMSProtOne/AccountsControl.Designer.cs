namespace ARMSProtOne
{
    partial class AccountsControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnTabStaff = new System.Windows.Forms.Button();
            this.btnTabTechnicians = new System.Windows.Forms.Button();
            this.btnManageAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.dgvStaffAccounts = new System.Windows.Forms.DataGridView();
            this.colStaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTechnicians = new System.Windows.Forms.DataGridView();
            this.colTechName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTechContact = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlHeader.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicians)).BeginInit();
            this.SuspendLayout();

            // ===== HEADER =====
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(844, 55);
            this.pnlHeader.Controls.Add(this.lblTitle);

            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(18, 13);
            this.lblTitle.Text = "Accounts";

            // ===== TOOLBAR =====
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 55);
            this.pnlToolbar.Size = new System.Drawing.Size(844, 60);
            this.pnlToolbar.Controls.Add(this.btnTabStaff);
            this.pnlToolbar.Controls.Add(this.btnTabTechnicians);
            this.pnlToolbar.Controls.Add(this.btnManageAccount);
            this.pnlToolbar.Controls.Add(this.btnAddAccount);

            this.btnTabStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabStaff.FlatAppearance.BorderSize = 0;
            this.btnTabStaff.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTabStaff.Location = new System.Drawing.Point(15, 15);
            this.btnTabStaff.Size = new System.Drawing.Size(120, 30);
            this.btnTabStaff.Text = "Staff Account";
            this.btnTabStaff.UseVisualStyleBackColor = true;
            this.btnTabStaff.Click += new System.EventHandler(this.btnTabStaff_Click);

            this.btnTabTechnicians.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabTechnicians.FlatAppearance.BorderSize = 0;
            this.btnTabTechnicians.ForeColor = System.Drawing.Color.Gray;
            this.btnTabTechnicians.Location = new System.Drawing.Point(140, 15);
            this.btnTabTechnicians.Size = new System.Drawing.Size(120, 30);
            this.btnTabTechnicians.Text = "Technicians";
            this.btnTabTechnicians.UseVisualStyleBackColor = true;
            this.btnTabTechnicians.Click += new System.EventHandler(this.btnTabTechnicians_Click);

            this.btnManageAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageAccount.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnManageAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAccount.FlatAppearance.BorderSize = 0;
            this.btnManageAccount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnManageAccount.ForeColor = System.Drawing.Color.White;
            this.btnManageAccount.Location = new System.Drawing.Point(538, 13);
            this.btnManageAccount.Size = new System.Drawing.Size(130, 34);
            this.btnManageAccount.Text = "Edit Selected";
            this.btnManageAccount.UseVisualStyleBackColor = false;
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);

            this.btnAddAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAccount.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.FlatAppearance.BorderSize = 0;
            this.btnAddAccount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAddAccount.ForeColor = System.Drawing.Color.White;
            this.btnAddAccount.Location = new System.Drawing.Point(674, 13);
            this.btnAddAccount.Size = new System.Drawing.Size(155, 34);
            this.btnAddAccount.Text = "+ Add Staff Account";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);

            // ===== STAFF GRID =====
            this.dgvStaffAccounts.AllowUserToAddRows = false;
            this.dgvStaffAccounts.AllowUserToDeleteRows = false;
            this.dgvStaffAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStaffAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaffAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dgvStaffAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStaffAccounts.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.dgvStaffAccounts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvStaffAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStaffName, this.colUsername, this.colPassword, this.colStaffContact});
            this.dgvStaffAccounts.Location = new System.Drawing.Point(18, 125);
            this.dgvStaffAccounts.MultiSelect = false;
            this.dgvStaffAccounts.ReadOnly = true;
            this.dgvStaffAccounts.RowHeadersVisible = false;
            this.dgvStaffAccounts.RowTemplate.Height = 32;
            this.dgvStaffAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffAccounts.Size = new System.Drawing.Size(808, 512);

            this.colStaffName.HeaderText = "Name"; this.colStaffName.Name = "colStaffName"; this.colStaffName.ReadOnly = true;
            this.colUsername.HeaderText = "Username"; this.colUsername.Name = "colUsername"; this.colUsername.ReadOnly = true;
            this.colPassword.HeaderText = "Password"; this.colPassword.Name = "colPassword"; this.colPassword.ReadOnly = true;
            this.colStaffContact.HeaderText = "Contact"; this.colStaffContact.Name = "colStaffContact"; this.colStaffContact.ReadOnly = true;

            // ===== TECHNICIAN GRID =====
            this.dgvTechnicians.AllowUserToAddRows = false;
            this.dgvTechnicians.AllowUserToDeleteRows = false;
            this.dgvTechnicians.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTechnicians.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTechnicians.BackgroundColor = System.Drawing.Color.White;
            this.dgvTechnicians.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTechnicians.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.dgvTechnicians.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvTechnicians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechnicians.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTechName, this.colTechContact});
            this.dgvTechnicians.Location = new System.Drawing.Point(18, 125);
            this.dgvTechnicians.MultiSelect = false;
            this.dgvTechnicians.ReadOnly = true;
            this.dgvTechnicians.RowHeadersVisible = false;
            this.dgvTechnicians.RowTemplate.Height = 32;
            this.dgvTechnicians.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTechnicians.Size = new System.Drawing.Size(808, 512);
            this.dgvTechnicians.Visible = false;

            this.colTechName.HeaderText = "Name"; this.colTechName.Name = "colTechName"; this.colTechName.ReadOnly = true;
            this.colTechContact.HeaderText = "Contact"; this.colTechContact.Name = "colTechContact"; this.colTechContact.ReadOnly = true;

            // ===== ROOT =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.dgvTechnicians);
            this.Controls.Add(this.dgvStaffAccounts);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.Name = "AccountsControl";
            this.Size = new System.Drawing.Size(844, 655);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicians)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Button btnTabStaff;
        private System.Windows.Forms.Button btnTabTechnicians;
        private System.Windows.Forms.Button btnManageAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.DataGridView dgvStaffAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffContact;
        private System.Windows.Forms.DataGridView dgvTechnicians;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTechName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTechContact;
    }
}
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(723, 48);
            this.pnlHeader.TabIndex = 3;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(91, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Accounts";
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToolbar.Controls.Add(this.btnTabStaff);
            this.pnlToolbar.Controls.Add(this.btnTabTechnicians);
            this.pnlToolbar.Controls.Add(this.btnManageAccount);
            this.pnlToolbar.Controls.Add(this.btnAddAccount);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 48);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(723, 52);
            this.pnlToolbar.TabIndex = 2;
            this.pnlToolbar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlToolbar_Paint);
            // 
            // btnTabStaff
            // 
            this.btnTabStaff.FlatAppearance.BorderSize = 0;
            this.btnTabStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabStaff.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTabStaff.Location = new System.Drawing.Point(13, 13);
            this.btnTabStaff.Name = "btnTabStaff";
            this.btnTabStaff.Size = new System.Drawing.Size(103, 26);
            this.btnTabStaff.TabIndex = 0;
            this.btnTabStaff.Text = "Staff Account";
            this.btnTabStaff.UseVisualStyleBackColor = true;
            this.btnTabStaff.Click += new System.EventHandler(this.btnTabStaff_Click);
            // 
            // btnTabTechnicians
            // 
            this.btnTabTechnicians.FlatAppearance.BorderSize = 0;
            this.btnTabTechnicians.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabTechnicians.ForeColor = System.Drawing.Color.Gray;
            this.btnTabTechnicians.Location = new System.Drawing.Point(120, 13);
            this.btnTabTechnicians.Name = "btnTabTechnicians";
            this.btnTabTechnicians.Size = new System.Drawing.Size(103, 26);
            this.btnTabTechnicians.TabIndex = 1;
            this.btnTabTechnicians.Text = "Technicians";
            this.btnTabTechnicians.UseVisualStyleBackColor = true;
            this.btnTabTechnicians.Click += new System.EventHandler(this.btnTabTechnicians_Click);
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnManageAccount.FlatAppearance.BorderSize = 0;
            this.btnManageAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAccount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnManageAccount.ForeColor = System.Drawing.Color.White;
            this.btnManageAccount.Location = new System.Drawing.Point(460, 11);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(111, 29);
            this.btnManageAccount.TabIndex = 2;
            this.btnManageAccount.Text = "Edit Selected";
            this.btnManageAccount.UseVisualStyleBackColor = false;
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAddAccount.FlatAppearance.BorderSize = 0;
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAddAccount.ForeColor = System.Drawing.Color.White;
            this.btnAddAccount.Location = new System.Drawing.Point(577, 11);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(133, 29);
            this.btnAddAccount.TabIndex = 3;
            this.btnAddAccount.Text = "+ Add Staff Account";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // dgvStaffAccounts
            // 
            this.dgvStaffAccounts.AllowUserToAddRows = false;
            this.dgvStaffAccounts.AllowUserToDeleteRows = false;
            this.dgvStaffAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStaffAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaffAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dgvStaffAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStaffAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStaffName,
            this.colUsername,
            this.colPassword,
            this.colStaffContact});
            this.dgvStaffAccounts.Location = new System.Drawing.Point(15, 108);
            this.dgvStaffAccounts.MultiSelect = false;
            this.dgvStaffAccounts.Name = "dgvStaffAccounts";
            this.dgvStaffAccounts.ReadOnly = true;
            this.dgvStaffAccounts.RowHeadersVisible = false;
            this.dgvStaffAccounts.RowTemplate.Height = 32;
            this.dgvStaffAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffAccounts.Size = new System.Drawing.Size(693, 444);
            this.dgvStaffAccounts.TabIndex = 1;
            // 
            // colStaffName
            // 
            this.colStaffName.HeaderText = "Name";
            this.colStaffName.Name = "colStaffName";
            this.colStaffName.ReadOnly = true;
            // 
            // colUsername
            // 
            this.colUsername.HeaderText = "Username";
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            // 
            // colPassword
            // 
            this.colPassword.HeaderText = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.ReadOnly = true;
            // 
            // colStaffContact
            // 
            this.colStaffContact.HeaderText = "Contact";
            this.colStaffContact.Name = "colStaffContact";
            this.colStaffContact.ReadOnly = true;
            // 
            // dgvTechnicians
            // 
            this.dgvTechnicians.AllowUserToAddRows = false;
            this.dgvTechnicians.AllowUserToDeleteRows = false;
            this.dgvTechnicians.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTechnicians.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTechnicians.BackgroundColor = System.Drawing.Color.White;
            this.dgvTechnicians.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTechnicians.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTechnicians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechnicians.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTechName,
            this.colTechContact});
            this.dgvTechnicians.Location = new System.Drawing.Point(15, 108);
            this.dgvTechnicians.MultiSelect = false;
            this.dgvTechnicians.Name = "dgvTechnicians";
            this.dgvTechnicians.ReadOnly = true;
            this.dgvTechnicians.RowHeadersVisible = false;
            this.dgvTechnicians.RowTemplate.Height = 32;
            this.dgvTechnicians.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTechnicians.Size = new System.Drawing.Size(693, 444);
            this.dgvTechnicians.TabIndex = 0;
            this.dgvTechnicians.Visible = false;
            // 
            // colTechName
            // 
            this.colTechName.HeaderText = "Name";
            this.colTechName.Name = "colTechName";
            this.colTechName.ReadOnly = true;
            // 
            // colTechContact
            // 
            this.colTechContact.HeaderText = "Contact";
            this.colTechContact.Name = "colTechContact";
            this.colTechContact.ReadOnly = true;
            // 
            // AccountsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.dgvTechnicians);
            this.Controls.Add(this.dgvStaffAccounts);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.Name = "AccountsControl";
            this.Size = new System.Drawing.Size(723, 568);
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
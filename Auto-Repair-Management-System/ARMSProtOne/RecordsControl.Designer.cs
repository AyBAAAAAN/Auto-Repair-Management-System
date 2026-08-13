namespace ARMSProtOne
{
    partial class RecordsControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTopToolbar = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.grpCustomerDatabase = new System.Windows.Forms.GroupBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.colCustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlTopToolbar.SuspendLayout();
            this.grpCustomerDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();

            // pnlTopToolbar
            this.pnlTopToolbar.BackColor = System.Drawing.Color.White;
            this.pnlTopToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTopToolbar.Controls.Add(this.btnEditCustomer);
            this.pnlTopToolbar.Controls.Add(this.btnAddCustomer);
            this.pnlTopToolbar.Controls.Add(this.txtSearch);
            this.pnlTopToolbar.Controls.Add(this.lblSearch);
            this.pnlTopToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopToolbar.Name = "pnlTopToolbar";
            this.pnlTopToolbar.Size = new System.Drawing.Size(844, 60);
            this.pnlTopToolbar.TabIndex = 0;

            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(16, 21);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Text = "Search Customer:";

            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.Location = new System.Drawing.Point(140, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 24);
            this.txtSearch.TabIndex = 1;

            this.btnAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(558, 12);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(130, 34);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "+ Add Record";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);

            this.btnEditCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCustomer.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCustomer.FlatAppearance.BorderSize = 0;
            this.btnEditCustomer.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEditCustomer.ForeColor = System.Drawing.Color.White;
            this.btnEditCustomer.Location = new System.Drawing.Point(698, 12);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(130, 34);
            this.btnEditCustomer.TabIndex = 3;
            this.btnEditCustomer.Text = "Modify File";
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);

            // grpCustomerDatabase
            this.grpCustomerDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCustomerDatabase.Controls.Add(this.dgvCustomers);
            this.grpCustomerDatabase.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpCustomerDatabase.Location = new System.Drawing.Point(18, 72);
            this.grpCustomerDatabase.Name = "grpCustomerDatabase";
            this.grpCustomerDatabase.Padding = new System.Windows.Forms.Padding(8);
            this.grpCustomerDatabase.Size = new System.Drawing.Size(808, 565);
            this.grpCustomerDatabase.TabIndex = 1;
            this.grpCustomerDatabase.TabStop = false;
            this.grpCustomerDatabase.Text = "Registered Vehicle Owners Database";

            // dgvCustomers
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustID,
            this.colCustName,
            this.colContact,
            this.colVehicle,
            this.colPlateNumber});
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.dgvCustomers.RowTemplate.Height = 30;
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.TabIndex = 0;

            this.colCustID.HeaderText = "Customer ID";
            this.colCustID.Name = "colCustID";
            this.colCustID.ReadOnly = true;
            this.colCustID.FillWeight = 90;

            this.colCustName.HeaderText = "Owner Name";
            this.colCustName.Name = "colCustName";
            this.colCustName.ReadOnly = true;
            this.colCustName.FillWeight = 140;

            this.colContact.HeaderText = "Contact Number";
            this.colContact.Name = "colContact";
            this.colContact.ReadOnly = true;
            this.colContact.FillWeight = 120;

            this.colVehicle.HeaderText = "Vehicle Model";
            this.colVehicle.Name = "colVehicle";
            this.colVehicle.ReadOnly = true;
            this.colVehicle.FillWeight = 140;

            this.colPlateNumber.HeaderText = "Plate #";
            this.colPlateNumber.Name = "colPlateNumber";
            this.colPlateNumber.ReadOnly = true;
            this.colPlateNumber.FillWeight = 100;

            // root
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.grpCustomerDatabase);
            this.Controls.Add(this.pnlTopToolbar);
            this.Name = "CustomerManagementControl";
            this.Size = new System.Drawing.Size(844, 655);
            this.pnlTopToolbar.ResumeLayout(false);
            this.pnlTopToolbar.PerformLayout();
            this.grpCustomerDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTopToolbar;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.GroupBox grpCustomerDatabase;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateNumber;
    }
}
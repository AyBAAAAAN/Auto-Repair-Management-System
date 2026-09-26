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
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
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
            // 
            // pnlTopToolbar
            // 
            this.pnlTopToolbar.BackColor = System.Drawing.Color.White;
            this.pnlTopToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTopToolbar.Controls.Add(this.btnEditCustomer);
            this.pnlTopToolbar.Controls.Add(this.btnAddCustomer);
            this.pnlTopToolbar.Controls.Add(this.txtSearch);
            this.pnlTopToolbar.Controls.Add(this.lblSearch);
            this.pnlTopToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopToolbar.Name = "pnlTopToolbar";
            this.pnlTopToolbar.Size = new System.Drawing.Size(723, 52);
            this.pnlTopToolbar.TabIndex = 0;
            this.pnlTopToolbar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTopToolbar_Paint);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnEditCustomer.FlatAppearance.BorderSize = 0;
            this.btnEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCustomer.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEditCustomer.ForeColor = System.Drawing.Color.White;
            this.btnEditCustomer.Location = new System.Drawing.Point(597, 10);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(111, 29);
            this.btnEditCustomer.TabIndex = 3;
            this.btnEditCustomer.Text = "Modify File";
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(477, 10);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(111, 29);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "+ Add Record";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.Location = new System.Drawing.Point(120, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(258, 24);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(14, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(116, 17);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search Customer:";
            // 
            // grpCustomerDatabase
            // 
            this.grpCustomerDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCustomerDatabase.Controls.Add(this.dgvCustomers);
            this.grpCustomerDatabase.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpCustomerDatabase.Location = new System.Drawing.Point(15, 62);
            this.grpCustomerDatabase.Name = "grpCustomerDatabase";
            this.grpCustomerDatabase.Padding = new System.Windows.Forms.Padding(7);
            this.grpCustomerDatabase.Size = new System.Drawing.Size(693, 490);
            this.grpCustomerDatabase.TabIndex = 1;
            this.grpCustomerDatabase.TabStop = false;
            this.grpCustomerDatabase.Text = "Registered Vehicle Owners Database";
            this.grpCustomerDatabase.Enter += new System.EventHandler(this.grpCustomerDatabase_Enter);
            // 
            // dgvCustomers
            // 
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
            this.dgvCustomers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvCustomers.Location = new System.Drawing.Point(7, 24);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowTemplate.Height = 30;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(679, 459);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellContentClick);
            // 
            // colCustID
            // 
            this.colCustID.FillWeight = 90F;
            this.colCustID.HeaderText = "Customer ID";
            this.colCustID.Name = "colCustID";
            this.colCustID.ReadOnly = true;
            // 
            // colCustName
            // 
            this.colCustName.FillWeight = 140F;
            this.colCustName.HeaderText = "Owner Name";
            this.colCustName.Name = "colCustName";
            this.colCustName.ReadOnly = true;
            // 
            // colContact
            // 
            this.colContact.FillWeight = 120F;
            this.colContact.HeaderText = "Contact Number";
            this.colContact.Name = "colContact";
            this.colContact.ReadOnly = true;
            // 
            // colVehicle
            // 
            this.colVehicle.FillWeight = 140F;
            this.colVehicle.HeaderText = "Vehicle Model";
            this.colVehicle.Name = "colVehicle";
            this.colVehicle.ReadOnly = true;
            // 
            // colPlateNumber
            // 
            this.colPlateNumber.HeaderText = "Plate #";
            this.colPlateNumber.Name = "colPlateNumber";
            this.colPlateNumber.ReadOnly = true;
            // 
            // RecordsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.grpCustomerDatabase);
            this.Controls.Add(this.pnlTopToolbar);
            this.Name = "RecordsControl";
            this.Size = new System.Drawing.Size(723, 568);
            this.Load += new System.EventHandler(this.RecordsControl_Load);
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
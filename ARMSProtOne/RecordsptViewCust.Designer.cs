namespace ARMSProtOne
{
    partial class RecordsptViewCust
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnlViewHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblProfileHeader = new System.Windows.Forms.Label();
            this.splProfileBodyContainer = new System.Windows.Forms.SplitContainer();
            this.grpFieldsCard = new System.Windows.Forms.GroupBox();
            this.btnRegisterNewCar = new System.Windows.Forms.Button();
            this.lblRegisteredCars = new System.Windows.Forms.Label();
            this.dgvRegisteredCars = new System.Windows.Forms.DataGridView();
            this.colCarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarPlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditToggle = new System.Windows.Forms.Button();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.tbcHistoryTabs = new System.Windows.Forms.TabControl();
            this.tbpVehicleHistory = new System.Windows.Forms.TabPage();
            this.dgvVehicleServiceHistory = new System.Windows.Forms.DataGridView();
            this.colVehDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehJO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVehicleHistoryHeader = new System.Windows.Forms.Label();
            this.tbpCustomerHistory = new System.Windows.Forms.TabPage();
            this.dgvCustomerHistory = new System.Windows.Forms.DataGridView();
            this.colCustDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustJO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCustomerHistoryHeader = new System.Windows.Forms.Label();
            this.pnlViewHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splProfileBodyContainer)).BeginInit();
            this.splProfileBodyContainer.Panel1.SuspendLayout();
            this.splProfileBodyContainer.Panel2.SuspendLayout();
            this.splProfileBodyContainer.SuspendLayout();
            this.grpFieldsCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisteredCars)).BeginInit();
            this.tbcHistoryTabs.SuspendLayout();
            this.tbpVehicleHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleServiceHistory)).BeginInit();
            this.tbpCustomerHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewHeader
            // 
            this.pnlViewHeader.BackColor = System.Drawing.Color.White;
            this.pnlViewHeader.Controls.Add(this.btnBack);
            this.pnlViewHeader.Controls.Add(this.lblProfileHeader);
            this.pnlViewHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlViewHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlViewHeader.Name = "pnlViewHeader";
            this.pnlViewHeader.Size = new System.Drawing.Size(844, 60);
            this.pnlViewHeader.TabIndex = 0;
            this.pnlViewHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlViewHeader_Paint);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 32);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblProfileHeader
            // 
            this.lblProfileHeader.AutoSize = true;
            this.lblProfileHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblProfileHeader.Location = new System.Drawing.Point(110, 18);
            this.lblProfileHeader.Name = "lblProfileHeader";
            this.lblProfileHeader.Size = new System.Drawing.Size(250, 21);
            this.lblProfileHeader.TabIndex = 1;
            this.lblProfileHeader.Text = "Customer Ledger Record Center";
            // 
            // splProfileBodyContainer
            // 
            this.splProfileBodyContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splProfileBodyContainer.Location = new System.Drawing.Point(0, 60);
            this.splProfileBodyContainer.Name = "splProfileBodyContainer";
            // 
            // splProfileBodyContainer.Panel1
            // 
            this.splProfileBodyContainer.Panel1.Controls.Add(this.grpFieldsCard);
            this.splProfileBodyContainer.Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.splProfileBodyContainer.Panel1MinSize = 260;
            // 
            // splProfileBodyContainer.Panel2
            // 
            this.splProfileBodyContainer.Panel2.Controls.Add(this.tbcHistoryTabs);
            this.splProfileBodyContainer.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splProfileBodyContainer.Panel2MinSize = 260;
            this.splProfileBodyContainer.Size = new System.Drawing.Size(844, 595);
            this.splProfileBodyContainer.SplitterDistance = 360;
            this.splProfileBodyContainer.TabIndex = 1;
            // 
            // grpFieldsCard
            // 
            this.grpFieldsCard.Controls.Add(this.btnRegisterNewCar);
            this.grpFieldsCard.Controls.Add(this.lblRegisteredCars);
            this.grpFieldsCard.Controls.Add(this.dgvRegisteredCars);
            this.grpFieldsCard.Controls.Add(this.btnEditToggle);
            this.grpFieldsCard.Controls.Add(this.txtContactNumber);
            this.grpFieldsCard.Controls.Add(this.lblContactNumber);
            this.grpFieldsCard.Controls.Add(this.txtCustomerName);
            this.grpFieldsCard.Controls.Add(this.lblCustomerName);
            this.grpFieldsCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFieldsCard.Location = new System.Drawing.Point(10, 10);
            this.grpFieldsCard.Name = "grpFieldsCard";
            this.grpFieldsCard.Padding = new System.Windows.Forms.Padding(12);
            this.grpFieldsCard.Size = new System.Drawing.Size(340, 575);
            this.grpFieldsCard.TabIndex = 0;
            this.grpFieldsCard.TabStop = false;
            this.grpFieldsCard.Text = "Client Profile & Assets";
            // 
            // btnRegisterNewCar
            // 
            this.btnRegisterNewCar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterNewCar.Location = new System.Drawing.Point(19, 455);
            this.btnRegisterNewCar.Name = "btnRegisterNewCar";
            this.btnRegisterNewCar.Size = new System.Drawing.Size(308, 34);
            this.btnRegisterNewCar.TabIndex = 7;
            this.btnRegisterNewCar.Text = "➕ Link New Car Asset";
            this.btnRegisterNewCar.UseVisualStyleBackColor = true;
            this.btnRegisterNewCar.Click += new System.EventHandler(this.btnRegisterNewCar_Click);
            // 
            // lblRegisteredCars
            // 
            this.lblRegisteredCars.AutoSize = true;
            this.lblRegisteredCars.Location = new System.Drawing.Point(16, 180);
            this.lblRegisteredCars.Name = "lblRegisteredCars";
            this.lblRegisteredCars.Size = new System.Drawing.Size(170, 13);
            this.lblRegisteredCars.TabIndex = 5;
            this.lblRegisteredCars.Text = "Registered Vehicle Fleet Tracking:";
            // 
            // dgvRegisteredCars
            // 
            this.dgvRegisteredCars.AllowUserToAddRows = false;
            this.dgvRegisteredCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegisteredCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegisteredCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCarModel,
            this.colCarPlate});
            this.dgvRegisteredCars.Location = new System.Drawing.Point(19, 205);
            this.dgvRegisteredCars.Name = "dgvRegisteredCars";
            this.dgvRegisteredCars.RowHeadersVisible = false;
            this.dgvRegisteredCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegisteredCars.Size = new System.Drawing.Size(308, 240);
            this.dgvRegisteredCars.TabIndex = 6;
            // 
            // colCarModel
            // 
            this.colCarModel.HeaderText = "Model Type";
            this.colCarModel.Name = "colCarModel";
            // 
            // colCarPlate
            // 
            this.colCarPlate.HeaderText = "Plate Number";
            this.colCarPlate.Name = "colCarPlate";
            // 
            // btnEditToggle
            // 
            this.btnEditToggle.Location = new System.Drawing.Point(19, 135);
            this.btnEditToggle.Name = "btnEditToggle";
            this.btnEditToggle.Size = new System.Drawing.Size(140, 30);
            this.btnEditToggle.TabIndex = 4;
            this.btnEditToggle.Text = "✏️ Edit Profile Info";
            this.btnEditToggle.UseVisualStyleBackColor = true;
            this.btnEditToggle.Click += new System.EventHandler(this.btnEditToggle_Click);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContactNumber.Location = new System.Drawing.Point(19, 100);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(308, 20);
            this.txtContactNumber.TabIndex = 3;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(16, 80);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(81, 13);
            this.lblContactNumber.TabIndex = 2;
            this.lblContactNumber.Text = "Contact Mobile:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerName.Location = new System.Drawing.Point(19, 46);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(308, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(16, 24);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(72, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Owner Name:";
            // 
            // tbcHistoryTabs
            // 
            this.tbcHistoryTabs.Controls.Add(this.tbpVehicleHistory);
            this.tbcHistoryTabs.Controls.Add(this.tbpCustomerHistory);
            this.tbcHistoryTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcHistoryTabs.Location = new System.Drawing.Point(10, 10);
            this.tbcHistoryTabs.Name = "tbcHistoryTabs";
            this.tbcHistoryTabs.SelectedIndex = 0;
            this.tbcHistoryTabs.Size = new System.Drawing.Size(460, 575);
            this.tbcHistoryTabs.TabIndex = 0;
            // 
            // tbpVehicleHistory
            // 
            this.tbpVehicleHistory.Controls.Add(this.dgvVehicleServiceHistory);
            this.tbpVehicleHistory.Controls.Add(this.lblVehicleHistoryHeader);
            this.tbpVehicleHistory.Location = new System.Drawing.Point(4, 22);
            this.tbpVehicleHistory.Name = "tbpVehicleHistory";
            this.tbpVehicleHistory.Padding = new System.Windows.Forms.Padding(6);
            this.tbpVehicleHistory.Size = new System.Drawing.Size(452, 549);
            this.tbpVehicleHistory.TabIndex = 0;
            this.tbpVehicleHistory.Text = "🚗 Active Car Maintenance Logs";
            this.tbpVehicleHistory.UseVisualStyleBackColor = true;
            // 
            // dgvVehicleServiceHistory
            // 
            this.dgvVehicleServiceHistory.AllowUserToAddRows = false;
            this.dgvVehicleServiceHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicleServiceHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVehDate,
            this.colVehJO,
            this.colVehDesc,
            this.colVehCost});
            this.dgvVehicleServiceHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVehicleServiceHistory.Location = new System.Drawing.Point(6, 36);
            this.dgvVehicleServiceHistory.Name = "dgvVehicleServiceHistory";
            this.dgvVehicleServiceHistory.RowHeadersVisible = false;
            this.dgvVehicleServiceHistory.Size = new System.Drawing.Size(440, 507);
            this.dgvVehicleServiceHistory.TabIndex = 1;
            // 
            // colVehDate
            // 
            this.colVehDate.HeaderText = "Repair Date";
            this.colVehDate.Name = "colVehDate";
            // 
            // colVehJO
            // 
            this.colVehJO.HeaderText = "Job Order ID";
            this.colVehJO.Name = "colVehJO";
            // 
            // colVehDesc
            // 
            this.colVehDesc.HeaderText = "Service Operational Applied";
            this.colVehDesc.Name = "colVehDesc";
            // 
            // colVehCost
            // 
            this.colVehCost.HeaderText = "Cost";
            this.colVehCost.Name = "colVehCost";
            // 
            // lblVehicleHistoryHeader
            // 
            this.lblVehicleHistoryHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVehicleHistoryHeader.Location = new System.Drawing.Point(6, 6);
            this.lblVehicleHistoryHeader.Name = "lblVehicleHistoryHeader";
            this.lblVehicleHistoryHeader.Size = new System.Drawing.Size(440, 30);
            this.lblVehicleHistoryHeader.TabIndex = 0;
            this.lblVehicleHistoryHeader.Text = "Service Logs Specific to Asset:";
            // 
            // tbpCustomerHistory
            // 
            this.tbpCustomerHistory.Controls.Add(this.dgvCustomerHistory);
            this.tbpCustomerHistory.Controls.Add(this.lblCustomerHistoryHeader);
            this.tbpCustomerHistory.Location = new System.Drawing.Point(4, 22);
            this.tbpCustomerHistory.Name = "tbpCustomerHistory";
            this.tbpCustomerHistory.Padding = new System.Windows.Forms.Padding(6);
            this.tbpCustomerHistory.Size = new System.Drawing.Size(456, 549);
            this.tbpCustomerHistory.TabIndex = 1;
            this.tbpCustomerHistory.Text = "🧾 Master Customer Invoices";
            this.tbpCustomerHistory.UseVisualStyleBackColor = true;
            // 
            // dgvCustomerHistory
            // 
            this.dgvCustomerHistory.AllowUserToAddRows = false;
            this.dgvCustomerHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustDate,
            this.colCustJO,
            this.colCustDesc,
            this.colCustCost,
            this.colCustStatus});
            this.dgvCustomerHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerHistory.Location = new System.Drawing.Point(6, 36);
            this.dgvCustomerHistory.Name = "dgvCustomerHistory";
            this.dgvCustomerHistory.RowHeadersVisible = false;
            this.dgvCustomerHistory.Size = new System.Drawing.Size(444, 507);
            this.dgvCustomerHistory.TabIndex = 1;
            // 
            // colCustDate
            // 
            this.colCustDate.HeaderText = "Date";
            this.colCustDate.Name = "colCustDate";
            // 
            // colCustJO
            // 
            this.colCustJO.HeaderText = "JO ID";
            this.colCustJO.Name = "colCustJO";
            // 
            // colCustDesc
            // 
            this.colCustDesc.HeaderText = "Invoice Summary Work Log";
            this.colCustDesc.Name = "colCustDesc";
            // 
            // colCustCost
            // 
            this.colCustCost.HeaderText = "Total Bill";
            this.colCustCost.Name = "colCustCost";
            // 
            // colCustStatus
            // 
            this.colCustStatus.HeaderText = "Status";
            this.colCustStatus.Name = "colCustStatus";
            // 
            // lblCustomerHistoryHeader
            // 
            this.lblCustomerHistoryHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCustomerHistoryHeader.Location = new System.Drawing.Point(6, 6);
            this.lblCustomerHistoryHeader.Name = "lblCustomerHistoryHeader";
            this.lblCustomerHistoryHeader.Size = new System.Drawing.Size(444, 30);
            this.lblCustomerHistoryHeader.TabIndex = 0;
            this.lblCustomerHistoryHeader.Text = "All Invoice Records Across Registered Fleet Assets:";
            // 
            // RecordsptViewCust
            // 
            this.Controls.Add(this.splProfileBodyContainer);
            this.Controls.Add(this.pnlViewHeader);
            this.Name = "RecordsptViewCust";
            this.Size = new System.Drawing.Size(844, 655);
            this.pnlViewHeader.ResumeLayout(false);
            this.pnlViewHeader.PerformLayout();
            this.splProfileBodyContainer.Panel1.ResumeLayout(false);
            this.splProfileBodyContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splProfileBodyContainer)).EndInit();
            this.splProfileBodyContainer.ResumeLayout(false);
            this.grpFieldsCard.ResumeLayout(false);
            this.grpFieldsCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisteredCars)).EndInit();
            this.tbcHistoryTabs.ResumeLayout(false);
            this.tbpVehicleHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleServiceHistory)).EndInit();
            this.tbpCustomerHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlViewHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblProfileHeader;
        private System.Windows.Forms.SplitContainer splProfileBodyContainer;
        private System.Windows.Forms.GroupBox grpFieldsCard;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Button btnEditToggle;
        private System.Windows.Forms.Label lblRegisteredCars;
        private System.Windows.Forms.DataGridView dgvRegisteredCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarPlate;
        private System.Windows.Forms.Button btnRegisterNewCar;
        private System.Windows.Forms.TabControl tbcHistoryTabs;
        private System.Windows.Forms.TabPage tbpVehicleHistory;
        private System.Windows.Forms.DataGridView dgvVehicleServiceHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehJO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehCost;
        private System.Windows.Forms.Label lblVehicleHistoryHeader;
        private System.Windows.Forms.TabPage tbpCustomerHistory;
        private System.Windows.Forms.DataGridView dgvCustomerHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustJO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustStatus;
        private System.Windows.Forms.Label lblCustomerHistoryHeader;
    }
}

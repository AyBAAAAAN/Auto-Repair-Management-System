namespace ARMSProtOne
{
    partial class ReportControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.lblReportType = new System.Windows.Forms.Label();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.lblDatePeriod = new System.Windows.Forms.Label();
            this.dtpReportDate = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.pnlSalesReport = new System.Windows.Forms.Panel();
            this.lblSalesTotal = new System.Windows.Forms.Label();
            this.dgvSalesReport = new System.Windows.Forms.DataGridView();
            this.colSRDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSRCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSRVehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSRService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSRAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSalesHeader = new System.Windows.Forms.Label();
            this.pnlDPSReport = new System.Windows.Forms.Panel();
            this.lblDPSTotal = new System.Windows.Forms.Label();
            this.dgvDPSReport = new System.Windows.Forms.DataGridView();
            this.colDPSRDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDPSRItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDPSRQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDPSRPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDPSRTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDPSHeader = new System.Windows.Forms.Label();
            this.pnlJOReport = new System.Windows.Forms.Panel();
            this.lblJOSummary = new System.Windows.Forms.Label();
            this.dgvJOReport = new System.Windows.Forms.DataGridView();
            this.colJORNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJORCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJORService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJORBackJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJORStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJORDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblJOHeader = new System.Windows.Forms.Label();
            this.pnlToolbar.SuspendLayout();
            this.pnlSalesReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            this.pnlDPSReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDPSReport)).BeginInit();
            this.pnlJOReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJOReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToolbar.Controls.Add(this.lblReportType);
            this.pnlToolbar.Controls.Add(this.cmbReportType);
            this.pnlToolbar.Controls.Add(this.lblDatePeriod);
            this.pnlToolbar.Controls.Add(this.dtpReportDate);
            this.pnlToolbar.Controls.Add(this.btnGenerateReport);
            this.pnlToolbar.Controls.Add(this.btnExportReport);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(723, 52);
            this.pnlToolbar.TabIndex = 3;
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblReportType.Location = new System.Drawing.Point(13, 18);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(86, 17);
            this.lblReportType.TabIndex = 0;
            this.lblReportType.Text = "Report Type:";
            // 
            // cmbReportType
            // 
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.Location = new System.Drawing.Point(90, 16);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(189, 21);
            this.cmbReportType.TabIndex = 1;
            this.cmbReportType.SelectedIndexChanged += new System.EventHandler(this.cmbReportType_SelectedIndexChanged);
            // 
            // lblDatePeriod
            // 
            this.lblDatePeriod.AutoSize = true;
            this.lblDatePeriod.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDatePeriod.Location = new System.Drawing.Point(296, 18);
            this.lblDatePeriod.Name = "lblDatePeriod";
            this.lblDatePeriod.Size = new System.Drawing.Size(87, 17);
            this.lblDatePeriod.TabIndex = 2;
            this.lblDatePeriod.Text = "Date/Period:";
            // 
            // dtpReportDate
            // 
            this.dtpReportDate.Location = new System.Drawing.Point(373, 16);
            this.dtpReportDate.Name = "dtpReportDate";
            this.dtpReportDate.Size = new System.Drawing.Size(138, 20);
            this.dtpReportDate.TabIndex = 3;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(525, 10);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(103, 29);
            this.btnGenerateReport.TabIndex = 4;
            this.btnGenerateReport.Text = "Generate";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnExportReport
            // 
            this.btnExportReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnExportReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportReport.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnExportReport.ForeColor = System.Drawing.Color.White;
            this.btnExportReport.Location = new System.Drawing.Point(633, 10);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(77, 29);
            this.btnExportReport.TabIndex = 5;
            this.btnExportReport.Text = "Export";
            this.btnExportReport.UseVisualStyleBackColor = false;
            this.btnExportReport.Click += new System.EventHandler(this.btnExportReport_Click);
            // 
            // pnlSalesReport
            // 
            this.pnlSalesReport.Controls.Add(this.lblSalesTotal);
            this.pnlSalesReport.Controls.Add(this.dgvSalesReport);
            this.pnlSalesReport.Controls.Add(this.lblSalesHeader);
            this.pnlSalesReport.Location = new System.Drawing.Point(0, 52);
            this.pnlSalesReport.Name = "pnlSalesReport";
            this.pnlSalesReport.Size = new System.Drawing.Size(723, 516);
            this.pnlSalesReport.TabIndex = 2;
            // 
            // lblSalesTotal
            // 
            this.lblSalesTotal.AutoSize = true;
            this.lblSalesTotal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblSalesTotal.Location = new System.Drawing.Point(17, 472);
            this.lblSalesTotal.Name = "lblSalesTotal";
            this.lblSalesTotal.Size = new System.Drawing.Size(149, 19);
            this.lblSalesTotal.TabIndex = 0;
            this.lblSalesTotal.Text = "Total Sales: PHP 0.00";
            // 
            // dgvSalesReport
            // 
            this.dgvSalesReport.AllowUserToAddRows = false;
            this.dgvSalesReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSalesReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSRDate,
            this.colSRCustomer,
            this.colSRVehicle,
            this.colSRService,
            this.colSRAmount});
            this.dgvSalesReport.Location = new System.Drawing.Point(17, 43);
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.ReadOnly = true;
            this.dgvSalesReport.RowHeadersVisible = false;
            this.dgvSalesReport.Size = new System.Drawing.Size(689, 416);
            this.dgvSalesReport.TabIndex = 1;
            // 
            // colSRDate
            // 
            this.colSRDate.HeaderText = "Date";
            this.colSRDate.Name = "colSRDate";
            this.colSRDate.ReadOnly = true;
            // 
            // colSRCustomer
            // 
            this.colSRCustomer.HeaderText = "Customer Name";
            this.colSRCustomer.Name = "colSRCustomer";
            this.colSRCustomer.ReadOnly = true;
            // 
            // colSRVehicle
            // 
            this.colSRVehicle.HeaderText = "Vehicle";
            this.colSRVehicle.Name = "colSRVehicle";
            this.colSRVehicle.ReadOnly = true;
            // 
            // colSRService
            // 
            this.colSRService.HeaderText = "Service";
            this.colSRService.Name = "colSRService";
            this.colSRService.ReadOnly = true;
            // 
            // colSRAmount
            // 
            this.colSRAmount.HeaderText = "Amount";
            this.colSRAmount.Name = "colSRAmount";
            this.colSRAmount.ReadOnly = true;
            // 
            // lblSalesHeader
            // 
            this.lblSalesHeader.AutoSize = true;
            this.lblSalesHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSalesHeader.Location = new System.Drawing.Point(17, 13);
            this.lblSalesHeader.Name = "lblSalesHeader";
            this.lblSalesHeader.Size = new System.Drawing.Size(96, 20);
            this.lblSalesHeader.TabIndex = 2;
            this.lblSalesHeader.Text = "Sales Report";
            // 
            // pnlDPSReport
            // 
            this.pnlDPSReport.Controls.Add(this.lblDPSTotal);
            this.pnlDPSReport.Controls.Add(this.dgvDPSReport);
            this.pnlDPSReport.Controls.Add(this.lblDPSHeader);
            this.pnlDPSReport.Location = new System.Drawing.Point(0, 52);
            this.pnlDPSReport.Name = "pnlDPSReport";
            this.pnlDPSReport.Size = new System.Drawing.Size(723, 516);
            this.pnlDPSReport.TabIndex = 1;
            this.pnlDPSReport.Visible = false;
            // 
            // lblDPSTotal
            // 
            this.lblDPSTotal.AutoSize = true;
            this.lblDPSTotal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblDPSTotal.Location = new System.Drawing.Point(17, 472);
            this.lblDPSTotal.Name = "lblDPSTotal";
            this.lblDPSTotal.Size = new System.Drawing.Size(149, 19);
            this.lblDPSTotal.TabIndex = 0;
            this.lblDPSTotal.Text = "Total Sales: PHP 0.00";
            // 
            // dgvDPSReport
            // 
            this.dgvDPSReport.AllowUserToAddRows = false;
            this.dgvDPSReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDPSReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDPSReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvDPSReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDPSReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDPSRDate,
            this.colDPSRItem,
            this.colDPSRQty,
            this.colDPSRPrice,
            this.colDPSRTotal});
            this.dgvDPSReport.Location = new System.Drawing.Point(17, 43);
            this.dgvDPSReport.Name = "dgvDPSReport";
            this.dgvDPSReport.ReadOnly = true;
            this.dgvDPSReport.RowHeadersVisible = false;
            this.dgvDPSReport.Size = new System.Drawing.Size(689, 416);
            this.dgvDPSReport.TabIndex = 1;
            // 
            // colDPSRDate
            // 
            this.colDPSRDate.HeaderText = "Date";
            this.colDPSRDate.Name = "colDPSRDate";
            this.colDPSRDate.ReadOnly = true;
            // 
            // colDPSRItem
            // 
            this.colDPSRItem.HeaderText = "Item Name";
            this.colDPSRItem.Name = "colDPSRItem";
            this.colDPSRItem.ReadOnly = true;
            // 
            // colDPSRQty
            // 
            this.colDPSRQty.HeaderText = "Qty";
            this.colDPSRQty.Name = "colDPSRQty";
            this.colDPSRQty.ReadOnly = true;
            // 
            // colDPSRPrice
            // 
            this.colDPSRPrice.HeaderText = "Price";
            this.colDPSRPrice.Name = "colDPSRPrice";
            this.colDPSRPrice.ReadOnly = true;
            // 
            // colDPSRTotal
            // 
            this.colDPSRTotal.HeaderText = "Total";
            this.colDPSRTotal.Name = "colDPSRTotal";
            this.colDPSRTotal.ReadOnly = true;
            // 
            // lblDPSHeader
            // 
            this.lblDPSHeader.AutoSize = true;
            this.lblDPSHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDPSHeader.Location = new System.Drawing.Point(17, 13);
            this.lblDPSHeader.Name = "lblDPSHeader";
            this.lblDPSHeader.Size = new System.Drawing.Size(175, 20);
            this.lblDPSHeader.TabIndex = 2;
            this.lblDPSHeader.Text = "Direct Part Sales Report";
            // 
            // pnlJOReport
            // 
            this.pnlJOReport.Controls.Add(this.lblJOSummary);
            this.pnlJOReport.Controls.Add(this.dgvJOReport);
            this.pnlJOReport.Controls.Add(this.lblJOHeader);
            this.pnlJOReport.Location = new System.Drawing.Point(0, 52);
            this.pnlJOReport.Name = "pnlJOReport";
            this.pnlJOReport.Size = new System.Drawing.Size(723, 516);
            this.pnlJOReport.TabIndex = 0;
            this.pnlJOReport.Visible = false;
            this.pnlJOReport.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlJOReport_Paint);
            // 
            // lblJOSummary
            // 
            this.lblJOSummary.AutoSize = true;
            this.lblJOSummary.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblJOSummary.Location = new System.Drawing.Point(17, 455);
            this.lblJOSummary.Name = "lblJOSummary";
            this.lblJOSummary.Size = new System.Drawing.Size(324, 17);
            this.lblJOSummary.TabIndex = 0;
            this.lblJOSummary.Text = "Total Job Orders: 0   Complete Jobs: 0   Back Job: 0";
            // 
            // dgvJOReport
            // 
            this.dgvJOReport.AllowUserToAddRows = false;
            this.dgvJOReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJOReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJOReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvJOReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJOReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colJORNumber,
            this.colJORCustomer,
            this.colJORService,
            this.colJORBackJob,
            this.colJORStatus,
            this.colJORDate});
            this.dgvJOReport.Location = new System.Drawing.Point(17, 43);
            this.dgvJOReport.Name = "dgvJOReport";
            this.dgvJOReport.ReadOnly = true;
            this.dgvJOReport.RowHeadersVisible = false;
            this.dgvJOReport.Size = new System.Drawing.Size(689, 399);
            this.dgvJOReport.TabIndex = 1;
            // 
            // colJORNumber
            // 
            this.colJORNumber.HeaderText = "Job Order";
            this.colJORNumber.Name = "colJORNumber";
            this.colJORNumber.ReadOnly = true;
            // 
            // colJORCustomer
            // 
            this.colJORCustomer.HeaderText = "Customer";
            this.colJORCustomer.Name = "colJORCustomer";
            this.colJORCustomer.ReadOnly = true;
            // 
            // colJORService
            // 
            this.colJORService.HeaderText = "Service";
            this.colJORService.Name = "colJORService";
            this.colJORService.ReadOnly = true;
            // 
            // colJORBackJob
            // 
            this.colJORBackJob.HeaderText = "Back Job";
            this.colJORBackJob.Name = "colJORBackJob";
            this.colJORBackJob.ReadOnly = true;
            // 
            // colJORStatus
            // 
            this.colJORStatus.HeaderText = "Status";
            this.colJORStatus.Name = "colJORStatus";
            this.colJORStatus.ReadOnly = true;
            // 
            // colJORDate
            // 
            this.colJORDate.HeaderText = "Date";
            this.colJORDate.Name = "colJORDate";
            this.colJORDate.ReadOnly = true;
            // 
            // lblJOHeader
            // 
            this.lblJOHeader.AutoSize = true;
            this.lblJOHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblJOHeader.Location = new System.Drawing.Point(17, 13);
            this.lblJOHeader.Name = "lblJOHeader";
            this.lblJOHeader.Size = new System.Drawing.Size(137, 20);
            this.lblJOHeader.TabIndex = 2;
            this.lblJOHeader.Text = "Job Order Reports";
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlJOReport);
            this.Controls.Add(this.pnlDPSReport);
            this.Controls.Add(this.pnlSalesReport);
            this.Controls.Add(this.pnlToolbar);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(723, 568);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.pnlSalesReport.ResumeLayout(false);
            this.pnlSalesReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).EndInit();
            this.pnlDPSReport.ResumeLayout(false);
            this.pnlDPSReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDPSReport)).EndInit();
            this.pnlJOReport.ResumeLayout(false);
            this.pnlJOReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJOReport)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Label lblDatePeriod;
        private System.Windows.Forms.DateTimePicker dtpReportDate;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnExportReport;

        private System.Windows.Forms.Panel pnlSalesReport;
        private System.Windows.Forms.Label lblSalesHeader;
        private System.Windows.Forms.DataGridView dgvSalesReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSRDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSRCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSRVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSRService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSRAmount;
        private System.Windows.Forms.Label lblSalesTotal;

        private System.Windows.Forms.Panel pnlDPSReport;
        private System.Windows.Forms.Label lblDPSHeader;
        private System.Windows.Forms.DataGridView dgvDPSReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDPSRDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDPSRItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDPSRQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDPSRPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDPSRTotal;
        private System.Windows.Forms.Label lblDPSTotal;

        private System.Windows.Forms.Panel pnlJOReport;
        private System.Windows.Forms.Label lblJOHeader;
        private System.Windows.Forms.DataGridView dgvJOReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJORNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJORCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJORService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJORBackJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJORStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJORDate;
        private System.Windows.Forms.Label lblJOSummary;
    }
}
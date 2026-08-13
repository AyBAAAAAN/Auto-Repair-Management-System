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
            this.lblSalesHeader = new System.Windows.Forms.Label();
            this.dgvSalesReport = new System.Windows.Forms.DataGridView();
            this.colSRDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSRCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSRVehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSRService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSRAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSalesTotal = new System.Windows.Forms.Label();

            this.pnlDPSReport = new System.Windows.Forms.Panel();
            this.lblDPSHeader = new System.Windows.Forms.Label();
            this.dgvDPSReport = new System.Windows.Forms.DataGridView();
            this.colDPSRDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDPSRItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDPSRQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDPSRPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDPSRTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDPSTotal = new System.Windows.Forms.Label();

            this.pnlJOReport = new System.Windows.Forms.Panel();
            this.lblJOHeader = new System.Windows.Forms.Label();
            this.dgvJOReport = new System.Windows.Forms.DataGridView();
            this.colJORNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJORCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJORService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJORBackJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJORStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJORDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblJOSummary = new System.Windows.Forms.Label();

            this.pnlToolbar.SuspendLayout();
            this.pnlSalesReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            this.pnlDPSReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDPSReport)).BeginInit();
            this.pnlJOReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJOReport)).BeginInit();
            this.SuspendLayout();

            // ===== SHARED TOOLBAR =====
            this.lblReportType.AutoSize = true;
            this.lblReportType.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblReportType.Location = new System.Drawing.Point(15, 21);
            this.lblReportType.Text = "Report Type:";
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.Location = new System.Drawing.Point(105, 18);
            this.cmbReportType.Size = new System.Drawing.Size(220, 24);
            this.cmbReportType.SelectedIndexChanged += new System.EventHandler(this.cmbReportType_SelectedIndexChanged);

            this.lblDatePeriod.AutoSize = true;
            this.lblDatePeriod.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDatePeriod.Location = new System.Drawing.Point(345, 21);
            this.lblDatePeriod.Text = "Date/Period:";
            this.dtpReportDate.Location = new System.Drawing.Point(435, 18);
            this.dtpReportDate.Size = new System.Drawing.Size(160, 24);

            this.btnGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(614, 12);
            this.btnGenerateReport.Size = new System.Drawing.Size(120, 34);
            this.btnGenerateReport.Text = "Generate";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);

            this.btnExportReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportReport.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnExportReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportReport.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnExportReport.ForeColor = System.Drawing.Color.White;
            this.btnExportReport.Location = new System.Drawing.Point(740, 12);
            this.btnExportReport.Size = new System.Drawing.Size(90, 34);
            this.btnExportReport.Text = "Export";
            this.btnExportReport.UseVisualStyleBackColor = false;
            this.btnExportReport.Click += new System.EventHandler(this.btnExportReport_Click);

            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Size = new System.Drawing.Size(844, 60);
            this.pnlToolbar.Controls.Add(this.lblReportType);
            this.pnlToolbar.Controls.Add(this.cmbReportType);
            this.pnlToolbar.Controls.Add(this.lblDatePeriod);
            this.pnlToolbar.Controls.Add(this.dtpReportDate);
            this.pnlToolbar.Controls.Add(this.btnGenerateReport);
            this.pnlToolbar.Controls.Add(this.btnExportReport);

            // ===== SALES REPORT PANEL =====
            this.lblSalesHeader.AutoSize = true;
            this.lblSalesHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSalesHeader.Location = new System.Drawing.Point(20, 15);
            this.lblSalesHeader.Text = "Sales Report";

            this.dgvSalesReport.AllowUserToAddRows = false;
            this.dgvSalesReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSalesReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSRDate, this.colSRCustomer, this.colSRVehicle, this.colSRService, this.colSRAmount});
            this.dgvSalesReport.Location = new System.Drawing.Point(20, 50);
            this.dgvSalesReport.ReadOnly = true;
            this.dgvSalesReport.RowHeadersVisible = false;
            this.dgvSalesReport.Size = new System.Drawing.Size(804, 480);

            this.colSRDate.HeaderText = "Date"; this.colSRDate.Name = "colSRDate";
            this.colSRCustomer.HeaderText = "Customer Name"; this.colSRCustomer.Name = "colSRCustomer";
            this.colSRVehicle.HeaderText = "Vehicle"; this.colSRVehicle.Name = "colSRVehicle";
            this.colSRService.HeaderText = "Service"; this.colSRService.Name = "colSRService";
            this.colSRAmount.HeaderText = "Amount"; this.colSRAmount.Name = "colSRAmount";

            this.lblSalesTotal.AutoSize = true;
            this.lblSalesTotal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblSalesTotal.Location = new System.Drawing.Point(20, 545);
            this.lblSalesTotal.Text = "Total Sales: PHP 0.00";

            this.pnlSalesReport.Location = new System.Drawing.Point(0, 60);
            this.pnlSalesReport.Size = new System.Drawing.Size(844, 595);
            this.pnlSalesReport.Controls.Add(this.lblSalesTotal);
            this.pnlSalesReport.Controls.Add(this.dgvSalesReport);
            this.pnlSalesReport.Controls.Add(this.lblSalesHeader);

            // ===== DIRECT PART SALES REPORT PANEL =====
            this.lblDPSHeader.AutoSize = true;
            this.lblDPSHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDPSHeader.Location = new System.Drawing.Point(20, 15);
            this.lblDPSHeader.Text = "Direct Part Sales Report";

            this.dgvDPSReport.AllowUserToAddRows = false;
            this.dgvDPSReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDPSReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDPSReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvDPSReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDPSReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDPSRDate, this.colDPSRItem, this.colDPSRQty, this.colDPSRPrice, this.colDPSRTotal});
            this.dgvDPSReport.Location = new System.Drawing.Point(20, 50);
            this.dgvDPSReport.ReadOnly = true;
            this.dgvDPSReport.RowHeadersVisible = false;
            this.dgvDPSReport.Size = new System.Drawing.Size(804, 480);

            this.colDPSRDate.HeaderText = "Date"; this.colDPSRDate.Name = "colDPSRDate";
            this.colDPSRItem.HeaderText = "Item Name"; this.colDPSRItem.Name = "colDPSRItem";
            this.colDPSRQty.HeaderText = "Qty"; this.colDPSRQty.Name = "colDPSRQty";
            this.colDPSRPrice.HeaderText = "Price"; this.colDPSRPrice.Name = "colDPSRPrice";
            this.colDPSRTotal.HeaderText = "Total"; this.colDPSRTotal.Name = "colDPSRTotal";

            this.lblDPSTotal.AutoSize = true;
            this.lblDPSTotal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblDPSTotal.Location = new System.Drawing.Point(20, 545);
            this.lblDPSTotal.Text = "Total Sales: PHP 0.00";

            this.pnlDPSReport.Location = new System.Drawing.Point(0, 60);
            this.pnlDPSReport.Size = new System.Drawing.Size(844, 595);
            this.pnlDPSReport.Visible = false;
            this.pnlDPSReport.Controls.Add(this.lblDPSTotal);
            this.pnlDPSReport.Controls.Add(this.dgvDPSReport);
            this.pnlDPSReport.Controls.Add(this.lblDPSHeader);

            // ===== JOB ORDER REPORT PANEL =====
            this.lblJOHeader.AutoSize = true;
            this.lblJOHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblJOHeader.Location = new System.Drawing.Point(20, 15);
            this.lblJOHeader.Text = "Job Order Reports";

            this.dgvJOReport.AllowUserToAddRows = false;
            this.dgvJOReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJOReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJOReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvJOReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJOReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colJORNumber, this.colJORCustomer, this.colJORService, this.colJORBackJob, this.colJORStatus, this.colJORDate});
            this.dgvJOReport.Location = new System.Drawing.Point(20, 50);
            this.dgvJOReport.ReadOnly = true;
            this.dgvJOReport.RowHeadersVisible = false;
            this.dgvJOReport.Size = new System.Drawing.Size(804, 460);

            this.colJORNumber.HeaderText = "Job Order"; this.colJORNumber.Name = "colJORNumber";
            this.colJORCustomer.HeaderText = "Customer"; this.colJORCustomer.Name = "colJORCustomer";
            this.colJORService.HeaderText = "Service"; this.colJORService.Name = "colJORService";
            this.colJORBackJob.HeaderText = "Back Job"; this.colJORBackJob.Name = "colJORBackJob";
            this.colJORStatus.HeaderText = "Status"; this.colJORStatus.Name = "colJORStatus";
            this.colJORDate.HeaderText = "Date"; this.colJORDate.Name = "colJORDate";

            this.lblJOSummary.AutoSize = true;
            this.lblJOSummary.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblJOSummary.Location = new System.Drawing.Point(20, 525);
            this.lblJOSummary.Text = "Total Job Orders: 0   Complete Jobs: 0   Back Job: 0";

            this.pnlJOReport.Location = new System.Drawing.Point(0, 60);
            this.pnlJOReport.Size = new System.Drawing.Size(844, 595);
            this.pnlJOReport.Visible = false;
            this.pnlJOReport.Controls.Add(this.lblJOSummary);
            this.pnlJOReport.Controls.Add(this.dgvJOReport);
            this.pnlJOReport.Controls.Add(this.lblJOHeader);

            // ===== ROOT =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlJOReport);
            this.Controls.Add(this.pnlDPSReport);
            this.Controls.Add(this.pnlSalesReport);
            this.Controls.Add(this.pnlToolbar);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(844, 655);
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
namespace ARMSProtOne
{
    partial class DashboardControl
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
            this.pnlCardActiveRepairs = new System.Windows.Forms.Panel();
            this.lblActiveRepairsValue = new System.Windows.Forms.Label();
            this.lblActiveRepairsTitle = new System.Windows.Forms.Label();
            this.pnlCardScheduledToday = new System.Windows.Forms.Panel();
            this.lblScheduledTodayValue = new System.Windows.Forms.Label();
            this.lblScheduledTodayTitle = new System.Windows.Forms.Label();
            this.pnlCardTodaysSales = new System.Windows.Forms.Panel();
            this.lblTodaysSalesValue = new System.Windows.Forms.Label();
            this.lblTodaysSalesTitle = new System.Windows.Forms.Label();
            this.pnlCardPendingPayments = new System.Windows.Forms.Panel();
            this.lblPendingPaymentsValue = new System.Windows.Forms.Label();
            this.lblPendingPaymentsTitle = new System.Windows.Forms.Label();
            this.grpRecentJobOrders = new System.Windows.Forms.GroupBox();
            this.dgvRecentJobOrders = new System.Windows.Forms.DataGridView();
            this.colJO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpLowStockAlerts = new System.Windows.Forms.GroupBox();
            this.lstLowStockAlerts = new System.Windows.Forms.ListBox();
            this.pnlCardActiveRepairs.SuspendLayout();
            this.pnlCardScheduledToday.SuspendLayout();
            this.pnlCardTodaysSales.SuspendLayout();
            this.pnlCardPendingPayments.SuspendLayout();
            this.grpRecentJobOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentJobOrders)).BeginInit();
            this.grpLowStockAlerts.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCardActiveRepairs
            // 
            this.pnlCardActiveRepairs.BackColor = System.Drawing.Color.White;
            this.pnlCardActiveRepairs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardActiveRepairs.Controls.Add(this.lblActiveRepairsValue);
            this.pnlCardActiveRepairs.Controls.Add(this.lblActiveRepairsTitle);
            this.pnlCardActiveRepairs.Location = new System.Drawing.Point(17, 17);
            this.pnlCardActiveRepairs.Name = "pnlCardActiveRepairs";
            this.pnlCardActiveRepairs.Size = new System.Drawing.Size(163, 78);
            this.pnlCardActiveRepairs.TabIndex = 0;
            // 
            // lblActiveRepairsValue
            // 
            this.lblActiveRepairsValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblActiveRepairsValue.Location = new System.Drawing.Point(10, 30);
            this.lblActiveRepairsValue.Name = "lblActiveRepairsValue";
            this.lblActiveRepairsValue.Size = new System.Drawing.Size(137, 35);
            this.lblActiveRepairsValue.TabIndex = 1;
            this.lblActiveRepairsValue.Text = "05";
            // 
            // lblActiveRepairsTitle
            // 
            this.lblActiveRepairsTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblActiveRepairsTitle.Location = new System.Drawing.Point(10, 10);
            this.lblActiveRepairsTitle.Name = "lblActiveRepairsTitle";
            this.lblActiveRepairsTitle.Size = new System.Drawing.Size(142, 17);
            this.lblActiveRepairsTitle.TabIndex = 0;
            this.lblActiveRepairsTitle.Text = "Active Repairs";
            // 
            // pnlCardScheduledToday
            // 
            this.pnlCardScheduledToday.BackColor = System.Drawing.Color.White;
            this.pnlCardScheduledToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardScheduledToday.Controls.Add(this.lblScheduledTodayValue);
            this.pnlCardScheduledToday.Controls.Add(this.lblScheduledTodayTitle);
            this.pnlCardScheduledToday.Location = new System.Drawing.Point(190, 17);
            this.pnlCardScheduledToday.Name = "pnlCardScheduledToday";
            this.pnlCardScheduledToday.Size = new System.Drawing.Size(163, 78);
            this.pnlCardScheduledToday.TabIndex = 1;
            // 
            // lblScheduledTodayValue
            // 
            this.lblScheduledTodayValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblScheduledTodayValue.Location = new System.Drawing.Point(10, 30);
            this.lblScheduledTodayValue.Name = "lblScheduledTodayValue";
            this.lblScheduledTodayValue.Size = new System.Drawing.Size(137, 35);
            this.lblScheduledTodayValue.TabIndex = 1;
            this.lblScheduledTodayValue.Text = "02";
            // 
            // lblScheduledTodayTitle
            // 
            this.lblScheduledTodayTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblScheduledTodayTitle.Location = new System.Drawing.Point(10, 10);
            this.lblScheduledTodayTitle.Name = "lblScheduledTodayTitle";
            this.lblScheduledTodayTitle.Size = new System.Drawing.Size(142, 17);
            this.lblScheduledTodayTitle.TabIndex = 0;
            this.lblScheduledTodayTitle.Text = "Scheduled Today";
            // 
            // pnlCardTodaysSales
            // 
            this.pnlCardTodaysSales.BackColor = System.Drawing.Color.White;
            this.pnlCardTodaysSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardTodaysSales.Controls.Add(this.lblTodaysSalesValue);
            this.pnlCardTodaysSales.Controls.Add(this.lblTodaysSalesTitle);
            this.pnlCardTodaysSales.Location = new System.Drawing.Point(363, 17);
            this.pnlCardTodaysSales.Name = "pnlCardTodaysSales";
            this.pnlCardTodaysSales.Size = new System.Drawing.Size(163, 78);
            this.pnlCardTodaysSales.TabIndex = 2;
            // 
            // lblTodaysSalesValue
            // 
            this.lblTodaysSalesValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTodaysSalesValue.Location = new System.Drawing.Point(10, 35);
            this.lblTodaysSalesValue.Name = "lblTodaysSalesValue";
            this.lblTodaysSalesValue.Size = new System.Drawing.Size(142, 28);
            this.lblTodaysSalesValue.TabIndex = 1;
            this.lblTodaysSalesValue.Text = "PHP 8,200.00";
            // 
            // lblTodaysSalesTitle
            // 
            this.lblTodaysSalesTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTodaysSalesTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTodaysSalesTitle.Name = "lblTodaysSalesTitle";
            this.lblTodaysSalesTitle.Size = new System.Drawing.Size(142, 17);
            this.lblTodaysSalesTitle.TabIndex = 0;
            this.lblTodaysSalesTitle.Text = "Today\'s Sales";
            // 
            // pnlCardPendingPayments
            // 
            this.pnlCardPendingPayments.BackColor = System.Drawing.Color.White;
            this.pnlCardPendingPayments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardPendingPayments.Controls.Add(this.lblPendingPaymentsValue);
            this.pnlCardPendingPayments.Controls.Add(this.lblPendingPaymentsTitle);
            this.pnlCardPendingPayments.Location = new System.Drawing.Point(537, 17);
            this.pnlCardPendingPayments.Name = "pnlCardPendingPayments";
            this.pnlCardPendingPayments.Size = new System.Drawing.Size(163, 78);
            this.pnlCardPendingPayments.TabIndex = 3;
            // 
            // lblPendingPaymentsValue
            // 
            this.lblPendingPaymentsValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblPendingPaymentsValue.Location = new System.Drawing.Point(10, 30);
            this.lblPendingPaymentsValue.Name = "lblPendingPaymentsValue";
            this.lblPendingPaymentsValue.Size = new System.Drawing.Size(137, 35);
            this.lblPendingPaymentsValue.TabIndex = 1;
            this.lblPendingPaymentsValue.Text = "3";
            // 
            // lblPendingPaymentsTitle
            // 
            this.lblPendingPaymentsTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblPendingPaymentsTitle.Location = new System.Drawing.Point(10, 10);
            this.lblPendingPaymentsTitle.Name = "lblPendingPaymentsTitle";
            this.lblPendingPaymentsTitle.Size = new System.Drawing.Size(142, 17);
            this.lblPendingPaymentsTitle.TabIndex = 0;
            this.lblPendingPaymentsTitle.Text = "Pending Payments";
            // 
            // grpRecentJobOrders
            // 
            this.grpRecentJobOrders.Controls.Add(this.dgvRecentJobOrders);
            this.grpRecentJobOrders.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpRecentJobOrders.Location = new System.Drawing.Point(17, 113);
            this.grpRecentJobOrders.Name = "grpRecentJobOrders";
            this.grpRecentJobOrders.Size = new System.Drawing.Size(369, 225);
            this.grpRecentJobOrders.TabIndex = 4;
            this.grpRecentJobOrders.TabStop = false;
            this.grpRecentJobOrders.Text = "Recent Job Orders";
            // 
            // dgvRecentJobOrders
            // 
            this.dgvRecentJobOrders.AllowUserToAddRows = false;
            this.dgvRecentJobOrders.AllowUserToDeleteRows = false;
            this.dgvRecentJobOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentJobOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colJO,
            this.colPlate,
            this.colService,
            this.colStatus});
            this.dgvRecentJobOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecentJobOrders.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvRecentJobOrders.Location = new System.Drawing.Point(3, 20);
            this.dgvRecentJobOrders.Name = "dgvRecentJobOrders";
            this.dgvRecentJobOrders.ReadOnly = true;
            this.dgvRecentJobOrders.RowHeadersVisible = false;
            this.dgvRecentJobOrders.Size = new System.Drawing.Size(363, 202);
            this.dgvRecentJobOrders.TabIndex = 0;
            // 
            // colJO
            // 
            this.colJO.HeaderText = "JO#";
            this.colJO.Name = "colJO";
            this.colJO.ReadOnly = true;
            // 
            // colPlate
            // 
            this.colPlate.HeaderText = "Plate";
            this.colPlate.Name = "colPlate";
            this.colPlate.ReadOnly = true;
            // 
            // colService
            // 
            this.colService.HeaderText = "Service";
            this.colService.Name = "colService";
            this.colService.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // grpLowStockAlerts
            // 
            this.grpLowStockAlerts.Controls.Add(this.lstLowStockAlerts);
            this.grpLowStockAlerts.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpLowStockAlerts.Location = new System.Drawing.Point(399, 113);
            this.grpLowStockAlerts.Name = "grpLowStockAlerts";
            this.grpLowStockAlerts.Size = new System.Drawing.Size(300, 225);
            this.grpLowStockAlerts.TabIndex = 5;
            this.grpLowStockAlerts.TabStop = false;
            this.grpLowStockAlerts.Text = "Low Stock Alerts";
            // 
            // lstLowStockAlerts
            // 
            this.lstLowStockAlerts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLowStockAlerts.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstLowStockAlerts.ForeColor = System.Drawing.Color.Firebrick;
            this.lstLowStockAlerts.FormattingEnabled = true;
            this.lstLowStockAlerts.ItemHeight = 17;
            this.lstLowStockAlerts.Location = new System.Drawing.Point(3, 20);
            this.lstLowStockAlerts.Name = "lstLowStockAlerts";
            this.lstLowStockAlerts.Size = new System.Drawing.Size(294, 202);
            this.lstLowStockAlerts.TabIndex = 0;
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.grpLowStockAlerts);
            this.Controls.Add(this.grpRecentJobOrders);
            this.Controls.Add(this.pnlCardPendingPayments);
            this.Controls.Add(this.pnlCardTodaysSales);
            this.Controls.Add(this.pnlCardScheduledToday);
            this.Controls.Add(this.pnlCardActiveRepairs);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(713, 384);
            this.pnlCardActiveRepairs.ResumeLayout(false);
            this.pnlCardScheduledToday.ResumeLayout(false);
            this.pnlCardTodaysSales.ResumeLayout(false);
            this.pnlCardPendingPayments.ResumeLayout(false);
            this.grpRecentJobOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentJobOrders)).EndInit();
            this.grpLowStockAlerts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

#endregion

        private System.Windows.Forms.Panel pnlCardActiveRepairs;
        private System.Windows.Forms.Label lblActiveRepairsValue;
        private System.Windows.Forms.Label lblActiveRepairsTitle;
        private System.Windows.Forms.Panel pnlCardScheduledToday;
        private System.Windows.Forms.Label lblScheduledTodayValue;
        private System.Windows.Forms.Label lblScheduledTodayTitle;
        private System.Windows.Forms.Panel pnlCardTodaysSales;
        private System.Windows.Forms.Label lblTodaysSalesValue;
        private System.Windows.Forms.Label lblTodaysSalesTitle;
        private System.Windows.Forms.Panel pnlCardPendingPayments;
        private System.Windows.Forms.Label lblPendingPaymentsValue;
        private System.Windows.Forms.Label lblPendingPaymentsTitle;
        private System.Windows.Forms.GroupBox grpRecentJobOrders;
        private System.Windows.Forms.DataGridView dgvRecentJobOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.GroupBox grpLowStockAlerts;
        private System.Windows.Forms.ListBox lstLowStockAlerts;
    }
}
namespace ARMSProtOne
{
    partial class JobOrderControl
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
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnFilterAll = new System.Windows.Forms.Button();
            this.btnFilterPending = new System.Windows.Forms.Button();
            this.btnFilterOngoing = new System.Windows.Forms.Button();
            this.btnFilterCompleted = new System.Windows.Forms.Button();
            this.btnManageJobOrder = new System.Windows.Forms.Button();
            this.btnNewJobOrder = new System.Windows.Forms.Button();
            this.dgvJobOrders = new System.Windows.Forms.DataGridView();
            this.colJO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobOrders)).BeginInit();
            this.SuspendLayout();

            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Size = new System.Drawing.Size(844, 60);
            this.pnlToolbar.Controls.Add(this.lblFilter);
            this.pnlToolbar.Controls.Add(this.btnFilterAll);
            this.pnlToolbar.Controls.Add(this.btnFilterPending);
            this.pnlToolbar.Controls.Add(this.btnFilterOngoing);
            this.pnlToolbar.Controls.Add(this.btnFilterCompleted);
            this.pnlToolbar.Controls.Add(this.btnManageJobOrder);
            this.pnlToolbar.Controls.Add(this.btnNewJobOrder);

            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFilter.Location = new System.Drawing.Point(15, 21);
            this.lblFilter.Text = "Filter:";

            this.btnFilterAll.Location = new System.Drawing.Point(65, 14);
            this.btnFilterAll.Size = new System.Drawing.Size(64, 32);
            this.btnFilterAll.Text = "All";
            this.btnFilterAll.UseVisualStyleBackColor = true;
            this.btnFilterAll.Click += new System.EventHandler(this.btnFilterAll_Click);

            this.btnFilterPending.Location = new System.Drawing.Point(137, 14);
            this.btnFilterPending.Size = new System.Drawing.Size(86, 32);
            this.btnFilterPending.Text = "Pending";
            this.btnFilterPending.UseVisualStyleBackColor = true;
            this.btnFilterPending.Click += new System.EventHandler(this.btnFilterPending_Click);

            this.btnFilterOngoing.Location = new System.Drawing.Point(231, 14);
            this.btnFilterOngoing.Size = new System.Drawing.Size(86, 32);
            this.btnFilterOngoing.Text = "Ongoing";
            this.btnFilterOngoing.UseVisualStyleBackColor = true;
            this.btnFilterOngoing.Click += new System.EventHandler(this.btnFilterOngoing_Click);

            this.btnFilterCompleted.Location = new System.Drawing.Point(325, 14);
            this.btnFilterCompleted.Size = new System.Drawing.Size(96, 32);
            this.btnFilterCompleted.Text = "Completed";
            this.btnFilterCompleted.UseVisualStyleBackColor = true;
            this.btnFilterCompleted.Click += new System.EventHandler(this.btnFilterCompleted_Click);

            this.btnManageJobOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageJobOrder.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnManageJobOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageJobOrder.FlatAppearance.BorderSize = 0;
            this.btnManageJobOrder.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnManageJobOrder.ForeColor = System.Drawing.Color.White;
            this.btnManageJobOrder.Location = new System.Drawing.Point(518, 12);
            this.btnManageJobOrder.Size = new System.Drawing.Size(150, 36);
            this.btnManageJobOrder.Text = "Manage Selected";
            this.btnManageJobOrder.UseVisualStyleBackColor = false;
            this.btnManageJobOrder.Click += new System.EventHandler(this.btnManageJobOrder_Click);

            this.btnNewJobOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewJobOrder.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnNewJobOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewJobOrder.FlatAppearance.BorderSize = 0;
            this.btnNewJobOrder.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNewJobOrder.ForeColor = System.Drawing.Color.White;
            this.btnNewJobOrder.Location = new System.Drawing.Point(676, 12);
            this.btnNewJobOrder.Size = new System.Drawing.Size(150, 36);
            this.btnNewJobOrder.Text = "+ Create Job Order";
            this.btnNewJobOrder.UseVisualStyleBackColor = false;
            this.btnNewJobOrder.Click += new System.EventHandler(this.btnNewJobOrder_Click);

            this.dgvJobOrders.AllowUserToAddRows = false;
            this.dgvJobOrders.AllowUserToDeleteRows = false;
            this.dgvJobOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJobOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJobOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvJobOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJobOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colJO, this.colPlate, this.colVehicle, this.colService, this.colCost, this.colStatus});
            this.dgvJobOrders.Location = new System.Drawing.Point(18, 72);
            this.dgvJobOrders.MultiSelect = false;
            this.dgvJobOrders.ReadOnly = true;
            this.dgvJobOrders.RowHeadersVisible = false;
            this.dgvJobOrders.RowTemplate.Height = 30;
            this.dgvJobOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobOrders.Size = new System.Drawing.Size(808, 565);

            this.colJO.HeaderText = "JO#"; this.colJO.Name = "colJO"; this.colJO.ReadOnly = true; this.colJO.FillWeight = 90;
            this.colPlate.HeaderText = "Plate"; this.colPlate.Name = "colPlate"; this.colPlate.ReadOnly = true; this.colPlate.FillWeight = 90;
            this.colVehicle.HeaderText = "Vehicle"; this.colVehicle.Name = "colVehicle"; this.colVehicle.ReadOnly = true; this.colVehicle.FillWeight = 130;
            this.colService.HeaderText = "Service Type"; this.colService.Name = "colService"; this.colService.ReadOnly = true; this.colService.FillWeight = 140;
            this.colCost.HeaderText = "Cost"; this.colCost.Name = "colCost"; this.colCost.ReadOnly = true; this.colCost.FillWeight = 90;
            this.colStatus.HeaderText = "Status"; this.colStatus.Name = "colStatus"; this.colStatus.ReadOnly = true; this.colStatus.FillWeight = 100;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.dgvJobOrders);
            this.Controls.Add(this.pnlToolbar);
            this.Name = "JobOrderControl";
            this.Size = new System.Drawing.Size(844, 655);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobOrders)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnFilterAll;
        private System.Windows.Forms.Button btnFilterPending;
        private System.Windows.Forms.Button btnFilterOngoing;
        private System.Windows.Forms.Button btnFilterCompleted;
        private System.Windows.Forms.Button btnManageJobOrder;
        private System.Windows.Forms.Button btnNewJobOrder;
        private System.Windows.Forms.DataGridView dgvJobOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
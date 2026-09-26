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
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToolbar.Controls.Add(this.lblFilter);
            this.pnlToolbar.Controls.Add(this.btnFilterAll);
            this.pnlToolbar.Controls.Add(this.btnFilterPending);
            this.pnlToolbar.Controls.Add(this.btnFilterOngoing);
            this.pnlToolbar.Controls.Add(this.btnFilterCompleted);
            this.pnlToolbar.Controls.Add(this.btnManageJobOrder);
            this.pnlToolbar.Controls.Add(this.btnNewJobOrder);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(723, 52);
            this.pnlToolbar.TabIndex = 1;
            this.pnlToolbar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlToolbar_Paint);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFilter.Location = new System.Drawing.Point(13, 18);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(45, 17);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filter:";
            // 
            // btnFilterAll
            // 
            this.btnFilterAll.Location = new System.Drawing.Point(56, 12);
            this.btnFilterAll.Name = "btnFilterAll";
            this.btnFilterAll.Size = new System.Drawing.Size(55, 28);
            this.btnFilterAll.TabIndex = 1;
            this.btnFilterAll.Text = "All";
            this.btnFilterAll.UseVisualStyleBackColor = true;
            this.btnFilterAll.Click += new System.EventHandler(this.btnFilterAll_Click);
            // 
            // btnFilterPending
            // 
            this.btnFilterPending.Location = new System.Drawing.Point(117, 12);
            this.btnFilterPending.Name = "btnFilterPending";
            this.btnFilterPending.Size = new System.Drawing.Size(74, 28);
            this.btnFilterPending.TabIndex = 2;
            this.btnFilterPending.Text = "Pending";
            this.btnFilterPending.UseVisualStyleBackColor = true;
            this.btnFilterPending.Click += new System.EventHandler(this.btnFilterPending_Click);
            // 
            // btnFilterOngoing
            // 
            this.btnFilterOngoing.Location = new System.Drawing.Point(198, 12);
            this.btnFilterOngoing.Name = "btnFilterOngoing";
            this.btnFilterOngoing.Size = new System.Drawing.Size(74, 28);
            this.btnFilterOngoing.TabIndex = 3;
            this.btnFilterOngoing.Text = "Ongoing";
            this.btnFilterOngoing.UseVisualStyleBackColor = true;
            this.btnFilterOngoing.Click += new System.EventHandler(this.btnFilterOngoing_Click);
            // 
            // btnFilterCompleted
            // 
            this.btnFilterCompleted.Location = new System.Drawing.Point(279, 12);
            this.btnFilterCompleted.Name = "btnFilterCompleted";
            this.btnFilterCompleted.Size = new System.Drawing.Size(82, 28);
            this.btnFilterCompleted.TabIndex = 4;
            this.btnFilterCompleted.Text = "Completed";
            this.btnFilterCompleted.UseVisualStyleBackColor = true;
            this.btnFilterCompleted.Click += new System.EventHandler(this.btnFilterCompleted_Click);
            // 
            // btnManageJobOrder
            // 
            this.btnManageJobOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageJobOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnManageJobOrder.FlatAppearance.BorderSize = 0;
            this.btnManageJobOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageJobOrder.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnManageJobOrder.ForeColor = System.Drawing.Color.White;
            this.btnManageJobOrder.Location = new System.Drawing.Point(443, 10);
            this.btnManageJobOrder.Name = "btnManageJobOrder";
            this.btnManageJobOrder.Size = new System.Drawing.Size(129, 31);
            this.btnManageJobOrder.TabIndex = 5;
            this.btnManageJobOrder.Text = "Manage Selected";
            this.btnManageJobOrder.UseVisualStyleBackColor = false;
            this.btnManageJobOrder.Click += new System.EventHandler(this.btnManageJobOrder_Click);
            // 
            // btnNewJobOrder
            // 
            this.btnNewJobOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewJobOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnNewJobOrder.FlatAppearance.BorderSize = 0;
            this.btnNewJobOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewJobOrder.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNewJobOrder.ForeColor = System.Drawing.Color.White;
            this.btnNewJobOrder.Location = new System.Drawing.Point(578, 10);
            this.btnNewJobOrder.Name = "btnNewJobOrder";
            this.btnNewJobOrder.Size = new System.Drawing.Size(129, 31);
            this.btnNewJobOrder.TabIndex = 6;
            this.btnNewJobOrder.Text = "+ Create Job Order";
            this.btnNewJobOrder.UseVisualStyleBackColor = false;
            this.btnNewJobOrder.Click += new System.EventHandler(this.btnNewJobOrder_Click);
            // 
            // dgvJobOrders
            // 
            this.dgvJobOrders.AllowUserToAddRows = false;
            this.dgvJobOrders.AllowUserToDeleteRows = false;
            this.dgvJobOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJobOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJobOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvJobOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJobOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colJO,
            this.colPlate,
            this.colVehicle,
            this.colService,
            this.colCost,
            this.colStatus});
            this.dgvJobOrders.Location = new System.Drawing.Point(15, 62);
            this.dgvJobOrders.MultiSelect = false;
            this.dgvJobOrders.Name = "dgvJobOrders";
            this.dgvJobOrders.ReadOnly = true;
            this.dgvJobOrders.RowHeadersVisible = false;
            this.dgvJobOrders.RowTemplate.Height = 30;
            this.dgvJobOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobOrders.Size = new System.Drawing.Size(693, 490);
            this.dgvJobOrders.TabIndex = 0;
            // 
            // colJO
            // 
            this.colJO.FillWeight = 90F;
            this.colJO.HeaderText = "JO#";
            this.colJO.Name = "colJO";
            this.colJO.ReadOnly = true;
            // 
            // colPlate
            // 
            this.colPlate.FillWeight = 90F;
            this.colPlate.HeaderText = "Plate";
            this.colPlate.Name = "colPlate";
            this.colPlate.ReadOnly = true;
            // 
            // colVehicle
            // 
            this.colVehicle.FillWeight = 130F;
            this.colVehicle.HeaderText = "Vehicle";
            this.colVehicle.Name = "colVehicle";
            this.colVehicle.ReadOnly = true;
            // 
            // colService
            // 
            this.colService.FillWeight = 140F;
            this.colService.HeaderText = "Service Type";
            this.colService.Name = "colService";
            this.colService.ReadOnly = true;
            // 
            // colCost
            // 
            this.colCost.FillWeight = 90F;
            this.colCost.HeaderText = "Cost";
            this.colCost.Name = "colCost";
            this.colCost.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // JobOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.dgvJobOrders);
            this.Controls.Add(this.pnlToolbar);
            this.Name = "JobOrderControl";
            this.Size = new System.Drawing.Size(723, 568);
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
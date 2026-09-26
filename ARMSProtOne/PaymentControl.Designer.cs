namespace ARMSProtOne
{
    partial class PaymentControl
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
            this.btnFilterAll = new System.Windows.Forms.Button();
            this.btnFilterUnpaid = new System.Windows.Forms.Button();
            this.btnFilterPartial = new System.Windows.Forms.Button();
            this.btnFilterPaid = new System.Windows.Forms.Button();
            this.btnManagePayment = new System.Windows.Forms.Button();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(844, 55);
            this.pnlHeader.Controls.Add(this.lblTitle);

            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(18, 13);
            this.lblTitle.Text = "Payment Transactions";

            // pnlToolbar
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 55);
            this.pnlToolbar.Size = new System.Drawing.Size(844, 50);
            this.pnlToolbar.Controls.Add(this.btnFilterAll);
            this.pnlToolbar.Controls.Add(this.btnFilterUnpaid);
            this.pnlToolbar.Controls.Add(this.btnFilterPartial);
            this.pnlToolbar.Controls.Add(this.btnFilterPaid);
            this.pnlToolbar.Controls.Add(this.btnManagePayment);

            this.btnFilterAll.Location = new System.Drawing.Point(15, 10);
            this.btnFilterAll.Size = new System.Drawing.Size(70, 30);
            this.btnFilterAll.Text = "All";
            this.btnFilterAll.UseVisualStyleBackColor = true;
            this.btnFilterAll.Click += new System.EventHandler(this.btnFilterAll_Click);

            this.btnFilterUnpaid.Location = new System.Drawing.Point(93, 10);
            this.btnFilterUnpaid.Size = new System.Drawing.Size(90, 30);
            this.btnFilterUnpaid.Text = "Unpaid";
            this.btnFilterUnpaid.UseVisualStyleBackColor = true;
            this.btnFilterUnpaid.Click += new System.EventHandler(this.btnFilterUnpaid_Click);

            this.btnFilterPartial.Location = new System.Drawing.Point(191, 10);
            this.btnFilterPartial.Size = new System.Drawing.Size(90, 30);
            this.btnFilterPartial.Text = "Partial";
            this.btnFilterPartial.UseVisualStyleBackColor = true;
            this.btnFilterPartial.Click += new System.EventHandler(this.btnFilterPartial_Click);

            this.btnFilterPaid.Location = new System.Drawing.Point(289, 10);
            this.btnFilterPaid.Size = new System.Drawing.Size(90, 30);
            this.btnFilterPaid.Text = "Paid";
            this.btnFilterPaid.UseVisualStyleBackColor = true;
            this.btnFilterPaid.Click += new System.EventHandler(this.btnFilterPaid_Click);

            this.btnManagePayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManagePayment.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnManagePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagePayment.FlatAppearance.BorderSize = 0;
            this.btnManagePayment.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnManagePayment.ForeColor = System.Drawing.Color.White;
            this.btnManagePayment.Location = new System.Drawing.Point(676, 8);
            this.btnManagePayment.Size = new System.Drawing.Size(150, 34);
            this.btnManagePayment.Text = "Manage Selected";
            this.btnManagePayment.UseVisualStyleBackColor = false;
            this.btnManagePayment.Click += new System.EventHandler(this.btnManagePayment_Click);

            // dgvPayments
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayments.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.dgvPayments.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.RowTemplate.Height = 32;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colType, this.colCustomer, this.colTotal, this.colBalance, this.colPaid, this.colStatus});

            this.colType.HeaderText = "Type"; this.colType.Name = "colType";
            this.colCustomer.HeaderText = "Customer"; this.colCustomer.Name = "colCustomer";
            this.colTotal.HeaderText = "Total"; this.colTotal.Name = "colTotal";
            this.colBalance.HeaderText = "Balance"; this.colBalance.Name = "colBalance";
            this.colPaid.HeaderText = "Paid"; this.colPaid.Name = "colPaid";
            this.colStatus.HeaderText = "Status"; this.colStatus.Name = "colStatus";

            // root
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.Name = "PaymentControl";
            this.Size = new System.Drawing.Size(844, 655);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Button btnFilterAll;
        private System.Windows.Forms.Button btnFilterUnpaid;
        private System.Windows.Forms.Button btnFilterPartial;
        private System.Windows.Forms.Button btnFilterPaid;
        private System.Windows.Forms.Button btnManagePayment;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
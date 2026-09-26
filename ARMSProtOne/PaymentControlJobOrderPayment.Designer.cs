namespace ARMSProtOne
{
    partial class PaymentControlJobOrderPayment
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
            this.grpJOInfo = new System.Windows.Forms.GroupBox();
            this.lblJONumber = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.grpTransactionType = new System.Windows.Forms.GroupBox();
            this.rbFullPayment = new System.Windows.Forms.RadioButton();
            this.rbPartialPayment = new System.Windows.Forms.RadioButton();
            this.grpCostSummary = new System.Windows.Forms.GroupBox();
            this.lblServicePartsTotal = new System.Windows.Forms.Label();
            this.lblLaborTotal = new System.Windows.Forms.Label();
            this.lblHomeServiceFee = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.txtJOPAmountPaid = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblJOPChange = new System.Windows.Forms.Label();
            this.btnCancelJOP = new System.Windows.Forms.Button();
            this.btnExportJOP = new System.Windows.Forms.Button();
            this.btnSubmitJOP = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.grpJOInfo.SuspendLayout();
            this.grpTransactionType.SuspendLayout();
            this.grpCostSummary.SuspendLayout();
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
            this.lblTitle.Text = "Payment — Job Order";

            System.Drawing.Font f = new System.Drawing.Font("Segoe UI", 9.5F);
            System.Windows.Forms.AnchorStyles stretch = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));

            // grpJOInfo
            this.grpJOInfo.Anchor = stretch;
            this.grpJOInfo.BackColor = System.Drawing.Color.White;
            this.grpJOInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpJOInfo.Location = new System.Drawing.Point(20, 68);
            this.grpJOInfo.Size = new System.Drawing.Size(804, 108);
            this.grpJOInfo.Text = "Job Order Info";
            this.grpJOInfo.Controls.Add(this.lblJONumber);
            this.grpJOInfo.Controls.Add(this.lblService);
            this.grpJOInfo.Controls.Add(this.lblCustomer);

            this.lblJONumber.AutoSize = true; this.lblJONumber.Font = f;
            this.lblJONumber.Location = new System.Drawing.Point(20, 34); this.lblJONumber.Text = "JO No.: -";

            this.lblService.AutoSize = true; this.lblService.Font = f;
            this.lblService.Location = new System.Drawing.Point(20, 62); this.lblService.Text = "Service: -";

            this.lblCustomer.AutoSize = true; this.lblCustomer.Font = f;
            this.lblCustomer.Location = new System.Drawing.Point(20, 90); this.lblCustomer.Text = "Customer: -";

            // grpTransactionType
            this.grpTransactionType.Anchor = stretch;
            this.grpTransactionType.BackColor = System.Drawing.Color.White;
            this.grpTransactionType.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpTransactionType.Location = new System.Drawing.Point(20, 184);
            this.grpTransactionType.Size = new System.Drawing.Size(804, 55);
            this.grpTransactionType.Text = "Transaction Type";
            this.grpTransactionType.Controls.Add(this.rbFullPayment);
            this.grpTransactionType.Controls.Add(this.rbPartialPayment);

            this.rbFullPayment.AutoSize = true; this.rbFullPayment.Font = f;
            this.rbFullPayment.Location = new System.Drawing.Point(20, 24); this.rbFullPayment.Text = "Full Payment";

            this.rbPartialPayment.AutoSize = true; this.rbPartialPayment.Font = f;
            this.rbPartialPayment.Location = new System.Drawing.Point(200, 24); this.rbPartialPayment.Text = "Partial Payment";

            // grpCostSummary
            this.grpCostSummary.Anchor = stretch;
            this.grpCostSummary.BackColor = System.Drawing.Color.White;
            this.grpCostSummary.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpCostSummary.Location = new System.Drawing.Point(20, 254);
            this.grpCostSummary.Size = new System.Drawing.Size(804, 250);
            this.grpCostSummary.Text = "Cost Summary";
            this.grpCostSummary.Controls.Add(this.lblServicePartsTotal);
            this.grpCostSummary.Controls.Add(this.lblLaborTotal);
            this.grpCostSummary.Controls.Add(this.lblHomeServiceFee);
            this.grpCostSummary.Controls.Add(this.lblDiscount);
            this.grpCostSummary.Controls.Add(this.lblTotal);
            this.grpCostSummary.Controls.Add(this.lblAmountPaid);
            this.grpCostSummary.Controls.Add(this.txtJOPAmountPaid);
            this.grpCostSummary.Controls.Add(this.lblChange);
            this.grpCostSummary.Controls.Add(this.lblJOPChange);

            this.lblServicePartsTotal.AutoSize = true; this.lblServicePartsTotal.Font = f;
            this.lblServicePartsTotal.Location = new System.Drawing.Point(20, 32); this.lblServicePartsTotal.Text = "Service & Parts Total: PHP 0.00";

            this.lblLaborTotal.AutoSize = true; this.lblLaborTotal.Font = f;
            this.lblLaborTotal.Location = new System.Drawing.Point(20, 58); this.lblLaborTotal.Text = "Labor Total: PHP 0.00";

            this.lblHomeServiceFee.AutoSize = true; this.lblHomeServiceFee.Font = f;
            this.lblHomeServiceFee.Location = new System.Drawing.Point(20, 84); this.lblHomeServiceFee.Text = "Home Service Fee: PHP 0.00";

            this.lblDiscount.AutoSize = true; this.lblDiscount.Font = f;
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.lblDiscount.Location = new System.Drawing.Point(20, 110); this.lblDiscount.Text = "Discount: -PHP 0.00";

            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(20, 144); this.lblTotal.Text = "Total: PHP 0.00";

            this.lblAmountPaid.AutoSize = true; this.lblAmountPaid.Font = f;
            this.lblAmountPaid.Location = new System.Drawing.Point(20, 186); this.lblAmountPaid.Text = "Amount Paid:";
            this.txtJOPAmountPaid.Location = new System.Drawing.Point(160, 182);
            this.txtJOPAmountPaid.Size = new System.Drawing.Size(200, 26);

            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblChange.Location = new System.Drawing.Point(20, 220); this.lblChange.Text = "Change:";
            this.lblJOPChange.AutoSize = true;
            this.lblJOPChange.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblJOPChange.ForeColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.lblJOPChange.Location = new System.Drawing.Point(160, 220); this.lblJOPChange.Text = "PHP 0.00";

            // buttons
            this.btnCancelJOP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelJOP.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnCancelJOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelJOP.FlatAppearance.BorderSize = 0;
            this.btnCancelJOP.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelJOP.ForeColor = System.Drawing.Color.White;
            this.btnCancelJOP.Location = new System.Drawing.Point(482, 600);
            this.btnCancelJOP.Size = new System.Drawing.Size(110, 36);
            this.btnCancelJOP.Text = "Cancel";
            this.btnCancelJOP.UseVisualStyleBackColor = false;
            this.btnCancelJOP.Click += new System.EventHandler(this.btnCancelJOP_Click);

            this.btnExportJOP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportJOP.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnExportJOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportJOP.FlatAppearance.BorderSize = 0;
            this.btnExportJOP.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnExportJOP.ForeColor = System.Drawing.Color.White;
            this.btnExportJOP.Location = new System.Drawing.Point(598, 600);
            this.btnExportJOP.Size = new System.Drawing.Size(110, 36);
            this.btnExportJOP.Text = "Export Receipt";
            this.btnExportJOP.UseVisualStyleBackColor = false;
            this.btnExportJOP.Click += new System.EventHandler(this.btnExportJOP_Click);

            this.btnSubmitJOP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitJOP.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSubmitJOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitJOP.FlatAppearance.BorderSize = 0;
            this.btnSubmitJOP.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSubmitJOP.ForeColor = System.Drawing.Color.White;
            this.btnSubmitJOP.Location = new System.Drawing.Point(714, 600);
            this.btnSubmitJOP.Size = new System.Drawing.Size(110, 36);
            this.btnSubmitJOP.Text = "Submit Payment";
            this.btnSubmitJOP.UseVisualStyleBackColor = false;
            this.btnSubmitJOP.Click += new System.EventHandler(this.btnSubmitJOP_Click);

            // root
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AutoScroll = true;
            this.Controls.Add(this.btnSubmitJOP);
            this.Controls.Add(this.btnExportJOP);
            this.Controls.Add(this.btnCancelJOP);
            this.Controls.Add(this.grpCostSummary);
            this.Controls.Add(this.grpTransactionType);
            this.Controls.Add(this.grpJOInfo);
            this.Controls.Add(this.pnlHeader);
            this.Name = "PaymentControlJobOrderPayment";
            this.Size = new System.Drawing.Size(844, 655);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpJOInfo.ResumeLayout(false);
            this.grpJOInfo.PerformLayout();
            this.grpTransactionType.ResumeLayout(false);
            this.grpTransactionType.PerformLayout();
            this.grpCostSummary.ResumeLayout(false);
            this.grpCostSummary.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpJOInfo;
        private System.Windows.Forms.Label lblJONumber;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.GroupBox grpTransactionType;
        private System.Windows.Forms.RadioButton rbFullPayment;
        private System.Windows.Forms.RadioButton rbPartialPayment;
        private System.Windows.Forms.GroupBox grpCostSummary;
        private System.Windows.Forms.Label lblServicePartsTotal;
        private System.Windows.Forms.Label lblLaborTotal;
        private System.Windows.Forms.Label lblHomeServiceFee;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.TextBox txtJOPAmountPaid;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblJOPChange;
        private System.Windows.Forms.Button btnCancelJOP;
        private System.Windows.Forms.Button btnExportJOP;
        private System.Windows.Forms.Button btnSubmitJOP;
    }
}
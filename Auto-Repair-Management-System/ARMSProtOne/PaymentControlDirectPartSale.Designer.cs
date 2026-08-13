namespace ARMSProtOne
{
    partial class PaymentControlDirectPartSale
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
            this.grpReleaseInfo = new System.Windows.Forms.GroupBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.grpCostSummary = new System.Windows.Forms.GroupBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblPartsTotal = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.txtDPSAmountPaid = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblDPSChange = new System.Windows.Forms.Label();
            this.btnCancelDPS = new System.Windows.Forms.Button();
            this.btnExportDPS = new System.Windows.Forms.Button();
            this.btnSubmitDPS = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.grpReleaseInfo.SuspendLayout();
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
            this.lblTitle.Text = "Payment — Direct Part Sale";

            System.Drawing.Font f = new System.Drawing.Font("Segoe UI", 9.5F);
            System.Windows.Forms.AnchorStyles stretch = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));

            // grpReleaseInfo
            this.grpReleaseInfo.Anchor = stretch;
            this.grpReleaseInfo.BackColor = System.Drawing.Color.White;
            this.grpReleaseInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpReleaseInfo.Location = new System.Drawing.Point(20, 70);
            this.grpReleaseInfo.Size = new System.Drawing.Size(804, 120);
            this.grpReleaseInfo.Text = "Release Part Info";
            this.grpReleaseInfo.Controls.Add(this.lblItemName);
            this.grpReleaseInfo.Controls.Add(this.lblCategory);
            this.grpReleaseInfo.Controls.Add(this.lblQuantity);

            this.lblItemName.AutoSize = true; this.lblItemName.Font = f;
            this.lblItemName.Location = new System.Drawing.Point(20, 34); this.lblItemName.Text = "Item Name: -";

            this.lblCategory.AutoSize = true; this.lblCategory.Font = f;
            this.lblCategory.Location = new System.Drawing.Point(20, 62); this.lblCategory.Text = "Category: -";

            this.lblQuantity.AutoSize = true; this.lblQuantity.Font = f;
            this.lblQuantity.Location = new System.Drawing.Point(20, 90); this.lblQuantity.Text = "Quantity: -";

            // grpCostSummary
            this.grpCostSummary.Anchor = stretch;
            this.grpCostSummary.BackColor = System.Drawing.Color.White;
            this.grpCostSummary.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpCostSummary.Location = new System.Drawing.Point(20, 205);
            this.grpCostSummary.Size = new System.Drawing.Size(804, 200);
            this.grpCostSummary.Text = "Cost Summary";
            this.grpCostSummary.Controls.Add(this.lblUnitPrice);
            this.grpCostSummary.Controls.Add(this.lblPartsTotal);
            this.grpCostSummary.Controls.Add(this.lblAmountPaid);
            this.grpCostSummary.Controls.Add(this.txtDPSAmountPaid);
            this.grpCostSummary.Controls.Add(this.lblChange);
            this.grpCostSummary.Controls.Add(this.lblDPSChange);

            this.lblUnitPrice.AutoSize = true; this.lblUnitPrice.Font = f;
            this.lblUnitPrice.Location = new System.Drawing.Point(20, 34); this.lblUnitPrice.Text = "Unit Price: PHP 0.00";

            this.lblPartsTotal.AutoSize = true; this.lblPartsTotal.Font = f;
            this.lblPartsTotal.Location = new System.Drawing.Point(20, 62); this.lblPartsTotal.Text = "Parts Total: PHP 0.00";

            this.lblAmountPaid.AutoSize = true; this.lblAmountPaid.Font = f;
            this.lblAmountPaid.Location = new System.Drawing.Point(20, 104); this.lblAmountPaid.Text = "Amount Paid:";
            this.txtDPSAmountPaid.Location = new System.Drawing.Point(160, 100);
            this.txtDPSAmountPaid.Size = new System.Drawing.Size(200, 26);

            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblChange.Location = new System.Drawing.Point(20, 150); this.lblChange.Text = "Change:";
            this.lblDPSChange.AutoSize = true;
            this.lblDPSChange.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDPSChange.ForeColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.lblDPSChange.Location = new System.Drawing.Point(160, 150); this.lblDPSChange.Text = "PHP 0.00";

            // buttons
            this.btnCancelDPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelDPS.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnCancelDPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelDPS.FlatAppearance.BorderSize = 0;
            this.btnCancelDPS.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelDPS.ForeColor = System.Drawing.Color.White;
            this.btnCancelDPS.Location = new System.Drawing.Point(482, 600);
            this.btnCancelDPS.Size = new System.Drawing.Size(110, 36);
            this.btnCancelDPS.Text = "Cancel";
            this.btnCancelDPS.UseVisualStyleBackColor = false;
            this.btnCancelDPS.Click += new System.EventHandler(this.btnCancelDPS_Click);

            this.btnExportDPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportDPS.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnExportDPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportDPS.FlatAppearance.BorderSize = 0;
            this.btnExportDPS.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnExportDPS.ForeColor = System.Drawing.Color.White;
            this.btnExportDPS.Location = new System.Drawing.Point(598, 600);
            this.btnExportDPS.Size = new System.Drawing.Size(110, 36);
            this.btnExportDPS.Text = "Export Receipt";
            this.btnExportDPS.UseVisualStyleBackColor = false;
            this.btnExportDPS.Click += new System.EventHandler(this.btnExportDPS_Click);

            this.btnSubmitDPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitDPS.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSubmitDPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitDPS.FlatAppearance.BorderSize = 0;
            this.btnSubmitDPS.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSubmitDPS.ForeColor = System.Drawing.Color.White;
            this.btnSubmitDPS.Location = new System.Drawing.Point(714, 600);
            this.btnSubmitDPS.Size = new System.Drawing.Size(110, 36);
            this.btnSubmitDPS.Text = "Submit Payment";
            this.btnSubmitDPS.UseVisualStyleBackColor = false;
            this.btnSubmitDPS.Click += new System.EventHandler(this.btnSubmitDPS_Click);

            // root
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnSubmitDPS);
            this.Controls.Add(this.btnExportDPS);
            this.Controls.Add(this.btnCancelDPS);
            this.Controls.Add(this.grpCostSummary);
            this.Controls.Add(this.grpReleaseInfo);
            this.Controls.Add(this.pnlHeader);
            this.Name = "PaymentControlDirectPartSale";
            this.Size = new System.Drawing.Size(844, 655);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpReleaseInfo.ResumeLayout(false);
            this.grpReleaseInfo.PerformLayout();
            this.grpCostSummary.ResumeLayout(false);
            this.grpCostSummary.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpReleaseInfo;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.GroupBox grpCostSummary;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblPartsTotal;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.TextBox txtDPSAmountPaid;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblDPSChange;
        private System.Windows.Forms.Button btnCancelDPS;
        private System.Windows.Forms.Button btnExportDPS;
        private System.Windows.Forms.Button btnSubmitDPS;
    }
}
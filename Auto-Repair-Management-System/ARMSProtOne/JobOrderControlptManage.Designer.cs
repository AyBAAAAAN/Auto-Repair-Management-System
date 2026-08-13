namespace ARMSProtOne
{
    partial class JobOrderControlptManage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblWarrantyBadge = new System.Windows.Forms.Label();
            this.lblTargetJO = new System.Windows.Forms.Label();
            this.lblTargetCustomer = new System.Windows.Forms.Label();
            this.lblTargetVehicle = new System.Windows.Forms.Label();
            this.lblTargetServiceType = new System.Windows.Forms.Label();
            this.lblTargetMechanic = new System.Windows.Forms.Label();
            this.lblTargetParts = new System.Windows.Forms.Label();
            this.lblTargetNotes = new System.Windows.Forms.Label();
            this.lblUpdateStatus = new System.Windows.Forms.Label();
            this.cmbStatusPicker = new System.Windows.Forms.ComboBox();
            this.btnCreateBackJob = new System.Windows.Forms.Button();
            this.btnSaveStatus = new System.Windows.Forms.Button();
            this.btnCloseDetails = new System.Windows.Forms.Button();

            this.pnlBackJob = new System.Windows.Forms.Panel();
            this.lblBackJobTitle = new System.Windows.Forms.Label();
            this.lblBackJobLinkInfo = new System.Windows.Forms.Label();
            this.lblBackJobCustomer = new System.Windows.Forms.Label();
            this.lblBackJobVehicle = new System.Windows.Forms.Label();
            this.lblBackJobOriginalService = new System.Windows.Forms.Label();
            this.lblBackJobDate = new System.Windows.Forms.Label();
            this.dtpBackJobDate = new System.Windows.Forms.DateTimePicker();
            this.lblBackJobMechanic = new System.Windows.Forms.Label();
            this.cmbBackJobMechanic = new System.Windows.Forms.ComboBox();
            this.btnCancelBackJob = new System.Windows.Forms.Button();
            this.btnSubmitBackJob = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // ===== WORK ORDER DETAILS PANEL =====
            this.lblWarrantyBadge.AutoSize = true;
            this.lblWarrantyBadge.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblWarrantyBadge.ForeColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.lblWarrantyBadge.Location = new System.Drawing.Point(18, 15);
            this.lblWarrantyBadge.Text = "Warranty active";

            this.lblTargetJO.AutoSize = true;
            this.lblTargetJO.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTargetJO.Location = new System.Drawing.Point(18, 48);
            this.lblTargetJO.Text = "Job Order: -";

            System.Drawing.Font infoFont = new System.Drawing.Font("Segoe UI", 9.5F);

            this.lblTargetCustomer.AutoSize = true; this.lblTargetCustomer.Font = infoFont;
            this.lblTargetCustomer.Location = new System.Drawing.Point(18, 92); this.lblTargetCustomer.Text = "Customer: -";

            this.lblTargetVehicle.AutoSize = true; this.lblTargetVehicle.Font = infoFont;
            this.lblTargetVehicle.Location = new System.Drawing.Point(18, 122); this.lblTargetVehicle.Text = "Vehicle: -";

            this.lblTargetServiceType.AutoSize = true; this.lblTargetServiceType.Font = infoFont;
            this.lblTargetServiceType.Location = new System.Drawing.Point(18, 152); this.lblTargetServiceType.Text = "Service Type: -";

            this.lblTargetMechanic.AutoSize = true; this.lblTargetMechanic.Font = infoFont;
            this.lblTargetMechanic.Location = new System.Drawing.Point(18, 182); this.lblTargetMechanic.Text = "Mechanic: -";

            this.lblTargetParts.AutoSize = true; this.lblTargetParts.Font = infoFont;
            this.lblTargetParts.Location = new System.Drawing.Point(18, 212); this.lblTargetParts.Text = "Parts Used: -";

            this.lblTargetNotes.AutoSize = true; this.lblTargetNotes.Font = infoFont;
            this.lblTargetNotes.Location = new System.Drawing.Point(18, 242); this.lblTargetNotes.Text = "Notes: -";

            this.lblUpdateStatus.AutoSize = true;
            this.lblUpdateStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUpdateStatus.Location = new System.Drawing.Point(18, 300);
            this.lblUpdateStatus.Text = "Update Status:";
            this.cmbStatusPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusPicker.Location = new System.Drawing.Point(160, 296);
            this.cmbStatusPicker.Size = new System.Drawing.Size(220, 26);

            this.btnCreateBackJob.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnCreateBackJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBackJob.FlatAppearance.BorderSize = 0;
            this.btnCreateBackJob.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCreateBackJob.ForeColor = System.Drawing.Color.White;
            this.btnCreateBackJob.Location = new System.Drawing.Point(18, 350);
            this.btnCreateBackJob.Size = new System.Drawing.Size(170, 38);
            this.btnCreateBackJob.Text = "Create Back Job";
            this.btnCreateBackJob.UseVisualStyleBackColor = false;
            this.btnCreateBackJob.Click += new System.EventHandler(this.btnCreateBackJob_Click);

            this.btnSaveStatus.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSaveStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStatus.FlatAppearance.BorderSize = 0;
            this.btnSaveStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSaveStatus.ForeColor = System.Drawing.Color.White;
            this.btnSaveStatus.Location = new System.Drawing.Point(198, 350);
            this.btnSaveStatus.Size = new System.Drawing.Size(170, 38);
            this.btnSaveStatus.Text = "Update Status";
            this.btnSaveStatus.UseVisualStyleBackColor = false;
            this.btnSaveStatus.Click += new System.EventHandler(this.btnSaveStatus_Click);

            this.btnCloseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseDetails.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnCloseDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseDetails.FlatAppearance.BorderSize = 0;
            this.btnCloseDetails.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCloseDetails.ForeColor = System.Drawing.Color.White;
            this.btnCloseDetails.Location = new System.Drawing.Point(714, 600);
            this.btnCloseDetails.Size = new System.Drawing.Size(110, 36);
            this.btnCloseDetails.Text = "Close";
            this.btnCloseDetails.UseVisualStyleBackColor = false;
            this.btnCloseDetails.Click += new System.EventHandler(this.btnCloseDetails_Click);

            this.pnlDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlDetails.Size = new System.Drawing.Size(844, 655);
            this.pnlDetails.Controls.AddRange(new System.Windows.Forms.Control[] {
            this.lblWarrantyBadge, this.lblTargetJO, this.lblTargetCustomer, this.lblTargetVehicle,
            this.lblTargetServiceType, this.lblTargetMechanic, this.lblTargetParts, this.lblTargetNotes,
            this.lblUpdateStatus, this.cmbStatusPicker, this.btnCreateBackJob, this.btnSaveStatus, this.btnCloseDetails});

            // ===== BACK JOB PANEL =====
            this.lblBackJobTitle.AutoSize = true;
            this.lblBackJobTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblBackJobTitle.Location = new System.Drawing.Point(18, 15);
            this.lblBackJobTitle.Text = "Back Job";

            this.lblBackJobLinkInfo.AutoSize = true;
            this.lblBackJobLinkInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.lblBackJobLinkInfo.ForeColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.lblBackJobLinkInfo.Location = new System.Drawing.Point(18, 52);
            this.lblBackJobLinkInfo.Text = "Linked to JO-0000 · Warranty valid";

            this.lblBackJobCustomer.AutoSize = true; this.lblBackJobCustomer.Font = infoFont;
            this.lblBackJobCustomer.Location = new System.Drawing.Point(18, 96); this.lblBackJobCustomer.Text = "Customer: -";

            this.lblBackJobVehicle.AutoSize = true; this.lblBackJobVehicle.Font = infoFont;
            this.lblBackJobVehicle.Location = new System.Drawing.Point(18, 126); this.lblBackJobVehicle.Text = "Vehicle: -";

            this.lblBackJobOriginalService.AutoSize = true; this.lblBackJobOriginalService.Font = infoFont;
            this.lblBackJobOriginalService.Location = new System.Drawing.Point(18, 156); this.lblBackJobOriginalService.Text = "Original Service: -";

            this.lblBackJobDate.AutoSize = true; this.lblBackJobDate.Font = infoFont;
            this.lblBackJobDate.Location = new System.Drawing.Point(18, 208); this.lblBackJobDate.Text = "Back Job Date:";
            this.dtpBackJobDate.Location = new System.Drawing.Point(160, 204);
            this.dtpBackJobDate.Size = new System.Drawing.Size(220, 26);

            this.lblBackJobMechanic.AutoSize = true; this.lblBackJobMechanic.Font = infoFont;
            this.lblBackJobMechanic.Location = new System.Drawing.Point(18, 250); this.lblBackJobMechanic.Text = "Mechanic:";
            this.cmbBackJobMechanic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBackJobMechanic.Location = new System.Drawing.Point(160, 246);
            this.cmbBackJobMechanic.Size = new System.Drawing.Size(220, 26);

            this.btnCancelBackJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelBackJob.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnCancelBackJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBackJob.FlatAppearance.BorderSize = 0;
            this.btnCancelBackJob.ForeColor = System.Drawing.Color.White;
            this.btnCancelBackJob.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelBackJob.Location = new System.Drawing.Point(598, 600);
            this.btnCancelBackJob.Size = new System.Drawing.Size(110, 36);
            this.btnCancelBackJob.Text = "Cancel";
            this.btnCancelBackJob.UseVisualStyleBackColor = false;
            this.btnCancelBackJob.Click += new System.EventHandler(this.btnCancelBackJob_Click);

            this.btnSubmitBackJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitBackJob.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSubmitBackJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitBackJob.FlatAppearance.BorderSize = 0;
            this.btnSubmitBackJob.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSubmitBackJob.ForeColor = System.Drawing.Color.White;
            this.btnSubmitBackJob.Location = new System.Drawing.Point(714, 600);
            this.btnSubmitBackJob.Size = new System.Drawing.Size(110, 36);
            this.btnSubmitBackJob.Text = "Create Back Job";
            this.btnSubmitBackJob.UseVisualStyleBackColor = false;
            this.btnSubmitBackJob.Click += new System.EventHandler(this.btnSubmitBackJob_Click);

            this.pnlBackJob.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBackJob.Location = new System.Drawing.Point(0, 0);
            this.pnlBackJob.Size = new System.Drawing.Size(844, 655);
            this.pnlBackJob.Visible = false;
            this.pnlBackJob.Controls.AddRange(new System.Windows.Forms.Control[] {
            this.lblBackJobTitle, this.lblBackJobLinkInfo, this.lblBackJobCustomer, this.lblBackJobVehicle,
            this.lblBackJobOriginalService, this.lblBackJobDate, this.dtpBackJobDate,
            this.lblBackJobMechanic, this.cmbBackJobMechanic, this.btnCancelBackJob, this.btnSubmitBackJob});

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlBackJob);
            this.Controls.Add(this.pnlDetails);
            this.Name = "JobOrderControlptManage";
            this.Size = new System.Drawing.Size(844, 655);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblWarrantyBadge;
        private System.Windows.Forms.Label lblTargetJO;
        private System.Windows.Forms.Label lblTargetCustomer;
        private System.Windows.Forms.Label lblTargetVehicle;
        private System.Windows.Forms.Label lblTargetServiceType;
        private System.Windows.Forms.Label lblTargetMechanic;
        private System.Windows.Forms.Label lblTargetParts;
        private System.Windows.Forms.Label lblTargetNotes;
        private System.Windows.Forms.Label lblUpdateStatus;
        private System.Windows.Forms.ComboBox cmbStatusPicker;
        private System.Windows.Forms.Button btnCreateBackJob;
        private System.Windows.Forms.Button btnSaveStatus;
        private System.Windows.Forms.Button btnCloseDetails;

        private System.Windows.Forms.Panel pnlBackJob;
        private System.Windows.Forms.Label lblBackJobTitle;
        private System.Windows.Forms.Label lblBackJobLinkInfo;
        private System.Windows.Forms.Label lblBackJobCustomer;
        private System.Windows.Forms.Label lblBackJobVehicle;
        private System.Windows.Forms.Label lblBackJobOriginalService;
        private System.Windows.Forms.Label lblBackJobDate;
        private System.Windows.Forms.DateTimePicker dtpBackJobDate;
        private System.Windows.Forms.Label lblBackJobMechanic;
        private System.Windows.Forms.ComboBox cmbBackJobMechanic;
        private System.Windows.Forms.Button btnCancelBackJob;
        private System.Windows.Forms.Button btnSubmitBackJob;
    }
}
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
            this.pnlDetails.SuspendLayout();
            this.pnlBackJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDetails.Controls.Add(this.lblWarrantyBadge);
            this.pnlDetails.Controls.Add(this.lblTargetJO);
            this.pnlDetails.Controls.Add(this.lblTargetCustomer);
            this.pnlDetails.Controls.Add(this.lblTargetVehicle);
            this.pnlDetails.Controls.Add(this.lblTargetServiceType);
            this.pnlDetails.Controls.Add(this.lblTargetMechanic);
            this.pnlDetails.Controls.Add(this.lblTargetParts);
            this.pnlDetails.Controls.Add(this.lblTargetNotes);
            this.pnlDetails.Controls.Add(this.lblUpdateStatus);
            this.pnlDetails.Controls.Add(this.cmbStatusPicker);
            this.pnlDetails.Controls.Add(this.btnCreateBackJob);
            this.pnlDetails.Controls.Add(this.btnSaveStatus);
            this.pnlDetails.Controls.Add(this.btnCloseDetails);
            this.pnlDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(723, 568);
            this.pnlDetails.TabIndex = 1;
            // 
            // lblWarrantyBadge
            // 
            this.lblWarrantyBadge.AutoSize = true;
            this.lblWarrantyBadge.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblWarrantyBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblWarrantyBadge.Location = new System.Drawing.Point(15, 13);
            this.lblWarrantyBadge.Name = "lblWarrantyBadge";
            this.lblWarrantyBadge.Size = new System.Drawing.Size(104, 17);
            this.lblWarrantyBadge.TabIndex = 0;
            this.lblWarrantyBadge.Text = "Warranty active";
            // 
            // lblTargetJO
            // 
            this.lblTargetJO.AutoSize = true;
            this.lblTargetJO.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTargetJO.Location = new System.Drawing.Point(15, 42);
            this.lblTargetJO.Name = "lblTargetJO";
            this.lblTargetJO.Size = new System.Drawing.Size(114, 25);
            this.lblTargetJO.TabIndex = 1;
            this.lblTargetJO.Text = "Job Order: -";
            // 
            // lblTargetCustomer
            // 
            this.lblTargetCustomer.AutoSize = true;
            this.lblTargetCustomer.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTargetCustomer.Location = new System.Drawing.Point(15, 80);
            this.lblTargetCustomer.Name = "lblTargetCustomer";
            this.lblTargetCustomer.Size = new System.Drawing.Size(76, 17);
            this.lblTargetCustomer.TabIndex = 2;
            this.lblTargetCustomer.Text = "Customer: -";
            // 
            // lblTargetVehicle
            // 
            this.lblTargetVehicle.AutoSize = true;
            this.lblTargetVehicle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTargetVehicle.Location = new System.Drawing.Point(15, 106);
            this.lblTargetVehicle.Name = "lblTargetVehicle";
            this.lblTargetVehicle.Size = new System.Drawing.Size(60, 17);
            this.lblTargetVehicle.TabIndex = 3;
            this.lblTargetVehicle.Text = "Vehicle: -";
            // 
            // lblTargetServiceType
            // 
            this.lblTargetServiceType.AutoSize = true;
            this.lblTargetServiceType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTargetServiceType.Location = new System.Drawing.Point(15, 132);
            this.lblTargetServiceType.Name = "lblTargetServiceType";
            this.lblTargetServiceType.Size = new System.Drawing.Size(92, 17);
            this.lblTargetServiceType.TabIndex = 4;
            this.lblTargetServiceType.Text = "Service Type: -";
            // 
            // lblTargetMechanic
            // 
            this.lblTargetMechanic.AutoSize = true;
            this.lblTargetMechanic.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTargetMechanic.Location = new System.Drawing.Point(15, 158);
            this.lblTargetMechanic.Name = "lblTargetMechanic";
            this.lblTargetMechanic.Size = new System.Drawing.Size(75, 17);
            this.lblTargetMechanic.TabIndex = 5;
            this.lblTargetMechanic.Text = "Mechanic: -";
            // 
            // lblTargetParts
            // 
            this.lblTargetParts.AutoSize = true;
            this.lblTargetParts.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTargetParts.Location = new System.Drawing.Point(15, 184);
            this.lblTargetParts.Name = "lblTargetParts";
            this.lblTargetParts.Size = new System.Drawing.Size(83, 17);
            this.lblTargetParts.TabIndex = 6;
            this.lblTargetParts.Text = "Parts Used: -";
            // 
            // lblTargetNotes
            // 
            this.lblTargetNotes.AutoSize = true;
            this.lblTargetNotes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTargetNotes.Location = new System.Drawing.Point(15, 210);
            this.lblTargetNotes.Name = "lblTargetNotes";
            this.lblTargetNotes.Size = new System.Drawing.Size(55, 17);
            this.lblTargetNotes.TabIndex = 7;
            this.lblTargetNotes.Text = "Notes: -";
            // 
            // lblUpdateStatus
            // 
            this.lblUpdateStatus.AutoSize = true;
            this.lblUpdateStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUpdateStatus.Location = new System.Drawing.Point(15, 260);
            this.lblUpdateStatus.Name = "lblUpdateStatus";
            this.lblUpdateStatus.Size = new System.Drawing.Size(98, 17);
            this.lblUpdateStatus.TabIndex = 8;
            this.lblUpdateStatus.Text = "Update Status:";
            // 
            // cmbStatusPicker
            // 
            this.cmbStatusPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusPicker.Location = new System.Drawing.Point(137, 257);
            this.cmbStatusPicker.Name = "cmbStatusPicker";
            this.cmbStatusPicker.Size = new System.Drawing.Size(189, 21);
            this.cmbStatusPicker.TabIndex = 9;
            // 
            // btnCreateBackJob
            // 
            this.btnCreateBackJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnCreateBackJob.FlatAppearance.BorderSize = 0;
            this.btnCreateBackJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBackJob.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCreateBackJob.ForeColor = System.Drawing.Color.White;
            this.btnCreateBackJob.Location = new System.Drawing.Point(15, 303);
            this.btnCreateBackJob.Name = "btnCreateBackJob";
            this.btnCreateBackJob.Size = new System.Drawing.Size(146, 33);
            this.btnCreateBackJob.TabIndex = 10;
            this.btnCreateBackJob.Text = "Create Back Job";
            this.btnCreateBackJob.UseVisualStyleBackColor = false;
            this.btnCreateBackJob.Click += new System.EventHandler(this.btnCreateBackJob_Click);
            // 
            // btnSaveStatus
            // 
            this.btnSaveStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSaveStatus.FlatAppearance.BorderSize = 0;
            this.btnSaveStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSaveStatus.ForeColor = System.Drawing.Color.White;
            this.btnSaveStatus.Location = new System.Drawing.Point(170, 303);
            this.btnSaveStatus.Name = "btnSaveStatus";
            this.btnSaveStatus.Size = new System.Drawing.Size(146, 33);
            this.btnSaveStatus.TabIndex = 11;
            this.btnSaveStatus.Text = "Update Status";
            this.btnSaveStatus.UseVisualStyleBackColor = false;
            this.btnSaveStatus.Click += new System.EventHandler(this.btnSaveStatus_Click);
            // 
            // btnCloseDetails
            // 
            this.btnCloseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCloseDetails.FlatAppearance.BorderSize = 0;
            this.btnCloseDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseDetails.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCloseDetails.ForeColor = System.Drawing.Color.White;
            this.btnCloseDetails.Location = new System.Drawing.Point(612, 520);
            this.btnCloseDetails.Name = "btnCloseDetails";
            this.btnCloseDetails.Size = new System.Drawing.Size(94, 31);
            this.btnCloseDetails.TabIndex = 12;
            this.btnCloseDetails.Text = "Close";
            this.btnCloseDetails.UseVisualStyleBackColor = false;
            this.btnCloseDetails.Click += new System.EventHandler(this.btnCloseDetails_Click);
            // 
            // pnlBackJob
            // 
            this.pnlBackJob.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBackJob.Controls.Add(this.lblBackJobTitle);
            this.pnlBackJob.Controls.Add(this.lblBackJobLinkInfo);
            this.pnlBackJob.Controls.Add(this.lblBackJobCustomer);
            this.pnlBackJob.Controls.Add(this.lblBackJobVehicle);
            this.pnlBackJob.Controls.Add(this.lblBackJobOriginalService);
            this.pnlBackJob.Controls.Add(this.lblBackJobDate);
            this.pnlBackJob.Controls.Add(this.dtpBackJobDate);
            this.pnlBackJob.Controls.Add(this.lblBackJobMechanic);
            this.pnlBackJob.Controls.Add(this.cmbBackJobMechanic);
            this.pnlBackJob.Controls.Add(this.btnCancelBackJob);
            this.pnlBackJob.Controls.Add(this.btnSubmitBackJob);
            this.pnlBackJob.Location = new System.Drawing.Point(0, 0);
            this.pnlBackJob.Name = "pnlBackJob";
            this.pnlBackJob.Size = new System.Drawing.Size(723, 568);
            this.pnlBackJob.TabIndex = 0;
            this.pnlBackJob.Visible = false;
            this.pnlBackJob.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBackJob_Paint);
            // 
            // lblBackJobTitle
            // 
            this.lblBackJobTitle.AutoSize = true;
            this.lblBackJobTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblBackJobTitle.Location = new System.Drawing.Point(15, 13);
            this.lblBackJobTitle.Name = "lblBackJobTitle";
            this.lblBackJobTitle.Size = new System.Drawing.Size(88, 25);
            this.lblBackJobTitle.TabIndex = 0;
            this.lblBackJobTitle.Text = "Back Job";
            // 
            // lblBackJobLinkInfo
            // 
            this.lblBackJobLinkInfo.AutoSize = true;
            this.lblBackJobLinkInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblBackJobLinkInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblBackJobLinkInfo.Location = new System.Drawing.Point(15, 45);
            this.lblBackJobLinkInfo.Name = "lblBackJobLinkInfo";
            this.lblBackJobLinkInfo.Size = new System.Drawing.Size(224, 17);
            this.lblBackJobLinkInfo.TabIndex = 1;
            this.lblBackJobLinkInfo.Text = "Linked to JO-0000 · Warranty valid";
            // 
            // lblBackJobCustomer
            // 
            this.lblBackJobCustomer.AutoSize = true;
            this.lblBackJobCustomer.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBackJobCustomer.Location = new System.Drawing.Point(15, 83);
            this.lblBackJobCustomer.Name = "lblBackJobCustomer";
            this.lblBackJobCustomer.Size = new System.Drawing.Size(76, 17);
            this.lblBackJobCustomer.TabIndex = 2;
            this.lblBackJobCustomer.Text = "Customer: -";
            // 
            // lblBackJobVehicle
            // 
            this.lblBackJobVehicle.AutoSize = true;
            this.lblBackJobVehicle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBackJobVehicle.Location = new System.Drawing.Point(15, 109);
            this.lblBackJobVehicle.Name = "lblBackJobVehicle";
            this.lblBackJobVehicle.Size = new System.Drawing.Size(60, 17);
            this.lblBackJobVehicle.TabIndex = 3;
            this.lblBackJobVehicle.Text = "Vehicle: -";
            // 
            // lblBackJobOriginalService
            // 
            this.lblBackJobOriginalService.AutoSize = true;
            this.lblBackJobOriginalService.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBackJobOriginalService.Location = new System.Drawing.Point(15, 135);
            this.lblBackJobOriginalService.Name = "lblBackJobOriginalService";
            this.lblBackJobOriginalService.Size = new System.Drawing.Size(111, 17);
            this.lblBackJobOriginalService.TabIndex = 4;
            this.lblBackJobOriginalService.Text = "Original Service: -";
            // 
            // lblBackJobDate
            // 
            this.lblBackJobDate.AutoSize = true;
            this.lblBackJobDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBackJobDate.Location = new System.Drawing.Point(15, 180);
            this.lblBackJobDate.Name = "lblBackJobDate";
            this.lblBackJobDate.Size = new System.Drawing.Size(93, 17);
            this.lblBackJobDate.TabIndex = 5;
            this.lblBackJobDate.Text = "Back Job Date:";
            // 
            // dtpBackJobDate
            // 
            this.dtpBackJobDate.Location = new System.Drawing.Point(137, 177);
            this.dtpBackJobDate.Name = "dtpBackJobDate";
            this.dtpBackJobDate.Size = new System.Drawing.Size(189, 20);
            this.dtpBackJobDate.TabIndex = 6;
            // 
            // lblBackJobMechanic
            // 
            this.lblBackJobMechanic.AutoSize = true;
            this.lblBackJobMechanic.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBackJobMechanic.Location = new System.Drawing.Point(15, 217);
            this.lblBackJobMechanic.Name = "lblBackJobMechanic";
            this.lblBackJobMechanic.Size = new System.Drawing.Size(66, 17);
            this.lblBackJobMechanic.TabIndex = 7;
            this.lblBackJobMechanic.Text = "Mechanic:";
            // 
            // cmbBackJobMechanic
            // 
            this.cmbBackJobMechanic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBackJobMechanic.Location = new System.Drawing.Point(137, 213);
            this.cmbBackJobMechanic.Name = "cmbBackJobMechanic";
            this.cmbBackJobMechanic.Size = new System.Drawing.Size(189, 21);
            this.cmbBackJobMechanic.TabIndex = 8;
            // 
            // btnCancelBackJob
            // 
            this.btnCancelBackJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelBackJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancelBackJob.FlatAppearance.BorderSize = 0;
            this.btnCancelBackJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBackJob.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelBackJob.ForeColor = System.Drawing.Color.White;
            this.btnCancelBackJob.Location = new System.Drawing.Point(513, 520);
            this.btnCancelBackJob.Name = "btnCancelBackJob";
            this.btnCancelBackJob.Size = new System.Drawing.Size(94, 31);
            this.btnCancelBackJob.TabIndex = 9;
            this.btnCancelBackJob.Text = "Cancel";
            this.btnCancelBackJob.UseVisualStyleBackColor = false;
            this.btnCancelBackJob.Click += new System.EventHandler(this.btnCancelBackJob_Click);
            // 
            // btnSubmitBackJob
            // 
            this.btnSubmitBackJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitBackJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSubmitBackJob.FlatAppearance.BorderSize = 0;
            this.btnSubmitBackJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitBackJob.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSubmitBackJob.ForeColor = System.Drawing.Color.White;
            this.btnSubmitBackJob.Location = new System.Drawing.Point(612, 520);
            this.btnSubmitBackJob.Name = "btnSubmitBackJob";
            this.btnSubmitBackJob.Size = new System.Drawing.Size(94, 31);
            this.btnSubmitBackJob.TabIndex = 10;
            this.btnSubmitBackJob.Text = "Create Back Job";
            this.btnSubmitBackJob.UseVisualStyleBackColor = false;
            this.btnSubmitBackJob.Click += new System.EventHandler(this.btnSubmitBackJob_Click);
            // 
            // JobOrderControlptManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlBackJob);
            this.Controls.Add(this.pnlDetails);
            this.Name = "JobOrderControlptManage";
            this.Size = new System.Drawing.Size(723, 568);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlBackJob.ResumeLayout(false);
            this.pnlBackJob.PerformLayout();
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
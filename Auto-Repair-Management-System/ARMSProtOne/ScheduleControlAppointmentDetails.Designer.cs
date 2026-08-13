namespace ARMSProtOne
{
    partial class ScheduleControlAppointmentDetails
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
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblDetailDate = new System.Windows.Forms.Label();
            this.lblDetailCustomer = new System.Windows.Forms.Label();
            this.lblDetailVehicle = new System.Windows.Forms.Label();
            this.lblDetailConcern = new System.Windows.Forms.Label();
            this.lblDetailStatus = new System.Windows.Forms.Label();
            this.grpReschedule = new System.Windows.Forms.GroupBox();
            this.lblNewDate = new System.Windows.Forms.Label();
            this.dtpNewDate = new System.Windows.Forms.DateTimePicker();
            this.lblNewTime = new System.Windows.Forms.Label();
            this.cmbNewTime = new System.Windows.Forms.ComboBox();
            this.btnCancelReschedule = new System.Windows.Forms.Button();
            this.btnSetReschedule = new System.Windows.Forms.Button();
            this.btnReschedule = new System.Windows.Forms.Button();
            this.btnStartJob = new System.Windows.Forms.Button();
            this.btnCloseDetails = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.grpReschedule.SuspendLayout();
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
            this.lblTitle.Text = "Appointment Details";

            System.Windows.Forms.AnchorStyles stretch = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));

            // grpInfo
            this.grpInfo.Anchor = stretch;
            this.grpInfo.BackColor = System.Drawing.Color.White;
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpInfo.Location = new System.Drawing.Point(20, 70);
            this.grpInfo.Size = new System.Drawing.Size(804, 195);
            this.grpInfo.Text = "Visit Information";
            this.grpInfo.Controls.Add(this.lblDetailDate);
            this.grpInfo.Controls.Add(this.lblDetailCustomer);
            this.grpInfo.Controls.Add(this.lblDetailVehicle);
            this.grpInfo.Controls.Add(this.lblDetailConcern);
            this.grpInfo.Controls.Add(this.lblDetailStatus);

            System.Drawing.Font infoFont = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDetailDate.AutoSize = true; this.lblDetailDate.Font = infoFont;
            this.lblDetailDate.Location = new System.Drawing.Point(20, 38); this.lblDetailDate.Text = "Date: -";

            this.lblDetailCustomer.AutoSize = true; this.lblDetailCustomer.Font = infoFont;
            this.lblDetailCustomer.Location = new System.Drawing.Point(20, 70); this.lblDetailCustomer.Text = "Customer: -";

            this.lblDetailVehicle.AutoSize = true; this.lblDetailVehicle.Font = infoFont;
            this.lblDetailVehicle.Location = new System.Drawing.Point(20, 102); this.lblDetailVehicle.Text = "Vehicle: -";

            this.lblDetailConcern.AutoSize = true; this.lblDetailConcern.Font = infoFont;
            this.lblDetailConcern.Location = new System.Drawing.Point(20, 134); this.lblDetailConcern.Text = "Concern: -";

            this.lblDetailStatus.AutoSize = true;
            this.lblDetailStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDetailStatus.ForeColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.lblDetailStatus.Location = new System.Drawing.Point(20, 166); this.lblDetailStatus.Text = "Status: -";

            // grpReschedule
            this.grpReschedule.Anchor = stretch;
            this.grpReschedule.BackColor = System.Drawing.Color.White;
            this.grpReschedule.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpReschedule.Location = new System.Drawing.Point(20, 285);
            this.grpReschedule.Size = new System.Drawing.Size(804, 90);
            this.grpReschedule.Text = "Reschedule Visit";
            this.grpReschedule.Controls.Add(this.lblNewDate);
            this.grpReschedule.Controls.Add(this.dtpNewDate);
            this.grpReschedule.Controls.Add(this.lblNewTime);
            this.grpReschedule.Controls.Add(this.cmbNewTime);
            this.grpReschedule.Controls.Add(this.btnCancelReschedule);
            this.grpReschedule.Controls.Add(this.btnSetReschedule);

            this.lblNewDate.AutoSize = true; this.lblNewDate.Font = infoFont;
            this.lblNewDate.Location = new System.Drawing.Point(20, 40); this.lblNewDate.Text = "New Date:";
            this.dtpNewDate.Location = new System.Drawing.Point(110, 36);
            this.dtpNewDate.Size = new System.Drawing.Size(160, 26);

            this.lblNewTime.AutoSize = true; this.lblNewTime.Font = infoFont;
            this.lblNewTime.Location = new System.Drawing.Point(300, 40); this.lblNewTime.Text = "New Time:";
            this.cmbNewTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewTime.Location = new System.Drawing.Point(390, 36);
            this.cmbNewTime.Size = new System.Drawing.Size(130, 26);

            this.btnCancelReschedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelReschedule.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnCancelReschedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelReschedule.FlatAppearance.BorderSize = 0;
            this.btnCancelReschedule.ForeColor = System.Drawing.Color.White;
            this.btnCancelReschedule.Location = new System.Drawing.Point(560, 34);
            this.btnCancelReschedule.Size = new System.Drawing.Size(100, 30);
            this.btnCancelReschedule.Text = "Cancel";
            this.btnCancelReschedule.UseVisualStyleBackColor = false;
            this.btnCancelReschedule.Click += new System.EventHandler(this.btnCancelReschedule_Click);

            this.btnSetReschedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetReschedule.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSetReschedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetReschedule.FlatAppearance.BorderSize = 0;
            this.btnSetReschedule.ForeColor = System.Drawing.Color.White;
            this.btnSetReschedule.Location = new System.Drawing.Point(670, 34);
            this.btnSetReschedule.Size = new System.Drawing.Size(100, 30);
            this.btnSetReschedule.Text = "Set";
            this.btnSetReschedule.UseVisualStyleBackColor = false;
            this.btnSetReschedule.Click += new System.EventHandler(this.btnSetReschedule_Click);

            // action buttons - anchored so they always sit flush with the bottom edge
            this.btnReschedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReschedule.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.btnReschedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReschedule.FlatAppearance.BorderSize = 0;
            this.btnReschedule.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnReschedule.Location = new System.Drawing.Point(20, 600);
            this.btnReschedule.Size = new System.Drawing.Size(140, 36);
            this.btnReschedule.Text = "Reschedule";
            this.btnReschedule.UseVisualStyleBackColor = false;
            this.btnReschedule.Click += new System.EventHandler(this.btnReschedule_Click);

            this.btnStartJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartJob.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnStartJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartJob.FlatAppearance.BorderSize = 0;
            this.btnStartJob.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnStartJob.ForeColor = System.Drawing.Color.White;
            this.btnStartJob.Location = new System.Drawing.Point(170, 600);
            this.btnStartJob.Size = new System.Drawing.Size(140, 36);
            this.btnStartJob.Text = "Start Job";
            this.btnStartJob.UseVisualStyleBackColor = false;
            this.btnStartJob.Click += new System.EventHandler(this.btnStartJob_Click);

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

            // root
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnCloseDetails);
            this.Controls.Add(this.btnStartJob);
            this.Controls.Add(this.btnReschedule);
            this.Controls.Add(this.grpReschedule);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ScheduleControlAppointmentDetails";
            this.Size = new System.Drawing.Size(844, 655);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpReschedule.ResumeLayout(false);
            this.grpReschedule.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblDetailDate;
        private System.Windows.Forms.Label lblDetailCustomer;
        private System.Windows.Forms.Label lblDetailVehicle;
        private System.Windows.Forms.Label lblDetailConcern;
        private System.Windows.Forms.Label lblDetailStatus;
        private System.Windows.Forms.GroupBox grpReschedule;
        private System.Windows.Forms.Label lblNewDate;
        private System.Windows.Forms.DateTimePicker dtpNewDate;
        private System.Windows.Forms.Label lblNewTime;
        private System.Windows.Forms.ComboBox cmbNewTime;
        private System.Windows.Forms.Button btnCancelReschedule;
        private System.Windows.Forms.Button btnSetReschedule;
        private System.Windows.Forms.Button btnReschedule;
        private System.Windows.Forms.Button btnStartJob;
        private System.Windows.Forms.Button btnCloseDetails;
    }
}
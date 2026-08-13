namespace ARMSProtOne
{
    partial class ScheduleControl
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
            this.btnBookAppointment = new System.Windows.Forms.Button();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.lblListCaption = new System.Windows.Forms.Label();
            this.btnViewAppointment = new System.Windows.Forms.Button();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConcern = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(844, 55);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnBookAppointment);

            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(18, 13);
            this.lblTitle.Text = "Home Service Appointments";

            this.btnBookAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBookAppointment.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnBookAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookAppointment.FlatAppearance.BorderSize = 0;
            this.btnBookAppointment.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnBookAppointment.ForeColor = System.Drawing.Color.White;
            this.btnBookAppointment.Location = new System.Drawing.Point(676, 10);
            this.btnBookAppointment.Size = new System.Drawing.Size(150, 35);
            this.btnBookAppointment.Text = "+ Book Appointment";
            this.btnBookAppointment.UseVisualStyleBackColor = false;
            this.btnBookAppointment.Click += new System.EventHandler(this.btnBookAppointment_Click);

            // pnlToolbar
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 55);
            this.pnlToolbar.Size = new System.Drawing.Size(844, 50);
            this.pnlToolbar.Controls.Add(this.lblListCaption);
            this.pnlToolbar.Controls.Add(this.btnViewAppointment);

            this.lblListCaption.AutoSize = true;
            this.lblListCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblListCaption.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.lblListCaption.Location = new System.Drawing.Point(18, 17);
            this.lblListCaption.Text = "Scheduled Visits";

            this.btnViewAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewAppointment.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnViewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAppointment.FlatAppearance.BorderSize = 0;
            this.btnViewAppointment.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnViewAppointment.ForeColor = System.Drawing.Color.White;
            this.btnViewAppointment.Location = new System.Drawing.Point(676, 8);
            this.btnViewAppointment.Size = new System.Drawing.Size(150, 34);
            this.btnViewAppointment.Text = "View Details";
            this.btnViewAppointment.UseVisualStyleBackColor = false;
            this.btnViewAppointment.Click += new System.EventHandler(this.btnViewAppointment_Click);

            // dgvSchedule
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.AllowUserToDeleteRows = false;
            this.dgvSchedule.BackgroundColor = System.Drawing.Color.White;
            this.dgvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSchedule.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.dgvSchedule.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchedule.MultiSelect = false;
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.RowHeadersVisible = false;
            this.dgvSchedule.RowTemplate.Height = 32;
            this.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate, this.colTime, this.colName, this.colVehicle, this.colConcern, this.colStatus});

            this.colDate.HeaderText = "Date"; this.colDate.Name = "colDate";
            this.colTime.HeaderText = "Time"; this.colTime.Name = "colTime";
            this.colName.HeaderText = "Customer"; this.colName.Name = "colName";
            this.colVehicle.HeaderText = "Vehicle"; this.colVehicle.Name = "colVehicle";
            this.colConcern.HeaderText = "Concern"; this.colConcern.Name = "colConcern";
            this.colStatus.HeaderText = "Status"; this.colStatus.Name = "colStatus";

            // root
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ScheduleControl";
            this.Size = new System.Drawing.Size(844, 655);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.ResumeLayout(false);
        }

        public System.Windows.Forms.Panel pnlHeader;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Button btnBookAppointment;
        public System.Windows.Forms.Panel pnlToolbar;
        public System.Windows.Forms.Label lblListCaption;
        public System.Windows.Forms.Button btnViewAppointment;
        public System.Windows.Forms.DataGridView dgvSchedule;
        public System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        public System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        public System.Windows.Forms.DataGridViewTextBoxColumn colName;
        public System.Windows.Forms.DataGridViewTextBoxColumn colVehicle;
        public System.Windows.Forms.DataGridViewTextBoxColumn colConcern;
        public System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
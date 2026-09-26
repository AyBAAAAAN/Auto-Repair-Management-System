namespace ARMSProtOne
{
    partial class ScheduleControlAddBookings
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
            this.grpSchedule = new System.Windows.Forms.GroupBox();
            this.lblApptDate = new System.Windows.Forms.Label();
            this.dtpApptDate = new System.Windows.Forms.DateTimePicker();
            this.lblApptTime = new System.Windows.Forms.Label();
            this.cmbApptTime = new System.Windows.Forms.ComboBox();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblCustContact = new System.Windows.Forms.Label();
            this.txtCustContact = new System.Windows.Forms.TextBox();
            this.lblCustAddress = new System.Windows.Forms.Label();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.grpVehicle = new System.Windows.Forms.GroupBox();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.lblVehicleBrand = new System.Windows.Forms.Label();
            this.txtVehicleBrand = new System.Windows.Forms.TextBox();
            this.lblVehicleModel = new System.Windows.Forms.Label();
            this.txtVehicleModel = new System.Windows.Forms.TextBox();
            this.lblVehicleYear = new System.Windows.Forms.Label();
            this.txtVehicleYear = new System.Windows.Forms.TextBox();
            this.lblConcern = new System.Windows.Forms.Label();
            this.txtConcern = new System.Windows.Forms.TextBox();
            this.lblHomeServiceFee = new System.Windows.Forms.Label();
            this.btnCancelBook = new System.Windows.Forms.Button();
            this.btnSubmitBook = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.grpSchedule.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.grpVehicle.SuspendLayout();
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
            this.lblTitle.Text = "Book Home Service Appointment";

            System.Drawing.Font f = new System.Drawing.Font("Segoe UI", 9F);
            System.Windows.Forms.AnchorStyles stretch = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));

            // grpSchedule
            this.grpSchedule.Anchor = stretch;
            this.grpSchedule.BackColor = System.Drawing.Color.White;
            this.grpSchedule.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpSchedule.Location = new System.Drawing.Point(20, 68);
            this.grpSchedule.Size = new System.Drawing.Size(804, 75);
            this.grpSchedule.Text = "Schedule";
            this.grpSchedule.Controls.Add(this.lblApptDate);
            this.grpSchedule.Controls.Add(this.dtpApptDate);
            this.grpSchedule.Controls.Add(this.lblApptTime);
            this.grpSchedule.Controls.Add(this.cmbApptTime);

            this.lblApptDate.AutoSize = true; this.lblApptDate.Font = f;
            this.lblApptDate.Location = new System.Drawing.Point(20, 36); this.lblApptDate.Text = "Date:";
            this.dtpApptDate.Location = new System.Drawing.Point(110, 32);
            this.dtpApptDate.Size = new System.Drawing.Size(180, 26);

            this.lblApptTime.AutoSize = true; this.lblApptTime.Font = f;
            this.lblApptTime.Location = new System.Drawing.Point(320, 36); this.lblApptTime.Text = "Time:";
            this.cmbApptTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApptTime.Location = new System.Drawing.Point(400, 32);
            this.cmbApptTime.Size = new System.Drawing.Size(180, 26);

            // grpCustomer
            this.grpCustomer.Anchor = stretch;
            this.grpCustomer.BackColor = System.Drawing.Color.White;
            this.grpCustomer.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpCustomer.Location = new System.Drawing.Point(20, 155);
            this.grpCustomer.Size = new System.Drawing.Size(804, 118);
            this.grpCustomer.Text = "Customer Information";
            this.grpCustomer.Controls.Add(this.lblCustName);
            this.grpCustomer.Controls.Add(this.txtCustName);
            this.grpCustomer.Controls.Add(this.lblCustContact);
            this.grpCustomer.Controls.Add(this.txtCustContact);
            this.grpCustomer.Controls.Add(this.lblCustAddress);
            this.grpCustomer.Controls.Add(this.txtCustAddress);

            this.lblCustName.AutoSize = true; this.lblCustName.Font = f;
            this.lblCustName.Location = new System.Drawing.Point(20, 36); this.lblCustName.Text = "Customer Name:*";
            this.txtCustName.Location = new System.Drawing.Point(160, 32);
            this.txtCustName.Size = new System.Drawing.Size(300, 24);

            this.lblCustContact.AutoSize = true; this.lblCustContact.Font = f;
            this.lblCustContact.Location = new System.Drawing.Point(480, 36); this.lblCustContact.Text = "Contact:";
            this.txtCustContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustContact.Location = new System.Drawing.Point(560, 32);
            this.txtCustContact.Size = new System.Drawing.Size(224, 24);

            this.lblCustAddress.AutoSize = true; this.lblCustAddress.Font = f;
            this.lblCustAddress.Location = new System.Drawing.Point(20, 76); this.lblCustAddress.Text = "Address:";
            this.txtCustAddress.Anchor = stretch;
            this.txtCustAddress.Location = new System.Drawing.Point(160, 72);
            this.txtCustAddress.Size = new System.Drawing.Size(624, 24);

            // grpVehicle
            this.grpVehicle.Anchor = stretch;
            this.grpVehicle.BackColor = System.Drawing.Color.White;
            this.grpVehicle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpVehicle.Location = new System.Drawing.Point(20, 283);
            this.grpVehicle.Size = new System.Drawing.Size(804, 118);
            this.grpVehicle.Text = "Vehicle Information";
            this.grpVehicle.Controls.Add(this.lblVehicleType);
            this.grpVehicle.Controls.Add(this.cmbVehicleType);
            this.grpVehicle.Controls.Add(this.lblVehicleBrand);
            this.grpVehicle.Controls.Add(this.txtVehicleBrand);
            this.grpVehicle.Controls.Add(this.lblVehicleModel);
            this.grpVehicle.Controls.Add(this.txtVehicleModel);
            this.grpVehicle.Controls.Add(this.lblVehicleYear);
            this.grpVehicle.Controls.Add(this.txtVehicleYear);

            this.lblVehicleType.AutoSize = true; this.lblVehicleType.Font = f;
            this.lblVehicleType.Location = new System.Drawing.Point(20, 36); this.lblVehicleType.Text = "Type:";
            this.cmbVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleType.Location = new System.Drawing.Point(150, 32);
            this.cmbVehicleType.Size = new System.Drawing.Size(150, 26);

            this.lblVehicleBrand.AutoSize = true; this.lblVehicleBrand.Font = f;
            this.lblVehicleBrand.Location = new System.Drawing.Point(320, 36); this.lblVehicleBrand.Text = "Brand:";
            this.txtVehicleBrand.Location = new System.Drawing.Point(400, 32);
            this.txtVehicleBrand.Size = new System.Drawing.Size(150, 24);

            this.lblVehicleModel.AutoSize = true; this.lblVehicleModel.Font = f;
            this.lblVehicleModel.Location = new System.Drawing.Point(570, 36); this.lblVehicleModel.Text = "Model:";
            this.txtVehicleModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVehicleModel.Location = new System.Drawing.Point(630, 32);
            this.txtVehicleModel.Size = new System.Drawing.Size(154, 24);

            this.lblVehicleYear.AutoSize = true; this.lblVehicleYear.Font = f;
            this.lblVehicleYear.Location = new System.Drawing.Point(20, 76); this.lblVehicleYear.Text = "Year Model:";
            this.txtVehicleYear.Location = new System.Drawing.Point(150, 72);
            this.txtVehicleYear.Size = new System.Drawing.Size(150, 24);

            // concern
            this.lblConcern.AutoSize = true; this.lblConcern.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblConcern.Location = new System.Drawing.Point(20, 415); this.lblConcern.Text = "Customer Concern:";
            this.txtConcern.Anchor = stretch;
            this.txtConcern.Location = new System.Drawing.Point(20, 438);
            this.txtConcern.Size = new System.Drawing.Size(804, 100);
            this.txtConcern.Multiline = true;

            this.lblHomeServiceFee.AutoSize = true;
            this.lblHomeServiceFee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblHomeServiceFee.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblHomeServiceFee.Location = new System.Drawing.Point(20, 548);
            this.lblHomeServiceFee.Text = "Home Service Fee: PHP 500";

            this.btnCancelBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelBook.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnCancelBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBook.FlatAppearance.BorderSize = 0;
            this.btnCancelBook.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelBook.ForeColor = System.Drawing.Color.White;
            this.btnCancelBook.Location = new System.Drawing.Point(598, 600);
            this.btnCancelBook.Size = new System.Drawing.Size(110, 36);
            this.btnCancelBook.Text = "Cancel";
            this.btnCancelBook.UseVisualStyleBackColor = false;
            this.btnCancelBook.Click += new System.EventHandler(this.btnCancelBook_Click);

            this.btnSubmitBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitBook.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSubmitBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitBook.FlatAppearance.BorderSize = 0;
            this.btnSubmitBook.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSubmitBook.ForeColor = System.Drawing.Color.White;
            this.btnSubmitBook.Location = new System.Drawing.Point(714, 600);
            this.btnSubmitBook.Size = new System.Drawing.Size(110, 36);
            this.btnSubmitBook.Text = "Submit";
            this.btnSubmitBook.UseVisualStyleBackColor = false;
            this.btnSubmitBook.Click += new System.EventHandler(this.btnSubmitBook_Click);

            // root
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AutoScroll = true;
            this.Controls.Add(this.btnSubmitBook);
            this.Controls.Add(this.btnCancelBook);
            this.Controls.Add(this.lblHomeServiceFee);
            this.Controls.Add(this.txtConcern);
            this.Controls.Add(this.lblConcern);
            this.Controls.Add(this.grpVehicle);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grpSchedule);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ScheduleControlAddBookings";
            this.Size = new System.Drawing.Size(844, 655);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpSchedule.ResumeLayout(false);
            this.grpSchedule.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpVehicle.ResumeLayout(false);
            this.grpVehicle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpSchedule;
        private System.Windows.Forms.Label lblApptDate;
        private System.Windows.Forms.DateTimePicker dtpApptDate;
        private System.Windows.Forms.Label lblApptTime;
        private System.Windows.Forms.ComboBox cmbApptTime;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblCustContact;
        private System.Windows.Forms.TextBox txtCustContact;
        private System.Windows.Forms.Label lblCustAddress;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.GroupBox grpVehicle;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.Label lblVehicleBrand;
        private System.Windows.Forms.TextBox txtVehicleBrand;
        private System.Windows.Forms.Label lblVehicleModel;
        private System.Windows.Forms.TextBox txtVehicleModel;
        private System.Windows.Forms.Label lblVehicleYear;
        private System.Windows.Forms.TextBox txtVehicleYear;
        private System.Windows.Forms.Label lblConcern;
        private System.Windows.Forms.TextBox txtConcern;
        private System.Windows.Forms.Label lblHomeServiceFee;
        private System.Windows.Forms.Button btnCancelBook;
        private System.Windows.Forms.Button btnSubmitBook;
    }
}
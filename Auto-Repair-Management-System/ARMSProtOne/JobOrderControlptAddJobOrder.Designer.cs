namespace ARMSProtOne
{
    partial class JobOrderControlptAddJobOrder
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblJONumber = new System.Windows.Forms.Label();
            this.txtJONumber = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblVehicleModel = new System.Windows.Forms.Label();
            this.txtVehicleModel = new System.Windows.Forms.TextBox();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.cmbServiceType = new System.Windows.Forms.ComboBox();
            this.lblConcern = new System.Windows.Forms.Label();
            this.txtConcern = new System.Windows.Forms.TextBox();
            this.lblMechanic = new System.Windows.Forms.Label();
            this.cmbMechanic = new System.Windows.Forms.ComboBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.Location = new System.Drawing.Point(18, 15);
            this.lblFormTitle.Text = "Create Job Order";

            this.lblJONumber.AutoSize = true;
            this.lblJONumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblJONumber.Location = new System.Drawing.Point(20, 58);
            this.lblJONumber.Text = "Job Order No.:";
            this.txtJONumber.Location = new System.Drawing.Point(150, 54);
            this.txtJONumber.Size = new System.Drawing.Size(150, 24);
            this.txtJONumber.ReadOnly = true;

            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCustomerName.Location = new System.Drawing.Point(20, 98);
            this.lblCustomerName.Text = "Customer Name:";
            this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCustomerName.Location = new System.Drawing.Point(150, 94);
            this.txtCustomerName.Size = new System.Drawing.Size(340, 24);

            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContact.Location = new System.Drawing.Point(510, 98);
            this.lblContact.Text = "Contact:";
            this.txtContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContact.Location = new System.Drawing.Point(580, 94);
            this.txtContact.Size = new System.Drawing.Size(244, 24);

            this.lblVehicleModel.AutoSize = true;
            this.lblVehicleModel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVehicleModel.Location = new System.Drawing.Point(20, 138);
            this.lblVehicleModel.Text = "Vehicle Model:";
            this.txtVehicleModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtVehicleModel.Location = new System.Drawing.Point(150, 134);
            this.txtVehicleModel.Size = new System.Drawing.Size(340, 24);

            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPlateNumber.Location = new System.Drawing.Point(510, 138);
            this.lblPlateNumber.Text = "Plate No.:*";
            this.txtPlateNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlateNumber.Location = new System.Drawing.Point(580, 134);
            this.txtPlateNumber.Size = new System.Drawing.Size(244, 24);

            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblServiceType.Location = new System.Drawing.Point(20, 178);
            this.lblServiceType.Text = "Service Type:";
            this.cmbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServiceType.Location = new System.Drawing.Point(150, 174);
            this.cmbServiceType.Size = new System.Drawing.Size(340, 24);

            this.lblConcern.AutoSize = true;
            this.lblConcern.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblConcern.Location = new System.Drawing.Point(20, 220);
            this.lblConcern.Text = "Customer Concern / Service Description:";
            this.txtConcern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.txtConcern.Location = new System.Drawing.Point(20, 245);
            this.txtConcern.Size = new System.Drawing.Size(804, 160);
            this.txtConcern.Multiline = true;

            this.lblMechanic.AutoSize = true;
            this.lblMechanic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMechanic.Location = new System.Drawing.Point(20, 420);
            this.lblMechanic.Text = "Mechanic Assigned:";
            this.cmbMechanic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMechanic.Location = new System.Drawing.Point(150, 416);
            this.cmbMechanic.Size = new System.Drawing.Size(340, 24);

            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCost.Location = new System.Drawing.Point(510, 420);
            this.lblCost.Text = "Grand Total (PHP):";
            this.txtCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCost.Location = new System.Drawing.Point(660, 416);
            this.txtCost.Size = new System.Drawing.Size(164, 24);

            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(598, 600);
            this.btnCancel.Size = new System.Drawing.Size(110, 36);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(714, 600);
            this.btnSave.Size = new System.Drawing.Size(110, 36);
            this.btnSave.Text = "Create Job Order";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
            this.lblFormTitle, this.lblJONumber, this.txtJONumber,
            this.lblCustomerName, this.txtCustomerName, this.lblContact, this.txtContact,
            this.lblVehicleModel, this.txtVehicleModel, this.lblPlateNumber, this.txtPlateNumber,
            this.lblServiceType, this.cmbServiceType, this.lblConcern, this.txtConcern,
            this.lblMechanic, this.cmbMechanic, this.lblCost, this.txtCost,
            this.btnCancel, this.btnSave});
            this.Name = "JobOrderControlptAddJobOrder";
            this.Size = new System.Drawing.Size(844, 655);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblJONumber;
        private System.Windows.Forms.TextBox txtJONumber;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblVehicleModel;
        private System.Windows.Forms.TextBox txtVehicleModel;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.ComboBox cmbServiceType;
        private System.Windows.Forms.Label lblConcern;
        private System.Windows.Forms.TextBox txtConcern;
        private System.Windows.Forms.Label lblMechanic;
        private System.Windows.Forms.ComboBox cmbMechanic;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}
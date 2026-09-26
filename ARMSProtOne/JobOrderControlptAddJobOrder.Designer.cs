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
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.Location = new System.Drawing.Point(15, 13);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(156, 25);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Create Job Order";
            // 
            // lblJONumber
            // 
            this.lblJONumber.AutoSize = true;
            this.lblJONumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblJONumber.Location = new System.Drawing.Point(17, 50);
            this.lblJONumber.Name = "lblJONumber";
            this.lblJONumber.Size = new System.Drawing.Size(83, 15);
            this.lblJONumber.TabIndex = 1;
            this.lblJONumber.Text = "Job Order No.:";
            // 
            // txtJONumber
            // 
            this.txtJONumber.Location = new System.Drawing.Point(129, 47);
            this.txtJONumber.Name = "txtJONumber";
            this.txtJONumber.ReadOnly = true;
            this.txtJONumber.Size = new System.Drawing.Size(129, 20);
            this.txtJONumber.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCustomerName.Location = new System.Drawing.Point(17, 85);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(97, 15);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(129, 81);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(292, 20);
            this.txtCustomerName.TabIndex = 4;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContact.Location = new System.Drawing.Point(437, 85);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(52, 15);
            this.lblContact.TabIndex = 5;
            this.lblContact.Text = "Contact:";
            // 
            // txtContact
            // 
            this.txtContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContact.Location = new System.Drawing.Point(497, 81);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(210, 20);
            this.txtContact.TabIndex = 6;
            // 
            // lblVehicleModel
            // 
            this.lblVehicleModel.AutoSize = true;
            this.lblVehicleModel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVehicleModel.Location = new System.Drawing.Point(17, 120);
            this.lblVehicleModel.Name = "lblVehicleModel";
            this.lblVehicleModel.Size = new System.Drawing.Size(84, 15);
            this.lblVehicleModel.TabIndex = 7;
            this.lblVehicleModel.Text = "Vehicle Model:";
            // 
            // txtVehicleModel
            // 
            this.txtVehicleModel.Location = new System.Drawing.Point(129, 116);
            this.txtVehicleModel.Name = "txtVehicleModel";
            this.txtVehicleModel.Size = new System.Drawing.Size(292, 20);
            this.txtVehicleModel.TabIndex = 8;
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPlateNumber.Location = new System.Drawing.Point(437, 120);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(63, 15);
            this.lblPlateNumber.TabIndex = 9;
            this.lblPlateNumber.Text = "Plate No.:*";
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlateNumber.Location = new System.Drawing.Point(497, 116);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(210, 20);
            this.txtPlateNumber.TabIndex = 10;
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblServiceType.Location = new System.Drawing.Point(17, 154);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(74, 15);
            this.lblServiceType.TabIndex = 11;
            this.lblServiceType.Text = "Service Type:";
            // 
            // cmbServiceType
            // 
            this.cmbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServiceType.Location = new System.Drawing.Point(129, 151);
            this.cmbServiceType.Name = "cmbServiceType";
            this.cmbServiceType.Size = new System.Drawing.Size(292, 21);
            this.cmbServiceType.TabIndex = 12;
            // 
            // lblConcern
            // 
            this.lblConcern.AutoSize = true;
            this.lblConcern.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblConcern.Location = new System.Drawing.Point(17, 191);
            this.lblConcern.Name = "lblConcern";
            this.lblConcern.Size = new System.Drawing.Size(258, 17);
            this.lblConcern.TabIndex = 13;
            this.lblConcern.Text = "Customer Concern / Service Description:";
            // 
            // txtConcern
            // 
            this.txtConcern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConcern.Location = new System.Drawing.Point(17, 212);
            this.txtConcern.Multiline = true;
            this.txtConcern.Name = "txtConcern";
            this.txtConcern.Size = new System.Drawing.Size(690, 139);
            this.txtConcern.TabIndex = 14;
            // 
            // lblMechanic
            // 
            this.lblMechanic.AutoSize = true;
            this.lblMechanic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMechanic.Location = new System.Drawing.Point(17, 364);
            this.lblMechanic.Name = "lblMechanic";
            this.lblMechanic.Size = new System.Drawing.Size(113, 15);
            this.lblMechanic.TabIndex = 15;
            this.lblMechanic.Text = "Mechanic Assigned:";
            // 
            // cmbMechanic
            // 
            this.cmbMechanic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMechanic.Location = new System.Drawing.Point(129, 361);
            this.cmbMechanic.Name = "cmbMechanic";
            this.cmbMechanic.Size = new System.Drawing.Size(292, 21);
            this.cmbMechanic.TabIndex = 16;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCost.Location = new System.Drawing.Point(437, 364);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(104, 15);
            this.lblCost.TabIndex = 17;
            this.lblCost.Text = "Grand Total (PHP):";
            // 
            // txtCost
            // 
            this.txtCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCost.Location = new System.Drawing.Point(566, 361);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(141, 20);
            this.txtCost.TabIndex = 18;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(513, 520);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 31);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(612, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 31);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Create Job Order";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // JobOrderControlptAddJobOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.lblJONumber);
            this.Controls.Add(this.txtJONumber);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblVehicleModel);
            this.Controls.Add(this.txtVehicleModel);
            this.Controls.Add(this.lblPlateNumber);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.cmbServiceType);
            this.Controls.Add(this.lblConcern);
            this.Controls.Add(this.txtConcern);
            this.Controls.Add(this.lblMechanic);
            this.Controls.Add(this.cmbMechanic);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "JobOrderControlptAddJobOrder";
            this.Size = new System.Drawing.Size(723, 568);
            this.Load += new System.EventHandler(this.JobOrderControlptAddJobOrder_Load);
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
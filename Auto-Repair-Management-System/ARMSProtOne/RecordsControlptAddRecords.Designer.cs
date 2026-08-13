namespace ARMSProtOne
{
    partial class RecordsControlptAddRecords
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlFormHeader = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.grpOwnerInfo = new System.Windows.Forms.GroupBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.grpVehicleInfo = new System.Windows.Forms.GroupBox();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.txtVehicleModel = new System.Windows.Forms.TextBox();
            this.lblVehicleModel = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlFormHeader.SuspendLayout();
            this.grpOwnerInfo.SuspendLayout();
            this.grpVehicleInfo.SuspendLayout();
            this.SuspendLayout();

            // pnlFormHeader
            this.pnlFormHeader.BackColor = System.Drawing.Color.White;
            this.pnlFormHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormHeader.Controls.Add(this.lblFormTitle);
            this.pnlFormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(844, 55);
            this.pnlFormHeader.TabIndex = 0;

            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblFormTitle.Location = new System.Drawing.Point(18, 15);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Text = "Customer File Registration Wizard";

            // grpOwnerInfo
            this.grpOwnerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.grpOwnerInfo.BackColor = System.Drawing.Color.White;
            this.grpOwnerInfo.Controls.Add(this.txtContactNumber);
            this.grpOwnerInfo.Controls.Add(this.lblContactNumber);
            this.grpOwnerInfo.Controls.Add(this.txtCustomerName);
            this.grpOwnerInfo.Controls.Add(this.lblCustomerName);
            this.grpOwnerInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpOwnerInfo.Location = new System.Drawing.Point(20, 72);
            this.grpOwnerInfo.Name = "grpOwnerInfo";
            this.grpOwnerInfo.Size = new System.Drawing.Size(804, 130);
            this.grpOwnerInfo.TabIndex = 1;
            this.grpOwnerInfo.TabStop = false;
            this.grpOwnerInfo.Text = "Customer Profile Context Details";

            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCustomerName.Location = new System.Drawing.Point(20, 38);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Text = "Full Owner Name:*";

            this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCustomerName.Location = new System.Drawing.Point(180, 34);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(600, 26);
            this.txtCustomerName.TabIndex = 1;

            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContactNumber.Location = new System.Drawing.Point(20, 82);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Text = "Contact Number:";

            this.txtContactNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.txtContactNumber.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtContactNumber.Location = new System.Drawing.Point(180, 78);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(600, 26);
            this.txtContactNumber.TabIndex = 3;

            // grpVehicleInfo
            this.grpVehicleInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.grpVehicleInfo.BackColor = System.Drawing.Color.White;
            this.grpVehicleInfo.Controls.Add(this.txtPlateNumber);
            this.grpVehicleInfo.Controls.Add(this.lblPlateNumber);
            this.grpVehicleInfo.Controls.Add(this.txtVehicleModel);
            this.grpVehicleInfo.Controls.Add(this.lblVehicleModel);
            this.grpVehicleInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpVehicleInfo.Location = new System.Drawing.Point(20, 215);
            this.grpVehicleInfo.Name = "grpVehicleInfo";
            this.grpVehicleInfo.Size = new System.Drawing.Size(804, 130);
            this.grpVehicleInfo.TabIndex = 2;
            this.grpVehicleInfo.TabStop = false;
            this.grpVehicleInfo.Text = "Vehicle Information Mapping Properties";

            this.lblVehicleModel.AutoSize = true;
            this.lblVehicleModel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVehicleModel.Location = new System.Drawing.Point(20, 38);
            this.lblVehicleModel.Name = "lblVehicleModel";
            this.lblVehicleModel.Text = "Vehicle Make/Model:";

            this.txtVehicleModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.txtVehicleModel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtVehicleModel.Location = new System.Drawing.Point(180, 34);
            this.txtVehicleModel.Name = "txtVehicleModel";
            this.txtVehicleModel.Size = new System.Drawing.Size(600, 26);
            this.txtVehicleModel.TabIndex = 1;

            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPlateNumber.Location = new System.Drawing.Point(20, 82);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Text = "Plate Number:*";

            this.txtPlateNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            this.txtPlateNumber.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPlateNumber.Location = new System.Drawing.Point(180, 78);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(600, 26);
            this.txtPlateNumber.TabIndex = 3;

            // buttons - anchored to bottom so they track the panel edge instead of floating mid-page
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(598, 600);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save Entry";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(714, 600);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 36);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // root
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpVehicleInfo);
            this.Controls.Add(this.grpOwnerInfo);
            this.Controls.Add(this.pnlFormHeader);
            this.Name = "AddCustomerControl";
            this.Size = new System.Drawing.Size(844, 655);
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
            this.grpOwnerInfo.ResumeLayout(false);
            this.grpOwnerInfo.PerformLayout();
            this.grpVehicleInfo.ResumeLayout(false);
            this.grpVehicleInfo.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlFormHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.GroupBox grpOwnerInfo;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.GroupBox grpVehicleInfo;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.TextBox txtVehicleModel;
        private System.Windows.Forms.Label lblVehicleModel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
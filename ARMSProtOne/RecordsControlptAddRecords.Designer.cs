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
            // 
            // pnlFormHeader
            // 
            this.pnlFormHeader.BackColor = System.Drawing.Color.White;
            this.pnlFormHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormHeader.Controls.Add(this.lblFormTitle);
            this.pnlFormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(723, 48);
            this.pnlFormHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblFormTitle.Location = new System.Drawing.Point(15, 13);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(301, 25);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Customer File Registration Wizard";
            // 
            // grpOwnerInfo
            // 
            this.grpOwnerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOwnerInfo.BackColor = System.Drawing.Color.White;
            this.grpOwnerInfo.Controls.Add(this.txtContactNumber);
            this.grpOwnerInfo.Controls.Add(this.lblContactNumber);
            this.grpOwnerInfo.Controls.Add(this.txtCustomerName);
            this.grpOwnerInfo.Controls.Add(this.lblCustomerName);
            this.grpOwnerInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpOwnerInfo.Location = new System.Drawing.Point(17, 62);
            this.grpOwnerInfo.Name = "grpOwnerInfo";
            this.grpOwnerInfo.Size = new System.Drawing.Size(689, 113);
            this.grpOwnerInfo.TabIndex = 1;
            this.grpOwnerInfo.TabStop = false;
            this.grpOwnerInfo.Text = "Customer Profile Context Details";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContactNumber.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtContactNumber.Location = new System.Drawing.Point(154, 68);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(515, 24);
            this.txtContactNumber.TabIndex = 3;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContactNumber.Location = new System.Drawing.Point(17, 71);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(99, 15);
            this.lblContactNumber.TabIndex = 4;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCustomerName.Location = new System.Drawing.Point(154, 29);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(515, 24);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCustomerName.Location = new System.Drawing.Point(17, 33);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(107, 15);
            this.lblCustomerName.TabIndex = 5;
            this.lblCustomerName.Text = "Full Owner Name:*";
            // 
            // grpVehicleInfo
            // 
            this.grpVehicleInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpVehicleInfo.BackColor = System.Drawing.Color.White;
            this.grpVehicleInfo.Controls.Add(this.txtPlateNumber);
            this.grpVehicleInfo.Controls.Add(this.lblPlateNumber);
            this.grpVehicleInfo.Controls.Add(this.txtVehicleModel);
            this.grpVehicleInfo.Controls.Add(this.lblVehicleModel);
            this.grpVehicleInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpVehicleInfo.Location = new System.Drawing.Point(17, 186);
            this.grpVehicleInfo.Name = "grpVehicleInfo";
            this.grpVehicleInfo.Size = new System.Drawing.Size(689, 113);
            this.grpVehicleInfo.TabIndex = 2;
            this.grpVehicleInfo.TabStop = false;
            this.grpVehicleInfo.Text = "Vehicle Information Mapping Properties";
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlateNumber.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPlateNumber.Location = new System.Drawing.Point(154, 68);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(515, 24);
            this.txtPlateNumber.TabIndex = 3;
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPlateNumber.Location = new System.Drawing.Point(17, 71);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(88, 15);
            this.lblPlateNumber.TabIndex = 4;
            this.lblPlateNumber.Text = "Plate Number:*";
            // 
            // txtVehicleModel
            // 
            this.txtVehicleModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVehicleModel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtVehicleModel.Location = new System.Drawing.Point(154, 29);
            this.txtVehicleModel.Name = "txtVehicleModel";
            this.txtVehicleModel.Size = new System.Drawing.Size(515, 24);
            this.txtVehicleModel.TabIndex = 1;
            // 
            // lblVehicleModel
            // 
            this.lblVehicleModel.AutoSize = true;
            this.lblVehicleModel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVehicleModel.Location = new System.Drawing.Point(17, 33);
            this.lblVehicleModel.Name = "lblVehicleModel";
            this.lblVehicleModel.Size = new System.Drawing.Size(118, 15);
            this.lblVehicleModel.TabIndex = 5;
            this.lblVehicleModel.Text = "Vehicle Make/Model:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(513, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save Entry";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(612, 520);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RecordsControlptAddRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpVehicleInfo);
            this.Controls.Add(this.grpOwnerInfo);
            this.Controls.Add(this.pnlFormHeader);
            this.Name = "RecordsControlptAddRecords";
            this.Size = new System.Drawing.Size(723, 568);
            this.Load += new System.EventHandler(this.RecordsControlptAddRecords_Load);
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
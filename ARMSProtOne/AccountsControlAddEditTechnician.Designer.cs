namespace ARMSProtOne
{
    partial class AccountsControlAddEditTechnician
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
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btnCancelTech = new System.Windows.Forms.Button();
            this.btnDeleteTech = new System.Windows.Forms.Button();
            this.btnSaveTech = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.Location = new System.Drawing.Point(15, 13);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(183, 25);
            this.lblFormTitle.TabIndex = 7;
            this.lblFormTitle.Text = "Add/Edit Technician";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(17, 52);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(57, 13);
            this.lblFullName.TabIndex = 6;
            this.lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(129, 49);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(343, 20);
            this.txtFullName.TabIndex = 5;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(17, 87);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(87, 13);
            this.lblContact.TabIndex = 4;
            this.lblContact.Text = "Contact Number:";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(129, 84);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(172, 20);
            this.txtContact.TabIndex = 3;
            // 
            // btnCancelTech
            // 
            this.btnCancelTech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancelTech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTech.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelTech.ForeColor = System.Drawing.Color.White;
            this.btnCancelTech.Location = new System.Drawing.Point(410, 520);
            this.btnCancelTech.Name = "btnCancelTech";
            this.btnCancelTech.Size = new System.Drawing.Size(86, 30);
            this.btnCancelTech.TabIndex = 2;
            this.btnCancelTech.Text = "Cancel";
            this.btnCancelTech.UseVisualStyleBackColor = false;
            this.btnCancelTech.Click += new System.EventHandler(this.btnCancelTech_Click);
            // 
            // btnDeleteTech
            // 
            this.btnDeleteTech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteTech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTech.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDeleteTech.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTech.Location = new System.Drawing.Point(506, 520);
            this.btnDeleteTech.Name = "btnDeleteTech";
            this.btnDeleteTech.Size = new System.Drawing.Size(94, 30);
            this.btnDeleteTech.TabIndex = 1;
            this.btnDeleteTech.Text = "Delete";
            this.btnDeleteTech.UseVisualStyleBackColor = false;
            this.btnDeleteTech.Click += new System.EventHandler(this.btnDeleteTech_Click);
            // 
            // btnSaveTech
            // 
            this.btnSaveTech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSaveTech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTech.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSaveTech.ForeColor = System.Drawing.Color.White;
            this.btnSaveTech.Location = new System.Drawing.Point(612, 520);
            this.btnSaveTech.Name = "btnSaveTech";
            this.btnSaveTech.Size = new System.Drawing.Size(94, 30);
            this.btnSaveTech.TabIndex = 0;
            this.btnSaveTech.Text = "Save Technician";
            this.btnSaveTech.UseVisualStyleBackColor = false;
            this.btnSaveTech.Click += new System.EventHandler(this.btnSaveTech_Click);
            // 
            // AccountsControlAddEditTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnSaveTech);
            this.Controls.Add(this.btnDeleteTech);
            this.Controls.Add(this.btnCancelTech);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblFormTitle);
            this.Name = "AccountsControlAddEditTechnician";
            this.Size = new System.Drawing.Size(723, 568);
            this.Load += new System.EventHandler(this.AccountsControlAddEditTechnician_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Button btnCancelTech;
        private System.Windows.Forms.Button btnDeleteTech;
        private System.Windows.Forms.Button btnSaveTech;
    }
}
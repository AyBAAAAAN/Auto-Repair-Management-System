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

            // ===== ADD/EDIT TECHNICIAN =====
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.Location = new System.Drawing.Point(18, 15);
            this.lblFormTitle.Text = "Add/Edit Technician";

            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(20, 60);
            this.lblFullName.Text = "Full Name:";
            this.txtFullName.Location = new System.Drawing.Point(150, 57);
            this.txtFullName.Size = new System.Drawing.Size(400, 24);

            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(20, 100);
            this.lblContact.Text = "Contact Number:";
            this.txtContact.Location = new System.Drawing.Point(150, 97);
            this.txtContact.Size = new System.Drawing.Size(200, 24);

            this.btnCancelTech.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnCancelTech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTech.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelTech.ForeColor = System.Drawing.Color.White;
            this.btnCancelTech.Location = new System.Drawing.Point(478, 600);
            this.btnCancelTech.Size = new System.Drawing.Size(100, 35);
            this.btnCancelTech.Text = "Cancel";
            this.btnCancelTech.UseVisualStyleBackColor = false;
            this.btnCancelTech.Click += new System.EventHandler(this.btnCancelTech_Click);

            this.btnDeleteTech.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDeleteTech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTech.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDeleteTech.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTech.Location = new System.Drawing.Point(590, 600);
            this.btnDeleteTech.Size = new System.Drawing.Size(110, 35);
            this.btnDeleteTech.Text = "Delete";
            this.btnDeleteTech.UseVisualStyleBackColor = false;
            this.btnDeleteTech.Click += new System.EventHandler(this.btnDeleteTech_Click);

            this.btnSaveTech.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSaveTech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTech.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSaveTech.ForeColor = System.Drawing.Color.White;
            this.btnSaveTech.Location = new System.Drawing.Point(714, 600);
            this.btnSaveTech.Size = new System.Drawing.Size(110, 35);
            this.btnSaveTech.Text = "Save Technician";
            this.btnSaveTech.UseVisualStyleBackColor = false;
            this.btnSaveTech.Click += new System.EventHandler(this.btnSaveTech_Click);

            // ===== ROOT =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
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
            this.Size = new System.Drawing.Size(844, 655);
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
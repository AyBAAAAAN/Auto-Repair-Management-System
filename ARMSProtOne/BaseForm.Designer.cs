namespace ARMSProtOne
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.lblAdminSection = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnJobOrder = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnlHeader.Controls.Add(this.lblUserRole);
            this.pnlHeader.Controls.Add(this.lblCompanyName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(974, 39);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblUserRole
            // 
            this.lblUserRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUserRole.ForeColor = System.Drawing.Color.White;
            this.lblUserRole.Location = new System.Drawing.Point(919, 12);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(53, 19);
            this.lblUserRole.TabIndex = 1;
            this.lblUserRole.Text = "Admin";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCompanyName.ForeColor = System.Drawing.Color.White;
            this.lblCompanyName.Location = new System.Drawing.Point(13, 10);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(284, 21);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Arias Cruz Car Aircon Auto Electrical";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnAccounts);
            this.pnlSidebar.Controls.Add(this.btnReport);
            this.pnlSidebar.Controls.Add(this.btnInventory);
            this.pnlSidebar.Controls.Add(this.lblAdminSection);
            this.pnlSidebar.Controls.Add(this.btnPayment);
            this.pnlSidebar.Controls.Add(this.btnSchedule);
            this.pnlSidebar.Controls.Add(this.btnJobOrder);
            this.pnlSidebar.Controls.Add(this.btnRecord);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 39);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(154, 622);
            this.pnlSidebar.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.Location = new System.Drawing.Point(0, 286);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(154, 29);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccounts.FlatAppearance.BorderSize = 0;
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnAccounts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAccounts.Location = new System.Drawing.Point(0, 257);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnAccounts.Size = new System.Drawing.Size(154, 29);
            this.btnAccounts.TabIndex = 8;
            this.btnAccounts.Text = "Accounts";
            this.btnAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounts.UseVisualStyleBackColor = false;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnReport.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReport.Location = new System.Drawing.Point(0, 228);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(154, 29);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnInventory.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInventory.Location = new System.Drawing.Point(0, 199);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(154, 29);
            this.btnInventory.TabIndex = 6;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // lblAdminSection
            // 
            this.lblAdminSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAdminSection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAdminSection.ForeColor = System.Drawing.Color.Silver;
            this.lblAdminSection.Location = new System.Drawing.Point(0, 175);
            this.lblAdminSection.Name = "lblAdminSection";
            this.lblAdminSection.Padding = new System.Windows.Forms.Padding(17, 7, 0, 0);
            this.lblAdminSection.Size = new System.Drawing.Size(154, 24);
            this.lblAdminSection.TabIndex = 5;
            this.lblAdminSection.Text = "Admin";
            // 
            // btnPayment
            // 
            this.btnPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(0, 140);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnPayment.Size = new System.Drawing.Size(154, 35);
            this.btnPayment.TabIndex = 4;
            this.btnPayment.Text = "Payment";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Location = new System.Drawing.Point(0, 105);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnSchedule.Size = new System.Drawing.Size(154, 35);
            this.btnSchedule.TabIndex = 3;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnJobOrder
            // 
            this.btnJobOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJobOrder.FlatAppearance.BorderSize = 0;
            this.btnJobOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJobOrder.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnJobOrder.ForeColor = System.Drawing.Color.White;
            this.btnJobOrder.Location = new System.Drawing.Point(0, 70);
            this.btnJobOrder.Name = "btnJobOrder";
            this.btnJobOrder.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnJobOrder.Size = new System.Drawing.Size(154, 35);
            this.btnJobOrder.TabIndex = 2;
            this.btnJobOrder.Text = "Job Order";
            this.btnJobOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJobOrder.UseVisualStyleBackColor = false;
            this.btnJobOrder.Click += new System.EventHandler(this.btnJobOrder_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnRecord.ForeColor = System.Drawing.Color.White;
            this.btnRecord.Location = new System.Drawing.Point(0, 35);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnRecord.Size = new System.Drawing.Size(154, 35);
            this.btnRecord.TabIndex = 1;
            this.btnRecord.Text = "Record";
            this.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(154, 35);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(154, 39);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(820, 622);
            this.pnlContent.TabIndex = 2;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 661);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(990, 700);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arias Cruz Car Aircon Auto Electrical";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

#endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Label lblAdminSection;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnJobOrder;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnDashboard;

        // This is the panel every sidebar button loads a module
        // UserControl into (see LoadControl() in BaseForm.cs).
        private System.Windows.Forms.Panel pnlContent;
    }
}


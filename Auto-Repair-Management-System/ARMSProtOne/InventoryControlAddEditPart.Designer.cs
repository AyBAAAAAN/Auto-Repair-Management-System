namespace ARMSProtOne
{
    partial class InventoryControlAddEditPart
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblAEPTitle = new System.Windows.Forms.Label();
            this.lblItemNameAEP = new System.Windows.Forms.Label();
            this.txtItemNameAEP = new System.Windows.Forms.TextBox();
            this.lblCategoryAEP = new System.Windows.Forms.Label();
            this.cmbCategoryAEP = new System.Windows.Forms.ComboBox();
            this.lblModelAEP = new System.Windows.Forms.Label();
            this.txtModelAEP = new System.Windows.Forms.TextBox();
            this.lblQtyAEP = new System.Windows.Forms.Label();
            this.txtQtyAEP = new System.Windows.Forms.TextBox();
            this.lblPriceAEP = new System.Windows.Forms.Label();
            this.txtPriceAEP = new System.Windows.Forms.TextBox();
            this.btnCancelAEP = new System.Windows.Forms.Button();
            this.btnRemoveAEP = new System.Windows.Forms.Button();
            this.btnSaveAEP = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // ===== ADD/EDIT PART =====
            this.lblAEPTitle.AutoSize = true;
            this.lblAEPTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblAEPTitle.Location = new System.Drawing.Point(18, 15);
            this.lblAEPTitle.Text = "Add / Edit Parts";

            this.lblItemNameAEP.AutoSize = true;
            this.lblItemNameAEP.Location = new System.Drawing.Point(20, 60);
            this.lblItemNameAEP.Text = "Item Name:";
            this.txtItemNameAEP.Location = new System.Drawing.Point(150, 57);
            this.txtItemNameAEP.Size = new System.Drawing.Size(400, 24);

            this.lblCategoryAEP.AutoSize = true;
            this.lblCategoryAEP.Location = new System.Drawing.Point(20, 100);
            this.lblCategoryAEP.Text = "Category:";
            this.cmbCategoryAEP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryAEP.Location = new System.Drawing.Point(150, 97);
            this.cmbCategoryAEP.Size = new System.Drawing.Size(200, 24);

            this.lblModelAEP.AutoSize = true;
            this.lblModelAEP.Location = new System.Drawing.Point(400, 100);
            this.lblModelAEP.Text = "Model (Optional):";
            this.txtModelAEP.Location = new System.Drawing.Point(530, 97);
            this.txtModelAEP.Size = new System.Drawing.Size(150, 24);

            this.lblQtyAEP.AutoSize = true;
            this.lblQtyAEP.Location = new System.Drawing.Point(20, 140);
            this.lblQtyAEP.Text = "Quantity:";
            this.txtQtyAEP.Location = new System.Drawing.Point(150, 137);
            this.txtQtyAEP.Size = new System.Drawing.Size(150, 24);

            this.lblPriceAEP.AutoSize = true;
            this.lblPriceAEP.Location = new System.Drawing.Point(400, 140);
            this.lblPriceAEP.Text = "Price:";
            this.txtPriceAEP.Location = new System.Drawing.Point(530, 137);
            this.txtPriceAEP.Size = new System.Drawing.Size(150, 24);

            this.btnCancelAEP.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnCancelAEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAEP.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelAEP.ForeColor = System.Drawing.Color.White;
            this.btnCancelAEP.Location = new System.Drawing.Point(478, 600);
            this.btnCancelAEP.Size = new System.Drawing.Size(100, 35);
            this.btnCancelAEP.Text = "Cancel";
            this.btnCancelAEP.UseVisualStyleBackColor = false;

            this.btnRemoveAEP.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnRemoveAEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAEP.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRemoveAEP.ForeColor = System.Drawing.Color.White;
            this.btnRemoveAEP.Location = new System.Drawing.Point(590, 600);
            this.btnRemoveAEP.Size = new System.Drawing.Size(110, 35);
            this.btnRemoveAEP.Text = "Remove";
            this.btnRemoveAEP.UseVisualStyleBackColor = false;

            this.btnSaveAEP.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSaveAEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAEP.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSaveAEP.ForeColor = System.Drawing.Color.White;
            this.btnSaveAEP.Location = new System.Drawing.Point(714, 600);
            this.btnSaveAEP.Size = new System.Drawing.Size(110, 35);
            this.btnSaveAEP.Text = "Save to Inventory";
            this.btnSaveAEP.UseVisualStyleBackColor = false;

            // ===== ROOT =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnSaveAEP);
            this.Controls.Add(this.btnRemoveAEP);
            this.Controls.Add(this.btnCancelAEP);
            this.Controls.Add(this.txtPriceAEP);
            this.Controls.Add(this.lblPriceAEP);
            this.Controls.Add(this.txtQtyAEP);
            this.Controls.Add(this.lblQtyAEP);
            this.Controls.Add(this.txtModelAEP);
            this.Controls.Add(this.lblModelAEP);
            this.Controls.Add(this.cmbCategoryAEP);
            this.Controls.Add(this.lblCategoryAEP);
            this.Controls.Add(this.txtItemNameAEP);
            this.Controls.Add(this.lblItemNameAEP);
            this.Controls.Add(this.lblAEPTitle);
            this.Name = "InventoryControlAddEditPart";
            this.Size = new System.Drawing.Size(844, 655);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.Label lblAEPTitle;
        public System.Windows.Forms.Label lblItemNameAEP;
        public System.Windows.Forms.TextBox txtItemNameAEP;
        public System.Windows.Forms.Label lblCategoryAEP;
        public System.Windows.Forms.ComboBox cmbCategoryAEP;
        public System.Windows.Forms.Label lblModelAEP;
        public System.Windows.Forms.TextBox txtModelAEP;
        public System.Windows.Forms.Label lblQtyAEP;
        public System.Windows.Forms.TextBox txtQtyAEP;
        public System.Windows.Forms.Label lblPriceAEP;
        public System.Windows.Forms.TextBox txtPriceAEP;
        public System.Windows.Forms.Button btnCancelAEP;
        public System.Windows.Forms.Button btnRemoveAEP;
        public System.Windows.Forms.Button btnSaveAEP;
    }
}
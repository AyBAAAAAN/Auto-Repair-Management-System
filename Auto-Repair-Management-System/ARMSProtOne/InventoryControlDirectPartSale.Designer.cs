namespace ARMSProtOne
{
    partial class InventoryControlDirectPartSale
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblDPSTitle = new System.Windows.Forms.Label();
            this.lblDPSCustomer = new System.Windows.Forms.Label();
            this.txtDPSCustomer = new System.Windows.Forms.TextBox();
            this.dgvDPSItems = new System.Windows.Forms.DataGridView();
            this.colDPSItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDPSCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDPSPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDPSQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDPSUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddItemDPS = new System.Windows.Forms.Button();
            this.btnCancelDPS = new System.Windows.Forms.Button();
            this.btnCompleteSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDPSItems)).BeginInit();
            this.SuspendLayout();

            // ===== DIRECT PART SALE =====
            this.lblDPSTitle.AutoSize = true;
            this.lblDPSTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblDPSTitle.Location = new System.Drawing.Point(18, 15);
            this.lblDPSTitle.Text = "Direct Part Sale";

            this.lblDPSCustomer.AutoSize = true;
            this.lblDPSCustomer.Location = new System.Drawing.Point(20, 60);
            this.lblDPSCustomer.Text = "Customer Name (Optional):";
            this.txtDPSCustomer.Location = new System.Drawing.Point(20, 82);
            this.txtDPSCustomer.Size = new System.Drawing.Size(400, 24);

            this.dgvDPSItems.AllowUserToAddRows = false;
            this.dgvDPSItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDPSItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvDPSItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDPSItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDPSItem, this.colDPSCategory, this.colDPSPrice, this.colDPSQty, this.colDPSUnit});
            this.dgvDPSItems.Location = new System.Drawing.Point(20, 120);
            this.dgvDPSItems.Size = new System.Drawing.Size(804, 300);
            this.dgvDPSItems.RowHeadersVisible = false;

            this.colDPSItem.HeaderText = "Item Name"; this.colDPSItem.Name = "colDPSItem";
            this.colDPSCategory.HeaderText = "Category"; this.colDPSCategory.Name = "colDPSCategory";
            this.colDPSPrice.HeaderText = "Price"; this.colDPSPrice.Name = "colDPSPrice";
            this.colDPSQty.HeaderText = "Qty"; this.colDPSQty.Name = "colDPSQty";
            this.colDPSUnit.HeaderText = "Unit (pc/set)"; this.colDPSUnit.Name = "colDPSUnit";

            this.btnAddItemDPS.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnAddItemDPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItemDPS.ForeColor = System.Drawing.Color.White;
            this.btnAddItemDPS.Location = new System.Drawing.Point(20, 430);
            this.btnAddItemDPS.Size = new System.Drawing.Size(100, 30);
            this.btnAddItemDPS.Text = "+ Add Item";
            this.btnAddItemDPS.UseVisualStyleBackColor = false;

            this.btnCancelDPS.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnCancelDPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelDPS.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelDPS.ForeColor = System.Drawing.Color.White;
            this.btnCancelDPS.Location = new System.Drawing.Point(598, 600);
            this.btnCancelDPS.Size = new System.Drawing.Size(110, 35);
            this.btnCancelDPS.Text = "Cancel";
            this.btnCancelDPS.UseVisualStyleBackColor = false;

            this.btnCompleteSale.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnCompleteSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteSale.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCompleteSale.ForeColor = System.Drawing.Color.White;
            this.btnCompleteSale.Location = new System.Drawing.Point(714, 600);
            this.btnCompleteSale.Size = new System.Drawing.Size(110, 35);
            this.btnCompleteSale.Text = "Complete Sale";
            this.btnCompleteSale.UseVisualStyleBackColor = false;

            // ===== ROOT =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnCompleteSale);
            this.Controls.Add(this.btnCancelDPS);
            this.Controls.Add(this.btnAddItemDPS);
            this.Controls.Add(this.dgvDPSItems);
            this.Controls.Add(this.txtDPSCustomer);
            this.Controls.Add(this.lblDPSCustomer);
            this.Controls.Add(this.lblDPSTitle);
            this.Name = "InventoryControlDirectPartSale";
            this.Size = new System.Drawing.Size(844, 655);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDPSItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.Label lblDPSTitle;
        public System.Windows.Forms.Label lblDPSCustomer;
        public System.Windows.Forms.TextBox txtDPSCustomer;
        public System.Windows.Forms.DataGridView dgvDPSItems;
        public System.Windows.Forms.DataGridViewTextBoxColumn colDPSItem;
        public System.Windows.Forms.DataGridViewTextBoxColumn colDPSCategory;
        public System.Windows.Forms.DataGridViewTextBoxColumn colDPSPrice;
        public System.Windows.Forms.DataGridViewTextBoxColumn colDPSQty;
        public System.Windows.Forms.DataGridViewTextBoxColumn colDPSUnit;
        public System.Windows.Forms.Button btnAddItemDPS;
        public System.Windows.Forms.Button btnCancelDPS;
        public System.Windows.Forms.Button btnCompleteSale;
    }
}
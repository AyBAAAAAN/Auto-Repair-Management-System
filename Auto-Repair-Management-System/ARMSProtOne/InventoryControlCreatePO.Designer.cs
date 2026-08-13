namespace ARMSProtOne
{
    partial class InventoryControlCreatePO
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblPOTitle = new System.Windows.Forms.Label();
            this.lblPONumber = new System.Windows.Forms.Label();
            this.txtPONumber = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dgvPOItems = new System.Windows.Forms.DataGridView();
            this.colPOItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPOCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPOQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPOUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddItemPO = new System.Windows.Forms.Button();
            this.btnCancelPO = new System.Windows.Forms.Button();
            this.btnSavePO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOItems)).BeginInit();
            this.SuspendLayout();

            // ===== CREATE PURCHASE ORDER =====
            this.lblPOTitle.AutoSize = true;
            this.lblPOTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPOTitle.Location = new System.Drawing.Point(18, 15);
            this.lblPOTitle.Text = "Create Purchase Order";

            this.lblPONumber.AutoSize = true;
            this.lblPONumber.Location = new System.Drawing.Point(20, 60);
            this.lblPONumber.Text = "P.O. Number:";
            this.txtPONumber.Location = new System.Drawing.Point(150, 57);
            this.txtPONumber.Size = new System.Drawing.Size(150, 24);
            this.txtPONumber.ReadOnly = true;

            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(340, 60);
            this.lblSupplier.Text = "Supplier:";
            this.txtSupplier.Location = new System.Drawing.Point(410, 57);
            this.txtSupplier.Size = new System.Drawing.Size(180, 24);

            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(610, 60);
            this.lblOrderDate.Text = "Order Date:";
            this.dtpOrderDate.Location = new System.Drawing.Point(610, 80);
            this.dtpOrderDate.Size = new System.Drawing.Size(200, 24);

            this.dgvPOItems.AllowUserToAddRows = false;
            this.dgvPOItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPOItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvPOItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPOItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPOItem, this.colPOCategory, this.colPOQty, this.colPOUnit});
            this.dgvPOItems.Location = new System.Drawing.Point(20, 120);
            this.dgvPOItems.Size = new System.Drawing.Size(804, 300);
            this.dgvPOItems.RowHeadersVisible = false;

            this.colPOItem.HeaderText = "Item Name"; this.colPOItem.Name = "colPOItem";
            this.colPOCategory.HeaderText = "Category"; this.colPOCategory.Name = "colPOCategory";
            this.colPOQty.HeaderText = "Qty"; this.colPOQty.Name = "colPOQty";
            this.colPOUnit.HeaderText = "Unit (pc/set)"; this.colPOUnit.Name = "colPOUnit";

            this.btnAddItemPO.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnAddItemPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItemPO.ForeColor = System.Drawing.Color.White;
            this.btnAddItemPO.Location = new System.Drawing.Point(20, 430);
            this.btnAddItemPO.Size = new System.Drawing.Size(100, 30);
            this.btnAddItemPO.Text = "+ Add Item";
            this.btnAddItemPO.UseVisualStyleBackColor = false;

            this.btnCancelPO.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnCancelPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelPO.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelPO.ForeColor = System.Drawing.Color.White;
            this.btnCancelPO.Location = new System.Drawing.Point(598, 600);
            this.btnCancelPO.Size = new System.Drawing.Size(110, 35);
            this.btnCancelPO.Text = "Cancel";
            this.btnCancelPO.UseVisualStyleBackColor = false;

            this.btnSavePO.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSavePO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePO.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSavePO.ForeColor = System.Drawing.Color.White;
            this.btnSavePO.Location = new System.Drawing.Point(714, 600);
            this.btnSavePO.Size = new System.Drawing.Size(110, 35);
            this.btnSavePO.Text = "Save PO";
            this.btnSavePO.UseVisualStyleBackColor = false;

            // ===== ROOT =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnSavePO);
            this.Controls.Add(this.btnCancelPO);
            this.Controls.Add(this.btnAddItemPO);
            this.Controls.Add(this.dgvPOItems);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.txtPONumber);
            this.Controls.Add(this.lblPONumber);
            this.Controls.Add(this.lblPOTitle);
            this.Name = "InventoryControlCreatePO";
            this.Size = new System.Drawing.Size(844, 655);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.Label lblPOTitle;
        public System.Windows.Forms.Label lblPONumber;
        public System.Windows.Forms.TextBox txtPONumber;
        public System.Windows.Forms.Label lblSupplier;
        public System.Windows.Forms.TextBox txtSupplier;
        public System.Windows.Forms.Label lblOrderDate;
        public System.Windows.Forms.DateTimePicker dtpOrderDate;
        public System.Windows.Forms.DataGridView dgvPOItems;
        public System.Windows.Forms.DataGridViewTextBoxColumn colPOItem;
        public System.Windows.Forms.DataGridViewTextBoxColumn colPOCategory;
        public System.Windows.Forms.DataGridViewTextBoxColumn colPOQty;
        public System.Windows.Forms.DataGridViewTextBoxColumn colPOUnit;
        public System.Windows.Forms.Button btnAddItemPO;
        public System.Windows.Forms.Button btnCancelPO;
        public System.Windows.Forms.Button btnSavePO;
    }
}
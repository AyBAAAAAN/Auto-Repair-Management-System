namespace ARMSProtOne
{
    partial class InventoryControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.lblCategoryFilter = new System.Windows.Forms.Label();
            this.cmbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddNewPart = new System.Windows.Forms.Button();
            this.btnCreatePO = new System.Windows.Forms.Button();
            this.btnDirectPartSale = new System.Windows.Forms.Button();
            this.btnManageSelected = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();

            // ===== TOOLBAR =====
            this.lblCategoryFilter.AutoSize = true;
            this.lblCategoryFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCategoryFilter.Location = new System.Drawing.Point(15, 21);
            this.lblCategoryFilter.Text = "Category:";
            this.cmbCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryFilter.Location = new System.Drawing.Point(90, 18);
            this.cmbCategoryFilter.Size = new System.Drawing.Size(140, 24);

            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.Location = new System.Drawing.Point(245, 18);
            this.txtSearch.Size = new System.Drawing.Size(180, 24);

            this.btnAddNewPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewPart.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnAddNewPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewPart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddNewPart.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPart.Location = new System.Drawing.Point(438, 12);
            this.btnAddNewPart.Size = new System.Drawing.Size(110, 34);
            this.btnAddNewPart.Text = "+ Add Part";
            this.btnAddNewPart.UseVisualStyleBackColor = false;
            this.btnAddNewPart.Click += new System.EventHandler(this.btnAddNewPart_Click);

            this.btnCreatePO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreatePO.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnCreatePO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCreatePO.ForeColor = System.Drawing.Color.White;
            this.btnCreatePO.Location = new System.Drawing.Point(554, 12);
            this.btnCreatePO.Size = new System.Drawing.Size(100, 34);
            this.btnCreatePO.Text = "Create PO";
            this.btnCreatePO.UseVisualStyleBackColor = false;
            this.btnCreatePO.Click += new System.EventHandler(this.btnCreatePO_Click);

            this.btnDirectPartSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDirectPartSale.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.btnDirectPartSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectPartSale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDirectPartSale.Location = new System.Drawing.Point(662, 12);
            this.btnDirectPartSale.Size = new System.Drawing.Size(120, 34);
            this.btnDirectPartSale.Text = "Direct Part Sale";
            this.btnDirectPartSale.UseVisualStyleBackColor = false;
            this.btnDirectPartSale.Click += new System.EventHandler(this.btnDirectPartSale_Click);

            this.btnManageSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageSelected.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnManageSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageSelected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnManageSelected.ForeColor = System.Drawing.Color.White;
            this.btnManageSelected.Location = new System.Drawing.Point(438, 12);
            this.btnManageSelected.Size = new System.Drawing.Size(0, 0);
            this.btnManageSelected.Text = "Edit Selected";
            this.btnManageSelected.Visible = false;
            this.btnManageSelected.UseVisualStyleBackColor = false;

            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Size = new System.Drawing.Size(844, 60);
            this.pnlToolbar.Controls.Add(this.lblCategoryFilter);
            this.pnlToolbar.Controls.Add(this.cmbCategoryFilter);
            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Controls.Add(this.btnAddNewPart);
            this.pnlToolbar.Controls.Add(this.btnCreatePO);
            this.pnlToolbar.Controls.Add(this.btnDirectPartSale);
            this.pnlToolbar.Controls.Add(this.btnManageSelected);

            // ===== INVENTORY GRID =====
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemName, this.colCategory, this.colModel, this.colPrice, this.colQty, this.colStatus});
            this.dgvInventory.Location = new System.Drawing.Point(18, 70);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(808, 568);
            this.dgvInventory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellDoubleClick);

            this.colItemName.HeaderText = "Item Name"; this.colItemName.Name = "colItemName"; this.colItemName.ReadOnly = true;
            this.colCategory.HeaderText = "Category"; this.colCategory.Name = "colCategory"; this.colCategory.ReadOnly = true;
            this.colModel.HeaderText = "Model"; this.colModel.Name = "colModel"; this.colModel.ReadOnly = true;
            this.colPrice.HeaderText = "Price"; this.colPrice.Name = "colPrice"; this.colPrice.ReadOnly = true;
            this.colQty.HeaderText = "Qty"; this.colQty.Name = "colQty"; this.colQty.ReadOnly = true;
            this.colStatus.HeaderText = "Status"; this.colStatus.Name = "colStatus"; this.colStatus.ReadOnly = true;

            // ===== ROOT =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.pnlToolbar);
            this.Name = "InventoryControl";
            this.Size = new System.Drawing.Size(844, 655);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblCategoryFilter;
        private System.Windows.Forms.ComboBox cmbCategoryFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddNewPart;
        private System.Windows.Forms.Button btnCreatePO;
        private System.Windows.Forms.Button btnDirectPartSale;
        private System.Windows.Forms.Button btnManageSelected;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
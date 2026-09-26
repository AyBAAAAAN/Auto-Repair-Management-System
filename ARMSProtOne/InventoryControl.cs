using System;
using System.Windows.Forms;

namespace ARMSProtOne
{
    public partial class InventoryControl : UserControl
    {
        public InventoryControl()
        {
            InitializeComponent();
            LoadComboItems();
            // TODO: Load inventory list from database.
        }

        private void LoadComboItems()
        {
            string[] categories = { "All", "Electrical", "Car Aircon", "Radiator", "Mechanical" };
            cmbCategoryFilter.Items.AddRange(categories);
            cmbCategoryFilter.SelectedIndex = 0;
        }

        private void ReturnToMainInventory()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            LoadComboItems();
        }

        // --- MAIN INVENTORY ---

        private void btnAddNewPart_Click(object sender, EventArgs e)
        {
            OpenAddEditPart(isEdit: false, itemName: null, category: null, model: null, qty: null, price: null);
        }

        private void dgvInventory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvInventory.Rows[e.RowIndex];

            OpenAddEditPart(
                isEdit: true,
                itemName: row.Cells["colItemName"].Value?.ToString(),
                category: row.Cells["colCategory"].Value?.ToString(),
                model: row.Cells["colModel"].Value?.ToString(),
                qty: row.Cells["colQty"].Value?.ToString(),
                price: row.Cells["colPrice"].Value?.ToString());
        }

        private void btnCreatePO_Click(object sender, EventArgs e)
        {
            var poControl = new InventoryControlCreatePO { Dock = DockStyle.Fill };
            poControl.txtPONumber.Text = string.Empty; // TODO: Generate PO number from database.
            poControl.txtSupplier.Text = string.Empty;
            poControl.dtpOrderDate.Value = DateTime.Now;

            poControl.btnAddItemPO.Click += (s, ev) =>
            {
                // TODO: Open Add Part picker and append selected item to poControl.dgvPOItems.
            };

            poControl.btnCancelPO.Click += (s, ev) => ReturnToMainInventory();

            poControl.btnSavePO.Click += (s, ev) =>
            {
                // TODO: Persist purchase order to database.
                ReturnToMainInventory();
            };

            this.Controls.Clear();
            this.Controls.Add(poControl);
        }

        private void btnDirectPartSale_Click(object sender, EventArgs e)
        {
            var dpsControl = new InventoryControlDirectPartSale { Dock = DockStyle.Fill };
            dpsControl.txtDPSCustomer.Text = string.Empty;

            dpsControl.btnAddItemDPS.Click += (s, ev) =>
            {
                // TODO: Open item picker and append selected item to dpsControl.dgvDPSItems.
            };

            dpsControl.btnCancelDPS.Click += (s, ev) => ReturnToMainInventory();

            dpsControl.btnCompleteSale.Click += (s, ev) =>
            {
                // TODO: Persist sale and deduct stock in database.
                ReturnToMainInventory();
            };

            this.Controls.Clear();
            this.Controls.Add(dpsControl);
        }

        // --- ADD/EDIT PART ---

        private void OpenAddEditPart(bool isEdit, string itemName, string category, string model, string qty, string price)
        {
            var aepControl = new InventoryControlAddEditPart { Dock = DockStyle.Fill };
            aepControl.cmbCategoryAEP.Items.AddRange(new object[] { "Electrical", "Car Aircon", "Radiator", "Mechanical" });

            aepControl.lblAEPTitle.Text = isEdit ? "Edit Part" : "Add New Part";
            aepControl.txtItemNameAEP.Text = itemName ?? string.Empty;
            aepControl.cmbCategoryAEP.Text = category ?? string.Empty;
            aepControl.txtModelAEP.Text = model ?? string.Empty;
            aepControl.txtQtyAEP.Text = qty ?? string.Empty;
            aepControl.txtPriceAEP.Text = price ?? string.Empty;
            aepControl.btnRemoveAEP.Visible = isEdit;

            aepControl.btnCancelAEP.Click += (s, ev) => ReturnToMainInventory();

            aepControl.btnRemoveAEP.Click += (s, ev) =>
            {
                if (dgvInventory.SelectedRows.Count > 0)
                    dgvInventory.Rows.Remove(dgvInventory.SelectedRows[0]);

                // TODO: Persist removal to database.
                ReturnToMainInventory();
            };

            aepControl.btnSaveAEP.Click += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(aepControl.txtItemNameAEP.Text))
                {
                    MessageBox.Show("Item Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (isEdit && dgvInventory.SelectedRows.Count > 0)
                {
                    var row = dgvInventory.SelectedRows[0];
                    row.Cells["colItemName"].Value = aepControl.txtItemNameAEP.Text.Trim();
                    row.Cells["colCategory"].Value = aepControl.cmbCategoryAEP.Text;
                    row.Cells["colModel"].Value = aepControl.txtModelAEP.Text.Trim();
                    row.Cells["colPrice"].Value = aepControl.txtPriceAEP.Text.Trim();
                    row.Cells["colQty"].Value = aepControl.txtQtyAEP.Text.Trim();
                }
                else
                {
                    dgvInventory.Rows.Add(aepControl.txtItemNameAEP.Text.Trim(), aepControl.cmbCategoryAEP.Text,
                        aepControl.txtModelAEP.Text.Trim(), aepControl.txtPriceAEP.Text.Trim(), aepControl.txtQtyAEP.Text.Trim(), "OK");
                }

                // TODO: Persist part to database.
                ReturnToMainInventory();
            };

            this.Controls.Clear();
            this.Controls.Add(aepControl);
        }
    }
}
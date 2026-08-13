using System;
using System.Windows.Forms;

namespace ARMSProtOne
{
    public partial class RecordsControl : UserControl
    {
        public RecordsControl()
        {
            InitializeComponent();
            // TODO: Load customer records from database.
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var addInputControl = new RecordsControlptAddRecords
            {
                Dock = DockStyle.Fill
            };

            addInputControl.OperationCancelled += (s, ev) =>
            {
                this.Controls.Clear();
                this.InitializeComponent();
            };

            addInputControl.OperationSaved += (s, ev) =>
            {
                this.Controls.Clear();
                this.InitializeComponent();

                // TODO: Persist customer to database instead of adding directly to grid.
                dgvCustomers.Rows.Add(ev.CustomerId, ev.Name, ev.ContactNumber, ev.VehicleModel, ev.PlateNumber);
            };

            this.Controls.Clear();
            this.Controls.Add(addInputControl);
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer record from the table to view.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvCustomers.SelectedRows[0];
            string name = row.Cells.Count > 1 && row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : string.Empty;
            string contact = row.Cells.Count > 2 && row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : string.Empty;
            string vehicle = row.Cells.Count > 3 && row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : string.Empty;
            string plate = row.Cells.Count > 4 && row.Cells[4].Value != null ? row.Cells[4].Value.ToString() : string.Empty;

            var view = new RecordsptViewCust(name, contact, vehicle, plate);

            view.OperationClosed += (s, ev) =>
            {
                this.Controls.Clear();
                this.InitializeComponent();
            };

            this.Controls.Clear();
            view.Dock = DockStyle.Fill;
            this.Controls.Add(view);
        }
    }
}
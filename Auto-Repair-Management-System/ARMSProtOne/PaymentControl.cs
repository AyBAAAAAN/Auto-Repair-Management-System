using System;
using System.Windows.Forms;

namespace ARMSProtOne
{
    public partial class PaymentControl : UserControl
    {
        public PaymentControl()
        {
            InitializeComponent();
            // TODO: Load payment transactions from database.
        }

        private void FilterGrid(string status)
        {
            foreach (DataGridViewRow row in dgvPayments.Rows)
            {
                if (row.Cells["colStatus"].Value == null) continue;
                row.Visible = status == "All" || row.Cells["colStatus"].Value.ToString() == status;
            }
        }

        private void btnFilterAll_Click(object sender, EventArgs e) => FilterGrid("All");
        private void btnFilterUnpaid_Click(object sender, EventArgs e) => FilterGrid("Unpaid");
        private void btnFilterPartial_Click(object sender, EventArgs e) => FilterGrid("Partial");
        private void btnFilterPaid_Click(object sender, EventArgs e) => FilterGrid("Paid");

        private void btnManagePayment_Click(object sender, EventArgs e)
        {
            if (dgvPayments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction row first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvPayments.SelectedRows[0];
            string type = row.Cells["colType"].Value.ToString();
            string customer = row.Cells["colCustomer"].Value.ToString();
            string total = row.Cells["colTotal"].Value.ToString();

            // TODO: Fetch full transaction details (items, service breakdown) from database.
            if (type == "Sell Part")
                OpenDirectPartSale(type, customer, total);
            else
                OpenJobOrderPayment(type, customer, total);
        }

        private void OpenDirectPartSale(string type, string customer, string total)
        {
            var dpsControl = new PaymentControlDirectPartSale(total) { Dock = DockStyle.Fill };

            dpsControl.OperationCancelled += (s, ev) =>
            {
                this.Controls.Clear();
                this.InitializeComponent();
            };

            dpsControl.OperationSaved += (s, ev) =>
            {
                this.Controls.Clear();
                this.InitializeComponent();
                // TODO: Re-fetch payments from database; grid is currently reset on reload until DB is attached.
                UpdateRowAfterPayment(type, customer, ev.AmountPaid, "Paid");
            };

            this.Controls.Clear();
            this.Controls.Add(dpsControl);
        }

        private void OpenJobOrderPayment(string type, string customer, string total)
        {
            var jopControl = new PaymentControlJobOrderPayment(type, customer, total) { Dock = DockStyle.Fill };

            jopControl.OperationCancelled += (s, ev) =>
            {
                this.Controls.Clear();
                this.InitializeComponent();
            };

            jopControl.OperationSaved += (s, ev) =>
            {
                this.Controls.Clear();
                this.InitializeComponent();
                // TODO: Re-fetch payments from database; grid is currently reset on reload until DB is attached.
                UpdateRowAfterPayment(type, customer, ev.AmountPaid, ev.IsFullPayment ? "Paid" : "Partial");
            };

            this.Controls.Clear();
            this.Controls.Add(jopControl);
        }

        private void UpdateRowAfterPayment(string type, string customer, string amountPaid, string status)
        {
            foreach (DataGridViewRow r in dgvPayments.Rows)
            {
                if (r.Cells["colType"].Value?.ToString() == type && r.Cells["colCustomer"].Value?.ToString() == customer)
                {
                    r.Cells["colPaid"].Value = amountPaid;
                    r.Cells["colStatus"].Value = status;
                    if (status == "Paid") r.Cells["colBalance"].Value = "0";
                    break;
                }
            }
        }
    }
}
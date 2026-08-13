using System;
using System.Globalization;
using System.Windows.Forms;

namespace ARMSProtOne
{
    public partial class PaymentControlJobOrderPayment : UserControl
    {
        public event EventHandler OperationCancelled;
        public event EventHandler<PaymentSubmittedEventArgs> OperationSaved;

        private readonly decimal total;

        public PaymentControlJobOrderPayment(string service, string customer, string totalAmount)
        {
            InitializeComponent();
            // TODO: Fetch JO number, labor, home service fee, and discount breakdown from database.
            decimal.TryParse(totalAmount, NumberStyles.Any, CultureInfo.InvariantCulture, out total);
            lblService.Text = "Service: " + service;
            lblCustomer.Text = "Customer: " + customer;
            lblTotal.Text = "Total: PHP " + total.ToString("N2");
            rbFullPayment.Checked = true;
            txtJOPAmountPaid.TextChanged += (s, e) => UpdateChange();
        }

        private void UpdateChange()
        {
            lblJOPChange.Text = decimal.TryParse(txtJOPAmountPaid.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal paid)
                ? "PHP " + Math.Max(0, paid - total).ToString("N2")
                : "PHP 0.00";
        }

        private void btnCancelJOP_Click(object sender, EventArgs e)
        {
            OperationCancelled?.Invoke(this, EventArgs.Empty);
        }

        private void btnExportJOP_Click(object sender, EventArgs e)
        {
            // TODO: Generate printable receipt.
        }

        private void btnSubmitJOP_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtJOPAmountPaid.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal paid) || paid <= 0)
            {
                MessageBox.Show("Please enter a valid amount paid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rbFullPayment.Checked && paid < total)
            {
                MessageBox.Show("Amount paid must cover the full total for a Full Payment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Persist payment to database.
            OperationSaved?.Invoke(this, new PaymentSubmittedEventArgs(paid.ToString("N2"), rbFullPayment.Checked));
        }
    }
}
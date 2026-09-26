using System;
using System.Globalization;
using System.Windows.Forms;

namespace ARMSProtOne
{
    public partial class PaymentControlDirectPartSale : UserControl
    {
        public event EventHandler OperationCancelled;
        public event EventHandler<PaymentSubmittedEventArgs> OperationSaved;

        private readonly decimal partsTotal;

        public PaymentControlDirectPartSale(string total)
        {
            InitializeComponent();
            // TODO: Fetch item name, category, quantity, and unit price for this sale from database.
            decimal.TryParse(total, NumberStyles.Any, CultureInfo.InvariantCulture, out partsTotal);
            lblPartsTotal.Text = "Parts Total: PHP " + partsTotal.ToString("N2");
            txtDPSAmountPaid.TextChanged += (s, e) => UpdateChange();
        }

        private void UpdateChange()
        {
            lblDPSChange.Text = decimal.TryParse(txtDPSAmountPaid.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal paid)
                ? "PHP " + Math.Max(0, paid - partsTotal).ToString("N2")
                : "PHP 0.00";
        }

        private void btnCancelDPS_Click(object sender, EventArgs e)
        {
            OperationCancelled?.Invoke(this, EventArgs.Empty);
        }

        private void btnExportDPS_Click(object sender, EventArgs e)
        {
            // TODO: Generate printable receipt.
        }

        private void btnSubmitDPS_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDPSAmountPaid.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal paid) || paid < partsTotal)
            {
                MessageBox.Show("Amount paid must cover the parts total.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Persist payment to database and deduct stock.
            OperationSaved?.Invoke(this, new PaymentSubmittedEventArgs(paid.ToString("N2"), true));
        }
    }

    public class PaymentSubmittedEventArgs : EventArgs
    {
        public string AmountPaid { get; }
        public bool IsFullPayment { get; }

        public PaymentSubmittedEventArgs(string amountPaid, bool isFullPayment)
        {
            AmountPaid = amountPaid;
            IsFullPayment = isFullPayment;
        }
    }
}
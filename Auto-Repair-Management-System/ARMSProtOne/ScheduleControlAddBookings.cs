using System;
using System.Windows.Forms;

namespace ARMSProtOne
{
    public partial class ScheduleControlAddBookings : UserControl
    {
        public event EventHandler OperationCancelled;
        public event EventHandler<AppointmentSavedEventArgs> OperationSaved;

        public ScheduleControlAddBookings()
        {
            InitializeComponent();
            cmbApptTime.Items.AddRange(new object[] { "8:00 AM", "9:00 AM", "10:00 AM", "1:00 PM", "3:00 PM" });
            cmbVehicleType.Items.AddRange(new object[] { "Sedan", "SUV", "Van", "Pickup" });
        }

        private void btnCancelBook_Click(object sender, EventArgs e)
        {
            OperationCancelled?.Invoke(this, EventArgs.Empty);
        }

        private void btnSubmitBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustName.Text))
            {
                MessageBox.Show("Customer Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OperationSaved?.Invoke(this, new AppointmentSavedEventArgs(
                dtpApptDate.Value.ToShortDateString(),
                cmbApptTime.Text,
                txtCustName.Text.Trim(),
                (txtVehicleBrand.Text + " " + txtVehicleModel.Text).Trim(),
                txtConcern.Text.Trim()));
        }
    }

    public class AppointmentSavedEventArgs : EventArgs
    {
        public string Date { get; }
        public string Time { get; }
        public string CustomerName { get; }
        public string Vehicle { get; }
        public string Concern { get; }

        public AppointmentSavedEventArgs(string date, string time, string customerName, string vehicle, string concern)
        {
            Date = date;
            Time = time;
            CustomerName = customerName;
            Vehicle = vehicle;
            Concern = concern;
        }
    }
}
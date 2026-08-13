using System;
using System.Windows.Forms;

namespace ARMSProtOne
{
    public partial class JobOrderControlptAddJobOrder : UserControl
    {
        public event EventHandler OperationCancelled;
        public event EventHandler<JobOrderSavedEventArgs> OperationSaved;

        public JobOrderControlptAddJobOrder()
        {
            InitializeComponent();
            // TODO: Generate JO number and load Service Type / Mechanic options from database.
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) || string.IsNullOrWhiteSpace(txtPlateNumber.Text))
            {
                MessageBox.Show("Customer Name and Plate Number are required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OperationSaved?.Invoke(this, new JobOrderSavedEventArgs(
                txtJONumber.Text,
                txtPlateNumber.Text.Trim().ToUpper(),
                txtVehicleModel.Text.Trim(),
                cmbServiceType.Text,
                txtCost.Text.Trim()));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OperationCancelled?.Invoke(this, EventArgs.Empty);
        }
    }

    public class JobOrderSavedEventArgs : EventArgs
    {
        public string JONumber { get; }
        public string PlateNumber { get; }
        public string VehicleModel { get; }
        public string ServiceType { get; }
        public string Cost { get; }

        public JobOrderSavedEventArgs(string joNumber, string plateNumber, string vehicleModel, string serviceType, string cost)
        {
            JONumber = joNumber;
            PlateNumber = plateNumber;
            VehicleModel = vehicleModel;
            ServiceType = serviceType;
            Cost = cost;
        }
    }
}
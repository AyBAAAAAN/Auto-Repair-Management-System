using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMSProtOne
{
    public partial class RecordsControlptAddRecords : UserControl
    {
        public event EventHandler OperationCancelled;

        // Raised when the user saves a new customer entry so the parent container can update its UI temporarily.
        public event EventHandler<CustomerSavedEventArgs> OperationSaved;

        public RecordsControlptAddRecords()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Input Validation
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) || string.IsNullOrWhiteSpace(txtPlateNumber.Text))
            {
                MessageBox.Show("Owner Name and Plate Number are strictly required fields.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prepare trimmed values to pass back to the parent UI as a temporary entry.
            string name = txtCustomerName.Text.Trim();
            string contact = txtContactNumber.Text.Trim();
            string vehicle = txtVehicleModel.Text.Trim();
            string plate = txtPlateNumber.Text.Trim().ToUpper();

            // Generate a temporary ID for the UI-only row.
            string tempId = $"CUST-TMP-{DateTime.Now:yyyyMMddHHmmssfff}";

            // Raise the save event with the captured data.
            OperationSaved?.Invoke(this, new CustomerSavedEventArgs(tempId, name, contact, vehicle, plate));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelOperation();
        }
        public void CancelOperation()
        {
            OperationCancelled?.Invoke(this, EventArgs.Empty);
        }
    }

    // Event args used to transport the saved customer data back to the parent control.
    public class CustomerSavedEventArgs : EventArgs
    {
        public string CustomerId { get; }
        public string Name { get; }
        public string ContactNumber { get; }
        public string VehicleModel { get; }
        public string PlateNumber { get; }

        public CustomerSavedEventArgs(string customerId, string name, string contactNumber, string vehicleModel, string plateNumber)
        {
            CustomerId = customerId;
            Name = name;
            ContactNumber = contactNumber;
            VehicleModel = vehicleModel;
            PlateNumber = plateNumber;
        }
    }
}


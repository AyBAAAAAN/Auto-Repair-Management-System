using System;
using System.Windows.Forms;

namespace ARMSProtOne
{
    public partial class JobOrderControlptManage : UserControl
    {
        public event EventHandler<JobOrderClosedEventArgs> OperationClosed;

        private readonly string joNumber;

        public JobOrderControlptManage(string joNumber, string plate, string vehicle, string serviceType, string status)
        {
            InitializeComponent();
            this.joNumber = joNumber;

            cmbStatusPicker.Items.AddRange(new object[] { "Pending", "Ongoing", "Done" });
            // TODO: Load mechanic list from database.

            // Populate Work Order Details with the context passed from the tracking grid.
            // TODO: Fetch full job order record (customer, mechanic, parts, notes) from database using joNumber.
            lblTargetJO.Text = "Job Order: " + joNumber;
            lblTargetVehicle.Text = "Vehicle: " + vehicle + " — " + plate;
            lblTargetServiceType.Text = "Service Type: " + serviceType;
            cmbStatusPicker.Text = status;

            SwitchPanel(pnlDetails);
        }

        private void SwitchPanel(Panel target)
        {
            pnlDetails.Visible = false;
            pnlBackJob.Visible = false;
            target.Dock = DockStyle.Fill;
            target.Visible = true;
        }

        private void btnSaveStatus_Click(object sender, EventArgs e)
        {
            // TODO: Persist status update to database.
            OperationClosed?.Invoke(this, new JobOrderClosedEventArgs(joNumber, cmbStatusPicker.Text));
        }

        private void btnCloseDetails_Click(object sender, EventArgs e)
        {
            OperationClosed?.Invoke(this, new JobOrderClosedEventArgs(joNumber, null));
        }

        private void btnCreateBackJob_Click(object sender, EventArgs e)
        {
            lblBackJobTitle.Text = "Back Job | " + joNumber;
            lblBackJobLinkInfo.Text = $"Linked to {joNumber}";
            lblBackJobVehicle.Text = lblTargetVehicle.Text;
            lblBackJobOriginalService.Text = "Original Service: " + lblTargetServiceType.Text.Replace("Service Type: ", "");
            dtpBackJobDate.Value = DateTime.Now;
            // TODO: Load mechanic list and customer info from database.

            SwitchPanel(pnlBackJob);
        }

        private void btnCancelBackJob_Click(object sender, EventArgs e)
        {
            SwitchPanel(pnlDetails);
        }

        private void btnSubmitBackJob_Click(object sender, EventArgs e)
        {
            // TODO: Persist back job to database.
            OperationClosed?.Invoke(this, new JobOrderClosedEventArgs(joNumber, "Done"));
        }
    }

    public class JobOrderClosedEventArgs : EventArgs
    {
        public string JONumber { get; }
        public string UpdatedStatus { get; }

        public JobOrderClosedEventArgs(string joNumber, string updatedStatus)
        {
            JONumber = joNumber;
            UpdatedStatus = updatedStatus;
        }
    }
}
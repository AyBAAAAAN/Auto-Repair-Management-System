using System;
using System.Windows.Forms;

namespace ARMSProtOne
{
    public partial class ScheduleControlAppointmentDetails : UserControl
    {
        public event EventHandler OperationClosed;

        public ScheduleControlAppointmentDetails(string date, string time, string customerName, string vehicle, string concern, string status)
        {
            InitializeComponent();
            cmbNewTime.Items.AddRange(new object[] { "8:00 AM", "9:00 AM", "10:00 AM", "1:00 PM", "3:00 PM" });

            // TODO: Fetch full appointment details (contact, address) from database.
            lblDetailDate.Text = "Date: " + date + " — " + time;
            lblDetailCustomer.Text = "Customer: " + customerName;
            lblDetailVehicle.Text = "Vehicle: " + vehicle;
            lblDetailConcern.Text = "Concern: " + concern;
            lblDetailStatus.Text = "Status: " + status;
            grpReschedule.Visible = false;
        }

        private void btnCloseDetails_Click(object sender, EventArgs e)
        {
            OperationClosed?.Invoke(this, EventArgs.Empty);
        }

        private void btnReschedule_Click(object sender, EventArgs e)
        {
            grpReschedule.Visible = !grpReschedule.Visible;
        }

        private void btnCancelReschedule_Click(object sender, EventArgs e)
        {
            grpReschedule.Visible = false;
        }

        private void btnSetReschedule_Click(object sender, EventArgs e)
        {
            lblDetailDate.Text = "Date: " + dtpNewDate.Value.ToShortDateString() + " — " + cmbNewTime.Text;
            grpReschedule.Visible = false;
            // TODO: Persist reschedule to database.
        }

        private void btnStartJob_Click(object sender, EventArgs e)
        {
            // TODO: Open the Job Order creation flow for this appointment.
        }
    }
}
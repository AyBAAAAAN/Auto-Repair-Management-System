using System;
using System.Windows.Forms;

namespace ARMSProtOne
{
    public partial class ScheduleControl : UserControl
    {
        public ScheduleControl()
        {
            InitializeComponent();
            // TODO: Load appointment list from database.
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            var addControl = new ScheduleControlAddBookings { Dock = DockStyle.Fill };

            addControl.OperationCancelled += (s, ev) =>
            {
                this.Controls.Clear();
                this.InitializeComponent();
            };

            addControl.OperationSaved += (s, ev) =>
            {
                this.Controls.Clear();
                this.InitializeComponent();
                // TODO: Persist appointment to database instead of adding directly to grid.
                dgvSchedule.Rows.Add(ev.Date, ev.Time, ev.CustomerName, ev.Vehicle, ev.Concern, "Scheduled");
            };

            this.Controls.Clear();
            this.Controls.Add(addControl);
        }

        private void btnViewAppointment_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment from the list first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvSchedule.SelectedRows[0];
            string date = row.Cells["colDate"].Value.ToString();
            string time = row.Cells["colTime"].Value.ToString();
            string name = row.Cells["colName"].Value.ToString();
            string vehicle = row.Cells["colVehicle"].Value.ToString();
            string concern = row.Cells["colConcern"].Value.ToString();
            string status = row.Cells["colStatus"].Value.ToString();

            var detailsControl = new ScheduleControlAppointmentDetails(date, time, name, vehicle, concern, status) { Dock = DockStyle.Fill };

            detailsControl.OperationClosed += (s, ev) =>
            {
                this.Controls.Clear();
                this.InitializeComponent();
                // TODO: Re-fetch appointments from database instead of reloading the in-memory grid.
            };

            this.Controls.Clear();
            this.Controls.Add(detailsControl);
        }
    }
}
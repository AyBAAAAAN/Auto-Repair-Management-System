using System;
using System.Windows.Forms;

namespace ARMSProtOne
{
    public partial class JobOrderControl : UserControl
    {
        public JobOrderControl()
        {
            InitializeComponent();
            // TODO: Load job orders from database.
        }

        private void FilterGrid(string status)
        {
            foreach (DataGridViewRow row in dgvJobOrders.Rows)
            {
                if (row.Cells["colStatus"].Value == null) continue;
                row.Visible = status == "All" || row.Cells["colStatus"].Value.ToString() == status;
            }
        }

        private void btnFilterAll_Click(object sender, EventArgs e) => FilterGrid("All");
        private void btnFilterPending_Click(object sender, EventArgs e) => FilterGrid("Pending");
        private void btnFilterOngoing_Click(object sender, EventArgs e) => FilterGrid("Ongoing");
        private void btnFilterCompleted_Click(object sender, EventArgs e) => FilterGrid("Done");

        private void btnNewJobOrder_Click(object sender, EventArgs e)
        {
            var addControl = new JobOrderControlptAddJobOrder { Dock = DockStyle.Fill };

            addControl.OperationCancelled += (s, ev) =>
            {
                this.Controls.Clear();
                this.InitializeComponent();
            };

            addControl.OperationSaved += (s, ev) =>
            {
                this.Controls.Clear();
                this.InitializeComponent();
                // TODO: Persist job order to database instead of adding directly to grid.
                dgvJobOrders.Rows.Add(ev.JONumber, ev.PlateNumber, ev.VehicleModel, ev.ServiceType, ev.Cost, "Pending");
            };

            this.Controls.Clear();
            this.Controls.Add(addControl);
        }

        private void btnManageJobOrder_Click(object sender, EventArgs e)
        {
            if (dgvJobOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Job Order from the tracking board first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvJobOrders.SelectedRows[0];
            string jo = row.Cells["colJO"].Value.ToString();
            string plate = row.Cells["colPlate"].Value.ToString();
            string vehicle = row.Cells["colVehicle"].Value.ToString();
            string service = row.Cells["colService"].Value.ToString();
            string status = row.Cells["colStatus"].Value.ToString();

            var manageControl = new JobOrderControlptManage(jo, plate, vehicle, service, status) { Dock = DockStyle.Fill };

            manageControl.OperationClosed += (s, ev) =>
            {
                this.Controls.Clear();
                this.InitializeComponent();

                // TODO: Re-fetch job orders from database instead of patching the in-memory grid.
                if (!string.IsNullOrWhiteSpace(ev.UpdatedStatus))
                {
                    foreach (DataGridViewRow r in dgvJobOrders.Rows)
                    {
                        if (r.Cells["colJO"].Value?.ToString() == ev.JONumber)
                        {
                            r.Cells["colStatus"].Value = ev.UpdatedStatus;
                            break;
                        }
                    }
                }
            };

            this.Controls.Clear();
            this.Controls.Add(manageControl);
        }
    }
}
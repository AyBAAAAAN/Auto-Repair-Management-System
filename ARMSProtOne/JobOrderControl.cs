using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ARMSProtOne
{
    public partial class JobOrderControl : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\GitHub Exports\\ARMS_DBInside\\Auto-Repair-Management-System\\Auto-Repair-Management-System\\ARMSProtOne\\ARMS_Database.mdf\";Integrated Security=True");
        public JobOrderControl()
        {
            InitializeComponent();
            LoadJobOrders();
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
            JobOrderControlptAddJobOrder addControl = new JobOrderControlptAddJobOrder(this);
            addControl.Dock = DockStyle.Fill;

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

            DataGridViewRow row = dgvJobOrders.SelectedRows[0];
            string jo = row.Cells["colJO"].Value.ToString();
            string plate = row.Cells["colPlate"].Value.ToString();
            string vehicle = row.Cells["colVehicle"].Value.ToString();
            string service = row.Cells["colService"].Value.ToString();
            string status = row.Cells["colStatus"].Value.ToString();

            JobOrderControlptManage manageControl = new JobOrderControlptManage(this, jo, plate, vehicle, service, status);
            manageControl.Dock = DockStyle.Fill;

            this.Controls.Clear();
            this.Controls.Add(manageControl);
        }

        private void pnlToolbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadJobOrders()
        {
            // Fetch job orders from the database and populate the DataGridView
            SqlCommand cmd = new SqlCommand(
                    "SELECT jo.JobOrderNumber, v.PlateNumber, v.Model, " +
                    "ISNULL(s.ServiceName, jo.CustomerConcern) AS ServiceType, jo.LaborCost, jo.Status " +
                    "FROM JobOrder jo " +
                    "JOIN Vehicles v ON jo.VehicleID = v.VehicleID " +
                    "LEFT JOIN JobOrderServices jos ON jos.JobOrderID = jo.JobOrderID " +
                    "LEFT JOIN Services s ON s.ServiceID = jos.ServiceID", conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvJobOrders.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                dgvJobOrders.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }
        }
        public void ReturnToMainView()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            LoadJobOrders();
        }
    }
}
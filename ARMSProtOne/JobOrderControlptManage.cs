using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ARMSProtOne
{
    public partial class JobOrderControlptManage : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\denze\\Desktop\\Auto-Repair-Management-System\\Auto-Repair-Management-System\\ARMSProtOne\\ARMS_Database.mdf;Integrated Security=True");
        private readonly string joNumber;
        private JobOrderControl parentControl;

        public JobOrderControlptManage() : this(null, "", "", "", "", "")
        {
        }

        public JobOrderControlptManage(JobOrderControl parent, string joNumber, string plate, string vehicle, string serviceType, string status)
        {
            InitializeComponent();
            parentControl = parent;
            this.joNumber = joNumber;

            cmbStatusPicker.Items.AddRange(new object[] { "Pending", "Ongoing", "Done" });

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
            // Update the status in the database.
            SqlCommand cmd = new SqlCommand("UPDATE JobOrder SET Status = @Status WHERE JobOrderNumber = @JONumber", conn);
            cmd.Parameters.AddWithValue("@Status", cmbStatusPicker.Text);
            cmd.Parameters.AddWithValue("@JONumber", joNumber);

            conn.Open();
            cmd.ExecuteNonQuery();

            parentControl.ReturnToMainView();
        }

        private void btnCloseDetails_Click(object sender, EventArgs e)
        {
            parentControl.ReturnToMainView();
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
            conn.Open();

            // Retrieve the original job order's VehicleID and TechnicianID.
            SqlCommand findOriginal = new SqlCommand("SELECT VehicleID, TechnicianID FROM JobOrder WHERE JobOrderNumber = @JONumber", conn);
            findOriginal.Parameters.AddWithValue("@JONumber", joNumber);

            SqlDataReader reader = findOriginal.ExecuteReader();
            int vehicleId = 0;
            int technicianId = 0;

            if (reader.Read())
            {
                vehicleId = (int)reader["VehicleID"];
                technicianId = reader["TechnicianID"] != DBNull.Value ? (int)reader["TechnicianID"] : 0;
            }
            reader.Close();

            string backJobNumber = "BJ-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            // Insert the back job into the JobOrder table.
            SqlCommand insertBackJob = new SqlCommand(
                "INSERT INTO JobOrder (VehicleID, TechnicianID, JobOrderNumber, DateCreated, CustomerConcern, Status, LaborCost, Notes) " +
                "VALUES (@VehicleID, @TechnicianID, @JONumber, @BackJobDate, 'Back job', 'Pending', 0, @Notes)", conn);
            insertBackJob.Parameters.AddWithValue("@VehicleID", vehicleId);
            insertBackJob.Parameters.AddWithValue("@TechnicianID", technicianId == 0 ? (object)DBNull.Value : technicianId);
            insertBackJob.Parameters.AddWithValue("@JONumber", backJobNumber);
            insertBackJob.Parameters.AddWithValue("@BackJobDate", dtpBackJobDate.Value);
            insertBackJob.Parameters.AddWithValue("@Notes", "Back job linked to " + joNumber);
            insertBackJob.ExecuteNonQuery();

            parentControl.ReturnToMainView();
        }

        private void pnlBackJob_Paint(object sender, PaintEventArgs e)
        {

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
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ARMSProtOne
{
    public partial class JobOrderControlptAddJobOrder : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\GitHub Exports\\ARMS_DBInside\\Auto-Repair-Management-System\\Auto-Repair-Management-System\\ARMSProtOne\\ARMS_Database.mdf\";Integrated Security=True");

        private JobOrderControl parentControl;
        public JobOrderControlptAddJobOrder()
        {
            InitializeComponent();
            // TODO: Generate JO number and load Service Type / Mechanic options from database.
        }

        public JobOrderControlptAddJobOrder(JobOrderControl parent)
        {
            InitializeComponent();
            parentControl = parent;

            txtJONumber.Text = "JO-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            LoadServiceTypes();
            LoadMechanics();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) || string.IsNullOrWhiteSpace(txtPlateNumber.Text))
            {
                MessageBox.Show("Customer Name and Plate Number are required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string plate = txtPlateNumber.Text.Trim().ToUpper();
            string customerName = txtCustomerName.Text.Trim();
            string contact = txtContact.Text.Trim();
            string vehicleModel = txtVehicleModel.Text.Trim();
            string concern = txtConcern.Text.Trim();
            decimal cost = 0;
            decimal.TryParse(txtCost.Text.Trim(), out cost);

            try
            {
                conn.Open();

                // Step 1: check if this plate number already exists.
                SqlCommand findVehicle = new SqlCommand("SELECT VehicleID FROM Vehicles WHERE PlateNumber = @Plate", conn);
                findVehicle.Parameters.AddWithValue("@Plate", plate);
                object vehicleResult = findVehicle.ExecuteScalar();

                int vehicleId;

                if (vehicleResult != null)
                {
                    // Existing vehicle found — just use it.
                    vehicleId = (int)vehicleResult;
                }
                else
                {
                    // New vehicle — create the customer and vehicle first.
                    string firstname = customerName;
                    string lastname = "";
                    int spaceIndex = customerName.IndexOf(' ');
                    if (spaceIndex > -1)
                    {
                        firstname = customerName.Substring(0, spaceIndex);
                        lastname = customerName.Substring(spaceIndex + 1);
                    }

                    SqlCommand insertCustomer = new SqlCommand(
                        "INSERT INTO Customers (FirstName, LastName, ContactNumber, DateCreated) " +
                        "VALUES (@FirstName, @LastName, @Contact, GETDATE()); SELECT CAST(SCOPE_IDENTITY() AS INT);", conn);
                    insertCustomer.Parameters.AddWithValue("@FirstName", firstname);
                    insertCustomer.Parameters.AddWithValue("@LastName", lastname);
                    insertCustomer.Parameters.AddWithValue("@Contact", contact);
                    int newCustomerId = (int)insertCustomer.ExecuteScalar();

                    SqlCommand insertVehicle = new SqlCommand(
                        "INSERT INTO Vehicles (CustomerID, Model, PlateNumber) " +
                        "VALUES (@CustomerID, @Model, @Plate); SELECT CAST(SCOPE_IDENTITY() AS INT);", conn);
                    insertVehicle.Parameters.AddWithValue("@CustomerID", newCustomerId);
                    insertVehicle.Parameters.AddWithValue("@Model", vehicleModel);
                    insertVehicle.Parameters.AddWithValue("@Plate", plate);
                    vehicleId = (int)insertVehicle.ExecuteScalar();
                }

                // Step 2: look up the TechnicianID from the selected mechanic name.
                int technicianId = 0;
                if (!string.IsNullOrWhiteSpace(cmbMechanic.Text))
                {
                    SqlCommand findTech = new SqlCommand("SELECT TechnicianID FROM Technicians WHERE FullName = @Name", conn);
                    findTech.Parameters.AddWithValue("@Name", cmbMechanic.Text);
                    object techResult = findTech.ExecuteScalar();
                    if (techResult != null) technicianId = (int)techResult;
                }

                // Step 3: insert the job order itself.
                SqlCommand insertJobOrder = new SqlCommand(
                    "INSERT INTO JobOrder (VehicleID, TechnicianID, JobOrderNumber, DateCreated, CustomerConcern, Status, LaborCost) " +
                    "VALUES (@VehicleID, @TechnicianID, @JONumber, GETDATE(), @Concern, 'Pending', @Cost); " +
                    "SELECT CAST(SCOPE_IDENTITY() AS INT);", conn);
                insertJobOrder.Parameters.AddWithValue("@VehicleID", vehicleId);
                insertJobOrder.Parameters.AddWithValue("@TechnicianID", technicianId == 0 ? (object)DBNull.Value : technicianId);
                insertJobOrder.Parameters.AddWithValue("@JONumber", txtJONumber.Text);
                insertJobOrder.Parameters.AddWithValue("@Concern", concern);
                insertJobOrder.Parameters.AddWithValue("@Cost", cost);
                int newJobOrderId = (int)insertJobOrder.ExecuteScalar();

                // Step 4: link the selected service, if one was picked.
                if (!string.IsNullOrWhiteSpace(cmbServiceType.Text))
                {
                    SqlCommand findService = new SqlCommand("SELECT ServiceID FROM Services WHERE ServiceName = @Name", conn);
                    findService.Parameters.AddWithValue("@Name", cmbServiceType.Text);
                    object serviceResult = findService.ExecuteScalar();

                    if (serviceResult != null)
                    {
                        int serviceId = (int)serviceResult;
                        SqlCommand insertJobService = new SqlCommand(
                            "INSERT INTO JobOrderServices (JobOrderID, ServiceID, LaborCost) VALUES (@JobOrderID, @ServiceID, @Cost)", conn);
                        insertJobService.Parameters.AddWithValue("@JobOrderID", newJobOrderId);
                        insertJobService.Parameters.AddWithValue("@ServiceID", serviceId);
                        insertJobService.Parameters.AddWithValue("@Cost", cost);
                        insertJobService.ExecuteNonQuery();
                    }
                }

                parentControl.ReturnToMainView();
                }
                catch(Exception ex)
            {
                MessageBox.Show("An error occurred while saving the job order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            parentControl.ReturnToMainView();
        }

        private void JobOrderControlptAddJobOrder_Load(object sender, EventArgs e)
        {

        }
        // Load service types from the database into the combo box.
        private void LoadServiceTypes()
        {
            SqlCommand cmd = new SqlCommand("SELECT ServiceName FROM Services", conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cmbServiceType.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbServiceType.Items.Add(dt.Rows[i][0].ToString());
            }
        }
        private void LoadMechanics()
        {
            SqlCommand cmd = new SqlCommand("SELECT FullName FROM Technicians", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cmbMechanic.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbMechanic.Items.Add(dt.Rows[i][0].ToString());
            }
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
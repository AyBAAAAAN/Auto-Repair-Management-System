using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ARMSProtOne
{
    public partial class RecordsControlptAddRecords : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\GitHub Exports\\ARMS_DBInside\\Auto-Repair-Management-System\\Auto-Repair-Management-System\\ARMSProtOne\\ARMS_Database.mdf\";Integrated Security=True");

        private RecordsControl parentControl;

        // Raised when the user saves a new customer entry so the parent container can update its UI temporarily.

        public RecordsControlptAddRecords(RecordsControl parent )
        {
            InitializeComponent();
            parentControl = parent;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) || string.IsNullOrWhiteSpace(txtPlateNumber.Text))
            {
                MessageBox.Show("Owner Name and Plate Number are strictly required fields.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtCustomerName.Text.Trim();
            string contact = txtContactNumber.Text.Trim();
            string vehicle = txtVehicleModel.Text.Trim();
            string plate = txtPlateNumber.Text.Trim().ToUpper();

            string firstname = name;
            string lastname = "";
            int spaceIndex = name.IndexOf(' ');

            if (spaceIndex > -1)
            {
                firstname = name.Substring(0, spaceIndex);
                lastname = name.Substring(spaceIndex + 1);
            }

            // NOTE: added a space before "VALUES" on both queries below —
            // without it, "DateCreated)VALUES" becomes one invalid word to SQL.
            SqlCommand insertcustomer = new SqlCommand(
                "INSERT INTO Customers (FirstName, LastName, ContactNumber, DateCreated) " +
                "VALUES (@Firstname, @LastName, @Contact, GETDATE()); SELECT CAST(SCOPE_IDENTITY() AS INT);", conn);
            insertcustomer.Parameters.AddWithValue("@Firstname", firstname);
            insertcustomer.Parameters.AddWithValue("@LastName", lastname);
            insertcustomer.Parameters.AddWithValue("@Contact", contact);

            conn.Open();
            int newcustomerId = (int)insertcustomer.ExecuteScalar();

            // NOTE: added the missing closing ")" after @Plate, and the missing space before VALUES.
            SqlCommand insertVehicles = new SqlCommand(
                "INSERT INTO Vehicles (CustomerID, Model, PlateNumber) " +
                "VALUES (@CustomerId, @Model, @Plate)", conn);
            insertVehicles.Parameters.AddWithValue("@CustomerId", newcustomerId);
            insertVehicles.Parameters.AddWithValue("@Model", vehicle);
            insertVehicles.Parameters.AddWithValue("@Plate", plate);
            insertVehicles.ExecuteNonQuery();

            conn.Close();

            // Go back to the main Records screen and refresh the grid with the new row.
            parentControl.ReturnToMainView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelOperation();
        }
        public void CancelOperation()
        {
            parentControl.ReturnToMainView();
        }

        private void RecordsControlptAddRecords_Load(object sender, EventArgs e)
        {

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


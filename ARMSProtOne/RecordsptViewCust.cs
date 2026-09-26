using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ARMSProtOne
{
    public partial class RecordsptViewCust : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\GitHub Exports\\ARMS_DBInside\\Auto-Repair-Management-System\\Auto-Repair-Management-System\\ARMSProtOne\\ARMS_Database.mdf\";Integrated Security=True");
        public event EventHandler OperationClosed;
        private int customerId;

        public RecordsptViewCust(int customerId, string name, string contact)
        {
            InitializeComponent();

            this.customerId = customerId;
            txtCustomerName.Text = name;
            txtContactNumber.Text = contact;

            LoadRegisteredVehicles();
        }

        private void DgvRegisteredCars_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRegisteredCars.SelectedRows.Count > 0 && dgvRegisteredCars.SelectedRows[0].Cells[1].Value != null)
            {
                string targetPlate = dgvRegisteredCars.SelectedRows[0].Cells[1].Value.ToString();
                UpdateContextualVehicleHistoryLog(targetPlate);
            }
        }

        private void UpdateContextualVehicleHistoryLog(string plateNumber)
        {
            lblVehicleHistoryHeader.Text = $"Service Logs for: [{plateNumber}]";
            dgvVehicleServiceHistory.Rows.Clear();
        }

        private void btnEditToggle_Click(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text.Trim();
            string contact = txtContactNumber.Text.Trim();

            string firstname = name;
            string lastname = "";
            int spaceIndex = name.IndexOf(' ');
            if (spaceIndex > -1)
            {
                firstname = name.Substring(0, spaceIndex);
                lastname = name.Substring(spaceIndex + 1);
            }

            SqlCommand cmd = new SqlCommand("UPDATE Customers SET FirstName=@FirstName, LastName=@LastName, " +
                "       ContactNumber=@Contact WHERE CustomerID=@CustomerID", conn);
            cmd.Parameters.AddWithValue("@FirstName", firstname);
            cmd.Parameters.AddWithValue("@LastName", lastname);
            cmd.Parameters.AddWithValue("@Contact", contact);
            cmd.Parameters.AddWithValue("@CustomerID", customerId);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Customer information updated successfully.");
            
        }

        private void btnRegisterNewCar_Click(object sender, EventArgs e)
        {
            using (Form popup = new Form())
            {
                popup.Text = "Link New Vehicle Asset";
                popup.Size = new Size(300, 220);
                popup.FormBorderStyle = FormBorderStyle.FixedDialog;
                popup.StartPosition = FormStartPosition.CenterParent;
                popup.MaximizeBox = false; popup.MinimizeBox = false;

                Label lbl1 = new Label { Left = 20, Top = 15, Text = "Vehicle Model Brand:", Width = 240 };
                TextBox txt1 = new TextBox { Left = 20, Top = 35, Width = 240 };
                Label lbl2 = new Label { Left = 20, Top = 70, Text = "Plate Number ID:", Width = 240 };
                TextBox txt2 = new TextBox { Left = 20, Top = 90, Width = 240 };

                Button btnSub = new Button { Text = "Add Asset", Left = 20, Top = 135, Width = 110, DialogResult = DialogResult.OK };
                Button btnCan = new Button { Text = "Cancel", Left = 150, Top = 135, Width = 110, DialogResult = DialogResult.Cancel };

                popup.Controls.AddRange(new Control[] { lbl1, txt1, lbl2, txt2, btnSub, btnCan });

                if (popup.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(txt1.Text))
                {
                    string model = txt1.Text.Trim();
                    string plate = txt2.Text.Trim().ToUpper();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Vehicles (CustomerID, Model, PlateNumber) VALUES (@CustomerID, @Model, @Plate)", conn);
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    cmd.Parameters.AddWithValue("@Model", model);
                    cmd.Parameters.AddWithValue("@Plate", plate);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    LoadRegisteredVehicles();
                }
            }
        }

        private void LoadRegisteredVehicles() {

            SqlCommand cmd = new SqlCommand("SELECT Model, PlateNumber FROM Vehicles WHERE CustomerID = @CustomerID", conn);
            cmd.Parameters.AddWithValue("@CustomerID", customerId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvRegisteredCars.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                dgvRegisteredCars.Rows.Add(row[0], row[1]);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OperationClosed?.Invoke(this, EventArgs.Empty);
        }

        private void pnlViewHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
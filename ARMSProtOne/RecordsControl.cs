using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ARMSProtOne
{
    public partial class RecordsControl : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\GitHub Exports\\ARMS_DBInside\\Auto-Repair-Management-System\\Auto-Repair-Management-System\\ARMSProtOne\\ARMS_Database.mdf\";Integrated Security=True");
        public RecordsControl()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var addInputControl = new RecordsControlptAddRecords(this)
            {
                Dock = DockStyle.Fill
            };

            this.Controls.Clear();
            this.Controls.Add(addInputControl);
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer first.");
                return;
            }

            DataGridViewRow row = dgvCustomers.SelectedRows[0];
            int customerId = Convert.ToInt32(row.Cells[0].Value);
            string name = row.Cells[1].Value.ToString();
            string contact = row.Cells[2].Value.ToString();

            RecordsptViewCust view = new RecordsptViewCust(customerId, name, contact);

            view.OperationClosed += (s, ev) =>
            {
                this.Controls.Clear();
                this.InitializeComponent();
                LoadCustomers();
            };

            this.Controls.Clear();
            view.Dock = DockStyle.Fill;
            this.Controls.Add(view);
        }

        private void LoadCustomers()
        {
            string searchTerm = txtSearch.Text.Trim();

            SqlCommand cmd;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                cmd = new SqlCommand("SELECT c.CustomerID, (c.FirstName + ' ' + c.LastName) AS OwnerName, c.ContactNumber, " +
                        "MIN(v.Model) AS VehicleModel, MIN(v.PlateNumber) AS PlateNumber " +
                        "FROM Customers c LEFT JOIN Vehicles v ON v.CustomerID = c.CustomerID " +
                        "GROUP BY c.CustomerID, c.FirstName, c.LastName, c.ContactNumber", conn);
            }
            else
            {
                cmd = new SqlCommand("SELECT c.CustomerID, (c.FirstName + ' ' + c.LastName) AS OwnerName, c.ContactNumber, " +
                        "MIN(v.Model) AS VehicleModel, MIN(v.PlateNumber) AS PlateNumber " +
                        "FROM Customers c LEFT JOIN Vehicles v ON v.CustomerID = c.CustomerID " +
                        "WHERE c.FirstName LIKE @Search OR c.LastName LIKE @Search OR v.PlateNumber LIKE @Search " +
                        "GROUP BY c.CustomerID, c.FirstName, c.LastName, c.ContactNumber", conn);
                cmd.Parameters.AddWithValue("@Search", "%" + searchTerm + "%");
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvCustomers.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                dgvCustomers.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
            }

        }

        private void pnlTopToolbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RecordsControl_Load(object sender, EventArgs e)
        {

        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grpCustomerDatabase_Enter(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCustomers();
        }
        public void ReturnToMainView()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            LoadCustomers();
        }
    }

}
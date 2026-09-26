using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace ARMSProtOne
{
    public partial class AccountsControl : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\GitHub Exports\\ARMS_DBInside\\Auto-Repair-Management-System\\Auto-Repair-Management-System\\ARMSProtOne\\ARMS_Database.mdf\";Integrated Security=True");
        private bool showingStaff = true;

        public AccountsControl()
        {
            InitializeComponent();
            LoadStaff();
            LoadTechnicians();
            ShowStaffTab();
            // TODO: Load staff accounts and technicians from database.
        }

        private void btnTabStaff_Click(object sender, EventArgs e) => ShowStaffTab();
        private void btnTabTechnicians_Click(object sender, EventArgs e) => ShowTechniciansTab();


        public void LoadStaff()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT FullName, Username, Password, Role FROM Users", conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvStaffAccounts.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    dgvStaffAccounts.Rows.Add(row[0], row[1], row[2], row[3]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load staff accounts.\n\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void LoadTechnicians()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT FullName, ContactNumber FROM Technicians", conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvTechnicians.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    dgvTechnicians.Rows.Add(row[0], row[1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load technicians.\n\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void ShowStaffTab()
        {
            showingStaff = true;
            dgvStaffAccounts.Visible = true;
            dgvTechnicians.Visible = false;
            SetActiveTab(btnTabStaff, btnTabTechnicians);
            btnAddAccount.Text = "+ Add Staff Account";
        }

        private void ShowTechniciansTab()
        {
            showingStaff = false;
            dgvStaffAccounts.Visible = false;
            dgvTechnicians.Visible = true;
            SetActiveTab(btnTabTechnicians, btnTabStaff);
            btnAddAccount.Text = "+ Add Technician";
        }

        private void SetActiveTab(Button active, Button inactive)
        {
            active.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            active.ForeColor = Color.FromArgb(33, 37, 41);
            inactive.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            inactive.ForeColor = Color.Gray;
        }

        public void ReturnToMainAccounts(bool staffTab)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            if (staffTab) ShowStaffTab(); else ShowTechniciansTab();
        }

        // --- MAIN ACCOUNTS LIST ---

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (showingStaff)
                OpenAddEditStaff(false, null, null, null, null);
            else
                OpenAddEditTechnician(false, null, null);
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            if (showingStaff)
            {
                if (dgvStaffAccounts.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a staff account first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow row = dgvStaffAccounts.SelectedRows[0];
                OpenAddEditStaff(
                    true,
                    row.Cells["colStaffName"].Value?.ToString(),
                    row.Cells["colUsername"].Value?.ToString(),
                    row.Cells["colPassword"].Value?.ToString(),
                    row.Cells["colStaffContact"].Value?.ToString());
            }
            else
            {
                if (dgvTechnicians.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a technician first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow row = dgvTechnicians.SelectedRows[0];
                OpenAddEditTechnician(
                    true,
                    row.Cells["colTechName"].Value?.ToString(),
                    row.Cells["colTechContact"].Value?.ToString());
            }
        }

        // --- ADD/EDIT STAFF ACCOUNT ---

        private void OpenAddEditStaff(bool isEdit, string fullName, string username, string password, string contact)
        {
            AccountsControlAddEditStaff control = isEdit
                ? new AccountsControlAddEditStaff(this, fullName, username, password, contact)
                : new AccountsControlAddEditStaff(this);

            control.Dock = DockStyle.Fill;

            this.Controls.Clear();
            this.Controls.Add(control);
        }

        // --- ADD/EDIT TECHNICIAN ---

        private void OpenAddEditTechnician(bool isEdit, string fullName, string contact)
        {
            AccountsControlAddEditTechnician control = isEdit
                ? new AccountsControlAddEditTechnician(this, fullName, contact)
                : new AccountsControlAddEditTechnician(this);

            control.Dock = DockStyle.Fill;

            this.Controls.Clear();
            this.Controls.Add(control);
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlToolbar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ARMSProtOne
{
    public partial class AccountsControlAddEditTechnician : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\GitHub Exports\\ARMS_DBInside\\Auto-Repair-Management-System\\Auto-Repair-Management-System\\ARMSProtOne\\ARMS_Database.mdf\";Integrated Security=True");
        private AccountsControl parentControl;
        private bool isEditMode;
        private string originalFullName;

        public AccountsControlAddEditTechnician() : this(null)
        {
        }
        // Add Technician mode.
        public AccountsControlAddEditTechnician(AccountsControl parent)
        {
            InitializeComponent();
            isEditMode = false;
            parentControl = parent;

            lblFormTitle.Text = "Add Technician";
            btnDeleteTech.Visible = false;
        }

        // Edit Technician mode — pre-fills the form with the selected row's values.
        public AccountsControlAddEditTechnician(AccountsControl parent, string fullName, string contact)
        {
            InitializeComponent();
            isEditMode = true;
            parentControl = parent;
            originalFullName = fullName;

            lblFormTitle.Text = "Edit Technician";
            btnDeleteTech.Visible = true;

            txtFullName.Text = fullName;
            txtContact.Text = contact;
        }

        private void btnCancelTech_Click(object sender, EventArgs e)
        {
            parentControl.ReturnToMainAccounts(false);
        }

        private void btnDeleteTech_Click(object sender, EventArgs e)
        {
            // TODO: Persist removal to database.
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Technicians WHERE FullName = @FullName", conn);
                cmd.Parameters.AddWithValue("@FullName", originalFullName);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete technician.\n\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            parentControl.ReturnToMainAccounts(false);
        }

        private void btnSaveTech_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fullName = txtFullName.Text.Trim();
            string contact = txtContact.Text.Trim();

            try
            {
                conn.Open();

                if (isEditMode)
                {
                    // Update existing technician
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Technicians SET FullName = @FullName, ContactNumber = @Contact WHERE FullName = @OriginalFullName", conn);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Contact", contact);
                    cmd.Parameters.AddWithValue("@OriginalFullName", originalFullName);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Technicians (FullName, ContactNumber) VALUES (@FullName, @Contact)", conn);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Contact", contact);
                    cmd.ExecuteNonQuery();
                }

                parentControl.ReturnToMainAccounts(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save technician.\n\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void AccountsControlAddEditTechnician_Load(object sender, EventArgs e)
        {

        }
    }

    public class TechnicianSavedEventArgs : EventArgs
    {
        public bool IsEdit { get; }
        public string FullName { get; }
        public string Contact { get; }

        public TechnicianSavedEventArgs(bool isEdit, string fullName, string contact)
        {
            IsEdit = isEdit;
            FullName = fullName;
            Contact = contact;
        }
    }
}
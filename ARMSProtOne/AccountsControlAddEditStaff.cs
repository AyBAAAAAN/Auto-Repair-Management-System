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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ARMSProtOne
{
    public partial class AccountsControlAddEditStaff : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\GitHub Exports\\ARMS_DBInside\\Auto-Repair-Management-System\\Auto-Repair-Management-System\\ARMSProtOne\\ARMS_Database.mdf\";Integrated Security=True");
        private AccountsControl parentControl;
        private bool isEditMode;
        private string originalUsername;

        public AccountsControlAddEditStaff() : this(null)
        {
        }

        // Add Staff Account mode.
        public AccountsControlAddEditStaff(AccountsControl parent)
        {
            InitializeComponent();
            isEditMode = false;
            parentControl = parent;

            lblFormTitle.Text = "Add Staff Account";
            btnDeleteSA.Visible = false;
        }

        // Edit Staff Account mode — pre-fills the form with the selected row's values.
        public AccountsControlAddEditStaff(AccountsControl parent, string fullName, string username, string password, string contact)
        {
            InitializeComponent();
            parentControl = parent;
            isEditMode = true;
            originalUsername = username;

            lblFormTitle.Text = "Edit Staff Account";
            btnDeleteSA.Visible = true;

            txtFullName.Text = fullName;
            txtUsername.Text = username;
            txtPassword.Text = password;
            txtContact.Text = contact;
        }

        private void btnCancelSA_Click(object sender, EventArgs e)
        {
            parentControl.ReturnToMainAccounts(true);
        }

        private void btnDeleteSA_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE Username = @Username", conn);
                cmd.Parameters.AddWithValue("@Username", originalUsername);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete staff account.\n\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            parentControl.ReturnToMainAccounts(true);
        }

        private void btnSaveSA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Full Name, User Name, and Password are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string contact = txtContact.Text.Trim();

            try
            {
                conn.Open();

                if (isEditMode)
                {
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Users SET FullName = @FullName, Username = @Username, Password = @Password " +
                        "WHERE Username = @OriginalUsername", conn);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@OriginalUsername", originalUsername);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Users (Username, Password, FullName, Role) VALUES (@Username, @Password, @FullName, 'Staff')", conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.ExecuteNonQuery();
                }

                parentControl.ReturnToMainAccounts(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save staff account.\n\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void AccountsControlAddEditStaff_Load(object sender, EventArgs e)
        {

        }
    }

    public class StaffAccountSavedEventArgs : EventArgs
    {
        public bool IsEdit { get; }
        public string FullName { get; }
        public string Username { get; }
        public string Password { get; }
        public string Contact { get; }

        public StaffAccountSavedEventArgs(bool isEdit, string fullName, string username, string password, string contact)
        {
            IsEdit = isEdit;
            FullName = fullName;
            Username = username;
            Password = password;
            Contact = contact;
        }
    }
}
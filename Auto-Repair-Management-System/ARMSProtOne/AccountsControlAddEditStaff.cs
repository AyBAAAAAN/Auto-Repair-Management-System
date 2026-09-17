using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMSProtOne
{
    public partial class AccountsControlAddEditStaff : UserControl
    {
        public event EventHandler OperationCancelled;
        public event EventHandler OperationDeleteRequested;
        public event EventHandler<StaffAccountSavedEventArgs> OperationSaved;

        private readonly bool isEditMode;

        // Add Staff Account mode.
        public AccountsControlAddEditStaff()
        {
            InitializeComponent();
            isEditMode = false;

            lblFormTitle.Text = "Add Staff Account";
            btnDeleteSA.Visible = false;
        }

        // Edit Staff Account mode — pre-fills the form with the selected row's values.
        public AccountsControlAddEditStaff(string fullName, string username, string password, string contact)
        {
            InitializeComponent();
            isEditMode = true;

            lblFormTitle.Text = "Edit Staff Account";
            btnDeleteSA.Visible = true;

            txtFullName.Text = fullName;
            txtUsername.Text = username;
            txtPassword.Text = password;
            txtContact.Text = contact;
        }

        private void btnCancelSA_Click(object sender, EventArgs e)
        {
            OperationCancelled?.Invoke(this, EventArgs.Empty);
        }

        private void btnDeleteSA_Click(object sender, EventArgs e)
        {
            // TODO: Persist removal to database.
            OperationDeleteRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnSaveSA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Full Name, User Name, and Password are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Persist staff account to database.
            OperationSaved?.Invoke(this, new StaffAccountSavedEventArgs(
                isEditMode,
                txtFullName.Text.Trim(),
                txtUsername.Text.Trim(),
                txtPassword.Text.Trim(),
                txtContact.Text.Trim()));
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
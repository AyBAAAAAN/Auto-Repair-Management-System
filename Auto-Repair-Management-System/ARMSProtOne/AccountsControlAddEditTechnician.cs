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
    public partial class AccountsControlAddEditTechnician : UserControl
    {
        public event EventHandler OperationCancelled;
        public event EventHandler OperationDeleteRequested;
        public event EventHandler<TechnicianSavedEventArgs> OperationSaved;

        private readonly bool isEditMode;

        // Add Technician mode.
        public AccountsControlAddEditTechnician()
        {
            InitializeComponent();
            isEditMode = false;

            lblFormTitle.Text = "Add Technician";
            btnDeleteTech.Visible = false;
        }

        // Edit Technician mode — pre-fills the form with the selected row's values.
        public AccountsControlAddEditTechnician(string fullName, string contact)
        {
            InitializeComponent();
            isEditMode = true;

            lblFormTitle.Text = "Edit Technician";
            btnDeleteTech.Visible = true;

            txtFullName.Text = fullName;
            txtContact.Text = contact;
        }

        private void btnCancelTech_Click(object sender, EventArgs e)
        {
            OperationCancelled?.Invoke(this, EventArgs.Empty);
        }

        private void btnDeleteTech_Click(object sender, EventArgs e)
        {
            // TODO: Persist removal to database.
            OperationDeleteRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnSaveTech_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Persist technician to database.
            OperationSaved?.Invoke(this, new TechnicianSavedEventArgs(
                isEditMode,
                txtFullName.Text.Trim(),
                txtContact.Text.Trim()));
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
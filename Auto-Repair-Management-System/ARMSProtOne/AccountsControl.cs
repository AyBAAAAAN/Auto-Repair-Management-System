using System;
using System.Drawing;
using System.Windows.Forms;

namespace ARMSProtOne
{
    public partial class AccountsControl : UserControl
    {
        private bool showingStaff = true;

        public AccountsControl()
        {
            InitializeComponent();
            ShowStaffTab();
            // TODO: Load staff accounts and technicians from database.
        }

        private void btnTabStaff_Click(object sender, EventArgs e) => ShowStaffTab();
        private void btnTabTechnicians_Click(object sender, EventArgs e) => ShowTechniciansTab();

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

        private void ReturnToMainAccounts(bool staffTab)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            if (staffTab) ShowStaffTab(); else ShowTechniciansTab();
        }

        // --- MAIN ACCOUNTS LIST ---

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (showingStaff)
                OpenAddEditStaff(isEdit: false, fullName: null, username: null, password: null, contact: null);
            else
                OpenAddEditTechnician(isEdit: false, fullName: null, contact: null);
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

                var row = dgvStaffAccounts.SelectedRows[0];
                OpenAddEditStaff(
                    isEdit: true,
                    fullName: row.Cells["colStaffName"].Value?.ToString(),
                    username: row.Cells["colUsername"].Value?.ToString(),
                    password: row.Cells["colPassword"].Value?.ToString(),
                    contact: row.Cells["colStaffContact"].Value?.ToString());
            }
            else
            {
                if (dgvTechnicians.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a technician first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var row = dgvTechnicians.SelectedRows[0];
                OpenAddEditTechnician(
                    isEdit: true,
                    fullName: row.Cells["colTechName"].Value?.ToString(),
                    contact: row.Cells["colTechContact"].Value?.ToString());
            }
        }

        // --- ADD/EDIT STAFF ACCOUNT ---

        private void OpenAddEditStaff(bool isEdit, string fullName, string username, string password, string contact)
        {
            var control = isEdit
                ? new AccountsControlAddEditStaff(fullName, username, password, contact) { Dock = DockStyle.Fill }
                : new AccountsControlAddEditStaff { Dock = DockStyle.Fill };

            control.OperationCancelled += (s, ev) => ReturnToMainAccounts(true);

            control.OperationDeleteRequested += (s, ev) =>
            {
                if (dgvStaffAccounts.SelectedRows.Count > 0)
                    dgvStaffAccounts.Rows.Remove(dgvStaffAccounts.SelectedRows[0]);

                // TODO: Persist removal to database.
                ReturnToMainAccounts(true);
            };

            control.OperationSaved += (s, ev) =>
            {
                if (ev.IsEdit && dgvStaffAccounts.SelectedRows.Count > 0)
                {
                    var row = dgvStaffAccounts.SelectedRows[0];
                    row.Cells["colStaffName"].Value = ev.FullName;
                    row.Cells["colUsername"].Value = ev.Username;
                    row.Cells["colPassword"].Value = ev.Password;
                    row.Cells["colStaffContact"].Value = ev.Contact;
                }
                else
                {
                    dgvStaffAccounts.Rows.Add(ev.FullName, ev.Username, ev.Password, ev.Contact);
                }

                // TODO: Persist staff account to database.
                ReturnToMainAccounts(true);
            };

            this.Controls.Clear();
            this.Controls.Add(control);
        }

        // --- ADD/EDIT TECHNICIAN ---

        private void OpenAddEditTechnician(bool isEdit, string fullName, string contact)
        {
            var control = isEdit
                ? new AccountsControlAddEditTechnician(fullName, contact) { Dock = DockStyle.Fill }
                : new AccountsControlAddEditTechnician { Dock = DockStyle.Fill };

            control.OperationCancelled += (s, ev) => ReturnToMainAccounts(false);

            control.OperationDeleteRequested += (s, ev) =>
            {
                if (dgvTechnicians.SelectedRows.Count > 0)
                    dgvTechnicians.Rows.Remove(dgvTechnicians.SelectedRows[0]);

                // TODO: Persist removal to database.
                ReturnToMainAccounts(false);
            };

            control.OperationSaved += (s, ev) =>
            {
                if (ev.IsEdit && dgvTechnicians.SelectedRows.Count > 0)
                {
                    var row = dgvTechnicians.SelectedRows[0];
                    row.Cells["colTechName"].Value = ev.FullName;
                    row.Cells["colTechContact"].Value = ev.Contact;
                }
                else
                {
                    dgvTechnicians.Rows.Add(ev.FullName, ev.Contact);
                }

                // TODO: Persist technician to database.
                ReturnToMainAccounts(false);
            };

            this.Controls.Clear();
            this.Controls.Add(control);
        }
    }
}
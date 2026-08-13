using System;
using System.Drawing;
using System.Windows.Forms;

namespace ARMSProtOne
{
    public partial class RecordsptViewCust : UserControl
    {
        public event EventHandler OperationClosed;
        private bool isEditMode = false;

        public RecordsptViewCust(string name, string contact, string baseVehicle, string basePlate)
        {
            InitializeComponent();

            txtCustomerName.Text = name;
            txtContactNumber.Text = contact;

            SetFieldsReadOnly(true);

            // TODO: Load registered vehicles and service history for this customer from database.
            dgvRegisteredCars.SelectionChanged += DgvRegisteredCars_SelectionChanged;
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
            // TODO: Fetch service history for this plate number from database.
        }

        private void btnEditToggle_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                isEditMode = true;
                SetFieldsReadOnly(false);
                btnEditToggle.Text = "Save Profile Changes";
                btnEditToggle.BackColor = Color.FromArgb(40, 167, 69);
            }
            else
            {
                isEditMode = false;
                SetFieldsReadOnly(true);
                btnEditToggle.Text = "Edit Profile Info";
                btnEditToggle.BackColor = Color.FromArgb(0, 123, 255);
                // TODO: Persist profile changes to database.
            }
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
                    // TODO: Persist new vehicle to database.
                    dgvRegisteredCars.Rows.Add(txt1.Text.Trim(), txt2.Text.Trim().ToUpper());
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OperationClosed?.Invoke(this, EventArgs.Empty);
        }

        private void SetFieldsReadOnly(bool state)
        {
            txtCustomerName.ReadOnly = state;
            txtContactNumber.ReadOnly = state;
            txtCustomerName.BackColor = state ? Color.White : Color.LightYellow;
            txtContactNumber.BackColor = state ? Color.White : Color.LightYellow;
        }
    }
}
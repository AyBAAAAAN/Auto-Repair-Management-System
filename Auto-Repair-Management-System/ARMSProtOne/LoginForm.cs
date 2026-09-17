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
    public partial class LoginForm : Form
    {
        // TODO: Replace with real authentication against the Users table in the database.
        // Demo accounts are hardcoded for now so the flow can be demonstrated end-to-end.
        private const string DemoAdminUser = "admin";
        private const string DemoAdminPass = "1234";
        private const string DemoStaffUser = "staff";
        private const string DemoStaffPass = "1234";

        public LoginForm()
        {
            InitializeComponent();
            CenterCard();
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            CenterCard();
        }

        private void CenterCard()
        {
            pnlCard.Location = new System.Drawing.Point(
                (this.ClientSize.Width - pnlCard.Width) / 2,
                (this.ClientSize.Height - pnlCard.Height) / 2);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Replace this check with a database lookup (Users table) once persistence is wired up.
            bool isValid =
                (username.Equals(DemoAdminUser, StringComparison.OrdinalIgnoreCase) && password == DemoAdminPass) ||
                (username.Equals(DemoStaffUser, StringComparison.OrdinalIgnoreCase) && password == DemoStaffPass);

            if (!isValid)
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            OpenMainSystem();
        }

        private void OpenMainSystem()
        {
            this.Hide();

            var mainForm = new BaseForm();
            mainForm.FormClosed += (s, ev) => this.Close();
            mainForm.Show();
        }
    }
}
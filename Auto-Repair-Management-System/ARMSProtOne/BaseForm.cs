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
    public partial class BaseForm : Form
    {

        //GOODLUCK BABYE
        //HAHAHAHAHHAHAHAHHA
        public BaseForm()
        {
            InitializeComponent();
            btnDashboard_Click(this, System.EventArgs.Empty);
        }

        private void btnDashboard_Click(object sender, System.EventArgs e)
        {
            SetActiveMenuItem(btnDashboard);
            LoadControl(new DashboardControl());
        }

        private void btnRecord_Click(object sender, System.EventArgs e)
        {
            SetActiveMenuItem(btnRecord);
            LoadControl(new RecordsControl());
        }

        private void btnJobOrder_Click(object sender, System.EventArgs e)
        {
            SetActiveMenuItem(btnJobOrder);
            LoadControl(new JobOrderControl());
        }

        private void btnSchedule_Click(object sender, System.EventArgs e)
        {
            SetActiveMenuItem(btnSchedule);
            LoadControl(new ScheduleControl());
        }

        private void btnPayment_Click(object sender, System.EventArgs e)
        {
            SetActiveMenuItem(btnPayment);
            LoadControl(new PaymentControl());
        }

        private void btnInventory_Click(object sender, System.EventArgs e)
        {
            SetActiveMenuItem(btnInventory);
            LoadControl(new InventoryControl());
        }

        private void btnReport_Click(object sender, System.EventArgs e)
        {
            SetActiveMenuItem(btnReport);
            LoadControl(new ReportControl());
        }

        private void btnAccounts_Click(object sender, System.EventArgs e)
        {
            SetActiveMenuItem(btnAccounts);
            LoadControl(new AccountsControl());
        }

        private void btnLogout_Click(object sender, System.EventArgs e)
        {
            SetActiveMenuItem(btnLogout);
            new LoginForm().Show();
            Hide();
        }
        private void LoadControl(UserControl control)
        {
            pnlContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(control);
        }

        protected void SetActiveMenuItem(Button activeButton)
        {
            Button[] mainButtons = { btnDashboard, btnRecord, btnJobOrder, btnSchedule, btnPayment };

            foreach (Button btn in mainButtons)
            {
                btn.BackColor = Color.FromArgb(52, 58, 64);
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            }

            Button[] adminButtons = { btnInventory, btnReport, btnAccounts };
            foreach (Button btn in adminButtons)
            {
                btn.BackColor = Color.FromArgb(52, 58, 64);
                btn.ForeColor = Color.Gainsboro;
                btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            }

            activeButton.BackColor = Color.White;
            activeButton.ForeColor = Color.FromArgb(52, 58, 64);
            activeButton.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        }
    }
}

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
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            dgvRecentJobOrders.Rows.Add("JO-1001", "ABC-1234", "AC Cleaning", "Ongoing");
            dgvRecentJobOrders.Rows.Add("JO-1002", "XYZ-7890", "Wiring Repair", "Pending");
            dgvRecentJobOrders.Rows.Add("JO-1003", "NBM-4557", "Alternator", "Pending");
            dgvRecentJobOrders.Rows.Add("JO-1004", "BBB-7510", "Starter Repair", "Ongoing");

            lstLowStockAlerts.Items.Add("⚠  Freon R134a");
            lstLowStockAlerts.Items.Add("⚠  8A Fuse");
            lstLowStockAlerts.Items.Add("⚠  Freon R134a");
        }
    }
}

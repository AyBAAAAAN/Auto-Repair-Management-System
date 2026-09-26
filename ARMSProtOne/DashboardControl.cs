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
    public partial class DashboardControl : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\GitHub Exports\\ARMS_DBInside\\Auto-Repair-Management-System\\Auto-Repair-Management-System\\ARMSProtOne\\ARMS_Database.mdf\";Integrated Security=True");
        public DashboardControl()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            //Display Active Repairs
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM JobOrder WHERE Status = 'Ongoing'", conn);
            conn.Open();
            int ongoingCount = (int)cmd.ExecuteScalar();
            conn.Close();
            lblActiveRepairsValue.Text = ongoingCount.ToString();

            //Display Scheduled Today
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM HomeService WHERE CAST(HomeServiceDate AS DATE) = CAST(GETDATE() AS DATE)", conn);
            conn.Open();
            int scheduledToday = (int)cmd2.ExecuteScalar();
            conn.Close();
            lblScheduledTodayValue.Text = scheduledToday.ToString();

            //Display Today's Sales
            SqlCommand cmd3 = new SqlCommand("SELECT ISNULL(SUM(AmountPaid), 0) FROM Payments WHERE CAST(PaymentDate AS DATE) = CAST(GETDATE() AS DATE)", conn);
            conn.Open();
            decimal todaysSales = (decimal)cmd3.ExecuteScalar();
            conn.Close();
            lblTodaysSalesValue.Text = "₱" + todaysSales.ToString("N2");

            //Display Pending Payments
            SqlCommand cmd4 = new SqlCommand("SELECT COUNT(*) FROM Payments WHERE PaymentStatus IN ('Unpaid', 'Partial')", conn);
            conn.Open();
            int pendingPayments = (int)cmd4.ExecuteScalar();
            conn.Close();
            lblPendingPaymentsValue.Text = pendingPayments.ToString();

            //Display Recent Job Orders
            dgvRecentJobOrders.Rows.Clear();
            SqlCommand cmd5 = new SqlCommand("SELECT TOP 10 jo.JobOrderNumber, v.PlateNumber, jo.CustomerConcern, jo.Status FROM JobOrder jo JOIN Vehicles v ON jo.VehicleID = v.VehicleID ORDER BY jo.DateCreated DESC", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd5);
            DataTable recentJobsTable = new DataTable();
            adapter.Fill(recentJobsTable);

            for (int i = 0; i < recentJobsTable.Rows.Count; i++) {
                DataRow row = recentJobsTable.Rows[i];
                dgvRecentJobOrders.Rows.Add(row[0], row[1], row[2], row[3]);
            }

            //Display Low Stock Alerts
            lstLowStockAlerts.Items.Clear();
            SqlCommand smd6 = new SqlCommand("SELECT ItemName FROM Inventory WHERE Quantity <= MinimumStock", conn);
            SqlDataAdapter adapter2 = new SqlDataAdapter(smd6);
            DataTable lowStockTable = new DataTable();
            adapter2.Fill(lowStockTable);

            for (int i = 0; i < lowStockTable.Rows.Count; i++) {
                
                lstLowStockAlerts.Items.Add("⚠  " + lowStockTable.Rows[i][0]);
            }
        }


        private void DashboardControl_Load(object sender, EventArgs e)
        {

        }

    }
}

using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace ARMSProtOne
{
    public partial class ReportControl : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ASMR_Database;Integrated Security=True;Encrypt=False");
        public ReportControl()
        {
            InitializeComponent();
            // TODO: Load report data from database.
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlSalesReport.Visible = false;
            pnlDPSReport.Visible = false;
            pnlJOReport.Visible = false;

            switch (cmbReportType.Text)
            {
                case "Direct Part Sales Report":
                    pnlDPSReport.Visible = true;
                    break;
                case "Job Order Report":
                    pnlJOReport.Visible = true;
                    break;
                default:
                    pnlSalesReport.Visible = true;
                    break;
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // TODO: Query and populate the selected report type from database based on date/period filter.
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            // TODO: Export the current report to file.
        }

        private void pnlJOReport_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
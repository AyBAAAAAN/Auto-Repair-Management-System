using System;
using System.Windows.Forms;

namespace ARMSProtOne
{
    public partial class ReportControl : UserControl
    {
        public ReportControl()
        {
            InitializeComponent();
            cmbReportType.Items.AddRange(new object[] { "Sales Report", "Direct Part Sales Report", "Job Order Report" });
            cmbReportType.SelectedIndex = 0;
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
    }
}
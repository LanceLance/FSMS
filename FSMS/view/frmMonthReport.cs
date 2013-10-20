using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Collections;
using FSMS.controler;

namespace FSMS.view
{
    public partial class frmMonthReport : Form
    {
        public frmMonthReport()
        {
            InitializeComponent();

            dtpMonthReport.Format = DateTimePickerFormat.Custom;
            dtpMonthReport.CustomFormat = "yyyy-MM";

        }

        private void btnGenMonthReport_Click(object sender, EventArgs e)
        {

            ArrayList dayReportList = ReportMgmControler.GenMonthReport(this.dtpMonthReport.Text);
            this.t_MonthReportTableAdapter.Fill(this.fSMFDataSet.T_MonthReport);
            ReportParameter rp1 = new ReportParameter("month", this.dtpMonthReport.Text);
            ReportParameter rp2 = new ReportParameter("monthPrintWorker", this.tbxMonthPrintWorker.Text);
            this.rvMonthReport.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2 });
            this.rvMonthReport.RefreshReport();
        }

        private void frmMonthReport_Load(object sender, EventArgs e)
        {
            
        }
    }
}
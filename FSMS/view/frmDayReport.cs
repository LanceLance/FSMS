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
    public partial class frmDayReport : Form
    {
        public frmDayReport()
        {
            InitializeComponent();
            dtpDayReport.Format = DateTimePickerFormat.Custom;
            dtpDayReport.CustomFormat = "yyyy-MM-dd dddd";
            
        }

        private void btnGenDayReport_Click(object sender, EventArgs e)
        {
            
            ArrayList dayReportList = ReportMgmControler.GenDayReport(this.dtpDayReport.Text);
            
            this.t_DayReportTableAdapter.Fill(this.fSMFDataSet.T_DayReport);
            ReportParameter rp1 = new ReportParameter("day", this.dtpDayReport.Text);
            ReportParameter rp2 = new ReportParameter("printWorker", this.tbxPrintWorker.Text);
            this.rvDayReport.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2 });
            this.rvDayReport.RefreshReport();
        }

        private void frmDayReport_Load(object sender, EventArgs e)
        {
        }

    }
}
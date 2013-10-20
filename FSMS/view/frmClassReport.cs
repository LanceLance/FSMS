using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FSMS.controler;
using FSMS.common;
using FSMS.model;
using Microsoft.Reporting.WinForms;

namespace FSMS.view
{
    public partial class frmClassReport : Form
    {
        public frmClassReport()
        {
            InitializeComponent();
            ReportMgmControler.BindClassReport(ref dgvClassReport);

            dtpBeginTime.Format = DateTimePickerFormat.Custom;
            dtpBeginTime.CustomFormat = "yyyy-MM-dd HH:mm:ss dddd";
            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss dddd";
        }

        /// <summary>
        /// 筛选查询按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectClass_Click(object sender, EventArgs e)
        {
            string startTime, endTime;
            startTime = dtpBeginTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
            endTime = dtpEndTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
            ReportMgmControler.BindClassReport(ref dgvClassReport, startTime, endTime);
        }

        /// <summary>
        /// 生成班报表按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenReport_Click(object sender, EventArgs e)
        {

            try
            {
                ClassCalendar cc = new ClassCalendar();
                cc.StartTime = tbxStartTime.Text;
                cc.EndTime = tbxEndTime.Text;
                cc.ClassName = tbxClassName.Text;

                ArrayList classReportList = ReportMgmControler.GenClassReport(cc);


                this.t_ClassReportTableAdapter.Fill(this.fSMFDataSet.T_ClassReport);
                ReportParameter rp1 = new ReportParameter("StartTime", this.tbxStartTime.Text);
                ReportParameter rp2 = new ReportParameter("EndTime", this.tbxEndTime.Text);
                ReportParameter rp3 = new ReportParameter("ClassName", this.tbxClassName.Text);
                this.rvClassReport.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2, rp3 });
                this.rvClassReport.RefreshReport();

            }
            catch(Exception ex)
            {
                Console.WriteLine("纺丝线异常："+ex.Message);
            }
        }

        /// <summary>
        /// 班组信息点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClassReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(dgvClassReport.SelectedRows.Count == 0))
                {
                    tbxStartTime.Text = dgvClassReport.SelectedRows[0].Cells["StartTime"].Value.ToString().Trim();
                    tbxEndTime.Text = dgvClassReport.SelectedRows[0].Cells["EndTime"].Value.ToString().Trim();
                    tbxClassName.Text = dgvClassReport.SelectedRows[0].Cells["ClassName"].Value.ToString().Trim();
                }
            }
            catch
            {                
                return;
            }

        }

        /// <summary>
        /// 班组信息选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClassReport_SelectionChanged(object sender, EventArgs e)
        {
            dgvClassReport_Click(sender,e);
        }

        private void frmClassReport_Load(object sender, EventArgs e)
        {
           
        }
    }
}
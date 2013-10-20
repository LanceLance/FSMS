namespace FSMS.view
{
    partial class frmDayReport
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tDayReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fSMFDataSet = new FSMS.FSMFDataSet();
            this.dtpDayReport = new System.Windows.Forms.DateTimePicker();
            this.btnGenDayReport = new System.Windows.Forms.Button();
            this.rvDayReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.t_DayReportTableAdapter = new FSMS.FSMFDataSetTableAdapters.T_DayReportTableAdapter();
            this.tbxPrintWorker = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tDayReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSMFDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tDayReportBindingSource
            // 
            this.tDayReportBindingSource.DataMember = "T_DayReport";
            this.tDayReportBindingSource.DataSource = this.fSMFDataSet;
            // 
            // fSMFDataSet
            // 
            this.fSMFDataSet.DataSetName = "FSMFDataSet";
            this.fSMFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpDayReport
            // 
            this.dtpDayReport.Location = new System.Drawing.Point(59, 10);
            this.dtpDayReport.Name = "dtpDayReport";
            this.dtpDayReport.Size = new System.Drawing.Size(184, 21);
            this.dtpDayReport.TabIndex = 0;
            // 
            // btnGenDayReport
            // 
            this.btnGenDayReport.Location = new System.Drawing.Point(434, 8);
            this.btnGenDayReport.Name = "btnGenDayReport";
            this.btnGenDayReport.Size = new System.Drawing.Size(100, 23);
            this.btnGenDayReport.TabIndex = 2;
            this.btnGenDayReport.Text = "生成日报表";
            this.btnGenDayReport.UseVisualStyleBackColor = true;
            this.btnGenDayReport.Click += new System.EventHandler(this.btnGenDayReport_Click);
            // 
            // rvDayReport
            // 
            this.rvDayReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "FSMFDataSet_T_DayReport";
            reportDataSource2.Value = this.tDayReportBindingSource;
            this.rvDayReport.LocalReport.DataSources.Add(reportDataSource2);
            this.rvDayReport.LocalReport.ReportEmbeddedResource = "FSMS.view.DayReport.rdlc";
            this.rvDayReport.Location = new System.Drawing.Point(12, 39);
            this.rvDayReport.Name = "rvDayReport";
            this.rvDayReport.Size = new System.Drawing.Size(968, 615);
            this.rvDayReport.TabIndex = 4;
            // 
            // t_DayReportTableAdapter
            // 
            this.t_DayReportTableAdapter.ClearBeforeFill = true;
            // 
            // tbxPrintWorker
            // 
            this.tbxPrintWorker.Location = new System.Drawing.Point(308, 10);
            this.tbxPrintWorker.Name = "tbxPrintWorker";
            this.tbxPrintWorker.Size = new System.Drawing.Size(120, 21);
            this.tbxPrintWorker.TabIndex = 5;
            this.tbxPrintWorker.Text = "                ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "制表人：";
            // 
            // frmDayReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 666);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPrintWorker);
            this.Controls.Add(this.rvDayReport);
            this.Controls.Add(this.btnGenDayReport);
            this.Controls.Add(this.dtpDayReport);
            this.Name = "frmDayReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "日报表";
            this.Load += new System.EventHandler(this.frmDayReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tDayReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSMFDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDayReport;
        private System.Windows.Forms.Button btnGenDayReport;
        private Microsoft.Reporting.WinForms.ReportViewer rvDayReport;
        private FSMFDataSet fSMFDataSet;
        private System.Windows.Forms.BindingSource tDayReportBindingSource;
        private FSMS.FSMFDataSetTableAdapters.T_DayReportTableAdapter t_DayReportTableAdapter;
        private System.Windows.Forms.TextBox tbxPrintWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
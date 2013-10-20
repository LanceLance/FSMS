namespace FSMS.view
{
    partial class frmMonthReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tMonthReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fSMFDataSet = new FSMS.FSMFDataSet();
            this.dtpMonthReport = new System.Windows.Forms.DateTimePicker();
            this.btnGenMonthReport = new System.Windows.Forms.Button();
            this.rvMonthReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.t_MonthReportTableAdapter = new FSMS.FSMFDataSetTableAdapters.T_MonthReportTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMonthPrintWorker = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tMonthReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSMFDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tMonthReportBindingSource
            // 
            this.tMonthReportBindingSource.DataMember = "T_MonthReport";
            this.tMonthReportBindingSource.DataSource = this.fSMFDataSet;
            // 
            // fSMFDataSet
            // 
            this.fSMFDataSet.DataSetName = "FSMFDataSet";
            this.fSMFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpMonthReport
            // 
            this.dtpMonthReport.Location = new System.Drawing.Point(59, 12);
            this.dtpMonthReport.Name = "dtpMonthReport";
            this.dtpMonthReport.Size = new System.Drawing.Size(157, 21);
            this.dtpMonthReport.TabIndex = 0;
            // 
            // btnGenMonthReport
            // 
            this.btnGenMonthReport.Location = new System.Drawing.Point(407, 10);
            this.btnGenMonthReport.Name = "btnGenMonthReport";
            this.btnGenMonthReport.Size = new System.Drawing.Size(100, 23);
            this.btnGenMonthReport.TabIndex = 1;
            this.btnGenMonthReport.Text = "生成月报表";
            this.btnGenMonthReport.UseVisualStyleBackColor = true;
            this.btnGenMonthReport.Click += new System.EventHandler(this.btnGenMonthReport_Click);
            // 
            // rvMonthReport
            // 
            this.rvMonthReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "FSMFDataSet_T_MonthReport";
            reportDataSource1.Value = this.tMonthReportBindingSource;
            this.rvMonthReport.LocalReport.DataSources.Add(reportDataSource1);
            this.rvMonthReport.LocalReport.ReportEmbeddedResource = "FSMS.view.MonthReport.rdlc";
            this.rvMonthReport.Location = new System.Drawing.Point(12, 39);
            this.rvMonthReport.Name = "rvMonthReport";
            this.rvMonthReport.Size = new System.Drawing.Size(968, 615);
            this.rvMonthReport.TabIndex = 2;
            // 
            // t_MonthReportTableAdapter
            // 
            this.t_MonthReportTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "月份：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "制表人：";
            // 
            // tbxMonthPrintWorker
            // 
            this.tbxMonthPrintWorker.Location = new System.Drawing.Point(281, 12);
            this.tbxMonthPrintWorker.Name = "tbxMonthPrintWorker";
            this.tbxMonthPrintWorker.Size = new System.Drawing.Size(120, 21);
            this.tbxMonthPrintWorker.TabIndex = 5;
            // 
            // frmMonthReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 666);
            this.Controls.Add(this.tbxMonthPrintWorker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rvMonthReport);
            this.Controls.Add(this.btnGenMonthReport);
            this.Controls.Add(this.dtpMonthReport);
            this.Name = "frmMonthReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "月报表";
            this.Load += new System.EventHandler(this.frmMonthReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tMonthReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSMFDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpMonthReport;
        private System.Windows.Forms.Button btnGenMonthReport;
        private Microsoft.Reporting.WinForms.ReportViewer rvMonthReport;
        private FSMFDataSet fSMFDataSet;
        private System.Windows.Forms.BindingSource tMonthReportBindingSource;
        private FSMS.FSMFDataSetTableAdapters.T_MonthReportTableAdapter t_MonthReportTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMonthPrintWorker;
    }
}
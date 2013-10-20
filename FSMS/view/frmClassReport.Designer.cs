namespace FSMS.view
{
    partial class frmClassReport
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
            this.tClassReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fSMFDataSet = new FSMS.FSMFDataSet();
            this.dgvClassReport = new System.Windows.Forms.DataGridView();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenReport = new System.Windows.Forms.Button();
            this.btnSelectClass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBeginTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxStartTime = new System.Windows.Forms.TextBox();
            this.tbxEndTime = new System.Windows.Forms.TextBox();
            this.tbxClassName = new System.Windows.Forms.TextBox();
            this.rvClassReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.t_ClassReportTableAdapter = new FSMS.FSMFDataSetTableAdapters.T_ClassReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tClassReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSMFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassReport)).BeginInit();
            this.SuspendLayout();
            // 
            // tClassReportBindingSource
            // 
            this.tClassReportBindingSource.DataMember = "T_ClassReport";
            this.tClassReportBindingSource.DataSource = this.fSMFDataSet;
            // 
            // fSMFDataSet
            // 
            this.fSMFDataSet.DataSetName = "FSMFDataSet";
            this.fSMFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvClassReport
            // 
            this.dgvClassReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvClassReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartTime,
            this.EndTime,
            this.ClassName});
            this.dgvClassReport.Location = new System.Drawing.Point(12, 114);
            this.dgvClassReport.Name = "dgvClassReport";
            this.dgvClassReport.ReadOnly = true;
            this.dgvClassReport.RowTemplate.Height = 23;
            this.dgvClassReport.Size = new System.Drawing.Size(380, 540);
            this.dgvClassReport.TabIndex = 0;
            this.dgvClassReport.SelectionChanged += new System.EventHandler(this.dgvClassReport_SelectionChanged);
            this.dgvClassReport.Click += new System.EventHandler(this.dgvClassReport_Click);
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "班开始时间";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Width = 120;
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "班结束时间";
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            this.EndTime.Width = 120;
            // 
            // ClassName
            // 
            this.ClassName.HeaderText = "班组名称";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            this.ClassName.Width = 80;
            // 
            // btnGenReport
            // 
            this.btnGenReport.Location = new System.Drawing.Point(311, 71);
            this.btnGenReport.Name = "btnGenReport";
            this.btnGenReport.Size = new System.Drawing.Size(81, 37);
            this.btnGenReport.TabIndex = 2;
            this.btnGenReport.Text = "生成报表";
            this.btnGenReport.UseVisualStyleBackColor = true;
            this.btnGenReport.Click += new System.EventHandler(this.btnGenReport_Click);
            // 
            // btnSelectClass
            // 
            this.btnSelectClass.Location = new System.Drawing.Point(222, 71);
            this.btnSelectClass.Name = "btnSelectClass";
            this.btnSelectClass.Size = new System.Drawing.Size(83, 37);
            this.btnSelectClass.TabIndex = 3;
            this.btnSelectClass.Text = "筛选查询";
            this.btnSelectClass.UseVisualStyleBackColor = true;
            this.btnSelectClass.Click += new System.EventHandler(this.btnSelectClass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "班开始时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "班结束时间";
            // 
            // dtpBeginTime
            // 
            this.dtpBeginTime.CustomFormat = "\"yyyy-MM-dd HH24-mm-ss\"";
            this.dtpBeginTime.Location = new System.Drawing.Point(86, 13);
            this.dtpBeginTime.Name = "dtpBeginTime";
            this.dtpBeginTime.Size = new System.Drawing.Size(306, 21);
            this.dtpBeginTime.TabIndex = 9;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "yyyy-MM-dd HH24-mm-ss";
            this.dtpEndTime.Location = new System.Drawing.Point(86, 44);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(306, 21);
            this.dtpEndTime.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "班开始时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "班结束时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(831, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "班组名称";
            // 
            // tbxStartTime
            // 
            this.tbxStartTime.Enabled = false;
            this.tbxStartTime.Location = new System.Drawing.Point(469, 12);
            this.tbxStartTime.Name = "tbxStartTime";
            this.tbxStartTime.Size = new System.Drawing.Size(140, 21);
            this.tbxStartTime.TabIndex = 15;
            // 
            // tbxEndTime
            // 
            this.tbxEndTime.Enabled = false;
            this.tbxEndTime.Location = new System.Drawing.Point(685, 12);
            this.tbxEndTime.Name = "tbxEndTime";
            this.tbxEndTime.Size = new System.Drawing.Size(140, 21);
            this.tbxEndTime.TabIndex = 16;
            // 
            // tbxClassName
            // 
            this.tbxClassName.Enabled = false;
            this.tbxClassName.Location = new System.Drawing.Point(890, 12);
            this.tbxClassName.Name = "tbxClassName";
            this.tbxClassName.Size = new System.Drawing.Size(90, 21);
            this.tbxClassName.TabIndex = 17;
            // 
            // rvClassReport
            // 
            this.rvClassReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "FSMFDataSet_T_ClassReport";
            reportDataSource1.Value = this.tClassReportBindingSource;
            this.rvClassReport.LocalReport.DataSources.Add(reportDataSource1);
            this.rvClassReport.LocalReport.ReportEmbeddedResource = "FSMS.view.ClassReport.rdlc";
            this.rvClassReport.Location = new System.Drawing.Point(400, 44);
            this.rvClassReport.Name = "rvClassReport";
            this.rvClassReport.Size = new System.Drawing.Size(580, 610);
            this.rvClassReport.TabIndex = 18;
            // 
            // t_ClassReportTableAdapter
            // 
            this.t_ClassReportTableAdapter.ClearBeforeFill = true;
            // 
            // frmClassReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 666);
            this.Controls.Add(this.rvClassReport);
            this.Controls.Add(this.tbxClassName);
            this.Controls.Add(this.tbxEndTime);
            this.Controls.Add(this.tbxStartTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpBeginTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectClass);
            this.Controls.Add(this.btnGenReport);
            this.Controls.Add(this.dgvClassReport);
            this.Name = "frmClassReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "班报表";
            this.Load += new System.EventHandler(this.frmClassReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tClassReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSMFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClassReport;
        private System.Windows.Forms.Button btnGenReport;
        private System.Windows.Forms.Button btnSelectClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBeginTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxStartTime;
        private System.Windows.Forms.TextBox tbxEndTime;
        private System.Windows.Forms.TextBox tbxClassName;
        private Microsoft.Reporting.WinForms.ReportViewer rvClassReport;
        private FSMFDataSet fSMFDataSet;
        private System.Windows.Forms.BindingSource tClassReportBindingSource;
        private FSMS.FSMFDataSetTableAdapters.T_ClassReportTableAdapter t_ClassReportTableAdapter;
    }
}
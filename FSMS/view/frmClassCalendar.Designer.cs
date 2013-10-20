namespace FSMS.view
{
    partial class frmClassCalendar
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
            this.dgvClassCalendar = new System.Windows.Forms.DataGridView();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClassCalendar
            // 
            this.dgvClassCalendar.AllowUserToAddRows = false;
            this.dgvClassCalendar.AllowUserToDeleteRows = false;
            this.dgvClassCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassCalendar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartTime,
            this.EndTime,
            this.ClassName,
            this.UpdateTime});
            this.dgvClassCalendar.Location = new System.Drawing.Point(12, 12);
            this.dgvClassCalendar.Name = "dgvClassCalendar";
            this.dgvClassCalendar.ReadOnly = true;
            this.dgvClassCalendar.RowTemplate.Height = 23;
            this.dgvClassCalendar.Size = new System.Drawing.Size(768, 442);
            this.dgvClassCalendar.TabIndex = 0;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "班开始时间";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Width = 200;
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "班结束时间";
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            this.EndTime.Width = 200;
            // 
            // ClassName
            // 
            this.ClassName.HeaderText = "班组名称";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // UpdateTime
            // 
            this.UpdateTime.HeaderText = "更新时间";
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.ReadOnly = true;
            this.UpdateTime.Width = 200;
            // 
            // frmClassCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 466);
            this.Controls.Add(this.dgvClassCalendar);
            this.Name = "frmClassCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "班次日历";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassCalendar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClassCalendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTime;
    }
}
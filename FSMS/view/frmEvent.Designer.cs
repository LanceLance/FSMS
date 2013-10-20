namespace FSMS.view
{
    partial class frmEvent
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
            this.dgvEvent = new System.Windows.Forms.DataGridView();
            this.DevNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SilkNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel5 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.checkbTime = new System.Windows.Forms.CheckBox();
            this.groupPanel6 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rbtnSmallPkg = new System.Windows.Forms.RadioButton();
            this.rbtnSwFailed = new System.Windows.Forms.RadioButton();
            this.rbtnSilk = new System.Windows.Forms.RadioButton();
            this.cbDevName = new System.Windows.Forms.ComboBox();
            this.checkbType = new System.Windows.Forms.CheckBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDay = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStartDay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).BeginInit();
            this.groupPanel5.SuspendLayout();
            this.groupPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEvent
            // 
            this.dgvEvent.AllowUserToAddRows = false;
            this.dgvEvent.AllowUserToDeleteRows = false;
            this.dgvEvent.AllowUserToOrderColumns = true;
            this.dgvEvent.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DevNo,
            this.EventType,
            this.SilkNo,
            this.EventTime});
            this.dgvEvent.Location = new System.Drawing.Point(12, 110);
            this.dgvEvent.MultiSelect = false;
            this.dgvEvent.Name = "dgvEvent";
            this.dgvEvent.ReadOnly = true;
            this.dgvEvent.RowTemplate.Height = 23;
            this.dgvEvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvent.Size = new System.Drawing.Size(968, 544);
            this.dgvEvent.TabIndex = 0;
            this.dgvEvent.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dgvEvent_SortCompare);
            // 
            // DevNo
            // 
            this.DevNo.HeaderText = "设备号";
            this.DevNo.Name = "DevNo";
            this.DevNo.ReadOnly = true;
            // 
            // EventType
            // 
            this.EventType.HeaderText = "事件类型";
            this.EventType.Name = "EventType";
            this.EventType.ReadOnly = true;
            // 
            // SilkNo
            // 
            this.SilkNo.HeaderText = "丝道号";
            this.SilkNo.Name = "SilkNo";
            this.SilkNo.ReadOnly = true;
            // 
            // EventTime
            // 
            this.EventTime.HeaderText = "事件时间";
            this.EventTime.Name = "EventTime";
            this.EventTime.ReadOnly = true;
            this.EventTime.Width = 200;
            // 
            // groupPanel5
            // 
            this.groupPanel5.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.groupPanel5.Controls.Add(this.checkbTime);
            this.groupPanel5.Controls.Add(this.groupPanel6);
            this.groupPanel5.Controls.Add(this.cbDevName);
            this.groupPanel5.Controls.Add(this.checkbType);
            this.groupPanel5.Controls.Add(this.btnQuery);
            this.groupPanel5.Controls.Add(this.dtpEndTime);
            this.groupPanel5.Controls.Add(this.dtpEndDay);
            this.groupPanel5.Controls.Add(this.dtpStartTime);
            this.groupPanel5.Controls.Add(this.label5);
            this.groupPanel5.Controls.Add(this.label4);
            this.groupPanel5.Controls.Add(this.dtpStartDay);
            this.groupPanel5.Controls.Add(this.label1);
            this.groupPanel5.Location = new System.Drawing.Point(12, 12);
            this.groupPanel5.Name = "groupPanel5";
            this.groupPanel5.Size = new System.Drawing.Size(968, 91);
            // 
            // 
            // 
            this.groupPanel5.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel5.Style.BackColorGradientAngle = 90;
            this.groupPanel5.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel5.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderBottomWidth = 1;
            this.groupPanel5.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel5.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderLeftWidth = 1;
            this.groupPanel5.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderRightWidth = 1;
            this.groupPanel5.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderTopWidth = 1;
            this.groupPanel5.Style.CornerDiameter = 4;
            this.groupPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel5.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel5.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel5.TabIndex = 3;
            this.groupPanel5.Text = "查询条件";
            // 
            // checkbTime
            // 
            this.checkbTime.AutoSize = true;
            this.checkbTime.BackColor = System.Drawing.Color.Transparent;
            this.checkbTime.Checked = true;
            this.checkbTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbTime.Location = new System.Drawing.Point(33, 45);
            this.checkbTime.Name = "checkbTime";
            this.checkbTime.Size = new System.Drawing.Size(48, 16);
            this.checkbTime.TabIndex = 28;
            this.checkbTime.Text = "时间";
            this.checkbTime.UseVisualStyleBackColor = false;
            this.checkbTime.CheckedChanged += new System.EventHandler(this.checkbTime_CheckedChanged);
            // 
            // groupPanel6
            // 
            this.groupPanel6.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.groupPanel6.Controls.Add(this.rbtnSmallPkg);
            this.groupPanel6.Controls.Add(this.rbtnSwFailed);
            this.groupPanel6.Controls.Add(this.rbtnSilk);
            this.groupPanel6.Location = new System.Drawing.Point(454, 3);
            this.groupPanel6.Name = "groupPanel6";
            this.groupPanel6.Size = new System.Drawing.Size(204, 30);
            // 
            // 
            // 
            this.groupPanel6.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel6.Style.BackColorGradientAngle = 90;
            this.groupPanel6.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel6.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel6.Style.BorderBottomWidth = 1;
            this.groupPanel6.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel6.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel6.Style.BorderLeftWidth = 1;
            this.groupPanel6.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel6.Style.BorderRightWidth = 1;
            this.groupPanel6.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel6.Style.BorderTopWidth = 1;
            this.groupPanel6.Style.CornerDiameter = 4;
            this.groupPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel6.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel6.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel6.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel6.TabIndex = 27;
            // 
            // rbtnSmallPkg
            // 
            this.rbtnSmallPkg.AutoSize = true;
            this.rbtnSmallPkg.BackColor = System.Drawing.Color.Transparent;
            this.rbtnSmallPkg.Checked = true;
            this.rbtnSmallPkg.Location = new System.Drawing.Point(140, 6);
            this.rbtnSmallPkg.Name = "rbtnSmallPkg";
            this.rbtnSmallPkg.Size = new System.Drawing.Size(47, 16);
            this.rbtnSmallPkg.TabIndex = 4;
            this.rbtnSmallPkg.TabStop = true;
            this.rbtnSmallPkg.Text = "小卷";
            this.rbtnSmallPkg.UseVisualStyleBackColor = false;
            // 
            // rbtnSwFailed
            // 
            this.rbtnSwFailed.AutoSize = true;
            this.rbtnSwFailed.BackColor = System.Drawing.Color.Transparent;
            this.rbtnSwFailed.Location = new System.Drawing.Point(63, 7);
            this.rbtnSwFailed.Name = "rbtnSwFailed";
            this.rbtnSwFailed.Size = new System.Drawing.Size(71, 16);
            this.rbtnSwFailed.TabIndex = 3;
            this.rbtnSwFailed.Text = "切换失败";
            this.rbtnSwFailed.UseVisualStyleBackColor = false;
            // 
            // rbtnSilk
            // 
            this.rbtnSilk.AutoSize = true;
            this.rbtnSilk.BackColor = System.Drawing.Color.Transparent;
            this.rbtnSilk.Location = new System.Drawing.Point(10, 7);
            this.rbtnSilk.Name = "rbtnSilk";
            this.rbtnSilk.Size = new System.Drawing.Size(47, 16);
            this.rbtnSilk.TabIndex = 2;
            this.rbtnSilk.Text = "断丝";
            this.rbtnSilk.UseVisualStyleBackColor = false;
            // 
            // cbDevName
            // 
            this.cbDevName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevName.FormattingEnabled = true;
            this.cbDevName.Location = new System.Drawing.Point(132, 10);
            this.cbDevName.Name = "cbDevName";
            this.cbDevName.Size = new System.Drawing.Size(111, 20);
            this.cbDevName.TabIndex = 26;
            // 
            // checkbType
            // 
            this.checkbType.AutoSize = true;
            this.checkbType.BackColor = System.Drawing.Color.Transparent;
            this.checkbType.Checked = true;
            this.checkbType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbType.Location = new System.Drawing.Point(400, 13);
            this.checkbType.Name = "checkbType";
            this.checkbType.Size = new System.Drawing.Size(48, 16);
            this.checkbType.TabIndex = 25;
            this.checkbType.Text = "类型";
            this.checkbType.UseVisualStyleBackColor = false;
            this.checkbType.CheckedChanged += new System.EventHandler(this.checkbType_CheckedChanged);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(808, 30);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(108, 31);
            this.btnQuery.TabIndex = 9;
            this.btnQuery.Text = "查  询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "HH:mm";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(566, 43);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(65, 21);
            this.dtpEndTime.TabIndex = 24;
            // 
            // dtpEndDay
            // 
            this.dtpEndDay.CustomFormat = "yyyy年M月d日";
            this.dtpEndDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDay.Location = new System.Drawing.Point(454, 43);
            this.dtpEndDay.Name = "dtpEndDay";
            this.dtpEndDay.Size = new System.Drawing.Size(109, 21);
            this.dtpEndDay.TabIndex = 23;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "HH:mm";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(248, 42);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(61, 21);
            this.dtpStartTime.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(404, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "终止:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(91, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "起始:";
            // 
            // dtpStartDay
            // 
            this.dtpStartDay.CustomFormat = "yyyy年M月d日";
            this.dtpStartDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDay.Location = new System.Drawing.Point(132, 42);
            this.dtpStartDay.Name = "dtpStartDay";
            this.dtpStartDay.Size = new System.Drawing.Size(111, 21);
            this.dtpStartDay.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(31, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "设备ID(必填):";
            // 
            // frmEvent
            // 
            this.ClientSize = new System.Drawing.Size(992, 666);
            this.Controls.Add(this.dgvEvent);
            this.Controls.Add(this.groupPanel5);
            this.Name = "frmEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设备历史事件";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).EndInit();
            this.groupPanel5.ResumeLayout(false);
            this.groupPanel5.PerformLayout();
            this.groupPanel6.ResumeLayout(false);
            this.groupPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvent;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel5;
        private System.Windows.Forms.ComboBox cbDevName;
        private System.Windows.Forms.CheckBox checkbType;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DateTimePicker dtpEndDay;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpStartDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SilkNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventTime;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel6;
        private System.Windows.Forms.RadioButton rbtnSmallPkg;
        private System.Windows.Forms.RadioButton rbtnSwFailed;
        private System.Windows.Forms.RadioButton rbtnSilk;
        private System.Windows.Forms.CheckBox checkbTime;

      
    }
}
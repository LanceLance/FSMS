namespace FSMS.view
{
    partial class frmClock
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
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbHour = new System.Windows.Forms.TextBox();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCurrentClock = new System.Windows.Forms.Button();
            this.btnClock = new System.Windows.Forms.Button();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblAutoClockStatus = new System.Windows.Forms.Label();
            this.cbTimeCycle = new System.Windows.Forms.ComboBox();
            this.checkbAutoClock = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.groupPanel2.Controls.Add(this.label1);
            this.groupPanel2.Controls.Add(this.tbMin);
            this.groupPanel2.Controls.Add(this.tbHour);
            this.groupPanel2.Controls.Add(this.tbDay);
            this.groupPanel2.Controls.Add(this.label5);
            this.groupPanel2.Controls.Add(this.label3);
            this.groupPanel2.Controls.Add(this.label2);
            this.groupPanel2.Controls.Add(this.btnCurrentClock);
            this.groupPanel2.Controls.Add(this.btnClock);
            this.groupPanel2.Location = new System.Drawing.Point(12, 34);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(280, 285);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 1;
            this.groupPanel2.Text = "手动同步";
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(203, 107);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(32, 21);
            this.tbMin.TabIndex = 8;
            this.tbMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbHour
            // 
            this.tbHour.Location = new System.Drawing.Point(154, 107);
            this.tbHour.Name = "tbHour";
            this.tbHour.Size = new System.Drawing.Size(32, 21);
            this.tbHour.TabIndex = 8;
            this.tbHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(105, 107);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(32, 21);
            this.tbDay.TabIndex = 8;
            this.tbDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(235, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(186, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "时";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(5, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "指定时刻：";
            // 
            // btnCurrentClock
            // 
            this.btnCurrentClock.Location = new System.Drawing.Point(45, 21);
            this.btnCurrentClock.Name = "btnCurrentClock";
            this.btnCurrentClock.Size = new System.Drawing.Size(205, 30);
            this.btnCurrentClock.TabIndex = 6;
            this.btnCurrentClock.Text = "下发当前主机时刻";
            this.btnCurrentClock.UseVisualStyleBackColor = true;
            this.btnCurrentClock.Click += new System.EventHandler(this.btnCurrentClock_Click);
            // 
            // btnClock
            // 
            this.btnClock.Location = new System.Drawing.Point(133, 147);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(119, 30);
            this.btnClock.TabIndex = 6;
            this.btnClock.Text = "下发指定时钟";
            this.btnClock.UseVisualStyleBackColor = true;
            this.btnClock.Click += new System.EventHandler(this.btnClock_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.groupPanel1.Controls.Add(this.lblAutoClockStatus);
            this.groupPanel1.Controls.Add(this.cbTimeCycle);
            this.groupPanel1.Controls.Add(this.checkbAutoClock);
            this.groupPanel1.Location = new System.Drawing.Point(296, 34);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(280, 285);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "自动同步";
            // 
            // lblAutoClockStatus
            // 
            this.lblAutoClockStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblAutoClockStatus.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAutoClockStatus.Location = new System.Drawing.Point(91, 107);
            this.lblAutoClockStatus.Name = "lblAutoClockStatus";
            this.lblAutoClockStatus.Size = new System.Drawing.Size(113, 80);
            this.lblAutoClockStatus.TabIndex = 17;
            this.lblAutoClockStatus.Text = "未开启自动下发时钟";
            // 
            // cbTimeCycle
            // 
            this.cbTimeCycle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeCycle.FormattingEnabled = true;
            this.cbTimeCycle.Location = new System.Drawing.Point(93, 21);
            this.cbTimeCycle.Name = "cbTimeCycle";
            this.cbTimeCycle.Size = new System.Drawing.Size(161, 20);
            this.cbTimeCycle.TabIndex = 16;
            // 
            // checkbAutoClock
            // 
            this.checkbAutoClock.AutoSize = true;
            this.checkbAutoClock.Location = new System.Drawing.Point(15, 23);
            this.checkbAutoClock.Name = "checkbAutoClock";
            this.checkbAutoClock.Size = new System.Drawing.Size(72, 16);
            this.checkbAutoClock.TabIndex = 15;
            this.checkbAutoClock.Text = "自动下发";
            this.checkbAutoClock.UseVisualStyleBackColor = true;
            this.checkbAutoClock.CheckedChanged += new System.EventHandler(this.checkbAutoClock_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(76, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "星期";
            // 
            // frmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.groupPanel2);
            this.Name = "frmClock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "时钟同步下发";
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCurrentClock;
        private System.Windows.Forms.Button btnClock;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Label lblAutoClockStatus;
        private System.Windows.Forms.ComboBox cbTimeCycle;
        private System.Windows.Forms.CheckBox checkbAutoClock;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
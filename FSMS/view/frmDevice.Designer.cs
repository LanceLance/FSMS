namespace FSMS.view
{
    partial class frmDevice
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
            this.dgvDevice = new System.Windows.Forms.DataGridView();
            this.IDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevMac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsSent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SilkNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockedSilkBitStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpDevice = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnDistID = new System.Windows.Forms.Button();
            this.btnClearDev = new System.Windows.Forms.Button();
            this.btnUpdateDev = new System.Windows.Forms.Button();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEndDevNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStartDevNo = new System.Windows.Forms.ComboBox();
            this.btnSilkNo = new System.Windows.Forms.Button();
            this.checkedlbSilkNo = new System.Windows.Forms.CheckedListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progBarDist = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
            this.gpDevice.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDevice
            // 
            this.dgvDevice.AllowUserToOrderColumns = true;
            this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDD,
            this.DevType,
            this.DevName,
            this.DevID,
            this.DevMac,
            this.IsSent,
            this.SilkNum,
            this.BlockedSilkBitStr,
            this.UpdateTime});
            this.dgvDevice.Location = new System.Drawing.Point(3, 3);
            this.dgvDevice.MultiSelect = false;
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.RowTemplate.Height = 23;
            this.dgvDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDevice.Size = new System.Drawing.Size(858, 321);
            this.dgvDevice.TabIndex = 8;
            this.dgvDevice.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dgvDevice_SortCompare);
            // 
            // IDD
            // 
            this.IDD.HeaderText = "ID";
            this.IDD.Name = "IDD";
            this.IDD.ReadOnly = true;
            this.IDD.Visible = false;
            // 
            // DevType
            // 
            this.DevType.HeaderText = "设备类型";
            this.DevType.Name = "DevType";
            this.DevType.Width = 80;
            // 
            // DevName
            // 
            this.DevName.HeaderText = "设备名称";
            this.DevName.Name = "DevName";
            this.DevName.Width = 80;
            // 
            // DevID
            // 
            this.DevID.HeaderText = "设备编号";
            this.DevID.Name = "DevID";
            this.DevID.Width = 80;
            // 
            // DevMac
            // 
            this.DevMac.HeaderText = "硬件地址";
            this.DevMac.Name = "DevMac";
            this.DevMac.Width = 80;
            // 
            // IsSent
            // 
            this.IsSent.HeaderText = "下发(只读)";
            this.IsSent.Name = "IsSent";
            this.IsSent.ReadOnly = true;
            this.IsSent.Width = 90;
            // 
            // SilkNum
            // 
            this.SilkNum.HeaderText = "丝道数";
            this.SilkNum.Name = "SilkNum";
            this.SilkNum.Width = 80;
            // 
            // BlockedSilkBitStr
            // 
            this.BlockedSilkBitStr.HeaderText = "屏蔽丝道码(只读)";
            this.BlockedSilkBitStr.Name = "BlockedSilkBitStr";
            this.BlockedSilkBitStr.ReadOnly = true;
            this.BlockedSilkBitStr.Width = 150;
            // 
            // UpdateTime
            // 
            this.UpdateTime.HeaderText = "更新时间(只读)";
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.ReadOnly = true;
            this.UpdateTime.Width = 120;
            // 
            // gpDevice
            // 
            this.gpDevice.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpDevice.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.gpDevice.Controls.Add(this.btnDistID);
            this.gpDevice.Controls.Add(this.btnClearDev);
            this.gpDevice.Controls.Add(this.btnUpdateDev);
            this.gpDevice.Controls.Add(this.dgvDevice);
            this.gpDevice.Location = new System.Drawing.Point(12, 1);
            this.gpDevice.Name = "gpDevice";
            this.gpDevice.Size = new System.Drawing.Size(968, 351);
            // 
            // 
            // 
            this.gpDevice.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpDevice.Style.BackColorGradientAngle = 90;
            this.gpDevice.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpDevice.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDevice.Style.BorderBottomWidth = 1;
            this.gpDevice.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpDevice.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDevice.Style.BorderLeftWidth = 1;
            this.gpDevice.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDevice.Style.BorderRightWidth = 1;
            this.gpDevice.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDevice.Style.BorderTopWidth = 1;
            this.gpDevice.Style.CornerDiameter = 4;
            this.gpDevice.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpDevice.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpDevice.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpDevice.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.gpDevice.TabIndex = 11;
            this.gpDevice.Text = "设备管理";
            // 
            // btnDistID
            // 
            this.btnDistID.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDistID.Location = new System.Drawing.Point(867, 123);
            this.btnDistID.Name = "btnDistID";
            this.btnDistID.Size = new System.Drawing.Size(92, 31);
            this.btnDistID.TabIndex = 11;
            this.btnDistID.Text = "通讯ID下发";
            this.btnDistID.UseVisualStyleBackColor = true;
            this.btnDistID.Click += new System.EventHandler(this.btnDistID_Click);
            // 
            // btnClearDev
            // 
            this.btnClearDev.Location = new System.Drawing.Point(867, 62);
            this.btnClearDev.Name = "btnClearDev";
            this.btnClearDev.Size = new System.Drawing.Size(92, 31);
            this.btnClearDev.TabIndex = 10;
            this.btnClearDev.Text = "清空设备信息";
            this.btnClearDev.UseVisualStyleBackColor = true;
            this.btnClearDev.Click += new System.EventHandler(this.btnClearDev_Click);
            // 
            // btnUpdateDev
            // 
            this.btnUpdateDev.Location = new System.Drawing.Point(867, 3);
            this.btnUpdateDev.Name = "btnUpdateDev";
            this.btnUpdateDev.Size = new System.Drawing.Size(92, 30);
            this.btnUpdateDev.TabIndex = 9;
            this.btnUpdateDev.Text = "更新设备信息";
            this.btnUpdateDev.UseVisualStyleBackColor = true;
            this.btnUpdateDev.Click += new System.EventHandler(this.btnUpdateDev_Click);
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.groupPanel3.Controls.Add(this.groupBox1);
            this.groupPanel3.Controls.Add(this.btnSilkNo);
            this.groupPanel3.Controls.Add(this.checkedlbSilkNo);
            this.groupPanel3.Location = new System.Drawing.Point(12, 358);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(968, 296);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel3.TabIndex = 12;
            this.groupPanel3.Text = "屏蔽丝道号下发";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbEndDevNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbStartDevNo);
            this.groupBox1.Location = new System.Drawing.Point(173, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 63);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(144, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "末台号:";
            // 
            // cbEndDevNo
            // 
            this.cbEndDevNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEndDevNo.FormattingEnabled = true;
            this.cbEndDevNo.Location = new System.Drawing.Point(198, 24);
            this.cbEndDevNo.Name = "cbEndDevNo";
            this.cbEndDevNo.Size = new System.Drawing.Size(60, 20);
            this.cbEndDevNo.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "首台号:";
            // 
            // cbStartDevNo
            // 
            this.cbStartDevNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartDevNo.FormattingEnabled = true;
            this.cbStartDevNo.Location = new System.Drawing.Point(57, 24);
            this.cbStartDevNo.Name = "cbStartDevNo";
            this.cbStartDevNo.Size = new System.Drawing.Size(60, 20);
            this.cbStartDevNo.TabIndex = 17;
            // 
            // btnSilkNo
            // 
            this.btnSilkNo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSilkNo.Location = new System.Drawing.Point(360, 88);
            this.btnSilkNo.Name = "btnSilkNo";
            this.btnSilkNo.Size = new System.Drawing.Size(105, 30);
            this.btnSilkNo.TabIndex = 4;
            this.btnSilkNo.Text = "下发屏蔽丝道号";
            this.btnSilkNo.UseVisualStyleBackColor = true;
            this.btnSilkNo.Click += new System.EventHandler(this.btnSilkNo_Click);
            // 
            // checkedlbSilkNo
            // 
            this.checkedlbSilkNo.CheckOnClick = true;
            this.checkedlbSilkNo.FormattingEnabled = true;
            this.checkedlbSilkNo.Location = new System.Drawing.Point(3, 3);
            this.checkedlbSilkNo.Name = "checkedlbSilkNo";
            this.checkedlbSilkNo.Size = new System.Drawing.Size(120, 260);
            this.checkedlbSilkNo.TabIndex = 0;
            this.checkedlbSilkNo.SelectedIndexChanged += new System.EventHandler(this.checkedlbSilkNo_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.progBarDist});
            this.statusStrip1.Location = new System.Drawing.Point(0, 664);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(992, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel1.Text = "下发进度：";
            // 
            // progBarDist
            // 
            this.progBarDist.Name = "progBarDist";
            this.progBarDist.Size = new System.Drawing.Size(913, 16);
            this.progBarDist.Step = 1;
            // 
            // frmDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 686);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.gpDevice);
            this.Name = "frmDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设备及用户管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDevice_FormClosed);
            this.Load += new System.EventHandler(this.frmDevice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
            this.gpDevice.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDevice;
        public DevComponents.DotNetBar.Controls.GroupPanel gpDevice;
        private System.Windows.Forms.Button btnUpdateDev;
        private System.Windows.Forms.Button btnClearDev;
        private System.Windows.Forms.Button btnDistID;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private System.Windows.Forms.ComboBox cbEndDevNo;
        private System.Windows.Forms.ComboBox cbStartDevNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSilkNo;
        private System.Windows.Forms.CheckedListBox checkedlbSilkNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevMac;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsSent;
        private System.Windows.Forms.DataGridViewTextBoxColumn SilkNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockedSilkBitStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTime;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar progBarDist;

    }
}
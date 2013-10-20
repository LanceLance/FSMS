namespace FSMS.view
{
    partial class frmSmallPkg
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvSmallPkgDist = new System.Windows.Forms.DataGridView();
            this.BatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SmallPkgTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsSent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnSend = new System.Windows.Forms.Button();
            this.listVDevNo = new System.Windows.Forms.ListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progBarDist = new System.Windows.Forms.ToolStripProgressBar();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSmallPkgDist)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.groupPanel1.Controls.Add(this.dgvSmallPkgDist);
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(572, 542);
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
            this.groupPanel1.TabIndex = 3;
            this.groupPanel1.Text = "下发详情";
            // 
            // dgvSmallPkgDist
            // 
            this.dgvSmallPkgDist.AllowUserToAddRows = false;
            this.dgvSmallPkgDist.AllowUserToDeleteRows = false;
            this.dgvSmallPkgDist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSmallPkgDist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BatchNo,
            this.DevNo,
            this.SmallPkgTime,
            this.IsSent,
            this.UpdateTime});
            this.dgvSmallPkgDist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSmallPkgDist.Location = new System.Drawing.Point(0, 0);
            this.dgvSmallPkgDist.Name = "dgvSmallPkgDist";
            this.dgvSmallPkgDist.ReadOnly = true;
            this.dgvSmallPkgDist.RowTemplate.Height = 23;
            this.dgvSmallPkgDist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSmallPkgDist.Size = new System.Drawing.Size(566, 518);
            this.dgvSmallPkgDist.TabIndex = 0;
            this.dgvSmallPkgDist.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dgvSmallPkgDist_SortCompare);
            this.dgvSmallPkgDist.SelectionChanged += new System.EventHandler(this.dgvSmallPkgDist_SelectionChanged);
            // 
            // BatchNo
            // 
            this.BatchNo.HeaderText = "批号";
            this.BatchNo.Name = "BatchNo";
            this.BatchNo.ReadOnly = true;
            // 
            // DevNo
            // 
            this.DevNo.HeaderText = "设备号";
            this.DevNo.Name = "DevNo";
            this.DevNo.ReadOnly = true;
            this.DevNo.Width = 80;
            // 
            // SmallPkgTime
            // 
            this.SmallPkgTime.HeaderText = "小卷时间";
            this.SmallPkgTime.Name = "SmallPkgTime";
            this.SmallPkgTime.ReadOnly = true;
            this.SmallPkgTime.Width = 80;
            // 
            // IsSent
            // 
            this.IsSent.HeaderText = "是否下发";
            this.IsSent.Name = "IsSent";
            this.IsSent.ReadOnly = true;
            // 
            // UpdateTime
            // 
            this.UpdateTime.HeaderText = "更新时间";
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.ReadOnly = true;
            this.UpdateTime.Width = 120;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.groupPanel2.Controls.Add(this.btnSend);
            this.groupPanel2.Controls.Add(this.listVDevNo);
            this.groupPanel2.Location = new System.Drawing.Point(587, 12);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(193, 542);
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
            this.groupPanel2.TabIndex = 4;
            this.groupPanel2.Text = "重新下发";
            // 
            // btnSend
            // 
            this.btnSend.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSend.Location = new System.Drawing.Point(93, 13);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(92, 30);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "小卷下发";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // listVDevNo
            // 
            this.listVDevNo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listVDevNo.Location = new System.Drawing.Point(0, 52);
            this.listVDevNo.Name = "listVDevNo";
            this.listVDevNo.Size = new System.Drawing.Size(187, 466);
            this.listVDevNo.TabIndex = 0;
            this.listVDevNo.UseCompatibleStateImageBehavior = false;
            this.listVDevNo.View = System.Windows.Forms.View.List;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.progBarDist});
            this.statusStrip1.Location = new System.Drawing.Point(0, 564);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(792, 22);
            this.statusStrip1.TabIndex = 5;
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
            this.progBarDist.Size = new System.Drawing.Size(713, 16);
            // 
            // frmSmallPkg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 586);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Name = "frmSmallPkg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "下发详情";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSmallPkg_FormClosed);
            this.Load += new System.EventHandler(this.frmSmallPkg_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSmallPkgDist)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        public System.Windows.Forms.DataGridView dgvSmallPkgDist;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListView listVDevNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SmallPkgTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsSent;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTime;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar progBarDist;

    }
}
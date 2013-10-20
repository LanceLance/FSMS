namespace FSMS.view
{
    partial class frmBatch
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
            this.dgvBatch = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstDevNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastDevNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinglePieWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullPkgTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SmallPkgTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsSent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.linklbDetail = new System.Windows.Forms.LinkLabel();
            this.btnSmallPkgTime = new System.Windows.Forms.Button();
            this.btnClearBatch = new System.Windows.Forms.Button();
            this.btnUpdateBatch = new System.Windows.Forms.Button();
            this.dgvGroup = new System.Windows.Forms.DataGridView();
            this.GroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDevNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDevNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupUpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnClearGroup = new System.Windows.Forms.Button();
            this.btnUpdateGroup = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDistStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgBarDist = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatch)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBatch
            // 
            this.dgvBatch.AllowUserToOrderColumns = true;
            this.dgvBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.BatchNo,
            this.FirstDevNo,
            this.LastDevNo,
            this.SinglePieWeight,
            this.FullPkgTime,
            this.SmallPkgTime,
            this.IsSent,
            this.UpdateTime});
            this.dgvBatch.Location = new System.Drawing.Point(3, 3);
            this.dgvBatch.MultiSelect = false;
            this.dgvBatch.Name = "dgvBatch";
            this.dgvBatch.RowTemplate.Height = 23;
            this.dgvBatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBatch.Size = new System.Drawing.Size(858, 299);
            this.dgvBatch.TabIndex = 8;
            this.dgvBatch.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBatch_CellLeave);
            this.dgvBatch.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBatch_CellValidated);
            this.dgvBatch.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvBatch_CellValidating);
            this.dgvBatch.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBatch_CellEndEdit);
            this.dgvBatch.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBatch_CellEnter);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // BatchNo
            // 
            this.BatchNo.HeaderText = "产品批号";
            this.BatchNo.Name = "BatchNo";
            // 
            // FirstDevNo
            // 
            this.FirstDevNo.HeaderText = "首台机器号";
            this.FirstDevNo.Name = "FirstDevNo";
            this.FirstDevNo.Width = 90;
            // 
            // LastDevNo
            // 
            this.LastDevNo.HeaderText = "末台机器号";
            this.LastDevNo.Name = "LastDevNo";
            this.LastDevNo.Width = 90;
            // 
            // SinglePieWeight
            // 
            this.SinglePieWeight.HeaderText = "单饼重量";
            this.SinglePieWeight.Name = "SinglePieWeight";
            this.SinglePieWeight.Width = 80;
            // 
            // FullPkgTime
            // 
            this.FullPkgTime.HeaderText = "满卷时间(秒)";
            this.FullPkgTime.Name = "FullPkgTime";
            // 
            // SmallPkgTime
            // 
            this.SmallPkgTime.HeaderText = "小卷时间(秒)";
            this.SmallPkgTime.Name = "SmallPkgTime";
            // 
            // IsSent
            // 
            this.IsSent.HeaderText = "下发(只读)";
            this.IsSent.Name = "IsSent";
            this.IsSent.ReadOnly = true;
            this.IsSent.Width = 90;
            // 
            // UpdateTime
            // 
            this.UpdateTime.HeaderText = "更新时间(只读)";
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.ReadOnly = true;
            this.UpdateTime.Width = 150;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.groupPanel1.Controls.Add(this.linklbDetail);
            this.groupPanel1.Controls.Add(this.btnSmallPkgTime);
            this.groupPanel1.Controls.Add(this.btnClearBatch);
            this.groupPanel1.Controls.Add(this.btnUpdateBatch);
            this.groupPanel1.Controls.Add(this.dgvBatch);
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(968, 329);
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
            this.groupPanel1.TabIndex = 9;
            this.groupPanel1.Text = "批号管理";
            // 
            // linklbDetail
            // 
            this.linklbDetail.AutoSize = true;
            this.linklbDetail.BackColor = System.Drawing.Color.Transparent;
            this.linklbDetail.Font = new System.Drawing.Font("宋体", 9F);
            this.linklbDetail.Location = new System.Drawing.Point(875, 224);
            this.linklbDetail.Name = "linklbDetail";
            this.linklbDetail.Size = new System.Drawing.Size(77, 12);
            this.linklbDetail.TabIndex = 10;
            this.linklbDetail.TabStop = true;
            this.linklbDetail.Text = "小卷下发详情";
            this.linklbDetail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbDetail_LinkClicked);
            // 
            // btnSmallPkgTime
            // 
            this.btnSmallPkgTime.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSmallPkgTime.Location = new System.Drawing.Point(867, 119);
            this.btnSmallPkgTime.Name = "btnSmallPkgTime";
            this.btnSmallPkgTime.Size = new System.Drawing.Size(92, 31);
            this.btnSmallPkgTime.TabIndex = 9;
            this.btnSmallPkgTime.Text = "小卷时间下发";
            this.btnSmallPkgTime.UseVisualStyleBackColor = true;
            this.btnSmallPkgTime.Click += new System.EventHandler(this.btnSmallPkgTime_Click);
            // 
            // btnClearBatch
            // 
            this.btnClearBatch.Location = new System.Drawing.Point(867, 59);
            this.btnClearBatch.Name = "btnClearBatch";
            this.btnClearBatch.Size = new System.Drawing.Size(92, 31);
            this.btnClearBatch.TabIndex = 9;
            this.btnClearBatch.Text = "清空批号信息";
            this.btnClearBatch.UseVisualStyleBackColor = true;
            this.btnClearBatch.Click += new System.EventHandler(this.btnClearBatch_Click);
            // 
            // btnUpdateBatch
            // 
            this.btnUpdateBatch.Location = new System.Drawing.Point(867, 0);
            this.btnUpdateBatch.Name = "btnUpdateBatch";
            this.btnUpdateBatch.Size = new System.Drawing.Size(92, 31);
            this.btnUpdateBatch.TabIndex = 9;
            this.btnUpdateBatch.Text = "更新批号信息";
            this.btnUpdateBatch.UseVisualStyleBackColor = true;
            this.btnUpdateBatch.Click += new System.EventHandler(this.btnUpdateBatch_Click);
            // 
            // dgvGroup
            // 
            this.dgvGroup.AllowUserToOrderColumns = true;
            this.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupID,
            this.GroupName,
            this.StartDevNo,
            this.EndDevNo,
            this.GroupUpdateTime});
            this.dgvGroup.Location = new System.Drawing.Point(3, 3);
            this.dgvGroup.MultiSelect = false;
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.RowTemplate.Height = 23;
            this.dgvGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvGroup.Size = new System.Drawing.Size(858, 277);
            this.dgvGroup.TabIndex = 8;
            // 
            // GroupID
            // 
            this.GroupID.HeaderText = "ID";
            this.GroupID.Name = "GroupID";
            this.GroupID.ReadOnly = true;
            this.GroupID.Visible = false;
            // 
            // GroupName
            // 
            this.GroupName.HeaderText = "小组名称";
            this.GroupName.Name = "GroupName";
            // 
            // StartDevNo
            // 
            this.StartDevNo.HeaderText = "首台机器号";
            this.StartDevNo.Name = "StartDevNo";
            this.StartDevNo.Width = 90;
            // 
            // EndDevNo
            // 
            this.EndDevNo.HeaderText = "末台机器号";
            this.EndDevNo.Name = "EndDevNo";
            this.EndDevNo.Width = 90;
            // 
            // GroupUpdateTime
            // 
            this.GroupUpdateTime.HeaderText = "更新时间(只读)";
            this.GroupUpdateTime.Name = "GroupUpdateTime";
            this.GroupUpdateTime.ReadOnly = true;
            this.GroupUpdateTime.Width = 150;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.groupPanel2.Controls.Add(this.btnClearGroup);
            this.groupPanel2.Controls.Add(this.btnUpdateGroup);
            this.groupPanel2.Controls.Add(this.dgvGroup);
            this.groupPanel2.Location = new System.Drawing.Point(12, 347);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(968, 307);
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
            this.groupPanel2.TabIndex = 10;
            this.groupPanel2.Text = "操作工小组管理";
            // 
            // btnClearGroup
            // 
            this.btnClearGroup.Location = new System.Drawing.Point(867, 65);
            this.btnClearGroup.Name = "btnClearGroup";
            this.btnClearGroup.Size = new System.Drawing.Size(92, 31);
            this.btnClearGroup.TabIndex = 9;
            this.btnClearGroup.Text = "清空小组信息";
            this.btnClearGroup.UseVisualStyleBackColor = true;
            this.btnClearGroup.Click += new System.EventHandler(this.btnClearGroup_Click);
            // 
            // btnUpdateGroup
            // 
            this.btnUpdateGroup.Location = new System.Drawing.Point(867, 1);
            this.btnUpdateGroup.Name = "btnUpdateGroup";
            this.btnUpdateGroup.Size = new System.Drawing.Size(92, 31);
            this.btnUpdateGroup.TabIndex = 9;
            this.btnUpdateGroup.Text = "更新小组信息";
            this.btnUpdateGroup.UseVisualStyleBackColor = true;
            this.btnUpdateGroup.Click += new System.EventHandler(this.btnUpdateGroup_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDistStatus,
            this.ProgBarDist});
            this.statusStrip1.Location = new System.Drawing.Point(0, 664);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(992, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDistStatus
            // 
            this.lblDistStatus.Name = "lblDistStatus";
            this.lblDistStatus.Size = new System.Drawing.Size(65, 17);
            this.lblDistStatus.Text = "下发进度：";
            // 
            // ProgBarDist
            // 
            this.ProgBarDist.Name = "ProgBarDist";
            this.ProgBarDist.Size = new System.Drawing.Size(913, 16);
            this.ProgBarDist.Step = 1;
            // 
            // frmBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 686);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Name = "frmBatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新批次参数设定";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBatch_FormClosed);
            this.Load += new System.EventHandler(this.frmBatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatch)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvBatch;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.DataGridView dgvGroup;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.Button btnUpdateBatch;
        private System.Windows.Forms.Button btnUpdateGroup;
        private System.Windows.Forms.Button btnClearBatch;
        private System.Windows.Forms.Button btnClearGroup;
        private System.Windows.Forms.Button btnSmallPkgTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDevNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDevNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupUpdateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstDevNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastDevNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SinglePieWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullPkgTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn SmallPkgTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsSent;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTime;
        private System.Windows.Forms.LinkLabel linklbDetail;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDistStatus;
        private System.Windows.Forms.ToolStripProgressBar ProgBarDist;
    }
}
namespace FSMS.view
{
    partial class frmSilk
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
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbEndDevNo = new System.Windows.Forms.ComboBox();
            this.cbStartDevNo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStopSilkNo = new System.Windows.Forms.Label();
            this.btnSilkNo = new System.Windows.Forms.Button();
            this.checkedlbSilkNo = new System.Windows.Forms.CheckedListBox();
            this.groupPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.groupPanel3.Controls.Add(this.cbEndDevNo);
            this.groupPanel3.Controls.Add(this.cbStartDevNo);
            this.groupPanel3.Controls.Add(this.label2);
            this.groupPanel3.Controls.Add(this.label1);
            this.groupPanel3.Controls.Add(this.label8);
            this.groupPanel3.Controls.Add(this.lblStopSilkNo);
            this.groupPanel3.Controls.Add(this.btnSilkNo);
            this.groupPanel3.Controls.Add(this.checkedlbSilkNo);
            this.groupPanel3.Location = new System.Drawing.Point(38, 15);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(515, 325);
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
            this.groupPanel3.TabIndex = 1;
            this.groupPanel3.Text = "屏蔽丝道";
            // 
            // cbEndDevNo
            // 
            this.cbEndDevNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEndDevNo.FormattingEnabled = true;
            this.cbEndDevNo.Location = new System.Drawing.Point(354, 10);
            this.cbEndDevNo.Name = "cbEndDevNo";
            this.cbEndDevNo.Size = new System.Drawing.Size(60, 20);
            this.cbEndDevNo.TabIndex = 17;
            // 
            // cbStartDevNo
            // 
            this.cbStartDevNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartDevNo.FormattingEnabled = true;
            this.cbStartDevNo.Location = new System.Drawing.Point(213, 10);
            this.cbStartDevNo.Name = "cbStartDevNo";
            this.cbStartDevNo.Size = new System.Drawing.Size(60, 20);
            this.cbStartDevNo.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(300, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "末台号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(160, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "首台号:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(225, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "当前屏蔽丝道：";
            // 
            // lblStopSilkNo
            // 
            this.lblStopSilkNo.BackColor = System.Drawing.Color.Transparent;
            this.lblStopSilkNo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStopSilkNo.Location = new System.Drawing.Point(225, 135);
            this.lblStopSilkNo.Name = "lblStopSilkNo";
            this.lblStopSilkNo.Size = new System.Drawing.Size(189, 123);
            this.lblStopSilkNo.TabIndex = 5;
            this.lblStopSilkNo.Text = "未知";
            // 
            // btnSilkNo
            // 
            this.btnSilkNo.Location = new System.Drawing.Point(309, 55);
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
            this.checkedlbSilkNo.Location = new System.Drawing.Point(14, 3);
            this.checkedlbSilkNo.Name = "checkedlbSilkNo";
            this.checkedlbSilkNo.Size = new System.Drawing.Size(120, 292);
            this.checkedlbSilkNo.TabIndex = 0;
            this.checkedlbSilkNo.SelectedIndexChanged += new System.EventHandler(this.checkedlbSilkNo_SelectedIndexChanged);
            // 
            // frmSilk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.Controls.Add(this.groupPanel3);
            this.Name = "frmSilk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "屏蔽丝道号下发";
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblStopSilkNo;
        private System.Windows.Forms.Button btnSilkNo;
        private System.Windows.Forms.CheckedListBox checkedlbSilkNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEndDevNo;
        private System.Windows.Forms.ComboBox cbStartDevNo;

    }
}
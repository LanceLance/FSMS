namespace FSMS.view
{
    partial class frmUser
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
            this.gpUser = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnClearUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserUpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // gpUser
            // 
            this.gpUser.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpUser.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.gpUser.Controls.Add(this.btnClearUser);
            this.gpUser.Controls.Add(this.btnUpdateUser);
            this.gpUser.Controls.Add(this.dgvUser);
            this.gpUser.Location = new System.Drawing.Point(12, 12);
            this.gpUser.Name = "gpUser";
            this.gpUser.Size = new System.Drawing.Size(633, 283);
            // 
            // 
            // 
            this.gpUser.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpUser.Style.BackColorGradientAngle = 90;
            this.gpUser.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpUser.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpUser.Style.BorderBottomWidth = 1;
            this.gpUser.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpUser.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpUser.Style.BorderLeftWidth = 1;
            this.gpUser.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpUser.Style.BorderRightWidth = 1;
            this.gpUser.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpUser.Style.BorderTopWidth = 1;
            this.gpUser.Style.CornerDiameter = 4;
            this.gpUser.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpUser.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpUser.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpUser.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.gpUser.TabIndex = 12;
            this.gpUser.Text = "用户管理";
            // 
            // btnClearUser
            // 
            this.btnClearUser.Location = new System.Drawing.Point(529, 60);
            this.btnClearUser.Name = "btnClearUser";
            this.btnClearUser.Size = new System.Drawing.Size(92, 30);
            this.btnClearUser.TabIndex = 9;
            this.btnClearUser.Text = "清空用户信息";
            this.btnClearUser.UseVisualStyleBackColor = true;
            this.btnClearUser.Click += new System.EventHandler(this.btnClearUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(529, 3);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(92, 30);
            this.btnUpdateUser.TabIndex = 9;
            this.btnUpdateUser.Text = "更新用户信息";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToOrderColumns = true;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UserName,
            this.UserPwd,
            this.RoleName,
            this.UserUpdateTime});
            this.dgvUser.Location = new System.Drawing.Point(3, 3);
            this.dgvUser.MultiSelect = false;
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowTemplate.Height = 23;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvUser.Size = new System.Drawing.Size(520, 253);
            this.dgvUser.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "用户名";
            this.UserName.Name = "UserName";
            // 
            // UserPwd
            // 
            this.UserPwd.HeaderText = "密码";
            this.UserPwd.Name = "UserPwd";
            // 
            // RoleName
            // 
            this.RoleName.HeaderText = "角色";
            this.RoleName.Name = "RoleName";
            // 
            // UserUpdateTime
            // 
            this.UserUpdateTime.HeaderText = "更新时间(只读)";
            this.UserUpdateTime.Name = "UserUpdateTime";
            this.UserUpdateTime.ReadOnly = true;
            this.UserUpdateTime.Width = 150;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 307);
            this.Controls.Add(this.gpUser);
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.gpUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel gpUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button btnClearUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserUpdateTime;

    }
}
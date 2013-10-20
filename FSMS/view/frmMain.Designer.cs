namespace FSMS.view
{
    partial class frmMain
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
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel3 = new DevComponents.DotNetBar.RibbonPanel();
            this.rbbUser = new DevComponents.DotNetBar.RibbonBar();
            this.btnUser = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar13 = new DevComponents.DotNetBar.RibbonBar();
            this.btnClass = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar6 = new DevComponents.DotNetBar.RibbonBar();
            this.rbtnBatch = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar5 = new DevComponents.DotNetBar.RibbonBar();
            this.btnDeviceConfig = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.btnAbout = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnLogin = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel5 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar12 = new DevComponents.DotNetBar.RibbonBar();
            this.btnBlockSilk = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar8 = new DevComponents.DotNetBar.RibbonBar();
            this.btnSmallPkgTime = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar7 = new DevComponents.DotNetBar.RibbonBar();
            this.btnClock = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.btnDeviceState = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar4 = new DevComponents.DotNetBar.RibbonBar();
            this.btnAlarm = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel4 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar11 = new DevComponents.DotNetBar.RibbonBar();
            this.btnMonthReport = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar10 = new DevComponents.DotNetBar.RibbonBar();
            this.btnDayReport = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar9 = new DevComponents.DotNetBar.RibbonBar();
            this.btnClassReport = new DevComponents.DotNetBar.ButtonItem();
            this.rtabSystem = new DevComponents.DotNetBar.RibbonTabItem();
            this.rtabWork = new DevComponents.DotNetBar.RibbonTabItem();
            this.rtabDistribute = new DevComponents.DotNetBar.RibbonTabItem();
            this.rtabMonitor = new DevComponents.DotNetBar.RibbonTabItem();
            this.rtabReport = new DevComponents.DotNetBar.RibbonTabItem();
            this.rtabHelp = new DevComponents.DotNetBar.RibbonTabItem();
            this.office2007StartButton1 = new DevComponents.DotNetBar.Office2007StartButton();
            this.titleMain = new DevComponents.DotNetBar.ButtonItem();
            this.picDevice = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ssLblSystem = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssLblSysState = new System.Windows.Forms.ToolStripStatusLabel();
            this.boolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssLblCurUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDistClock = new System.Windows.Forms.Timer(this.components);
            this.timerConnStatus = new System.Windows.Forms.Timer(this.components);
            this.timerDevStatus = new System.Windows.Forms.Timer(this.components);
            this.timerCalendar = new System.Windows.Forms.Timer(this.components);
            this.timerEvent = new System.Windows.Forms.Timer(this.components);
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel3.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel5.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CanCustomize = false;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Controls.Add(this.ribbonPanel3);
            this.ribbonControl1.Controls.Add(this.ribbonPanel5);
            this.ribbonControl1.Controls.Add(this.ribbonPanel4);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Expanded = false;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rtabSystem,
            this.rtabWork,
            this.rtabDistribute,
            this.rtabMonitor,
            this.rtabReport,
            this.rtabHelp});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.office2007StartButton1,
            this.titleMain});
            this.ribbonControl1.Size = new System.Drawing.Size(915, 100);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel3.Controls.Add(this.rbbUser);
            this.ribbonPanel3.Controls.Add(this.ribbonBar13);
            this.ribbonPanel3.Controls.Add(this.ribbonBar6);
            this.ribbonPanel3.Controls.Add(this.ribbonBar5);
            this.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel3.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel3.Size = new System.Drawing.Size(915, 43);
            this.ribbonPanel3.TabIndex = 3;
            this.ribbonPanel3.Visible = false;
            // 
            // rbbUser
            // 
            this.rbbUser.AutoOverflowEnabled = true;
            this.rbbUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbbUser.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnUser});
            this.rbbUser.Location = new System.Drawing.Point(243, 0);
            this.rbbUser.Name = "rbbUser";
            this.rbbUser.Size = new System.Drawing.Size(70, 40);
            this.rbbUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbbUser.TabIndex = 3;
            this.rbbUser.Visible = false;
            // 
            // btnUser
            // 
            this.btnUser.ImagePaddingHorizontal = 8;
            this.btnUser.Name = "btnUser";
            this.btnUser.SubItemsExpandWidth = 14;
            this.btnUser.Text = "用户管理";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // ribbonBar13
            // 
            this.ribbonBar13.AutoOverflowEnabled = true;
            this.ribbonBar13.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar13.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnClass});
            this.ribbonBar13.Location = new System.Drawing.Point(173, 0);
            this.ribbonBar13.Name = "ribbonBar13";
            this.ribbonBar13.Size = new System.Drawing.Size(70, 40);
            this.ribbonBar13.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar13.TabIndex = 2;
            // 
            // btnClass
            // 
            this.btnClass.ImagePaddingHorizontal = 8;
            this.btnClass.Name = "btnClass";
            this.btnClass.SubItemsExpandWidth = 14;
            this.btnClass.Text = "班次管理";
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click_1);
            // 
            // ribbonBar6
            // 
            this.ribbonBar6.AutoOverflowEnabled = true;
            this.ribbonBar6.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar6.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rbtnBatch});
            this.ribbonBar6.Location = new System.Drawing.Point(73, 0);
            this.ribbonBar6.Name = "ribbonBar6";
            this.ribbonBar6.Size = new System.Drawing.Size(100, 40);
            this.ribbonBar6.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar6.TabIndex = 1;
            // 
            // rbtnBatch
            // 
            this.rbtnBatch.ImagePaddingHorizontal = 8;
            this.rbtnBatch.Name = "rbtnBatch";
            this.rbtnBatch.SubItemsExpandWidth = 14;
            this.rbtnBatch.Text = "批号＆小组管理";
            this.rbtnBatch.Click += new System.EventHandler(this.rbtnBatch_Click);
            // 
            // ribbonBar5
            // 
            this.ribbonBar5.AutoOverflowEnabled = true;
            this.ribbonBar5.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar5.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDeviceConfig});
            this.ribbonBar5.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar5.Name = "ribbonBar5";
            this.ribbonBar5.Size = new System.Drawing.Size(70, 40);
            this.ribbonBar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar5.TabIndex = 0;
            // 
            // btnDeviceConfig
            // 
            this.btnDeviceConfig.ImagePaddingHorizontal = 8;
            this.btnDeviceConfig.Name = "btnDeviceConfig";
            this.btnDeviceConfig.SubItemsExpandWidth = 14;
            this.btnDeviceConfig.Text = "设备管理";
            this.btnDeviceConfig.Click += new System.EventHandler(this.btnDeviceConfig_Click);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel1.Controls.Add(this.ribbonBar2);
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(915, 43);
            this.ribbonPanel1.TabIndex = 1;
            this.ribbonPanel1.Visible = false;
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAbout});
            this.ribbonBar2.Location = new System.Drawing.Point(53, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(71, 40);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar2.TabIndex = 1;
            // 
            // btnAbout
            // 
            this.btnAbout.ImagePaddingHorizontal = 8;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.SubItemsExpandWidth = 14;
            this.btnAbout.Text = "关于FSMS";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnLogin});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(50, 40);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.ImagePaddingHorizontal = 8;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.SubItemsExpandWidth = 14;
            this.btnLogin.Text = "登录";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel5.Controls.Add(this.ribbonBar12);
            this.ribbonPanel5.Controls.Add(this.ribbonBar8);
            this.ribbonPanel5.Controls.Add(this.ribbonBar7);
            this.ribbonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel5.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel5.Name = "ribbonPanel5";
            this.ribbonPanel5.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel5.Size = new System.Drawing.Size(915, 43);
            this.ribbonPanel5.TabIndex = 5;
            this.ribbonPanel5.Visible = false;
            // 
            // ribbonBar12
            // 
            this.ribbonBar12.AutoOverflowEnabled = true;
            this.ribbonBar12.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar12.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnBlockSilk});
            this.ribbonBar12.Location = new System.Drawing.Point(143, 0);
            this.ribbonBar12.Name = "ribbonBar12";
            this.ribbonBar12.Size = new System.Drawing.Size(70, 40);
            this.ribbonBar12.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar12.TabIndex = 2;
            // 
            // btnBlockSilk
            // 
            this.btnBlockSilk.ImagePaddingHorizontal = 8;
            this.btnBlockSilk.Name = "btnBlockSilk";
            this.btnBlockSilk.SubItemsExpandWidth = 14;
            this.btnBlockSilk.Text = "屏蔽丝道";
            this.btnBlockSilk.Click += new System.EventHandler(this.btnBlockSilk_Click);
            // 
            // ribbonBar8
            // 
            this.ribbonBar8.AutoOverflowEnabled = true;
            this.ribbonBar8.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar8.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSmallPkgTime});
            this.ribbonBar8.Location = new System.Drawing.Point(73, 0);
            this.ribbonBar8.Name = "ribbonBar8";
            this.ribbonBar8.Size = new System.Drawing.Size(70, 40);
            this.ribbonBar8.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar8.TabIndex = 1;
            // 
            // btnSmallPkgTime
            // 
            this.btnSmallPkgTime.ImagePaddingHorizontal = 8;
            this.btnSmallPkgTime.Name = "btnSmallPkgTime";
            this.btnSmallPkgTime.SubItemsExpandWidth = 14;
            this.btnSmallPkgTime.Text = "小卷时间";
            this.btnSmallPkgTime.Click += new System.EventHandler(this.btnSmallPkgTime_Click);
            // 
            // ribbonBar7
            // 
            this.ribbonBar7.AutoOverflowEnabled = true;
            this.ribbonBar7.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar7.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnClock});
            this.ribbonBar7.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar7.Name = "ribbonBar7";
            this.ribbonBar7.Size = new System.Drawing.Size(70, 40);
            this.ribbonBar7.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar7.TabIndex = 0;
            // 
            // btnClock
            // 
            this.btnClock.ImagePaddingHorizontal = 8;
            this.btnClock.Name = "btnClock";
            this.btnClock.SubItemsExpandWidth = 14;
            this.btnClock.Text = "时钟同步";
            this.btnClock.Click += new System.EventHandler(this.btnShield_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel2.Controls.Add(this.ribbonBar3);
            this.ribbonPanel2.Controls.Add(this.ribbonBar4);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(915, 43);
            this.ribbonPanel2.TabIndex = 2;
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDeviceState});
            this.ribbonBar3.Location = new System.Drawing.Point(73, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(70, 40);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar3.TabIndex = 2;
            this.ribbonBar3.Visible = false;
            // 
            // btnDeviceState
            // 
            this.btnDeviceState.ImagePaddingHorizontal = 8;
            this.btnDeviceState.Name = "btnDeviceState";
            this.btnDeviceState.SubItemsExpandWidth = 14;
            this.btnDeviceState.Text = "设备状态";
            this.btnDeviceState.Click += new System.EventHandler(this.btnDeviceState_Click);
            // 
            // ribbonBar4
            // 
            this.ribbonBar4.AutoOverflowEnabled = true;
            this.ribbonBar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAlarm});
            this.ribbonBar4.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar4.Name = "ribbonBar4";
            this.ribbonBar4.Size = new System.Drawing.Size(70, 40);
            this.ribbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar4.TabIndex = 1;
            // 
            // btnAlarm
            // 
            this.btnAlarm.ImagePaddingHorizontal = 8;
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.SubItemsExpandWidth = 14;
            this.btnAlarm.Text = "历史事件";
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel4.Controls.Add(this.ribbonBar11);
            this.ribbonPanel4.Controls.Add(this.ribbonBar10);
            this.ribbonPanel4.Controls.Add(this.ribbonBar9);
            this.ribbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel4.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel4.Size = new System.Drawing.Size(915, 43);
            this.ribbonPanel4.TabIndex = 6;
            this.ribbonPanel4.Visible = false;
            // 
            // ribbonBar11
            // 
            this.ribbonBar11.AutoOverflowEnabled = true;
            this.ribbonBar11.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar11.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMonthReport});
            this.ribbonBar11.Location = new System.Drawing.Point(123, 0);
            this.ribbonBar11.Name = "ribbonBar11";
            this.ribbonBar11.Size = new System.Drawing.Size(60, 40);
            this.ribbonBar11.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar11.TabIndex = 2;
            // 
            // btnMonthReport
            // 
            this.btnMonthReport.ImagePaddingHorizontal = 8;
            this.btnMonthReport.Name = "btnMonthReport";
            this.btnMonthReport.SubItemsExpandWidth = 14;
            this.btnMonthReport.Text = "月报表";
            this.btnMonthReport.Click += new System.EventHandler(this.btnMonthReport_Click);
            // 
            // ribbonBar10
            // 
            this.ribbonBar10.AutoOverflowEnabled = true;
            this.ribbonBar10.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar10.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDayReport});
            this.ribbonBar10.Location = new System.Drawing.Point(63, 0);
            this.ribbonBar10.Name = "ribbonBar10";
            this.ribbonBar10.Size = new System.Drawing.Size(60, 40);
            this.ribbonBar10.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar10.TabIndex = 1;
            // 
            // btnDayReport
            // 
            this.btnDayReport.ImagePaddingHorizontal = 8;
            this.btnDayReport.Name = "btnDayReport";
            this.btnDayReport.SubItemsExpandWidth = 14;
            this.btnDayReport.Text = "日报表";
            this.btnDayReport.Click += new System.EventHandler(this.btnDayReport_Click);
            // 
            // ribbonBar9
            // 
            this.ribbonBar9.AutoOverflowEnabled = true;
            this.ribbonBar9.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar9.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnClassReport});
            this.ribbonBar9.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar9.Name = "ribbonBar9";
            this.ribbonBar9.Size = new System.Drawing.Size(60, 40);
            this.ribbonBar9.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar9.TabIndex = 0;
            // 
            // btnClassReport
            // 
            this.btnClassReport.ImagePaddingHorizontal = 8;
            this.btnClassReport.Name = "btnClassReport";
            this.btnClassReport.SubItemsExpandWidth = 14;
            this.btnClassReport.Text = "班报表";
            this.btnClassReport.Click += new System.EventHandler(this.btnClassReport_Click);
            // 
            // rtabSystem
            // 
            this.rtabSystem.ImagePaddingHorizontal = 8;
            this.rtabSystem.Name = "rtabSystem";
            this.rtabSystem.Panel = this.ribbonPanel1;
            this.rtabSystem.Text = "系统";
            // 
            // rtabWork
            // 
            this.rtabWork.ImagePaddingHorizontal = 8;
            this.rtabWork.Name = "rtabWork";
            this.rtabWork.Panel = this.ribbonPanel3;
            this.rtabWork.Text = "运营";
            this.rtabWork.Visible = false;
            // 
            // rtabDistribute
            // 
            this.rtabDistribute.ImagePaddingHorizontal = 8;
            this.rtabDistribute.Name = "rtabDistribute";
            this.rtabDistribute.Panel = this.ribbonPanel5;
            this.rtabDistribute.Text = "下发";
            this.rtabDistribute.Visible = false;
            // 
            // rtabMonitor
            // 
            this.rtabMonitor.Checked = true;
            this.rtabMonitor.ImagePaddingHorizontal = 8;
            this.rtabMonitor.Name = "rtabMonitor";
            this.rtabMonitor.Panel = this.ribbonPanel2;
            this.rtabMonitor.Text = "监控";
            // 
            // rtabReport
            // 
            this.rtabReport.ImagePaddingHorizontal = 8;
            this.rtabReport.Name = "rtabReport";
            this.rtabReport.Panel = this.ribbonPanel4;
            this.rtabReport.Text = "报表";
            // 
            // rtabHelp
            // 
            this.rtabHelp.ImagePaddingHorizontal = 8;
            this.rtabHelp.Name = "rtabHelp";
            this.rtabHelp.Text = "帮助";
            this.rtabHelp.Click += new System.EventHandler(this.rtabHelp_Click);
            // 
            // office2007StartButton1
            // 
            this.office2007StartButton1.AutoExpandOnClick = true;
            this.office2007StartButton1.CanCustomize = false;
            this.office2007StartButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.office2007StartButton1.ImagePaddingHorizontal = 2;
            this.office2007StartButton1.ImagePaddingVertical = 2;
            this.office2007StartButton1.Name = "office2007StartButton1";
            this.office2007StartButton1.ShowSubItems = false;
            this.office2007StartButton1.Text = "&File";
            // 
            // titleMain
            // 
            this.titleMain.ImagePaddingHorizontal = 8;
            this.titleMain.Name = "titleMain";
            this.titleMain.Text = "纺丝线管理系统";
            // 
            // picDevice
            // 
            this.picDevice.BackColor = System.Drawing.Color.AliceBlue;
            this.picDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDevice.Location = new System.Drawing.Point(0, 100);
            this.picDevice.Name = "picDevice";
            this.picDevice.Size = new System.Drawing.Size(915, 507);
            this.picDevice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDevice.TabIndex = 64;
            this.picDevice.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssLblSystem,
            this.ssLblSysState,
            this.boolStripStatusLabel1,
            this.ssLblCurUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 585);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(915, 22);
            this.statusStrip1.TabIndex = 65;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ssLblSystem
            // 
            this.ssLblSystem.Name = "ssLblSystem";
            this.ssLblSystem.Size = new System.Drawing.Size(65, 17);
            this.ssLblSystem.Text = "系统状态：";
            // 
            // ssLblSysState
            // 
            this.ssLblSysState.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.ssLblSysState.Name = "ssLblSysState";
            this.ssLblSysState.Size = new System.Drawing.Size(41, 17);
            this.ssLblSysState.Text = "未连接";
            // 
            // boolStripStatusLabel1
            // 
            this.boolStripStatusLabel1.BackColor = System.Drawing.Color.AliceBlue;
            this.boolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(100, 3, 0, 2);
            this.boolStripStatusLabel1.Name = "boolStripStatusLabel1";
            this.boolStripStatusLabel1.Size = new System.Drawing.Size(77, 17);
            this.boolStripStatusLabel1.Text = "当前操作员：";
            // 
            // ssLblCurUser
            // 
            this.ssLblCurUser.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.ssLblCurUser.Name = "ssLblCurUser";
            this.ssLblCurUser.Size = new System.Drawing.Size(53, 17);
            this.ssLblCurUser.Text = "普通用户";
            // 
            // timerDistClock
            // 
            this.timerDistClock.Tick += new System.EventHandler(this.timerDistClock_Tick);
            // 
            // timerConnStatus
            // 
            this.timerConnStatus.Tick += new System.EventHandler(this.timerConnStatus_Tick);
            // 
            // timerDevStatus
            // 
            this.timerDevStatus.Tick += new System.EventHandler(this.timerDevStatus_Tick);
            // 
            // timerCalendar
            // 
            this.timerCalendar.Tick += new System.EventHandler(this.timerCalendar_Tick);
            // 
            // timerEvent
            // 
            this.timerEvent.Tick += new System.EventHandler(this.timerEvent_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(915, 607);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.picDevice);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MinimumSizeChanged += new System.EventHandler(this.frmMain_MinimumSizeChanged);
            this.MaximumSizeChanged += new System.EventHandler(this.frmMain_MaximumSizeChanged);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel3.ResumeLayout(false);
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel5.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDevice)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonTabItem rtabSystem;
        private DevComponents.DotNetBar.RibbonTabItem rtabMonitor;
        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton1;
        private DevComponents.DotNetBar.ButtonItem titleMain;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem btnAbout;
        public DevComponents.DotNetBar.ButtonItem btnLogin;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel3;
        public DevComponents.DotNetBar.RibbonTabItem rtabWork;
        private DevComponents.DotNetBar.RibbonBar ribbonBar4;
        private DevComponents.DotNetBar.ButtonItem btnAlarm;
        private DevComponents.DotNetBar.RibbonBar ribbonBar5;
        private DevComponents.DotNetBar.RibbonTabItem rtabHelp;
        private DevComponents.DotNetBar.ButtonItem btnDeviceConfig;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel5;
        private DevComponents.DotNetBar.RibbonBar ribbonBar7;
        private DevComponents.DotNetBar.ButtonItem btnClock;
        private DevComponents.DotNetBar.RibbonTabItem rtabDistribute;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel4;
        private DevComponents.DotNetBar.RibbonBar ribbonBar11;
        private DevComponents.DotNetBar.ButtonItem btnMonthReport;
        private DevComponents.DotNetBar.RibbonBar ribbonBar10;
        private DevComponents.DotNetBar.ButtonItem btnDayReport;
        private DevComponents.DotNetBar.RibbonBar ribbonBar9;
        private DevComponents.DotNetBar.ButtonItem btnClassReport;
        private DevComponents.DotNetBar.RibbonTabItem rtabReport;
        public System.Windows.Forms.PictureBox picDevice;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ssLblSystem;
        private System.Windows.Forms.ToolStripStatusLabel ssLblSysState;
        private System.Windows.Forms.ToolStripStatusLabel boolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel ssLblCurUser;
        private DevComponents.DotNetBar.RibbonBar ribbonBar12;
        private DevComponents.DotNetBar.RibbonBar ribbonBar8;
        private DevComponents.DotNetBar.ButtonItem btnBlockSilk;
        private DevComponents.DotNetBar.ButtonItem btnSmallPkgTime;
        public System.Windows.Forms.Timer timerDistClock;
        private System.Windows.Forms.Timer timerConnStatus;
        private System.Windows.Forms.Timer timerDevStatus;
        private DevComponents.DotNetBar.RibbonBar ribbonBar6;
        private DevComponents.DotNetBar.ButtonItem rbtnBatch;
        private DevComponents.DotNetBar.RibbonBar ribbonBar13;
        private DevComponents.DotNetBar.ButtonItem btnClass;
        private System.Windows.Forms.Timer timerCalendar;
        private System.Windows.Forms.Timer timerEvent;
        public DevComponents.DotNetBar.RibbonBar rbbUser;
        private DevComponents.DotNetBar.ButtonItem btnUser;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ButtonItem btnDeviceState;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FSMS.controler;
using FSMS.common;
using System.Timers;
using System.Threading;

namespace FSMS.view
{
    public partial class frmMain : Form
    {

        private System.Timers.Timer _queryEventTimer = new System.Timers.Timer();
        private System.Timers.Timer _genCalendarTimer = new System.Timers.Timer();
        private System.Timers.Timer _distClockTimer = new System.Timers.Timer();
        private System.Timers.Timer _comConnTimer = new System.Timers.Timer();

        private System.Timers.Timer _devStateTimer = new System.Timers.Timer();


        private delegate void FlushDevState(); //代理
        private delegate void TryToConnCom();

        public frmMain()
        {

            FsmsContextControler.Init();

            InitializeComponent();
            //int boundWidth = Screen.GetBounds(this).Width;
            //int boundHeight = Screen.GetBounds(this).Height;
            DeviceMgmControler.LoadAllDevicePics(ref picDevice);
            DeviceMgmControler.ShowDevStatus(ref picDevice);

            timerConnStatus.Interval = GlobalDefiniation.Com_Conn_Interval;
            timerConnStatus.Enabled = true;
            timerConnStatus.Start();

            timerDevStatus.Interval = GlobalDefiniation.Update_Dev_State_Interval;
            timerDevStatus.Enabled = true;
            timerDevStatus.Start();

            //timerCalendar.Interval = GlobalDefiniation.ClassCalendar_Interval;
            //timerCalendar.Enabled = true;
            //timerCalendar.Start();

            //timerDistClock.Interval = GlobalDefiniation.Clock_Syn_Interval;
            //timerDistClock.Enabled = true;
            //timerDistClock.Start();

            //timerEvent.Interval = GlobalDefiniation.Query_Event_Interval;
            //timerEvent.Enabled = true;
            //timerEvent.Start();

            //_queryEventTimer.Interval = GlobalDefiniation.Query_Event_Interval;
            //_queryEventTimer.Elapsed += new System.Timers.ElapsedEventHandler(_queryEventTimer_Elapsed);
            //_queryEventTimer.Enabled = true;
            //_queryEventTimer.Start();

            //_comConnTimer.Interval = GlobalDefiniation.Com_Conn_Interval;
            //_comConnTimer.Elapsed += new System.Timers.ElapsedEventHandler(_comConnTimer_Elapsed);
            //_comConnTimer.Enabled = true;
            //_comConnTimer.Start();

            _distClockTimer.Interval = GlobalDefiniation.Clock_Syn_Interval;
            _distClockTimer.Elapsed += new System.Timers.ElapsedEventHandler(_distClockTimer_Elapsed);
            _distClockTimer.Enabled = true;
            _distClockTimer.Start();

            _genCalendarTimer.Interval = GlobalDefiniation.ClassCalendar_Interval;
            _genCalendarTimer.Elapsed +=new System.Timers.ElapsedEventHandler(_genCalendarTimer_Elapsed);
            _genCalendarTimer.Enabled = true;
            _genCalendarTimer.Start();

            //_devStateTimer.Interval = GlobalDefiniation.Update_Dev_State_Interval;
            //_devStateTimer.Elapsed += new System.Timers.ElapsedEventHandler(_devStateTimer_Elapsed);
            //_devStateTimer.Enabled = true;
            //_devStateTimer.Start();
            


            //Query Event in single thread
            Thread thread = new Thread(ThreadFuntion);
            thread.IsBackground = true;
            thread.Start();


            

        }

        private void ThreadFuntion()
        {
            while (true)
            {
                if (GlobalDefiniation.Enable_Auto_Query_Event)
                {
                    DistributionControler.QueryEvent();
                }
                System.Threading.Thread.Sleep(GlobalDefiniation.Query_Event_Interval);
            }
        }
        private void rtabHelp_Click(object sender, EventArgs e)
        {
            frmHelp form = new frmHelp();
            form.ShowDialog();
            form.Dispose();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout form = new frmAbout();
            form.ShowDialog();
            form.Dispose();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.Text == "登出")
            {

                this.Close();
                this.Dispose();
                Environment.Exit(0);
                
            }
            frmLogin form = new frmLogin( this);
            form.ShowDialog();
            form.Dispose();
        }

        private void btnDeviceConfig_Click(object sender, EventArgs e)
        {
            frmDevice form = new frmDevice(this);
            //if (GlobalDefiniation.UserRoleName == "Admin")
            //{
            //    form.gpDevice.Enabled = true;
            ////}
            //else
            //{
            //    form.gpDevice.Enabled = false;
            //}
            form.ShowDialog();
            form.Dispose();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            frmClass form = new frmClass();
            form.ShowDialog();
            form.Dispose();
        }

        private void btnShield_Click(object sender, EventArgs e)
        {
            frmClock form = new frmClock(this);
            form.ShowDialog();
            form.Dispose();

        }



        private void btnDevice_Click(object sender, EventArgs e)
        {
            frmDevState form = new frmDevState();
            form.ShowDialog();
            form.Dispose();
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            frmEvent form = new frmEvent();
            form.ShowDialog();
            form.Dispose();
        }

        private void btnClassReport_Click(object sender, EventArgs e)
        {
            frmClassReport form = new frmClassReport();
            form.ShowDialog();
            form.Dispose();
        }

        private void btnDayReport_Click(object sender, EventArgs e)
        {
            frmDayReport form = new frmDayReport();
            form.ShowDialog();
            form.Dispose();
        }

        private void btnMonthReport_Click(object sender, EventArgs e)
        {
            frmMonthReport form = new frmMonthReport();
            form.ShowDialog();
            form.Dispose();
        }

        private void frmMain_MaximumSizeChanged(object sender, EventArgs e)
        {
            this.Width = Screen.GetBounds(this).Width;
            this.Height = Screen.GetBounds(this).Height;
            this.Location = new System.Drawing.Point(0, 0);
        }

        private void frmMain_MinimumSizeChanged(object sender, EventArgs e)
        {
            this.Width = Screen.GetBounds(this).Width;
            this.Height = Screen.GetBounds(this).Height;
            this.Location = new System.Drawing.Point(0, 0);
        }

        private void btnSmallPkgTime_Click(object sender, EventArgs e)
        {
            frmSmallPkg form = new frmSmallPkg();
            form.ShowDialog();
            form.Dispose();
        }

        private void btnBlockSilk_Click(object sender, EventArgs e)
        {
            frmSilk form = new frmSilk();
            form.ShowDialog();
            form.Dispose();
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            frmGroup form = new frmGroup();
            form.ShowDialog();
            form.Dispose();
        }




       
        private void rbtnBatch_Click(object sender, EventArgs e)
        {
            frmBatch form = new frmBatch();
            form.ShowDialog();
            form.Dispose();
        }

        private void btnClass_Click_1(object sender, EventArgs e)
        {
            frmClass form = new frmClass();
            form.ShowDialog();
            form.Dispose();
        }


        private void timerConnStatus_Tick(object sender, EventArgs e)
        {
            if (FsmsContextControler.GetComConnState())
            {
                ssLblSysState.Text = "已连接";
            }
            else
            {

                FsmsContextControler.TryConnCom();

                ssLblSysState.Text = "未连接";
            }
        }

        private void timerDevStatus_Tick(object sender, EventArgs e)
        {
            DeviceMgmControler.ShowDevStatus(ref picDevice);
        }

        private void timerDistClock_Tick(object sender, EventArgs e)
        {

            DistributionControler.SendClockSync();
        }

        private void timerEvent_Tick(object sender, EventArgs e)
        {
            DistributionControler.QueryEvent();
        }

        private void timerCalendar_Tick(object sender, EventArgs e)
        {
            //Gen Class Calendar
            FsmsContextControler.GenClassCalendar();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmUser form = new frmUser();
            form.ShowDialog();
            form.Dispose();
        }

        private void btnDeviceState_Click(object sender, EventArgs e)
        {
            frmDevState form = new frmDevState();
            form.ShowDialog();
            form.Dispose();
        }




        private void _comConnTimer_Elapsed(object sender,ElapsedEventArgs e )
        {
            if (FsmsContextControler.GetComConnState())
            {
                ssLblSysState.Text = "已连接";
            }
            else
            {

                FsmsContextControler.TryConnCom();

                ssLblSysState.Text = "未连接";
            }
        }

        private void _devStateTimer_Elapsed(object sender,System.Timers.ElapsedEventArgs e)
        {
            DeviceMgmControler.ShowDevStatus(ref picDevice);
        }

        private void _distClockTimer_Elapsed(object sender, ElapsedEventArgs e)
        {

            DistributionControler.SendClockSync();
        }

        private void _queryEventTimer_Elapsed(object sender,System.Timers.ElapsedEventArgs e)
        {
            DistributionControler.QueryEvent();
        }

        private void _genCalendarTimer_Elapsed(object sender,System.Timers.ElapsedEventArgs e )
        {
            //Gen Class Calendar
            FsmsContextControler.GenClassCalendar();
        }

    }
}
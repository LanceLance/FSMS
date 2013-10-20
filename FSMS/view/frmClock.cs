using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FSMS.controler;
using FSMS.common;

namespace FSMS.view
{
    public partial class frmClock : Form
    {
        private Timer _timer = null;
 

        public frmClock(frmMain frm)
        {
            InitializeComponent();
            _timer = frm.timerDistClock;

            

            cbTimeCycle.Items.Add("每隔1分钟");//0
            cbTimeCycle.Items.Add("每隔5分钟");//1
            cbTimeCycle.Items.Add("每隔半小时");//2
            cbTimeCycle.Items.Add("每隔1小时");//3
            cbTimeCycle.Items.Add("每隔1天");//4
            cbTimeCycle.Items.Add("每隔一周");//5
    
            cbTimeCycle.SelectedIndex = GlobalDefiniation.AUTO_CLOCK_INDEX;
            checkbAutoClock.Checked = GlobalDefiniation.AUTO_CLOCK_CHECKED;
    
            
        
        
        }

        private void checkbAutoClock_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbAutoClock.Checked)
            {
                //MessageBox.Show(cbTimeCycle.Text + ",自动下发时钟同步,确认开启？");
                switch(cbTimeCycle.SelectedIndex)
                {
                    case 0:
                        _timer.Interval = 1000*60;
                        break;
                    case 1:
                        _timer.Interval = 1000*60*5;
                        break;
                    case 2:
                        _timer.Interval = 1000*60*30;
                        break;
                    case 3:
                        _timer.Interval = 1000*60*60;
                        break;
                    case 4:
                        _timer.Interval = 1000*60*60*24;
                        break;

                    case 5:
                        _timer.Interval = 1000*60*60*24*7;
                        break;
             
                    default:
                        _timer.Interval = 1000;
                        break;
                }

                //save data
                GlobalDefiniation.AUTO_CLOCK_INDEX = cbTimeCycle.SelectedIndex;
                GlobalDefiniation.AUTO_CLOCK_INTERVAL = _timer.Interval;
                GlobalDefiniation.AUTO_CLOCK_CHECKED = true;

                _timer.Enabled = true;
                _timer.Start();

                lblAutoClockStatus.Text = "自动下发时钟同步已开启，时间间隔为" + _timer.Interval.ToString() + "毫秒";
            }
            else
            {
                GlobalDefiniation.AUTO_CLOCK_CHECKED = false;
                _timer.Stop();
                _timer.Enabled = false;
                lblAutoClockStatus.Text = "未开启自动下发时钟同步";
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void btnClock_Click(object sender, EventArgs e)
        {
            int weekDay = DateTime.Now.Day;
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
    
            try
            {
                weekDay = Convert.ToInt32(tbDay.Text.Trim());
                hour = Convert.ToInt32(tbHour.Text.Trim());
                min = Convert.ToInt32(tbMin.Text.Trim());
        

            }
            catch(Exception)
            {
                MessageBox.Show("数据输入有误,请重新输入!");
                return;
            }
            if (weekDay < 0 || weekDay > 6)
            {
                MessageBox.Show("星期输入不正确,请重新输入!");
                tbDay.Text = "";
                return;
            }
            DistributionControler.SendClockSync(weekDay, hour, min);
        }

        private void btnCurrentClock_Click(object sender, EventArgs e)
        {
            if (-1 == DistributionControler.SendClockSync())
            {
                MessageBox.Show("时钟同步下发失败,请检查!");
                
            }
            else
            {
                MessageBox.Show("时钟同步下发成功!");
            }
        }
            
    }
}
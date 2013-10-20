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

            

            cbTimeCycle.Items.Add("ÿ��1����");//0
            cbTimeCycle.Items.Add("ÿ��5����");//1
            cbTimeCycle.Items.Add("ÿ����Сʱ");//2
            cbTimeCycle.Items.Add("ÿ��1Сʱ");//3
            cbTimeCycle.Items.Add("ÿ��1��");//4
            cbTimeCycle.Items.Add("ÿ��һ��");//5
    
            cbTimeCycle.SelectedIndex = GlobalDefiniation.AUTO_CLOCK_INDEX;
            checkbAutoClock.Checked = GlobalDefiniation.AUTO_CLOCK_CHECKED;
    
            
        
        
        }

        private void checkbAutoClock_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbAutoClock.Checked)
            {
                //MessageBox.Show(cbTimeCycle.Text + ",�Զ��·�ʱ��ͬ��,ȷ�Ͽ�����");
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

                lblAutoClockStatus.Text = "�Զ��·�ʱ��ͬ���ѿ�����ʱ����Ϊ" + _timer.Interval.ToString() + "����";
            }
            else
            {
                GlobalDefiniation.AUTO_CLOCK_CHECKED = false;
                _timer.Stop();
                _timer.Enabled = false;
                lblAutoClockStatus.Text = "δ�����Զ��·�ʱ��ͬ��";
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
                MessageBox.Show("������������,����������!");
                return;
            }
            if (weekDay < 0 || weekDay > 6)
            {
                MessageBox.Show("�������벻��ȷ,����������!");
                tbDay.Text = "";
                return;
            }
            DistributionControler.SendClockSync(weekDay, hour, min);
        }

        private void btnCurrentClock_Click(object sender, EventArgs e)
        {
            if (-1 == DistributionControler.SendClockSync())
            {
                MessageBox.Show("ʱ��ͬ���·�ʧ��,����!");
                
            }
            else
            {
                MessageBox.Show("ʱ��ͬ���·��ɹ�!");
            }
        }
            
    }
}
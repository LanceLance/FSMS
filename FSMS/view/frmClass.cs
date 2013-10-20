using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FSMS.controler;
using FSMS.common;
using System.Collections;

namespace FSMS.view
{
    public partial class frmClass : Form
    {
        public frmClass()
        {
            InitializeComponent();
            string startCalendar = ClassMgmControler.GetStartDate();
            if (startCalendar != "")
            {
                dtpStartDate.Value = DateTime.Parse(startCalendar);
            }
            else
            {
                dtpStartDate.Value = DateTime.Now;
            }
            dtpEndDate.Value = dtpStartDate.Value.AddDays(6);
            SetTabText();
            ArrayList listClassNames = ClassMgmControler.GetClassName();
            lstbClassNames.Items.AddRange(listClassNames.ToArray());
            //for (int i = 0; i < 7; i++)
            //{

            //    TabPage tp = (TabPage)Utils.getControl("tabPage" + i.ToString(), this.tabcCalendar);
            //    ListBox lstbSwitchTimes = (ListBox)Utils.getControl("lstb" + i.ToString(), tp);
            //    ArrayList listSwitchTimes = ClassMgmControler.GetSwitchTimes(GlobalDefiniation.WeekDayCnStr[i]);

            //    lstbSwitchTimes.Items.AddRange(listSwitchTimes.ToArray());
                
            //} 

        }



        private void SetTabText()
        {
            tabcCalendar.TabPages["tabPage1"].Text = "星期日";//dtpStartDate.Value.ToString("dddd");
            tabcCalendar.TabPages["tabPage2"].Text = "星期一";//dtpStartDate.Value.AddDays(1).ToString("dddd");
            tabcCalendar.TabPages["tabPage3"].Text = "星期二";//dtpStartDate.Value.AddDays(2).ToString("dddd");
            tabcCalendar.TabPages["tabPage4"].Text = "星期三";// dtpStartDate.Value.AddDays(3).ToString("dddd");
            tabcCalendar.TabPages["tabPage5"].Text = "星期四";// dtpStartDate.Value.AddDays(4).ToString("dddd");
            tabcCalendar.TabPages["tabPage6"].Text = "星期五";// dtpStartDate.Value.AddDays(5).ToString("dddd");
            tabcCalendar.TabPages["tabPage0"].Text = "星期六";// dtpStartDate.Value.AddDays(6).ToString("dddd");
        }


        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            SetTabText();

        }

        //update all 
        private void button1_Click(object sender, EventArgs e)
        {
            //if (dtpEndDate.Value.CompareTo(dtpStartDate.Value.AddDays(6)) < 0)
            //{

            //    MessageBox.Show("终止日期与开始日期最小间隔为6天,请检查!");
            //    dtpEndDate.Value = dtpStartDate.Value.AddDays(6);
            //    return;


            //}
            //check class 
            if(lstbClassNames.Items.Count < 1)
            {
                MessageBox.Show("请先输入组信息!");
                return ;
            }

            for(int i = 0;i< 7;i++)
            {
                TabPage tp = (TabPage)Utils.getControl("tabPage" + i.ToString(), this.tabcCalendar);
                ListBox lstbSwitchTimes = (ListBox)Utils.getControl("lstb" + i.ToString(), tp);

                if(lstbSwitchTimes.Items.Count < 1)
                {
                    MessageBox.Show("输入的换班时间不完整,请检查!");
                    return;
                }
            }

            //Update class info
            string [] classNames = new string[lstbClassNames.Items.Count];
            lstbClassNames.Items.CopyTo(classNames,0);
            ClassMgmControler.UpdateClass(classNames);

            //Update Calendar Info
            ClassMgmControler.DelCalendar();
            string sunday = Utils.GetThisSundayDate();
            //         startDate = DateTime.Parse(sunday);
            for (int i = 1; i < 8; i++)
            {
                int index = i % 7;
                TabPage tp = (TabPage)Utils.getControl("tabPage" + index.ToString(), this.tabcCalendar);
                ListBox lstbSwitchTimes = (ListBox)Utils.getControl("lstb" + index.ToString(), tp);
                string[] switchTimes = new string[lstbSwitchTimes.Items.Count];

                lstbSwitchTimes.Items.CopyTo(switchTimes, 0);
                if (switchTimes.Length > 0)
                {
                    //if (i == 1)
                    //    ClassMgmControler.AddCalendar(dtpStartDate.Value.ToString("yyyy-MM-dd"), dtpStartDate.Value.ToString("dddd"), switchTimes);
                    //else
                    {
                        ClassMgmControler.AddCalendar(DateTime.Parse(sunday).ToString("yyyy-MM-dd"), DateTime.Parse(sunday).AddDays(i - 1).ToString("dddd"), switchTimes);
                    }
                }
            }

            //gen class calendar
            ClassMgmControler.GenClassCalendar();

            MessageBox.Show("更新成功,请查详细信息!");

            ////Update ClassCalendar for 2 years from startdate

            //ClassMgmControler.DelClassCalendar(dtpStartDate.Value.ToString("yyyy-MM-dd"));
            
            //DateTime startTime = DateTime.Parse(dtpStartDate.Value.ToString("yyyy-MM-dd") + " 00:00:00");
            //DateTime endTime = DateTime.Parse(dtpEndDate.Value.ToString("yyyy-MM-dd") + " 23:59:59");
            
            //DateTime startDate = DateTime.Parse(dtpStartDate.Value.ToString("yyyy-MM-dd"));
            //DateTime endDate = DateTime.Parse(dtpEndDate.Value.ToString("yyyy-MM-dd"));
            //int count = 0;

            ////bool shouldStop = false;
            //while (endDate.CompareTo(startDate) >= 0)
            //{
            //    //7 tabPage
            //    for (int i = 1; i < 8; i++)
            //    {

            //        //if (startDate.CompareTo(endDate) > 0)
            //        //{
            //        //    shouldStop = true;
            //        //    break;
            //        //}
            //        // tab or control index,the 7th's index is 0
            //        int index = i % 7;
            //        //class index 0~count-1
            //        int classIndex = count % classNames.Length;

            //        //last timeframe
            //        //last tab index is (index+6)%7
            //        TabPage lasttp = (TabPage)Utils.getControl("tabPage" + ((index + 6) % 7).ToString(), this.tabcCalendar);
            //        ListBox lastlstbSwitchTimes = (ListBox)Utils.getControl("lstb" + ((index +6) % 7).ToString(), lasttp);
            //        string[] lastswitchTimes = new string[lastlstbSwitchTimes.Items.Count];
            //        lastlstbSwitchTimes.Items.CopyTo(lastswitchTimes, 0);

            //        //current timeframe
            //        TabPage tp = (TabPage)Utils.getControl("tabPage" + index.ToString(), this.tabcCalendar);
            //        ListBox lstbSwitchTimes = (ListBox)Utils.getControl("lstb" + index.ToString(), tp);
            //        string[] switchTimes = new string[lstbSwitchTimes.Items.Count];
            //        lstbSwitchTimes.Items.CopyTo(switchTimes, 0);

            //        for (int j = 0; j < lstbSwitchTimes.Items.Count ; j++)
            //        {
            //            if (j == 0)
            //            {
            //                string laststart = startDate.AddDays(-1).ToString("yyyy-MM-dd") + " " + lastswitchTimes[lastswitchTimes.Length - 1] + ":00";
            //                string start = startDate.ToString("yyyy-MM-dd") + " " + switchTimes[j] + ":00";
            //                ClassMgmControler.AddClassCalendar(laststart, start, classNames[classIndex]);
            //                count++;
            //                classIndex = count % classNames.Length;

            //                if (j + 1 < lstbSwitchTimes.Items.Count)
            //                {

            //                    string end = startDate.ToString("yyyy-MM-dd") + " " + switchTimes[j + 1] + ":00";
            //                    ClassMgmControler.AddClassCalendar(start, end, classNames[classIndex]);
            //                    count++;
            //                    classIndex = count % classNames.Length;
            //                }

            //            }
            //            else if (j + 1 < lstbSwitchTimes.Items.Count)
            //            {

            //                string start = startDate.ToString("yyyy-MM-dd") + " "+ switchTimes[j] + ":00";
            //                string end = startDate.ToString("yyyy-MM-dd") + " " + switchTimes[j+1] + ":00";
            //                ClassMgmControler.AddClassCalendar(start, end, classNames[classIndex]);

            //                count++;
            //                classIndex = count % classNames.Length;
            //            }

                        
                        
            //        }


            //        startDate = startDate.AddDays(1);
            //    }

            //}
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbClassName.Text = "";
        }

        private void btnAddClassName_Click(object sender, EventArgs e)
        {
            lstbClassNames.Items.Add(tbClassName.Text.ToString().Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string btnNamePrefix = "btnAdd";
            string lstbPrefix = "lstb";
            string gbPrefix = "gb";
            string dtpPrefix = "dtp";

            for (int i = 1; i < 8; i++)
            {
                int index = i % 7;
                Button btn = (Button)sender;
                if (btn.Name == btnNamePrefix + index.ToString())
                {
                    TabPage tp = (TabPage)Utils.getControl("tabPage" + index.ToString(),this.tabcCalendar);
                    ListBox lstb = (ListBox)Utils.getControl(lstbPrefix + index.ToString(), tp);
                    GroupBox gb = (GroupBox)Utils.getControl(gbPrefix + index.ToString(),tp);
                    DateTimePicker dtp = (DateTimePicker)Utils.getControl(dtpPrefix + index.ToString(), gb);
                    if (lstb.SelectedIndex > -1)
                        lstb.Items.Insert(lstb.SelectedIndex , dtp.Text);
                    else
                        lstb.Items.Add(dtp.Text);

                    break;
                    
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string btnNamePrefix = "btnDel";
            string lstbPrefix = "lstb";
     

            for (int i = 1; i < 8; i++)
            {
                int index = i % 7;
                Button btn = (Button)sender;
                if (btn.Name == btnNamePrefix + index.ToString())
                {
                    TabPage tp = (TabPage)Utils.getControl("tabPage" + index.ToString(), this.tabcCalendar);
                    ListBox lstb = (ListBox)Utils.getControl(lstbPrefix + index.ToString(), tp);

                    if (lstb.Items.Count > 0 && lstb.SelectedIndex > -1)
                        lstb.Items.RemoveAt(lstb.SelectedIndex);
                    else
                        MessageBox.Show("请先选择要删除的项!");
                    break;

                }
            }


            
            
        }

        private void lstb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void lstbClassNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbClassNames.SelectedIndex > -1)
            {
                tbClassName.Text = lstbClassNames.Text.ToString().Trim();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstbClassNames.SelectedIndex > -1)
            {
                lstbClassNames.Items.RemoveAt(lstbClassNames.SelectedIndex);
            }
            else
            {
                MessageBox.Show("请先选择要删除项!");
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstbClassNames.SelectedIndex > -1)
            {
                int index = lstbClassNames.SelectedIndex;
                lstbClassNames.Items.RemoveAt(lstbClassNames.SelectedIndex);
                lstbClassNames.Items.Insert(index, tbClassName.Text.ToString().Trim());
            }
            else
            {
                MessageBox.Show("请先选择要修改项!");
                return;
            }
        }

        private void linklbDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new frmClassCalendar();
            form.ShowDialog();
            form.Dispose();


        }
     
    }
}
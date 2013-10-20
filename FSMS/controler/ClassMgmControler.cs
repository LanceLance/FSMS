using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using FSMS.model;
using System.Data;
using System.Collections;
using FSMS.common;

namespace FSMS.controler
{
    class ClassMgmControler
    {

        private static object _lockCalendar = new object();

        public static void InitDateAndClass(ComboBox cb,DateTimePicker dtp)
        {
            
        }
        public static ArrayList GetClassName()
        { 
            DataTable dt = new DataTable();
            DataService.Instance().GetClasses(ref dt);
            ArrayList arr = new ArrayList();
            for (int i = 0; i < dt.Rows.Count;i++ )
            {
                arr.Add(dt.Rows[i]["ClassName"].ToString());
            }

            return arr;
        }

        public static void UpdateClass(string[] className)
        {
            DataService.Instance().DelClass();
            for (int i = 0; i < className.Length; i++)
            {
                if(className[i] != null && className[i].Trim() != "")
                    DataService.Instance().AddClass(className[i]);
            }
        }
        public static void AddCalendar(string startDate,string dayOfWeek,string [] switchTime)
        {
                    
            for(int i = 0;i <switchTime.Length;i++)
            {
                if(switchTime != null  && switchTime[i].Trim() != "")
                    DataService.Instance().AddCalendaInfo(startDate,dayOfWeek,switchTime[i]);
            }
            
        }
        public static int DelCalendar()
        {
            return DataService.Instance().DelCalendar();
        }
        public static int DelClass(string name)
        {
            return DataService.Instance().DelClass();
        }
        public static void UpdateClassCalendar(string []className,string startDate, string [] switchTimes)
        {
            //int ret = DataService.Instance().AddCalendaInfo(weekday, switchClock);  
        }

        public static int DelClassCalendar(string startDate)
        {
            string startTime = startDate + " 00:00:00";
            return DataService.Instance().DelClassCalendar(startTime);
        }

        public static void AddClassCalendar(string startTime,string endTime,string className)
        {
            DataService.Instance().AddClassCalendar(startTime, endTime, className);

        }

        public static ArrayList GetSwitchTimes(string dayOfWeek)
        {
            DataTable dt = new DataTable();
            DataService.Instance().GetSwitchTimes(dayOfWeek, ref dt);
            ArrayList arr = new ArrayList();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                arr.Add(dt.Rows[i]["SwitchClock"].ToString());
            }

            return arr;
        }

        public static string GetStartDate()
        {
            return DataService.Instance().GetStartDate();
        }

        public static void BindClassCalender(ref DataGridView dgv)
        {
            DataTable dt = new DataTable();
            DataService.Instance().GetClassCalendar(ref dt);

            dgv.Rows.Clear();
            if (dt.Rows.Count < 1)
                return;
            dgv.Rows.Add(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv.Rows[i].Cells["StartTime"].Value = dt.Rows[i]["StartDateTime"].ToString();
                dgv.Rows[i].Cells["EndTime"].Value = dt.Rows[i]["EndDateTime"].ToString();
                dgv.Rows[i].Cells["ClassName"].Value = dt.Rows[i]["ClassName"].ToString();
                dgv.Rows[i].Cells["UpdateTime"].Value = dt.Rows[i]["UpdateTime"].ToString();

            }
        }

        public static void GenClassCalendar()
        {
            lock (_lockCalendar)
            {

                DataTable dtClass = new DataTable();
                DataTable dtCalendar = new DataTable();

                DataService.Instance().GetClasses(ref dtClass);
                DataService.Instance().GetCalendar(ref dtCalendar);

                //Update class info
                if (dtCalendar.Rows.Count < 1)
                {
                    Logger.Instance().LogError("FsmsContextControler::GenClassCalendar: 没有日历信息,请检查!");
                    return;
                }

                if (dtClass.Rows.Count < 1)
                {
                    Logger.Instance().LogError("FsmsContextControler::GenClassCalendar: 没有班次信息,请检查!");
                    return;
                }
                int count = 0;
                string[] classNames = new string[dtClass.Rows.Count];
                string lastClassName = DataService.Instance().GetClassCalendarLastClass();
                for (int i = 0; i < dtClass.Rows.Count; i++)
                {
                    classNames[i] = dtClass.Rows[i]["ClassName"].ToString().Trim();

                    if (lastClassName == classNames[i])
                    {
                        count = (i + 1) % classNames.Length;
                    }
                }

                string lastDate = DataService.Instance().GetClassCalendarLastDate();
                DateTime startDate;
                if (lastDate != "")
                {
                    startDate = DateTime.Parse(lastDate).AddDays(1);
                }
                else
                {
                    //first time to generate the classcalendar
                    string sunday = Utils.GetThisSundayDate();
                    startDate = DateTime.Parse(sunday);
                    lastDate = DateTime.Parse(sunday).AddDays(-1).ToString("yyyy-MM-dd");

                }

                //set one four week class calendar

                for (int n = 0; n < 4; n++)
                {



                    for (int i = 0; i < 7; i++)
                    {
                        ArrayList switchTimes = new ArrayList();
                        ArrayList lastSwitchTimes = new ArrayList();

                        int classIndex = count % classNames.Length;

                        //GlobalDefiniation.WeekDayCnStr[i];
                        for (int j = 0; j < dtCalendar.Rows.Count; j++)
                        {
                            if (GlobalDefiniation.WeekDayCnStr[(i + 6) % 7] == dtCalendar.Rows[j]["DayOfWeek"].ToString())
                            {
                                lastSwitchTimes.Add(DateTime.Parse(dtCalendar.Rows[j]["SwitchClock"].ToString()).ToString("HH:mm"));
                            }

                            if (GlobalDefiniation.WeekDayCnStr[i] == dtCalendar.Rows[j]["DayOfWeek"].ToString())
                            {
                                switchTimes.Add(DateTime.Parse(dtCalendar.Rows[j]["SwitchClock"].ToString()).ToString("HH:mm"));
                            }
                        }


                        for (int k = 0; k < switchTimes.Count; k++)
                        {
                            if (k == 0)
                            {

                                string laststart = startDate.AddDays(-1).ToString("yyyy-MM-dd") + " " + lastSwitchTimes[lastSwitchTimes.Count - 1] + ":00";
                                string start = startDate.ToString("yyyy-MM-dd") + " " + switchTimes[k] + ":00";
                                ClassMgmControler.AddClassCalendar(laststart, start, classNames[classIndex]);
                                count++;
                                classIndex = count % classNames.Length;

                                if (k + 1 < switchTimes.Count)
                                {

                                    string end = startDate.ToString("yyyy-MM-dd") + " " + switchTimes[k + 1] + ":00";
                                    ClassMgmControler.AddClassCalendar(start, end, classNames[classIndex]);
                                    count++;
                                    classIndex = count % classNames.Length;
                                }

                            }
                            else if (k + 1 < switchTimes.Count)
                            {

                                string start = startDate.ToString("yyyy-MM-dd") + " " + switchTimes[k] + ":00";
                                string end = startDate.ToString("yyyy-MM-dd") + " " + switchTimes[k + 1] + ":00";
                                ClassMgmControler.AddClassCalendar(start, end, classNames[classIndex]);

                                count++;
                                classIndex = count % classNames.Length;
                            }
                        }

                        startDate = startDate.AddDays(1);
                    }
                }





            }
        }

    }
}

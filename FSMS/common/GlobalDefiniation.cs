using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace FSMS.common
{
    enum EWeekDayIndex
    { 
        SUN = 0,
        MON = 1,
        TUE = 2,
        WED = 3,
        THU = 4,
        FRI = 5,
        SAT = 6
        
    
    }



    class GlobalDefiniation
    {
        public static string[] WeekDayCnStr = new string[] { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
        public static string[] WeekDayEnStr = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        public static string[] DEV_STATE_STR = new string[] { "废丝", "卷绕", "废丝", "卷绕", "停机", "卷绕", "废丝", "故障" }; 
        public static string[] DEV_STATE_CMD = new string[] { "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8" };           
        public static string[] DEV_EVENT_STR = new string[] { "无新事件 ","JLB开启", "生头成功", "产生小卷", "切换成功", "停机", "卷绕断丝/恢复事件", "切换失败", "无应答", "恢复应答",  };
                                                                //DA                                                                                                //D8       D9                                                         
        public static Color[] DEV_STATE_COLOR = new Color[] { Color.DarkOrange,
                                                              Color.DarkGreen,
                                                              Color.DarkOrange,
                                                              Color.DarkGreen,
                                                              Color.DarkGray,
                                                              Color.DarkGreen,
                                                              Color.DarkOrange,
                                                              Color.DarkRed
                                                             };
        public static string DEV_BROKEN_SILK_STR = "断丝";
        public static Color DEV_BROKEN_SILK_COLOR = Color.DarkBlue;


        public static string TAB_COLUMN_BLOCKED_SILKS = "BLOCKED_SILKS";
        public static string TAB_COLUMN_SMALL_PKG_TIME = "SMALL_PKG_TIME";


        public static string[] Sent_Result_Str = { "未下发", "已下发" };

        public static string UserRoleName = "User";



        public static bool IsShowMsgBox = false;

        public static string FSMS_CONFIG_FILE = Application.StartupPath + @"\" + "FSMS.ini";
        public static string LOG_CONFIG_FILE = Application.StartupPath + @"\" + "LOG.ini";
        public static string SEQ_CONFIG_FILE = Application.StartupPath + @"\" + "SEQ.ini";




        public static bool AUTO_CLOCK_CHECKED = false;
        public static int AUTO_CLOCK_INTERVAL = 1000 * 60; //ms
        public static int AUTO_CLOCK_INDEX = 0;

        public static int Max_Msg_Len = 40;
        public static byte Msg_Head = 0xEA;
        public static int Msg_Recv_Timeout = 60 * 1; //s

        public static int Monitor_Time_Interval = 1000 * 60;//ms

        public static int Seq_No = 1;

        public static int Redo_Times = 2;
        public static long Start_Second = Utils.GetSecond();

        public static int Area_No = 0;
        public static int Mem_Addr = 0x0000;
        public static int Max7_Mem_Addr = 0x7f5f;
        public static int Max_Mem_Addr = 0x7ff8;
        public static int Min_Mem_Addr = 0x0000;


        public static int Clock_Syn_Interval = 1000 * 60 * 60 * 14;//14h
        public static int ClassCalendar_Interval = 1000 * 60 * 60 * 24;//24h
        public static int Query_Event_Interval = 1000 * 2; //1min
        public static int Update_Dev_State_Interval = 1000 * 100; //1min
        public static int Com_Conn_Interval = 3000; //1s

        public static bool Enable_Auto_Query_Event = true;
//状态定义
        public static string STATE1 = "D1";
        public static string STATE2 = "D2";
        public static string STATE3 = "D3";
        public static string STATE4 = "D4";
        public static string STATE5 = "D5";
        public static string STATE6 = "D6";
        public static string STATE7 = "D7";
    }
}

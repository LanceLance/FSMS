using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data.OleDb;
using System.Data;
using FSMS.common;

namespace FSMS.model
{
    class DataService
    {
        private string _connString = "";
        private OleDbConnection _oledbConn = null;
        private static DataService _instance; 

        private static object _lock = new object();
        private DataService()
        {
        
        }

        public static DataService Instance()       
        {               
            if(_instance == null)               
            {                      
                lock(_lock)                      
                {                             
                    if(_instance == null)                             
                    {
                        _instance = new DataService();                             
                    }                      
                }               
            }               
            return _instance;       
        }


        public void Open(string connStr)
        {
            _connString = connStr;
            Open();
        }
        private void Open()
        {

            try
            {
                _oledbConn = new OleDbConnection(_connString);
                _oledbConn.Open();
            }
            catch(Exception e)
            {
               Logger.Instance().LogError("DataService::Open: 数据库连接失败:"+e.Message);
            }
        }
        public void Close()
        {
            try
            {
                _oledbConn.Close();
                _oledbConn.Dispose();
            }
            catch (Exception e)
            {
                Logger.Instance().LogError("DataService::Close: 数据库连接失败:" + e.Message);
            }
        }

       
        public int Execute(string sql)
        {
            if(_oledbConn.State != ConnectionState.Open)
            {
                Close();
                Open();
            }

            int ret = 0;
            Logger.Instance().LogDebug(sql);
            using (OleDbCommand command = new OleDbCommand(sql))
            {
                // Set the Connection to the new OleDbConnection.
                command.Connection = _oledbConn;

                // Open the connection and execute the insert command.
                try
                {
                    ret = command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Logger.Instance().LogError("ExecuteNonQuery error: "+ e.Message);
                }
                // The connection is automatically closed when the
                // code exits the using block.
            }
            return ret;
        }

        public void Execute(string sql,ref int outInt)
        {
            if (_oledbConn.State != ConnectionState.Open)
            {
                Close();
                Open();
            }

            

            using (OleDbCommand command = new OleDbCommand(sql))
            {
                // Set the Connection to the new OleDbConnection.
                OleDbDataReader dr = null;
                try
                {
                    command.Connection = _oledbConn;
                    dr = command.ExecuteReader();
                    if (dr == null)
                        return;

                    if (!dr.HasRows)
                        return;
                    dr.Read();
                    outInt = Convert.ToInt32(dr[0].ToString());
                }
                catch (Exception e)
                {
                    Logger.Instance().LogError("Execute outInt error: " + e.Message);
                }
                dr.Close();
                dr.Dispose();
            }
        }

        public void Execute(string sql, ref string outStr)
        {
            if (_oledbConn.State != ConnectionState.Open)
            {
                Close();
                Open();
            }

            

            using (OleDbCommand command = new OleDbCommand(sql))
            {
                OleDbDataReader dr = null;
                try
                {
                    command.Connection = _oledbConn;
                    dr = command.ExecuteReader();
                    if (dr == null)
                        return;
                    if (!dr.HasRows)
                        return;
                    dr.Read();
                    outStr = dr[0].ToString();
                }
                catch (Exception e)
                {
                    Logger.Instance().LogError("Execute outStr error: " + e.Message);
                }
                dr.Close();
                dr.Dispose();
            }
        }

        public void Execute(string sql, ref DataTable outTable)
        {
            if (_oledbConn.State != ConnectionState.Open)
            {
                Close();
                Open();
            }

            using (OleDbDataAdapter adp = new OleDbDataAdapter(sql,_oledbConn))
            {
                DataSet ds = new DataSet();
                try
                {
                    adp.SelectCommand = new OleDbCommand(sql, _oledbConn);
                    adp.Fill(ds);
                    outTable = ds.Tables[0];
                }
                catch (Exception e)
                {
                    Logger.Instance().LogError("Execute outTable error: " + e.Message);
                }
                ds.Dispose();
                adp.SelectCommand.Dispose();
                
            }
        }


        public int AddBatchInfo(string batchNo,int first,int last)
        {

            string sql = "insert into T_BatchInfo(BatchNo,FirstDevNo,LastDevNo,UpdateTime)";
            sql += "VALUES ('" + batchNo +"',"+ first+ ","+last+",'"+Utils.GetTimeNowDbFmt()+"')";

            return Execute(sql) ;
        }

        public int AddBatchInfo(string batchNo, int first, int last,int singlePieWeight,int fullPkgTime,int smallPkgTime)
        {

            string sql = "insert into T_BatchInfo(BatchNo,FirstDevNo,LastDevNo,SinglePieWeight,FullPkgTime,SmallPkgTime,UpdateTime)";
            sql += "VALUES ('" + batchNo + "'," + first + "," + last + ","+ singlePieWeight + "," +fullPkgTime+ "," +smallPkgTime+ ",'" 
                + Utils.GetTimeNowDbFmt() + "')";

            return Execute(sql);
        }

        public int ModifyBatch(string batchNo,int smallPkgTime,int isSent)
        {

            string sql = "update T_BatchInfo set BatchNo='" + batchNo +"',SmallPkgTime=" + smallPkgTime.ToString()
                +",IsSent=" + isSent.ToString() +",UpdateTime='" + Utils.GetTimeNowDbFmt()+"' where BatchNo='" + batchNo + "'";
            return Execute(sql);
        }

        public int ModifyBatch(string batchNo,int isSent)
        {

            string sql = "update T_BatchInfo set BatchNo='" + batchNo +"',IsSent=" + isSent.ToString() 
                +",UpdateTime='" + Utils.GetTimeNowDbFmt()+"' where BatchNo='" + batchNo + "'";
            return Execute(sql);
        }
        public int DelBatch(int id)
        {

            string sql = "delete * from T_BatchInfo where ID=" + id;
            return Execute(sql);
        }
        public int DelBatch()
        {

            string sql = "delete * from T_BatchInfo";
            return Execute(sql);
        }
        public int AddEventInfo(MsgDevEvent msg)
        {
            string sql = "insert into T_DeviceEvent(DevNo,EventType,SilkNo,BrokenSilkBitStr,BatchNo,GroupName,EventTime,UpdateTime)";
            sql += "VALUES (" + Convert.ToInt32(msg.GetDevNoHStr(),16) + ",'" + Convert.ToString(msg.GetCmdCode(),16).ToUpper() + "','" + 
                msg.GetSilkNoH()  + "','" + msg.GetBrokenSilkBitStr() +"','" +
                msg.GetBatchNo() +"','" +msg.GetGroupName() + "','" + msg.GetEventTime() +"','"+ Utils.GetTimeNowDbFmt() + "')";

            return Execute(sql);
        }

        public int AddDevice(string devType, string devName, int devNo, string DevMac, int silkNum, string blockedSilkBitStr)
        {

            string sql = "insert into T_Device(DevType,DevName,DevNo,DevMac,SilkNum,BlockedSilkBitStr,UpdateTime)";
            sql += "VALUES ('" + devType + "','" + devName + "'," + devNo + ",'"+DevMac+"'," + silkNum + ",'"+ blockedSilkBitStr+"','" + Utils.GetTimeNowDbFmt() + "')";

            return Execute(sql);
        }



        public int GetGroupInfo(ref DataTable dt)
        {
            string sql = "select * from T_GroupInfo";
            Execute(sql, ref dt);
            return 0;

        }
        public int AddGroup(string groupName, int first,int last)
        {

            string sql = "insert into T_GroupInfo(GroupName,FirstDevNo,LastDevNo,UpdateTime)";
            sql += "VALUES ('" + groupName + "'," + first + ","+last+",'" + Utils.GetTimeNowDbFmt() + "')";

            return Execute(sql);
        }

        public int ModifyGroup(int id,string groupName, int first, int last)
        {

            string sql = "update T_GroupInfo set GroupName='" + groupName + "',FirstDevNo=" + first
                + ",LastDevNo=" + last + ",UpdateTime='" + Utils.GetTimeNowDbFmt() + "' where ID=" + id;
            return Execute(sql);
        }
        public int DelGroup(int id)
        {

            string sql = "delete * from T_GroupInfo where ID=" + id;
            return Execute(sql);
        }
        public int DelGroup()
        {

            string sql = "delete * from T_GroupInfo";
            return Execute(sql);
        }
        public int AddClassInfo(int year,int weekOfYear,string dayOfWeek,string className,long startSecOfWeek,long endSecOfWeek)
        {

            string sql = "insert into T_ClassInfo(ThisYear,MonthOfYear,WeekOfYear,DayOfWeek,ClassName,StartSecOfMonth,EndSecOfMonth,UpdateTime)";
            sql += "VALUES (" + year + "," + weekOfYear +",'"+dayOfWeek +"','" +className + "'," + startSecOfWeek + "," + endSecOfWeek 
                    + ",'" + Utils.GetTimeNowDbFmt() + "') ;";
            return Execute(sql);
        }

        public int AddUser(string userName, string userPwd,string roleName)
        {

            string sql = "insert into T_User(UserName,UserPwd,RoleName,UpdateTime)";
            sql += "VALUES ('" + userName + "','" + userPwd + "','" + roleName + "','" + Utils.GetTimeNowDbFmt() + "')";

            return Execute(sql);
        }

        public int AddSmallPkgDistInfo(string batchNo, int devNo, int smallPkgTime,int isSent)
        {

            string sql = "insert into T_SmallPkgDistInfo(BatchNo,DevNo,SmallPkgTime,IsSent,UpdateTime)";
            sql += "VALUES ('" + batchNo + "'," + devNo + "," + smallPkgTime + ","+ isSent +",'" + Utils.GetTimeNowDbFmt() + "')";

            return Execute(sql);
        }
        public int GetBatchInfo(ref DataTable dt)
        {
            string sql = "select * from T_BatchInfo" ;
            Execute(sql, ref dt);
            return 0;
        }

        public int GetBatchInfo(ref DataTable dt,int batchNo)
        {
            string sql = "select * from T_BatchInfo where BatchNo = '" + batchNo + "'";
            Execute(sql, ref dt);
            return 0;
        }

        public int GetUser(ref DataTable dt)
        {
            string sql = "select * from T_User ";
            Execute(sql, ref dt);
            return 0;

        }

        public string GetUserPwd(string userName)
        {
            string outStr = null;
            string sql = "select UserPwd from T_User where UserName = '" + userName +"';" ;
            Execute(sql, ref outStr);
            return outStr;
        }
        public string GetUserRole(string userName)
        {
            string outStr = null;
            string sql = "select RoleName from T_User where UserName = '" + userName + "';";
            Execute(sql, ref outStr);
            return outStr;
        }
        public bool IsUserExist(string userName)
        {
            int ret = 0;
            string sql = "select * from T_User where UserName = '" + userName + "';";
            ret = Execute(sql);
            return Convert.ToBoolean(ret);
        }
        public int DelUser(string userName)
        {
            string sql = "delete * from T_User where UserName ='" + userName +"'";
            return Execute(sql);
            

        }
        public int DelUser()
        {
            string sql = "delete * from T_User";
            return Execute(sql);


        }

        public int ModifyUser(string userName,string pwd,string role)
        {
            string sql = "update T_User set UserName='" +userName+"',UserPwd='"+pwd+"',RoleName='"+role+"' where UserName ='" + userName +"'";
            return Execute(sql);


        }
        public int ModifyDevice(int devNo,string blockedSilkBitStr,int isSent)
        {
            string sql = "update T_Device set DevNo =" +devNo+",BlockedSilkBitStr='"+ blockedSilkBitStr +"',IsSent="+ isSent+ ",UpdateTime='" + Utils.GetTimeNowDbFmt();
                sql += "' where DevNo = " + devNo ;
            return Execute(sql);
        }

        public int ModifyDevice(int devNo,int isSent)
        {
            string sql = "update T_Device set DevNo =" + devNo + ",IsSent=" + isSent + ",UpdateTime='" + Utils.GetTimeNowDbFmt();
            sql += "' where DevNo = " + devNo ;
            return Execute(sql);
        }
        public int ModifySmallPkgDistInfo(int devNo,int isSent)
        {
            string sql = "update T_SmallPkgDistInfo set IsSent=" + isSent + ",UpdateTime='" + Utils.GetTimeNowDbFmt();
            sql += "' where DevNo = " + devNo ;
            return Execute(sql);
        }

        public int DelDevice(int id)
        {
            string sql = "delete * from T_Device where ID = " + id;
            return Execute(sql);
        }
        public int DelDevice()
        {
            string sql = "delete * from T_Device";
            return Execute(sql);
        }
        public int DelSmallPkgDistInfo()
        {
            string sql = "delete * from T_SmallPkgDistInfo";
            return Execute(sql);
        }
        public int DelClassInfo(int thisYear,int weekOfYear)
        {
            string sql = "delete * from T_ClassInfo where WeekOfYear >" + weekOfYear + " and ThisYear > " + thisYear;
            return Execute(sql);
        }

        public int DelCalendar()
        {
            string sql = "delete * from T_Calendar";
            return Execute(sql);
        }

        public int AddCalendaInfo(string startDate,string dayOfWeek,string switchClock)
        {
            string sql = "insert into T_Calendar(StartDate,DayOfWeek,SwitchClock,UpdateTime) VALUES ";
            sql += "('"+ startDate +"','" + dayOfWeek +"','" + switchClock +"','" + Utils.GetTimeNowDbFmt() +"')";
            return Execute(sql);
        }

        public int AddClass(string className)
        {
            string sql = "insert into T_Class(ClassName,UpdateTime) VALUES ";
            sql += "('" + className + "','" + Utils.GetTimeNowDbFmt() + "')";
            return Execute(sql);
        }
        public void GetClasses(ref DataTable outTable)
        {
            string sql = "select ClassName from T_Class order by ID  ";
            
            Execute(sql,ref outTable);
        }
        public void GetCalendar(ref DataTable outTable)
        {
            string sql = "select * from T_Calendar";

            Execute(sql, ref outTable);
        }
        public string GetStartDate()
        {
            string sql = "select StartDate from T_Calendar";
            string outStr = "";
            Execute(sql,ref outStr);
            
            return outStr;
        }

        public int DelClass()
        {
            string sql = "delete * from T_Class";
            return Execute(sql);
        }
        public int DelClass(string name)
        {
            string sql = "delete * from T_Class where ClassName = '" + name +"'";
            return Execute(sql);
        }
        public int AddClassCalendar(string startTime,string endTime,string className)
        {
            string sql = "insert into T_ClassCalendar(StartDateTime,EndDateTime,ClassName,UpdateTime) VALUES ";
            sql += "('" + startTime +"','" +endTime +"','" + className + "','" + Utils.GetTimeNowDbFmt() + "')";
            return Execute(sql);
        }

        public string GetClassCalendarLastDate()
        {
            string sql = "select MAX(EndDateTime) from T_ClassCalendar";
            string outDateTime = "";
            Execute(sql, ref outDateTime);
            DateTime dt;
            try
            {
                dt = DateTime.Parse(outDateTime);
            }
            catch (Exception)
            {
                return "";
            }
            return dt.ToString("yyyy-MM-dd");
        }
        public string GetClassCalendarLastClass()
        {
            string sql = "select ClassName from T_ClassCalendar where EndDateTime=(select MAX(EndDateTime) from T_ClassCalendar)";
            string outClassName = "";
            try
            {
                Execute(sql, ref outClassName);
            }
            catch (Exception)
            { 
            
            }
            return outClassName;
        }
        public int DelClassCalendar(string startTime)
        {
            string sql = "delete * from T_ClassCalendar where EndDateTime > #" + startTime +"#";
            return Execute(sql);
        }

        public void GetSwitchTimes(string dayOfWeek,ref DataTable outTable)
        {
            string sql = "select * from T_Calendar where DayOfWeek = '" + dayOfWeek + "' order by SwitchClock";
            Execute(sql, ref outTable);
        }

        public void GetClassCalendar(ref DataTable outTable)
        {
            string sql = "select * from T_ClassCalendar order by StartDateTime";
            Execute(sql, ref outTable);
        }

        public void GetDevice(ref DataTable outTable)
        {

            string sql = "select * from T_Device";
            Execute(sql, ref outTable);
        }
        public void GetSmallPkgDist(ref DataTable outTable)
        {

            string sql = "select * from T_SmallPkgDistInfo";
            Execute(sql, ref outTable);
        }
        public void GetSmallPkgDist(ref DataTable outTable,string batchNo,int isSent)
        {

            string sql = "select * from T_SmallPkgDistInfo where BatchNo='" +batchNo + "' and IsSent=" + isSent ;
            Execute(sql, ref outTable);
        }
        public void GetDevice(ref DataTable outTable,int devNo)
        {

            string sql = "select * from T_Device where DevNo =" + devNo;
            Execute(sql, ref outTable);
        }

        public void GetDeviceByType(ref DataTable outTable,string devType)
        {

            string sql = "select * from T_Device where DevType ='" + devType + "' order by DevNo";
            Execute(sql, ref outTable);
        }
        public string GetDeviceNoByName( string devName)
        {

            string sql = "select DevNo from T_Device where DevName ='" + devName + "'";
            string outStr = "";
            Execute(sql, ref outStr);

            return outStr;
        }

        public int ModifyDeviceState(int devNo,string stateCodeH)
        {
            string sql = "update T_Device set DevState='" + stateCodeH + "' where DevNo = " + devNo ;
            return Execute(sql);
        }
        public int ModifyDeviceBrokenSilkBitStr(int devNo, string brokenSilkBitStr)
        {
            string sql = "update T_Device set BrokenSilkBitStr='" + brokenSilkBitStr + "' where DevNo = " + devNo ;
            return Execute(sql);
        }
        public int ModifyDeviceBlockedSilkBitStr(int devNo, string blockedSilkBitStr)
        {
            string sql = "update T_Device set BlockedSilkBitStr='" + blockedSilkBitStr + "' where DevNo = " + devNo ;
            return Execute(sql);
        }
        public void GetDeviceEvent1(ref DataTable outTable, int devNo)
        {
            string sql = "select * from T_DeviceEvent where DevNo=" + devNo ;
            Execute(sql, ref outTable);
        }
        public void GetDeviceEvent1(ref DataTable outTable, int devNo, string eventType)
        {
            string sql = "select * from T_DeviceEvent where DevNo=" + devNo + " and EventType='" + eventType + "'";
            Execute(sql, ref outTable);
        }

        public void GetDeviceEvent1(ref DataTable outTable, int devNo, string startTime, string endTime)
        {
            string sql = "select * from T_DeviceEvent where DevNo=" + devNo + " and  EventTime >=#" + startTime + "# and EventTime<=#" + endTime + "#";
            Execute(sql, ref outTable);
        }
        public void GetDeviceEvent1(ref DataTable outTable, int devNo, string startTime, string endTime, string eventType)
        {
            string sql = "select * from T_DeviceEvent where DevNo=" + devNo + " and  EventTime >=#" + startTime + "# and EventTime<=#" + endTime + "#";
            sql += " and EventType='" + eventType + "'";
            Execute(sql, ref outTable);
        }

        /// <summary>
        /// get all device event
        /// </summary>
        /// <param name="outTable"></param>
        public void GetDeviceEvent(ref DataTable outTable)
        {
            string sql = "select * from T_DeviceEvent ";
            Execute(sql, ref outTable);
        }

        public void GetDeviceEvent(ref DataTable outTable, string eventType)
        {
            string sql = "select * from T_DeviceEvent where EventType='" + eventType + "'";
            Execute(sql, ref outTable);
        }
        public void GetDeviceEvent(ref DataTable outTable, string eventType, string startTime, string endTime)
        {
            string sql = "select * from T_DeviceEvent where EventType='" + eventType + "' and EventTime >=#" + startTime + "# and EventTime<=#" + endTime + "#";
            Execute(sql, ref outTable);
        }
      
        public void GetDeviceEvent(ref DataTable outTable,string startTime, string endTime)
        {
            string sql = "select * from T_DeviceEvent where EventTime >=#" + startTime + "# and EventTime<=#" + endTime + "#";
            Execute(sql, ref outTable);
        }
   
        public void GetDeviceEventGroupByName(ref DataTable outTable)
        {
            string sql = "select DevNo from T_DeviceEvent group by DevNo";
            Execute(sql, ref outTable);
        }

        public int AddBrokenSilk(int devNo,int firstBrokenSilkNo,string eventTime)
        {
            string sql = "insert into T_BrokenSilk(DevNo,FirstBrokenSilkNo,EventTime,UpdateTime) VALUES ";
            sql += "(" + devNo + "," + firstBrokenSilkNo +",'"+ eventTime +"','"+ Utils.GetTimeNowDbFmt() + "')";
            return Execute(sql);
        }
        public void GetBrokenSilk(ref DataTable outTable)
        {
            string sql = "select * from T_BrokenSilk";
            Execute(sql, ref outTable);
        }

        public string GetBrokenBitStr(int devNo)
        {
            string sql = "select BrokenSilkBitStr from T_Device where DevNo=" + devNo ;
            string brokenBit = "";
            Execute(sql, ref brokenBit);

            return brokenBit;
        }
        public string GetBlockedBitStr(int devNo)
        {
            string sql = "select BlockedSilkBitStr from T_Device where DevNo=" + devNo ;
            string brokenBit = "";
            Execute(sql, ref brokenBit);

            return brokenBit;
        }

        public string GetBatchNoByDevNo(int devNo)
        {
            DataTable dt = new DataTable();
            DataService.Instance().GetBatchInfo(ref dt);
            string batchNo = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToInt32(dt.Rows[i]["FirstDevNo"].ToString()) <= Convert.ToUInt32(devNo) &&
                    Convert.ToUInt32(devNo) <= Convert.ToInt32(dt.Rows[i]["LastDevNo"].ToString()))
                {

                    batchNo = dt.Rows[i]["BatchNo"].ToString();
                    break;
                }
            }

            return batchNo;
        }

        public string GetGroupNameByDevNo(int devNo)
        {
            DataTable dt = new DataTable();
            DataService.Instance().GetGroupInfo(ref dt);
            string batchNo = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToInt32(dt.Rows[i]["FirstDevNo"].ToString()) <= Convert.ToUInt32(devNo) &&
                    Convert.ToUInt32(devNo) <= Convert.ToInt32(dt.Rows[i]["LastDevNo"].ToString()))
                {

                    batchNo = dt.Rows[i]["GroupName"].ToString();
                    break;
                }
            }

            return batchNo;
        }

        #region wengu.li    

        public void GetDeviceEventForReport(ref DataTable outTable, string startTime, string endTime)
        {
            string sql = "select * from T_DeviceEvent where EventTime >=#" + startTime + "# and EventTime<=#" + endTime + "#" + " and EventType in ('" + GlobalDefiniation.STATE1 + "','" + GlobalDefiniation.STATE2 + "','" + GlobalDefiniation.STATE3 + "','" + GlobalDefiniation.STATE4 + "','" + GlobalDefiniation.STATE5 + "','" + GlobalDefiniation.STATE6 + "','" + GlobalDefiniation.STATE7 + "'" + ")";
            Execute(sql, ref outTable);
        }

        public void GetDeviceEventForReport(ref DataTable outTable, string startTime, string endTime,string batchNo,string devNo)
        {
            string sql = "select * from T_DeviceEvent where EventTime >=#" + startTime + "# and EventTime<=#" + endTime + "#" + " and BatchNo = '" + batchNo + "' and DevNo = '" + devNo + "' and EventType in ('" + GlobalDefiniation.STATE1 + "','" + GlobalDefiniation.STATE2 + "','" + GlobalDefiniation.STATE3 + "','" + GlobalDefiniation.STATE4 + "','" + GlobalDefiniation.STATE5 + "','" + GlobalDefiniation.STATE6 + "','" + GlobalDefiniation.STATE7 + "'" + ") order by EventTime";
            Execute(sql, ref outTable);
        }

        /// <summary>
        /// 依据时间获取班组信息
        /// </summary>
        /// <param name="outTable"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        public void GetClassCalendar(ref DataTable outTable,string startTime,string endTime)
        {
            string sql = "select * from T_ClassCalendar where STARTDATETIME >=#" + startTime + "# and ENDDATETIME<=#" + endTime + "#";
            Execute(sql, ref outTable);
        }

        public int TruncateClassReport()
        {
            string sql = "delete * from T_ClassReport";
            return Execute(sql);
        }

        public int TruncateDayReport()
        {
            string sql = "delete * from T_DayReport";
            return Execute(sql);
        }

        public int TruncateMonthReport()
        {
            string sql = "delete * from T_MonthReport";
            return Execute(sql);
        }

        public int AddClassReport(ClassReport cr)
        {
            string sql = "insert into T_ClassReport(DevName,BatchNo,MjCount,QhFailCount,DsCount,BengProduct,ActProduct,FailProduct,MjProduct,Efficient)";
            sql += "VALUES ('" + cr.DevNo + "','" + cr.BatchNo + "','" + cr.MjCount + "','" + cr.QhFailCount + "','" + cr.DsCount + "','" + cr.BengProduct + "','" + cr.ActProduct + "','" + cr.FailProduct + "','" + cr.MjProduct + "','" + cr.Efficient + "')";
            return Execute(sql);
        }

        public int AddDayReport(DayReport dr)
        {
            string sql = "insert into T_DayReport(DevName,BatchNo,MjCount,QhFailCount,DsCount,BengProduct,ActProduct,FailProduct,MjProduct,Efficient)";
            sql += "VALUES ('" + dr.DevNo + "','" + dr.BatchNo + "','" + dr.MjCount + "','" + dr.QhFailCount + "','" + dr.DsCount + "','" + dr.BengProduct + "','" + dr.ActProduct + "','" + dr.FailProduct + "','" + dr.MjProduct + "','" + dr.Efficient + "')";
            return Execute(sql);
        }

        public int AddMonthReport(MonthReport mr)
        {
            string sql = "insert into T_MonthReport(DevName,BatchNo,MjCount,QhFailCount,DsCount,BengProduct,ActProduct,FailProduct,MjProduct,Efficient)";
            sql += "VALUES ('" + mr.DevNo + "','" + mr.BatchNo + "','" + mr.MjCount + "','" + mr.QhFailCount + "','" + mr.DsCount + "','" + mr.BengProduct + "','" + mr.ActProduct + "','" + mr.FailProduct + "','" + mr.MjProduct + "','" + mr.Efficient + "')";
            return Execute(sql);
        }

        public void GetDeviceEventBatchNo(ref DataTable outTable, string startTime, string endTime)
        {
            string sql = "select distinct(BatchNo) from T_DeviceEvent where EventTime >=#" + startTime + "# and EventTime<=#" + endTime + "#";
            Execute(sql, ref outTable);
        }

        public void GetDeviceEventDeviceNo(ref DataTable outTable, string startTime,string endTime)
        {

            string sql = "select distinct(DevNo) from T_DeviceEvent where EventTime >=#" + startTime + "# and EventTime<=#" + endTime + "#";
            Execute(sql, ref outTable);
        }

        public void GetDeviceEventBatchNoDevNo(ref DataTable outTable, string startTime, string endTime)
        {
            string sql = "select distinct BatchNo,DevNo from T_DeviceEvent where EventTime >=#" + startTime + "# and EventTime<=#" + endTime + "#";
            Execute(sql, ref outTable);
        }
        #endregion
    }
}

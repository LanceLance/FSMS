using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using FSMS.model;
using FSMS.common;

namespace FSMS.controler
{
    class ReportMgmControler
    {
        
        /// <summary>
        /// 绑定班报表记录
        /// </summary>
        /// <param name="dgv"></param>
        public static void BindClassReport(ref DataGridView dgv)
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
            }
        }

        /// <summary>
        /// 绑定班报表记录
        /// </summary>
        /// <param name="dgv"></param>
        public static void BindClassReport(ref DataGridView dgv, string startTime, string endTime)
        {
            DataTable dt = new DataTable();
            DataService.Instance().GetClassCalendar(ref dt, startTime, endTime);

            dgv.Rows.Clear();
            if (dt.Rows.Count < 1)
                return;
            dgv.Rows.Add(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv.Rows[i].Cells["StartTime"].Value = dt.Rows[i]["StartDateTime"].ToString();
                dgv.Rows[i].Cells["EndTime"].Value = dt.Rows[i]["EndDateTime"].ToString();
                dgv.Rows[i].Cells["ClassName"].Value = dt.Rows[i]["ClassName"].ToString();
            }
        }

        /// <summary>
        /// 生成班报表
        /// </summary>
        public static ArrayList GenClassReport(ClassCalendar cc)
        {
            int result = DataService.Instance().TruncateClassReport();

             TimeSpan classDiffSecond = DateTime.Parse(cc.EndTime) - DateTime.Parse(cc.StartTime);

            ArrayList classReportList = new ArrayList();
            ClassReport cr;
            BatchDevice bd;
            DeviceEvent de;

            //按班取设备事件列表
            ArrayList devEventList = new ArrayList();
            devEventList = GetDeviceEventList(cc);

            //事件列表内生产批号列表
            ArrayList batchList = new ArrayList();
            batchList = GetBatchList(cc);

            //事件列表内设备号列表
            ArrayList deviceList = new ArrayList();
            deviceList = GetDeviceList(cc);

            //事件列表内根据批次号筛选卷绕机号列表
            ArrayList batchDevList = new ArrayList();
            batchDevList = GetBatchDeviceList(cc);




            //按批次设备列表生成班报表列表
            for (int crcount = 0; crcount < batchDevList.Count; crcount++)
            {
                cr = new ClassReport();
                bd = (BatchDevice)batchDevList[crcount];
                cr.DevNo = bd.DevNo;
                cr.BatchNo = bd.BatchNo;
                cr.MjCount = "0";
                cr.QhFailCount = "0";
                cr.DsCount = "0";
                cr.BengProduct = "0";
                cr.ActProduct = "0";
                cr.FailProduct = "0";
                cr.MjProduct = "0";
                cr.Efficient = "0";
                classReportList.Add(cr);
            }
            
            for (int i = 0; i < devEventList.Count;i++ )
            {
                de =(DeviceEvent)devEventList[i];


                //满卷次数
                int mjCount = 0;
                //切换失败次数
                int qhfailCount = 0;
                //卷绕断丝次数
                int dsCount = 0;
                //满卷产量
                int mjProduct = 0;
               
                for (int m = 0; m < classReportList.Count; m++)
                {
                    cr = (ClassReport)classReportList[m];

                    #region Calc MjCount,QhFailCount,DsCount
                    mjCount =int.Parse(cr.MjCount);
                    qhfailCount = int.Parse(cr.QhFailCount);
                    dsCount = int.Parse(cr.DsCount);

                    if (de.DevNo == cr.DevNo && de.BatchNo == cr.BatchNo)
                    {
                        if (de.EventType == GlobalDefiniation.STATE4 || de.EventType == GlobalDefiniation.STATE7)//满卷次数
                        {
                            mjCount += 1;
                            cr.MjCount = mjCount.ToString();
                        }

                        if (de.EventType == GlobalDefiniation.STATE7)//切换失败次数
                        {
                            qhfailCount += 1;
                            cr.QhFailCount = qhfailCount.ToString();
                        }
                        
                        if (de.EventType == GlobalDefiniation.STATE6)//断丝次数
                        {
                            dsCount += 1;
                            cr.DsCount = dsCount.ToString();
                        }
                    }
                    #endregion
                    
                    #region Calc MjProduct
                    //计算满卷产量
                    if (mjCount != 0)
                    {

                        Batch bt = GetBatch(int.Parse(de.BatchNo));

                        Device dv = GetDevice(int.Parse(de.DevNo));

                        int blockSilkNum = 0;
                        if (dv.BlockedSilkBitStr != "")
                        {
                            char[] silkChr = dv.BlockedSilkBitStr.ToCharArray();
                            for (int j = 0; j < silkChr.Length; j++)
                            {
                                if (silkChr[j] == '1')
                                {
                                    blockSilkNum += 1;
                                }
                            }
                        }

                        int actSilkNum = int.Parse(dv.SilkNum) - blockSilkNum;

                        mjProduct = int.Parse(bt.SinglePieWeight) * actSilkNum * mjCount;

                        cr.MjProduct = mjProduct.ToString();
                    }
                    #endregion
                    
                }
            }

            #region Calc FailProduct,ActProduct

            #region 设备事件前后状态列表

            ArrayList bdList = new ArrayList();

            for (int x = 0; x < batchList.Count; x++)
            {
                Batch curBatch = (Batch)batchList[x];
                for (int y = 0; y < deviceList.Count; y++)
                {
                    Device curDev = (Device)deviceList[y];

                    ArrayList curBatchDevEventList = GetDeviceEventList(cc, curBatch, curDev);

                    for (int z = curBatchDevEventList.Count; z > 1; z--)
                    {
                        DeviceEvent curDE = (DeviceEvent)curBatchDevEventList[z - 1];
                        DeviceEvent abvDE = (DeviceEvent)curBatchDevEventList[z - 2];
                        TimeSpan diffSecond = DateTime.Parse(curDE.EventTime) - DateTime.Parse(abvDE.EventTime);
                        BatchDevice curbd = new BatchDevice();
                        curbd.BatchNo = curBatch.BatchNo;
                        curbd.DevNo = curDev.DevNo;
                        curbd.CurEventType = curDE.EventType;
                        curbd.AbvEventType = abvDE.EventType;
                        curbd.DiffSecond = diffSecond.TotalSeconds.ToString("0");

                        if (curbd.CurEventType == GlobalDefiniation.STATE6 && curbd.AbvEventType == GlobalDefiniation.STATE6)
                        {
                            curbd.BrokenSilkBitStr = abvDE.BrokenSilkBitStr;
                        }

                        bdList.Add(curbd);
                    }

                }
            }
            #endregion


            //计算废丝量,有效产量

            for (int m = 0; m < classReportList.Count; m++)
            {
                //满卷总时间
                int mjDuringTime = 0;
                //有效总时间
                int actDuringTime = 0;
                int sumActDuringTime = 0;
                //实际产量
                int actProduct = 0;
                //废丝总时间
                int failDuringTime = 0;
                int sumFailDuringTime = 0;
                //废丝量
                int failProduct = 0;
                //效率
                int efficient = 0;
                //断丝废丝量
                int brokenFailProduct = 0, sumBrokenFailProduct = 0;
                 //断丝有效量
                int brokenActProduct = 0, sumBrokenActProduct = 0;

                cr = (ClassReport)classReportList[m];

                for (int w = 0; w < bdList.Count; w++)
                {
                    BatchDevice bbdd = (BatchDevice)bdList[w];

                    if (bbdd.DevNo == cr.DevNo && bbdd.BatchNo == cr.BatchNo)
                    {
                        //废丝情况统计
                        if (bbdd.AbvEventType == GlobalDefiniation.STATE1 && bbdd.CurEventType == GlobalDefiniation.STATE5)
                        {
                            failDuringTime = int.Parse(bbdd.DiffSecond);
                            sumFailDuringTime += failDuringTime;
                        }
                        if (bbdd.AbvEventType == GlobalDefiniation.STATE1 && bbdd.CurEventType == GlobalDefiniation.STATE2)
                        {
                            failDuringTime = int.Parse(bbdd.DiffSecond);
                            sumFailDuringTime += failDuringTime;
                        }
                        if (bbdd.AbvEventType == GlobalDefiniation.STATE2 && bbdd.CurEventType == GlobalDefiniation.STATE3)
                        {
                            failDuringTime = int.Parse(bbdd.DiffSecond);
                            sumFailDuringTime += failDuringTime;
                        }
                        if (bbdd.AbvEventType == GlobalDefiniation.STATE3 && bbdd.CurEventType == GlobalDefiniation.STATE2)
                        {
                            failDuringTime = int.Parse(bbdd.DiffSecond);
                            sumFailDuringTime += failDuringTime;
                        }
                        if (bbdd.AbvEventType == GlobalDefiniation.STATE3 && bbdd.CurEventType == GlobalDefiniation.STATE5)
                        {
                            failDuringTime = int.Parse(bbdd.DiffSecond);
                            sumFailDuringTime += failDuringTime;
                        }
                        if (bbdd.AbvEventType == GlobalDefiniation.STATE6 && bbdd.CurEventType == GlobalDefiniation.STATE5)
                        {
                            failDuringTime = int.Parse(bbdd.DiffSecond);
                            sumFailDuringTime += failDuringTime;
                        }
                        if (bbdd.AbvEventType == GlobalDefiniation.STATE6 && bbdd.CurEventType == GlobalDefiniation.STATE2)
                        {
                            failDuringTime = int.Parse(bbdd.DiffSecond);
                            sumFailDuringTime += failDuringTime;
                        }
                        if (bbdd.AbvEventType == GlobalDefiniation.STATE7 && bbdd.CurEventType == GlobalDefiniation.STATE2)
                        {
                            failDuringTime = int.Parse(bbdd.DiffSecond);
                            sumFailDuringTime += failDuringTime;
                        }
                        if (bbdd.AbvEventType == GlobalDefiniation.STATE7 && bbdd.CurEventType == GlobalDefiniation.STATE5)
                        {
                            failDuringTime = int.Parse(bbdd.DiffSecond);
                            sumFailDuringTime += failDuringTime;
                        }




                        //有效情况统计
                        if (bbdd.AbvEventType == GlobalDefiniation.STATE2 && bbdd.CurEventType == GlobalDefiniation.STATE6)
                        {
                            actDuringTime = int.Parse(bbdd.DiffSecond);
                            sumActDuringTime = actDuringTime;
                        }
                        if (bbdd.AbvEventType == GlobalDefiniation.STATE4 && bbdd.CurEventType == GlobalDefiniation.STATE6)
                        {
                            actDuringTime = int.Parse(bbdd.DiffSecond);
                            sumActDuringTime = actDuringTime;
                        }

                        //断丝情况
                        if (bbdd.AbvEventType == GlobalDefiniation.STATE6 && bbdd.CurEventType == GlobalDefiniation.STATE6)
                        {
                            Device curBrokenDv = GetDevice(int.Parse(bbdd.DevNo));

                            Batch curBrokenBt = GetBatch(int.Parse(bbdd.BatchNo));

                            //断丝道数
                            int brokenSilkNum = 0;
                            if (bbdd.BrokenSilkBitStr != "")
                            {
                                char[] curBrokenSilkChr = bbdd.BrokenSilkBitStr.ToCharArray();
                                for (int j = 0; j < curBrokenSilkChr.Length; j++)
                                {
                                    if (curBrokenSilkChr[j] == '1')
                                    {
                                        brokenSilkNum += 1;
                                    }
                                }
                            }

                            //有效丝道数
                            int actSilkNum = int.Parse(curBrokenDv.SilkNum) - brokenSilkNum;

                            //当前废丝量
                            brokenFailProduct =int.Parse(bbdd.DiffSecond) * int.Parse(curBrokenBt.SinglePieWeight) * brokenSilkNum/int.Parse(curBrokenBt.FullPkgTime);
                            //总和断丝废思量
                            sumBrokenFailProduct += brokenFailProduct;

                            //当前有效量
                            brokenActProduct = int.Parse(bbdd.DiffSecond) * int.Parse(curBrokenBt.SinglePieWeight) * actSilkNum/ int.Parse(curBrokenBt.FullPkgTime);
                            //总和断丝有效量
                            sumBrokenActProduct += brokenActProduct;

                        }


                        //满卷情况统计
                        if (bbdd.AbvEventType == GlobalDefiniation.STATE2 && bbdd.CurEventType == GlobalDefiniation.STATE4)
                        {
                            mjDuringTime += int.Parse(bbdd.DiffSecond);
                        }
                        if (bbdd.AbvEventType == GlobalDefiniation.STATE2 && bbdd.CurEventType == GlobalDefiniation.STATE7)
                        {
                            mjDuringTime += int.Parse(bbdd.DiffSecond);
                        }
                        if (bbdd.AbvEventType == GlobalDefiniation.STATE4 && bbdd.CurEventType == GlobalDefiniation.STATE4)
                        {
                            mjDuringTime += int.Parse(bbdd.DiffSecond);
                        }
                        if (bbdd.AbvEventType == GlobalDefiniation.STATE6 && bbdd.CurEventType == GlobalDefiniation.STATE4)
                        {
                            mjDuringTime += int.Parse(bbdd.DiffSecond);
                        }
                        if (bbdd.AbvEventType == GlobalDefiniation.STATE6 && bbdd.CurEventType == GlobalDefiniation.STATE7)
                        {
                            mjDuringTime += int.Parse(bbdd.DiffSecond);
                        }
                      
                    }
                    
                }


                if (sumActDuringTime != 0 || sumFailDuringTime != 0)
                {

                    Batch curbt = GetBatch(int.Parse(cr.BatchNo));

                    Device curdv = GetDevice(int.Parse(cr.DevNo));

                    int failblockSilkNum = 0;
                    if (curdv.BlockedSilkBitStr != "")
                    {
                        char[] curSilkChr = curdv.BlockedSilkBitStr.ToCharArray();
                        for (int j = 0; j < curSilkChr.Length; j++)
                        {
                            if (curSilkChr[j] == '1')
                            {
                                failblockSilkNum += 1;
                            }
                        }
                    }

                    int actFailSilkNum = int.Parse(curdv.SilkNum) - failblockSilkNum;

                    int failResult = sumFailDuringTime * int.Parse(curbt.SinglePieWeight) * actFailSilkNum / int.Parse(curbt.FullPkgTime) + sumBrokenFailProduct;

                    int actResult = sumActDuringTime * int.Parse(curbt.SinglePieWeight) * actFailSilkNum / int.Parse(curbt.FullPkgTime) + sumBrokenActProduct;

                    cr.FailProduct = failResult.ToString();
                    cr.ActProduct = actResult.ToString();

                    cr.Efficient = ((classDiffSecond.TotalSeconds - failDuringTime) / classDiffSecond.TotalSeconds).ToString("0.00%");

                }

            }
            #endregion

            for (int i = 0; i < classReportList.Count; i++)
            {
                cr = (ClassReport)classReportList[i];
                DataService.Instance().AddClassReport(cr);
            }
            if (classReportList.Count != 0)
            {
                cr = (ClassReport)classReportList[0];
                DataService.Instance().AddClassReport(cr);
            }
            return classReportList;
        }

        /// <summary>
        /// 生成日报表
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        public static ArrayList GenDayReport(string day)
        {
            int result = DataService.Instance().TruncateDayReport();

            ArrayList dayReportList = new ArrayList();
            DayReport dr;
            Group gp;

           

            //获取组列表
            ArrayList groupList = new ArrayList();
            groupList = GetGroupList();

            //按组生成日报表列表
            for (int gpcount = 0; gpcount < groupList.Count; gpcount++)
            {
                dr = new DayReport();
                gp = (Group)groupList[gpcount];
                dr.DevNo = gp.GroupName;                
                dr.MjCount = "0";
                dr.QhFailCount = "0";
                dr.DsCount = "0";
                dr.BengProduct = "0";
                dr.ActProduct = "0";
                dr.FailProduct = "0";
                dr.MjProduct = "0";
                dr.Efficient = "0";
                dayReportList.Add(dr);
            }

            ClassCalendar cc = new ClassCalendar();
            cc.StartTime = day.Substring(0,10).Replace("-","/") + " 00:00:00";
            cc.EndTime = day.Substring(0, 10).Replace("-", "/") + " 23:59:59";

            ArrayList dayClassReportList = GenClassReport(cc);

            for (int j = 0; j < dayReportList.Count; j++)
            {
                //满卷次数
                int mjCount = 0, qhFailCount = 0, dsCount = 0, bengProduct = 0, actProduct = 0, failProduct = 0, mjProduct = 0;
                dr = (DayReport)dayReportList[j];
                gp = (Group)groupList[j];

                for (int i = 0; i < dayClassReportList.Count; i++)
                {
                    ClassReport cr = (ClassReport)dayClassReportList[i];
                    if (int.Parse(cr.DevNo) >= int.Parse(gp.FirstDevNo) && int.Parse(cr.DevNo) <= int.Parse(gp.LastDevNo))
                    {
                        mjCount +=int.Parse(cr.MjCount);
                        qhFailCount += int.Parse(cr.QhFailCount);
                        dsCount += int.Parse(cr.DsCount);
                        bengProduct += int.Parse(cr.BengProduct);
                        actProduct += int.Parse(cr.ActProduct);
                        failProduct += int.Parse(cr.FailProduct);
                        mjProduct += int.Parse(cr.MjProduct);
                    }
                }

                dr.MjCount = mjCount.ToString();
                dr.QhFailCount = qhFailCount.ToString();
                dr.DsCount = dsCount.ToString();
                dr.BengProduct = bengProduct.ToString();
                dr.ActProduct = actProduct.ToString();
                dr.FailProduct = failProduct.ToString();
                dr.MjProduct = mjProduct.ToString();
            }


            for (int i = 0; i < dayReportList.Count; i++)
            {
                dr = (DayReport)dayReportList[i];
                DataService.Instance().AddDayReport(dr);
            }
            if (dayReportList.Count != 0)
            {
                dr = (DayReport)dayReportList[0];
                DataService.Instance().AddDayReport(dr);
            }
            return dayReportList;

        }


        /// <summary>
        /// 生成月报表
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        public static ArrayList GenMonthReport(string month)
        {
            int result = DataService.Instance().TruncateMonthReport();

            ArrayList monthReportList = new ArrayList();
            MonthReport mr;
            Class cl;

            ClassCalendar cc = new ClassCalendar();
            cc.StartTime = month.Replace("-", "/") + "/01 00:00:00";

            string[] param = month.Split('-');
            int year = int.Parse(param[0]);
            int mont = int.Parse(param[1]);

            int days = DateTime.DaysInMonth(year, mont);

            cc.EndTime = month.Replace("-", "/") + "/" + days.ToString() + " 23:59:59";

            //获取时间内班次表
            ArrayList classCalendarList = new ArrayList();
            classCalendarList = GetClassCalendarList(cc);

            //获取班信息列表
            ArrayList classList = new ArrayList();
            classList = GetClassList();

            //按组生成月报表列表
            for (int clcount = 0; clcount < classList.Count; clcount++)
            {
                mr = new MonthReport();
                cl = (Class)classList[clcount];
                mr.DevNo = cl.ClassName;
                mr.MjCount = "0";
                mr.QhFailCount = "0";
                mr.DsCount = "0";
                mr.BengProduct = "0";
                mr.ActProduct = "0";
                mr.FailProduct = "0";
                mr.MjProduct = "0";
                mr.Efficient = "0";
                monthReportList.Add(mr);
            }

            for (int i = 0; i < monthReportList.Count; i++)
            {

                mr =(MonthReport) monthReportList[i];
                int summjCount = 0, sumqhFailCount = 0, sumdsCount = 0, sumbengProduct = 0, sumactProduct = 0, sumfailProduct = 0, summjProduct = 0;

                for (int j = 0; j < classCalendarList.Count; j++)
                {

                    ClassCalendar curcc = (ClassCalendar) classCalendarList[j];


                    if (curcc.ClassName == mr.DevNo)
                    {
                        ArrayList dayClassReportList = GenClassReport(curcc);
                        int ccmjCount = 0, ccqhFailCount = 0, ccdsCount = 0, ccbengProduct = 0, ccactProduct = 0, ccfailProduct = 0, ccmjProduct = 0;

                        for (int k = 0; k < dayClassReportList.Count; k++)
                        {
                            ClassReport curCr = (ClassReport)dayClassReportList[k];
                            int mjCount = 0, qhFailCount = 0, dsCount = 0, bengProduct = 0, actProduct = 0, failProduct = 0, mjProduct = 0;

                            mjCount = int.Parse(curCr.MjCount);
                            qhFailCount = int.Parse(curCr.QhFailCount);
                            dsCount = int.Parse(curCr.DsCount);
                            bengProduct = int.Parse(curCr.BengProduct);
                            actProduct = int.Parse(curCr.ActProduct);
                            failProduct = int.Parse(curCr.FailProduct);
                            mjProduct = int.Parse(curCr.MjProduct);

                            ccmjCount += mjCount;
                            ccqhFailCount += qhFailCount;
                            ccdsCount += dsCount;
                            ccbengProduct += bengProduct;
                            ccactProduct += actProduct;
                            ccfailProduct += failProduct;
                            ccmjProduct += mjProduct;
                        }

                        summjCount += ccmjCount;
                        sumqhFailCount += ccqhFailCount;
                        sumdsCount += ccdsCount;
                        sumbengProduct += ccbengProduct;
                        sumactProduct += ccactProduct;
                        sumfailProduct += ccfailProduct;
                        summjProduct += ccmjProduct;
                    }
                }

                mr.MjCount = summjCount.ToString();
                mr.QhFailCount = sumqhFailCount.ToString();
                mr.DsCount = sumdsCount.ToString();
                mr.BengProduct = sumbengProduct.ToString();
                mr.ActProduct = sumactProduct.ToString();
                mr.FailProduct = sumfailProduct.ToString();
                mr.MjProduct = summjProduct.ToString();

            }

            for (int i = 0; i < monthReportList.Count; i++)
            {
                mr = (MonthReport)monthReportList[i];
                DataService.Instance().AddMonthReport(mr);
            }
            if (monthReportList.Count != 0)
            {
                mr = (MonthReport)monthReportList[0];
                DataService.Instance().AddMonthReport(mr);
            }
            return monthReportList;

        }

        /// <summary>
        /// 获取设备信息列表
        /// </summary>
        /// <returns></returns>
        public static Device GetDevice(int deviceNo)
        {
            DataTable dt = new DataTable();
            DataService.Instance().GetDevice(ref dt,deviceNo);
            Device dv = new Device();
           
            if (dt.Rows.Count > 0)
            {
                dv.DevName = dt.Rows[0]["DevNo"].ToString();
                dv.DevName = dt.Rows[0]["DevName"].ToString();
                dv.DevType = dt.Rows[0]["DevType"].ToString();
                dv.DevMac = dt.Rows[0]["DevMac"].ToString();
                dv.SilkNum = dt.Rows[0]["SilkNum"].ToString();
                dv.BlockedSilkBitStr = dt.Rows[0]["BlockedSilkBitStr"].ToString();
                dv.BrokenSilkBitStr = dt.Rows[0]["BrokenSilkBitStr"].ToString();
            }
            return dv;
        }


        /// <summary>
        /// 获取设备信息列表
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetDeviceList()
        {
            DataTable dt = new DataTable();
            DataService.Instance().GetDevice(ref dt);            
            ArrayList devList = new ArrayList();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Device dv = new Device();
                    dv.DevName = dt.Rows[i]["DevName"].ToString();
                    dv.DevType = dt.Rows[i]["DevType"].ToString();
                    dv.DevMac = dt.Rows[i]["DevMac"].ToString();
                    dv.SilkNum = dt.Rows[i]["SilkNum"].ToString();
                    dv.BlockedSilkBitStr = dt.Rows[i]["BlockedSilkBitStr"].ToString();
                    dv.BrokenSilkBitStr = dt.Rows[i]["BrokenSilkBitStr"].ToString();
                    devList.Add(dv);
                }
            }
            return devList;
        }

        /// <summary>
        /// 事件列表内获取设备信息列表
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetDeviceList(ClassCalendar cc)
        {
            DataTable dt = new DataTable();
            DataService.Instance().GetDeviceEventDeviceNo(ref dt, cc.StartTime,cc.EndTime);
            ArrayList devList = new ArrayList();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Device dv = new Device();
                    dv.DevNo = dt.Rows[i]["DevNo"].ToString();                    
                    devList.Add(dv);
                }
            }
            return devList;
        }

        /// <summary>
        /// 设备事件列表中获取批次设备信息列表
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetBatchDeviceList(ClassCalendar cc)
        {
            DataTable dt = new DataTable();
            DataService.Instance().GetDeviceEventBatchNoDevNo(ref dt, cc.StartTime, cc.EndTime);
            ArrayList batchDevList = new ArrayList();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BatchDevice bd = new BatchDevice();
                    bd.BatchNo =dt.Rows[i]["BatchNo"].ToString();
                    bd.DevNo =dt.Rows[i]["DevNo"].ToString();
                    batchDevList.Add(bd);
                }
            }
            return batchDevList;
        }

        /// <summary>
        /// 根据批次号获取批次信息
        /// </summary>
        /// <returns></returns>
        public static Batch GetBatch(int batchNo)
        {
            DataTable dt = new DataTable();
            DataService.Instance().GetBatchInfo(ref dt,batchNo);
            Batch bt = new Batch();

            if (dt.Rows.Count > 0)
            {                
                bt.BatchNo = dt.Rows[0]["BatchNo"].ToString();
                bt.FirstDevNo = dt.Rows[0]["FirstDevNo"].ToString();
                bt.LastDevNo = dt.Rows[0]["LastDevNo"].ToString();
                bt.SinglePieWeight = dt.Rows[0]["SinglePieWeight"].ToString();
                bt.FullPkgTime = dt.Rows[0]["FullPkgTime"].ToString();
                bt.SmallPkgTime = dt.Rows[0]["SmallPkgTime"].ToString();
            }
            return bt;
        }

        /// <summary>
        /// 获取批次信息列表
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetBatchList()
        {
            DataTable dt = new DataTable();
            DataService.Instance().GetBatchInfo(ref dt);            
            ArrayList batchList = new ArrayList();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Batch bt = new Batch();                    
                    bt.BatchNo = dt.Rows[i]["BatchNo"].ToString();
                    bt.FirstDevNo = dt.Rows[i]["FirstDevNo"].ToString();
                    bt.LastDevNo = dt.Rows[i]["LastDevNo"].ToString();
                    batchList.Add(bt);
                }
            }
            return batchList;
        }

        /// <summary>
        /// 事件列表内获取批次信息列表
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetBatchList(ClassCalendar cc)
        {
            DataTable dt = new DataTable();
            DataService.Instance().GetDeviceEventBatchNo(ref dt, cc.StartTime, cc.EndTime);
            ArrayList batchList = new ArrayList();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Batch bt = new Batch();
                    bt.BatchNo = dt.Rows[i]["BatchNo"].ToString();
                    batchList.Add(bt);
                }
            }
            return batchList;
        }

        /// <summary>
        /// 按班次取设备事件列表
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetDeviceEventList(ClassCalendar cc)
        {
            DataTable dt = new DataTable();
            DataService.Instance().GetDeviceEventForReport(ref dt, cc.StartTime, cc.EndTime);
            ArrayList deviceEventList = new ArrayList();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DeviceEvent de = new DeviceEvent();
                    de.DevNo = dt.Rows[i]["DevNo"].ToString();
                    de.SilkNo = dt.Rows[i]["SilkNo"].ToString();
                    de.BatchNo = dt.Rows[i]["BatchNo"].ToString();
                    de.GroupName = dt.Rows[i]["GroupName"].ToString();
                    de.EventType = dt.Rows[i]["EventType"].ToString();
                    de.EventTime = dt.Rows[i]["EventTime"].ToString();
                    deviceEventList.Add(de);
                }
            }
            return deviceEventList;

        }

        /// <summary>
        /// 按班次取特定批次、特定设备的设备事件列表
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetDeviceEventList(ClassCalendar cc,Batch curBatch,Device curDev)
        {
            DataTable dt = new DataTable();
            DataService.Instance().GetDeviceEventForReport(ref dt, cc.StartTime, cc.EndTime, curBatch.BatchNo, curDev.DevNo);
            ArrayList deviceEventList = new ArrayList();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DeviceEvent de = new DeviceEvent();
                    de.DevNo = dt.Rows[i]["DevNo"].ToString();
                    de.SilkNo = dt.Rows[i]["SilkNo"].ToString();
                    de.BatchNo = dt.Rows[i]["BatchNo"].ToString();
                    de.GroupName = dt.Rows[i]["GroupName"].ToString();
                    de.EventType = dt.Rows[i]["EventType"].ToString();
                    de.BrokenSilkBitStr = dt.Rows[i]["BrokenSilkBitStr"].ToString();
                    de.EventTime = dt.Rows[i]["EventTime"].ToString();
                    deviceEventList.Add(de);
                }
            }
            return deviceEventList;

        }

        /// <summary>
        /// 获取组列表
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetGroupList()
        {
            DataTable dt = new DataTable();
            DataService.Instance().GetGroupInfo(ref dt);
            ArrayList groupList = new ArrayList();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Group gp = new Group();
                    gp.GroupName = dt.Rows[i]["GroupName"].ToString();
                    gp.FirstDevNo = dt.Rows[i]["FirstDevNo"].ToString();
                    gp.LastDevNo = dt.Rows[i]["LastDevNo"].ToString();
                    groupList.Add(gp);
                }
            }
            return groupList;
        }

        /// <summary>
        /// 获取班列表
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetClassList()
        {
            DataTable dt = new DataTable();
            DataService.Instance().GetClasses(ref dt);
            ArrayList classList = new ArrayList();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Class cl = new Class();
                    cl.ClassName = dt.Rows[i]["ClassName"].ToString();
                    classList.Add(cl);
                }
            }
            return classList;
        }

        /// <summary>
        /// 获取时间段内班次表
        /// </summary>
        /// <param name="cc"></param>
        /// <returns></returns>
        public static ArrayList GetClassCalendarList(ClassCalendar cc)
        {

            DataTable dt = new DataTable();
            DataService.Instance().GetClassCalendar(ref dt,cc.StartTime ,cc.EndTime);
            ArrayList classCalendarList = new ArrayList();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ClassCalendar curCC = new ClassCalendar();
                    curCC.ClassName = dt.Rows[i]["ClassName"].ToString();
                    curCC.StartTime = dt.Rows[i]["StartDateTime"].ToString();
                    curCC.EndTime = dt.Rows[i]["EndDateTime"].ToString();
                    classCalendarList.Add(curCC);
                }
            }
            return classCalendarList;
        }
    }
}

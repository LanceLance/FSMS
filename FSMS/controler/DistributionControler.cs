using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using FSMS.model;
using FSMS.common;

namespace FSMS.controler
{
    class DistributionControler
    {

        

        static public void InitSilkNo(ref CheckedListBox box)
        {
            for (int i = 1; i < 17; i++)
            {
                box.Items.Add("丝道_" + i);
            }           
        }

        public static int SendClockSync()
        {

            MsgHeader head = new MsgHeader(4, MsgType.Msg_Type_Dist_Clock_Syn);
            byte[] buf = new byte[6];
            buf[0] = head.GetBytes()[0];
            buf[1] = head.GetBytes()[1];
            buf[2] = head.GetBytes()[2];
            buf[3] = Convert.ToByte(Utils.GetWeekDayOfNowI());
            buf[4] = Convert.ToByte(DateTime.Now.Hour);
            buf[5] = Convert.ToByte(DateTime.Now.Minute);

            MsgStruct msgS = new MsgStruct();
            msgS.Init(buf, 6);

            MsgStruct outMsgS = new MsgStruct();
            if (-1 == SerialTransfer.Instance().SendAndRecv(msgS, ref outMsgS))
            {
                Logger.Instance().LogError("DistributionControler::SendClockSync: 串口通讯失败,请检查!.");
                return -1;
            }
            else
            {
                if (0 == Utils.MemoryCompare(msgS.GetBuf(), outMsgS.GetBuf()))
                {
                    Logger.Instance().LogDebug("DistributionControler::SendClockSync: 时钟同步成功!.");
                    return 0;
                }
                else
                {
                    Logger.Instance().LogError("DistributionControler::SendClockSync: 消息处理失败,请检查!.");
                    return -1;
                }
            }
            
        }
        public static int SendClockSync(int weekDay,int hour,int min)
        {

            MsgHeader head = new MsgHeader(4, MsgType.Msg_Type_Dist_Clock_Syn);
            byte[] buf = new byte[6];
            buf[0] = head.GetBytes()[0];
            buf[1] = head.GetBytes()[1];
            buf[2] = head.GetBytes()[2];
            buf[3] = Convert.ToByte(weekDay);
            buf[4] = Convert.ToByte(hour);
            buf[5] = Convert.ToByte(min);

            MsgStruct msgS = new MsgStruct();
            msgS.Init(buf, 6);

            MsgStruct outMsgS = new MsgStruct();
            if (-1 == SerialTransfer.Instance().SendAndRecv(msgS, ref outMsgS))
            {
                Logger.Instance().LogError("DistributionControler::SendClockSync: 时钟同步失败,请检查!.");
                return -1;
            }
            else
            {
                if (0 == Utils.MemoryCompare(msgS.GetBuf(), outMsgS.GetBuf()))
                {
                    Logger.Instance().LogDebug("DistributionControler::SendClockSync: 时钟同步成功!.");
                    return 0;
                }
                else
                {
                    Logger.Instance().LogError("DistributionControler::SendClockSync: 时钟同步失败,请检查!.");
                    return -1;
                }
            }

        }
        public static int SendBlockSilkNos(int devNo,string[] silkNos)
        {

            /*
             * EAH  06H  XXH  XXH   A2H    XXH       XXH     XXH
            开始   n   流水1 流水2 指令码  JRT号  每个位表达一个丝道，屏蔽的丝道位为0 
            ZKQ回答：
            EAH  04H  XXH  XXH   A2H   XXH

             */

            char[] arrSilk = new char[16];
            for (int i = 0; i < 16; i++)
            {
                arrSilk[i] = '0';
            }
            
            byte[] buf = new byte[3] { 0x00,0x00, 0x00};

       
            for (int j = 0; j < silkNos.Length; j++)
            {
                int silkNo = Convert.ToInt32(silkNos[j].Substring(silkNos[j].IndexOf('_') + 1));
                arrSilk[16 - silkNo] = '1';
            }
            string blockedSilk = new string(arrSilk);
            int blockedSilkI = Convert.ToInt32(blockedSilk, 2);

            buf[0] = Convert.ToByte(devNo);
            buf[1] = Convert.ToByte(blockedSilkI >> 8);
            buf[2] = Convert.ToByte(blockedSilkI & 0x00ff);
        
   
            MsgHeader head = new MsgHeader(4, MsgType.Msg_Type_Dist_Blocked_Silk);
            byte[] msg = new byte[6];
            for (int j = 0; j < 3; j++)
            {
                msg[j] = head.GetBytes()[j];
            }

            msg[3] = buf[0];
            msg[4] = buf[1];
            msg[5] = buf[2];

            
        
            MsgStruct msgS = new MsgStruct();
            msgS.Init(msg,6);
            MsgStruct outMsg = new MsgStruct();

            if (-1 == SerialTransfer.Instance().SendAndRecv(msgS, ref outMsg))
            {
                Logger.Instance().LogError("DistributionControler::SendBlockSilkNos: 屏蔽丝道号下发，请检查。");
                return -1;
            }
            else
            {
                if (0 != Utils.MemoryCompare(msgS.GetBuf(),outMsg.GetBuf()))
                {
                    Logger.Instance().LogError("DistributionControler::SendBlockSilkNos: 应答格式不正确，请检查。");
                    return -1;
                }
                Logger.Instance().LogDebug("DistributionControler::SendBlockSilkNos: 屏蔽丝道号下发成功!");

                if (-1 == DataService.Instance().ModifyDeviceBlockedSilkBitStr(devNo, blockedSilk))
                {
                    Logger.Instance().LogError("DistributionControler::SendBlockSilkNos: 数据库更新失败，请检查。");
                    return -1;
                }
                
           
                return 0;
            }
           
     

           

        }

        public static int SendSmallPkgTime(int devNo, int min, int sec)
        {
            /*
                EAH   04H  A1H   XXH    XXH   XXH 
                开始    n   指令码  JRT号    分      秒
                  ZKQ回答：
                 EAH   02H   A1H   XXH
                开始    n    指令码  JRT号

            */

            MsgHeader head = new MsgHeader(4, MsgType.Msg_Type_Dist_Small_Pkg_Time);

            byte[] buf = new byte[6];
            buf[0] = head.GetBytes()[0];
            buf[1] = head.GetBytes()[1];
            buf[2] = head.GetBytes()[2];
            buf[3] = Convert.ToByte(devNo);
            buf[4] = Convert.ToByte(min);
            buf[5] = Convert.ToByte(sec);

            MsgStruct msgS = new MsgStruct();
            msgS.Init(buf, 6);
            MsgStruct outMsg = new MsgStruct();

            if (-1 == SerialTransfer.Instance().SendAndRecv(msgS, ref outMsg))
            {
                Logger.Instance().LogError("DistributionControler::SendSmallPkgTime: 小卷时间下发，请检查。");
                return -1;
            }
            else
            {
                if (0 != Utils.MemoryCompare(msgS.GetBuf(), outMsg.GetBuf()))
                {
                    Logger.Instance().LogError("DistributionControler::SendSmallPkgTime: 应答格式不正确，请检查。");
                    return -1;
                }
                Logger.Instance().LogDebug("DistributionControler::SendSmallPkgTime: 小卷下发成功!");

                //if (DataService.Instance().ModifyBatch(batchNo, min * 60 + sec, 1) < 1)
                //{
                //    Logger.Instance().LogError("DistributionControler::SendSmallPkgTime: 下发标志位更新失败，请检查。");
                //    return -1;
                //}
                return 0;
            }
        
 
           
        }

        public static void QueryEvent()
        {
            /*
            EAH  04H    A5H    XXH      XX H     XXH
            开始   n    指令码  存储区号  地址号高  地址号低
            */

            byte[] buf = new byte[6];
            MsgHeader head = new MsgHeader(4, MsgType.Msg_Type_Dist_Query_Dev_Event);
            buf[0] = head.GetBytes()[0];
            buf[1] = head.GetBytes()[1];
            buf[2] = head.GetBytes()[2];
            int areaNo = 0;
            int memAddr = 0;

            Utils.GetMemArea(ref areaNo, ref memAddr);

            buf[3] = Convert.ToByte(areaNo);
            buf[4] = Convert.ToByte(memAddr >> 8);
            buf[5] = Convert.ToByte(memAddr & 0x00ff);

            MsgStruct msgS = new MsgStruct();
            msgS.Init(buf, 6);
            MsgStruct outMsg = new MsgStruct();

            if (-1 == SerialTransfer.Instance().SendAndRecv(msgS, ref outMsg))
            {
                Logger.Instance().LogError("DistributionControler::QueryEvent: 事件查询失败，请检查。");
            }
            else
            {
                
                if (memAddr != (Convert.ToInt32(outMsg.GetBuf()[outMsg.GetBufLen() - 2] << 8) + Convert.ToInt32(outMsg.GetBuf()[outMsg.GetBufLen() - 1])))
                {
                    Logger.Instance().LogError("DistributionControler::QueryEvent: 应答校验失败，请检查。");     
                    return;
                }
               

                if(outMsg.GetBuf()[2] == MsgType.Msg_Type_No_More_Event)
                {
                    Logger.Instance().LogDebug("DistributionControler::QueryEvent: 没有事件!.");
                    //sleep 10s
                    System.Threading.Thread.Sleep(600000);
                    return;
                }

                //validate event msg format


                //deal with the response
                Logger.Instance().LogDebug("DistributionControler::QueryEvent: 事件查询成功,开始处理应答...");

 
                try
                {

                    MsgDevEvent msgEvent = new MsgDevEvent(outMsg.GetBuf(), outMsg.GetBufLen());


                    if (msgEvent.GetBatchNo() == "" || msgEvent.GetGroupName() == "" ||msgEvent.GetDevNoHStr() == "")
                    {
                        Logger.Instance().LogWarning("DistributionControler::QueryEvent: 接收到的事件内容不合法");

                    }
                    else
                    {


                        if (outMsg.GetCmdCode() == MsgType.Msg_Type_Switch_Failed || outMsg.GetCmdCode() == MsgType.Msg_Type_Broken_Event)
                        {
                            //MsgDevEvent mevent = new MsgDevEvent(outMsg.GetBuf(), outMsg.GetBufLen());
                            if (outMsg.GetCmdCode() == MsgType.Msg_Type_Switch_Failed)
                            {
                                DataService.Instance().AddBrokenSilk(Convert.ToInt32(msgEvent.GetDevNoHStr(), 16), Convert.ToInt32(msgEvent.GetSilkNoH(), 16), msgEvent.GetEventTime());
                            }
                            else
                            {
                                string brokenBit = msgEvent.GetBrokenSilkBitStr();
                                if (brokenBit == "")
                                {
                                    brokenBit = "0000000000000000";
                                }

                                string blockedBit = DataService.Instance().GetBlockedBitStr(Convert.ToInt32(msgEvent.GetDevNoHStr(),16));
                                if (blockedBit == "")
                                {
                                    blockedBit = "0000000000000000";
                                }
                                string lastBrokenBit = DataService.Instance().GetBrokenBitStr(Convert.ToInt32(msgEvent.GetDevNoHStr(),16));
                                if (lastBrokenBit == "")
                                {
                                    lastBrokenBit = "0000000000000000";
                                }
                                if ((Convert.ToInt32(brokenBit, 2) ^ Convert.ToInt32(blockedBit, 2)) > 0 && (Convert.ToInt32(lastBrokenBit, 2) ^ Convert.ToInt32(blockedBit, 2)) == 0)
                                {
                                    //broken occur
                                    int tmp = Convert.ToInt32(brokenBit, 2) ^ Convert.ToInt32(blockedBit, 2);
                                    string tmpStr = Utils.ReverseStr(Convert.ToString(tmp, 2).PadLeft(16, '0'));
                                    char[] arrCh = tmpStr.ToCharArray();

                                    int silkNo = 0;
                                    for (int i = 0; i < arrCh.Length; i++)
                                    {
                                        if (arrCh[i] == '1')
                                        {
                                            silkNo = i;
                                            break;
                                        }
                                    }

                                    DataService.Instance().AddBrokenSilk(Convert.ToInt32(msgEvent.GetDevNoHStr(), 16), silkNo + 1, msgEvent.GetEventTime());

                                }
                                DataService.Instance().ModifyDeviceBrokenSilkBitStr(Convert.ToInt32(msgEvent.GetDevNoHStr(),16), brokenBit);
                            }
                        }

                        //MsgDevEvent msgEvent = new MsgDevEvent(outMsg.GetBuf(), outMsg.GetBufLen());


                        DataService.Instance().AddEventInfo(msgEvent);
                        DataService.Instance().ModifyDeviceState(Convert.ToInt32(msgEvent.GetDevNoHStr(),16), Convert.ToString(msgEvent.GetCmdCode(), 16).ToUpper());

                    }
                }
                catch (Exception e)
                {
                    Logger.Instance().LogError("DistributionControler::QueryEvent: 处理应答消息错误：."+e.Message);
                }
                
                Utils.IncMemArea();
                Logger.Instance().LogDebug("DistributionControler::QueryEvent: 存储流水号加8.");
            }



        }


        public static int SetDevID(int devNo,string devMacH)
        {
            byte[] buf = new byte[6];
            MsgHeader head = new MsgHeader(4, MsgType.Msg_Type_Dist_Set_Dev_No);

            buf[0] = head.GetBytes()[0];
            buf[1] = head.GetBytes()[1];
            buf[2] = head.GetBytes()[2];

            buf[3] = Convert.ToByte(devNo);
            buf[4] = Convert.ToByte(devMacH.PadLeft(4, '0').Substring(0, 2),16);
            buf[5] = Convert.ToByte(devMacH.PadLeft(4, '0').Substring(2, 2),16);

            MsgStruct msgS = new MsgStruct();
            msgS.Init(buf, 6);

            MsgStruct outMsg = new MsgStruct() ;

            if (-1 == SerialTransfer.Instance().SendAndRecv(msgS, ref outMsg))
            {
                Logger.Instance().LogError("DistributionControler::SetDevID: 赋地址（ID）失败，请检查!");
                return -1;
            }
            else
            {
                Logger.Instance().LogDebug("DistributionControler::SetDevID: 赋地址（ID）成功。");
                //check response

                if (0 != Utils.MemoryCompare(msgS.GetBuf(), outMsg.GetBuf()))
                {
                    Logger.Instance().LogError("DistributionControler::SetDevID:应答不正确，请检查!");
                    return -1;
                }
                if (0 == DataService.Instance().ModifyDevice(devNo, 1))
                {
                    Logger.Instance().LogError("DistributionControler::SetDevID:更新下发设备地址标志位失败，请检查!");
                }
                else
                {
                    Logger.Instance().LogDebug("DistributionControler::SetDevID: 数据库更新成功。");
                }
                return 0;
            }

        }
    }
}

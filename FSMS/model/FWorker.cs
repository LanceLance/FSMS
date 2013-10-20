using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using FSMS.common;

namespace FSMS.model
{
    class FWorker :  FThread
    {
        private MsgQueue _msgQ;
        public FWorker(ref MsgQueue msgQ)
        {
            _msgQ = msgQ;
        }

        

        public override void ThreadCallback(object threadContext)
        {
        //    while (true)
        //    {
        //        MsgStruct msg = null;
        //        if (0 == _msgQ.Get(ref msg))
        //        {
        //            //TODO: deal with msg
        //            if (msg.GetCmdCode() == MsgType.Msg_Type_No_More_Event)
        //            {
        //                continue;
        //            }
        //            //else if (msg.GetCmdCode() == MsgType.Msg_Type_Node_No_Resp || msg.GetCmdCode() == MsgType.Msg_Type_Node_Resume_Resp)
        //            //{ 
                        
        //            //}
        //            else if(msg.GetCmdCode() == MsgType.Msg_Type_Switch_Failed || msg.GetCmdCode() == MsgType.Msg_Type_Broken_Event)
        //            {
        //                MsgDevEvent mevent = new MsgDevEvent(msg.GetBuf(), msg.GetBufLen());
        //                if (msg.GetCmdCode() == MsgType.Msg_Type_Switch_Failed)
        //                {
        //                    DataService.Instance().AddBrokenSilk(mevent.GetDevNoHStr(), mevent.GetSilkNoH(),mevent.GetEventTime());
        //                }
        //                else
        //                {
        //                    string brokenBit = mevent.GetBrokenSilkBitStr();
        //                    if (brokenBit == "")
        //                    {
        //                        brokenBit = "0000000000000000";
        //                    }

        //                    string blockedBit = DataService.Instance().GetBlockedBitStr(Convert.ToString(mevent.GetCmdCode(), 16));
        //                    if (blockedBit == "") 
        //                    {
        //                        blockedBit = "0000000000000000";
        //                    }
        //                    string lastBrokenBit = DataService.Instance().GetBrokenBitStr(Convert.ToString(mevent.GetCmdCode(), 16));
        //                    if (lastBrokenBit == "") 
        //                    {
        //                        lastBrokenBit = "0000000000000000";
        //                    }
        //                    if ((Convert.ToInt32(brokenBit, 2) ^ Convert.ToInt32(blockedBit, 2)) > 0 && (Convert.ToInt32(lastBrokenBit, 2) ^ Convert.ToInt32(blockedBit, 2)) == 0)
        //                    {
        //                        //broken occur
        //                        DataService.Instance().AddBrokenSilk(mevent.GetDevNoHStr(), mevent.GetSilkNoH(), mevent.GetEventTime());

        //                    }
        //                    DataService.Instance().ModifyDeviceBrokenSilkBitStr(Convert.ToString(mevent.GetCmdCode(), 16), brokenBit);
        //                }
        //            }
              
        //            MsgDevEvent msgEvent = new MsgDevEvent(msg.GetBuf(),msg.GetBufLen());
        //            DataService.Instance().AddEventInfo(msgEvent);
        //            DataService.Instance().ModifyDeviceState(Convert.ToInt32(msgEvent.GetDevNoHStr()), Convert.ToString(msgEvent.GetCmdCode(), 16));
                 
                    
        //        }
        //        else
        //        {
        //            System.Threading.Thread.Sleep(10);
        //        }

        //    }
            
        }
    }
}

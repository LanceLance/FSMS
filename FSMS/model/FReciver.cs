using System;
using System.Collections.Generic;
using System.Text;
using FSMS.common;

namespace FSMS.model
{
    class FReciver : FThread
    {

        //private SerialTransfer _transfer;
        
        public FReciver(ref SerialTransfer transfer)
        {
            //_transfer = transfer;
        }

        public override void ThreadCallback(object threadContext)
        {
            //while (true)
            //{

            //    MsgStruct msg = new MsgStruct();

            //    int bufLen = _transfer.Read(ref msg);

            //    if (-1 == bufLen)
            //    {
            //        System.Threading.Thread.Sleep(10);
            //        continue;
            //    }

            //    if (msg.GetCmdCode() == MsgType.Msg_Type_Broken_Event ||
            //        msg.GetCmdCode() == MsgType.Msg_Type_JLB_Open ||
            //        msg.GetCmdCode() == MsgType.Msg_Type_No_More_Event ||
            //        msg.GetCmdCode() == MsgType.Msg_Type_Off_State ||
            //        msg.GetCmdCode() == MsgType.Msg_Type_Small_Pkg ||
            //        msg.GetCmdCode() == MsgType.Msg_Type_Spin_Success ||
            //        msg.GetCmdCode() == MsgType.Msg_Type_Switch_Failed ||
            //        msg.GetCmdCode() == MsgType.Msg_Type_Switch_Success ||
            //        msg.GetCmdCode() == MsgType.Msg_Type_Node_No_Resp || 
            //        msg.GetCmdCode() == MsgType.Msg_Type_Node_Resume_Resp )
            //    {
            //        MsgQueue.Instance().Put(msg);
            //    }
            //    else
            //    {
            //        MsgRespQueue.Instance().Put(msg);
            //    }

                          
                

                
            //}

        }
    }
}

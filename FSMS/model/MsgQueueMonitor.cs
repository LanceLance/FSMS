using System;
using System.Collections.Generic;
using System.Text;
using FSMS.common;

namespace FSMS.model
{
    class MsgQueueMonitor : FThread
    {

        private MsgSendQueue _sendMsgQ;

        public MsgQueueMonitor(ref MsgSendQueue msgQ)
        {
            _sendMsgQ = msgQ;
        }

        public override void ThreadCallback(object threadContext)
        {
            while (true)
            {

                MsgStruct msg = null;

                if (-1 == _sendMsgQ.GetCopy(ref msg))
                {

                }
                else
                {
                    if (Utils.GetSecond() - msg.GetSentTime() > GlobalDefiniation.Msg_Recv_Timeout)
                    {
                        //_sendMsgQ.Remove(msg.GetSeqNo());
                    }
                    
                }

                System.Threading.Thread.Sleep(GlobalDefiniation.Monitor_Time_Interval);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using FSMS.common;

namespace FSMS.model
{
    class FSender : FThread
    {

        //private MsgSendQueue _sendMsgQ;
        public FSender()
        {
            //_sendMsgQ = msgQ;
        }

        public override void ThreadCallback(object threadContext)
        {
            
            //while (true)
            //{
            //    MsgStruct msg = null;
            //    if (-1 == _sendMsgQ.Get(ref msg))
            //    {
            //        Logger.Instance().LogWarning("FSender::ThreadCallback: ���л�ȡ����ʧ��");
            //        System.Threading.Thread.Sleep(100);
            //        continue;
            //    }

            //    if (-1 == SerialTransfer.Instance().Write(msg.GetBuf()))
            //    {
            //        //Cannot send msg
            //        Logger.Instance().LogWarning("FSender::ThreadCallback: ��Ϣ����ʧ�ܣ���Ϣ��������С�");
            //    }
            //    else
            //    {
            //        msg.AddTimes();
            //        msg.SetSent(true);
            //        msg.SetSentTime(Utils.GetSecond());
            //        Logger.Instance().LogDebug("FSender::ThreadCallback: ��Ϣ���ͳɹ�����Ϣ��������С�");

            //    }

            //    _sendMsgQ.Put(msg);
                
            //    System.Threading.Thread.Sleep(100);
                

            //}



            
        }
    }
}

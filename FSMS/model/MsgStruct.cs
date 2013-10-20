using System;
using System.Collections.Generic;
using System.Text;
using FSMS.common;
using System.Threading;

namespace FSMS.model
{

    class MsgType
    {


        public static byte Msg_Type_Dist_Small_Pkg_Time = 0xA1;
        public static byte Msg_Type_Dist_Blocked_Silk = 0xA2;
        public static byte Msg_Type_Dist_Clock_Syn = 0xA3;
        public static byte Msg_Type_Dist_Set_Dev_No = 0xA4;
        public static byte Msg_Type_Dist_Query_Dev_Event = 0xA5;

        public static byte Msg_Type_JLB_Open = 0xD1;
        public static byte Msg_Type_Spin_Success = 0xD2;
        public static byte Msg_Type_Small_Pkg = 0xD3;
        public static byte Msg_Type_Switch_Success = 0xD4;
        public static byte Msg_Type_Off_State = 0xD5;

        public static byte Msg_Type_Broken_Event = 0xD6;
        public static byte Msg_Type_Switch_Failed = 0xD7;

   

        public static byte Msg_Type_Node_No_Resp = 0xD8;
        public static byte Msg_Type_Node_Resume_Resp = 0xD9;
        public static byte Msg_Type_No_More_Event = 0xDA;
    }

    class MsgStruct
    {
   
        private int _bufLen;
        private byte[] _buf = null; //= new byte[GlobalDefiniation.Max_Msg_Len];

        private int _sentTimes = 0;
        private bool _sentFlag = false;
        private long _sentTime;

        private ManualResetEvent _timesEvent = new ManualResetEvent(true);
        private ManualResetEvent _sentEvent = new ManualResetEvent(true);
        private ManualResetEvent _sentTimeEvent = new ManualResetEvent(true);

        public MsgStruct()
        {
            
        }

        public void Init(byte[] buf, int bufLen)
        {
  
            _bufLen = bufLen;
            _buf = new byte[_bufLen]; //init buf with the certain size
            _buf = buf;
        }

        public byte GetCmdCode()
        {
            return Convert.ToByte(_buf[2]);
        }

        public int GetBufLen()
        {
            return _bufLen;
        }

        public byte[] GetBuf()
        {
            return _buf;
        }

        public void AddTimes()
        {
            _timesEvent.WaitOne();
            _sentTimes++;
            _timesEvent.Set();
        }

        public int GetTimes()
        {
            int times = 0;
            _timesEvent.WaitOne();
            times = _sentTimes;
            _timesEvent.Set();

            return times;
        }

        public void SetSent(bool sent)
        {
            _sentEvent.WaitOne();
            _sentFlag = sent;
            _sentEvent.Set();

        }

        public bool GetSent()
        {
            bool sent = false;
            _sentEvent.WaitOne();
            sent = _sentFlag;
            _sentEvent.Set();

            return sent;
        }

        public void SetSentTime(long time)
        {
            _sentTimeEvent.WaitOne();

            _sentTime = time;

            _sentTimeEvent.Set();

        }
        public long GetSentTime()
        {
            long time = 0;
            _sentTimeEvent.WaitOne();
            time = _sentTime;
            _sentTimeEvent.Set();

            return time;

        }

    }

    class MsgHeader
    {
        private  byte _head = 0xEA;
        private  int _len ;   //1byte
        //private  int _seqNo ;  //2byte
        private  byte _cmdCode;
        

        
        public MsgHeader(int len,byte cmdCode)
        {
            _len = len;
            //_seqNo = seqNo;
            _cmdCode = cmdCode;    
        }

        public MsgHeader(byte[] buf,int bufLen)
        {
            _len = bufLen - 2;
            //_seqNo = Convert.ToInt32(buf[2] << 8) + Convert.ToInt32(buf[3]);
            _cmdCode = Convert.ToByte(buf[2]);
        }

        public string GetHexStr()
        {
            return Convert.ToString(_head).PadLeft(2, '0')
                    + Convert.ToString(_len, 16).PadLeft(2, '0')
                    //+ Convert.ToString(_seqNo, 16).PadLeft(4, '0')
                    + Convert.ToString(_cmdCode).PadLeft(2, '0');
        }

        public byte[] GetBytes()
        {
            byte[] buf = new byte[3];
            buf[0] = _head;
            buf[1] = Convert.ToByte(_len);
           // buf[2] = Convert.ToByte(Convert.ToString(_seqNo, 16).PadLeft(4, '0').Substring(0, 2),16);
           // buf[3] = Convert.ToByte(Convert.ToString(_seqNo, 16).PadLeft(4, '0').Substring(2, 2), 16);
            buf[2] = _cmdCode;

            return buf;

        }

        //public int GetSeqNo()
        //{
        //    return _seqNo;
        //}

        public int GetLen()
        {
            return _len;
        }

        public byte GetHead()
        {
            return _head;
        }

        public byte GetCmdCode()
        {
            return _cmdCode;
        }


      
    }

    


    class MsgDevEvent : MsgHeader
    {


        private string _devNoH = "";
        private int _dayOfWeek;
        private int _hour;
        private int _minute;
        private int _second;

        private int _areaNo;
        private int _memoryAddr;

        private string _silkNoH = "";    //only for Msg_Type_Switch_Failed
        private string _brokenSilkBitH = ""; //only for Msg_Type_Broken_Event
        
        private string _eventTime; //2013-06-11 12:12:12

        
        public MsgDevEvent(int len,byte cmdCode,byte[] buf):base(len,cmdCode)
        {
            _devNoH = Convert.ToString(buf[3], 16).PadLeft(2, '0');
            _dayOfWeek = Convert.ToInt32(buf[4] & 0x01);
            _areaNo = Convert.ToInt32(buf[4] >> 4);
            _hour = Convert.ToInt32(buf[5]);
            _minute = Convert.ToInt32(buf[6]);
            _second = Convert.ToInt32(buf[7]);
            _eventTime = Utils.GetDateByWeekDay(_dayOfWeek) + " "
                        + _hour.ToString().PadLeft(2, '0') + ":"
                        + _minute.ToString().PadLeft(2, '0') + ":"
                        + _second.ToString().PadLeft(2, '0');

            if (MsgType.Msg_Type_Broken_Event == base.GetCmdCode())
            {
                _brokenSilkBitH = Convert.ToString(buf[8], 16).PadLeft(2, '0') + Convert.ToString(buf[9], 16).PadLeft(2, '0');
                _memoryAddr = Convert.ToInt32(buf[10] << 8) + Convert.ToInt32(buf[11]);
            }
            else if (MsgType.Msg_Type_Switch_Failed == base.GetCmdCode())
            {
                _silkNoH = Convert.ToString(buf[8],16).PadLeft(2,'0');
                _memoryAddr = Convert.ToInt32(buf[9] << 8) + Convert.ToInt32(buf[10]);
            }
            else
            {

                _memoryAddr = Convert.ToInt32(buf[8] << 8) + Convert.ToInt32(buf[9]);
            }
                       
        }

        public MsgDevEvent(byte[] buf,int bufLen): base(buf,bufLen)
        {
            _devNoH = Convert.ToString(buf[3], 16).PadLeft(2, '0');
            _dayOfWeek = Convert.ToInt32(buf[4] & 0x01);
            //_areaNo = Convert.ToInt32(buf[4] & 0x10);
            _areaNo = Convert.ToInt32(buf[4] >>4 );
            _hour = Convert.ToInt32(buf[5]);
            _minute = Convert.ToInt32(buf[6]);
            _second = Convert.ToInt32(buf[7]);
            _eventTime = Utils.GetDateByWeekDay(_dayOfWeek) + " "
                       + _hour.ToString().PadLeft(2, '0') + ":"
                       + _minute.ToString().PadLeft(2, '0') + ":"
                       + _second.ToString().PadLeft(2, '0');



            if (MsgType.Msg_Type_Broken_Event == base.GetCmdCode())
            {
                _brokenSilkBitH = Convert.ToString(buf[8], 16).PadLeft(2, '0') + Convert.ToString(buf[9], 16).PadLeft(2, '0');
                _memoryAddr = Convert.ToInt32(buf[10] << 8) + Convert.ToInt32(buf[11]);
            }
            else if (MsgType.Msg_Type_Switch_Failed == base.GetCmdCode())
            {
                _silkNoH = Convert.ToString(buf[8],16);
                _memoryAddr = Convert.ToInt32(buf[9] << 8) + Convert.ToInt32(buf[10]);

            }
            else
            {

                _memoryAddr = Convert.ToInt32(buf[8] << 8) + Convert.ToInt32(buf[9]);
            }
   

        }
        public string GetDevNoHStr()
        {
            return _devNoH;
        }
 
        public string GetEventTime()
        {
            return _eventTime;
        }
    
        public string GetBatchNo()
        {
            //return DataCatcher.Instance().GetBatchNo(_devNoH);
            return DataService.Instance().GetBatchNoByDevNo(Convert.ToInt32(_devNoH,16));
        }

        public string GetGroupName()
        {
            //return DataCatcher.Instance().GetGroupName(_devNoH);
            return DataService.Instance().GetGroupNameByDevNo(Convert.ToInt32(_devNoH,16));
        }

        public string GetSilkNoH()
        {
            return _silkNoH;
        }

        public string GetBrokenSilkBitStr()
        {
            //_brokenSilkBitH
            if (_brokenSilkBitH == "")
            {
                return "0000000000000000";
            }
            else
            {

                return Utils.HexToBin(_brokenSilkBitH.Substring(0, 2)) + Utils.HexToBin(_brokenSilkBitH.Substring(2, 2));
            }
        }

        public new string GetHexStr()
        {
            string hexStr = base.GetHexStr() + _devNoH + Convert.ToString(_areaNo, 16) + Convert.ToString(_dayOfWeek, 16)
                    + Convert.ToString(_hour, 16).PadLeft(2, '0') + Convert.ToString(_minute, 16).PadLeft(2, '0')
                    + Convert.ToString(_second, 16).PadLeft(2, '0');

            if (MsgType.Msg_Type_Broken_Event == base.GetCmdCode())
            {
                hexStr += _silkNoH.PadLeft(2,'0');
            }
            else if (MsgType.Msg_Type_Switch_Failed == base.GetCmdCode())
            {
                hexStr += _brokenSilkBitH.PadLeft(4, '0') ;
            }
            else
            {
                hexStr += Convert.ToString(_memoryAddr, 16).PadLeft(4, '0'); 
            }

            return hexStr;
            
        }

        public new byte[] GetBytes()
        {
            byte[] buf = new byte[base.GetLen() + 2];

            for (int i = 0; i < 3; i++)
                buf[i] = base.GetBytes()[i];

            buf[3] = Convert.ToByte(_devNoH, 16);
            buf[4] = Convert.ToByte(Convert.ToString(_areaNo, 16) + Convert.ToString(_dayOfWeek, 16), 16);
            buf[5] = Convert.ToByte(_hour);
            buf[6] = Convert.ToByte(_minute);
            buf[7] = Convert.ToByte(_second);
            buf[8] = Convert.ToByte(_memoryAddr>> 8);
            buf[9] = Convert.ToByte(_memoryAddr & 0x00ff);

            return buf;
        }
    }


    class MsgSmallPkg : MsgHeader
    {

        public MsgSmallPkg(ref byte[] buf,int bufLen):base(buf,bufLen)
        { 
            
        }


    }





   

}

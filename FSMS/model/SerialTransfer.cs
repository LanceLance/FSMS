using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using FSMS.common;
using System.Threading;


namespace FSMS.model
{

    class SerialTransfer
    {
        //private ManualResetEvent _transferEvent = new ManualResetEvent(true);

        private SerialPort _serialPort = new SerialPort();
        private static object _lockPort = new object();


        private static SerialTransfer _instance = null; 
        private static object _lock = new object();


        public static SerialTransfer Instance()       
        {               
            if(_instance == null)               
            {                      
                lock(_lock)                      
                {                             
                    if(_instance == null)                             
                    {
                        _instance = new SerialTransfer();                             
                    }                      
                }               
            }               
            return _instance;       
        }

        private SerialTransfer()
        {
            
        }

        public void Open(string portName,int rate,int readTimeout,int writeTimeout)
        {
            _serialPort.PortName = portName;
            _serialPort.BaudRate = rate;
            _serialPort.ReadTimeout = readTimeout;
            _serialPort.WriteTimeout = writeTimeout;

            //_serialPort.RtsEnable = false;
            //_serialPort.StopBits = StopBits.One;
            //_serialPort.DataBits = 8;
            //_serialPort.Parity = Parity.None;
            
            Open();
            
            
        }

        public void Open()
        {
            
            try
            {
                if (!_serialPort.IsOpen)
                    _serialPort.Open();
            }
            catch (Exception e)
            {
                Logger.Instance().LogError("SerialTransfer::Open: Open COM error,error msg:"+e.Message);
            }
            
        }

        public bool IsOpen()
        {
            return _serialPort.IsOpen;
        }
        

        public int Read(ref MsgStruct msgSt)
        {
            
            if (!_serialPort.IsOpen)
                return -1;
            try
            {


                byte first = Convert.ToByte(_serialPort.ReadByte());
                while (first != 0xEA)
                {
                    
                    Logger.Instance().LogDebug("SerialTransfer::Read: Msg Head is not EA("+Convert.ToString(first,16).PadLeft(2,'0').ToUpper()
                        +"),Continue to read one byte");

                    first = Convert.ToByte(_serialPort.ReadByte());
                }

                //Thread.Sleep(100);

                int dataNum = _serialPort.ReadByte();
                if (dataNum < 0 || dataNum > GlobalDefiniation.Max_Msg_Len)
                {
                    Logger.Instance().LogError("SerialTransfer::Read: Msg Len is not validate");
                    return -1;
                }

                byte[] buf = new byte[dataNum + 2];

                int i = 0;
                while (i < dataNum)
                {
                    _serialPort.Read(buf, 2 + i, 1);
                    i++;
                }

                //int ret = _serialPort.Read(buf, 2, dataNum);
                //if (ret != dataNum)
                //{
                //    Logger.Instance().LogError("SerialTransfer::Read: 读到的消息长度与期望值不符合,dataNum = " + dataNum + ";ret =" + ret);
                //    return -1;
                //}

                buf[0] = first;
                buf[1] = Convert.ToByte(dataNum);

                msgSt.Init(buf, dataNum + 2);

                try
                {
                    Logger.Instance().LogDebug("SerialTransfer::Read: " + Utils.BytesToHexStr(buf));
                }
                catch (Exception e)
                {
                    Logger.Instance().LogError("SerialTransfer::Read: Write msg byte log error:"+e.Message);
                }

                return dataNum + 2;
            }
            catch (Exception e)
            {

                Logger.Instance().LogError("SerialTransfer::Read: Read msg failed,error msg:" + e.Message);
                return -1;
            }
        }

        
        

        public int Write(byte[] buf)
        {


            if (!_serialPort.IsOpen)
                return -1;

         

            try
            {
                _serialPort.DiscardInBuffer();
                _serialPort.DiscardOutBuffer();
                
                _serialPort.Write(buf, 0, buf.Length);

                try
                {
                    Logger.Instance().LogDebug("SerialTransfer::Write: " + Utils.BytesToHexStr(buf));
                }
                catch (Exception e)
                {
                    Logger.Instance().LogError("SerialTransfer::Write: Write msg byte log error:" + e.Message);
                }

                return buf.Length;
            }
            catch (Exception e)
            {
                Logger.Instance().LogError("SerialTransfer::Write: Write msg failed,error msg:" + e.Message);
               return -1;;
            }
            

                   
        }

        public int SendAndRecv(MsgStruct inMsg, ref MsgStruct outMsg)
        {
            lock (_lockPort)
            {
                int result = -1;
                bool success = false;

                //_transferEvent.WaitOne();


                for (int i = 0; i < GlobalDefiniation.Redo_Times; i++)
                {

                    if (-1 == Write(inMsg.GetBuf()))
                    {
                        continue;
                    }

                    if (-1 == Read(ref outMsg))
                    {
                        continue;
                    }
                    else
                    {
                        result = outMsg.GetBufLen();
                        success = true;
                        break;
                    }

                }
                //_transferEvent.Set();

                if (success)
                {
                    return result;
                }

                return -1;
            }
        }

        public void Close()
        {
            try
            {
                if (_serialPort.IsOpen)
                    _serialPort.Close();
            }
            catch (Exception e)
            {
                Logger.Instance().LogError("SerialTransfer::Close: Close COM failed,error msg:" + e.Message);
            }
        }


    }
}

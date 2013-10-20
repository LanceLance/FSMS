using System;
using System.Collections.Generic;
using System.Text;
using FSMS.model;
using FSMS.common;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace FSMS.controler
{
    class FsmsContextControler
    {
        
        

        private static bool _isInit = false;
        public static void Init()
        {
            if (_isInit)
            {
                Logger.Instance().LogDebug("FsmsContextControler::Init: It is already inited.");
                return;
            }
            int logLevel = -1;
            try
            {
                StringBuilder readVal = new StringBuilder();


                int ret = Utils.GetPrivateProfileString("LOG", "LogLevel", "", readVal, 10, GlobalDefiniation.LOG_CONFIG_FILE);
                if (ret != 0)
                {
                    //MessageBox.Show("û�ж�ȡLogLevel��Ϣ,�˳�!");
                    //Environment.Exit(0);
                    logLevel = Convert.ToInt32(readVal.ToString());
                }
                
            }
            catch (Exception)
            { 
            
            }

            //init log
            if (logLevel == -1)
            {
                Logger.Instance().InitLog("FSMS.log", ELogClass.LOG_CLASS_ERROR);
            }
            else
            {
                Logger.Instance().InitLog("FSMS.log",(ELogClass)logLevel);
            }
            Logger.Instance().LogDebug("FsmsContextControler::Init: init...");

            //init data service
            string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\db\\FSMF.mdb";
            DataService ds = DataService.Instance();
            ds.Open(connString);

            //msgQ
            //MsgQueue recvMsgQ = MsgQueue.Instance();
            //recvMsgQ.setMaxSize(1000);
            
            ////respMsgQ
            //MsgRespQueue respMsgQ = MsgRespQueue.Instance();
            //respMsgQ.setMaxSize(1000);

            //MsgSendQueue sendMsgQ = MsgSendQueue.Instance();
            //sendMsgQ.setMaxSize(1000);

            //transfer
            SerialTransfer transfer = SerialTransfer.Instance();
            try
            {
                StringBuilder readVal = new StringBuilder() ;
                string comName = "";
                int transRate = 0;
                int readTimeout = 0;
                int writeTimeout = 0;

                int ret = Utils.GetPrivateProfileString("COM", "ComName", "", readVal, 10, GlobalDefiniation.FSMS_CONFIG_FILE);
                if (ret == 0)
                {
                    MessageBox.Show("û�ж�ȡComName��Ϣ,�˳�!");
                    Environment.Exit(0);
                }
                comName = readVal.ToString();

                ret = Utils.GetPrivateProfileString("COM", "TransRate", "", readVal, 10, GlobalDefiniation.FSMS_CONFIG_FILE);
                if (ret == 0)
                {
                    MessageBox.Show("û�ж�ȡTransRate��Ϣ,�˳�!");
                    Environment.Exit(0);
                }
                transRate = Convert.ToInt32(readVal.ToString());
                ret = Utils.GetPrivateProfileString("COM", "ReadTimeout", "", readVal, 10, GlobalDefiniation.FSMS_CONFIG_FILE);
                if (ret == 0)
                {
                    MessageBox.Show("û�ж�ȡReadTimeout��Ϣ,�˳�!");
                    Environment.Exit(0);
                }
                readTimeout  = Convert.ToInt32(readVal.ToString());
                ret = Utils.GetPrivateProfileString("COM", "WriteTimeout", "", readVal, 10, GlobalDefiniation.FSMS_CONFIG_FILE);
                if (ret == 0)
                {
                    MessageBox.Show("û�ж�ȡWriteTimeout��Ϣ,�˳�!");
                    Environment.Exit(0);
                }
                writeTimeout = Convert.ToInt32(readVal.ToString());

                //for test
                ret = Utils.GetPrivateProfileString("EVENT", "QueryInterval", "", readVal, 10, GlobalDefiniation.FSMS_CONFIG_FILE);
                if (ret == 0)
                {
                    Logger.Instance().LogWarning("FsmsContextControler::Init: Can not get query event interval.");
                }
                else
                {
                    GlobalDefiniation.Query_Event_Interval = Convert.ToInt32(readVal.ToString());
                    Logger.Instance().LogDebug("FsmsContextControler::Init: ѯ��ʱ��ʱ����Ϊ" + GlobalDefiniation.Query_Event_Interval + "����");
                }


                Logger.Instance().LogDebug("FsmsContextControler::Init: �õ�COM���ã�ComName="+comName+";TransRate="+transRate+";ReadTimeout="+readTimeout+";WriteTimeout="+writeTimeout);
                transfer.Open(comName, transRate,readTimeout,writeTimeout);

            }
            catch (Exception e)
            {
                Logger.Instance().LogError("FsmsContextControler::Init: Open COM failed,error msg:"+e.Message);
            }


            try
            {
                StringBuilder readVal = new StringBuilder();
                

                int ret = Utils.GetPrivateProfileString("SEQ", "AreaNo", "", readVal, 50, GlobalDefiniation.SEQ_CONFIG_FILE);
                if (ret == 0)
                {
                    Logger.Instance().LogWarning("FsmsContextControler::Init: û�д��ļ���ȡAreaNo");
                }
                else
                {
                    GlobalDefiniation.Area_No = Convert.ToInt32(readVal.ToString().Trim());    
                }

                ret = Utils.GetPrivateProfileString("SEQ", "MemAddr", "", readVal, 50, GlobalDefiniation.SEQ_CONFIG_FILE);
                if (ret == 0)
                {
                    Logger.Instance().LogWarning("FsmsContextControler::Init: û�д��ļ���ȡMemAddr");
                }
                else
                {
                    GlobalDefiniation.Mem_Addr = Convert.ToInt32(readVal.ToString().Trim());
                }
            }
            catch (Exception e)
            {
                Logger.Instance().LogError("FsmsContextControler::Init: Open COM failed,error msg:"+e.Message);
            }


            ////receiver 
            //FReciver recv = new FReciver(ref transfer);
            //FThreadPool.Instance().add(recv);

            ////sender
            //FSender send = new FSender(ref sendMsgQ);
            //FThreadPool.Instance().add(send);
            
            ////worker
            //for (int i = 0; i < 1; i++)
            //{
            //    FWorker worker = new FWorker(ref recvMsgQ);

            //    FThreadPool.Instance().add(worker);

            //}

         
            //Send Clock Syncronize
            DistributionControler.SendClockSync();
    
            //Gen Class Calendar
            GenClassCalendar();

            _isInit = true;
            Logger.Instance().LogDebug("FsmsContextControler::Init: inited.");
            
        }

        

        public static bool GetComConnState()
        {
            return SerialTransfer.Instance().IsOpen();
        }

        public static void TryConnCom()
        {
            
            SerialTransfer.Instance().Open();
            
        }

        public static void GenClassCalendar()
        {
            string lastDate = DataService.Instance().GetClassCalendarLastDate();
            if (lastDate == "")
            {
                Logger.Instance().LogError("FsmsContextControler::Init: û�еõ������������,����!");
                ClassMgmControler.GenClassCalendar();

                return;
            }

            if (DateTime.Now.AddDays(7).ToString("yyyy-MM-dd").CompareTo(lastDate) >= 0)
            {
                ClassMgmControler.GenClassCalendar();
            }
        }
    }
}

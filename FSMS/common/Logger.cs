using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FSMS.common
{
    enum ELogClass
    {
        LOG_CLASS_DEBUG = 0,
        LOG_CLASS_INFO = 1,
        LOG_CLASS_WARNING = 2,
        LOG_CLASS_ERROR = 3,
        LOG_CLASS_NONE = 4
    }

    class Logger
    {
        public int _logClass = 3;
        public string[] _logLevelStr = new string[5] { "Debug","Info","Warning","Error","None"};

        private StreamWriter _strWriter = null;


        private static Logger _instance = null; 
        private static object _lock = new object();       
        private Logger()
        { 
            
        }       
        
        public static Logger Instance()       
        {               
            if(_instance == null)               
            {                      
                lock(_lock)                      
                {                             
                    if(_instance == null)                             
                    {                                     
                        _instance = new Logger();                             
                    }                      
                }               
            }               
            return _instance;       
        }

        public void InitLog(string filePath ,ELogClass level)
        {
            _strWriter = new StreamWriter(filePath, true, Encoding.UTF8);
            _strWriter.AutoFlush = true;
            _logClass = (int)level;

            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss,0fff");
            string info = dateTime + " | Log Level is " + _logLevelStr[(int)level] + " | " + "Start...";

            _strWriter.WriteLine(info);   
        }

        public void WriteLog(int logLevel, string content)
        {
            if (logLevel < _logClass)
                return;

            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss,0fff");
            string info = dateTime + " | " + _logLevelStr[logLevel] + " | " + content ;

            _strWriter.WriteLine(info);      
        }

        public void LogError(string content)
        {
            WriteLog((int)ELogClass.LOG_CLASS_ERROR, content);
        }

        public void LogWarning(string content)
        {
            WriteLog((int)ELogClass.LOG_CLASS_WARNING, content);
        }
        public void LogInfo(string content)
        {
            WriteLog((int)ELogClass.LOG_CLASS_INFO, content);
        }

        public void LogDebug(string content)
        {
            WriteLog((int)ELogClass.LOG_CLASS_DEBUG, content);
        }


    }
}

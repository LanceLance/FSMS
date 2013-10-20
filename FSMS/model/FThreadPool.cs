using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FSMS.model
{
    class FThreadPool
    {
        private int _threadNo = 0;

        private static FThreadPool _instance = null; 
        private static object _lock = new object();

        private FThreadPool()
        { 
            
        }       
        
        public static FThreadPool Instance()       
        {               
            if(_instance == null)               
            {                      
                lock(_lock)                      
                {                             
                    if(_instance == null)                             
                    {
                        _instance = new FThreadPool();                             
                    }                      
                }               
            }               
            return _instance;       
        }

        public void add(FThread th)
        {
           
            System.Threading.ThreadPool.QueueUserWorkItem(th.ThreadCallback);
            _threadNo++;
           
        }
        public void add(FThread th,Object treadContext)
        {

            System.Threading.ThreadPool.QueueUserWorkItem(th.ThreadCallback, treadContext);
            _threadNo++;

        }
        public int GetThreadNo()
        {
            return _threadNo;
        }
      

    }
}

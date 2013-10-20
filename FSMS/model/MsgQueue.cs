using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Collections;

namespace FSMS.model
{
    class MsgQueue
    {
        private ManualResetEvent _qEvent = new ManualResetEvent(true);
        private List<MsgStruct> _aList = new List<MsgStruct>();


        private static MsgQueue _instance = null; 
        private static object _lock = new object();
        private MsgQueue()
        {
            
        }       
        
        public void setMaxSize(int n)
        {
            _aList.Capacity = n;
        }

        public static MsgQueue Instance()       
        {               
            if(_instance == null)               
            {                      
                lock(_lock)                      
                {                             
                    if(_instance == null)                             
                    {                                     
                        _instance = new MsgQueue();                             
                    }                      
                }               
            }               
            return _instance;       
        }


        public int Get(ref MsgStruct msgOut)
        {
            _qEvent.WaitOne();

            if (_aList.Count <= 0)
            {
                _qEvent.Set();
                return -1;
            }
            
            msgOut = _aList[0];
            
            _aList.RemoveAt(0);
            _qEvent.Set();
            return 0;

        }

        public int Put(MsgStruct msgIn)
        {
            _qEvent.WaitOne();

            if (_aList.Count >= _aList.Capacity)
            {
                _qEvent.Set();
                return -1;
            }
            _aList.Add(msgIn);

            _qEvent.Set();
            return 0;
    
        }

    }
}

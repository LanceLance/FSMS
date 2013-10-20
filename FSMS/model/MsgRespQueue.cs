using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Collections;

namespace FSMS.model
{
    class MsgRespQueue
    {
        private ManualResetEvent _qEvent = new ManualResetEvent(true);
        private List<MsgStruct> _aList = new List<MsgStruct>() ;


        private static MsgRespQueue _instance = null; 
        private static object _lock = new object();
        private MsgRespQueue()
        {
            
        }       
        
        public void setMaxSize(int n)
        {
            _aList.Capacity = n;
        }

        public static MsgRespQueue Instance()       
        {               
            if(_instance == null)               
            {                      
                lock(_lock)                      
                {                             
                    if(_instance == null)                             
                    {
                        _instance = new MsgRespQueue();                             
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

            for (int i = 0; i < _aList.Count; i++)
            {
                if (!_aList[i].GetSent())
                {
                    msgOut = _aList[i];
                    _aList.RemoveAt(i);
                    _qEvent.Set();
                    return 0;
                }
            }

            return -1;

        }

        public int GetCopy(ref MsgStruct msgOut)
        {
            _qEvent.WaitOne();

            if (_aList.Count <= 0)
            {
                _qEvent.Set();
                return -1;
            }

            for (int i = 0; i < _aList.Count; i++)
            {
                if (!_aList[i].GetSent())
                {
                    msgOut = _aList[i];
                    //_aList.RemoveAt(i);
                    _qEvent.Set();
                    return 0;
                }
            }

            return -1;

        }
        public void Remove(MsgStruct msg)
        {
            _qEvent.WaitOne();
            for (int i = 0; i < _aList.Count; i++)
            {
                //if (msg.GetSeqNo() == _aList[i].GetSeqNo())
                {
                    _aList.RemoveAt(i);
                    break;
                }
            }

            _qEvent.Set();

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

        public void Clear()
        {
            _qEvent.WaitOne();
            
            _aList.Clear();
            _qEvent.Set();
        }

    }
}

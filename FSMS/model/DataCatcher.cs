using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FSMS.model
{
    class DataCatcher
    {
        private DataTable _batchInfo;
        private DataTable _groupInfo;

        private static DataCatcher _instance; 
        private static object _lock = new object();
        private DataCatcher()
        {
        
        }

        public static DataCatcher Instance()       
        {               
            if(_instance == null)               
            {                      
                lock(_lock)                      
                {                             
                    if(_instance == null)                             
                    {
                        _instance = new DataCatcher();                             
                    }                      
                }               
            }               
            return _instance;       
        }


        public int LoadBatch()
        {
            DataTable dt = new DataTable(); 
            DataService.Instance().GetBatchInfo(ref dt);

            _batchInfo = dt;
            return 0;
            
        }

        public int LoadGroup()
        {
            DataTable dt = new DataTable();
            DataService.Instance().GetGroupInfo(ref dt);

            _groupInfo = dt;
            return 0;
        }

        public int Load()
        {
            LoadBatch();
            LoadGroup();
            return 0;
        }

        public int Reload()
        {

            _groupInfo.Clear();
            _batchInfo.Clear();
            LoadGroup();
            LoadBatch();

            return 0;
        }

        public string GetBatchNo(string devNoH)
        {
            string batchNo = "";
            for (int i = 0; i < _batchInfo.Rows.Count; i++)
            {
                if (Convert.ToInt32(_batchInfo.Rows[i]["FirstDevNo"].ToString(), 16) <= Convert.ToUInt32(devNoH, 16) &&
                    Convert.ToUInt32(devNoH, 16) <= Convert.ToInt32(_batchInfo.Rows[i]["LastDevNo"].ToString(), 16))
                {

                    batchNo = _batchInfo.Rows[i]["BatchNo"].ToString();
                    break;
                }
            }

            return batchNo;
        }

        public string GetGroupName(string devNoH)
        {
            string groupName = "";
            for (int i = 0; i < _groupInfo.Rows.Count; i++)
            {
                if (Convert.ToInt32(_groupInfo.Rows[i]["FirstDevNo"].ToString(),16) <= Convert.ToUInt32(devNoH,16) && 
                    Convert.ToUInt32(devNoH,16) <= Convert.ToInt32(_groupInfo.Rows[i]["LastDevNo"].ToString(),16))
                {

                    groupName = _batchInfo.Rows[i]["GroupName"].ToString();
                    break;
                }
            }

            return groupName;
        }
    }
}

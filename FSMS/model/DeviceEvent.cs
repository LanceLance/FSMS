using System;
using System.Collections.Generic;
using System.Text;

namespace FSMS.model
{
    class DeviceEvent
    {
        //设备编号
        private string devNo;

        public string DevNo
        {
            get { return devNo; }
            set { devNo = value; }
        }
        //事件类型
        private string eventType;

        public string EventType
        {
            get { return eventType; }
            set { eventType = value; }
        }
        //丝道号
        private string silkNo;

        public string SilkNo
        {
            get { return silkNo; }
            set { silkNo = value; }
        }

        //批次号
        private string batchNo;

        public string BatchNo
        {
            get { return batchNo; }
            set { batchNo = value; }
        }

        //小组号
        private string groupName;

        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }

        //断丝道位图
        private string brokenSilkBitStr;

        public string BrokenSilkBitStr
        {
            get { return brokenSilkBitStr; }
            set { brokenSilkBitStr = value; }
        }

        //事件时间
        private string eventTime;

        public string EventTime
        {
            get { return eventTime; }
            set { eventTime = value; }
        }

    }
}

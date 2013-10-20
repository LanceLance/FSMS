using System;
using System.Collections.Generic;
using System.Text;

namespace FSMS.model
{
    class BatchDevice
    {
        //批次号
        private string batchNo;

        public string BatchNo
        {
            get { return batchNo; }
            set { batchNo = value; }
        }
        //设备号
        private string devNo;

        public string DevNo
        {
            get { return devNo; }
            set { devNo = value; }
        }

        //当前事件类型
        private string curEventType;

        public string CurEventType
        {
            get { return curEventType; }
            set { curEventType = value; }
        }

        //上次事件类型
        private string abvEventType;

        public string AbvEventType
        {
            get { return abvEventType; }
            set { abvEventType = value; }
        }

        //间隔秒数
        private string diffSecond;

        public string DiffSecond
        {
            get { return diffSecond; }
            set { diffSecond = value; }
        }

        //断丝道位图
        private string brokenSilkBitStr;

        public string BrokenSilkBitStr
        {
            get { return brokenSilkBitStr; }
            set { brokenSilkBitStr = value; }
        }

    }
}

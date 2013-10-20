using System;
using System.Collections.Generic;
using System.Text;

namespace FSMS.model
{
    class Device
    {
        //设备类型
        private string devType;

        public string DevType
        {
            get { return devType; }
            set { devType = value; }
        }

        //设备名称
        private string devName;

        public string DevName
        {
            get { return devName; }
            set { devName = value; }
        }
        
        //设备编号
        private string devNo;

        public string DevNo
        {
            get { return devNo; }
            set { devNo = value; }
        }


        //设备标识
        private string devMac;

        public string DevMac
        {
            get { return devMac; }
            set { devMac = value; }
        }
        //丝道数
        private string silkNum;

        public string SilkNum
        {
            get { return silkNum; }
            set { silkNum = value; }
        }

        //屏蔽丝道位图
        private string blockedSilkBitStr;

        public string BlockedSilkBitStr
        {
            get { return blockedSilkBitStr; }
            set { blockedSilkBitStr = value; }
        }

        //坏丝道位图
        private string brokenSilkBitStr;

        public string BrokenSilkBitStr
        {
            get { return brokenSilkBitStr; }
            set { brokenSilkBitStr = value; }
        }


    }
}

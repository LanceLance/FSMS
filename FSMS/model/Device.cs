using System;
using System.Collections.Generic;
using System.Text;

namespace FSMS.model
{
    class Device
    {
        //�豸����
        private string devType;

        public string DevType
        {
            get { return devType; }
            set { devType = value; }
        }

        //�豸����
        private string devName;

        public string DevName
        {
            get { return devName; }
            set { devName = value; }
        }
        
        //�豸���
        private string devNo;

        public string DevNo
        {
            get { return devNo; }
            set { devNo = value; }
        }


        //�豸��ʶ
        private string devMac;

        public string DevMac
        {
            get { return devMac; }
            set { devMac = value; }
        }
        //˿����
        private string silkNum;

        public string SilkNum
        {
            get { return silkNum; }
            set { silkNum = value; }
        }

        //����˿��λͼ
        private string blockedSilkBitStr;

        public string BlockedSilkBitStr
        {
            get { return blockedSilkBitStr; }
            set { blockedSilkBitStr = value; }
        }

        //��˿��λͼ
        private string brokenSilkBitStr;

        public string BrokenSilkBitStr
        {
            get { return brokenSilkBitStr; }
            set { brokenSilkBitStr = value; }
        }


    }
}

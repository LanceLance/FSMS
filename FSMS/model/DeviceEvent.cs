using System;
using System.Collections.Generic;
using System.Text;

namespace FSMS.model
{
    class DeviceEvent
    {
        //�豸���
        private string devNo;

        public string DevNo
        {
            get { return devNo; }
            set { devNo = value; }
        }
        //�¼�����
        private string eventType;

        public string EventType
        {
            get { return eventType; }
            set { eventType = value; }
        }
        //˿����
        private string silkNo;

        public string SilkNo
        {
            get { return silkNo; }
            set { silkNo = value; }
        }

        //���κ�
        private string batchNo;

        public string BatchNo
        {
            get { return batchNo; }
            set { batchNo = value; }
        }

        //С���
        private string groupName;

        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }

        //��˿��λͼ
        private string brokenSilkBitStr;

        public string BrokenSilkBitStr
        {
            get { return brokenSilkBitStr; }
            set { brokenSilkBitStr = value; }
        }

        //�¼�ʱ��
        private string eventTime;

        public string EventTime
        {
            get { return eventTime; }
            set { eventTime = value; }
        }

    }
}

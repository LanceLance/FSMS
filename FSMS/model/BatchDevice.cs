using System;
using System.Collections.Generic;
using System.Text;

namespace FSMS.model
{
    class BatchDevice
    {
        //���κ�
        private string batchNo;

        public string BatchNo
        {
            get { return batchNo; }
            set { batchNo = value; }
        }
        //�豸��
        private string devNo;

        public string DevNo
        {
            get { return devNo; }
            set { devNo = value; }
        }

        //��ǰ�¼�����
        private string curEventType;

        public string CurEventType
        {
            get { return curEventType; }
            set { curEventType = value; }
        }

        //�ϴ��¼�����
        private string abvEventType;

        public string AbvEventType
        {
            get { return abvEventType; }
            set { abvEventType = value; }
        }

        //�������
        private string diffSecond;

        public string DiffSecond
        {
            get { return diffSecond; }
            set { diffSecond = value; }
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

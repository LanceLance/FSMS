using System;
using System.Collections.Generic;
using System.Text;

namespace FSMS.model
{
    class Batch
    {
        //���κ�
        private string batchNo;

        public string BatchNo
        {
            get { return batchNo; }
            set { batchNo = value; }
        }

        //��̨�豸��
        private string firstDevNo;

        public string FirstDevNo
        {
            get { return firstDevNo; }
            set { firstDevNo = value; }
        }

        //į̃�豸��
        private string lastDevNo;

        public string LastDevNo
        {
            get { return lastDevNo; }
            set { lastDevNo = value; }
        }

        //��������
        private string singlePieWeight;

        public string SinglePieWeight
        {
            get { return singlePieWeight; }
            set { singlePieWeight = value; }
        }

        //����ʱ��
        private string fullPkgTime;

        public string FullPkgTime
        {
            get { return fullPkgTime; }
            set { fullPkgTime = value; }
        }

        //С��ʱ��
        private string smallPkgTime;

        public string SmallPkgTime
        {
            get { return smallPkgTime; }
            set { smallPkgTime = value; }
        }


    }
}

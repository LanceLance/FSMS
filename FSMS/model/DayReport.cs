using System;
using System.Collections.Generic;
using System.Text;

namespace FSMS.model
{
    class DayReport
    {
        //���ƻ���
        private string devNo;

        public string DevNo
        {
            get { return devNo; }
            set { devNo = value; }
        }

        //���ƻ���
        private string devName;

        public string DevName
        {
            get { return devName; }
            set { devName = value; }
        }
        //��������
        private string batchNo;

        public string BatchNo
        {
            get { return batchNo; }
            set { batchNo = value; }
        }
        //�������
        private string mjCount;

        public string MjCount
        {
            get { return mjCount; }
            set { mjCount = value; }
        }
        //�л�ʧ�ܴ���
        private string qhFailCount;

        public string QhFailCount
        {
            get { return qhFailCount; }
            set { qhFailCount = value; }
        }
        //��˿����
        private string dsCount;

        public string DsCount
        {
            get { return dsCount; }
            set { dsCount = value; }
        }
        //�ó���
        private string bengProduct;

        public string BengProduct
        {
            get { return bengProduct; }
            set { bengProduct = value; }
        }
        //ʵ�ʲ���
        private string actProduct;

        public string ActProduct
        {
            get { return actProduct; }
            set { actProduct = value; }
        }
        //��˿��
        private string failProduct;

        public string FailProduct
        {
            get { return failProduct; }
            set { failProduct = value; }
        }
        //�������
        private string mjProduct;

        public string MjProduct
        {
            get { return mjProduct; }
            set { mjProduct = value; }
        }
        //����Ч��
        private string efficient;

        public string Efficient
        {
            get { return efficient; }
            set { efficient = value; }
        }
    }
}

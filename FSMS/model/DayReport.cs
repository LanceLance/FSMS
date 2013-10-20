using System;
using System.Collections.Generic;
using System.Text;

namespace FSMS.model
{
    class DayReport
    {
        //卷绕机号
        private string devNo;

        public string DevNo
        {
            get { return devNo; }
            set { devNo = value; }
        }

        //卷绕机名
        private string devName;

        public string DevName
        {
            get { return devName; }
            set { devName = value; }
        }
        //生产批号
        private string batchNo;

        public string BatchNo
        {
            get { return batchNo; }
            set { batchNo = value; }
        }
        //满卷次数
        private string mjCount;

        public string MjCount
        {
            get { return mjCount; }
            set { mjCount = value; }
        }
        //切换失败次数
        private string qhFailCount;

        public string QhFailCount
        {
            get { return qhFailCount; }
            set { qhFailCount = value; }
        }
        //断丝次数
        private string dsCount;

        public string DsCount
        {
            get { return dsCount; }
            set { dsCount = value; }
        }
        //泵出量
        private string bengProduct;

        public string BengProduct
        {
            get { return bengProduct; }
            set { bengProduct = value; }
        }
        //实际产量
        private string actProduct;

        public string ActProduct
        {
            get { return actProduct; }
            set { actProduct = value; }
        }
        //废丝量
        private string failProduct;

        public string FailProduct
        {
            get { return failProduct; }
            set { failProduct = value; }
        }
        //满卷产量
        private string mjProduct;

        public string MjProduct
        {
            get { return mjProduct; }
            set { mjProduct = value; }
        }
        //运行效率
        private string efficient;

        public string Efficient
        {
            get { return efficient; }
            set { efficient = value; }
        }
    }
}

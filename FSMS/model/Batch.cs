using System;
using System.Collections.Generic;
using System.Text;

namespace FSMS.model
{
    class Batch
    {
        //批次号
        private string batchNo;

        public string BatchNo
        {
            get { return batchNo; }
            set { batchNo = value; }
        }

        //首台设备号
        private string firstDevNo;

        public string FirstDevNo
        {
            get { return firstDevNo; }
            set { firstDevNo = value; }
        }

        //末台设备号
        private string lastDevNo;

        public string LastDevNo
        {
            get { return lastDevNo; }
            set { lastDevNo = value; }
        }

        //单饼重量
        private string singlePieWeight;

        public string SinglePieWeight
        {
            get { return singlePieWeight; }
            set { singlePieWeight = value; }
        }

        //满卷时间
        private string fullPkgTime;

        public string FullPkgTime
        {
            get { return fullPkgTime; }
            set { fullPkgTime = value; }
        }

        //小卷时间
        private string smallPkgTime;

        public string SmallPkgTime
        {
            get { return smallPkgTime; }
            set { smallPkgTime = value; }
        }


    }
}

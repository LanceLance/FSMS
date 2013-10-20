using System;
using System.Collections.Generic;
using System.Text;

namespace FSMS.model
{
    class Group
    {
        //批次号
        private string groupName;

        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
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

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FSMS.model
{
    class Group
    {
        //���κ�
        private string groupName;

        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
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

    }
}

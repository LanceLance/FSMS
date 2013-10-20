using System;
using System.Collections.Generic;
using System.Text;

namespace FSMS.model
{
    class ClassCalendar
    {
        //班开始时间
        private string startTime;

        public string StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        //班结束时间
        private string endTime;

        public string EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }

        //班名称
        private string className;

        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }
    }
}

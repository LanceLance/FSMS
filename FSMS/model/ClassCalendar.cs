using System;
using System.Collections.Generic;
using System.Text;

namespace FSMS.model
{
    class ClassCalendar
    {
        //�࿪ʼʱ��
        private string startTime;

        public string StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        //�����ʱ��
        private string endTime;

        public string EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }

        //������
        private string className;

        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }
    }
}

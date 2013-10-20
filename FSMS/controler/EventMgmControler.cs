using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using FSMS.model;
using FSMS.common;

namespace FSMS.controler
{
    class EventMgmControler
    {

        public static void BindEvent(ref DataGridView dgv)
        {
            DataTable dt = new DataTable();

            DataService.Instance().GetDeviceEvent(ref dt);

            BindDgv(ref dgv, ref dt);
            
           
        }
        public static void BindEvent(ref DataGridView dgv, string eventType)
        {
            DataTable dt = new DataTable();

            DataService.Instance().GetDeviceEvent(ref dt, eventType);

            BindDgv(ref dgv, ref dt);


        }

        public static void BindEvent(ref DataGridView dgv, string startTime, string endTime)
        {
            DataTable dt = new DataTable();

            DataService.Instance().GetDeviceEvent(ref dt, startTime, endTime);

            BindDgv(ref dgv, ref dt);


        }
        public static void BindEvent(ref DataGridView dgv, string eventType, string startTime, string endTime)
        {
            DataTable dt = new DataTable();

            DataService.Instance().GetDeviceEvent(ref dt,eventType, startTime, endTime);

            BindDgv(ref dgv, ref dt);


        }
        public static void BindEvent1(ref DataGridView dgv,int devNo,string eventType)
        {
            DataTable dt = new DataTable();

            DataService.Instance().GetDeviceEvent1(ref dt,devNo,eventType);

            BindDgv(ref dgv, ref dt);


        }
        public static void BindEvent1(ref DataGridView dgv,int devNo)
        {
            DataTable dt = new DataTable();

            DataService.Instance().GetDeviceEvent1(ref dt,devNo);

            BindDgv(ref dgv, ref dt);
            
           
        }
       
        public static void BindEvent1(ref DataGridView dgv, int devNo,string startTime, string endTime)
        {
            DataTable dt = new DataTable();

            DataService.Instance().GetDeviceEvent1(ref dt, devNo,startTime, endTime);

            BindDgv(ref dgv, ref dt);


        }
        public static void BindEvent1(ref DataGridView dgv, int devNo, string eventType, string startTime, string endTime)
        {
            DataTable dt = new DataTable();

            DataService.Instance().GetDeviceEvent1(ref dt, devNo, eventType, startTime, endTime);

            BindDgv(ref dgv, ref dt);


        }

        public static void BindDgv(ref DataGridView dgv,ref DataTable dt)
        {
            dgv.Rows.Clear();
            if (dt.Rows.Count < 1)
                return;
            dgv.Rows.Add(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv.Rows[i].Cells["DevNo"].Value = dt.Rows[i]["DevNo"].ToString();
                try
                {
                    dgv.Rows[i].Cells["EventType"].Value = GlobalDefiniation.DEV_EVENT_STR[Convert.ToInt32(dt.Rows[i]["EventType"].ToString().Substring(1, 1) == "A" ?
                        "0" : dt.Rows[i]["EventType"].ToString().Substring(1, 1))];
                }
                catch (Exception)
                {
                    dgv.Rows[i].Cells["EventType"].Value = dt.Rows[i]["EventType"].ToString();
                }
                dgv.Rows[i].Cells["SilkNo"].Value = dt.Rows[i]["SilkNo"].ToString();

                //string eventTime = year + "-" + month + "-" + day + " " + hour + ":" + min + ":" + sec;
                dgv.Rows[i].Cells["EventTime"].Value = dt.Rows[i]["EventTime"].ToString();




            }
        }

        public static void InitDevNameList(ref ComboBox cb)
        {
            DataTable dt = new DataTable();

            DataService.Instance().GetDeviceEventGroupByName(ref dt);
            cb.Items.Clear();
            cb.Items.Add("È«²¿");
            cb.SelectedIndex = 0;
            if (dt.Rows.Count < 1)
                return;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb.Items.Add(dt.Rows[i][0]);
            }
        }


        
    }
}

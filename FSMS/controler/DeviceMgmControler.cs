using System;
using System.Collections.Generic;
using System.Text;
using FSMS.model;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using FSMS.common;
using System.ComponentModel;


namespace FSMS.controler
{
    class DeviceMgmControler
    {

        public static void ClearDevice()
        {
            DataService.Instance().DelDevice();
        }
        public static string GetDeviceNoByName(string devName)
        {
            return DataService.Instance().GetDeviceNoByName(devName);
        }

        public static int ValidateNullDgv(ref DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    if (!dgv.Rows[i].Cells[j].ReadOnly)
                    {
                        if (dgv.Rows[i].Cells[j].Value == null || dgv.Rows[i].Cells[j].Value.ToString().Trim() == "")
                        {
                            MessageBox.Show("行" + Convert.ToString(i + 1) + ",列" + Convert.ToString(j) + "单元格值不能为空,请检查!");
                            return -1;
                        }
                    }
                }
            }
            return 0;
        }

        public static void AddDeviceByDgv(ref DataGridView dgv)
        {
            int errCount = 0;
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {

       
                string devName = dgv.Rows[i].Cells["DevName"].Value.ToString().Trim();
                string devType = dgv.Rows[i].Cells["DevType"].Value.ToString().Trim().ToUpper();
                string devID = dgv.Rows[i].Cells["DevID"].Value.ToString().Trim();
                string blockedBit = "";
                string devMac = "0000";
                if (dgv.Rows[i].Cells["BlockedSilkBitStr"].Value != null && dgv.Rows[i].Cells["BlockedSilkBitStr"].Value.ToString().Trim() != "")
                {
                    blockedBit = dgv.Rows[i].Cells["BlockedSilkBitStr"].Value.ToString().Trim();
                }
                if(dgv.Rows[i].Cells["DevMac"].Value != null && dgv.Rows[i].Cells["DevMac"].Value.ToString().Trim() != "")
                {
                    devMac = dgv.Rows[i].Cells["DevMac"].Value.ToString().Trim(); 
                }
                int silkNum = 0;
                try
                {
                    silkNum = Convert.ToInt32(dgv.Rows[i].Cells["SilkNum"].Value.ToString().Trim());
                }
                catch (Exception)
                { }

                if (silkNum > 0 && blockedBit == "")
                {
                    for (int j = 0; j < 16; j++)
                    {
                        blockedBit += "0";
                    }
                }


                if (DataService.Instance().AddDevice(devType,devName,Convert.ToInt32(devID),devMac,silkNum,blockedBit) < 1)
                {
                    errCount++;
                }

            }
            if (errCount > 0)
            {
                MessageBox.Show("错误,有" + errCount + "条目更新错误!请检查!");
            }
            else
            {
                MessageBox.Show("更新成功!");
            }
        }

        static public void BindDevice(ref DataGridView dgv)
        {

            DataTable dt = new DataTable();
            DataService.Instance().GetDevice(ref dt);

            dgv.Rows.Clear();
            if (dt.Rows.Count < 1)
                return;
            dgv.Rows.Add(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv.Rows[i].Cells["DevName"].Value = dt.Rows[i]["DevName"].ToString();
                dgv.Rows[i].Cells["DevType"].Value = dt.Rows[i]["DevType"].ToString();
                dgv.Rows[i].Cells["DevID"].Value = dt.Rows[i]["DevNo"].ToString();
                dgv.Rows[i].Cells["DevMac"].Value = dt.Rows[i]["DevMac"].ToString();
               
                dgv.Rows[i].Cells["SilkNum"].Value = dt.Rows[i]["SilkNum"].ToString().Trim() == "" ? "0" : dt.Rows[i]["SilkNum"].ToString().Trim();
                if (dt.Rows[i]["IsSent"].ToString().Trim() == "")
                {
                    dgv.Rows[i].Cells["IsSent"].Value = GlobalDefiniation.Sent_Result_Str[0];
                }
                else
                {
                    dgv.Rows[i].Cells["IsSent"].Value = GlobalDefiniation.Sent_Result_Str[Convert.ToInt32(dt.Rows[i]["IsSent"].ToString())];
                }
                
                if (Convert.ToInt32(dgv.Rows[i].Cells["SilkNum"].Value.ToString()) > 0)
                { 
                    string blockBit = "";
                    for(int j = 0;j<Convert.ToInt32(dgv.Rows[i].Cells["SilkNum"].Value.ToString());j++)
                    {
                        blockBit +="0";
                    }
                    dgv.Rows[i].Cells["BlockedSilkBitStr"].Value = dt.Rows[i]["BlockedSilkBitStr"].ToString().Trim() == "" ? blockBit : dt.Rows[i]["BlockedSilkBitStr"].ToString().Trim();
                }
                else
                {
                    dgv.Rows[i].Cells["BlockedSilkBitStr"].Value = "";
                }

                dgv.Rows[i].Cells["UpdateTime"].Value = dt.Rows[i]["UpdateTime"].ToString();
                dgv.Rows[i].Cells["IDD"].Value = dt.Rows[i]["ID"].ToString();
                
            }
            
            
            dgv.Sort(dgv.Columns["DevID"],ListSortDirection.Ascending);
            dgv.Sort(dgv.Columns["DevType"], ListSortDirection.Ascending);
           
       
        }




        private static object devStatusLock = new object();
        public static  void ShowDevStatus(ref PictureBox pb)
        {
            lock (devStatusLock)
            {
                DataTable dt = new DataTable();
                DataService.Instance().GetDevice(ref dt);

                foreach (Label lbl in pb.Controls)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if ("lblDev" + dt.Rows[i]["DevNo"].ToString().Trim() == lbl.Name)
                        {
                            string state = dt.Rows[i]["DevState"].ToString().Trim();
                            for (int j = 0; j < GlobalDefiniation.DEV_STATE_CMD.Length; j++)
                            {
                                if (state == GlobalDefiniation.DEV_STATE_CMD[j])
                                {
                                    try
                                    {
                                        lbl.Text = dt.Rows[i]["DevType"] + "_" + dt.Rows[i]["DevName"] + "\n" + GlobalDefiniation.DEV_STATE_STR[j];
                                        lbl.BackColor = GlobalDefiniation.DEV_STATE_COLOR[j];
                                        //:TODO check Device table's Broken Column if (broken ^ blocked >0) then broken is occured.
                                        if (state == Convert.ToString(MsgType.Msg_Type_Broken_Event, 16).ToUpper() &&
                                            0 < (Convert.ToInt32(dt.Rows[i]["BlockedSilkBitStr"].ToString()) ^ Convert.ToInt32(dt.Rows[i]["BrokenSilkBitStr"].ToString())))
                                        {
                                            //broken
                                            lbl.Text = dt.Rows[i]["DevType"] + "_" + dt.Rows[i]["DevName"] + "\n" + GlobalDefiniation.DEV_BROKEN_SILK_STR;
                                            lbl.BackColor = GlobalDefiniation.DEV_BROKEN_SILK_COLOR;
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        Logger.Instance().LogError("DeviceMgmControler::ShowDevStatus: 错误：" + e.Message);
                                    }

                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
            }
        }


        public static void LoadAllDevicePics(ref PictureBox pb)
        {

            lock (devStatusLock)
            {
                DataTable dt = new DataTable();
                DataService.Instance().GetDeviceByType(ref dt, "JRT");
                pb.Controls.Clear();
                if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("暂无设备信息,请检查!");
                    return;
                }

                //Sort Dev


                int allDevNum = dt.Rows.Count;

                //configuratle
                //int allDevNum = 10;

                int hDevNum = 10;
                int vDevNum = allDevNum / hDevNum;
                if (allDevNum % hDevNum != 0)
                    vDevNum++;

                int startX = pb.Location.X;
                int startY = pb.Location.Y;

                int devHGap = ((Screen.GetBounds(pb).Width - startX) / hDevNum) / 2;
                int devWidth = (Screen.GetBounds(pb).Width - startX) / hDevNum / 2;


                int devVGap = (Screen.GetBounds(pb).Height - startY) / vDevNum / 2;
                int devHeight = (Screen.GetBounds(pb).Height - startY) / vDevNum / 2;


                Label[] lbls = new Label[allDevNum];
                for (int i = 0; i < allDevNum; i++)
                {

                    string state = "停机";
                    lbls[i] = new Label();
                    lbls[i].Text = dt.Rows[i]["DevType"] + "_" + dt.Rows[i]["DevName"] + "\n" + state;
                    lbls[i].Name = "lblDev" + dt.Rows[i]["DevNo"].ToString();
                    lbls[i].AutoSize = false;
                    lbls[i].Width = devWidth;
                    lbls[i].Height = devHeight;
                    lbls[i].BorderStyle = BorderStyle.Fixed3D;
                    lbls[i].BackColor = Color.DarkGray;
                    lbls[i].ForeColor = Color.White;
                    lbls[i].Font = new System.Drawing.Font("宋体", 9F, FontStyle.Bold);
                    lbls[i].TextAlign = ContentAlignment.MiddleCenter;

                    lbls[i].Location = new System.Drawing.Point(((i) % hDevNum) * (devWidth + devHGap) + devHGap / 2, (i / hDevNum) * (devHeight + devVGap) + devVGap / 2);


                    pb.Controls.Add(lbls[i]);
                }

            }
        }

        static public void InitSilkNo(ref CheckedListBox box)
        {
            box.Items.Clear();
            for (int i = 1; i < 17; i++)
            {
                box.Items.Add("丝道_" + i);
            }
        }

        public static void InitCbDevNo(DataGridView dgv,ref ComboBox cbStart,ref ComboBox cbEnd)
        {
            cbStart.Items.Clear();
            cbEnd.Items.Clear();
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                if (dgv.Rows[i].Cells["DevID"].Value == null || dgv.Rows[i].Cells["DevID"].Value.ToString().Trim() == ""　||
                    dgv.Rows[i].Cells["DevType"].Value.ToString().Trim() != "JRT")
                {
                    continue;
                }

                cbStart.Items.Add(dgv.Rows[i].Cells["DevID"].Value.ToString().Trim());
                cbEnd.Items.Add(dgv.Rows[i].Cells["DevID"].Value.ToString().Trim());

                if (cbStart.Items.Count > 0)
                    cbStart.SelectedIndex = 0;
                if (cbEnd.Items.Count > 0)
                    cbEnd.SelectedIndex = 0;
                
            }
        }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FSMS.controler;
using FSMS.common;

namespace FSMS.view
{
    public partial class frmDevice : Form
    {
        private frmMain _frmMain;
        public frmDevice(frmMain main)
        {
            InitializeComponent();
            _frmMain = main;

            DeviceMgmControler.BindDevice(ref dgvDevice);
            DeviceMgmControler.InitSilkNo(ref checkedlbSilkNo);
            DeviceMgmControler.InitCbDevNo(dgvDevice, ref cbStartDevNo, ref cbEndDevNo);
        }


        private void btnUpdateDev_Click(object sender, EventArgs e)
        {
            if (-1 == DeviceMgmControler.ValidateNullDgv(ref dgvDevice))
            {
                return;
            }

            DeviceMgmControler.ClearDevice();
            DeviceMgmControler.AddDeviceByDgv(ref dgvDevice);
            DeviceMgmControler.BindDevice(ref dgvDevice);

            //reload device 
            DeviceMgmControler.LoadAllDevicePics(ref _frmMain.picDevice);
          
            DeviceMgmControler.InitSilkNo(ref checkedlbSilkNo);
            DeviceMgmControler.InitCbDevNo(dgvDevice, ref cbStartDevNo, ref cbEndDevNo);
        }

        private void btnClearDev_Click(object sender, EventArgs e)
        {
            DeviceMgmControler.ClearDevice();
            DeviceMgmControler.BindDevice(ref dgvDevice);
            DeviceMgmControler.InitSilkNo(ref checkedlbSilkNo);
            DeviceMgmControler.InitCbDevNo(dgvDevice, ref cbStartDevNo, ref cbEndDevNo);
        }

    


        private void frmDevice_Load(object sender, EventArgs e)
        {
            dgvDevice.ClearSelection();
       
        }

        private void btnDistID_Click(object sender, EventArgs e)
        {
            int prograssMax = 0;



            bool allSuc = true;
            int count = 0;

            int maxJLB = 0;
            int maxBP = 0;
            int maxJRT = 0;

            for (int i = 0; i < dgvDevice.Rows.Count - 1; i++)
            {
                if (dgvDevice.Rows[i].Cells["DevName"].Value == null ||
                    dgvDevice.Rows[i].Cells["DevType"].Value == null ||
                    dgvDevice.Rows[i].Cells["DevID"].Value == null ||
                    dgvDevice.Rows[i].Cells["DevMac"].Value == null ||
                    dgvDevice.Rows[i].Cells["DevName"].Value.ToString().Trim() == "" ||
                    dgvDevice.Rows[i].Cells["DevType"].Value.ToString().Trim() == "" ||
                    dgvDevice.Rows[i].Cells["DevID"].Value.ToString().Trim() == "" ||
                    dgvDevice.Rows[i].Cells["DevMac"].Value.ToString().Trim() == ""
                    )
                {
                    continue;
                }

                prograssMax += 1;
            
            }

            progBarDist.Value = 0;
            progBarDist.Maximum = prograssMax + 2;
            progBarDist.Step = 1;

            btnDistID.Enabled = false;


            for(int i = 0;i < dgvDevice.Rows.Count-1 ;i++)
            {
                if (dgvDevice.Rows[i].Cells["DevName"].Value == null ||
                    dgvDevice.Rows[i].Cells["DevType"].Value == null ||
                    dgvDevice.Rows[i].Cells["DevID"].Value == null ||
                    dgvDevice.Rows[i].Cells["DevMac"].Value == null ||
                    dgvDevice.Rows[i].Cells["DevName"].Value.ToString().Trim()== "" ||
                    dgvDevice.Rows[i].Cells["DevType"].Value.ToString().Trim()== "" ||
                    dgvDevice.Rows[i].Cells["DevID"].Value.ToString().Trim()== "" ||
                    dgvDevice.Rows[i].Cells["DevMac"].Value.ToString().Trim() == ""
                    )
                {
                    continue;
                }

                
                int devID = Convert.ToInt32(dgvDevice.Rows[i].Cells["DevID"].Value.ToString().Trim());
                if (dgvDevice.Rows[i].Cells["DevType"].Value.ToString().Trim().ToUpper() == "JRT")
                {
                    if (maxJRT < devID)
                    {
                        maxJRT = devID;
                    }
                }
                else if (dgvDevice.Rows[i].Cells["DevType"].Value.ToString().Trim().ToUpper() == "JLB")
                {
                    devID += 0x80;
                    if (maxJLB < devID)
                    {
                        maxJLB = devID;
                    }
                    
                }
                else if (dgvDevice.Rows[i].Cells["DevType"].Value.ToString().Trim().ToUpper() == "BP")
                {
                    devID += 0x83;
                    if (maxBP < devID)
                    {
                        maxBP = devID;
                    }
                }
                else
                {
                    continue;
                }
                

                string devMacH = dgvDevice.Rows[i].Cells["DevMac"].Value.ToString().Trim().PadLeft(4,'0');

                if (-1 == DistributionControler.SetDevID(devID, devMacH))
                {
                    allSuc = false;
                   
                }
                else
                {
                    count++;
     
                }
                //prograss Bar Value++
                progBarDist.PerformStep();
            }

            if(maxBP != 0)
                DistributionControler.SetDevID(maxBP + 1, "0000");
            if(maxJRT != 0)
                DistributionControler.SetDevID(maxJRT + 1, "0000");
            if (maxJLB != 0)
                DistributionControler.SetDevID(maxJLB + 1, "0000");

            if (allSuc && count > 0)
            {
                MessageBox.Show("ȫ���豸��ַ���ųɹ�!");
                
            }
            else
            {
                MessageBox.Show("����ȫ���豸��ַû�ɹ�,����!");
            }
            DeviceMgmControler.BindDevice(ref dgvDevice);
            
            progBarDist.Value = 0;
            btnDistID.Enabled = true;

        }

        private void btnSilkNo_Click(object sender, EventArgs e)
        {
            string startDevH = cbStartDevNo.Text.Trim();
            string endDevH = cbEndDevNo.Text.Trim();
            if (startDevH == "" || endDevH == "")
            {
                MessageBox.Show("�豸��ʼ��&�����Ų���Ϊ�գ�����!");
                return;
            }



            //string startDevH = DeviceMgmControler.GetDeviceNoByName(startDevName);
            //string endDevH = DeviceMgmControler.GetDeviceNoByName(endDevName);

            if (Convert.ToInt32(endDevH) < Convert.ToInt32(startDevH))
            {
                MessageBox.Show("�豸��ʼ�Ų��ܴ����豸������,������ѡ��!");
                return;
            }
            btnSilkNo.Enabled = false;
            GlobalDefiniation.Enable_Auto_Query_Event = false;
            progBarDist.Maximum = Convert.ToInt32(endDevH) - Convert.ToInt32(startDevH) + 1 ;
            progBarDist.Step = 1;


            bool allSuc = true;
            int count = checkedlbSilkNo.CheckedItems.Count;
            string[] silkNos = new string[count];

            for (int i = 0; i < count; i++)
            {
                silkNos[i] = checkedlbSilkNo.CheckedItems[i].ToString();
            }

           

           
            for (int i = Convert.ToInt32(startDevH); i <= Convert.ToInt32(endDevH); i++)
            {
                if (-1 == DistributionControler.SendBlockSilkNos(i, silkNos))
                {
                    allSuc = false;
                }

                progBarDist.PerformStep();
            
            }

            if (allSuc)
            {
                MessageBox.Show("��������˿�����·��ɹ�!");        
            }
            else
            {
                MessageBox.Show("����ȫ���豸����˿�����·��ɹ�,����!");
            }
            DeviceMgmControler.BindDevice(ref dgvDevice);

            progBarDist.Value = 1;

            btnSilkNo.Enabled = true;
            GlobalDefiniation.Enable_Auto_Query_Event = true;
        }

        private void checkedlbSilkNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvDevice_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            //DataGridView dgv = (DataGridView)sender;

            if (e.Column.Name == "DevID")
            {
                int val1, val2;

                int.TryParse(e.CellValue1.ToString().Trim(), out val1);
                int.TryParse(e.CellValue2.ToString().Trim(), out val2);


                if (val1 < val2) e.SortResult = -1;
                else if (val1 == val2) e.SortResult = 0;
                else e.SortResult = 1;
                e.Handled = true;
            }

        }

        private void frmDevice_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalDefiniation.Enable_Auto_Query_Event = true;
        }
    }
}
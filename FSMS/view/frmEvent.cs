using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FSMS.controler;

namespace FSMS.view
{
    public partial class frmEvent : Form
    {
        public frmEvent()
        {
            InitializeComponent();

            checkbTime.Checked = false;
            checkbType.Checked = false;

            EventMgmControler.BindEvent(ref dgvEvent);
            EventMgmControler.InitDevNameList(ref cbDevName);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string startTime = dtpStartDay.Value.ToString("yyyy-MM-dd") + " " + dtpStartTime.Value.ToString("HH:mm:ss");
            string endTime = dtpEndDay.Value.ToString("yyyy-MM-dd") + " " + dtpEndTime.Value.ToString("HH:mm:ss");
            string eventType = "D3";

            if (rbtnSilk.Checked)
                eventType = "D6";
            else if (rbtnSwFailed.Checked)
                eventType = "D7";
            else
                eventType = "D3";


            if (cbDevName.Text == "È«²¿")
            {

                if (checkbTime.Checked && checkbType.Checked)
                {
                    EventMgmControler.BindEvent(ref dgvEvent, eventType, startTime, endTime);
                }
                else if (checkbTime.Checked)
                {
                    EventMgmControler.BindEvent(ref dgvEvent, startTime, endTime);
                }
                else if (checkbType.Checked)
                {
                    EventMgmControler.BindEvent(ref dgvEvent, eventType);
                }
                else
                {
                    EventMgmControler.BindEvent(ref dgvEvent);
                }
            }
            else
            {
                if (checkbTime.Checked && checkbType.Checked)
                {
                    EventMgmControler.BindEvent1(ref dgvEvent, Convert.ToInt32(cbDevName.Text.Trim()), startTime, endTime, eventType);
                }
                else if (checkbTime.Checked)
                {
                    EventMgmControler.BindEvent1(ref dgvEvent, Convert.ToInt32(cbDevName.Text.Trim()), startTime, endTime);
                }
                else if (checkbType.Checked)
                {
                    EventMgmControler.BindEvent1(ref dgvEvent, Convert.ToInt32(cbDevName.Text.Trim()), eventType);
                }
                else
                {
                    EventMgmControler.BindEvent1(ref dgvEvent, Convert.ToInt32(cbDevName.Text.Trim()));
                }
            }

        }

        private void checkbType_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbType.Checked)
            {
                rbtnSilk.Enabled = true;
                rbtnSmallPkg.Enabled = true;
                rbtnSwFailed.Enabled = true;
            }
            else
            {
                rbtnSilk.Enabled = false;
                rbtnSmallPkg.Enabled = false;
                rbtnSwFailed.Enabled = false;
            }
        }

        private void checkbTime_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbTime.Checked)
            {
                dtpEndDay.Enabled = true;
                dtpEndTime.Enabled = true;
                dtpStartDay.Enabled = true;
                dtpStartTime.Enabled = true;
            }
            else
            {
                dtpEndDay.Enabled = false;
                dtpEndTime.Enabled = false;
                dtpStartDay.Enabled = false;
                dtpStartTime.Enabled = false;
            }
        }

        private void dgvEvent_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Name == "DevNo")
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
    }
}
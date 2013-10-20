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
    public partial class frmSmallPkg : Form
    {
        private frmBatch _batch;
        public frmSmallPkg()
        {
            InitializeComponent();

            BatchMgmControler.BindSmallPkgDist(ref dgvSmallPkgDist);
        }

        public frmSmallPkg(frmBatch batch)
        {
            _batch = batch;
            InitializeComponent();
            BatchMgmControler.BindSmallPkgDist(ref dgvSmallPkgDist);
        }

        private void btnSmallPkg_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (listVDevNo.Items.Count < 1)
            {
                MessageBox.Show("请先选择要下发的行！");
                return;
            }
            btnSend.Enabled = false;
            GlobalDefiniation.Enable_Auto_Query_Event = false;
            int failedCount = 0;
            progBarDist.Maximum = listVDevNo.Items.Count;
            progBarDist.Step = 1;

            for (int i = 0; i < listVDevNo.Items.Count; i++)
            {

                int devNo = Convert.ToInt32(listVDevNo.Items[i].Text.Substring(0, listVDevNo.Items[i].Text.IndexOf("-")));
                int second = Convert.ToInt32(listVDevNo.Items[i].Text.Substring(listVDevNo.Items[i].Text.IndexOf("-") + 1));


                if (-1 == DistributionControler.SendSmallPkgTime(devNo, second / 60, second % 60))
                {

                    failedCount++;
                }
                else
                {
                    if (FSMS.model.DataService.Instance().ModifySmallPkgDistInfo(devNo, 1) < 1)
                    {
                        Logger.Instance().LogError("frmSmallPkg::btnSend_Click: SmallPkgDistInfo下发标志位更新失败，请检查。");

                    }
                }
                progBarDist.PerformStep();

            }


            if (failedCount > 0)
            {
                MessageBox.Show("不是全部设备下发成功，请检查！");
            }
            else
            {
                MessageBox.Show("全部设备下发成功！");
            }

            BatchMgmControler.BindSmallPkgDist(ref this.dgvSmallPkgDist);
            try
            {
                BatchMgmControler.BindBatchDataToGrid(ref _batch.dgvBatch);
            }
            catch (Exception)
            { 
                
            }
            progBarDist.Value = 0;
            btnSend.Enabled = true;
            GlobalDefiniation.Enable_Auto_Query_Event = true;
        }

        private void dgvSmallPkgDist_SelectionChanged(object sender, EventArgs e)
        {


            listVDevNo.Clear();
            for (int i = 0; i < dgvSmallPkgDist.SelectedRows.Count; i++)
            {
                if (dgvSmallPkgDist.SelectedRows[i].Cells["DevNo"].Value == null || dgvSmallPkgDist.SelectedRows[i].Cells["SmallPkgTime"].Value == null)
                    continue;

                listVDevNo.Items.Add(Convert.ToString(dgvSmallPkgDist.SelectedRows[i].Cells["DevNo"].Value.ToString() + "-" 
                    + dgvSmallPkgDist.SelectedRows[i].Cells["SmallPkgTime"].Value.ToString()));
               
                              
            }
        }

        private void frmSmallPkg_Load(object sender, EventArgs e)
        {
            dgvSmallPkgDist.ClearSelection();
        }

        private void dgvSmallPkgDist_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
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

        private void frmSmallPkg_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalDefiniation.Enable_Auto_Query_Event = true;
        }





    }
}
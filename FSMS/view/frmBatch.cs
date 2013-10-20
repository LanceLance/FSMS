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
    public partial class frmBatch : Form
    {
        public frmBatch()
        {
            InitializeComponent();

            BatchMgmControler.BindBatchDataToGrid(ref dgvBatch);
            GroupMgmControler.BindGroupToGrid(ref dgvGroup);
           
        }
         

        private void btnUpdateBatch_Click(object sender, EventArgs e)
        {

            if (-1 == BatchMgmControler.ValidateNullDgv(ref dgvBatch))
            {
                return;
            }
            BatchMgmControler.ClearBatch();
            if( -1 == BatchMgmControler.AddBatchByDgv(ref dgvBatch))
            {
                MessageBox.Show("批号更新有错，请检查！");
                return;
            }

            if (-1 == BatchMgmControler.AddSmallPkgDistInfoByDgv(ref dgvBatch))
            {
                MessageBox.Show("小卷下发详情表更新有错，请检查！");
                return;
            }

            
            
            BatchMgmControler.BindBatchDataToGrid(ref dgvBatch);
            MessageBox.Show("更新成功！");
        }

        private void btnUpdateGroup_Click(object sender, EventArgs e)
        {
            if (-1 == BatchMgmControler.ValidateNullDgv(ref dgvGroup))
            {
                return;
            }
            GroupMgmControler.ClearGroup();
            GroupMgmControler.AddGroupByDgv(ref dgvGroup);
            GroupMgmControler.BindGroupToGrid(ref dgvGroup);
        }

        private void btnClearBatch_Click(object sender, EventArgs e)
        {
            BatchMgmControler.ClearBatch();
            BatchMgmControler.ClearSmallPkgDistInfo();
            BatchMgmControler.BindBatchDataToGrid(ref dgvBatch);
        }

        private void btnClearGroup_Click(object sender, EventArgs e)
        {
            GroupMgmControler.ClearGroup();
            GroupMgmControler.BindGroupToGrid(ref dgvGroup);
        }

        private void dgvBatch_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgvBatch_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBatch_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //if (dgvBatch.Columns[e.ColumnIndex].Name == "FirstDevNo" || dgvBatch.Columns[e.ColumnIndex].Name == "EndDevNo")
            //{
            //    if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
            //    {
            //        dgvBatch.Rows[e.RowIndex].ErrorText = "此列值不能为空！";
            //        e.Cancel = true;
            //        dgvBatch.CancelEdit();
            //    }
            //    else 
            //    {
                    
            //        //try
            //        //{
            //        //    Convert.ToInt32(dgvBatch.CurrentCell.Value.ToString().Trim());
            //        //}
            //        //catch (Exception)
            //        //{
            //        //    dgvBatch.Rows[e.RowIndex].ErrorText = "此列值只能为数字[0~9]!";
            //        //    e.Cancel = true;
            //        //    dgvBatch.CancelEdit();
            //        //}
                    
            //    }
            //}
        }

        private void dgvBatch_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView dgv = (DataGridView)sender;
            //DataGridViewCell dgc = dgv.CurrentCell;
            //try
            //{
            //    if (dgv.CurrentCell.ColumnIndex == 2 || dgv.CurrentCell.ColumnIndex == 3)
            //    {
            //        Convert.ToInt32(dgv.CurrentCell.Value.ToString().Trim());

            //    }



            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("validated failed,It need num");

            //    dgv[dgc.ColumnIndex, dgc.RowIndex].Selected = true;
            //}
        }

        private void frmBatch_Load(object sender, EventArgs e)
        {
            dgvBatch.ClearSelection();
            dgvGroup.ClearSelection();
        }

        private void dgvBatch_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //dgvBatch.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void btnSmallPkgTime_Click(object sender, EventArgs e)
        {
            int prograssMax = 0;
            btnSmallPkgTime.Enabled = false;
            GlobalDefiniation.Enable_Auto_Query_Event = false;
            bool allSuc = true;
            int count = 0;
            int failedCount = 0;
            for (int i = 0; i < dgvBatch.Rows.Count - 1; i++)
            {
                if (dgvBatch.Rows[i].Cells["BatchNo"].Value == null ||
                   dgvBatch.Rows[i].Cells["FirstDevNo"].Value == null ||
                   dgvBatch.Rows[i].Cells["LastDevNo"].Value == null ||
                   dgvBatch.Rows[i].Cells["SmallPkgTime"].Value == null ||
                   dgvBatch.Rows[i].Cells["FirstDevNo"].Value.ToString().Trim() == "" ||
                   dgvBatch.Rows[i].Cells["LastDevNo"].Value.ToString().Trim() == "" ||
                   dgvBatch.Rows[i].Cells["BatchNo"].Value.ToString().Trim() == "" ||
                   dgvBatch.Rows[i].Cells["SmallPkgTime"].Value.ToString().Trim() == ""
                   )
                {
                    continue;
                }

                int startDevNo = Convert.ToInt32(dgvBatch.Rows[i].Cells["FirstDevNo"].Value.ToString().Trim());
                int endDevNo = Convert.ToInt32(dgvBatch.Rows[i].Cells["LastDevNo"].Value.ToString().Trim());

                prograssMax += endDevNo - startDevNo + 1;
               

            }
            ProgBarDist.Value = 0;
            ProgBarDist.Maximum = prograssMax;
            ProgBarDist.Step = 1;


            for (int i = 0; i < dgvBatch.Rows.Count - 1; i++)
            {
                count = 0;
                allSuc = true;

                if (dgvBatch.Rows[i].Cells["BatchNo"].Value == null ||
                    dgvBatch.Rows[i].Cells["FirstDevNo"].Value == null ||
                    dgvBatch.Rows[i].Cells["LastDevNo"].Value == null ||
                    dgvBatch.Rows[i].Cells["SmallPkgTime"].Value == null ||
                    dgvBatch.Rows[i].Cells["FirstDevNo"].Value.ToString().Trim() == "" ||
                    dgvBatch.Rows[i].Cells["LastDevNo"].Value.ToString().Trim() == "" ||
                    dgvBatch.Rows[i].Cells["BatchNo"].Value.ToString().Trim() == "" ||
                    dgvBatch.Rows[i].Cells["SmallPkgTime"].Value.ToString().Trim() == ""
                    )
                {
                    continue;
                }
                string batchNo = dgvBatch.Rows[i].Cells["BatchNo"].Value.ToString().Trim();
                int startDevNo = Convert.ToInt32(dgvBatch.Rows[i].Cells["FirstDevNo"].Value.ToString().Trim());
                int endDevNo = Convert.ToInt32(dgvBatch.Rows[i].Cells["LastDevNo"].Value.ToString().Trim());

                int min = Convert.ToInt32(dgvBatch.Rows[i].Cells["SmallPkgTime"].Value.ToString()) / 60;
                int sec = Convert.ToInt32(dgvBatch.Rows[i].Cells["SmallPkgTime"].Value.ToString()) % 60;

                for (int j = startDevNo; j <= endDevNo; j++)
                {
                    if (-1 == DistributionControler.SendSmallPkgTime(j, min, sec))
                    {
                        allSuc = false;
                        failedCount++;
                    }
                    else
                    {
                        if (1 > FSMS.model.DataService.Instance().ModifySmallPkgDistInfo(j, 1))
                        {
                            Logger.Instance().LogError("frmBatch::btnSmallPkgTime_Click: T_SmallPkgDistInfo下发标志位更新失败，请检查。");
                        }
                        count++;
                    }

                    //prograss Bar value ++
                    ProgBarDist.PerformStep();
                }

                if (allSuc && count > 0)
                {

                    if (FSMS.model.DataService.Instance().ModifyBatch(batchNo, min * 60 + sec, 1) < 1)
                    {
                        Logger.Instance().LogError("frmBatch::btnSmallPkgTime_Click: T_BatchInfo下发标志位更新失败，请检查。");

                    }
                }


            }

            if (failedCount == 0)
            {
                MessageBox.Show("全部小卷认定时间下发成功!");     
            }
            else
            {
                MessageBox.Show("不是全部小卷认定时间下发成功,请检查!");
            }
            BatchMgmControler.BindBatchDataToGrid(ref dgvBatch);

            ProgBarDist.Value = 0;
            btnSmallPkgTime.Enabled = true;
            GlobalDefiniation.Enable_Auto_Query_Event = true;
        }

        private void linklbDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSmallPkg form = new frmSmallPkg(this);
            form.ShowDialog();
            form.Dispose();
        }

        private void frmBatch_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalDefiniation.Enable_Auto_Query_Event = true;
        }
    }
}
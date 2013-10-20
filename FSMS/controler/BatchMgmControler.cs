using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using FSMS.model;
using FSMS.common;
using System.ComponentModel;

namespace FSMS.controler
{
    class BatchMgmControler
    {

        static public void BindSmallPkgDist(ref DataGridView dgv)
        {

            DataTable dt = new DataTable();
            DataService.Instance().GetSmallPkgDist(ref dt);

            dgv.Rows.Clear();
            if (dt.Rows.Count < 1)
                return;
            dgv.Rows.Add(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv.Rows[i].Cells["BatchNo"].Value = dt.Rows[i]["BatchNo"].ToString();
                dgv.Rows[i].Cells["DevNo"].Value = dt.Rows[i]["DevNo"].ToString();
                dgv.Rows[i].Cells["SmallPkgTime"].Value = dt.Rows[i]["SmallPkgTime"].ToString();
                if (dt.Rows[i]["IsSent"].ToString().Trim() == "")
                {
                    dgv.Rows[i].Cells["IsSent"].Value = GlobalDefiniation.Sent_Result_Str[0];
                }
                else
                {
                    dgv.Rows[i].Cells["IsSent"].Value = GlobalDefiniation.Sent_Result_Str[Convert.ToInt32(dt.Rows[i]["IsSent"].ToString())];
                }
                             
                dgv.Rows[i].Cells["UpdateTime"].Value = dt.Rows[i]["UpdateTime"].ToString();


            }


        }

        public static void ClearSmallPkgDistInfo()
        {
            DataService.Instance().DelSmallPkgDistInfo();
        }
        public static int AddSmallPkgDistInfoByDgv(ref DataGridView dgv)
        {
            int errCount = 0;

            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
               
                string batchNo = dgv.Rows[i].Cells["BatchNo"].Value.ToString().Trim();
                int first = Convert.ToInt32(dgv.Rows[i].Cells["FirstDevNo"].Value.ToString().Trim());
                int last = Convert.ToInt32(dgv.Rows[i].Cells["LastDevNo"].Value.ToString().Trim());

                int smallPkgSec = Convert.ToInt32(dgv.Rows[i].Cells["SmallPkgTime"].Value.ToString().Trim());
                for (int j = first; j <= last; j++)
                {
                    if (DataService.Instance().AddSmallPkgDistInfo(batchNo,j,smallPkgSec,0) < 1)
                    {
                        errCount++;
                    }

                }
                
            }
            if (errCount > 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public static void ClearBatch()
        {
            DataService.Instance().DelBatch();
        }

        public static int AddBatch(string batchNo,int first,int last)
        {
            return DataService.Instance().AddBatchInfo(batchNo, first, last);
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

        public static int AddBatchByDgv(ref DataGridView dgv)
        {
            int errCount = 0;

            
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
             
                //AddBatchInfo(string batchNo, int first, int last,int singlePieWeight,int fullPkgTime,int smallPkgTime)
                string batchNo = dgv.Rows[i].Cells["BatchNo"].Value.ToString().Trim();
                int first = Convert.ToInt32(dgv.Rows[i].Cells["FirstDevNo"].Value.ToString().Trim());
                int last = Convert.ToInt32(dgv.Rows[i].Cells["LastDevNo"].Value.ToString().Trim());

                int singlePieWeight = Convert.ToInt32(dgv.Rows[i].Cells["SinglePieWeight"].Value.ToString().Trim());
                int fullPkgSec = Convert.ToInt32(dgv.Rows[i].Cells["FullPkgTime"].Value.ToString().Trim());
                int smallPkgSec = Convert.ToInt32(dgv.Rows[i].Cells["SmallPkgTime"].Value.ToString().Trim());
                if (DataService.Instance().AddBatchInfo(batchNo, first, last,singlePieWeight,fullPkgSec,smallPkgSec) < 1)
                {
                    errCount ++; 
                }

            }
            if (errCount > 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public static void BindBatchDataToGrid(ref DataGridView dgv)
        {
        
            DataTable dt = new DataTable();
            DataService.Instance().GetBatchInfo(ref dt);

            dgv.Rows.Clear();
            if (dt.Rows.Count < 1)
                return;
            
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                DataTable tableSmallPkgDist = new DataTable();
                DataService.Instance().GetSmallPkgDist(ref tableSmallPkgDist, dt.Rows[i]["BatchNo"].ToString(), 0);

                DataTable tableSmallPkgDist1 = new DataTable();
                DataService.Instance().GetSmallPkgDist(ref tableSmallPkgDist1, dt.Rows[i]["BatchNo"].ToString(), 1);

                if (tableSmallPkgDist.Rows.Count == 0 && tableSmallPkgDist1.Rows.Count > 0)
                {
                    DataService.Instance().ModifyBatch(dt.Rows[i]["BatchNo"].ToString(), 1);
                    dt.Rows[i]["IsSent"] = 1;
                }

            }


            dgv.Rows.Add(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                dgv.Rows[i].Cells["ID"].Value = dt.Rows[i]["ID"].ToString();
                dgv.Rows[i].Cells["BatchNo"].Value = dt.Rows[i]["BatchNo"].ToString();
                dgv.Rows[i].Cells["FirstDevNo"].Value = dt.Rows[i]["FirstDevNo"].ToString();
                dgv.Rows[i].Cells["LastDevNo"].Value = dt.Rows[i]["LastDevNo"].ToString();
                dgv.Rows[i].Cells["SinglePieWeight"].Value = dt.Rows[i]["SinglePieWeight"].ToString();
                dgv.Rows[i].Cells["FullPkgTime"].Value = dt.Rows[i]["FullPkgTime"].ToString();
                dgv.Rows[i].Cells["SmallPkgTime"].Value = dt.Rows[i]["SmallPkgTime"].ToString();
                if (dt.Rows[i]["IsSent"].ToString().Trim() == "")
                {
                    dgv.Rows[i].Cells["IsSent"].Value = GlobalDefiniation.Sent_Result_Str[0];
                }
                else
                {
                    dgv.Rows[i].Cells["IsSent"].Value = GlobalDefiniation.Sent_Result_Str[Convert.ToInt32(dt.Rows[i]["IsSent"].ToString())];
                }

                dgv.Rows[i].Cells["UpdateTime"].Value = dt.Rows[i]["UpdateTime"].ToString();

            }
            dgv.Sort(dgv.Columns["FirstDevNo"], ListSortDirection.Ascending);

        }
    }
}

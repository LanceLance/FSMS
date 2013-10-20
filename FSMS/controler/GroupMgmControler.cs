using System;
using System.Collections.Generic;
using System.Text;

using FSMS.controler;
using System.Windows.Forms;
using System.Data;
using FSMS.model;
using System.ComponentModel;

namespace FSMS.controler
{
    class GroupMgmControler
    {

        public static void ClearGroup()
        {
            DataService.Instance().DelGroup();
        }


        public static int AddGroup(string groupName,int first,int last)
        {
            return DataService.Instance().AddGroup(groupName, first, last);
        }

        public static void AddGroupByDgv(ref DataGridView dgv)
        {
            int errCount = 0;
            for (int i = 0; i < dgv.Rows.Count -1; i++)
            {
                if (dgv.Rows[i].Cells["GroupName"].Value == null ||
                   dgv.Rows[i].Cells["StartDevNo"].Value == null ||
                   dgv.Rows[i].Cells["EndDevNo"].Value == null)
                {
                    continue;
                }
                string groupName = dgv.Rows[i].Cells["GroupName"].Value.ToString().Trim();
                //int first = Convert.ToInt32(dgv.Rows[i].Cells["StartDevNo"].Value.ToString().Trim());
                //int last = Convert.ToInt32(dgv.Rows[i].Cells["EndDevNo"].Value.ToString().Trim());

                if (DataService.Instance().AddGroup(groupName, Convert.ToInt32(dgv.Rows[i].Cells["StartDevNo"].Value.ToString().Trim()), 
                    Convert.ToInt32(dgv.Rows[i].Cells["EndDevNo"].Value.ToString().Trim())) < 1)
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


        static public void BindGroupToGrid(ref DataGridView dgv)
        {
            DataTable dt = new DataTable();
            DataService.Instance().GetGroupInfo(ref dt);

            dgv.Rows.Clear();
            if (dt.Rows.Count < 1)
                return;
            dgv.Rows.Add(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv.Rows[i].Cells["GroupID"].Value = dt.Rows[i]["ID"].ToString();
                dgv.Rows[i].Cells["GroupName"].Value = dt.Rows[i]["GroupName"].ToString();
                dgv.Rows[i].Cells["StartDevNo"].Value = dt.Rows[i]["FirstDevNo"].ToString();
                dgv.Rows[i].Cells["EndDevNo"].Value = dt.Rows[i]["LastDevNo"].ToString();
                dgv.Rows[i].Cells["GroupUpdateTime"].Value = dt.Rows[i]["UpdateTime"].ToString();

            }
            dgv.Sort(dgv.Columns["StartDevNo"], ListSortDirection.Ascending);
        }
    }
}

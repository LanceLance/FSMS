using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using FSMS.model;


namespace FSMS.controler
{
    class DataGridControler
    {

        static public void BindData(ref DataGridView dgw,ref DataTable dt)
        {
            dgw.DataSource = dt;
        }

        static public void BindBatchDataToGrid(ref DataGridView dgv)
        {
            DataTable dt = new DataTable();
            DataService.Instance().GetBatchInfo(ref dt);
            dgv.DataSource = dt;

        }

        


    }
}

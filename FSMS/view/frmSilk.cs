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
    public partial class frmSilk : Form
    {
        public frmSilk()
        {
            InitializeComponent();

            DistributionControler.InitSilkNo(ref checkedlbSilkNo);
        }

        
        private void btnSilkNo_Click(object sender, EventArgs e)
        {
            int count = checkedlbSilkNo.CheckedItems.Count;
            string [] silkNos = new string [count];
         
            for (int i = 0; i < count; i++)
            { 
                silkNos[i] = checkedlbSilkNo.CheckedItems[i].ToString();
            }


            //for test
            //DistributionControler.SendBlockSilkNos(silkNos,1,10);
        }

        private void checkedlbSilkNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
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
    public partial class frmGroup : Form
    {
        public frmGroup()
        {
            InitializeComponent();
            GroupMgmControler.BindGroupToGrid(ref dgvGroup);
            lblID.Text = "";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvBatch_Click(object sender, EventArgs e)
        {

         
        }

        private void frmGroup_Load(object sender, EventArgs e)
        {
        
        }
    }
}
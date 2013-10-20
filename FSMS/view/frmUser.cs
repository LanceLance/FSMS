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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();

            UserMgmControler.BindUserDateToGrid(ref dgvUser);
        }


        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            UserMgmControler.ClearUser();
            UserMgmControler.AddUserByDgv(ref dgvUser);
            UserMgmControler.BindUserDateToGrid(ref dgvUser);
        }

        private void btnClearUser_Click(object sender, EventArgs e)
        {
            UserMgmControler.ClearUser();
            UserMgmControler.BindUserDateToGrid(ref dgvUser);
        }


        private void frmUser_Load(object sender, EventArgs e)
        {
            dgvUser.ClearSelection();
        }


    }
}
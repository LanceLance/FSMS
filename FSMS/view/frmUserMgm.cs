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
    public partial class frmUserMgm : Form
    {
        public frmUserMgm()
        {
            
            InitializeComponent();

            UserMgmControler.InitRole(ref cbRole);
            UserMgmControler.BindUserDateToGrid(ref dgvUser);
            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text == "")
            {
                MessageBox.Show("用户名不能为空,请重新输入!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }


            UserMgmControler.AddUser(tbUserName.Text.ToString().Trim(), tbPassword.Text.ToString().Trim(), cbRole.Text.ToString().Trim());
            UserMgmControler.BindUserDateToGrid(ref dgvUser);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count < 1)
            {
                MessageBox.Show("请先选择要更新的项!");
                return;
            }
            UserMgmControler.ModifyUser(tbUserName.Text.ToString().Trim(), tbPassword.Text.ToString().Trim(), cbRole.Text.ToString().Trim());
            UserMgmControler.BindUserDateToGrid(ref dgvUser);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count < 1)
            {
                MessageBox.Show("请先选择要删除的项!");
                return;
            }
            UserMgmControler.DelUser(tbUserName.Text.ToString());
            UserMgmControler.BindUserDateToGrid(ref dgvUser);
        }

        private void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbPassword.Text = "";
            tbUserName.Text = "";
            cbRole.SelectedIndex = 0;
        }

        private void dgvUser_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count > 0)
            {

                tbUserName.Text = dgvUser.SelectedRows[0].Cells["dgvTbUserName"].Value.ToString().Trim();
                tbPassword.Text = dgvUser.SelectedRows[0].Cells["dgvTbUserPwd"].Value.ToString().Trim();
                cbRole.SelectedItem = dgvUser.SelectedRows[0].Cells["dgvTbUserRole"].Value.ToString().Trim();

            }
        }

        private void frmUserMgm_Load(object sender, EventArgs e)
        {
            dgvUser.ReadOnly = true;
            dgvUser.ClearSelection();
        }
    }
}
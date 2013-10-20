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
    public partial class frmLogin : Form
    {
        private frmMain _frmMain;
        
        public frmLogin(frmMain frm)
        {
            _frmMain = frm;
            InitializeComponent();
        }


        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (tbUserName.Text.ToString().Trim() == "" )
            {
                MessageBox.Show("用户名不能为空,请重新输入!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (!UserMgmControler.Login(tbUserName.Text.ToString().Trim(), tbPassword.Text.ToString().Trim()))
            {
                return;
            }
            else
            {
                MessageBox.Show("登录成功,欢迎进入纺丝线管理系统!");
            }
            if (GlobalDefiniation.UserRoleName == "Admin")
            {
                _frmMain.rbbUser.Visible = true;
                _frmMain.rtabWork.Visible = true;
                _frmMain.Refresh();
            }
            else
            {
                _frmMain.rtabWork.Visible = false;
                _frmMain.rbbUser.Visible = false;
            }

            _frmMain.btnLogin.Text = "登出";
            _frmMain.ssLblCurUser.Text = tbUserName.Text;
            this.Close();
            this.Dispose();
            

        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //btnLogin.Focus();
            
        }
    }
}
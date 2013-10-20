using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FSMS.common;


namespace FSMS.view
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbWriteTimeout.Text = tbReadTimeout.Text = tbRate.Text = tbComName.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.WritePrivateProfileString("COM", "ComName", tbComName.Text.Trim(), GlobalDefiniation.FSMS_CONFIG_FILE);
                Utils.WritePrivateProfileString("COM", "TransRate", tbRate.Text.Trim(), GlobalDefiniation.FSMS_CONFIG_FILE);
                Utils.WritePrivateProfileString("COM", "ReadTimeout", tbReadTimeout.Text.Trim(), GlobalDefiniation.FSMS_CONFIG_FILE);
                Utils.WritePrivateProfileString("COM", "WriteTimeout", tbWriteTimeout.Text.Trim(), GlobalDefiniation.FSMS_CONFIG_FILE);
            }
            catch (Exception)
            {
                MessageBox.Show("配置失败,请检查!");
                return;
            }
            MessageBox.Show("配置成功,请重新启动此程序!");
            Environment.Exit(0) ;
        }
    }
}
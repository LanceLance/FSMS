using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using FSMS.common;

namespace FSMS.view
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            //test

            //FSMS.controler.FsmsContextControler.Init();
            //Application.Run(new frmDevice());
            //return;


            bool isFirst;
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, "FSMS", out isFirst);
            if (!isFirst)
            {
                MessageBox.Show("应用程序已运行!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Environment.Exit(1);                            //实例已经存在,退出程序
            }
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                if (!File.Exists(GlobalDefiniation.FSMS_CONFIG_FILE))
                {
                    Application.Run(new frmConfig());
                }
                else
                {
                    Application.Run(new frmMain());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Main():" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Environment.Exit(1);
            }
            //Application.Run(new frmMain());
        
            //for test
            //FSMS.controler.FsmsContextControler.Init();
            // new frmMain can be replaced to other form 
            
            //Application.Run(new frmConfig());
            //Application.Run(new frmSilk());
                
        }
    }
}
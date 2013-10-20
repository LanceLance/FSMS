using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using FSMS.model;
using FSMS.view;
using FSMS.common;
using System.Data;


namespace FSMS.controler
{
    class UserMgmControler
    {
        public static void ClearUser()
        {
            DataService.Instance().DelUser();
        }
        
        public static bool Login(string userName,string userPwd)
        {
            if (DataService.Instance().GetUserPwd(userName) != userPwd)
            {
                MessageBox.Show("用户名或密码不正确,请重新输入!");
                return false;
                    
            }

            string role = DataService.Instance().GetUserRole(userName);
            if (role == "Admin")
            {
                GlobalDefiniation.UserRoleName = "Admin";
                
            }

            return true;
        }


        public static void AddUserByDgv(ref DataGridView dgv)
        {
            int errCount = 0;
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                if (dgv.Rows[i].Cells["UserName"].Value == null ||
                    dgv.Rows[i].Cells["UserPwd"].Value == null ||
                    dgv.Rows[i].Cells["RoleName"].Value == null)
                {
                    continue;
                }
                string userName = dgv.Rows[i].Cells["UserName"].Value.ToString().Trim();
                string userPwd = dgv.Rows[i].Cells["UserPwd"].Value.ToString().Trim();
                string roleName = dgv.Rows[i].Cells["RoleName"].Value.ToString().Trim();


                if (DataService.Instance().AddUser(userName,userPwd,roleName) < 1)
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

        static public void BindUserDateToGrid(ref DataGridView dgv)
        {
            DataTable dt = new DataTable();
            DataService.Instance().GetUser(ref dt);
 
            dgv.Rows.Clear();
            if (dt.Rows.Count < 1)
                return;
            dgv.Rows.Add(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv.Rows[i].Cells["UserName"].Value = dt.Rows[i]["UserName"].ToString();
                dgv.Rows[i].Cells["UserPwd"].Value = dt.Rows[i]["UserPwd"].ToString();
                dgv.Rows[i].Cells["RoleName"].Value = dt.Rows[i]["RoleName"].ToString();
                dgv.Rows[i].Cells["UserUpdateTime"].Value = dt.Rows[i]["UpdateTime"].ToString();
                dgv.Rows[i].Cells["ID"].Value = dt.Rows[i]["ID"].ToString();

            }

            
            
        }


       
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar;
using System.Windows.Forms;

namespace FSMS.controler
{
    class CompAttrControler
    {
        
        static public void SetVisible(RibbonBar bar,bool isVisible)
        {

            bar.Visible = isVisible;
        }

        static public void InitRole(ref ComboBox cbRole)
        {
            cbRole.Items.Add("User");
            cbRole.Items.Add("Admin");
            cbRole.SelectedIndex = 0;
            
        }
    }
}

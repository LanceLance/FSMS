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
    public partial class frmClassCalendar : Form
    {
        public frmClassCalendar()
        {
            InitializeComponent();
            ClassMgmControler.BindClassCalender(ref dgvClassCalendar);

        }
    }
}
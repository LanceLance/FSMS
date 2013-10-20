using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FSMS.view
{
    public partial class frmDistribution : Form
    {
        public frmDistribution()
        {
            InitializeComponent();
        }

        private void btnDistribute_Click(object sender, EventArgs e)
        {

        }

        private void btnSilkNo_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnClock_Click(object sender, EventArgs e)
        {

        }

        private void checkbAutoClock_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbAutoClock.Checked)
                MessageBox.Show("checked");
        }
    }
}
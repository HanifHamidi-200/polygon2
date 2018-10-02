using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEARS
{
    public partial class fSub1 : Form
    {
        public fSub1()
        {
            InitializeComponent();
        }

        private void btnOpen1_Click(object sender, EventArgs e)
        {
            fSub11 _dlg = new fSub11();
            _dlg.ShowDialog();
        }

        private void btnOpen2_Click(object sender, EventArgs e)
        {
            fSub12 _dlg = new fSub12();
            _dlg.ShowDialog();

        }

        private void btnOpen3_Click(object sender, EventArgs e)
        {
            fSub13 _dlg = new fSub13();
            _dlg.ShowDialog();

        }
    }
}

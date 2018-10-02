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
    public partial class fSub13 : Form
    {
        public fSub13()
        {
            InitializeComponent();
        }

        private void btnOpen1_Click(object sender, EventArgs e)
        {
            fSubS1 _dlg = new fSubS1();
            _dlg.ShowDialog();
        }

        private void btnOpen2_Click(object sender, EventArgs e)
        {
            fSubS2 _dlg = new fSubS2();
            _dlg.ShowDialog();

        }

        private void btnOpen3_Click(object sender, EventArgs e)
        {
            fSubS3 _dlg = new fSubS3();
            _dlg.ShowDialog();

        }

        private void btnOpen4_Click(object sender, EventArgs e)
        {
            fSubS4 _dlg = new fSubS4();
            _dlg.ShowDialog();

        }

        private void btnOpen5_Click(object sender, EventArgs e)
        {
            fSubS5 _dlg = new fSubS5();
            _dlg.ShowDialog();

        }

        private void btnOpen6_Click(object sender, EventArgs e)
        {
            fSubS6 _dlg = new fSubS6();
            _dlg.ShowDialog();

        }
    }
}

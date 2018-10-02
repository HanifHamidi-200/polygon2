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
    public partial class fSub3 : Form
    {
        public fSub3()
        {
            InitializeComponent();
        }

        private void btnOpen1_Click(object sender, EventArgs e)
        {
            fSubT1 _dlg = new fSubT1();
            _dlg.ShowDialog();
        }

        private void btnOpen2_Click(object sender, EventArgs e)
        {
            fSubT2 _dlg = new fSubT2();
            _dlg.ShowDialog();

        }

        private void btnOpen3_Click(object sender, EventArgs e)
        {
            fSubT3 _dlg = new fSubT3();
            _dlg.ShowDialog();

        }
    }
}

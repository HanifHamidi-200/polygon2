using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPMOL2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn11_Click_1(object sender, EventArgs e)
        {
            fSub11 _dlg = new fSub11();
            _dlg.ShowDialog();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            fSub12 _dlg = new fSub12();
            _dlg.ShowDialog();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLITCH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            fSubA2 _dlg = new fSubA2();
            _dlg.ShowDialog();
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            fSubB2 _dlg = new fSubB2();
            _dlg.ShowDialog();

        }
    }
}

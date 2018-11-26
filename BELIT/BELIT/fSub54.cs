using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BELIT
{
    public partial class fSub54 : Form
    {
        public fSub54()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            picView.Image = pic0.Image;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            picView.Image = pic1.Image;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            picView.Image = pic2.Image;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            picView.Image = pic3.Image;
        }
    }
}

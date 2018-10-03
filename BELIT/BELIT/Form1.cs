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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            fSub1 _dlg = new fSub1();
            _dlg.ShowDialog();
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            fSub3 _dlg = new fSub3();
            _dlg.ShowDialog();

        }

        private void btn22_Click(object sender, EventArgs e)
        {
            fSub2 _dlg = new fSub2();
            _dlg.ShowDialog();

        }

        private void btn31_Click(object sender, EventArgs e)
        {
            fSub3 _dlg = new fSub3();
            _dlg.ShowDialog();

        }

        private void btn21_Click(object sender, EventArgs e)
        {
            fSub2 _dlg = new fSub2();
            _dlg.ShowDialog();

        }

        private void btn12_Click(object sender, EventArgs e)
        {
            fSub1 _dlg = new fSub1();
            _dlg.ShowDialog();

        }

    
        private void btn41_Click(object sender, EventArgs e)
        {
            fSub41 _dlg = new fSub41();
            _dlg.ShowDialog();

        }

        private void btn42_Click(object sender, EventArgs e)
        {
            fSub42 _dlg = new fSub42();
            _dlg.ShowDialog();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn51_Click(object sender, EventArgs e)
        {
            fSub51 _dlg = new fSub51();
            _dlg.ShowDialog();

        }

        private void btn52_Click(object sender, EventArgs e)
        {
            fSub52 _dlg = new fSub52();
            _dlg.ShowDialog();

        }

        private void btn53_Click(object sender, EventArgs e)
        {
            fSub53 _dlg = new fSub53();
            _dlg.ShowDialog();

        }
    }
}

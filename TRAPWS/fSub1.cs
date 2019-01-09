using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAPWS
{
    public partial class fSub1 : Form
    {
        private int mnFormnumber;

        private void fSave()
        {
            String sName = "Data.txt";
            String sNumber = Convert.ToString(mnFormnumber);

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@sName))
            {

                file.WriteLine("LIST");
                file.WriteLine(sNumber);
                file.WriteLine("END");
                file.Close();
            }
        }


        public fSub1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picCar1_Click(object sender, EventArgs e)
        {
            mnFormnumber = 1;
            fSave();
            fBlank _dlg = new fBlank();
            _dlg.ShowDialog();
        }

        private void picCar2_Click(object sender, EventArgs e)
        {
            mnFormnumber = 2;
            fSave();
            fBlank _dlg = new fBlank();
            _dlg.ShowDialog();

        }

        private void picCar3_Click(object sender, EventArgs e)
        {
            mnFormnumber = 3;
            fSave();
            fButtons _dlg = new fButtons();
            _dlg.ShowDialog();

        }

        private void picComputer1_Click(object sender, EventArgs e)
        {
            mnFormnumber = 4;
            fSave();
            fBlank _dlg = new fBlank();
            _dlg.ShowDialog();

        }

        private void picComputer2_Click(object sender, EventArgs e)
        {
            mnFormnumber = 5;
            fSave();
            fButtons _dlg = new fButtons();
            _dlg.ShowDialog();

        }

        private void picConstruction1_Click(object sender, EventArgs e)
        {
            mnFormnumber = 6;
            fSave();
            fButtons _dlg = new fButtons();
            _dlg.ShowDialog();

        }

        private void picConstruction2_Click(object sender, EventArgs e)
        {
            mnFormnumber = 7;
            fSave();
            fBlank _dlg = new fBlank();
            _dlg.ShowDialog();

        }

        private void picConstruction3_Click(object sender, EventArgs e)
        {
            mnFormnumber = 8;
            fSave();
            fButtons _dlg = new fButtons();
            _dlg.ShowDialog();

        }

        private void picGarden1_Click(object sender, EventArgs e)
        {
            mnFormnumber = 9;
            fSave();
            fBlank _dlg = new fBlank();
            _dlg.ShowDialog();

        }

        private void picGarden2_Click(object sender, EventArgs e)
        {
            mnFormnumber = 10;
            fSave();
            fBlank _dlg = new fBlank();
            _dlg.ShowDialog();

        }
    }
}

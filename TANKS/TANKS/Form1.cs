using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TANKS
{
    public partial class Form1 : Form
    {

        private List<int> _col1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int nNumber;

        private void fReset()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= 10; i++)
            {
                _col1[i - 1] = rnd1.Next(1, 5) * 2000;
                _col2[i - 1] = rnd1.Next(1, 5) * 2000;
                _col3[i - 1] = rnd1.Next(1, 5) * 2000;
            }

            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            lbl11.Text = Convert.ToString(_col1[0]);
            lbl12.Text = Convert.ToString(_col1[1]);
            lbl13.Text = Convert.ToString(_col1[2]);
            lbl14.Text = Convert.ToString(_col1[3]);
            lbl15.Text = Convert.ToString(_col1[4]);
            lbl16.Text = Convert.ToString(_col1[5]);
            lbl17.Text = Convert.ToString(_col1[6]);
            lbl18.Text = Convert.ToString(_col1[7]);
            lbl19.Text = Convert.ToString(_col1[8]);
            lbl1a.Text = Convert.ToString(_col1[9]);

            lbl21.Text = Convert.ToString(_col2[0]);
            lbl22.Text = Convert.ToString(_col2[1]);
            lbl23.Text = Convert.ToString(_col2[2]);
            lbl24.Text = Convert.ToString(_col2[3]);
            lbl25.Text = Convert.ToString(_col2[4]);
            lbl26.Text = Convert.ToString(_col2[5]);
            lbl27.Text = Convert.ToString(_col2[6]);
            lbl28.Text = Convert.ToString(_col2[7]);
            lbl29.Text = Convert.ToString(_col2[8]);
            lbl2a.Text = Convert.ToString(_col2[9]);

            lbl31.Text = Convert.ToString(_col3[0]);
            lbl32.Text = Convert.ToString(_col3[1]);
            lbl33.Text = Convert.ToString(_col3[2]);
            lbl34.Text = Convert.ToString(_col3[3]);
            lbl35.Text = Convert.ToString(_col3[4]);
            lbl36.Text = Convert.ToString(_col3[5]);
            lbl37.Text = Convert.ToString(_col3[6]);
            lbl38.Text = Convert.ToString(_col3[7]);
            lbl39.Text = Convert.ToString(_col3[8]);
            lbl3a.Text = Convert.ToString(_col3[9]);

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }
    }
}

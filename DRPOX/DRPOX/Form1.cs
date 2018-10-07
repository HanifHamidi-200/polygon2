using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRPOX
{
    public partial class Form1 : Form
    {
        private List<String> _text = new List<string> { null, null, null, null };
        private int mnStyle;

        private void fReset()
        {
            _text[0] = null;
            _text[1] = "Title";
            _text[2] = null;
            _text[3] = null;

            fUpdateDisplay();
        }
        
        private void fSave()
        {
            _text[0] = txt1.Text;
            _text[2] = txt2.Text;
            _text[3] = txt3.Text;

        }

        private void fStyle(int nMode)
        {
            mnStyle = nMode;
            fSave();
            fUpdateDisplay();
        }
        private void fUpdateDisplay()
        {
            txt1.Text = _text[0];
            lbl1.Text = _text[1];
            txt2.Text = _text[2];
            txt3.Text = _text[3];

            switch (mnStyle)
            {
                case 1:
                    fraPrimary.BackColor = Color.Green;
                    fraSecondary.BackColor = Color.Pink;
                    lbl1.BackColor = Color.Red;
                    break;
                case 2:
                    fraPrimary.BackColor = Color.Green;
                    fraSecondary.BackColor = Color.Purple;
                    lbl1.BackColor = Color.Yellow;
                    break;
                case 3:
                    fraPrimary.BackColor = Color.DarkBlue ;
                    fraSecondary.BackColor = Color.LightBlue ;
                    lbl1.BackColor = Color.Yellow;
                    break;
                default:
                    fraPrimary.BackColor = Color.Orange;
                    fraSecondary.BackColor = Color.Blue;
                    lbl1.BackColor = Color.Yellow;
                    break;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mnStyle = 1;
            fReset();
        }

        private void btnStyle1_Click(object sender, EventArgs e)
        {
            fStyle(1);
        }

        private void btnStyle2_Click(object sender, EventArgs e)
        {
            fStyle(3);
        }

        private void btnStyle3_Click(object sender, EventArgs e)
        {
            fStyle(4);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            lbl1.Text = txtTitle.Text;
        }

        private void btnStyle2_Click_1(object sender, EventArgs e)
        {
            fStyle(2);
        }
    }
}

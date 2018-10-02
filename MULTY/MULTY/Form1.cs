using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MULTY
{
    public partial class Form1 : Form
    {
        List<String> _header = new List<string> { null, null, null, null, null, null, null, null };
        List<int> _roll = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        List<int> _multiply = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        List<int> _answer = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        List<int> _answer2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };

        private void fComply()
        {
            bool bFound = false;
            int nError = 0;

            _answer2[0] = Convert.ToInt32(txtAnswer1.Text);
            _answer2[1] = Convert.ToInt32(txtAnswer2.Text);
            _answer2[2] = Convert.ToInt32(txtAnswer3.Text);
            _answer2[3] = Convert.ToInt32(txtAnswer4.Text);
            _answer2[4] = Convert.ToInt32(txtAnswer5.Text);
            _answer2[5] = Convert.ToInt32(txtAnswer6.Text);
            _answer2[6] = Convert.ToInt32(txtAnswer7.Text);
            _answer2[7] = Convert.ToInt32(txtAnswer8.Text);

            _answer[0] = _multiply[0] / _roll[0];
            _answer[1] = _multiply[1] / _roll[1];
            _answer[2] = _multiply[2] / _roll[2];
            _answer[3] = _multiply[3] / _roll[3];
            _answer[4] = _multiply[4] / _roll[4];
            _answer[5] = _multiply[5] / _roll[5];
            _answer[6] = _multiply[6] / _roll[6];
            _answer[7] = _multiply[7] / _roll[7];

            for (int i = 1; i <= 8; i++)
            {
                if (_answer2[i - 1] == _answer[i-1])
                {

                }
                else
                {
                    bFound = true;
                    nError = i;
                    goto exitlabel;
                }
            }

            exitlabel:;
            if (bFound == false)
            {
                fReset();
            }
            else
            {
                MessageBox.Show("There is an error at " + _header[nError - 1]);
            }
        }
        private void fReset()
        {
            Random rnd1 = new Random();
            char s1, s2;

            for (int i = 1; i <= 8; i++)
            {
                s1 = (char)(rnd1.Next(1, 27) + 64);
                s2 = (char)(rnd1.Next(1, 27) + 64);
                _header[i - 1] = Convert.ToString(s1) + Convert.ToString(s2);
                _header[i - 1].ToUpper();
                _roll[i - 1] = rnd1.Next(20, 101);
                _multiply[i - 1] = 0;
                _answer[i - 1] = 0;
            }

            fUpdateDisplay(true);
        }

        private void fReroll()
        {
            Random rnd1 = new Random();
      
            for (int i = 1; i <= 8; i++)
            {
                _roll[i - 1] = rnd1.Next(20, 101);
                _multiply[i - 1] = 0;
                _answer[i - 1] = 0;
            }

            fUpdateDisplay(true);
        }
        private void fMultiply()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= 8; i++)
            {
                _multiply[i - 1] = rnd1.Next(2, 7);
                _answer[i - 1] = 0;
            }

            fUpdateDisplay(true);
        }

        private void fUpdateDisplay(bool bAnswers)
        {
            lblHeader1.Text = _header[0];
            lblHeader2.Text = _header[1];
            lblHeader3.Text = _header[2];
            lblHeader4.Text = _header[3];
            lblHeader5.Text = _header[4];
            lblHeader6.Text = _header[5];
            lblHeader7.Text = _header[6];
            lblHeader8.Text = _header[7];

            lblRoll1.Text = Convert.ToString(_roll[0]);
            lblRoll2.Text = Convert.ToString(_roll[1]);
            lblRoll3.Text = Convert.ToString(_roll[2]);
            lblRoll4.Text = Convert.ToString(_roll[3]);
            lblRoll5.Text = Convert.ToString(_roll[4]);
            lblRoll6.Text = Convert.ToString(_roll[5]);
            lblRoll7.Text = Convert.ToString(_roll[6]);
            lblRoll8.Text = Convert.ToString(_roll[7]);

            lblMultiply1.Text = Convert.ToString(_roll[0] * _multiply[0]);
            lblMultiply2.Text = Convert.ToString(_roll[1] * _multiply[1]);
            lblMultiply3.Text = Convert.ToString(_roll[2] * _multiply[2]);
            lblMultiply4.Text = Convert.ToString(_roll[3] * _multiply[3]);
            lblMultiply5.Text = Convert.ToString(_roll[4] * _multiply[4]);
            lblMultiply6.Text = Convert.ToString(_roll[5] * _multiply[5]);
            lblMultiply7.Text = Convert.ToString(_roll[6] * _multiply[6]);
            lblMultiply8.Text = Convert.ToString(_roll[7] * _multiply[7]);

            if (bAnswers)
            {
                txtAnswer1.Text = Convert.ToString(_answer[0]);
                txtAnswer2.Text = Convert.ToString(_answer[1]);
                txtAnswer3.Text = Convert.ToString(_answer[2]);
                txtAnswer4.Text = Convert.ToString(_answer[3]);
                txtAnswer5.Text = Convert.ToString(_answer[4]);
                txtAnswer6.Text = Convert.ToString(_answer[5]);
                txtAnswer7.Text = Convert.ToString(_answer[6]);
                txtAnswer8.Text = Convert.ToString(_answer[7]);

            }
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

        private void btnReroll_Click(object sender, EventArgs e)
        {
            fReroll();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            fMultiply();
        }

        private void btnComply_Click(object sender, EventArgs e)
        {
            fComply();
        }
    }
}

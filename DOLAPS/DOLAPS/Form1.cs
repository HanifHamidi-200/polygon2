using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simple;

namespace DOLAPS
{
    public partial class Form1 : Form
    {
        private List<String> _entry = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null ,null};
        private List<String> _detail = new List<String> { null, null, null };
        private String msFile, msHeader;
        private int mnRecords, mnTop;
        private FILESimple2 _simple = new FILESimple2();

        private void fInput()
        {
            int nNumber = mnTop;

            _entry[nNumber - 1] = txtInput1.Text;

            nNumber += 1;
            if (nNumber > mnRecords)
            {
                _entry[nNumber - 1] = null;
            }
            else
            {
                _entry[nNumber - 1] = txtInput2.Text;
            }

            nNumber += 1;
            if (nNumber > mnRecords)
            {
                _entry[nNumber - 1] = null;
            }
            else
            {
                _entry[nNumber - 1] = txtInput3.Text;
            }

            nNumber += 1;
            if (nNumber > mnRecords)
            {
                _entry[nNumber - 1] = null;
            }
            else
            {
                _entry[nNumber - 1] = txtInput4.Text;
            }

            nNumber += 1;
            if (nNumber > mnRecords)
            {
                _entry[nNumber - 1] = null;
            }
            else
            {
                _entry[nNumber - 1] = txtInput5.Text;
            }

            nNumber += 1;
            if (nNumber > mnRecords)
            {
                _entry[nNumber - 1] = null;
            }
            else
            {
                _entry[nNumber - 1] = txtInput6.Text;
            }

            nNumber += 1;
            if (nNumber > mnRecords)
            {
                _entry[nNumber - 1] = null;
            }
            else
            {
                _entry[nNumber - 1] = txtInput7.Text;
            }

            nNumber += 1;
            if (nNumber > mnRecords)
            {
                _entry[nNumber - 1] = null;
            }
            else
            {
                _entry[nNumber - 1] = txtInput8.Text;
            }

            nNumber += 1;
            if (nNumber > mnRecords)
            {
                _entry[nNumber - 1] = null;
            }
            else
            {
                _entry[nNumber - 1] = txtInput9.Text;
            }

            nNumber += 1;
            if (nNumber > mnRecords)
            {
                _entry[nNumber - 1] = null;
            }
            else
            {
                _entry[nNumber - 1] = txtInputa.Text;
            }

            _detail[0] = txtDetail1.Text;
            _detail[1] = txtDetail2.Text;
            _detail[2] = txtDetail3.Text;

        }
        private void fReset()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= 28; i++)
            {
                _entry[i - 1] = null;
            }
            for (int i = 1; i <= 3; i++)
            {
                _detail[i - 1] = null;
            }
            msFile = "DUB1.txt";
            mnRecords = rnd1.Next(6, 29);
            mnTop = 1;

            _simple.fInitRecords(mnRecords);

            fUpdateDisplay();
            fUpdateStatus();
        }

        private void fUpdateDisplay()
        {
            int nNumber = mnTop;

            if (nNumber > mnRecords)
            {
                nNumber = 1;
            }
            if (nNumber < 1)
            {
                nNumber = 1;
            }

            lblMoneiyy1.Text = msHeader + Convert.ToString(nNumber);
            txtInput1.Text = _entry[nNumber - 1];

            nNumber += 1;
            if (nNumber > mnRecords)
            {
                lblMoneiyy2.Text = "<NG>";
                txtInput2.Text = null;
            }
            else
            {
                lblMoneiyy2.Text = msHeader + Convert.ToString(nNumber);
                txtInput2.Text = _entry[nNumber - 1];
            }

            nNumber += 1;
            if (nNumber > mnRecords)
            {
                lblMoneiyy3.Text = "<NG>";
                txtInput3.Text = null;
            }
            else
            {
                lblMoneiyy3.Text = msHeader + Convert.ToString(nNumber);
                txtInput3.Text = _entry[nNumber - 1];
            }

            nNumber += 1;
            if (nNumber > mnRecords)
            {
                lblMoneiyy4.Text = "<NG>";
                txtInput4.Text = null;
            }
            else
            {
                lblMoneiyy4.Text = msHeader + Convert.ToString(nNumber);
                txtInput4.Text = _entry[nNumber - 1];
            }

            nNumber += 1;
            if (nNumber > mnRecords)
            {
                lblMoneiyy5.Text = "<NG>";
                txtInput5.Text = null;
            }
            else
            {
                lblMoneiyy5.Text = msHeader + Convert.ToString(nNumber);
                txtInput5.Text = _entry[nNumber - 1];
            }

            nNumber += 1;
            if (nNumber > mnRecords)
            {
                lblMoneiyy6.Text = "<NG>";
                txtInput6.Text = null;
            }
            else
            {
                lblMoneiyy6.Text = msHeader + Convert.ToString(nNumber);
                txtInput6.Text = _entry[nNumber - 1];
            }

            nNumber += 1;
            if (nNumber > mnRecords)
            {
                lblMoneiyy7.Text = "<NG>";
                txtInput7.Text = null;
            }
            else
            {
                lblMoneiyy7.Text = msHeader + Convert.ToString(nNumber);
                txtInput7.Text = _entry[nNumber - 1];
            }

            nNumber += 1;
            if (nNumber > mnRecords)
            {
                lblMoneiyy8.Text = "<NG>";
                txtInput8.Text = null;
            }
            else
            {
                lblMoneiyy8.Text = msHeader + Convert.ToString(nNumber);
                txtInput8.Text = _entry[nNumber - 1];
            }

            nNumber += 1;
            if (nNumber > mnRecords)
            {
                lblMoneiyy9.Text = "<NG>";
                txtInput9.Text = null;
            }
            else
            {
                lblMoneiyy9.Text = msHeader + Convert.ToString(nNumber);
                txtInput9.Text = _entry[nNumber - 1];
            }

            nNumber += 1;
            if (nNumber > mnRecords)
            {
                lblMoneiyya.Text = "<NG>";
                txtInputa.Text = null;
            }
            else
            {
                lblMoneiyya.Text = msHeader + Convert.ToString(nNumber);
                txtInputa.Text = _entry[nNumber - 1];
            }
        }

        private void fUpdateStatus()
        {
            lblRecords.Text = "Records = " + Convert.ToString(mnRecords);
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnNav1_Click(object sender, EventArgs e)
        {
            mnTop -= 1;
            fUpdateDisplay();
        }

        private void btnNav3_Click(object sender, EventArgs e)
        {
            mnTop += 1;
            fUpdateDisplay();
        }

        private void btnHeader_Click(object sender, EventArgs e)
        {
            msHeader = txtHeader.Text;
            fReset();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            fInput();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            fAbout _dlg = new fAbout();
            _dlg.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fInput();
            _simple.fInitFName(txtSave.Text);
            _simple.fInitRecords(mnRecords);
            for(int i = 1; i <= mnRecords; i++)
            {
                _simple.fAddRecord(i, msHeader + Convert.ToString(i), _entry[i - 1]);
            }
            _simple.fAddDetail(_detail[0], _detail[1], _detail[2]);
            _simple.fFSave();
        }

        public Form1()
        {
            InitializeComponent();
            msHeader = "Moneiyy";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }
    }
}

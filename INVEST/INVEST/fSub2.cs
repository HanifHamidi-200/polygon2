using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVEST
{
    public partial class fSub2 : Form
    {
        private String msShuffle1;
        private String msShuffle2;
        private int nNumber;
        private List<bool> _option = new List<bool> { false, false, false, false };
        private int mnClick;
        private List<int> _holdings1 = new List<int> { 0, 0, 0, 0 };
        private List<int> _holdings2 = new List<int> { 0, 0, 0, 0 };
        private List<int> _holdings3 = new List<int> { 0, 0, 0, 0 };
        private List<int> _holdings4 = new List<int> { 0, 0, 0, 0 };
        private int mnCol, mnRow;

        private int fAmount(int nCol,int nRow)
        {
           switch (nCol)
            {
                case 1:
                    return _holdings1[nRow - 1];
                case 2:
                    return _holdings2[nRow - 1];
                case 3:
                    return _holdings3[nRow - 1];
                default:
                    return _holdings4[nRow - 1];
             }

        }
        private void fUpdateList()
        {
            int nBlue=0, nGreen=0, nRed=0, nYellow=0;
            int nType,nAmount;
            int nPos;
            String sText;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    nPos = (i - 1) * 4 + j;
                    nType = fHoletype(msShuffle2, nPos);
                    switch (nType)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        default:
                            nAmount = fAmount(i, j);
                            switch (nType)
                            {
                                case 3:
                                    nBlue += nAmount;
                                    break;
                                case 4:
                                    nGreen += nAmount;
                                    break;
                                case 5:
                                    nRed += nAmount;
                                    break;
                                default:
                                    nYellow += nAmount;
                                    break;
                            }
                            break;

                    }
                }

                   }
            if (lst1.Items.Count !=0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                }while (lst1.Items.Count!=0);
            }
            sText = "Blue = " + Convert.ToString(nBlue);
            lst1.Items.Add(sText);
            sText = "Green = " + Convert.ToString(nGreen);
            lst1.Items.Add(sText);
            sText = "Red = " + Convert.ToString(nRed);
            lst1.Items.Add(sText);
            sText = "Yellow = " + Convert.ToString(nYellow);
            lst1.Items.Add(sText);
        }
        private void fClick(int nCol,int nRow)
        {
            int nHoldings;
            int nPos = (nCol - 1) * 4 + nRow;
            int nType = fHoletype(msShuffle2, nPos);

            if (nType <= 2)
            {
                lblData.Text = "Data =";
                txtData.Text = "N/A";
            }
            else
            {
                nHoldings = fAmount(nCol, nRow);
                lblData.Text = "Data" + Convert.ToString(nCol) + Convert.ToString(nRow) + " =";
                txtData.Text = Convert.ToString(nHoldings);
            }
            mnCol = nCol;
            mnRow = nRow;
        }

        private void fReset()
        {
            Random rnd1 = new Random();
            int nValue;
            String sTwo = null;

            msShuffle1 = "01020304050607080910111213141516";
            msShuffle2 = null;

            for (int i = 1; i <= 16; i++)
            {
                nValue = rnd1.Next(1, 7);
                sTwo = Convert.ToString(nValue);
                if (sTwo.Length == 1)
                {
                    sTwo = "0" + sTwo;
                    msShuffle2 = msShuffle2 + sTwo;
                }
            }
      
            for (int i = 1; i <= 4; i++)
            {
                _option[i - 1] = false;
            }
            mnClick = rnd1.Next(1000, 99999);
            txtClick.Text = Convert.ToString(mnClick);
            for (int i = 1; i <= 4; i++)
            {
                _holdings1[i - 1] = rnd1.Next(200, 801);
                _holdings2[i - 1] = rnd1.Next(200, 801);
                _holdings3[i - 1] = rnd1.Next(200, 801);
                _holdings4[i - 1] = rnd1.Next(200, 801);
            }

            fUpdateDisplay();
            fUpdateList();
            fClick(1, 1);
         }

        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F trainline.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F tunnel.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F blue.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F green.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F red.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F yellow.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            switch (nValue)
            {
                case 1:
                    _pic2 = picture1;
                    break;
                case 2:
                    _pic2 = picture2;
                    break;
                case 3:
                    _pic2 = picture3;
                    break;
                case 4:
                    _pic2 = picture4;
                    break;
                case 5:
                    _pic2 = picture5;
                    break;
                case 6:
                    _pic2 = picture6;
                    break;
                default:
                    _pic2 = picture7;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        private int fHoletype(String sShuffle, int nSquare)
        {
            int nType = 0;

            nType = Convert.ToInt32(sShuffle.Substring(nSquare * 2 - 2, 2));
            return nType;
        }

        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate = 1;

            chk1.Checked = _option[0];
            chk2.Checked = _option[1];
            chk3.Checked = _option[2];
            chk4.Checked = _option[3];

            //1
            nType = fHoletype(msShuffle2, 1);
            fPeek(nType, nRotate, ref _pic);
            pic11.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 2);
            fPeek(nType, nRotate, ref _pic);
            pic12.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 3);
            fPeek(nType, nRotate, ref _pic);
            pic13.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 4);
            fPeek(nType, nRotate, ref _pic);
            pic14.Image = _pic.Image;

            //2
            nType = fHoletype(msShuffle2, 5);
            fPeek(nType, nRotate, ref _pic);
            pic21.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 6);
            fPeek(nType, nRotate, ref _pic);
            pic22.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 7);
            fPeek(nType, nRotate, ref _pic);
            pic23.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 8);
            fPeek(nType, nRotate, ref _pic);
            pic24.Image = _pic.Image;

            //3
            nType = fHoletype(msShuffle2, 9);
            fPeek(nType, nRotate, ref _pic);
            pic31.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 10);
            fPeek(nType, nRotate, ref _pic);
            pic32.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 11);
            fPeek(nType, nRotate, ref _pic);
            pic33.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 12);
            fPeek(nType, nRotate, ref _pic);
            pic34.Image = _pic.Image;

            //4
            nType = fHoletype(msShuffle2, 13);
            fPeek(nType, nRotate, ref _pic);
            pic41.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 14);
            fPeek(nType, nRotate, ref _pic);
            pic42.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 15);
            fPeek(nType, nRotate, ref _pic);
            pic43.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 16);
            fPeek(nType, nRotate, ref _pic);
            pic44.Image = _pic.Image;
        }
            public fSub2()
        {
            InitializeComponent();
        }

        private void fSub2_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            int nHoldings = Convert.ToInt32(txtData.Text);
            int nPos = (mnCol - 1) * 4 + mnRow;
            int nType = fHoletype(msShuffle2, nPos);

            if (nType <= 2)
            {

            }
            else
            {

                switch (mnCol)
                {
                    case 1:
                        _holdings1[mnRow - 1] = nHoldings;
                        break;
                    case 2:
                        _holdings2[mnRow - 1] = nHoldings;
                        break;
                    case 3:
                        _holdings3[mnRow - 1] = nHoldings;
                        break;
                    default:
                        _holdings4[mnRow - 1] = nHoldings;
                        break;
                }
            }
        }

        private void btnUpdateList_Click(object sender, EventArgs e)
        {
            fUpdateList();
        }

        private void pic11_Click(object sender, EventArgs e)
        {
            fClick(1, 1);
        }

        private void pic12_Click(object sender, EventArgs e)
        {
            fClick(1, 2);
        }

        private void pic13_Click(object sender, EventArgs e)
        {
            fClick(1, 3);
        }

        private void pic14_Click(object sender, EventArgs e)
        {
            fClick(1, 4);
        }

        private void pic21_Click(object sender, EventArgs e)
        {
            fClick(2, 1);
        }

        private void pic22_Click(object sender, EventArgs e)
        {
            fClick(2, 2);

        }

        private void pic23_Click(object sender, EventArgs e)
        { 
            fClick(2, 3);
        }

        private void pic24_Click(object sender, EventArgs e)
        {
            fClick(2, 4);
        }

        private void pic31_Click(object sender, EventArgs e)
        {
            fClick(3, 1);
        }

        private void pic32_Click(object sender, EventArgs e)
        {
            fClick(3, 2);
        }

        private void pic33_Click(object sender, EventArgs e)
        {
            fClick(3, 3);
        }

        private void pic34_Click(object sender, EventArgs e)
        {
            fClick(3, 4);
        }

        private void pic41_Click(object sender, EventArgs e)
        {
            fClick(4, 1);
        }

        private void pic42_Click(object sender, EventArgs e)
        {
            fClick(4, 2);
        }

        private void pic43_Click(object sender, EventArgs e)
        {
            fClick(4, 3);
        }

        private void pic44_Click(object sender, EventArgs e)
        {
            fClick(4, 4);
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }
    }
}

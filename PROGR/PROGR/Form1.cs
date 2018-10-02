using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGR
{
    public partial class Form1 : Form
    {
        private List<int> _level = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _crosses = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _moundset1 = new List<int> { 0, 0, 0, 0, 0 };
        private List<int> _moundset2 = new List<int> { 0, 0, 0, 0, 0 };
        private List<int> _moundset3 = new List<int> { 0, 0, 0, 0, 0 };
        private List<int> _occurance = new List<int> { 0, 0, 0, 0 };
        private List<int> _occurance2 = new List<int> { 0, 0, 0, 0 };
        private List<string> _numbers = new List<string> { null, null, null, null, null, null };
        private int nNumber;
        private string sMOO = "YYB";
        private int mnMode = 1;

        private void fClick(int nMode)
        {
            _crosses[nMode - 1] = (mnMode * 2) + (_level[nMode - 1] - 2);
            fUpdateDisplay(false);
        }

        private void fReset()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= 17; i++)
            {
                _level[i - 1] = rnd1.Next(1, 4);
                _crosses[i - 1] = _level[i - 1] + 9;
            }
            for (int i = 1; i <= 5; i++)
            {
                _moundset1[i - 1] = rnd1.Next(13, 17);
            }
            for (int i = 1; i <= 5; i++)
            {
                _moundset2[i - 1] = rnd1.Next(13, 17);
            }
            for (int i = 1; i <= 5; i++)
            {
                _moundset3[i - 1] = rnd1.Next(13, 17);
            }

            for (int i = 1; i <= 6; i++)
            {
                _numbers[i - 1] = null;
            }

            fUpdateDisplay(true);
        }

        private void fUpdateDisplay(bool bText)
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate = 1;

            nType = _crosses[0];
            fPeek(nType, nRotate, ref _pic);
            picWork1.Image = _pic.Image;
            nType = _crosses[1];
            fPeek(nType, nRotate, ref _pic);
            picWork2.Image = _pic.Image;
            nType = _crosses[2];
            fPeek(nType, nRotate, ref _pic);
            picWork3.Image = _pic.Image;
            nType = _crosses[3];
            fPeek(nType, nRotate, ref _pic);
            picWork4.Image = _pic.Image;
            nType = _crosses[4];
            fPeek(nType, nRotate, ref _pic);
            picWork5.Image = _pic.Image;
            nType = _crosses[5];
            fPeek(nType, nRotate, ref _pic);
            picWork6.Image = _pic.Image;
            nType = _crosses[6];
            fPeek(nType, nRotate, ref _pic);
            picWork7.Image = _pic.Image;
            nType = _crosses[7];
            fPeek(nType, nRotate, ref _pic);
            picWork8.Image = _pic.Image;
            nType = _crosses[8];
            fPeek(nType, nRotate, ref _pic);
            picWork9.Image = _pic.Image;
            nType = _crosses[9];
            fPeek(nType, nRotate, ref _pic);
            picWork10.Image = _pic.Image;
            nType = _crosses[10];
            fPeek(nType, nRotate, ref _pic);
            picWork11.Image = _pic.Image;
            nType = _crosses[11];
            fPeek(nType, nRotate, ref _pic);
            picWork12.Image = _pic.Image;
            nType = _crosses[12];
            fPeek(nType, nRotate, ref _pic);
            picWork13.Image = _pic.Image;

            nType = _moundset1[0];
            fPeek(nType, nRotate, ref _pic);
            picMound11.Image = _pic.Image;
            nType = _moundset1[1];
            fPeek(nType, nRotate, ref _pic);
            picMound12.Image = _pic.Image;
            nType = _moundset1[2];
            fPeek(nType, nRotate, ref _pic);
            picMound13.Image = _pic.Image;
            nType = _moundset1[3];
            fPeek(nType, nRotate, ref _pic);
            picMound14.Image = _pic.Image;
            nType = _moundset1[4];
            fPeek(nType, nRotate, ref _pic);
            picMound15.Image = _pic.Image;

            nType = _moundset2[0];
            fPeek(nType, nRotate, ref _pic);
            picMound21.Image = _pic.Image;
            nType = _moundset2[1];
            fPeek(nType, nRotate, ref _pic);
            picMound22.Image = _pic.Image;
            nType = _moundset2[2];
            fPeek(nType, nRotate, ref _pic);
            picMound23.Image = _pic.Image;
            nType = _moundset2[3];
            fPeek(nType, nRotate, ref _pic);
            picMound24.Image = _pic.Image;
            nType = _moundset2[4];
            fPeek(nType, nRotate, ref _pic);
            picMound25.Image = _pic.Image;

            nType = _moundset3[0];
            fPeek(nType, nRotate, ref _pic);
            picMound31.Image = _pic.Image;
            nType = _moundset3[1];
            fPeek(nType, nRotate, ref _pic);
            picMound32.Image = _pic.Image;
            nType = _moundset3[2];
            fPeek(nType, nRotate, ref _pic);
            picMound33.Image = _pic.Image;
            nType = _moundset3[3];
            fPeek(nType, nRotate, ref _pic);
            picMound34.Image = _pic.Image;
            nType = _moundset3[4];
            fPeek(nType, nRotate, ref _pic);
            picMound35.Image = _pic.Image;

            if (bText)
            {
                txtNumber11.Text = _numbers[0];
                txtNumber12.Text = _numbers[1];
                txtNumber21.Text = _numbers[2];
                txtNumber22.Text = _numbers[3];
                txtNumber31.Text = _numbers[4];
                txtNumber32.Text = _numbers[5];

            }
        }
        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F A1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F A2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F A3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F B1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F B2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F B3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F C1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F C2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F C3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F cross1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F cross2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F cross3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F mound1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F mound2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F mound3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F mound4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
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
                case 7:
                    _pic2 = picture7;
                    break;
                case 8:
                    _pic2 = picture8;
                    break;
                case 9:
                    _pic2 = picture9;
                    break;
                case 10:
                    _pic2 = picture10;
                    break;
                case 11:
                    _pic2 = picture11;
                    break;
                case 12:
                    _pic2 = picture12;
                    break;
                case 13:
                    _pic2 = picture13;
                    break;
                case 14:
                    _pic2 = picture14;
                    break;
                case 15:
                    _pic2 = picture15;
                    break;
                case 16:
                    _pic2 = picture16;
                    break;
                default:
                    _pic2 = picture17;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
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

        private void btnMode1_Click(object sender, EventArgs e)
        {
            mnMode = 1;
        }

        private void btnMode2_Click(object sender, EventArgs e)
        {
            mnMode = 2;

        }

        private void btnMode3_Click(object sender, EventArgs e)
        {
            mnMode = 3;

        }

        private void picWork1_Click(object sender, EventArgs e)
        {
            fClick(1);
        }

        private void picWork2_Click(object sender, EventArgs e)
        {
            fClick(2);
        }

        private void picWork3_Click(object sender, EventArgs e)
        {
            fClick(3);
        }

        private void picWork4_Click(object sender, EventArgs e)
        {
            fClick(4);
        }

        private void picWork5_Click(object sender, EventArgs e)
        {
            fClick(5);
        }

        private void picWork6_Click(object sender, EventArgs e)
        {
            fClick(6);
        }

        private void picWork7_Click(object sender, EventArgs e)
        {
            fClick(7);
        }

        private void picWork8_Click(object sender, EventArgs e)
        {
            fClick(8);
        }

        private void picWork9_Click(object sender, EventArgs e)
        {
            fClick(9);
        }

        private void picWork10_Click(object sender, EventArgs e)
        {
            fClick(10);
        }

        private void picWork11_Click(object sender, EventArgs e)
        {
            fClick(11);
        }

        private void picWork12_Click(object sender, EventArgs e)
        {
            fClick(12);
        }

        private void picWork13_Click(object sender, EventArgs e)
        {
            fClick(13);
        }

        private void btnMOO_Click(object sender, EventArgs e)
        {
            string sText = txtMOO.Text;
            string sChar = null;
            int nColour;

            for (int i = 1; i <= 4; i++)
            {
                _occurance[i - 1] = 0;
                _occurance2[i - 1] = 0;
            }

            for (int i = 1; i <= sText.Length; i++)
            {
                sChar = sText.Substring(i - 1, 1);
                switch (sChar)
                {
                    case "R":
                        _occurance[0] += 1;
                        break;
                    case "G":
                        _occurance[1] += 1;
                        break;
                    case "Y":
                        _occurance[2] += 1;
                        break;
                    case "B":
                        _occurance[3] += 1;
                        break;

                }
            }
            for (int i = 1; i <= 5; i++)
            {
                switch (mnMode)
                {
                    case 1:
                        nColour = _moundset1[i-1] - 12;
                        _occurance2[nColour - 1] += 1;
                        break;
                    case 2:
                        nColour = _moundset2[i-1] - 12;
                        _occurance2[nColour - 1] += 1;
                        break;
                    default:
                        nColour = _moundset3[i-1] - 12;
                        _occurance2[nColour - 1] += 1;
                        break;
                }
            }
            btnConstruction.Visible = false;

            if (_occurance2[0] >= _occurance[0])
            {
                if (_occurance2[1] >= _occurance[1])
                {
                    if (_occurance2[2] >= _occurance[2])
                    {
                        if (_occurance2[3] >= _occurance[3])
                        {
                            btnConstruction.Visible = true;



                        }
                    }
                }
            }
        }

        private void btnConstruction_Click(object sender, EventArgs e)
        {
            fSub1 _dlg = new fSub1();
            _dlg.ShowDialog();
        }
    }
}

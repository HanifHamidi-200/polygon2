using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRARRS
{
    public partial class Form1 : Form
    {
        private int mnGamesWon = 0;
        private string msShuffle1, msShuffle2;
        private int mnPuzzle;
         private int mnHole,mnQuestion;

        private void fClaimCol(int nCol)
        {
            String sSequence = null;
            bool bFound = false;
            int nSquare, nGot;

            switch (nCol)
            {
                case 1:
                    sSequence = "01020304";
                    break;
                case 2:
                    sSequence = "05060708";
                    break;
                case 3:
                    sSequence = "09101112";
                    break;
                case 4:
                    sSequence = "13141516";
                    break;
                default:
                    goto exitlabel;
             }

            for (int i = 1; i <= 4; i++)
            {
                nSquare = Convert.ToInt32(sSequence.Substring(i * 2 - 2, 2));
                nGot = Convert.ToInt32(msShuffle2.Substring(nSquare * 2 - 2, 2));
                if (nGot != nSquare)
                {
                    bFound = true;
                    continue;
                }
            }

            if (bFound == false)
            {
                mnGamesWon += 2;
                MessageBox.Show("ColFound", "GWin" + Convert.ToString(mnGamesWon));
                fReset();
            }

        exitlabel:;
        }

        private void fClaimRow(int nRow)
        {
            String sSequence=null;
            bool bFound = false;
            int nSquare,nGot;

            switch (nRow)
            {
                case 1:
                    sSequence = "01050913";
                    break;
                case 2:
                    sSequence = "02061014";
                    break;
                case 3:
                    sSequence = "03071115";
                    break;
                case 4:
                    sSequence = "04081216";
                    break;
                default:
                    goto exitlabel;
            }

            for (int i = 1; i <= 4; i++)
            {
                nSquare = Convert.ToInt32(sSequence.Substring(i * 2 - 2, 2));
                nGot = Convert.ToInt32(msShuffle2.Substring(nSquare * 2 - 2, 2));
                if (nGot != nSquare)
                {
                    bFound = true;
                    continue;
                }
            }

            if (bFound == false)
            {
                mnGamesWon += 2;
                MessageBox.Show("RowFound", "GWin" + Convert.ToString(mnGamesWon));
                fReset();
            }

        exitlabel:;
        }
        private bool fValidCorrect()
        {
            if (mnHole == mnQuestion)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool fValidClick(int nSquare)
        {
            Random rnd1 = new Random();
            String sOptions = null;
            int nLength, nPos,nReturn;

            switch (mnHole){
                case 1:
                    sOptions = "0205";
                    break;
                case 2:
                    sOptions = "010306";
                    break;
                case 3:
                    sOptions = "020407";
                    break;
                case 4:
                    sOptions = "0308";
                    break;
                case 5:
                    sOptions = "010609";
                    break;
                case 6:
                    sOptions = "02050710";
                    break;
                case 7:
                    sOptions = "03060811";
                    break;
                case 8:
                    sOptions = "040712";
                    break;
                case 9:
                    sOptions = "051013";
                    break;
                case 10:
                    sOptions = "06091114";
                    break;
                case 11:
                    sOptions = "07101215";
                    break;
                case 12:
                    sOptions = "081116";
                    break;
                case 13:
                    sOptions = "0914";
                    break;
                case 14:
                    sOptions = "101315";
                    break;
                case 15:
                    sOptions = "111416";
                    break;
                default:
                    sOptions = "1215";
                    break;

            }

            nLength = sOptions.Length/2;
            for (int i = 1; i <= nLength; i++)
            {
                nPos = i;
                nReturn = Convert.ToInt32(sOptions.Substring(nPos * 2 - 2, 2));
                if (nSquare == nReturn)
                {
                    return true;
                }
            }

            return false;
        }
        private void fClick(int nSquare)
        {
            int nSave,nHole;
            String sShuffle = msShuffle2;
            String sTwo = null;
            bool bEnded = false;

            if (fValidClick(nSquare)){
                nSave =Convert.ToInt32( msShuffle2.Substring(nSquare * 2 - 2, 2));
                nHole = Convert.ToInt32(msShuffle2.Substring(mnHole * 2 - 2, 2));
                sTwo = Convert.ToString(nHole);
                if (sTwo.Length == 1)
                {
                    sTwo = "0" + sTwo;
                }
                msShuffle2 = msShuffle2.Substring(0, nSquare * 2 - 2) + sTwo+msShuffle2.Substring(nSquare * 2, (16 - nSquare) * 2);
                sTwo = Convert.ToString(nSave);
                if (sTwo.Length == 1)
                {
                    sTwo = "0" + sTwo;
                }
                msShuffle2 = msShuffle2.Substring(0, mnHole * 2 - 2) + sTwo + msShuffle2.Substring(mnHole * 2, (16 - mnHole) * 2);
                mnHole = nSquare;
                lblShuffle.Text = "Shuffle = " + fShuffleText(msShuffle2);
                fUpdateDisplay();

                bEnded = fValidCorrect();
                if (bEnded)
                {
                    mnGamesWon += 1;
                    MessageBox.Show("You've won", "GWin"+Convert.ToString(mnGamesWon));
                    fReset();
                }
            }
        }

        private String fShuffleText(String sShuffle)
        {
            String sText = sShuffle.Substring(0, 8) + " " + sShuffle.Substring(8, 8) + " "+sShuffle.Substring(16, 8) + " " + sShuffle.Substring(24, 8);
            return sText;
        }
        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            string sDir;

            sDir = "slot" + Convert.ToString(mnPuzzle);

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(sDir + "\\F A1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(sDir + "\\F A2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(sDir + "\\F A3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(sDir + "\\F A4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(sDir + "\\F B1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(sDir + "\\F B2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(sDir + "\\F B3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(sDir + "\\F B4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(sDir + "\\F C1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(sDir + "\\F C2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(sDir + "\\F C3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(sDir + "\\F C4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(sDir + "\\F D1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(sDir + "\\F D2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(sDir + "\\F D3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(sDir + "\\F D4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(sDir + "\\F holehere.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(sDir + "\\F specialsquarefound.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(sDir + "\\F NullGate.png"),
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
                case 17:
                    _pic2 = picture17;
                    break;
                case 18:
                    _pic2 = picture18;
                    break;
                default:
                    _pic2 = picture19;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        private int fHoletype(String sShuffle,int nSquare)
        {
            int nType = 0;

            if (nSquare == mnHole)
            {
                nType = 17;
            }
            else
            {
                nType = Convert.ToInt32(sShuffle.Substring(nSquare * 2 - 2, 2));
            }
            return nType;
        }
        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate = 1;

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

        private string fShuffle(string sText)
        {
            string sText2 = null;
            int nPos = 0,nLength=16;

            Random rnd1 = new Random();

            for (int i = 1; i <= 16; i++)
            {
                nLength = 17 - i;
                nPos = rnd1.Next(1, nLength + 1);
                sText2 = sText2 + sText.Substring(nPos * 2 - 2, 2);
                sText = sText.Substring(0, nPos * 2 - 2) + sText.Substring(nPos * 2, (nLength - nPos) * 2);
            }

            return sText2;
        }
        private String fHoleString(int nHole)
        {
            switch (nHole)
            {
                case 1:
                    return "A1";
                case 2:
                    return "A2";
                case 3:
                    return "A3";
                case 4:
                    return "A4";
                case 5:
                    return "B1";
                case 6:
                    return "B2";
                case 7:
                    return "B3";
                case 8:
                    return "B4";
                case 9:
                    return "C1";
                case 10:
                    return "C2";
                case 11:
                    return "C3";
                case 12:
                    return "C4";
                case 13:
                    return "D1";
                case 14:
                    return "D2";
                case 15:
                    return "D3";
                default:
                    return "D4";

            }
        }
        private void fReset()
        {
            Random rnd1 = new Random();
            String sHole;

            msShuffle1 = "01020304050607080910111213141516";
            msShuffle2 = fShuffle(msShuffle1);
            mnPuzzle = rnd1.Next(1, 5);
            mnHole = rnd1.Next(1, 17);
            mnQuestion = rnd1.Next(1, 17);
            sHole = fHoleString(mnQuestion);

            lblShuffle.Text = "Shuffle = " + msShuffle2;
            lblQuestion.Text = "hole to " + sHole;
            fUpdateDisplay();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void pic11_Click(object sender, EventArgs e)
        {
            fClick(1);
        }

        private void pic12_Click(object sender, EventArgs e)
        {
            fClick(2);
        }

        private void pic13_Click(object sender, EventArgs e)
        {
            fClick(3);
        }

        private void pic14_Click(object sender, EventArgs e)
        {
            fClick(4);
        }

        private void pic21_Click(object sender, EventArgs e)
        {
            fClick(5);
        }

        private void pic22_Click(object sender, EventArgs e)
        {
            fClick(6);
        }

        private void pic23_Click(object sender, EventArgs e)
        {
            fClick(7);
        }

        private void pic24_Click(object sender, EventArgs e)
        {
            fClick(8);
        }

        private void pic31_Click(object sender, EventArgs e)
        {
            fClick(9);
        }

        private void pic32_Click(object sender, EventArgs e)
        {
            fClick(10);
        }

        private void pic33_Click(object sender, EventArgs e)
        {
            fClick(11);
        }

        private void pic34_Click(object sender, EventArgs e)
        {
            fClick(12);
        }

        private void pic41_Click(object sender, EventArgs e)
        {
            fClick(13);
        }

        private void pic42_Click(object sender, EventArgs e)
        {
            fClick(14);
        }

        private void pic43_Click(object sender, EventArgs e)
        {
            fClick(15);
        }

        private void pic44_Click(object sender, EventArgs e)
        {
            fClick(16);
        }

        private void btnClaimRow_Click(object sender, EventArgs e)
        {
            int nRow = Convert.ToInt32(txtClaimRow.Text);
            fClaimRow(nRow);
        }

        private void btnClaimCol_Click(object sender, EventArgs e)
        {
            int nCol = Convert.ToInt32(txtClaimCol.Text);
            fClaimRow(nCol);

        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }
    }
}

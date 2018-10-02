using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAASY
{
    public partial class Form1 : Form
    {
        private List<int> _col1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _skill1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _skill2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _skill3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _skill4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _skill5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _skill6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _skill7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _skill8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private int nNumber;
        private bool mbSelect;
        private int mnCol = 1,mnRow=1;
        private int mnAction = 1;
        private int mnEnemy = 0;
        private int mnECol, mnERow, mnECode;
        private bool mbFireball = false;

        private void fShoot(int nMode,int nCol,int nRow)
        {
            Random rnd1 = new Random();

            switch (nMode)
            {
                case 3:
                    for (int i = nCol - 1; i <= nCol + 2; i++)
                    {
                        for (int j = nRow - 1; j <= nRow + 2; j++)
                        {
                            if (i >= 1)
                            {
                                if (i <= 8)
                                {
                                    if (j >= 1)
                                    {
                                        if (j <= 8)
                                        {
                                            nNumber = rnd1.Next(1, 10);
                                            if (nNumber <= 3)
                                            {
                                                fPlace(i, j, 4);
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                    fUpdateDisplay();
                    break;
                default:
                    fPlace(nCol, nRow, 5);
                    fUpdateDisplay();
                    break;
            }
        }

        private bool fValidPlanar(int nCol1,int nRow1,int nCol2,int nRow2)
        {
            int nType;

            if (nCol1 == nCol2)
            {
                if (nRow2 < nRow1)
                {
                    for (int i = nRow2 + 1; i < nRow1; i++)
                    {
                        nType = fType(nCol1, i);
                        if (nType == 3)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (nRow2 > nRow1)
                    {
                        for (int i = nRow2 - 1; i > nRow1; i--)
                        {
                            nType = fType(nCol1, i);
                            if (nType == 3)
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                if (nRow1 == nRow2)
                {
                    if (nCol2 < nCol1)
                    {
                        for (int i = nCol2 + 1; i < nCol1; i++)
                        {
                            nType = fType(i,nRow1);
                            if (nType == 3)
                            {
                                return false;
                            }
                        }

                    }
                    else
                    {
                        if (nCol2 > nCol1)
                        {
                            for (int i = nCol2 - 1; i > nCol1; i--)
                            {
                                nType = fType(i, nRow1);
                                if (nType == 3)
                                {
                                    return false;
                                }
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private bool fNext(int nCol1,int nRow1,int nCol2,int nRow2)
        {
            int nCol3, nRow3;

            for (int i = 1; i <= 8; i++)
            {
                switch (i)
                {
                    case 1:
                        nCol3 = nCol1;
                        nRow3 = nRow1 - 1;
                        break;
                    case 2:
                        nCol3 = nCol1+1;
                        nRow3 = nRow1 - 1;
                        break;
                    case 3:
                        nCol3 = nCol1+1;
                        nRow3 = nRow1 ;
                        break;
                    case 4:
                        nCol3 = nCol1+1;
                        nRow3 = nRow1 + 1;
                        break;
                    case 5:
                        nCol3 = nCol1;
                        nRow3 = nRow1 + 1;
                        break;
                    case 6:
                        nCol3 = nCol1-1;
                        nRow3 = nRow1 + 1;
                        break;
                    case 7:
                        nCol3 = nCol1-1;
                        nRow3 = nRow1 ;
                        break;
                    default:
                        nCol3 = nCol1-1;
                        nRow3 = nRow1 - 1;
                        break;
                }
                if (nCol3 == 0)
                {
                    nCol3 = 8;
                }
                if (nCol3 == 9)
                {
                    nCol3 = 1;
                }
                if (nRow3 == 0)
                {
                    nRow3 = 8;
                }
                if (nRow3 == 9)
                {
                    nRow3 = 1;
                }
                if (nCol3 == nCol2)
                {
                    if (nRow3 == nRow2)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private int fSkill(int nCol,int nRow)
        {
            switch (nCol)
            {
                case 1:
                    return _skill1[nRow - 1];
                case 2:
                    return _skill2[nRow - 1];
                case 3:
                    return _skill3[nRow - 1];
                case 4:
                    return _skill4[nRow - 1];
                case 5:
                    return _skill5[nRow - 1];
                case 6:
                    return _skill6[nRow - 1];
                case 7:
                    return _skill7[nRow - 1];
                default:
                    return _skill8[nRow - 1];

            }
        }
        private void fRidmode(int nCol,int nRow)
        {
            int nType = fType(nCol, nRow);
            int nMode = 0;
            int nSkill=0;
            string sText = null;

            if (nType == 3) { 
                if (fNext(mnCol, mnRow, nCol, nRow))
                {
                    nMode = 1;
                }
                else
                {
                    nSkill = fSkill(nCol, nRow);
                    if (nSkill >= 1)
                    {
                        nMode = 2;
                    }
                    else
                    {
                        nMode = 3;
                    }
                }
            }
            else
            {
                nMode = 0;
            }

            mnEnemy = nMode;
            mnECol = nCol;
            mnERow = nRow;
            mnECode = nSkill;
            switch (mnEnemy)
            {
                case 1:
                    MessageBox.Show("Just shootit");
                    break;
                case 2:
                    switch (nSkill)
                    {
                        case 1:
                            sText = "[1]";
                            break;
                        case 2:
                            sText = "[2]";
                            break;
                        case 3:
                            sText = "[3]";
                            break;
                        case 4:
                            sText = "[12]";
                            break;
                        case 5:
                            sText = "[23]";
                            break;
                        case 6:
                            sText = "[13]";
                            break;
                        default:
                            sText = "[123]";
                            break;
                    }
                    MessageBox.Show("Useskill " + sText);
                    break;
                case 3:
                    MessageBox.Show("Use Fireball");
                    break;
                default:
                    break;

            }

         }

        private void fClick(int nCol,int nRow)
        {
            bool bValid = false;
            int nType;

            if (mbFireball)
            {
                if (nCol == mnECol)
                {
                    if (nRow == mnERow)
                    {
                        fShoot(3, nCol, nRow);
                        mnEnemy = 0;
                        mbFireball = false;
                    }
                }
            }

            if (mbSelect)
            {
                mnCol = nCol;
                mnRow = nRow;
                fUpdateStatus();
            }
            else
            {
                switch (mnAction)
                {
                    case 1:
                        nType = fType(mnCol, mnRow);
                        if (nType == 10)
                        {

                        }
                        else
                        {
                            if (nType == 9)
                            {

                            }
                            else
                            {
                                goto exitlabel;
                            }
                        }
                        bValid = fValidPlanar(mnCol, mnRow, nCol, nRow);
                        if (bValid)
                        {
                            fPlace(nCol, nRow, 10);
                            fUpdateDisplay();
                        }
                        break;
                    case 3:
                        fRidmode(nCol, nRow);
                        break;

                }
            }
            exitlabel:;

        }

        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F land.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F sea.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F enemy.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F fireball.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F shoot.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F skill1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F skill2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F skill3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F spawnedstation.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F station.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
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
                default:
                    _pic2 = picture11;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        private void fUpdateStatus()
        {
            lblSelect.Text = "SELECT = (" + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow) + ")";

        }
        private void fReset()
        {
            Random rnd1 = new Random();
            int nStation = rnd1.Next(4, 13);
            int nEnemy = rnd1.Next(4, 9);
            int nCol=0, nRow=0;

            mnCol = 1;
            mnRow = 1;
            mnEnemy = 0;
            mbFireball = false;

            for (int i = 1; i <= 8; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col1[i - 1] = 1;
                }
                else
                {
                    _col1[i - 1] = 2;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col2[i - 1] = 1;
                }
                else
                {
                    _col2[i - 1] = 2;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col3[i - 1] = 1;
                }
                else
                {
                    _col3[i - 1] = 2;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col4[i - 1] = 1;
                }
                else
                {
                    _col4[i - 1] = 2;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col5[i - 1] = 1;
                }
                else
                {
                    _col5[i - 1] = 2;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col6[i - 1] = 1;
                }
                else
                {
                    _col6[i - 1] = 2;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col7[i - 1] = 1;
                }
                else
                {
                    _col7[i - 1] = 2;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col8[i - 1] = 1;
                }
                else
                {
                    _col8[i - 1] = 2;
                }
            }
            for (int i = 1; i <= 8; i++)
            {
                _skill1[i - 1] = rnd1.Next(0, 8);
                _skill2[i - 1] = rnd1.Next(0, 8);
                _skill3[i - 1] = rnd1.Next(0, 8);
                _skill4[i - 1] = rnd1.Next(0, 8);
                _skill5[i - 1] = rnd1.Next(0, 8);
                _skill6[i - 1] = rnd1.Next(0, 8);
                _skill7[i - 1] = rnd1.Next(0, 8);
                _skill8[i - 1] = rnd1.Next(0, 8);
            }

            for (int i = 1; i <= nStation; i++)
            {
                fFree(ref nCol, ref nRow);
                fPlace(nCol, nRow, 10);
            }
            for (int i = 1; i <= nEnemy; i++)
            {
                fFree(ref nCol, ref nRow);
                fPlace(nCol, nRow, 3);
            }

            fUpdateDisplay();
            fUpdateStatus();
        }

        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate=1;

            nType = _col1[0];
            fPeek(nType, nRotate, ref _pic);
            pic11.Image = _pic.Image;
            nType = _col1[1];
            fPeek(nType, nRotate, ref _pic);
            pic12.Image = _pic.Image;
            nType = _col1[2];
            fPeek(nType, nRotate, ref _pic);
            pic13.Image = _pic.Image;
            nType = _col1[3];
            fPeek(nType, nRotate, ref _pic);
            pic14.Image = _pic.Image;
            nType = _col1[4];
            fPeek(nType, nRotate, ref _pic);
            pic15.Image = _pic.Image;
            nType = _col1[5];
            fPeek(nType, nRotate, ref _pic);
            pic16.Image = _pic.Image;
            nType = _col1[6];
            fPeek(nType, nRotate, ref _pic);
            pic17.Image = _pic.Image;
            nType = _col1[7];
            fPeek(nType, nRotate, ref _pic);
            pic18.Image = _pic.Image;

            //2
            nType = _col2[0];
            fPeek(nType, nRotate, ref _pic);
            pic21.Image = _pic.Image;
            nType = _col2[1];
            fPeek(nType, nRotate, ref _pic);
            pic22.Image = _pic.Image;
            nType = _col2[2];
            fPeek(nType, nRotate, ref _pic);
            pic23.Image = _pic.Image;
            nType = _col2[3];
            fPeek(nType, nRotate, ref _pic);
            pic24.Image = _pic.Image;
            nType = _col2[4];
            fPeek(nType, nRotate, ref _pic);
            pic25.Image = _pic.Image;
            nType = _col2[5];
            fPeek(nType, nRotate, ref _pic);
            pic26.Image = _pic.Image;
            nType = _col2[6];
            fPeek(nType, nRotate, ref _pic);
            pic27.Image = _pic.Image;
            nType = _col2[7];
            fPeek(nType, nRotate, ref _pic);
            pic28.Image = _pic.Image;

            //3
            nType = _col3[0];
            fPeek(nType, nRotate, ref _pic);
            pic31.Image = _pic.Image;
            nType = _col3[1];
            fPeek(nType, nRotate, ref _pic);
            pic32.Image = _pic.Image;
            nType = _col3[2];
            fPeek(nType, nRotate, ref _pic);
            pic33.Image = _pic.Image;
            nType = _col3[3];
            fPeek(nType, nRotate, ref _pic);
            pic34.Image = _pic.Image;
            nType = _col3[4];
            fPeek(nType, nRotate, ref _pic);
            pic35.Image = _pic.Image;
            nType = _col3[5];
            fPeek(nType, nRotate, ref _pic);
            pic36.Image = _pic.Image;
            nType = _col3[6];
            fPeek(nType, nRotate, ref _pic);
            pic37.Image = _pic.Image;
            nType = _col3[7];
            fPeek(nType, nRotate, ref _pic);
            pic38.Image = _pic.Image;

            //4
            nType = _col4[0];
            fPeek(nType, nRotate, ref _pic);
            pic41.Image = _pic.Image;
            nType = _col4[1];
            fPeek(nType, nRotate, ref _pic);
            pic42.Image = _pic.Image;
            nType = _col4[2];
            fPeek(nType, nRotate, ref _pic);
            pic43.Image = _pic.Image;
            nType = _col4[3];
            fPeek(nType, nRotate, ref _pic);
            pic44.Image = _pic.Image;
            nType = _col4[4];
            fPeek(nType, nRotate, ref _pic);
            pic45.Image = _pic.Image;
            nType = _col4[5];
            fPeek(nType, nRotate, ref _pic);
            pic46.Image = _pic.Image;
            nType = _col4[6];
            fPeek(nType, nRotate, ref _pic);
            pic47.Image = _pic.Image;
            nType = _col4[7];
            fPeek(nType, nRotate, ref _pic);
            pic48.Image = _pic.Image;

            //5
            nType = _col5[0];
            fPeek(nType, nRotate, ref _pic);
            pic51.Image = _pic.Image;
            nType = _col5[1];
            fPeek(nType, nRotate, ref _pic);
            pic52.Image = _pic.Image;
            nType = _col5[2];
            fPeek(nType, nRotate, ref _pic);
            pic53.Image = _pic.Image;
            nType = _col5[3];
            fPeek(nType, nRotate, ref _pic);
            pic54.Image = _pic.Image;
            nType = _col5[4];
            fPeek(nType, nRotate, ref _pic);
            pic55.Image = _pic.Image;
            nType = _col5[5];
            fPeek(nType, nRotate, ref _pic);
            pic56.Image = _pic.Image;
            nType = _col5[6];
            fPeek(nType, nRotate, ref _pic);
            pic57.Image = _pic.Image;
            nType = _col5[7];
            fPeek(nType, nRotate, ref _pic);
            pic58.Image = _pic.Image;

            //6
            nType = _col6[0];
            fPeek(nType, nRotate, ref _pic);
            pic71.Image = _pic.Image;
            nType = _col6[1];
            fPeek(nType, nRotate, ref _pic);
            pic62.Image = _pic.Image;
            nType = _col6[2];
            fPeek(nType, nRotate, ref _pic);
            pic63.Image = _pic.Image;
            nType = _col6[3];
            fPeek(nType, nRotate, ref _pic);
            pic64.Image = _pic.Image;
            nType = _col6[4];
            fPeek(nType, nRotate, ref _pic);
            pic65.Image = _pic.Image;
            nType = _col6[5];
            fPeek(nType, nRotate, ref _pic);
            pic66.Image = _pic.Image;
            nType = _col6[6];
            fPeek(nType, nRotate, ref _pic);
            pic67.Image = _pic.Image;
            nType = _col6[7];
            fPeek(nType, nRotate, ref _pic);
            pic68.Image = _pic.Image;

            //7
            nType = _col7[0];
            fPeek(nType, nRotate, ref _pic);
            pic61.Image = _pic.Image;
            nType = _col7[1];
            fPeek(nType, nRotate, ref _pic);
            pic72.Image = _pic.Image;
            nType = _col7[2];
            fPeek(nType, nRotate, ref _pic);
            pic73.Image = _pic.Image;
            nType = _col7[3];
            fPeek(nType, nRotate, ref _pic);
            pic74.Image = _pic.Image;
            nType = _col7[4];
            fPeek(nType, nRotate, ref _pic);
            pic75.Image = _pic.Image;
            nType = _col7[5];
            fPeek(nType, nRotate, ref _pic);
            pic76.Image = _pic.Image;
            nType = _col7[6];
            fPeek(nType, nRotate, ref _pic);
            pic77.Image = _pic.Image;
            nType = _col7[7];
            fPeek(nType, nRotate, ref _pic);
            pic78.Image = _pic.Image;

            //8
            nType = _col8[0];
            fPeek(nType, nRotate, ref _pic);
            pic81.Image = _pic.Image;
            nType = _col8[1];
            fPeek(nType, nRotate, ref _pic);
            pic82.Image = _pic.Image;
            nType = _col8[2];
            fPeek(nType, nRotate, ref _pic);
            pic83.Image = _pic.Image;
            nType = _col8[3];
            fPeek(nType, nRotate, ref _pic);
            pic84.Image = _pic.Image;
            nType = _col8[4];
            fPeek(nType, nRotate, ref _pic);
            pic85.Image = _pic.Image;
            nType = _col8[5];
            fPeek(nType, nRotate, ref _pic);
            pic86.Image = _pic.Image;
            nType = _col8[6];
            fPeek(nType, nRotate, ref _pic);
            pic87.Image = _pic.Image;
            nType = _col8[7];
            fPeek(nType, nRotate, ref _pic);
            pic88.Image = _pic.Image;

        }

        private void fPlace(int nCol,int nRow,int nType)
        {
            switch (nCol)
            {
                case 1:
                    _col1[nRow - 1] = nType;
                    break;
                case 2:
                    _col2[nRow - 1] = nType;
                    break;
                case 3:
                    _col3[nRow - 1] = nType;
                    break;
                case 4:
                    _col4[nRow - 1] = nType;
                    break;
                case 5:
                    _col5[nRow - 1] = nType;
                    break;
                case 6:
                    _col6[nRow - 1] = nType;
                    break;
                case 7:
                    _col7[nRow - 1] = nType;
                    break;
                default:
                    _col8[nRow - 1] = nType;
                    break;
            }
        }
        private int fType(int nCol,int nRow)
        {
            switch (nCol)
            {
                case 1:
                    return _col1[nRow - 1];
                case 2:
                    return _col2[nRow - 1];
                case 3:
                    return _col3[nRow - 1];
                case 4:
                    return _col4[nRow - 1];
                case 5:
                    return _col5[nRow - 1];
                case 6:
                    return _col6[nRow - 1];
                case 7:
                    return _col7[nRow - 1];
                default:
                    return _col8[nRow - 1];
            }
        }

        private void fFree(ref int nCol, ref int nRow)
        {
            Random rnd1 = new Random();
            bool bFound = false;
            int nType;

            do
            {
                nCol = rnd1.Next(1, 9);
                nRow = rnd1.Next(1, 9);
                nType = fType(nCol, nRow);
                if (nType <= 2)
                {
                    bFound = true;
                }
            } while (bFound == false);

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mbSelect = false;
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnAction1_Click(object sender, EventArgs e)
        {
            mbSelect = false;
            mnAction = 1;
        }

        private void btnAction2_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nType,nDirection;
            int nSavecol, nSaverow;
            int nCol2, nRow2;

            mbSelect = false;
            mnAction = 2;

            nType = fType(mnCol, mnRow);
            if (nType == 10)
            {

            }
            else
            {
                if (nType == 9)
                {

                }
                else
                {
                    goto exitlabel;
                }
            }

            nSavecol = mnCol;
            nSaverow = mnRow;
            for (int i = 1; i <= 8; i++)
            {
                nDirection = i;
                switch (nDirection)
                {
                    case 1:
                        nCol2 = nSavecol;
                        nRow2 = nSaverow - 1;
                        break;
                    case 2:
                        nCol2 = nSavecol+1;
                        nRow2 = nSaverow - 1;
                        break;
                    case 3:
                        nCol2 = nSavecol+1;
                        nRow2 = nSaverow;
                        break;
                    case 4:
                        nCol2 = nSavecol+1;
                        nRow2 = nSaverow + 1;
                        break;
                    case 5:
                        nCol2 = nSavecol;
                        nRow2 = nSaverow + 1;
                        break;
                    case 6:
                        nCol2 = nSavecol-1;
                        nRow2 = nSaverow + 1;
                        break;
                    case 7:
                        nCol2 = nSavecol-1;
                        nRow2 = nSaverow ;
                        break;
                    default:
                        nCol2 = nSavecol-1;
                        nRow2 = nSaverow-1 ;
                        break;
                }
                if (nCol2 == 0)
                {
                    nCol2 = 8;
                }
                if (nCol2 == 9)
                {
                    nCol2 = 1;
                }
                if (nRow2 == 0)
                {
                    nRow2 = 8;
                }
                if (nRow2 == 9)
                {
                    nRow2 = 1;
                }
                nType = fType(nCol2, nRow2);
                if (nType == 3)
                {
                    goto exitlabel;
                }
                if (nType <= 2)
                {
                    nNumber = rnd1.Next(1, 10);
                    if (nNumber <= 4)
                    {
                        fPlace(nCol2, nRow2, 9);
                    }
                }
            }

            fUpdateDisplay();

            exitlabel:;
        }

        private void btnAction3_Click(object sender, EventArgs e)
        {
            mbSelect = false;
            mnAction = 3;
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

        private void pic15_Click(object sender, EventArgs e)
        {
            fClick(1, 5);
        }

        private void pic16_Click(object sender, EventArgs e)
        {
            fClick(1, 6);
        }

        private void pic17_Click(object sender, EventArgs e)
        {
            fClick(1, 7);
        }

        private void pic18_Click(object sender, EventArgs e)
        {
            fClick(1, 8);
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

        private void pic25_Click(object sender, EventArgs e)
        {
            fClick(2, 5);
        }

        private void pic26_Click(object sender, EventArgs e)
        {
            fClick(2, 6);
        }

        private void pic27_Click(object sender, EventArgs e)
        {
            fClick(2, 7);
        }

        private void pic28_Click(object sender, EventArgs e)
        {
            fClick(2, 8);
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

        private void pic35_Click(object sender, EventArgs e)
        {
            fClick(3, 5);
        }

        private void pic36_Click(object sender, EventArgs e)
        {
            fClick(3, 6);
        }

        private void pic37_Click(object sender, EventArgs e)
        {
            fClick(3, 7);
        }

        private void pic38_Click(object sender, EventArgs e)
        {
            fClick(3, 8);
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

        private void pic45_Click(object sender, EventArgs e)
        {
            fClick(4, 5);
        }

        private void pic46_Click(object sender, EventArgs e)
        {
            fClick(4, 6);
        }

        private void pic47_Click(object sender, EventArgs e)
        {
            fClick(4, 7);
        }

        private void pic48_Click(object sender, EventArgs e)
        {
            fClick(4, 8);
        }

        private void pic51_Click(object sender, EventArgs e)
        {
            fClick(5, 1);
        }

        private void pic52_Click(object sender, EventArgs e)
        {
            fClick(5, 2);
        }

        private void pic53_Click(object sender, EventArgs e)
        {
            fClick(5, 3);
        }

        private void pic54_Click(object sender, EventArgs e)
        {
            fClick(5, 4);
        }

        private void pic55_Click(object sender, EventArgs e)
        {
            fClick(5, 5);
        }

        private void pic56_Click(object sender, EventArgs e)
        {
            fClick(5, 6);
        }

        private void pic57_Click(object sender, EventArgs e)
        {
            fClick(5, 7);
        }

        private void pic58_Click(object sender, EventArgs e)
        {
            fClick(5, 8);
        }

        private void pic61_Click(object sender, EventArgs e)
        {
            fClick(6, 1);
        }

        private void pic62_Click(object sender, EventArgs e)
        {
            fClick(6, 2);
        }

        private void pic63_Click(object sender, EventArgs e)
        {
            fClick(6, 3);
        }

        private void pic64_Click(object sender, EventArgs e)
        {
            fClick(6, 4);
        }

        private void pic65_Click(object sender, EventArgs e)
        {
            fClick(6, 5);
        }

        private void pic66_Click(object sender, EventArgs e)
        {
            fClick(6, 6);
        }

        private void pic67_Click(object sender, EventArgs e)
        {
            fClick(6, 7);
        }

        private void pic68_Click(object sender, EventArgs e)
        {
            fClick(6, 8);
        }

        private void pic71_Click(object sender, EventArgs e)
        {
            fClick(7, 1);
        }

        private void pic72_Click(object sender, EventArgs e)
        {
            fClick(7, 2);
        }

        private void pic73_Click(object sender, EventArgs e)
        {
            fClick(7, 3);
        }

        private void pic74_Click(object sender, EventArgs e)
        {
            fClick(7, 4);
        }

        private void pic75_Click(object sender, EventArgs e)
        {
            fClick(7, 5);
        }

        private void pic76_Click(object sender, EventArgs e)
        {
            fClick(7, 6);
        }

        private void pic77_Click(object sender, EventArgs e)
        {
            fClick(7, 7);
        }

        private void pic78_Click(object sender, EventArgs e)
        {
            fClick(7, 8);
        }

        private void pic81_Click(object sender, EventArgs e)
        {
            fClick(8, 1);
        }

        private void pic82_Click(object sender, EventArgs e)
        {
            fClick(8, 2);
        }

        private void pic83_Click(object sender, EventArgs e)
        {
            fClick(8, 3);
        }

        private void pic84_Click(object sender, EventArgs e)
        {
            fClick(8, 4);
        }

        private void pic85_Click(object sender, EventArgs e)
        {
            fClick(8, 5);
        }

        private void pic86_Click(object sender, EventArgs e)
        {
            fClick(8, 6);
        }

        private void pic87_Click(object sender, EventArgs e)
        {
            fClick(8, 7);
        }

        private void pic88_Click(object sender, EventArgs e)
        {
            fClick(8, 8);
        }

        private void btnSkill2_Click(object sender, EventArgs e)
        {
            if (mnEnemy == 2)
            {
                switch (mnECode)
                {
                    case 2:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 7:
                        break;
                    default:
                        goto exitlabel;
                }
                fShoot(2, mnECol, mnERow);
                mnEnemy = 0;
            }

            exitlabel:;
        }

        private void btnSkill3_Click(object sender, EventArgs e)
        {
            if (mnEnemy == 2)
            {
                switch (mnECode)
                {
                    case 3:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    default:
                        goto exitlabel;
                }
                fShoot(2, mnECol, mnERow);
                mnEnemy = 0;
            }

            exitlabel:;
        }

        private void btnFireball_Click(object sender, EventArgs e)
        {
            if (mnEnemy == 2)
            {
                mbFireball = true;
            }
      }

        private void btnComply_Click(object sender, EventArgs e)
        {
            bool bFound = false;
            int nType;

            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    nType = fType(i, j);
                    if (nType == 3)
                    {
                        bFound = true;
                        goto exitlabel;
                    }
                }

            }

            exitlabel:;
            if (bFound==false)
            {
                fReset();
            }
        }

        private void btnSkill1_Click(object sender, EventArgs e)
        {
            if (mnEnemy == 2)
            {
                switch (mnECode)
                {
                    case 1:
                        break;
                    case 4:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    default:
                        goto exitlabel;
                 }
                fShoot(2, mnECol, mnERow);
                mnEnemy = 0;
            }

            exitlabel:;

        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            if (mnEnemy == 1)
            {
                fShoot(1, mnECol, mnERow);
                mnEnemy = 0;
            }          
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            mbSelect = true;
        }
    }
}

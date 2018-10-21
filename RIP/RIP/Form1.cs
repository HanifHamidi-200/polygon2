using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIP
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
        private int nNumber;
        private int mnCol, mnRow, mnRotate;

           private int fType(int nCol, int nRow)
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
        private void fReset()
        {
            Random rnd1 = new Random();
            int nCount = rnd1.Next(4, 15);
            int nCol, nRow;
            bool bFound = false;

            for (int i = 1; i <= 8; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber >= 3)
                {
                    _col1[i - 1] = 1;
                }
                else
                {
                    _col1[i - 1] = nNumber+1;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber >= 3)
                {
                    _col2[i - 1] = 1;
                }
                else
                {
                    _col2[i - 1] = nNumber + 1;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber >= 3)
                {
                    _col3[i - 1] = 1;
                }
                else
                {
                    _col3[i - 1] = nNumber + 1;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber >= 3)
                {
                    _col4[i - 1] = 1;
                }
                else
                {
                    _col4[i - 1] = nNumber + 1;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber >= 3)
                {
                    _col5[i - 1] = 1;
                }
                else
                {
                    _col5[i - 1] = nNumber + 1;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber >= 3)
                {
                    _col6[i - 1] = 1;
                }
                else
                {
                    _col6[i - 1] = nNumber + 1;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber >= 3)
                {
                    _col7[i - 1] = 1;
                }
                else
                {
                    _col7[i - 1] = nNumber + 1;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber >= 3)
                {
                    _col8[i - 1] = 1;
                }
                else
                {
                    _col8[i - 1] = nNumber + 1;
                }
            }
            for (int i = 1; i <= 8; i++)
            {
                nCount = rnd1.Next(0, 4);
                for (nCol = 0;nCol <= nCount;nCol++)
                {
                    if (nCol != 0)
                    {
                        fPlace(5, nCol, i);
                    }
                }
                nCount = rnd1.Next(0, 4);
                for (nCol = 9; nCol >= 9-nCount; nCol--)
                {
                    if (nCol != 9)
                    {
                        fPlace(5, nCol, i);
                    }
                }
            }

            do
            {
                mnCol = rnd1.Next(1, 9);
                mnRow = rnd1.Next(1, 9);
                mnRotate = rnd1.Next(1, 5);
                if (fType(mnCol, mnRow) <= 4)
                {
                    bFound = true;
                }
            } while (bFound == false);
       
            fUpdateDisplay();
            fUpdateCounter();
        }

        private void fPlace(int nType, int nCol, int nRow)
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

        private void fUpdateCounter()
        {
            PictureBox _pic = new PictureBox();
            int nType = 6, nRotate = mnRotate;

            switch (mnCol)
            {
                case 1:

                    switch (mnRow)
                    {


                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic11.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic12.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic13.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic14.Image = _pic.Image;
                            break;
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic15.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic16.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic17.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic18.Image = _pic.Image;
                            break;
                    }
                    break;
                case 2:

                    switch (mnRow)
                    {


                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic21.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic22.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic23.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic24.Image = _pic.Image;
                            break;
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic25.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic26.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic27.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic28.Image = _pic.Image;
                            break;
                    }
                    break;
                case 3:

                    switch (mnRow)
                    {


                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic31.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic32.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic33.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic34.Image = _pic.Image;
                            break;
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic35.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic36.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic37.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic38.Image = _pic.Image;
                            break;
                    }
                    break;
                case 4:

                    switch (mnRow)
                    {


                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic41.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic42.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic43.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic44.Image = _pic.Image;
                            break;
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic45.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic46.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic47.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic48.Image = _pic.Image;
                            break;
                    }
                    break;
                case 5:

                    switch (mnRow)
                    {


                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic51.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic52.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic53.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic54.Image = _pic.Image;
                            break;
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic55.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic56.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic57.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic58.Image = _pic.Image;
                            break;
                    }
                    break;
                case 6:

                    switch (mnRow)
                    {


                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic61.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic62.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic63.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic64.Image = _pic.Image;
                            break;
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic65.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic66.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic67.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic68.Image = _pic.Image;
                            break;
                    }
                    break;
                case 7:

                    switch (mnRow)
                    {


                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic71.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic72.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic73.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic74.Image = _pic.Image;
                            break;
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic75.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic76.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic77.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic78.Image = _pic.Image;
                            break;
                    }
                    break;
                default:

                    switch (mnRow)
                    {


                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic81.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic82.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic83.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic84.Image = _pic.Image;
                            break;
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic85.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic86.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic87.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic88.Image = _pic.Image;
                            break;
                    }
                    break;
            }
        }
        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate = 1;

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


        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F floor.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F box1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F box2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F box3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F rip.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F YOU.png"),
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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fReset();
        }

    
        private void btnQNext_Click_1(object sender, EventArgs e)
        {
            fReset();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

     }
}



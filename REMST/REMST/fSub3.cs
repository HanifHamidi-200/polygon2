using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMST
{
    public partial class fSub3 : Form
    {
        private List<int> _col1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private int nNumber;
        private int mnCol, mnRow,mnRotate;
     
        private void fReset()
        {
            Random rnd1 = new Random();
            int nBridge = rnd1.Next(4, 9);
         
            for (int i = 1; i <= 8; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col1[i - 1] = 2;
                }
                else
                {
                    _col1[i - 1] = 4;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col2[i - 1] = 2;
                }
                else
                {
                    _col2[i - 1] = 4;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col3[i - 1] = 2;
                }
                else
                {
                    _col3[i - 1] = 4;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col4[i - 1] = 2;
                }
                else
                {
                    _col4[i - 1] = 4;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col5[i - 1] = 2;
                }
                else
                {
                    _col5[i - 1] = 4;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col6[i - 1] = 2;
                }
                else
                {
                    _col6[i - 1] = 4;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col7[i - 1] = 2;
                }
                else
                {
                    _col7[i - 1] = 4;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col8[i - 1] = 2;
                }
                else
                {
                    _col8[i - 1] = 4;
                }
                _rotate1[i - 1] = rnd1.Next(1, 5);
                _rotate2[i - 1] = rnd1.Next(1, 5);
                _rotate3[i - 1] = rnd1.Next(1, 5);
                _rotate4[i - 1] = rnd1.Next(1, 5);
                _rotate5[i - 1] = rnd1.Next(1, 5);
                _rotate6[i - 1] = rnd1.Next(1, 5);
                _rotate7[i - 1] = rnd1.Next(1, 5);
                _rotate8[i - 1] = rnd1.Next(1, 5);
            }

            for (int i = 1; i <= nBridge; i++)
            {
                fDrawBridge();
            }
        
            mnCol = rnd1.Next(1, 9);
            mnRow = rnd1.Next(1, 9);
            mnRotate = rnd1.Next(1, 5);

            fUpdateDisplay();
            fUpdateYOU();
        }

        private void fDrawLine(int nCol1,int nRow1,int nCol2,int nRow2)
        {
            Random rnd1 = new Random();
            bool bFound = false;
            int nCol3 = nCol1, nRow3 = nRow1;

            fPlace(nCol1, nRow1, 11);

            do
            {
                if (nRow2 > nRow3)
                {
                    nNumber = rnd1.Next(1, 10);
                    if (nNumber <= 6)
                    {
                        nRow3 += 1;
                        fPlace(nCol3, nRow3, 11);
                    }
                    else
                    {
                        if (nCol2 < nCol3)
                        {
                            nCol3 -= 1;
                            fPlace(nCol3, nRow3, 11);
                        }
                        else
                        {
                            nCol3 += 1;
                            fPlace(nCol3, nRow3, 11);
                        }
                    }
                }
                else
                {
                    if (nCol2 < nCol3)
                    {
                        nCol3 -= 1;
                        fPlace(nCol3, nRow3, 11);
                    }
                    else
                    {
                        nCol3 += 1;
                        fPlace(nCol3, nRow3, 11);
                    }
                }
                if (nCol3 == nCol2)
                {
                    if (nRow3 == nRow2)
                    {
                        bFound = true;
                    }
                }
            } while (bFound == false);
        }
        private void fDrawBridge()
        {
            Random rnd1 = new Random();
            string sText = "1234";
            int nSide1 = rnd1.Next(1, 5);
            int nPos = rnd1.Next(1, 4);
            int nSide2;
            int nCol1=0, nRow1=0, nCol2=0, nRow2=0;

            sText = sText.Substring(1, nSide1 - 1) + sText.Substring(nSide1, 4 - nSide1);
            nSide2 = Convert.ToInt32(sText.Substring(nPos - 1, 1));

            switch (nSide1)
            {
                case 1:
                    nCol1 = rnd1.Next(1, 9);
                    nRow1 = 1;
                    break;
                case 2:
                    nCol1 = 8;
                    nRow1 = rnd1.Next(1, 9);
                    break;
                case 3:
                    nCol1 = rnd1.Next(1, 9);
                    nRow1 = 8;
                    break;
                case 4:
                    nCol1 = 1;
                    nRow1 = rnd1.Next(1, 9);
                    break;

            }
            switch (nSide2)
            {
                case 1:
                    nCol2 = rnd1.Next(1, 9);
                    nRow2 = 1;
                    break;
                case 2:
                    nCol2 = 8;
                    nRow2 = rnd1.Next(1, 9);
                    break;
                case 3:
                    nCol2 = rnd1.Next(1, 9);
                    nRow2 = 8;
                    break;
                case 4:
                    nCol2 = 1;
                    nRow2 = rnd1.Next(1, 9);
                    break;

            }

            if (nRow2 < nRow1)
            {
                fSwap(ref nCol1, ref nRow1, ref nCol2, ref nRow2);
            }
            fDrawLine(nCol1, nRow1, nCol2, nRow2);
        }
        private void fSwap(ref int nCol1,ref int nRow1,ref int nCol2,ref int nRow2)
        {
            int nSavecol = nCol1, nSaverow = nRow1;

            nCol1 = nCol2;
            nRow1 = nRow2;
            nCol2 = nSavecol;
            nRow2 = nSaverow;
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

        private void fPlace(int nCol, int nRow, int nType)
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

        private void fUpdateYOU()
        {

            PictureBox _pic = new PictureBox();
            int nType = 10, nRotate = mnRotate;

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

   
        private void btnQNext_Click_1(object sender, EventArgs e)
        {
            fReset();

        }


        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate;

            nType = _col1[0];
            nRotate = _rotate1[0];
            fPeek(nType, nRotate, ref _pic);
            pic11.Image = _pic.Image;
            nType = _col1[1];
            nRotate = _rotate1[1];
            fPeek(nType, nRotate, ref _pic);
            pic12.Image = _pic.Image;
            nType = _col1[2];
            nRotate = _rotate1[2];
            fPeek(nType, nRotate, ref _pic);
            pic13.Image = _pic.Image;
            nType = _col1[3];
            nRotate = _rotate1[3];
            fPeek(nType, nRotate, ref _pic);
            pic14.Image = _pic.Image;
            nType = _col1[4];
            nRotate = _rotate1[4];
            fPeek(nType, nRotate, ref _pic);
            pic15.Image = _pic.Image;
            nType = _col1[5];
            nRotate = _rotate1[5];
            fPeek(nType, nRotate, ref _pic);
            pic16.Image = _pic.Image;
            nType = _col1[6];
            nRotate = _rotate1[6];
            fPeek(nType, nRotate, ref _pic);
            pic17.Image = _pic.Image;
            nType = _col1[7];
            nRotate = _rotate1[7];
            fPeek(nType, nRotate, ref _pic);
            pic18.Image = _pic.Image;


            //2

            nType = _col2[0];
            nRotate = _rotate2[0];
            fPeek(nType, nRotate, ref _pic);
            pic21.Image = _pic.Image;
            nType = _col2[1];
            nRotate = _rotate2[1];
            fPeek(nType, nRotate, ref _pic);
            pic22.Image = _pic.Image;
            nType = _col2[2];
            nRotate = _rotate2[2];
            fPeek(nType, nRotate, ref _pic);
            pic23.Image = _pic.Image;
            nType = _col2[3];
            nRotate = _rotate2[3];
            fPeek(nType, nRotate, ref _pic);
            pic24.Image = _pic.Image;
            nType = _col2[4];
            nRotate = _rotate2[4];
            fPeek(nType, nRotate, ref _pic);
            pic25.Image = _pic.Image;
            nType = _col2[5];
            nRotate = _rotate2[5];
            fPeek(nType, nRotate, ref _pic);
            pic26.Image = _pic.Image;
            nType = _col2[6];
            nRotate = _rotate2[6];
            fPeek(nType, nRotate, ref _pic);
            pic27.Image = _pic.Image;
            nType = _col2[7];
            nRotate = _rotate2[7];
            fPeek(nType, nRotate, ref _pic);
            pic28.Image = _pic.Image;


            //3

            nType = _col3[0];
            nRotate = _rotate3[0];
            fPeek(nType, nRotate, ref _pic);
            pic31.Image = _pic.Image;
            nType = _col3[1];
            nRotate = _rotate3[1];
            fPeek(nType, nRotate, ref _pic);
            pic32.Image = _pic.Image;
            nType = _col3[2];
            nRotate = _rotate3[2];
            fPeek(nType, nRotate, ref _pic);
            pic33.Image = _pic.Image;
            nType = _col3[3];
            nRotate = _rotate3[3];
            fPeek(nType, nRotate, ref _pic);
            pic34.Image = _pic.Image;
            nType = _col3[4];
            nRotate = _rotate3[4];
            fPeek(nType, nRotate, ref _pic);
            pic35.Image = _pic.Image;
            nType = _col3[5];
            nRotate = _rotate3[5];
            fPeek(nType, nRotate, ref _pic);
            pic36.Image = _pic.Image;
            nType = _col3[6];
            nRotate = _rotate3[6];
            fPeek(nType, nRotate, ref _pic);
            pic37.Image = _pic.Image;
            nType = _col3[7];
            nRotate = _rotate3[7];
            fPeek(nType, nRotate, ref _pic);
            pic38.Image = _pic.Image;


            //4

            nType = _col4[0];
            nRotate = _rotate4[0];
            fPeek(nType, nRotate, ref _pic);
            pic41.Image = _pic.Image;
            nType = _col4[1];
            nRotate = _rotate4[1];
            fPeek(nType, nRotate, ref _pic);
            pic42.Image = _pic.Image;
            nType = _col4[2];
            nRotate = _rotate4[2];
            fPeek(nType, nRotate, ref _pic);
            pic43.Image = _pic.Image;
            nType = _col4[3];
            nRotate = _rotate4[3];
            fPeek(nType, nRotate, ref _pic);
            pic44.Image = _pic.Image;
            nType = _col4[4];
            nRotate = _rotate4[4];
            fPeek(nType, nRotate, ref _pic);
            pic45.Image = _pic.Image;
            nType = _col4[5];
            nRotate = _rotate4[5];
            fPeek(nType, nRotate, ref _pic);
            pic46.Image = _pic.Image;
            nType = _col4[6];
            nRotate = _rotate4[6];
            fPeek(nType, nRotate, ref _pic);
            pic47.Image = _pic.Image;
            nType = _col4[7];
            nRotate = _rotate4[7];
            fPeek(nType, nRotate, ref _pic);
            pic48.Image = _pic.Image;


            //5

            nType = _col5[0];
            nRotate = _rotate5[0];
            fPeek(nType, nRotate, ref _pic);
            pic51.Image = _pic.Image;
            nType = _col5[1];
            nRotate = _rotate5[1];
            fPeek(nType, nRotate, ref _pic);
            pic52.Image = _pic.Image;
            nType = _col5[2];
            nRotate = _rotate5[2];
            fPeek(nType, nRotate, ref _pic);
            pic53.Image = _pic.Image;
            nType = _col5[3];
            nRotate = _rotate5[3];
            fPeek(nType, nRotate, ref _pic);
            pic54.Image = _pic.Image;
            nType = _col5[4];
            nRotate = _rotate5[4];
            fPeek(nType, nRotate, ref _pic);
            pic55.Image = _pic.Image;
            nType = _col5[5];
            nRotate = _rotate5[5];
            fPeek(nType, nRotate, ref _pic);
            pic56.Image = _pic.Image;
            nType = _col5[6];
            nRotate = _rotate5[6];
            fPeek(nType, nRotate, ref _pic);
            pic57.Image = _pic.Image;
            nType = _col5[7];
            nRotate = _rotate5[7];
            fPeek(nType, nRotate, ref _pic);
            pic58.Image = _pic.Image;


            //6

            nType = _col6[0];
            nRotate = _rotate6[0];
            fPeek(nType, nRotate, ref _pic);
            pic61.Image = _pic.Image;
            nType = _col6[1];
            nRotate = _rotate6[1];
            fPeek(nType, nRotate, ref _pic);
            pic62.Image = _pic.Image;
            nType = _col6[2];
            nRotate = _rotate6[2];
            fPeek(nType, nRotate, ref _pic);
            pic63.Image = _pic.Image;
            nType = _col6[3];
            nRotate = _rotate6[3];
            fPeek(nType, nRotate, ref _pic);
            pic64.Image = _pic.Image;
            nType = _col6[4];
            nRotate = _rotate6[4];
            fPeek(nType, nRotate, ref _pic);
            pic65.Image = _pic.Image;
            nType = _col6[5];
            nRotate = _rotate6[5];
            fPeek(nType, nRotate, ref _pic);
            pic66.Image = _pic.Image;
            nType = _col6[6];
            nRotate = _rotate6[6];
            fPeek(nType, nRotate, ref _pic);
            pic67.Image = _pic.Image;
            nType = _col6[7];
            nRotate = _rotate6[7];
            fPeek(nType, nRotate, ref _pic);
            pic68.Image = _pic.Image;


            //7

            nType = _col7[0];
            nRotate = _rotate7[0];
            fPeek(nType, nRotate, ref _pic);
            pic71.Image = _pic.Image;
            nType = _col7[1];
            nRotate = _rotate7[1];
            fPeek(nType, nRotate, ref _pic);
            pic72.Image = _pic.Image;
            nType = _col7[2];
            nRotate = _rotate7[2];
            fPeek(nType, nRotate, ref _pic);
            pic73.Image = _pic.Image;
            nType = _col7[3];
            nRotate = _rotate7[3];
            fPeek(nType, nRotate, ref _pic);
            pic74.Image = _pic.Image;
            nType = _col7[4];
            nRotate = _rotate7[4];
            fPeek(nType, nRotate, ref _pic);
            pic75.Image = _pic.Image;
            nType = _col7[5];
            nRotate = _rotate7[5];
            fPeek(nType, nRotate, ref _pic);
            pic76.Image = _pic.Image;
            nType = _col7[6];
            nRotate = _rotate7[6];
            fPeek(nType, nRotate, ref _pic);
            pic77.Image = _pic.Image;
            nType = _col7[7];
            nRotate = _rotate7[7];
            fPeek(nType, nRotate, ref _pic);
            pic78.Image = _pic.Image;


            //8

            nType = _col8[0];
            nRotate = _rotate8[0];
            fPeek(nType, nRotate, ref _pic);
            pic81.Image = _pic.Image;
            nType = _col8[1];
            nRotate = _rotate8[1];
            fPeek(nType, nRotate, ref _pic);
            pic82.Image = _pic.Image;
            nType = _col8[2];
            nRotate = _rotate8[2];
            fPeek(nType, nRotate, ref _pic);
            pic83.Image = _pic.Image;
            nType = _col8[3];
            nRotate = _rotate8[3];
            fPeek(nType, nRotate, ref _pic);
            pic84.Image = _pic.Image;
            nType = _col8[4];
            nRotate = _rotate8[4];
            fPeek(nType, nRotate, ref _pic);
            pic85.Image = _pic.Image;
            nType = _col8[5];
            nRotate = _rotate8[5];
            fPeek(nType, nRotate, ref _pic);
            pic86.Image = _pic.Image;
            nType = _col8[6];
            nRotate = _rotate8[6];
            fPeek(nType, nRotate, ref _pic);
            pic87.Image = _pic.Image;
            nType = _col8[7];
            nRotate = _rotate8[7];
            fPeek(nType, nRotate, ref _pic);
            pic88.Image = _pic.Image;

        }
        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F back1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F back2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F back3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F back4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F arrow1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F arrow2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F bridge.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F crater.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F gun.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F methanesea.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F path.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F powersourcecollecter.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F sit1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F sit2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F YOU.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
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
                default:
                    _pic2 = picture16;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }
        public fSub3()
        {
            InitializeComponent();
        }

        private void fSub3_Load(object sender, EventArgs e)
        {

        }
    }
}

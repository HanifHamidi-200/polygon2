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
    public partial class fSub3 : Form
    {
        private String msShuffle1;
        private String msShuffle2;
        private String msShuffle3;
        private String msEmbossed;
        private int nNumber;
        private List<int> _hpmax = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _hpnow = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int mnConsolidation, mnTradeAgreement;
        private int mnSelect;
        private int mnCol, mnRow;
        private int mnTick;
        private bool mbDeploy;
        private int mnDeployCol, mnDeployRow;
        private bool mbFast;
        private void fNav(int nMode)
        {
            int nCol = mnDeployCol;
            int nRow = mnDeployRow;
            int nPos;
            int nType;
            String sTwo=null;

            if (!mbDeploy)
            {
                goto lineend;
            }

            switch (nMode)
            {
                case 1:
                    nRow -= 1;
                    break;
                case 2:
                    nCol += 1;
                    break;
                case 3:
                    nRow += 1;
                    break;
                default:
                    nCol -= 1;
                    break;
            }

            if (nRow < 1)
            {
                goto lineend;
            }
            if (nRow >6)
            {
                goto lineend;
            }
            if (nCol < 1)
            {
                goto lineend;
            }
            if (nCol > 6)
            {
                goto lineend;
            }

            nPos = (nCol - 1) * 6 + nRow;
            nType = fHoletype(msShuffle2, nPos);

            msEmbossed = null;
            for (int i = 1; i <= 36; i++)
            {
                msEmbossed = msEmbossed + "0";
            }

            switch (nType)
            {
                case 5:
                    fHit(nCol, nRow);
                    fPlace3("1", nPos);
                    mnTick = 2;
                    timer1.Enabled = true;
                    break;
                case 6:
                    fHit(nCol, nRow);
                    fPlace3("1", nPos);
                    mnTick = 2;
                    timer1.Enabled = true;
                    break;
                case 7:
                    fHit(nCol, nRow);
                    fPlace3("1", nPos);
                    mnTick = 2;
                    timer1.Enabled = true;
                    break;
                default:
                    mnDeployCol = nCol;
                    mnDeployRow = nRow;
                    fUpdateDisplay();
                    break;
            }
        lineend:;
        }
        private void fConsolidation()
        {
            Random rnd1 = new Random();
            int nCol, nRow;
            int nPos = 0;

             msEmbossed = null;
            for(int i = 1; i <= 36; i++)
            {
                 msEmbossed = msEmbossed + "0";
            }

            if (mbFast)
            {
                nCol = mnCol;
                for (int i = 1; i <= 6; i++)
                {
                    nRow = i;
                    nPos = (nCol - 1) * 6 + nRow;
                    fPlace3("1", nPos);
                }
                nRow = mnRow;
                for (int i = 1; i <= 6; i++)
                {
                    nCol = i;
                    nPos = (nCol - 1) * 6 + nRow;
                    fPlace3("1", nPos);
                }


            }
            else
            {

            
            nNumber = rnd1.Next(1, 10);

                if (nNumber <= 5)
                {
                    nCol = mnCol;
                    for (int i = 1; i <= 6; i++)
                    {
                        nRow = i;
                        nPos = (nCol - 1) * 6 + nRow;
                        fPlace3("1", nPos);
                    }
                }
                else
                {
                    nRow = mnRow;
                    for (int i = 1; i <= 6; i++)
                    {
                        nCol = i;
                        nPos = (nCol - 1) * 6 + nRow;
                        fPlace3("1", nPos);
                    }

                }
            }
            mnTick = 1;
            timer1.Enabled = true;
        }

    private void fTradeAgreement()
        {
            Random rnd1 = new Random();
            int nCol, nRow;
            int nPos = 0;

            msEmbossed = null;
            for (int i = 1; i <= 36; i++)
            {
                msEmbossed = msEmbossed + "0";
            }

            if (mbFast)
            {
                nCol = mnCol;
                nRow = mnRow;
                for (int i = nCol - 2; i <= nCol+2; i++)
                {
                    for (int j = nRow-2; j <= nRow + 2; j++)
                    {
                        if (i < 1)
                        {

                        }
                        else
                        {
                            if (i > 6)
                            {

                            }
                            else
                            {
                                if (j < 1)
                                {

                                }
                                else
                                {
                                    if (j > 6)
                                    {

                                    }
                                    else
                                    {
                                        nPos = (i - 1) * 6 + j;
                                        fPlace3("1", nPos);
                                    }
                                }
                            }
                        }
                    }
                }


            }
            else
            {


                nNumber = rnd1.Next(1, 5);

                nCol = mnCol;
                nRow = mnRow;
                switch (nNumber)
                {
                    case 1:
                        for (int i = nCol - 2; i <= nCol; i++)
                        {
                            for (int j = nRow - 2; j <= nRow; j++)
                            {
                                if (i < 1)
                                {

                                }
                                else
                                {
                                    if (i > 6)
                                    {

                                    }
                                    else
                                    {
                                        if (j < 1)
                                        {

                                        }
                                        else
                                        {
                                            if (j > 6)
                                            {

                                            }
                                            else
                                            {
                                                nPos = (i - 1) * 6 + j;
                                                fPlace3("1", nPos);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 2:
                        for (int i = nCol; i <= nCol + 2; i++)
                        {
                            for (int j = nRow - 2; j <= nRow; j++)
                            {
                                if (i < 1)
                                {

                                }
                                else
                                {
                                    if (i > 6)
                                    {

                                    }
                                    else
                                    {
                                        if (j < 1)
                                        {

                                        }
                                        else
                                        {
                                            if (j > 6)
                                            {

                                            }
                                            else
                                            {
                                                nPos = (i - 1) * 6 + j;
                                                fPlace3("1", nPos);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 3:
                        for (int i = nCol; i <= nCol + 2; i++)
                        {
                            for (int j = nRow; j <= nRow + 2; j++)
                            {
                                if (i < 1)
                                {

                                }
                                else
                                {
                                    if (i > 6)
                                    {

                                    }
                                    else
                                    {
                                        if (j < 1)
                                        {

                                        }
                                        else
                                        {
                                            if (j > 6)
                                            {

                                            }
                                            else
                                            {
                                                nPos = (i - 1) * 6 + j;
                                                fPlace3("1", nPos);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    default:
                        for (int i = nCol - 2; i <= nCol; i++)
                        {
                            for (int j = nRow; j <= nRow + 2; j++)
                            {
                                if (i < 1)
                                {

                                }
                                else
                                {
                                    if (i > 6)
                                    {

                                    }
                                    else
                                    {
                                        if (j < 1)
                                        {

                                        }
                                        else
                                        {
                                            if (j > 6)
                                            {

                                            }
                                            else
                                            {
                                                nPos = (i - 1) * 6 + j;
                                                fPlace3("1", nPos);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;

                }
            }
            mnTick = 1;

            timer1.Enabled = true;

        }
        private void fClick(int nCol,int nRow)
        {
            int nPos = (nCol - 1) * 6 + nRow;
            int nType = fHoletype(msShuffle2, nPos);

            if (fra1.Visible)
            {
                if (mbDeploy == false)
                {
                    if (nType <= 2)
                    {
                        mbDeploy = true;
                        mnDeployCol = nCol;
                        mnDeployRow = nRow;
                        fUpdateDisplay();
                    }
                    else
                    {
                        goto lineend;
                    }
                }
                else
                {
                    goto lineend;
                }
            }
            switch(mnSelect){
                case 1:
                    if (nType==3)
                    {

                    }
                    else
                    {
                        if (mnConsolidation == 0)
                        {


                        }
                        else
                        {
                            mnCol = nCol;
                            mnRow = nRow;
                            mnConsolidation -= 1;

                            fConsolidation();
                            fUpdateStatus();
                        }

                    }
                    break;
                case 2:
                    if (nType ==3)
                    {

                    }
                    else
                    {
                        if (mnTradeAgreement == 0)
                        {

                        }
                        else
                        {
                            mnCol = nCol;
                            mnRow = nRow;
                            mnTradeAgreement -= 1;
                            fTradeAgreement();
                            fUpdateStatus();
                        }

                    }
                    break;
                default:
                    break;

            }

        lineend:;
        }

        private void fHit(int nCol,int nRow)
        {
            Random rnd1 = new Random();
            int nPos = (nCol - 1) * 6 + nRow;
            int nType = fHoletype(msShuffle3, nPos);
            int nAmount = rnd1.Next(10, 41);
            String sText;
            String sTwo;

            if (nAmount > _hpnow[nType - 1])
            {
                nAmount = _hpnow[nType - 1];
            }
            _hpnow[nType - 1] -= nAmount;
            sText = "HIT ENEMY" + Convert.ToString(nType) + " for " + Convert.ToString(nAmount) + "HP";
            lst1.Items.Add(sText);
            if (_hpnow[nType - 1] < 1)
            {
                sText = "ENEMY is now DEAD";
                lst1.Items.Add(sText);
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    sTwo = "01";
                }
                else
                {
                    sTwo = "02";
                }
                fPlace(sTwo, nPos);
            }
            else
            {
                sText = "ENEMY at " + _hpnow[nType - 1] + "/" + _hpmax[nType - 1];
                lst1.Items.Add(sText);
            }
        }
        private void fReset()
        {
            Random rnd1 = new Random();
            int nValue;
            String sTwo = null;
            int nHAX = rnd1.Next(4, 15);
            int nCol = 0, nRow = 0;
            int nPos = 0;

            msShuffle1 = "010203040506070809101112131415161718192021222324252627282930213233343536";
            msShuffle2 = null;
            msShuffle3 = null;
            mnConsolidation = rnd1.Next(2, 11);
            mnTradeAgreement = rnd1.Next(4, 13);
            mnSelect = 0;
            timer1.Enabled = false;
            fra1.Visible = false;
            mbDeploy = false;
            mnDeployCol = 1;
            mnDeployRow = 1;
            mbFast = false;

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
            for (int i = 1; i <= 14; i++)
            {
                _hpmax[i - 1] = 0;
                _hpnow[i - 1] = 0;
            }
            for (int i = 1; i <= 36; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    nValue = 1;
                }
                else
                {
                    nValue = 2;
                }            
                sTwo = Convert.ToString(nValue);
                if (sTwo.Length == 1)
                {
                    sTwo = "0" + sTwo;
                    msShuffle2 = msShuffle2 + sTwo;
                }
                sTwo = "00";
                msShuffle3 = msShuffle3 + sTwo;
            }

            for (int i = 1; i <= nHAX; i++)
            {
                fFree(ref nCol, ref nRow);
                nPos = (nCol - 1) * 6 + nRow;
                nNumber = rnd1.Next(1, 10);
                switch (nNumber)
                {
                    case 1:
                        sTwo = "05";
                         break;
                    case 2:
                        sTwo = "05";
                        break;
                    case 3:
                        sTwo = "05";
                        break;
                    case 4:
                        sTwo = "06";
                        break;
                    case 5:
                        sTwo = "06";
                        break;
                    case 6:
                        sTwo = "06";
                        break;
                    default:
                        sTwo = "07";
                        break;
                }
                fPlace(sTwo, nPos);
                switch (sTwo)
                {
                    case "05":
                        _hpmax[i - 1] = rnd1.Next(20,41);
                        break;
                    case "06":
                        _hpmax[i - 1] = rnd1.Next(40, 61);
                        break;
                    default:
                        _hpmax[i - 1] = rnd1.Next(60, 81);
                        break;
                }
                _hpnow[i - 1] = _hpmax[i-1];
                sTwo = Convert.ToString(i);
                if (sTwo.Length == 1)
                {
                    sTwo = "0" + sTwo;
                }
              fPlace2(sTwo, nPos);
             }

            for (int i = 1; i <= 4; i++)
            {
                fFree(ref nCol, ref nRow);
                nPos = (nCol - 1) * 6 + nRow;
                fPlace("03", nPos);
            }
         
            fUpdateDisplay();
            fUpdateStatus();
        }

        private void fUpdateStatus()
        {
            btn1.Text = "Consolidation = " + Convert.ToString(mnConsolidation);
            btn2.Text = "TradeAgreement = " + Convert.ToString(mnTradeAgreement);
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
                Image = Image.FromFile(@"F bush.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F consolidation.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F hax1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F hax2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F hax3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F hit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F TradeAgreement.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F TruckLeavers2.png"),
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
        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate = 1;

            //1
            nType = fHoletype2(msShuffle2, 1);
            fPeek(nType, nRotate, ref _pic);
            pic11.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 2);
            fPeek(nType, nRotate, ref _pic);
            pic12.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 3);
            fPeek(nType, nRotate, ref _pic);
            pic13.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 4);
            fPeek(nType, nRotate, ref _pic);
            pic14.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 5);
            fPeek(nType, nRotate, ref _pic);
            pic15.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 6);
            fPeek(nType, nRotate, ref _pic);
            pic16.Image = _pic.Image;

            //2
             nType = fHoletype2(msShuffle2, 7);
            fPeek(nType, nRotate, ref _pic);
            pic21.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 8);
            fPeek(nType, nRotate, ref _pic);
            pic22.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 9);
            fPeek(nType, nRotate, ref _pic);
            pic23.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 10);
            fPeek(nType, nRotate, ref _pic);
            pic24.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 11);
            fPeek(nType, nRotate, ref _pic);
            pic25.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 12);
            fPeek(nType, nRotate, ref _pic);
            pic26.Image = _pic.Image;

            //3
            nType = fHoletype2(msShuffle2, 13);
            fPeek(nType, nRotate, ref _pic);
            pic31.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 14);
            fPeek(nType, nRotate, ref _pic);
            pic32.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 15);
            fPeek(nType, nRotate, ref _pic);
            pic33.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 16);
            fPeek(nType, nRotate, ref _pic);
            pic34.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 17);
            fPeek(nType, nRotate, ref _pic);
            pic35.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 18);
            fPeek(nType, nRotate, ref _pic);
            pic36.Image = _pic.Image;


            //4
            nType = fHoletype2(msShuffle2, 19);
            fPeek(nType, nRotate, ref _pic);
            pic41.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 20);
            fPeek(nType, nRotate, ref _pic);
            pic42.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 21);
            fPeek(nType, nRotate, ref _pic);
            pic43.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 22);
            fPeek(nType, nRotate, ref _pic);
            pic44.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 23);
            fPeek(nType, nRotate, ref _pic);
            pic45.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 24);
            fPeek(nType, nRotate, ref _pic);
            pic46.Image = _pic.Image;

            //5
            nType = fHoletype2(msShuffle2, 25);
            fPeek(nType, nRotate, ref _pic);
            pic51.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 26);
            fPeek(nType, nRotate, ref _pic);
            pic52.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 27);
            fPeek(nType, nRotate, ref _pic);
            pic53.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 28);
            fPeek(nType, nRotate, ref _pic);
            pic54.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 29);
            fPeek(nType, nRotate, ref _pic);
            pic55.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 30);
            fPeek(nType, nRotate, ref _pic);
            pic56.Image = _pic.Image;

            //6
            nType = fHoletype2(msShuffle2, 31);
            fPeek(nType, nRotate, ref _pic);
            pic61.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 32);
            fPeek(nType, nRotate, ref _pic);
            pic62.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 33);
            fPeek(nType, nRotate, ref _pic);
            pic63.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 34);
            fPeek(nType, nRotate, ref _pic);
            pic64.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 35);
            fPeek(nType, nRotate, ref _pic);
            pic65.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 36);
            fPeek(nType, nRotate, ref _pic);
            pic66.Image = _pic.Image;

        }

        private void fPlace(String sText,int nPos)
        {
            msShuffle2 = msShuffle2.Substring(0, nPos * 2 - 2) + sText + msShuffle2.Substring(nPos * 2, (36 - nPos) * 2);
        }
        private void fPlace2(String sText, int nPos)
        {
            msShuffle3 = msShuffle3.Substring(0, nPos * 2 - 2) + sText + msShuffle3.Substring(nPos * 2, (36 - nPos) * 2);
        }
        private void fPlace3(String sText, int nPos)
        {
            msEmbossed = msEmbossed.Substring(0, nPos  - 1) + sText + msEmbossed.Substring(nPos , (36 - nPos) );
        }

        private int fHoletype(String sShuffle, int nSquare)
        {
            int nType = 0;

            nType = Convert.ToInt32(sShuffle.Substring(nSquare * 2 - 2, 2));
            return nType;
        }

        private void fCoordinates(int nSquare,ref int nCol,ref int nRow)
        {
            nCol = 1;

            if (nSquare > 6)
            {
                do
                {
                    nSquare -= 6;
                    nCol += 1;
                } while (nSquare > 6);

            }
            nRow = nSquare;
        }
        private int fHoletype2(String sShuffle, int nSquare)
        {
            int nType = 0;
            int nCol = 0,nRow = 0;

            nType = Convert.ToInt32(sShuffle.Substring(nSquare * 2 - 2, 2));
            if (mbDeploy)
            {
                fCoordinates(nSquare, ref nCol, ref nRow);
                if (nCol == mnDeployCol)
                {
                    if (nRow == mnDeployRow)
                    {
                        nType = 10;
                    }
                }
            }
            if (timer1.Enabled)
            {
                switch (mnTick)
                {
                    case 0:
                        break;
                    case 1:
                        if (msEmbossed.Substring(nSquare - 1, 1) == "1")
                        {
                            if (mnSelect == 1)
                            {
                                nType = 4;
                            }
                            else
                            {
                                nType = 9;
                            }
                        }
                        break;
                    case 2:
                        if (msEmbossed.Substring(nSquare - 1, 1) == "1")
                        {
                            switch (nType)
                            {
                                case 5:
                                    nType = 8;
                                    fCoordinates(nSquare, ref nCol, ref nRow);
                                    fHit(nCol, nRow);
                                    break;
                                case 6:
                                    nType = 8;
                                    fCoordinates(nSquare, ref nCol, ref nRow);
                                    fHit(nCol, nRow);
                                    break;
                                case 7:
                                    nType = 8;
                                    fCoordinates(nSquare, ref nCol, ref nRow);
                                    fHit(nCol, nRow);
                                    break;
                                default:
                                    break;
                            }
                        }
                         break;
                    default:
                        break;
                }
            }
            return nType;
        }

        private void fFree(ref int nCol,ref int nRow)
        {
            Random rnd1 = new Random();
            bool bFound = false;
            int nType = 0,nPos=0;

            do
            {
                nCol = rnd1.Next(1, 7);
                nRow = rnd1.Next(1, 7);
                nPos = (nCol - 1) * 6 + nRow;
                nType = fHoletype(msShuffle2, nPos);
                if (nType <= 2)
                {
                    bFound = true;
                }
            } while (bFound != true);

        }
        public fSub3()
        {
            InitializeComponent();
        }

        private void fSub3_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            mnSelect = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (mnTick)
            {
                case 1:
                    fUpdateDisplay();
                    mnTick += 1;
                    break;
                case 2:
                    fUpdateDisplay();
                    mnTick += 1;
                    break;
                default:
                    timer1.Enabled = false;
                    fUpdateDisplay();
                    mnSelect = 0;
                    mnTick = 0;
                    break;
            }
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

        private void btnFast_Click(object sender, EventArgs e)
        {
            mbFast = true;
        }

        private void btnNav1_Click(object sender, EventArgs e)
        {
            fNav(1);
        }

        private void btnNav2_Click(object sender, EventArgs e)
        {
            fNav(2);
        }

        private void btnNav3_Click(object sender, EventArgs e)
        {
            fNav(3);
        }

        private void btnNav4_Click(object sender, EventArgs e)
        {
            fNav(4);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            mnConsolidation = 0;
            mnTradeAgreement = 0;
            fUpdateStatus();

            fra1.Visible = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            mnSelect = 2;
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }
    }
}

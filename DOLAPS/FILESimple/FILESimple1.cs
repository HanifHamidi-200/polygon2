using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FILESimple;

namespace Simple
{
    public class FILESimple1
    {
        private cRecord Record1 = new cRecord();
        private int mnRecords;

        private void fInitRecords(int nSize)
        {
            mnRecords = nSize;
        }

        private void fAddRecord(int nPos,String sText1,String sText2)
        {
            Record1.fSet1(nPos, sText1);
            Record1.fSet2(nPos, sText2);
        }

        private void fClearRecords()
        {
            mnRecords = 0;
            Record1.fReset();
        }

        private String fReadRecord1(int nPos)
        {
            return Record1.fText1(nPos);
        }
        private String fReadRecord2(int nPos)
        {
            return Record1.fText2(nPos);
        }
    }
}

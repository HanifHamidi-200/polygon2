using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleRecord;

namespace Simple
{
    public class FILESimple2
    {
        private cRecord Record1 = new cRecord();
        private int mnRecords;
        private String sFName;
        private List<String> _detail = new List<string> { null, null, null };

        public void fInitRecords(int nSize)
        {
            mnRecords = nSize;
        }

        public void fAddRecord(int nPos, String sText1, String sText2)
        {
            Record1.fSet1(nPos, sText1);
            Record1.fSet2(nPos, sText2);
        }

        public void fClearRecords()
        {
            mnRecords = 0;
            Record1.fReset();
            _detail[0] = null;
            _detail[1] = null;
            _detail[2] = null;
        }

        public String fReadRecord1(int nPos)
        {
            return Record1.fText1(nPos);
        }
        public String fReadRecord2(int nPos)
        {
            return Record1.fText2(nPos);
        }

        public void fInitFName(String sName)
        {
            sFName = sName;
        }

        public void fFSave()
        {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@sFName))
                {

                file.WriteLine("LIST");
                file.WriteLine(_detail[0]);
                file.WriteLine(_detail[1]);
                file.WriteLine(_detail[2]);
                for (int i = 1; i <= mnRecords; i++)
                {
                    file.WriteLine(Record1.fText1(i));
                    file.WriteLine(Record1.fText2(i));
                }
                file.WriteLine("END");
            }

        }

        public void fAddDetail(String sText1,String sText2,String sText3)
        {
            _detail[0] = sText1;
            _detail[1] = sText2;
            _detail[2] = sText3;

        }
    }
}

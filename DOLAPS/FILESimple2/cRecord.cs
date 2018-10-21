using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecord
{

    class cRecord
    {
        private List<String> _data1 = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _data2 = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };

        public void fReset()
        {
            for (int i = 1; i <= 28; i++)
            {
                _data1[i - 1] = null;
                _data2[i - 1] = null;
            }
        }
        public String fText1(int nPos)
        {
            return _data1[nPos - 1];
        }
        public String fText2(int nPos)
        {
            return _data2[nPos - 1];
        }

        public void fSet1(int nPos, String sText)
        {
            _data1[nPos - 1] = sText;
        }
        public void fSet2(int nPos, String sText)
        {
            _data2[nPos - 1] = sText;
        }
    }
}

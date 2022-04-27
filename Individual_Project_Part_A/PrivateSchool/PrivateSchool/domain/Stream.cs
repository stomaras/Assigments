using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain
{
    class Stream
    {
        private int _min;

        public int Min
        {
            get { return _min; }
            set { _min = value; }
        }

        private int _max;

        public int Max
        {
            get { return _max; }
            set { _max = value; }
        }

        private int _numOfChars;

        public int NumOfChars
        {
            get { return _numOfChars; }
            set { _numOfChars = value; }
        }

        public Stream(int min, int max, int numOfChars)
        {
            Min = min;
            Max = max;
            NumOfChars = numOfChars;

            if(Min > Max)
            {
                Min = 65;
                Max = 91;
            }

            if(NumOfChars != 1)
            {
                NumOfChars = 1;
            }

            if(Max - Min > 2)
            {
                Min = 65;
                Max = 91;
            }
        }



    }
}

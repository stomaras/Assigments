using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain
{
    class NameMinMax
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


        private int _length;

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public NameMinMax(int min, int max, int length)
        {
            Min = min;
            Max = max;
            Length = length;
            if (min < 0 || max < 0)
            {
                Min = 1;
                Max = Min + 5;//business logic
            }
  
        }

        public override string ToString()
        {
            return $"NameMinMax, with min ascci character {Min}, with max ascii character {Max}, number of characters {Length}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain
{
    class MinMax
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

        private double _minTuitionFees;

        public double MinTuitionFees
        {
            get { return _minTuitionFees; }
            set { _minTuitionFees = value; }
        }

        private double _maxTuitionfees;

        public double MaxTuitionFees
        {
            get { return _maxTuitionfees; }
            set { _maxTuitionfees = value; }
        }

        public MinMax(int min, int max)
        {

            
            Min = min; // 200
            Max = max; // 100
            // conditional statements
            if (min > max) // specific business logic
            {
                Max = min + max;
            }

        }

        public MinMax(double minTuitionFees, double maxTuitionFees)
        {
            MinTuitionFees = minTuitionFees;
            MaxTuitionFees = maxTuitionFees;

            if(MinTuitionFees > MaxTuitionFees)
            {
                MinTuitionFees = 1000;
                MaxTuitionFees = 2500;
            }

            if(MinTuitionFees < 1000 || MinTuitionFees > 2500)
            {
                MinTuitionFees = 1000;
            }

            if(MaxTuitionFees < 1000 || MaxTuitionFees > 2500)
            {
                MaxTuitionFees = 2500;
            }


        }

        public override string ToString()
        {
            return $"MinMax {{ with min Id : {Min}, with max Id : {Max}, with min tuition fees : {MinTuitionFees}, with max tuition fees : {MaxTuitionFees} }} "; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.services
{
    class RandomService
    {
        private static Random _rand = new Random((int)DateTime.Now.Ticks);
        public static int Number(int min, int max)
        {
            int result = 0;
            result = _rand.Next(min, max);
            return (result);
        }

        //public static double DoubleNumber(double min, double max)
        //{
        //    double result = 0;
        //    result = _rand.Next(min, max);
        //    return (result);
        //}
        public static DateTime RandomDate(int minAcceptedYear, int maxAcceptedyear, int minMonth, int maxMonth, int minDay, int maxDay)
        {
            int year = Number(minAcceptedYear, maxAcceptedyear);
            int month = Number(minMonth, maxMonth);
            int day = Number(minDay, maxDay);

            DateTime randomDateTime = new DateTime(year, month, day);
            return randomDateTime;
        }

        
        public static string Name(int min, int max, int noOfChars)
        {
            string result = "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < noOfChars; i++)
            {
                sb.Append((char)_rand.Next(min, max));
            }
            result = sb.ToString();
            return (result);
        }
    }
}

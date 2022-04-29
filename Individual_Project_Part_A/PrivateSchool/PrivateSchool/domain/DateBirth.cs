using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain
{
    class DateBirth
    {
        private int _minAcceptedYearInCalendar;

        public int MinAcceptedYearInCalendar
        {
            get { return _minAcceptedYearInCalendar; }
            set { _minAcceptedYearInCalendar = value; }
        }

        private int _maxAcceptedYearInCalendar;

        public int MaxAcceptedYearInCalendar
        {
            get { return _maxAcceptedYearInCalendar; }
            set { _maxAcceptedYearInCalendar = value; }
        }

        private int _minMonth;

        public int MinMonth
        {
            get { return _minMonth; }
            set { _minMonth = value; }
        }

        private int _maxMonth;

        public int MaxMonth
        {
            get { return _maxMonth; }
            set { _maxMonth = value; }
        }

        private int _minDay;

        public int MinDay
        {
            get { return _minDay; }
            set { _minDay = value; }
        }

        private int _maxDay;

        public int MaxDay
        {
            get { return _maxDay; }
            set { _maxDay = value; }
        }


        public DateBirth(int minAcceptedYearInCalendar, int maxAcceptedYearInCalendar, int minMonth, int maxMonth, int minDay, int maxDay)
        {
            MinAcceptedYearInCalendar = minAcceptedYearInCalendar;
            MaxAcceptedYearInCalendar = maxAcceptedYearInCalendar;
            MinMonth = minMonth;
            MaxMonth = maxMonth;
            MinDay = minDay;
            MaxDay = maxDay;


            if(DateTime.Now.Year - maxAcceptedYearInCalendar < 18 || DateTime.Now.Year - maxAcceptedYearInCalendar > 70 || maxAcceptedYearInCalendar < 0 || maxAcceptedYearInCalendar < minAcceptedYearInCalendar)
            {
                maxAcceptedYearInCalendar = DateTime.Now.Year - 18;
                MaxAcceptedYearInCalendar = maxAcceptedYearInCalendar;
            }
            if(DateTime.Now.Year - minAcceptedYearInCalendar > 70 || DateTime.Now.Year -minAcceptedYearInCalendar < 18 || minAcceptedYearInCalendar < 0 || minAcceptedYearInCalendar > maxAcceptedYearInCalendar)
            {
                minAcceptedYearInCalendar = DateTime.Now.Year - 70;
                MinAcceptedYearInCalendar = minAcceptedYearInCalendar;
            }

            if(minMonth < 0 || minMonth > maxMonth)
            {
                minMonth = 1;
                MinMonth = minMonth;
            }

            if(maxMonth > 12 || maxMonth < minMonth)
            {
                maxMonth = 12;
                MaxMonth = maxMonth;
            }

            if(minDay < 0 || minDay > 30 || (minDay > maxDay))
            {
                minDay = 1;
                MinDay = minDay;
            }

            if(maxDay < 0 || maxDay > 30 || (maxDay < minDay))
            {
                maxDay = 30;
                MaxDay = maxDay;
            }

        }

        public override string ToString()
        {
            return $"DateBirth {{ Details minimum accepted year in calendar {MinAcceptedYearInCalendar} , maximum accepted year in calendar {MaxAcceptedYearInCalendar} , min Month {MinMonth} , max Month {MaxMonth} , min day {MinDay} , max day {MaxDay} }}";
;        }
    }
}

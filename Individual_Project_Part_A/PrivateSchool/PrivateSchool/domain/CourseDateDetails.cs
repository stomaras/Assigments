using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain
{
    class CourseDateDetails
    {
        private DateTime _startDate;

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        private DateTime _endDate;

        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public CourseDateDetails(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;

            int diff = EndDate.Year - StartDate.Year;
            DateTime currYear = DateTime.Now;


            if (StartDate.Year < DateTime.Now.Year) 
            {
                StartDate = currYear;
                EndDate = DateTime.Now.AddYears(1);
            }
            
            if(StartDate.Year > EndDate.Year)
            {
                StartDate = currYear;
                EndDate = currYear.AddYears(1);
            }
            
        }


    }
}

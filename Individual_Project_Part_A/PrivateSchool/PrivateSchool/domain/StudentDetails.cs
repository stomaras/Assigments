using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrivateSchool.domain
{
    class StudentDetails
    {
        string[] firstNames = new string[] { "spyros", "kostas", "chris", "zarma", "mitsos", "natalia", "anna", "agathi" };
        string[] lastNames = new string[] { "tomaras", "fragulis", "oikonomidis", "kanoulas", "karaulanis", "kallifonis", "papanikolaou", "papagiani" };
        private FullName _fullName;

        public FullName FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }


        private DateTime _dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }



        private double _tuitionFees;

        public double TuitionFees
        {
            get { return _tuitionFees; }
            set { _tuitionFees = value; }
        }

        public StudentDetails(FullName fullName, DateTime dateOfBirth, double tuitionFees)
        {
            FullName = new FullName(fullName.FirstName, fullName.LastName);
            DateOfBirth = GenerateDateOfBirth(dateOfBirth);
            TuitionFees = CreateTuitionFees(tuitionFees);
        }


        private DateTime GenerateDateOfBirth(DateTime date)
        {
            DateTime dateAccept = new DateTime(2004, 1, 1);
            if(date.Year > DateTime.Now.Year)
            {
                date.Subtract((DateTime.Now));
                date.Subtract(dateAccept);
            }

            if (date.Year - DateTime.Now.Year < 18)
            {
                date.Subtract(dateAccept);
            }
            return date;
        }

        private double CreateTuitionFees(double tuitionFees)
        {
            if(tuitionFees < 2000)
            {
                tuitionFees = 2000;
            }

            return tuitionFees;
        }







    }
}

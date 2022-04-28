using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain
{
    abstract class Student
    {
        private int _sid;

        public int Sid
        {
            get { return _sid; }
            set { _sid = value; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
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

        public abstract override string ToString();


        //private int _sid;

        //public int Sid
        //{
        //    get { return _sid; }
        //    set { _sid = value; }
        //}

        //private string _firstName;

        //public string FirstName
        //{
        //    get { return _firstName; }
        //    set { _firstName = value; }
        //}

        //private string _lastName;

        //public string LastName
        //{
        //    get { return _lastName; }
        //    set { _lastName = value; }
        //}

        //private DateTime _dateOfBirth;

        //public DateTime DateOfBirth
        //{
        //    get { return _dateOfBirth; }
        //    set { _dateOfBirth = value; }
        //}

        //private double _tuitionFees;

        //public double TuitionFees
        //{
        //    get { return _tuitionFees; }
        //    set { _tuitionFees = value; }
        //}


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain
{
    class StudentDetails
    {
        private MinMax _id;

        public MinMax Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private NameMinMax _firstName;

        public NameMinMax FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private NameMinMax _lastName;

        public NameMinMax LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private DateBirth _dateOfBirth;

        public DateBirth DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }


        private MinMax _tuitionFees;

        public MinMax TuitionFees
        {
            get { return _tuitionFees; }
            set { _tuitionFees = value; }
        }

        public StudentDetails(MinMax id, NameMinMax firstName, NameMinMax lastName, DateBirth dateOfBirth, MinMax tuitionFees)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            TuitionFees = tuitionFees;
        }

        public override string ToString()
        {
            return $"Student Details : With min Id ";
        }
    }
}

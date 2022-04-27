using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain
{
    class RandomStudent : Student
    {

        private StudentDetails _studentDetails;

        public StudentDetails StudentDetails
        {
            get { return _studentDetails; }
            set { _studentDetails = value; }
        }


        public RandomStudent(){}

        public RandomStudent(StudentDetails studentDetails)
        {
            _studentDetails = studentDetails;
        }

        public override string ToString()
        {
            return $"Student:: with Full Name: {StudentDetails.FullName}, with date of birth: {StudentDetails.DateOfBirth}, with tuition fees: {StudentDetails.TuitionFees}";
        }
    }
}

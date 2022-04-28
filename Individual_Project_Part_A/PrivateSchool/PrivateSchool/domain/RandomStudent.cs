using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.services;

namespace PrivateSchool.domain
{
    class RandomStudent : Student
    {

        private StudentDetails _studentDetails;

        


        public RandomStudent (StudentDetails studentDetails)
        {
            _studentDetails = studentDetails;
            Sid = RandomService.Number(_studentDetails.Id.Min, _studentDetails.Id.Max);
            FirstName = RandomService.Name(_studentDetails.FirstName.Min, _studentDetails.FirstName.Max, _studentDetails.FirstName.Length);
            LastName = RandomService.Name(_studentDetails.LastName.Min, _studentDetails.LastName.Max, _studentDetails.LastName.Length);
            TuitionFees = RandomService.Number((int)_studentDetails.TuitionFees.MinTuitionFees, (int)_studentDetails.TuitionFees.MaxTuitionFees);
            DateOfBirth = RandomService.RandomDate(_studentDetails.DateOfBirth.MinAcceptedYearInCalendar, _studentDetails.DateOfBirth.MaxAcceptedYearInCalendar, _studentDetails.DateOfBirth.MinMonth, _studentDetails.DateOfBirth.MaxMonth, _studentDetails.DateOfBirth.MinDay, _studentDetails.DateOfBirth.MaxDay);
        }
        

        public override string ToString()
        {
            //string s = "Student with : ";
            //string s1= StudentDetails.ToString();
            //s += s + s1;
            //return $"Student with Id {StudentDetails.Id.} with First Name { StudentDetails.FirstName}";
            return $" Student with id: {Sid}, with first name: {FirstName}, with last name: {LastName}, with tuition fees: {TuitionFees}, with Date Of Birth {DateOfBirth}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.services
{
    class UserDataService
    {

        private string[] Courses { get; set; }

        private int _numOfStudents;

        public int NumOfStudents
        {
            get { return _numOfStudents; }
            set { _numOfStudents = value; }
        }

        private int _numOfTrainers;

        public int NumOfTrainers
        {
            get { return _numOfTrainers; }
            set { _numOfTrainers = value; }
        }

        private int _numOfAssigments;

        public int NumOfAssigments
        {
            get { return _numOfAssigments; }
            set { _numOfAssigments = value; }
        }

        private int _numOfCourses;

        public int NumOfCourses
        {
            get { return _numOfCourses; }
            set { _numOfCourses = value; }
        }

        public UserDataService(int numOfStudents, int numOfTrainers, int numOfAssigments, int numOfCourses)
        {
            Courses = InitializeCourses();
            NumOfStudents = numOfStudents;
            NumOfTrainers = numOfTrainers;
            NumOfAssigments = numOfAssigments;
            NumOfCourses = numOfCourses;
        }

        public string[] InitializeCourses()
        {
            Courses = new string[4]{ "java", "python", "csharp", "javascript"};
            return Courses;
        }




    }
}

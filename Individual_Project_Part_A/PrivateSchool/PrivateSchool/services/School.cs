using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.domain;
namespace PrivateSchool.services
{
    class School
    {
        private StudentDetails _studentDetails;

        public StudentDetails StudentDetails
        {
            get { return _studentDetails; }
            set { _studentDetails = value; }
        }

        private int _noOfStudents;

        public int NoOfStudents
        {
            get { return _noOfStudents; }
            set { _noOfStudents = value; }
        }

        

        public School(StudentDetails studentDetails, int noOfStudents)
        {
            StudentDetails = studentDetails;
            NoOfStudents = noOfStudents;
        }

        public void Start()
        {
            Console.WriteLine("-----------------Private School Application Start----------------------------");

            StudentService studentService = new StudentService(_studentDetails, _noOfStudents);

            foreach(RandomStudent student in studentService.Students)
            {
                Console.WriteLine(student);
            }
        }
    }
}

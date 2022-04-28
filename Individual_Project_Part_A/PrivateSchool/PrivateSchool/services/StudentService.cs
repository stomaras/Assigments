using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.domain;

namespace PrivateSchool.services
{
    class StudentService
    {
        private int _noOfStudents;
        private StudentDetails _studentDetails;

        public List<Student> Students { get; private set; }

        public StudentService(StudentDetails studentDetails, int noOfStudents)
        {
            _studentDetails = studentDetails;
            _noOfStudents = noOfStudents;
            Students = GenerateStudents();
        }

        private List<Student> GenerateStudents()
        {
            List<Student> students = new List<Student>();


            for(int i = 0; i < _noOfStudents; i++)
            {
                students.Add(new RandomStudent(_studentDetails));
            }
            return students;
        }
    }
}

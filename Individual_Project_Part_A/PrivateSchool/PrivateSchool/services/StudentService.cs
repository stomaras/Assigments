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
            var newStudent = new RandomStudent(_studentDetails);
            students.Add(newStudent);

            var newId = 0;

            for(int i = 0; i < _noOfStudents - 1; i++)
            {
                bool notFound = true;

                while (notFound)
                {
                    newId = RandomService.Number(_studentDetails.Id.Min, _studentDetails.Id.Max);
                    foreach(Student student in students)
                    {
                        if(student.Sid == newId)
                        {
                            break;
                        }
                        if(students.Last() == student)
                        {
                            notFound = false;
                        }
                    }
                }
                students.Add(new RandomStudent(_studentDetails, newId));
            }
            return students;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.domain;
using PrivateSchool.services;
namespace PrivateSchool
{
    class Program
    {
        static void Main(string[] args)
        {

            int noOfCourses = 500;
            Stream stream = new Stream(0, 2, 2);
            CourseDateDetails CourseDateDetails = new CourseDateDetails(new DateTime(2020/3/23), new DateTime(2019/4/23));
            CourseDetails courseDetails = new CourseDetails("JaVa", stream, "full time", CourseDateDetails);

            FullName fullName = new FullName("Spyros", "Tomaras");
            StudentDetails studentDetails = new StudentDetails(fullName, new DateTime(1997, 11, 01), 300);
            RandomStudent randomStudent = new RandomStudent(studentDetails);
            Console.WriteLine(randomStudent.ToString());

            School school = new School(courseDetails, noOfCourses);
            school.Start();

            
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.domain;
namespace PrivateSchool.services
{
    class CourseService
    {
        private CourseDetails _courseDetails;
        private int _noOfCourses;

        public List<Course> Courses { get; private set; }

        public CourseService(CourseDetails courseDetails, int noOfCourses)
        {
            _courseDetails = courseDetails;
            _noOfCourses = noOfCourses;
            Courses = GenerateCourses();
        }

        private List<Course> GenerateCourses()
        {
            List<Course> courses = new List<Course>();
            for(int i=0; i < _noOfCourses; i++)
            {
                courses.Add(new RandomCourse(_courseDetails));
            }
            return courses;
        }
    }
}

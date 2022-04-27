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
        private CourseDetails _courseDetails;

        public CourseDetails CourseDetails
        {
            get { return _courseDetails; }
            set { _courseDetails = value; }
        }

        private int _noOfCourses;

        public int NoOfCourses
        {
            get { return _noOfCourses; }
            set { _noOfCourses = value; }
        }

        public School(CourseDetails courseDetails, int noOfCourses)
        {
            CourseDetails = courseDetails;
            NoOfCourses = noOfCourses;
        }


        public void Start()
        {
            Console.WriteLine("-----------------------------------------Private School Console Application------------------------------------------");
            CourseService courseService = new CourseService(_courseDetails, _noOfCourses);

            foreach(RandomCourse course in courseService.Courses)
            {
                Console.WriteLine(course);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain
{
    class RandomCourse : Course
    {

        private CourseDetails _courseDetails;

        public CourseDetails CourseDetails
        {
            get { return _courseDetails; }
            set { _courseDetails = value; }
        }

        public RandomCourse() { }

        public RandomCourse(CourseDetails courseDetails)
        {
            this.CourseDetails = courseDetails;
        }

        public override string ToString()
        {
            return $"Course: with Title {CourseDetails.Title}, with type {CourseDetails.Type} , in stream {CourseDetails.Stream}, with start date {CourseDetails.CourseDateDetails.StartDate}, with end date {CourseDetails.CourseDateDetails.EndDate}";
        }


    }
}

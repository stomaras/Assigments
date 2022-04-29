using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain
{
    class Subject : ISubject
    {
        private string[] _courses;
        

        public string[] Courses 
        {
            get { return _courses; }
            set { _courses = value; }
        }

        public Subject()
        {
            string[] ccourses = new string[4];
            this.Courses = InitializeCourses(ccourses);
            Courses[0] = "java";
            Courses[1] = "csharp";
            Courses[2] = "python";
            Courses[3] = "javascript";
        }

        

        public string[] InitializeCourses(string[] courses)
        {
            for(int i=0; i<= courses.Length - 1; i++)
            {
                courses[i] = "";
            }
            return courses;
            
        }

        public override string ToString()
        {
            string s = "Subject with number of courses : " + Courses.Length + " and available courses : ";
            for(int i = 0; i<= Courses.Length - 1; i++)
            {
                s = s + Courses[i] + " ";
            }
            return s;
        }
    }
}

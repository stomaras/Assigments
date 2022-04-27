using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain
{
    class CourseDetails
    {
        private static Random _rand = new Random((int)DateTime.Now.Ticks);
        private string[] courses = { "java", "csharp", "python", "javascript" };
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _stream;

        public string Stream
        {
            get { return _stream; }
            set { _stream = value; }
        }

        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private CourseDateDetails _coursedateDetails;

        public CourseDateDetails CourseDateDetails
        {
            get { return _coursedateDetails; }
            set { _coursedateDetails = value; }
        }

        public CourseDetails(string title, Stream stream, string type, CourseDateDetails dateDetails)
        {
            this.Title = CreateTitle(title);
            this.Stream = CreateStream(stream);
            this.Type = CreateType(type);
            this.CourseDateDetails = dateDetails;
        }

        public string CreateTitle(string title)
        {
            string result = title.ToLower();
            
            for (int i = 0; i <= courses.Length - 1; i++)
            {
                
                if (courses[i] == result)
                {
                    Console.WriteLine(result);
                    return result;
                }
            }
            result = "java";
            return result;
        }

        public string CreateStream(Stream stream)
        {
            string result = "";
            
            StringBuilder sb = new StringBuilder();

            for(int i= 0; i<= stream.NumOfChars; i++)
            {
                sb.Append((char)_rand.Next(65, 91));
            }
            result = sb.ToString() + _rand.Next(0,9) + _rand.Next(0,9);
            return result;
        }

        public string CreateType(string type)
        {
            string newType = type.ToLower();
            if (newType == "full time" || newType == "part time")
            {
                return newType;
            }
            else
            {
                newType = "part time";
            }
            return newType;
        }
    }
}

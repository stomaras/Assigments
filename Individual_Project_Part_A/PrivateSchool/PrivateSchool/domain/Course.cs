using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain
{
    class Course
    {
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

        private int _type;

        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private DateTime _start_date;

        public DateTime StartDate
        {
            get { return _start_date; }
            set { _start_date = value; }
        }

        private DateTime _end_date;

        public DateTime EndDate
        {
            get { return _end_date; }
            set { _end_date = value; }
        }





    }
}

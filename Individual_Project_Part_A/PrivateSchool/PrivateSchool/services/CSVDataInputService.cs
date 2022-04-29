using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PrivateSchool.domain;



namespace PrivateSchool.services
{
    
    class CSVDataInputService
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



        public CSVDataInputService(string filename)
        {

            
            using (var reader = new StreamReader(filename))// using with resources
            {
                var counter = 0;
                MinMax sid;
                MinMax tuitionFees;
                NameMinMax firstName;
                NameMinMax lastName;
                DateBirth dateBirth;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (counter > 0)
                    {
                        var values = line.Split(';');
                        NoOfStudents = Convert.ToInt32(values[0]);
                        sid = new MinMax(Convert.ToInt32(values[1]), Convert.ToInt32(values[2]));
                        tuitionFees = new MinMax(Convert.ToDouble(values[3]), Convert.ToDouble(values[4]));
                        firstName = new NameMinMax(Convert.ToInt32(values[5]), Convert.ToInt32(values[6]), Convert.ToInt32(values[7]));
                        lastName = new NameMinMax(Convert.ToInt32(values[8]), Convert.ToInt32(values[9]), Convert.ToInt32(values[10]));
                        dateBirth = new DateBirth(Convert.ToInt32(values[11]), Convert.ToInt32(values[12]), Convert.ToInt32(values[13]), Convert.ToInt32(values[14]), Convert.ToInt32(values[15]), Convert.ToInt32(values[16]));
                        StudentDetails = new StudentDetails(sid, firstName, lastName, dateBirth, tuitionFees);
                    }
                    counter++;
                }
            }
            Console.WriteLine(NoOfStudents);
            Console.WriteLine(StudentDetails);
        }
    }
}

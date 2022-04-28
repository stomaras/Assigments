using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.domain;


namespace PrivateSchool.services
{
    class StudentDataInputService
    {

        private StudentDetails _studentDetails;

        public StudentDetails  StudentDetails
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

        public StudentDataInputService() { }

        public StudentDataInputService(StudentDetails studentDetails, int numOfStudents)
        {
            NoOfStudents = numOfStudents;
            StudentDetails = studentDetails;
            
        }


        public void Start()
        {
            Console.WriteLine("Enter number of Students: ");
            int num = Convert.ToInt32(Console.ReadLine());
            NoOfStudents = num;
            int i = 0;
            List<Student> students = new List<Student>();
            while (i < NoOfStudents)
            {
                // Enter all data fields that a student is required
                // Create Entity student
                // Insert Single Entity Student to the List
                
                int Id = CreateUniqueId();
                //
                i++;
            }
        }

        public static int CreateUniqueId()
        {
            Console.WriteLine("Enter min acceptable id: ");
            int minId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max acceptable id: ");
            int maxId = Convert.ToInt32(Console.ReadLine());
            int Id = RandomService.Number(minId, maxId);
            return Id;
        }
    }

    
}

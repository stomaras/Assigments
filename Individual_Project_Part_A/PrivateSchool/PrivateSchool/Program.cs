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
        /*
         * With CSVDataInputService, i will generate noOfStudents and StudentDetails
         * 
         * 
         */
        static void Main(string[] args)
        {


            //StudentDataInputService studentDataInputService = new StudentDataInputService();
            //studentDataInputService.Start();


            //csvDataInputService.NoOfStudents;
            //csvDataInputService.StudentDetails

            //int noOfStudents = 30;
            //MinMax Id = new MinMax(1, 100);
            //MinMax TuitionFees = new MinMax(900.00, 7900.00);
            //NameMinMax FirstName = new NameMinMax(65, 91, 4);
            //NameMinMax LastName = new NameMinMax(65, 91, 6);
            //DateBirth DateBirth = new DateBirth(1982, 2005, 3, 8, 5, 23);
            //StudentDetails studentDetails = new StudentDetails(Id, FirstName, LastName, DateBirth, TuitionFees);
            //RandomStudent random = new RandomStudent(studentDetails);

            //Console.WriteLine(random.ToString());
            CSVDataInputService csvDataInputService = new CSVDataInputService(@"C:\Users\spyros\Assigments\Individual_Project_Part_A\PrivateSchool\PrivateSchool\SchoolData.csv");
            StudentDetails studentDetails = csvDataInputService.StudentDetails;
            int noOfStudents = csvDataInputService.NoOfStudents;
            School school = new School(studentDetails, noOfStudents);
            school.Start();



        }

            
    }
        
}


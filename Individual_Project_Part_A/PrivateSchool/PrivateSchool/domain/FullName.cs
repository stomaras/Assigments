using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace PrivateSchool.domain
{
    class FullName
    {

        private static int sid = 0;

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _fullName;

        public string FullNamee
        {
            get { return _fullName; }
            set { _fullName = value; }
        }


        public FullName(string firstName, string lastName)
        {
            int sid = GenerateSid();
            FirstName = CreateFirstName(firstName, sid);
            LastName = CreateLastName(lastName, sid);
            FullNamee = FirstName + LastName;
        }

        private string CreateFirstName(string name, int sid)
        {

            if(name == "")
            {
                name = " First Name " + sid;
            } 
            return name;
        }
        private string CreateLastName(string name, int sid)
        {

            if (name == "")
            {
                name = " Last Name " + sid;
            }
            return name;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        private int GenerateSid()
        {
            sid++;
            return sid;
        }




        //private bool HasDigitOrSpecialCharacter(string name)
        //{
        //    string pattern = "[^A-Za-z]";
        //    Regex reg = new Regex(pattern);
        //    bool containsSpecialCharacterOrDigit = reg.IsMatch(name);

        //    if (containsSpecialCharacterOrDigit)
        //    {
        //        return true;
        //    }

        //    return false;
        //}

    }
}

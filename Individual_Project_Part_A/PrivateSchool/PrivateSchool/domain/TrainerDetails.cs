using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain
{
    class TrainerDetails
    {

        private MinMax _id;

        public MinMax Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private NameMinMax _firstName;

        public NameMinMax FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private NameMinMax _lastName;

        public NameMinMax LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private Subject _subject;

        public Subject Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public TrainerDetails(MinMax id, NameMinMax firstName, NameMinMax lastName, Subject subject)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
            
        }

        public override string ToString()
        {
            return $"TrainerDetails {{ with min Id {Id.Min} with max Id {Id.Max} \n with min ascii for trainer first name {FirstName.Min} with max ascii for trainer first name {FirstName.Max} with num of characters of first name {FirstName.Length} \n with min ascii for trainer last name {LastName.Min} with max ascii for trainer last name {LastName.Max} with num of characters of last name {LastName.Length} \n with subject details {Subject.ToString()} }}";
        }
    }
}

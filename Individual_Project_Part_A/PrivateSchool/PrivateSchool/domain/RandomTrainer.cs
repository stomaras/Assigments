using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.services;

namespace PrivateSchool.domain
{
    class RandomTrainer : Trainer
    {
        private TrainerDetails _trainerDetails;

        public TrainerDetails TrainerDetails
        {
            get { return _trainerDetails; }
            set { _trainerDetails = value; }
        }

        public RandomTrainer() { }

        public RandomTrainer(TrainerDetails trainerDetails)
        {
            _trainerDetails = trainerDetails;
            Tid = RandomService.Number(_trainerDetails.Id.Min, _trainerDetails.Id.Max);
            FirstName = RandomService.Name(_trainerDetails.FirstName.Min, _trainerDetails.FirstName.Max, _trainerDetails.FirstName.Length);
            LastName = RandomService.Name(_trainerDetails.LastName.Min, _trainerDetails.LastName.Max, _trainerDetails.LastName.Length);
            Subject = RandomService.Course(_trainerDetails.Subject.Courses);
        }


        public override string ToString()
        {
            return $"Trainer {{ with ID: {Tid} with FirstName: {FirstName} with LastName: {LastName}  with Subject: {Subject} }}";
        }
    }
}

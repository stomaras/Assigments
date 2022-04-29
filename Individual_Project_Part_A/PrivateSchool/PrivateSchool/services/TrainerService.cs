using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.domain;


namespace PrivateSchool.services
{
    class TrainerService
    {
        private TrainerDetails _trainerDetails;
        private int _numOfTrainers;
       

        public int NumOfTrainers
        {
            get { return _numOfTrainers; }
            set { _numOfTrainers = value; }
        }

        private List<Trainer> _trainers;

        public List<Trainer> Trainers { get; private set; }

        public TrainerService(TrainerDetails trainerDetails, int numOfTrainers)
        {
            _trainerDetails = trainerDetails;
            _numOfTrainers = numOfTrainers;
        }




    }
}

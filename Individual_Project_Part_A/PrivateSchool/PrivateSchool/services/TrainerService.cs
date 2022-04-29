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
            Trainers = GenerateTrainers();
        }

        public List<Trainer> GenerateTrainers()
        {
            List<Trainer> trainers = new List<Trainer>();
            var newTrainer = new RandomTrainer(_trainerDetails);
            trainers.Add(newTrainer);

            for(int i = 0; i < _numOfTrainers - 1; i++)
            {
                trainers.Add(new RandomTrainer(_trainerDetails, GenerateUniqueTrainerIds(GetTrainersIds(trainers))));
                
            }
            return trainers;
        }

        private List<int> GetTrainersIds(List<Trainer> trainers)
        {
            return (new List<int>(trainers.Select(trainer => trainer.Tid)));
        }

        private int GenerateUniqueTrainerIds(List<int> ids)
        {
            var newId = RandomService.Number(_trainerDetails.Id.Min, _trainerDetails.Id.Max);
            while (ids.Contains(newId))
            {
                newId = RandomService.Number(_trainerDetails.Id.Min, _trainerDetails.Id.Max);
            }
            return (newId);
        }




    }
}

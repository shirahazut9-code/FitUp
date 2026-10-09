using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class Training:BaseEntity
    {
        private Trainers idTrainer;
        private DateOnly dateofTraining;
        private TimeOnly hourOfTraing;
        private TrainingTypes trainingTypeID;

        public Trainers IdTrainer { get => idTrainer; set => idTrainer = value; }
        public DateOnly DateofTraining { get => dateofTraining; set => dateofTraining = value; }
        public TimeOnly HourOfTraing { get => hourOfTraing; set => hourOfTraing = value; }
        public TrainingTypes TrainingTypeID { get => trainingTypeID; set => trainingTypeID = value; }
    }
}

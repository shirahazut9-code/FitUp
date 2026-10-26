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
        private DateTime dateOfTraining;
        private TrainingTypes trainingTypeID;

        public Trainers IdTrainer { get => idTrainer; set => idTrainer = value; }       
        public TrainingTypes TrainingTypeID { get => trainingTypeID; set => trainingTypeID = value; }
        public DateTime DateOfTraining { get => dateOfTraining; set => dateOfTraining = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TrainingTypes:BaseEntity
    {
        private string trainingName;
        private int maxParticipants;
        private int lengthTraining;

        public string TrainingName { get => trainingName; set => trainingName = value; }
        public int MaxParticipants { get => maxParticipants; set => maxParticipants = value; }
        public int LengthTraining { get => lengthTraining; set => lengthTraining = value; }
    }
}

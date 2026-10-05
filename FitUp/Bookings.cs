using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bookings:BaseEntity 
    {
        private Members iDMember;
        private Training trainingID;

        public Members IDMember { get => iDMember; set => iDMember = value; }
        public Training TrainingID { get => trainingID; set => trainingID = value; }
    }
}

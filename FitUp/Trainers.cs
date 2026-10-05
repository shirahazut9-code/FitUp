using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Trainers:Person
    {
        private DateTime experience;

        public DateTime Experience { get => experience; set => experience = value; }
    }
}

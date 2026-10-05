using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Document:BaseEntity
    {
        private Trainers iDTrainer;
        private string linkToFile;

        public Trainers IDTrainer { get => iDTrainer; set => iDTrainer = value; }
        public string LinkToFile { get => linkToFile; set => linkToFile = value; }
    }
}

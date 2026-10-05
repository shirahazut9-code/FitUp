using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TrainersList:List<Trainers>
    {
        public TrainersList() { }
        public TrainersList(IEnumerable<Trainers> list) : base(list) { }
        public TrainersList(IEnumerable<BaseEntity> list) : base(list.Cast<Trainers>().ToList()) { }
    }
}

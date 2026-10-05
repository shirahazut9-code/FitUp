using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TrainingTypesList:List<TrainingTypes>
    {
        public TrainingTypesList() { }
        public TrainingTypesList(IEnumerable<TrainingTypes> list) : base(list) { }
        public TrainingTypesList(IEnumerable<BaseEntity> list) : base(list.Cast<TrainingTypes>().ToList()) { }
    }
}

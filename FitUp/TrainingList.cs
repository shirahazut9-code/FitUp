using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TrainingList:List<Training>
    {
        public TrainingList() { }
        public TrainingList(IEnumerable<Training> list) : base(list) { }
        public TrainingList(IEnumerable<BaseEntity> list) : base(list.Cast<Training>().ToList()) { }
    }
}

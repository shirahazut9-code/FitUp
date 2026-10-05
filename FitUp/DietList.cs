using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DietList:List<Diet>
    {
        public DietList() { }
        public DietList(IEnumerable<Diet> list) : base(list) { }
        public DietList(IEnumerable<BaseEntity> list) : base(list.Cast<Diet>().ToList()) { }
    }
}

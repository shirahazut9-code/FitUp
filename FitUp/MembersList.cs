using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MembersList:List<Members>
    {
        public MembersList() { }
        public MembersList(IEnumerable<Members> list) : base(list) { }
        public MembersList(IEnumerable<BaseEntity> list) : base(list.Cast<Members>().ToList()) { }
    }
}

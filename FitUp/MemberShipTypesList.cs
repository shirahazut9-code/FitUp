using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MemberShipTypesList:List<MemberShipTypes>
    {
        public MemberShipTypesList() { }
        public MemberShipTypesList(IEnumerable<MemberShipTypes> list) : base(list) { }
        public MemberShipTypesList(IEnumerable<BaseEntity> list) : base(list.Cast<MemberShipTypes>().ToList()) { }
    }
}

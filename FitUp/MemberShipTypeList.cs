using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class MemberShipTypeList:List<MemberShipType>
    {
        public MemberShipTypeList() { }
        public MemberShipTypeList(IEnumerable<MemberShipType> list) : base(list) { }
        public MemberShipTypeList(IEnumerable<BaseEntity> list) : base(list.Cast<MemberShipType>().ToList()) { }
    }
}

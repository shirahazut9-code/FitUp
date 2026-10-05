using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Members:Person
    {
        private MemberShipType typeName;
        private DateTime expirationDate;

        public MemberShipType TypeName { get => typeName; set => typeName = value; }
        public DateTime ExpirationDate { get => expirationDate; set => expirationDate = value; }
    }
}

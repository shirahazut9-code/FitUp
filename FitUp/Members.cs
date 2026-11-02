using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Members:Person
    {
        private MemberShipTypes typeName;
        private DateTime expirationDate;

        public MemberShipTypes TypeName { get => typeName; set => typeName = value; }
        public DateTime ExpirationDate { get => expirationDate; set => expirationDate = value; }
    }
}

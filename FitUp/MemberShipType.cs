using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MemberShipType:BaseEntity
    {
        private string typeName;
        private int price;

        public string TypeName { get => typeName; set => typeName = value; }
        public int Price { get => price; set => price = value; }
    }
}

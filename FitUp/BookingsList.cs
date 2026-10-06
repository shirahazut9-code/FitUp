using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BookingsList:List<Bookings>
    {
        public BookingsList() { }
        public BookingsList(IEnumerable<Bookings> list) : base(list) { }
        public BookingsList(IEnumerable<BaseEntity> list) : base(list.Cast<Bookings>().ToList()) { }
    }
}

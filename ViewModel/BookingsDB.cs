using System;
using Model;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class BookingsDB:BaseDB
    {
        public BookingsList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Bookings";
            BookingsList groupList = new BookingsList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Bookings d = entity as Bookings;
            d.IDMember = MembersDB.SelectById((int)reader["IDMember"]);
            d.TrainingID = TrainingDB.SelectById((int)reader["TrainingID"]);



            base.CreateModel(entity);
            return d;
        }
        public override BaseEntity NewEntity()
        {
            return new Bookings();
        }
        static private BookingsList list = new BookingsList();

        public static Bookings SelectById(int id)
        {
            BookingsDB db = new BookingsDB();
            list = db.SelectAll();

            Bookings d = list.Find(item => item.Id == id);
            return d;
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }
    }
}

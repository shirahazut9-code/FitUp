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
        
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Bookings t = entity as Bookings;
            if (t != null)
            {
                string sqlStr = $"Insert INTO Bookings (IDMember, TrainingID) VALUES (@iDMember, @TrainingID)";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@iDMember", t.IDMember.Id));
                command.Parameters.Add(new OleDbParameter("@TrainingID", t.TrainingID.Id));       
            }
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Bookings tt = entity as Bookings;
            if (tt != null)
            {
                string sqlStr = $"DELETE FROM Bookings where id=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", tt.Id));
            }
        }
        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Bookings m = entity as Bookings;
            if (m != null)
            {
                string sqlStr = $"UPDATE Bookings Set IDMember=@iDMember , TrainingID=@trainingID Where ID=@id";


                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@iDMember", m.IDMember.Id));
                command.Parameters.Add(new OleDbParameter("@trainingID", m.TrainingID.Id));
                command.Parameters.Add(new OleDbParameter("@id", m.Id));

            }
        }
    }
}

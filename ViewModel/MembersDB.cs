using System;
using Model;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class MembersDB:PersonDB
    {
        public MembersList SelectAll()
        {
            command.CommandText = $"SELECT Person.ID, Person.FirstName, " +
                $" Person.LastName, Person.PhonNumber, Person.Email, Person.Pass, " +
                $" Person.BirthDate, Person.Active, Members.MemberShipTypeID, " +
                $" Members.ExpirationDate" +
                $" FROM (Members INNER JOIN Person ON Members.ID = Person.ID)";
            MembersList groupList = new MembersList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Members m = entity as Members;
            m.TypeName = MemberShipTypesDB.SelectById((int)reader["MemberShipTypeID"]);
            m.ExpirationDate = DateTime.Parse(reader["ExpirationDate"].ToString());


            base.CreateModel(entity);
            return m;
        }
        public override BaseEntity NewEntity()
        {
            return new Members();
        }
        static private MembersList list = new MembersList();

        public static Members SelectById(int id)
        {
            MembersDB db = new MembersDB();
            list = db.SelectAll();

            Members m = list.Find(item => item.Id == id);
            return m;
        }

    }
}

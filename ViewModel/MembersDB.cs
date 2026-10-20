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
        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Members m = entity as Members;
            if (m != null)
            {
                string sqlStr = $"UPDATE Members Set TypeName=@typeName , ExpirationDate=@expirationDate Where ID=@id";
                command.CommandText = sqlStr;
                //command.Parameters.Add(new OleDbParameter("@firstName", m.FirstName));
                //command.Parameters.Add(new OleDbParameter("@lastName", m.LastName));
                //command.Parameters.Add(new OleDbParameter("@phonNumber", m.PhonNumber));
                //command.Parameters.Add(new OleDbParameter("@email", m.Email));
                //command.Parameters.Add(new OleDbParameter("@pass", m.Pass));
                //command.Parameters.Add("@birthDate", System.Data.OleDb.OleDbType.Date).Value = m.BirthDate;
                //command.Parameters.Add(new OleDbParameter("@active", m.Active));
                command.Parameters.Add(new OleDbParameter("@typeName", m.TypeName.Id));
                command.Parameters.Add(new OleDbParameter("@expirationDate", m.ExpirationDate));
                command.Parameters.Add(new OleDbParameter("@id", m.Id));
            }
        }

        public override void Update(BaseEntity entity)
        {
            Members members = entity as Members;
            if (members != null)
            {
                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }

    }
}

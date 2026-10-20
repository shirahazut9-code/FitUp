using Model;
using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class MemberShipTypesDB:BaseDB
    {
        public MemberShipTypesList SelectAll()
        {
            command.CommandText = $"SELECT * FROM MemberShipTypes";
            MemberShipTypesList groupList = new MemberShipTypesList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            MemberShipTypes mt = entity as MemberShipTypes;
            mt.TypeName = reader["TypeName"].ToString();
            mt.Price = int.Parse(reader["Price"].ToString());
            

            base.CreateModel(entity);
            return mt;
        }
        public override BaseEntity NewEntity()
        {
            return new MemberShipTypes();
        }
        static private MemberShipTypesList list = new MemberShipTypesList();

        public static MemberShipTypes SelectById(int id)
        {
            MemberShipTypesDB db = new MemberShipTypesDB();
            list = db.SelectAll();

            MemberShipTypes m = list.Find(item => item.Id == id);
            return m;
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            MemberShipTypes m = entity as MemberShipTypes;
            if (m != null)
            {
                string sqlStr = $"UPDATE MemberShipTypes Set TypeName=@typeName, Price=@price Where ID=@id";

                command.CommandText= sqlStr ;
                command.Parameters.Add(new OleDbParameter("@typeName",m.TypeName));
                command.Parameters.Add(new OleDbParameter("@price", m.Price));
                command.Parameters.Add(new OleDbParameter("@id", m.Id));
            }
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

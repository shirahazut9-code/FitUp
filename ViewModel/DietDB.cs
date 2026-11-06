using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Model;

namespace ViewModel
{
    public class DietDB:BaseDB
    {
        public DietList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Diet";
            DietList groupList = new DietList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Diet d = entity as Diet;
            d.IDFood = FoodDB.SelectById((int)reader["IDFood"]);
            d.IDMember =MembersDB.SelectById((int)reader["IDMember"]);
            d.MealTime = DateTime.Parse(reader["MealTime"].ToString());

            base.CreateModel(entity);
            return d;
        }
        public override BaseEntity NewEntity()
        {
            return new Diet();
        }
        static private DietList list = new DietList();

        public static Diet SelectById(int id)
        {
            DietDB db = new DietDB();
            list = db.SelectAll();

            Diet d = list.Find(item => item.Id == id);
            return d;
        }
       

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Diet t = entity as Diet;
            if (t != null)
            {
                string sqlStr = $"Insert INTO Diet (IDFood, IDMember, MealTime) VALUES (@iDFood, @iDMember, @MealTime)";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@iDFood", t.IDFood.Id));
                command.Parameters.Add(new OleDbParameter("@iDMember", t.IDMember.Id));
                command.Parameters.Add("@mealTime", t.MealTime);
            }
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }
        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Diet m = entity as Diet;
            if (m != null)
            {
                string sqlStr = $"UPDATE Diet Set IDFood=@iDFood , IDMember=@iDMember , MealTime=@mealTime Where ID=@id";
                

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@iDFood", m.IDFood.Id));
                command.Parameters.Add(new OleDbParameter("@iDMember", m.IDMember.Id));
                command.Parameters.Add("@mealTime", System.Data.OleDb.OleDbType.Date).Value = m.MealTime;    
                command.Parameters.Add(new OleDbParameter("@id", m.Id));

            }
        }
    }
}

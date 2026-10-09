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

    }
}

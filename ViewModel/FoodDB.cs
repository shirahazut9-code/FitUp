using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class FoodDB:BaseDB
    {
        public FoodList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Food";
            FoodList groupList = new FoodList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {           
            Food tt = entity as Food;
            tt.FoodName = reader["FoodName"].ToString();
            tt.Calories = int.Parse(reader["Calories"].ToString());
            tt.Proteins = int.Parse(reader["Proteins"].ToString());
            tt.Carbohydrates = int.Parse(reader["Carbohydrates"].ToString());
            tt.ImageLink = reader["ImageLink"].ToString();

            base.CreateModel(entity);
            return tt;
        }
        public override BaseEntity NewEntity()
        {
            return new Food();
        }
        static private FoodList list = new FoodList();

        public static Food SelectById(int id)
        {
            FoodDB db = new FoodDB();
            list = db.SelectAll();

            Food t = list.Find(item => item.Id == id);
            return t;
        }

       

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Food m = entity as Food;
            if (m != null)
            {
                string sqlStr = $"UPDATE Food Set FoodName=@foodName, Calories=@calories,  Proteins=@proteins , Carbohydrates=@carbohydrates ,ImageLink=@imageLink  Where ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@foodName", m.FoodName));
                command.Parameters.Add(new OleDbParameter("@calories", m.Calories));
                command.Parameters.Add(new OleDbParameter("@proteins", m.Proteins));
                command.Parameters.Add(new OleDbParameter("@carbohydrates", m.Carbohydrates));        
                command.Parameters.Add(new OleDbParameter("@imageLink", m.ImageLink));
                command.Parameters.Add(new OleDbParameter("@id", m.Id));
            }
        }
    }
}


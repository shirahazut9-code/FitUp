using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class TrainingTypesDB:BaseDB
    {
        public TrainingTypesList SelectAll()
        {
            command.CommandText = $"SELECT * FROM TrainingTypes";
            TrainingTypesList groupList = new TrainingTypesList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            TrainingTypes tt = entity as TrainingTypes;
            tt.TrainingName = reader["TrainingName"].ToString();
            tt.MaxParticipants =int.Parse(reader["MaxParticipants"].ToString());
            tt.LengthTraining = int.Parse(reader["LengthTraining"].ToString());

            base.CreateModel(entity);
            return tt;
        }
        public override BaseEntity NewEntity()
        {
            return new TrainingTypes();
        }
        static private TrainingTypesList list = new TrainingTypesList();

        public static TrainingTypes SelectById(int id)
        {
            TrainingTypesDB db = new TrainingTypesDB();
            list = db.SelectAll();

            TrainingTypes t = list.Find(item => item.Id == id);
            return t;
        }


        
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;


namespace ViewModel
{
    public class TrainingDB:BaseDB
    {
        public TrainingList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Training";
            TrainingList groupList = new TrainingList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Training t = entity as Training;
            t.IdTrainer = TrainersDB.SelectById((int)reader["IdTrainer"]);
            t.DateofTraining = DateOnly.Parse(reader["DateofTraining"].ToString());
            t.HourOfTraing= TimeOnly.Parse(reader["hourOfTraing"].ToString());
            t.TrainingTypeID= TrainingTypesDB.SelectById((int)reader["TrainingTypeID"]);

            base.CreateModel(entity);
            return t;
        }
        public override BaseEntity NewEntity()
        {
            return new Training();
        }
        static private TrainingList list = new TrainingList();

        public static Training SelectById(int id)
        {
            TrainingDB db = new TrainingDB();
            list = db.SelectAll();

            Training t = list.Find(item => item.Id == id);
            return t;
        }
    }
}
}

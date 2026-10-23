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

            DateTime dt1 = Convert.ToDateTime(reader["DateofTraining"]);
            t.DateofTraining = DateOnly.FromDateTime(dt1);
           

            DateTime dt2 = Convert.ToDateTime(reader["hourOfTraing"]);
            t.HourOfTraing = TimeOnly.FromDateTime(dt2);

            
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
            Training m = entity as Training;
            if (m != null)
            {
                string sqlStr = $"UPDATE Training Set IdTrainer=@idTrainer , DateofTraining=@dateofTraining , HourOfTraing=@hourOfTraing , TrainingTypeID=@trainingTypeID Where ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@idTrainer", m.IdTrainer.Id));
                command.Parameters.Add("@dateofTraining", System.Data.OleDb.OleDbType.Date).Value = m.DateofTraining;
                //DateTime dateToSave = t.DateofTraining.ToDateTime(TimeOnly.MinValue);
                command.Parameters.Add("@hourOfTraing", System.Data.OleDb.OleDbType.Date).Value = m.HourOfTraing;
                command.Parameters.Add(new OleDbParameter("@trainingTypeID", m.TrainingTypeID.Id));
                command.Parameters.Add(new OleDbParameter("@id", m.Id));

            }
        }
    }
}


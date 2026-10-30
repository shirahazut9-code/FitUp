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
            t.DateOfTraining = DateTime.Parse(reader["dateOfTraining"].ToString());


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
            Training t = entity as Training;
            if (t != null)
            {
                string sqlStr = $"Insert INTO Training (IdTrainer, DateOfTraining, TrainingTypeID) VALUES (@idTrainer, @dateOfTraining, @trainingTypeID)";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@idTrainer", t.IdTrainer.Id));
                command.Parameters.Add(new OleDbParameter("@dateOfTraining", t.DateOfTraining));
                command.Parameters.Add(new OleDbParameter("@trainingTypeID", t.TrainingTypeID.Id));
            }
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
                string sqlStr = $"UPDATE Training Set IdTrainer=@idTrainer , DateOfTraining=@dateOfTraining , TrainingTypeID=@trainingTypeID Where ID=@id";
                //string sqlStr = $"UPDATE Training Set IdTrainer=@idTrainer , DateofTraining=@dateofTraining , HourOfTraing=@hourOfTraing , TrainingTypeID=@trainingTypeID Where ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@idTrainer", m.IdTrainer.Id));
                command.Parameters.Add("@dateOfTraining", System.Data.OleDb.OleDbType.Date).Value = m.DateOfTraining;
                command.Parameters.Add(new OleDbParameter("@trainingTypeID", m.TrainingTypeID.Id));
                command.Parameters.Add(new OleDbParameter("@id", m.Id));

            }
        }
    }
}


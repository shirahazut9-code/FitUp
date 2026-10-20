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
            TrainingTypes m = entity as TrainingTypes;
            if (m != null)
            {
                string sqlStr = $"UPDATE TrainingTypes Set TrainingName=@trainingName, MaxParticipants=@maxParticipants , LengthTraining=@lengthTraining  Where ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@trainingName", m.TrainingName));
                command.Parameters.Add(new OleDbParameter("@maxParticipants", m.MaxParticipants));
                command.Parameters.Add(new OleDbParameter("@lengthTraining", m.LengthTraining));
                command.Parameters.Add(new OleDbParameter("@id", m.Id));
            }
        }
    }
}


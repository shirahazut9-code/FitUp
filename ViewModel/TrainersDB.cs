using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;



namespace ViewModel
{
    public class TrainersDB:PersonDB
    {
        public TrainersList SelectAll()
        {
            command.CommandText = $"SELECT Person.ID, Person.FirstName, Person.LastName, Person.PhonNumber, Person.Email, Person.Pass, Person.BirthDate, Person.Active, Trainers.Experience FROM (Person INNER JOIN Trainers ON Person.ID = Trainers.ID)";
            TrainersList groupList = new TrainersList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Trainers t = entity as Trainers;
            t.Experience=DateTime.Parse(reader["Experience"].ToString());

            base.CreateModel(entity);
            return t;
        }
        public override BaseEntity NewEntity()
        {
            return new Trainers();
        }
        static private TrainersList list = new TrainersList();

        public static Trainers SelectById(int id)
        {
            TrainersDB db = new TrainersDB();
            list = db.SelectAll();

            Trainers t = list.Find(item => item.Id == id);
            return t;
        }
        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Trainers m = entity as Trainers;
            if (m != null)
            {
                string sqlStr = $"UPDATE Trainers Set Experience=@experience Where ID=@id";

                command.CommandText = sqlStr;
                //command.Parameters.Add(new OleDbParameter("@firstName", m.FirstName));
                //command.Parameters.Add(new OleDbParameter("@lastName", m.LastName));
                //command.Parameters.Add(new OleDbParameter("@phonNumber", m.PhonNumber));
                //command.Parameters.Add(new OleDbParameter("@email", m.Email));
                //command.Parameters.Add(new OleDbParameter("@pass", m.Pass));
                //command.Parameters.Add("@birthDate", System.Data.OleDb.OleDbType.Date).Value = m.BirthDate;
                //command.Parameters.Add(new OleDbParameter("@active", m.Active));
                command.Parameters.Add("@experience", System.Data.OleDb.OleDbType.Date).Value =m.Experience;
                command.Parameters.Add(new OleDbParameter("@id", m.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Trainers t = entity as Trainers;
            if (t != null)
            {
                string sqlStr = $"Insert INTO Trainers ([ID], Experience) VALUES (@id, @experience)";
                command.CommandText = sqlStr;
                cmd.Parameters.Add("@id", t.Id);
                cmd.Parameters.Add("@experience", t.Experience);

            }        
        }
        public virtual void Insert(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                inserted.Add(new ChangeEntity(base.CreateInsertdSQL, entity));
                inserted.Add(new ChangeEntity(this.CreateInsertdSQL, entity));
            }
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Trainers tt = entity as Trainers;
            if (tt != null)
            {
                string sqlStr = $"DELETE FROM Trainers where id=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", tt.Id));
            }
        }

        public override void Update(BaseEntity entity)
        {
            Trainers trainers = entity as Trainers;
            if (trainers != null)
            {
                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }
        public virtual void DeleteFromTrainer(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                deleted.Add(new ChangeEntity(this.CreateDeletedSQL, entity));
            }
        }
        public virtual void Delete(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                deleted.Add(new ChangeEntity(this.CreateDeletedSQL, entity));
                deleted.Add(new ChangeEntity(base.CreateDeletedSQL, entity));
            }
        }


    }
}


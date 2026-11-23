using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;


namespace ViewModel
{
    public class ManagerDB:PersonDB
    {
        public ManagerList SelectAll()
        {
            command.CommandText = $"SELECT Person.ID, Person.FirstName, Person.LastName, Person.PhonNumber, Person.Email, Person.Pass, Person.BirthDate, Person.Active FROM (Manager INNER JOIN Person ON Manager.ID = Person.ID)";
            ManagerList groupList = new ManagerList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Manager t = entity as Manager;
          
            base.CreateModel(entity);
            return t;
        }
        public override BaseEntity NewEntity()
        {
            return new Manager();
        }
        static private ManagerList list = new ManagerList();

        public static Manager SelectById(int id)
        {
            ManagerDB db = new ManagerDB();
            list = db.SelectAll();

            Manager t = list.Find(item => item.Id == id);
            return t;
        }

        //protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        //{
        //    Manager m = entity as Manager;
        //    if (m != null)
        //    {
        //        string sqlStr = $"UPDATE Manager Set Where ID=@id";

        //        command.CommandText = sqlStr;
        //        command.Parameters.Add(new OleDbParameter("@id", m.Id));
        //    }
        //}
        public override void Update(BaseEntity entity)
        {
            Manager manager = entity as Manager;
            if (manager != null)
            {
                //updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Manager t = entity as Manager;
            if (t != null)
            {
                string sqlStr = $"Insert INTO Manager (Id) VALUES (@id)";
                command.CommandText = sqlStr;
                cmd.Parameters.Add("@id", t.Id);
            
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
            Manager tt = entity as Manager;
            if (tt != null)
            {
                string sqlStr = $"DELETE FROM Manager where id=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", tt.Id));
            }
        }
        public virtual void DeleteFromManager(BaseEntity entity)
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


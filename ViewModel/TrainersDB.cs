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
    }
}


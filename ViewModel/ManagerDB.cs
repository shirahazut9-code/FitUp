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
    }
}


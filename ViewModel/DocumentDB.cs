using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class DocumentDB: BaseDB
    {
        public DocumentList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Document";
            DocumentList groupList = new DocumentList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Document d = entity as Document;
            d.IDTrainer =  TrainersDB.SelectById((int)reader["IDTrainer"]);
            d.LinkToFile = reader["LinkToFile"].ToString();



            base.CreateModel(entity);
            return d;
        }
        public override BaseEntity NewEntity()
        {
            return new Document();
        }
        static private DocumentList list = new DocumentList();

        public static Document SelectById(int id)
        {
            DocumentDB db = new DocumentDB();
            list = db.SelectAll();

            Document t = list.Find(item => item.Id == id);
            return t;
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }
    }
}

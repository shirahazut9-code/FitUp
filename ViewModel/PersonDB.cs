using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class PersonDB : BaseDB
    {
        public PersonList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Person";
            PersonList pList = new PersonList(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Person p = entity as Person;
            p.FirstName = reader["FirstName"].ToString();
            p.LastName = reader["LastName"].ToString();
            p.PhonNumber = int.Parse(reader["PhonNumber"].ToString());
            p.Email = reader["Email"].ToString();
            p.Pass = reader["Pass"].ToString();
            p.BirthDate = DateTime.Parse(reader["BirthDate"].ToString());
            p.Active = bool.Parse(reader["Active"].ToString());



            base.CreateModel(entity);
            return p;
        }
        public override BaseEntity NewEntity()
        {
            return new Person();
        }
        static private PersonList list = new PersonList();
        public static Person SelectById(int id)
        {
            PersonDB db = new PersonDB();
            list = db.SelectAll();

            Person g = list.Find(item => item.Id == id);
            return g;
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
            Person m = entity as Person;
            if (m != null)
            {
                string sqlStr = $"UPDATE Person Set FirstName=@firstName , LastName=@lastName , PhonNumber=@phonNumber , Email=@email ," +
                    $" Pass=@pass ,BirthDate=@birthDate , Active=@activeactive  Where ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@firstName", m.FirstName));
                command.Parameters.Add(new OleDbParameter("@lastName", m.LastName));
                command.Parameters.Add(new OleDbParameter("@phonNumber", m.PhonNumber));
                command.Parameters.Add(new OleDbParameter("@email", m.Email));
                command.Parameters.Add(new OleDbParameter("@pass", m.Pass));
                command.Parameters.Add("@birthDate",System.Data.OleDb.OleDbType.Date).Value=m.BirthDate;              
                command.Parameters.Add(new OleDbParameter("@active", m.Active));                
                command.Parameters.Add(new OleDbParameter("@id", m.Id));
            }
        }
    }  
}

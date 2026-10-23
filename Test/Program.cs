using Model;
using System.Data;
using System.Reflection.Metadata;
using ViewModel;
namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TrainingTypesDB ...
            TrainingTypesDB db = new TrainingTypesDB();
            TrainingTypesList ttlist = db.SelectAll();
            foreach (TrainingTypes c in ttlist)
                Console.WriteLine($"{c.TrainingName},{c.MaxParticipants},{c.LengthTraining}");

            Console.WriteLine("==============================");

            //FoodDB
            FoodDB f = new FoodDB();
            FoodList flist = f.SelectAll();
            foreach (Food c in flist)
                Console.WriteLine($"{c.FoodName},{c.Calories},{c.Proteins},{c.Carbohydrates},{c.ImageLink}");

            Console.WriteLine("==============================");

            //MemberShipTypesDB
            MemberShipTypesDB mst = new MemberShipTypesDB();
            MemberShipTypesList mstlist = mst.SelectAll();
            foreach (MemberShipTypes c in mstlist)
                Console.WriteLine($"{c.TypeName},{c.Price}");

            Console.WriteLine("==============================");

            //DietDB
            DietDB dt = new DietDB();
            DietList dtList = dt.SelectAll();
            foreach (Diet c in dtList)
                Console.WriteLine($"{c.IDFood.FoodName},{c.IDMember.Id},{c.MealTime}");

            Console.WriteLine("========mEMBERS======================");

            //MembersDB
            MembersDB mt = new MembersDB();
            MembersList mtList = mt.SelectAll();
            foreach (Members c in mtList)
                Console.WriteLine($"{c.TypeName.TypeName},{c.ExpirationDate}");
            Console.WriteLine("==============================");

            //PersonDB
            PersonDB p = new PersonDB();
            PersonList pList = p.SelectAll();
            foreach (Person c in pList)
                Console.WriteLine($"{c.FirstName},{c.LastName},{c.PhonNumber},{c.Email},{c.Pass},{c.BirthDate},{c.Active}");

            Console.WriteLine("==============================");

            //TrainersDB
            TrainersDB tr = new TrainersDB();
            TrainersList trList = tr.SelectAll();
            foreach (Trainers c in trList)
                Console.WriteLine($"{c.Experience}");
            Console.WriteLine("============TrainingDB==================");

            //TrainingDB
            TrainingDB t = new TrainingDB();
            TrainingList tList = t.SelectAll();
            foreach (Training c in tList)
                Console.WriteLine($"{c.IdTrainer.Id},{c.DateofTraining},{c.HourOfTraing},{c.TrainingTypeID.Id}");
            Console.WriteLine("==============================");
            //Documentdb
            DocumentDB d = new DocumentDB();
            DocumentList dList = d.SelectAll();
            foreach (Model.Document c in dList)
                Console.WriteLine($"{c.IDTrainer.Id},{c.LinkToFile}");
            Console.WriteLine("==============================");
            //ManagerDB
            ManagerDB ma = new ManagerDB();
            ManagerList maList = ma.SelectAll();
            foreach (Manager c in maList)
                Console.WriteLine($"{c.Id}");
            Console.WriteLine("==============================");

            //BookingsDB
            BookingsDB b = new BookingsDB();
            BookingsList bList = b.SelectAll();
            foreach (Bookings c in bList)
                Console.WriteLine($"{c.IDMember.Id},{c.TrainingID.Id}");
            Console.WriteLine("==============================");

            //UpdateMemberShipTypes
            Console.WriteLine("=================UpdateMemberShipTypes=============");

            MemberShipTypesDB msst = new();
            MemberShipTypesList mstList = msst.SelectAll();
            foreach (MemberShipTypes c in mstList)
            {
                Console.WriteLine(c.Price);
                Console.WriteLine(c.TypeName);
            }
            MemberShipTypes MemberShipTypestoupdate = mstList[0];
            MemberShipTypestoupdate.Price += 44;
            MemberShipTypestoupdate.TypeName += "אאא";
            msst.Update(MemberShipTypestoupdate);
            int x= msst.SaveChanges();
            Console.WriteLine($"{x}rows were updated");

            //UpdatePerson
            Console.WriteLine("================UpdatePeson==============");
            Person personUpDate = pList[0];
            personUpDate.FirstName = "נועם";
            personUpDate.LastName = "כהן";
            personUpDate.PhonNumber = 8383;
            personUpDate.Email = "Noam@gmail.com";
            personUpDate.Pass = "8876";
            personUpDate.BirthDate = DateTime.Now;
            personUpDate.Active = false;

            //p.Update(personUpDate);
            // x= p.SaveChanges();
            //Console.WriteLine($"{x}rows were updated");
            // UPDateFood
            //Console.WriteLine("================UPDateFood==============");
            //Food FoodUpDate = flist[0];
            //FoodUpDate.FoodName += "fhjfhf";
            //FoodUpDate.Calories += 4748;
            //FoodUpDate.Proteins += 8383;
            //FoodUpDate.Carbohydrates += 58757;
            //FoodUpDate.ImageLink += "jdff";
            //f.Update(FoodUpDate);
            //x = f.SaveChanges();
            //Console.WriteLine($"{x}rows were updated");

            //UpdateTrainingTypes
            //Console.WriteLine("================UpdateTrainingTypes==============");
            //TrainingTypes TrainingTypesUpDate = ttlist[0];
            //TrainingTypesUpDate.TrainingName += "fhjfhf";
            //TrainingTypesUpDate.MaxParticipants += 4748;
            //TrainingTypesUpDate.LengthTraining += 8383;           
            //db.Update(TrainingTypesUpDate);
            //x = db.SaveChanges();
            //Console.WriteLine($"{x}rows were updated");

            //UpdateTrainers
            Console.WriteLine("================UpdateTrainers==============");
            Trainers trainersUpDate = trList[0];
            trainersUpDate.FirstName = "אלמוג";
            trainersUpDate.LastName = "כהן";
            trainersUpDate.PhonNumber = 8383;
            trainersUpDate.Email = "Almog@gmail.com";
            trainersUpDate.Pass = "6443";
            trainersUpDate.BirthDate = DateTime.Now;
            trainersUpDate.Active = false;
            trainersUpDate.Experience = DateTime.Now;
            tr.Update(trainersUpDate);
            x = tr.SaveChanges();
            Console.WriteLine($"{x}rows were updated");
            //UpDateMembers
            Console.WriteLine("================UpDateMembers==============");
            Members membersUpDate = mtList[0];
            membersUpDate.FirstName = "עדי";
            membersUpDate.LastName = "לוי";
            membersUpDate.PhonNumber = 0502223334;
            membersUpDate.Email = "Shira@gmail.com";
            membersUpDate.Pass = "55555";
            membersUpDate.BirthDate = DateTime.Now;
            membersUpDate.Active = false;
            membersUpDate.TypeName = mstlist[2];
            membersUpDate.ExpirationDate = DateTime.Now;                      
            mt.Update(membersUpDate);
            x = mt.SaveChanges();
            Console.WriteLine($"{x}rows were updated");

            //UpDateTraining
            Console.WriteLine("================UpDateTraining==============");
            Training trainingUpDate= tList[0];
            trainingUpDate.IdTrainer = trList[1];
            DateTime date = DateTime.Now;
            trainingUpDate.DateofTraining = DateOnly.FromDateTime(date);
            trainingUpDate.HourOfTraing = TimeOnly.FromDateTime(date);
            trainingUpDate.TrainingTypeID = ttlist[0];
            t.Update(trainingUpDate);
            x = t.SaveChanges();
            Console.WriteLine($"{x}rows were updated");


















        }

    } 
}
    
    


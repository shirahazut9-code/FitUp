using Model;
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






        }

    } 
}
    
    


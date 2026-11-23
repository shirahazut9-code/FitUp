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
            //foreach (TrainingTypes c in ttlist)
              //  Console.WriteLine($"{c.TrainingName},{c.MaxParticipants},{c.LengthTraining}");

            //Console.WriteLine("==============================");

            ////FoodDB
            FoodDB f = new FoodDB();
            FoodList flist = f.SelectAll();
            foreach (Food c in flist)
                Console.WriteLine($"{c.FoodName},{c.Calories},{c.Proteins},{c.Carbohydrates},{c.ImageLink}");

            //Console.WriteLine("==============================");

            ////MemberShipTypesDB
            MemberShipTypesDB mst = new MemberShipTypesDB();
            MemberShipTypesList mstlist = mst.SelectAll();
            foreach (MemberShipTypes c in mstlist)
                Console.WriteLine($"{c.TypeName},{c.Price}");

            //Console.WriteLine("==============================");

            ////DietDB
            DietDB dt = new DietDB();
            DietList dtList = dt.SelectAll();
            foreach (Diet c in dtList)
                Console.WriteLine($"{c.IDFood.FoodName},{c.IDMember.Id},{c.MealTime}");

            //Console.WriteLine("========mEMBERS======================");

            ////MembersDB
            MembersDB mt = new MembersDB();
            MembersList mtList = mt.SelectAll();
            foreach (Members c in mtList)
                Console.WriteLine($"{c.TypeName.TypeName},{c.ExpirationDate}");
            //Console.WriteLine("==============================");

            ////PersonDB
            PersonDB p = new PersonDB();
            PersonList pList = p.SelectAll();
            foreach (Person c in pList)
                Console.WriteLine($"{c.FirstName},{c.LastName},{c.PhonNumber},{c.Email},{c.Pass},{c.BirthDate},{c.Active}");

            //Console.WriteLine("==============================");

            ////TrainersDB
            TrainersDB tr = new TrainersDB();
            TrainersList trList = tr.SelectAll();
            foreach (Trainers c in trList)
                Console.WriteLine($"{c.Experience}");
            //Console.WriteLine("============TrainingDB==================");

            ////TrainingDB
            TrainingDB t = new TrainingDB();
            TrainingList tList = t.SelectAll();
            foreach (Training c in tList)
                Console.WriteLine($"{c.IdTrainer.Id},{c.DateOfTraining},{c.TrainingTypeID.Id}");
            //Console.WriteLine("==============================");
            ////Documentdb
            DocumentDB d = new DocumentDB();
            DocumentList dList = d.SelectAll();
            foreach (Model.Document c in dList)
                Console.WriteLine($"{c.IDTrainer.Id},{c.LinkToFile}");
            //Console.WriteLine("==============================");
            ////ManagerDB
            //ManagerDB ma = new ManagerDB();
            //ManagerList maList = ma.SelectAll();
            //foreach (Manager c in maList)
            //    Console.WriteLine($"{c.Id}");
            //Console.WriteLine("==============================");

            ////BookingsDB
            BookingsDB b = new BookingsDB();
            BookingsList bList = b.SelectAll();
            foreach (Bookings c in bList)
                Console.WriteLine($"{c.IDMember.Id},{c.TrainingID.Id}");
            Console.WriteLine("==============================");

            ////UpdateMemberShipTypes
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
            MemberShipTypestoupdate.TypeName = "אאא";
            msst.Update(MemberShipTypestoupdate);
            int x = msst.SaveChanges();
            Console.WriteLine($"{x}rows were updated");

            ////UpdatePerson
            Console.WriteLine("================UpdatePerson==============");
            Person personUpDate = pList[0];
            personUpDate.FirstName = "נועם";
            personUpDate.LastName = "כהן";
            personUpDate.PhonNumber = 8383;
            personUpDate.Email = "Noam@gmail.com";
            personUpDate.Pass = "8876";
            personUpDate.BirthDate = DateTime.Now;
            personUpDate.Active = false;
            p.Update(personUpDate);
            x = p.SaveChanges();
            Console.WriteLine($"{x}rows were updated");
            ////UPDateFood
            Console.WriteLine("================UPDateFood==============");
            Food FoodUpDate = flist[0];
            FoodUpDate.FoodName = "fhjfhf";
            FoodUpDate.Calories = 4748;
            FoodUpDate.Proteins = 8383;
            FoodUpDate.Carbohydrates = 58757;
            FoodUpDate.ImageLink = "jdff";
            f.Update(FoodUpDate);
            x = f.SaveChanges();
            Console.WriteLine($"{x}rows were updated");

            ////UpdateTrainingTypes
            Console.WriteLine("================UpdateTrainingTypes==============");
            TrainingTypes TrainingTypesUpDate = ttlist[0];
            TrainingTypesUpDate.TrainingName += "fhjfhf";
            TrainingTypesUpDate.MaxParticipants += 4748;
            TrainingTypesUpDate.LengthTraining += 8383;
            db.Update(TrainingTypesUpDate);
            x = db.SaveChanges();
            Console.WriteLine($"{x}rows were updated");

            ////UpdateTrainers
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
            ////UpDateMembers
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

            ////UpDateTraining
            Console.WriteLine("================UpDateTraining==============");
            Training trainingUpDate = tList[0];
            trainingUpDate.IdTrainer = trList[1];
            DateTime date = DateTime.Now;
            trainingUpDate.DateOfTraining = DateTime.Now;
            trainingUpDate.TrainingTypeID = ttlist[0];
            t.Update(trainingUpDate);
            x = t.SaveChanges();
            Console.WriteLine($"{x}rows were updated");

            ////Mangager

            ////DocumentDB          
            Console.WriteLine("================UpDateDocument==============");
            Model.Document DocumentUpDate = dList[0];
            DocumentUpDate.IDTrainer = trList[0];
            DocumentUpDate.LinkToFile = "Link";
            d.Update(DocumentUpDate);
            x = d.SaveChanges();
            Console.WriteLine($"{x}rows were updated");

            ////Diet
            Console.WriteLine("================UpDateDiet==============");
            Diet DietUpDate = dtList[0];
            DietUpDate.IDFood = flist[0];
            DietUpDate.IDMember = mtList[0];
            DietUpDate.MealTime = DateTime.Now;
            dt.Update(DietUpDate);
            x = dt.SaveChanges();
            Console.WriteLine($"{x}rows were updated");

            ////BookingsUpDate
            Console.WriteLine("================BookingsUpDate==============");
            Bookings BookingsUpDate = bList[0];
            BookingsUpDate.IDMember = mtList[0];
            BookingsUpDate.TrainingID = tList[0];
            b.Update(BookingsUpDate);
            x = b.SaveChanges();
            Console.WriteLine($"{x}rows were updated");

            ////Insert
            ////TrainingTypesInsert

            //Console.WriteLine("================TrainingTypesInsert==============");
            //TrainingTypesDB dddb = new();
            //TrainingTypes ttt = new TrainingTypes() {TrainingName = "אירובי", MaxParticipants = 6, LengthTraining = 50 };
            //dddb.Insert(ttt);
            //int y = dddb.SaveChanges();
            //Console.WriteLine($"{y}rows were inserted");

            ////TrainingInsert

            ////Console.WriteLine("======TrainingInsert=======");
            ////TrainingDB dddt = new();
            ////Training tt = new Training() { Id = 11, IdTrainer = trList[0], DateOfTraining = DateTime.Now, TrainingTypeID = ttlist[0] };
            ////dddt.Insert(tt);
            ////int a = dddb.SaveChanges();
            ////Console.WriteLine($"{a}rows were inserted");

            ////MemberShipTypesInsert 

            //Console.WriteLine("======MemberShipTypesInsert======="); 
            //MemberShipTypesDB dddm = new();
            //MemberShipTypes ttd = new MemberShipTypes() { TypeName = "XXXX", Price = 200 };
            //dddm.Insert(ttd);
            //int g = dddm.SaveChanges();
            //Console.WriteLine($"{g}rows were inserted");
            //PersonInsert

            //Console.WriteLine("======PersonInsert=======");
            //PersonDB dddp = new();
            //Person ttp = new Person() { FirstName = "שירה", LastName = "חזות", PhonNumber = 05833, Email = "shira@g", Pass = "ssss", BirthDate = DateTime.Today, Active = true };
            //dddp.Insert(ttp);
            //int pp = dddp.SaveChanges();
            //Console.WriteLine($"{pp}rows were inserted");

            //Trainersinsert
            //TrainersDB tdtd = new();
            //Trainers ttpp = new Trainers() { FirstName="רומי", LastName= "מחלוף", PhonNumber=08755,Email="ROMI@", Pass="ייי", BirthDate=DateTime.Today, Active=true,Experience=DateTime.Today};
            //tdtd.Insert(ttpp);
            //int tt = tdtd.SaveChanges();
            //Console.WriteLine($"{tt}rows were inserted");

            //MembersInsert
            //Console.WriteLine("======MembersInsert=======");
            //MembersDB mdm = new();
            //Members mtp = new Members() { FirstName="עדי", LastName= "כהן", PhonNumber=5473,Email="Adi@", Pass="pass", BirthDate=DateTime.Today, Active=true,TypeName= mstlist[0], ExpirationDate=DateTime.Today};
            //mdm.Insert(mtp);
            //int ttm = mdm.SaveChanges();
            //Console.WriteLine($"{ttm}rows were inserted");

            //Manager 
            //Console.WriteLine("======ManagerInsert=======");
            //ManagerDB mPm = new();
            //Manager mPp = new Manager() { FirstName = "יהלי", LastName = "כהן", PhonNumber = 5473, Email = "@GMAIL", Pass = "passSS", BirthDate = DateTime.Today, Active = true };
            //mPm.Insert(mPp);
            //int ttjp = mPm.SaveChanges();
            //Console.WriteLine($"{ttjp}rows were inserted");

            //Foodinsert
            //Console.WriteLine("======Foodinsert=======");
            //FoodDB mPmm = new();
            //Food mPpm = new Food() { FoodName = "בורקס", Calories=80, Proteins=87, Carbohydrates=65, ImageLink="Link" };
            //mPmm.Insert(mPpm);
            //int ttpm = mPmm.SaveChanges();
            //Console.WriteLine($"{ttpm}rows were inserted");

            //Document//        
            //Console.WriteLine("======Documentinsert=======");
            //DocumentDB mPmr = new();
            //Model.Document mPpr = new Model.Document() { IDTrainer = trList[3], LinkToFile = "Link" };
            //mPmr.Insert(mPpr);
            //int ttpr = mPmr.SaveChanges();
            //Console.WriteLine($"{ttpr}rows were inserted");


            //DietInsert
            //Console.WriteLine("======Dietinsert=======");
            //DietDB mPmt = new();
            //Diet mPpt = new Diet() { IDFood = flist[1], IDMember = mtList[0], MealTime = DateTime.Today };
            //mPmt.Insert(mPpt);
            //int ttdt = mPmt.SaveChanges();
            //Console.WriteLine($"{ttdt}rows were inserted");

            //BookingInsert
            //Console.WriteLine("======BookingInsert=======");
            //BookingsDB mPmw = new();
            //Bookings mPpw = new Bookings() { IDMember = mtList[0], TrainingID = tList[0] };
            //mPmw.Insert(mPpw);
            //int ttdw = mPmw.SaveChanges();
            //Console.WriteLine($"{ttdw}rows were inserted");

            //TrainingTypesDeleted
            //Console.WriteLine("TrainingTypesDeleted");
            //TrainingTypes tt1 = ttlist[0];
            //db.Delete(tt1);
            //int tt2 = db.SaveChanges();
            //Console.WriteLine($"{tt2} rows Deleted");

            //TrainingDeleted
            //Console.WriteLine("TrainingDeleted");
            //Training t1 = tList[0];
            //t.Delete(t1);
            //int t2 = t.SaveChanges();
            //Console.WriteLine($"{t2} rows Deleted");

            //MembersShipTypesDeleted
            //Console.WriteLine("MembersShipTypesDeleted");
            //MemberShipTypes mt1 = mstlist[0];
            //mst.Delete(mt1);
            //int mt2 = mst.SaveChanges();
            //Console.WriteLine($"{mt2} rows Deleted");

            //PersonDeleted
            //Console.WriteLine("PersonDeleted");
            //Person p1 = pList[0];
            //p.Delete(p1);
            //int p2 = p.SaveChanges();
            //Console.WriteLine($"{p2} rows Deleted");

            //FoodDeleted
            // Console.WriteLine("FoodDeleted");
            // Food f1 = flist[0];
            // f.Delete(f1);
            // int f2 = f.SaveChanges();
            //Console.WriteLine($"{f2} rows Deleted");

            //Diet
            //Console.WriteLine("DietDelted");
            //Diet d1 = dtList[2];
            //dt.Delete(d1);
            //int d2 = dt.SaveChanges();
            //Console.WriteLine($"{d2} rows Deleted");

            // מה שיורש לא בודקים את הפעולה של המחיקה , מסמנים שקר בתכונה של הפעיל.

            //Document
            //Console.WriteLine("DocumentDelted");
            //Model.Document dd1 = dList[0];
            //d.Delete(dd1);
            //int dd2 = d.SaveChanges();
            //Console.WriteLine($"{dd2} rows Deleted");

            //BookingD
            //Console.WriteLine("BookingDDelted");
            //Bookings b1 = bList[0];
            //b.Delete(b1);
            //int b2 = b.SaveChanges();
            //Console.WriteLine($"{b2} rows Deleted");




















































        }

    } 
}
    
    


using Model;
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
            Console.WriteLine("==============================");
            ////MembersDB
            //MembersDB mt = new MembersDB();
            //MembersList mtList = mt.SelectAll();
            //foreach (Members c in mtList)
            //    Console.WriteLine($"{c.TypeName},{c.IDMember.Id},{c.MealTime}");

           


        }

    } 
}
    
    


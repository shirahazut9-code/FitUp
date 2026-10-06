using Model;
using ViewModel;
namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TrainingTypesDB ...
            TrainingTypesDB db = new TrainingTypesDB();
            TrainingTypesList ttlist = db.SelectAll();
            foreach (TrainingTypes c in ttlist)
                Console.WriteLine($"{c.TrainingName},{c.MaxParticipants},{c.LengthTraining}");
            //FoodDB
            FoodDB f = new FoodDB();
            FoodList flist = f.SelectAll();
            foreach (Food c in flist)
                Console.WriteLine($"{c.FoodName},{c.Calories},{c.Proteins},{c.Carbohydrates},{c.ImageLink}");

            //MemberShipTypesDB
            MemberShipTypesDB mst = new MemberShipTypesDB();
            MemberShipTypesList mstlist = mst.SelectAll();
            foreach (MemberShipTypes c in mstlist)
                Console.WriteLine($"{c.TypeName},{c.Price}");
        }
    }
}

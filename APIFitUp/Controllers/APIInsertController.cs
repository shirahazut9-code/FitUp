using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace APIFitUp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class APIInsertController : ControllerBase
    {
        [HttpPost]
        public int InsertTrainingTypes(TrainingTypes trainingTypes)
        {
            TrainingTypesDB trainingTypesDB = new TrainingTypesDB();
            trainingTypesDB.Insert(trainingTypes);
            int t=trainingTypesDB.SaveChanges();
            return t;
        }
        [HttpPost]
        public int InsertTraining(Training training)
        {
            TrainingDB trainingDB = new TrainingDB();
            trainingDB.Insert(training);
            int t = trainingDB.SaveChanges();
            return t;
        }
        [HttpPost]
        public int InsertTrainers(Trainers trainers)
        {
            TrainersDB trainersDB = new TrainersDB();
            trainersDB.Insert(trainers);
            int t = trainersDB.SaveChanges();
            return t;
        }
        [HttpPost]
        public int InsertPerson(Person person)
        {
            PersonDB personDB = new PersonDB();
            personDB.Insert(person);
            int p = personDB.SaveChanges();
            return p;
        }
        [HttpPost]
        public int InsertMembers(Members members)
        {
            MembersDB membersDB = new MembersDB();
            membersDB.Insert(members);
            int m = membersDB.SaveChanges();
            return m;
        }
        [HttpPost]
        public int InsertMemberShipTypes(MemberShipTypes memberShipTypes)
        {
            MemberShipTypesDB memberShipTypesDB = new MemberShipTypesDB();
            memberShipTypesDB.Insert(memberShipTypes);
            int m = memberShipTypesDB.SaveChanges();
            return m;
        }
        [HttpPost]
        public int InsertManager(Manager manager)
        {
            ManagerDB managerDB = new ManagerDB();
            managerDB.Insert(manager);
            int m = managerDB.SaveChanges();
            return m;
        }
        [HttpPost]
        public int InsertFood(Food food)
        {
            FoodDB foodDB = new FoodDB();
            foodDB.Insert(food);
            int m = foodDB.SaveChanges();
            return m;
        }
        [HttpPost]
        public int InsertDocument(Document document)
        {
            DocumentDB documentDB = new DocumentDB();
            documentDB.Insert(document);
            int d = documentDB.SaveChanges();
            return d;
        }
        [HttpPost]
        public int InsertDiet(Diet diet)
        {
            DietDB dietDB = new DietDB();
            dietDB.Insert(diet);
            int d = dietDB.SaveChanges();
            return d;
        }
        [HttpPost]
        public int InsertBookinsg(Bookings bookings)
        {
            BookingsDB bookingsDB = new BookingsDB();
            bookingsDB.Insert(bookings);
            int b = bookingsDB.SaveChanges();
            return b;
        }












    }
}

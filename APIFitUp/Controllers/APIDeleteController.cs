using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace APIFitUp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class APIDeleteController : ControllerBase
    {
        [HttpDelete]
        public int DeleteTrainingTypes(TrainingTypes trainingTypes)
        {
            TrainingTypesDB trainingTypesDB=new TrainingTypesDB();
            trainingTypesDB.Delete(trainingTypes);
            int t= trainingTypesDB.SaveChanges();
            return t;
        }
        [HttpDelete]
        public int DeleteTraining(Training training)
        {
            TrainingDB trainingDB = new TrainingDB();
            trainingDB.Delete(training);
            int t = trainingDB.SaveChanges();
            return t;
        }
        [HttpDelete]
        public int DeleteTrainers(Trainers trainers)
        {
            TrainersDB trainersDB = new TrainersDB();
            trainersDB.Delete(trainers);
            int t = trainersDB.SaveChanges();
            return t;
        }
        [HttpDelete]
        public int DeletePerson(Person person)
        {
            PersonDB personDB = new PersonDB();
            personDB.Delete(person);
            int p = personDB.SaveChanges();
            return p;
        }
        [HttpDelete]
        public int DeleteMmebers(Members members)
        {
            MembersDB membersDB = new MembersDB();
            membersDB.Delete(members);
            int m = membersDB.SaveChanges();
            return m;
        }
        [HttpDelete]
        public int DeleteMmeberShipTypes(MemberShipTypes memberShipTypes)
        {
            MemberShipTypesDB memberShipTypesDB = new MemberShipTypesDB();
            memberShipTypesDB.Delete(memberShipTypes);
            int m = memberShipTypesDB.SaveChanges();
            return m;
        }
        [HttpDelete]
        public int DeleteManager(Manager manager)
        {
            ManagerDB managerDB = new ManagerDB();
            managerDB.Delete(manager);
            int m = managerDB.SaveChanges();
            return m;
        }
        [HttpDelete]
        public int DeleteFood(Food food)
        {
            FoodDB foodDB = new FoodDB();
            foodDB.Delete(food);
            int m = foodDB.SaveChanges();
            return m;
        }
        [HttpDelete]
        public int DeleteDocument(Document document)
        {
            DocumentDB documentDB = new DocumentDB();
            documentDB.Delete(document);
            int d = documentDB.SaveChanges();
            return d;
        }
        [HttpDelete]
        public int DeleteDiet(Diet diet)
        {
            DietDB dietDB = new DietDB();
            dietDB.Delete(diet);
            int d = dietDB.SaveChanges();
            return d;
        }
        [HttpDelete]
        public int DeleteBookings(Bookings bookings)
        {
            BookingsDB bookingsDB = new BookingsDB();
            bookingsDB.Delete(bookings);
            int d = bookingsDB.SaveChanges();
            return d;
        }











    }
}

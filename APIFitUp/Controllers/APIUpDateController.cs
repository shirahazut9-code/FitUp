using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace APIFitUp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class APIUpDateController : ControllerBase
    {
        [HttpPut]
        public int UpDateTrainingTypes(TrainingTypes trainingTypes)
        {
            TrainingTypesDB trainingTypesDB = new TrainingTypesDB();
            trainingTypesDB.Update(trainingTypes);
            int t = trainingTypesDB.SaveChanges();
            return t;
        }
        [HttpPut]
        public int UpDateTraining(Training training)
        {
            TrainingDB trainingDB = new TrainingDB();
            trainingDB.Update(training);
            int t = trainingDB.SaveChanges();
            return t;
        }
        [HttpPut]
        public int UpDateTrainers(Trainers trainers)
        {
            TrainersDB trainersDB = new TrainersDB();
            trainersDB.Update(trainers);
            int t = trainersDB.SaveChanges();
            return t;
        }
        [HttpPut]
        public int UpDatePerson(Person person)
        {
            PersonDB personDB = new PersonDB();
            personDB.Update(person);
            int p = personDB.SaveChanges();
            return p;
        }
        [HttpPut]
        public int UpDatemembers(Members members)
        {
            MembersDB membersDB = new MembersDB();
            membersDB.Update(members);
            int m = membersDB.SaveChanges();
            return m;
        }
        [HttpPut]
        public int UpDatememberShipTypes(MemberShipTypes memberShipTypes)
        {
            MemberShipTypesDB memberShipTypesDB = new MemberShipTypesDB();
            memberShipTypesDB.Update(memberShipTypes);
            int m = memberShipTypesDB.SaveChanges();
            return m;
        }
        [HttpPut]
        public int UpDateManager(Manager manager)
        {
            ManagerDB managerDB = new ManagerDB();
            managerDB.Update(manager);
            int m = managerDB.SaveChanges();
            return m;
        }
        [HttpPut]
        public int UpDateFood(Food food)
        {
            FoodDB foodDB = new FoodDB();
            foodDB.Update(food);
            int f = foodDB.SaveChanges();
            return f;
        }
        [HttpPut]
        public int UpDateDocument(Document document)
        {
            DocumentDB documentDB = new DocumentDB();
            documentDB.Update(document);
            int d = documentDB.SaveChanges();
            return d;
        }
        [HttpPut]
        public int UpDateDiet(Diet diet)
        {
            DietDB dietDB = new DietDB();
            dietDB.Update(diet);
            int d = dietDB.SaveChanges();
            return d;
        }
        [HttpPut]
        public int UpDateBooking(Bookings bookings)
        {
            BookingsDB bookingsDB = new BookingsDB();
            bookingsDB.Update(bookings);
            int b = bookingsDB.SaveChanges();
            return b;
        }











    }
}

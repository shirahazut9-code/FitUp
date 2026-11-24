using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace APIFitUp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class APISelectController : ControllerBase
    {
        [HttpGet]
        public TrainingTypesList SelectAllTrainingTypes()
        {
            TrainingTypesDB TrainingTypesdb = new TrainingTypesDB();
            TrainingTypesList trainingTypesList = TrainingTypesdb.SelectAll();
            return trainingTypesList;
        }
        [HttpGet]
        public TrainingList SelectAllTraining()
        {
            TrainingDB Trainingdb = new TrainingDB();
            TrainingList trainingList = Trainingdb.SelectAll();
            return trainingList;
        }
        [HttpGet]
        public PersonList SelectAllPerson()
        {
            PersonDB Persondb = new PersonDB();
            PersonList personList = Persondb.SelectAll();
            return personList;
        }
        [HttpGet]
        public TrainersList SelectAllTrainers()
        {
            TrainersDB trainersdb = new TrainersDB();
            TrainersList trainersList = trainersdb.SelectAll();
            return trainersList;
        }
        [HttpGet]
        public MembersList SelectAllMembers()
        {
            MembersDB membersdb = new MembersDB();
            MembersList membersList = membersdb.SelectAll();
            return membersList;
        }
        [HttpGet]
        public MemberShipTypesList SelectAllMemberShipTypes()
        {
            MemberShipTypesDB memberShipTypesdb = new MemberShipTypesDB();
            MemberShipTypesList memberShipTypesList = memberShipTypesdb.SelectAll();
            return memberShipTypesList;
        }
        [HttpGet]
        public ManagerList SelectAllManager()
        {
            ManagerDB managerdb = new ManagerDB();
            ManagerList managerList = managerdb.SelectAll();
            return managerList;
        }
        [HttpGet]
        public FoodList SelectAllFood()
        {
            FoodDB fooddb = new FoodDB();
            FoodList foodList = fooddb.SelectAll();
            return foodList;
        }
        [HttpGet]
        public DocumentList SelectAllDocument()
        {
            DocumentDB documentdb = new DocumentDB();
            DocumentList documentList = documentdb.SelectAll();
            return documentList;
        }
        [HttpGet]
        public DietList SelectAllDiet()
        {
            DietDB dietdb = new DietDB();
            DietList dietList = dietdb.SelectAll();
            return dietList;
        }
        [HttpGet]
        public BookingsList SelectAllBookings()
        {
            BookingsDB bookingsdb = new BookingsDB();
            BookingsList bookingsList = bookingsdb.SelectAll();
            return bookingsList;
        }
        
        






















    }
}

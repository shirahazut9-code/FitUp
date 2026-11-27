using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;    
using ViewModel;
using System.Net.Http.Json;

namespace ApiInterface
{
    public class ApiService : IApiInterface
    {
        string uri;
        public HttpClient client;
        public ApiService()
        {
            uri = "https://localhost:44396";
            client = new HttpClient();
        }
        public async Task<TrainingTypesList> GetTrainingTypes()
        {
            return await client.GetFromJsonAsync<TrainingTypesList>(uri + "/api/TrainingTypes");
        }
        public async Task<int> DeleteATrainingTypes(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Insert/DeleteTrainingTypes/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int>UpDateTrainingTypes(TrainingTypes trainingTypes)
        {
            return (await client.PutAsJsonAsync(uri + "/api/Insert/UpdateTrainingTypes", trainingTypes)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertTrainingTypes(TrainingTypes trainingTypes)
        {
            return (await client.PostAsJsonAsync(uri + "/api/Insert/InsertTrainingTypes", trainingTypes)).IsSuccessStatusCode ? 1 : 0;
        }

        //Training 
        public async Task<TrainingList> GetTraining()
        {
            return await client.GetFromJsonAsync<TrainingList>(uri + "/api/Training");
        }
        public async Task<int> DeleteATraining(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Insert/DeleteTraining/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpDateTraining(Training training)
        {
            return (await client.PutAsJsonAsync(uri + "/api/Insert/UpdateTraining", training)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertTraining(Training training)
        {
            return (await client.PostAsJsonAsync(uri + "/api/Insert/InsertTraining", training)).IsSuccessStatusCode ? 1 : 0;
        }

        //Trainers
        public async Task<TrainersList> GetTrainers()
        {
            return await client.GetFromJsonAsync<TrainersList>(uri + "/api/Trainers");
        }
        public async Task<int> DeleteATrainers(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Insert/DeleteTrainers/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpDateTrainers(Trainers trainers)
        {
            return (await client.PutAsJsonAsync(uri + "/api/Insert/UpdateTrainers", trainers)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertTrainers(Trainers trainers)
        {
            return (await client.PostAsJsonAsync(uri + "/api/Insert/InsertTrainers", trainers)).IsSuccessStatusCode ? 1 : 0;
        }

        //Person
        public async Task<PersonList> GetPerson()
        {
            return await client.GetFromJsonAsync<PersonList>(uri + "/api/Person");
        }
        public async Task<int> DeleteAPerson(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Insert/DeletePerson/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpDatePerson(Person person)
        {
            return (await client.PutAsJsonAsync(uri + "/api/Insert/UpdatePerson", person)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertPerson(Person person)
        {
            return (await client.PostAsJsonAsync(uri + "/api/Insert/InsertPerson", person)).IsSuccessStatusCode ? 1 : 0;
        }

        //Members
        public async Task<MembersList> GetMembers()
        {
            return await client.GetFromJsonAsync<MembersList>(uri + "/api/Members");
        }
        public async Task<int> DeleteAMembers(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Insert/DeleteMembers/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpDateMembers(Members members)
        {
            return (await client.PutAsJsonAsync(uri + "/api/Insert/UpdateMembers", members)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertMembers(Members members)
        {
            return (await client.PostAsJsonAsync(uri + "/api/Insert/InsertCity", members)).IsSuccessStatusCode ? 1 : 0;
        }
        //MemberShipTypes
        public async Task<MemberShipTypesList> GetMemberShipTypes()
        {
            return await client.GetFromJsonAsync<MemberShipTypesList>(uri + "/api/MemberShipTypes");
        }
        public async Task<int> DeleteAMemberShipTypes(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Insert/DeleteMemberShipTypes/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpDateMemberShipTypes(MemberShipTypes memberShipTypes)
        {
            return (await client.PutAsJsonAsync(uri + "/api/Insert/UpdateMemberShipTypes", memberShipTypes)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertMemberShipTypes(MemberShipTypes memberShipTypes)
        {
            return (await client.PostAsJsonAsync(uri + "/api/Insert/InsertMemberShipTypes", memberShipTypes)).IsSuccessStatusCode ? 1 : 0;
        }

        //Manager
        public async Task<ManagerList> GetManager()
        {
            return await client.GetFromJsonAsync<ManagerList>(uri + "/api/Manager");
        }
        public async Task<int> DeleteAManager(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Insert/DeleteManager/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpDatev(Manager manager)
        {
            return (await client.PutAsJsonAsync(uri + "/api/Insert/UpdateManager", manager)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertManager(Manager manager)
        {
            return (await client.PostAsJsonAsync(uri + "/api/Insert/InsertManager", manager)).IsSuccessStatusCode ? 1 : 0;
        }

        //Food
        public async Task<FoodList> GetFood()
        {
            return await client.GetFromJsonAsync<FoodList>(uri + "/api/Food");
        }
        public async Task<int> DeleteAFood(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Insert/DeleteFood/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpDateFood(Food food)
        {
            return (await client.PutAsJsonAsync(uri + "/api/Insert/UpdateFood",food)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertFood(Food food)
        {
            return (await client.PostAsJsonAsync(uri + "/api/Insert/InsertFood", food)).IsSuccessStatusCode ? 1 : 0;
        }
        //Document
        public async Task<DocumentList> GetDocument()
        {
            return await client.GetFromJsonAsync<DocumentList>(uri + "/api/Document");
        }
        public async Task<int> DeleteADocument(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Insert/DeleteDocument/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpDateDocument(Document document)
        {
            return (await client.PutAsJsonAsync(uri + "/api/Insert/UpdateDocument", document)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertDocument(Document document)
        {
            return (await client.PostAsJsonAsync(uri + "/api/Insert/InsertDocument", document)).IsSuccessStatusCode ? 1 : 0;
        }

        //Diet
        public async Task<DietList> GetDiet()
        {
            return await client.GetFromJsonAsync<DietList>(uri + "/api/Diet");
        }
        public async Task<int> DeleteADiet(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Insert/DeleteDiet/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpDateDiet(Diet diet)
        {
            return (await client.PutAsJsonAsync(uri + "/api/Insert/UpdateDiet", diet)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertDiet(Diet diet)
        {
            return (await client.PostAsJsonAsync(uri + "/api/Insert/InsertDiet", diet)).IsSuccessStatusCode ? 1 : 0;
        }

        //Bookings
        public async Task<BookingsList> GetBookings()
        {
            return await client.GetFromJsonAsync<BookingsList>(uri + "/api/Bookings");
        }
        public async Task<int> DeleteABookings(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Insert/DeleteBookings/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpDateBookings(Bookings bookings)
        {
            return (await client.PutAsJsonAsync(uri + "/api/Insert/UpdateBookings", bookings)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertDiet(Bookings bookings)
        {
            return (await client.PostAsJsonAsync(uri + "/api/Insert/InsertDiet", bookings)).IsSuccessStatusCode ? 1 : 0;
        }













    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Person:BaseEntity
    {
        private string firstName;
        private string lastName;
        private int phonNumber;
        private string email;
        private string pass;
        private DateTime birthDate;
        private bool active;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int PhonNumber { get => phonNumber; set => phonNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Pass { get => pass; set => pass = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public bool Active { get => active; set => active = value; }
    }
}

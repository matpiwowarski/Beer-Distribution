using BeerMaker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerMaker.Models
{
    // tutaj pola które podajemy przy tworzeniu/edycji użytkownika 
    public class WorkerEntry
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public UserType RoleType { get; set; }
    }
}

using BeerMaker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerMaker.Models
{
    // tutaj pola które będą widoczne po pobraniu użytkownika // NIE MOŻE BYĆ TUTAJ HASŁA
    public class WorkerViewer
    {
		public int ID { get; set; }
		public Guid Uuid { get; set; } // guuid tylko u¿ytkownik/admin/pracownik // dla reszty tylko ID
		public string Email { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PhoneNumber { get; set; }
		public string Address { get; set; }
		public DateTime DateOfBirth { get; set; }
		public UserType RoleType { get; set; }
	}
}

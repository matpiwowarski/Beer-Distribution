using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeerMaker.Models
{
	public class Client
	{
		public int ID { get; set; }
		public Guid Uuid { get; set; } // guuid tylko u¿ytkownik/admin/pracownik // dla reszty tylko ID
		public string Email { get; set; }
		public string HashedPassword { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PhoneNumber { get; set; }
		public string Address { get; set; }
		public DateTime DateOfBirth { get; set; }
		//public virtual ICollection<Statistics> Statistics { get; set; }
	}
}
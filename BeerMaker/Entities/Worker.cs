using BeerMaker.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeerMaker
{
	public class Worker
	{
		public int ID { get; set; }
		public Guid Uuid { get; set; } 
		public string Email { get; set; }
		public string HashedPassword { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PhoneNumber { get; set; }
		public string Address { get; set; }
		public string ImageFileName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public UserType RoleType { get; set; }
	}
}
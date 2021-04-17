using BeerMaker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerMaker.Models
{
    public class Warehouse
	{
		public int ID { get; set; }
		public string PhoneNumber { get; set; }
		public string Address { get; set; }
		public List<Beer> Beers { get; set; }
	}
}

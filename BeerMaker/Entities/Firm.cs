using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerMaker.Entities
{
    public class Firm
	{
		public int ID { get; set; }
		public string PhoneNumber { get; set; }
		public string Address { get; set; }
		public List<Client> Workers { get; set; }
	}
}

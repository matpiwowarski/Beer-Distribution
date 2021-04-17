using BeerMaker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerMaker.Entities
{
    public class Order
    {
        public Worker Worker { get; set; }
        public Client Client { get; set; }
        public List<Beer> BeerList { get; set; }
        public Warehouse Warehouse { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}

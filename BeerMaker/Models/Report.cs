using BeerMaker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerMaker.Models
{
    public class Report
    {
        public string title { get; set; }
        public DateTime date { get; set; }
        public int SoldBeersCount { get; set; }
        public List<Beer> BeerRanking { get; set; }
        public List<BeerType> BeerTypeRanking { get; set; }
    }
}

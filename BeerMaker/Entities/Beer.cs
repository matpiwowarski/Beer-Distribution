using BeerMaker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerMaker.Entities
{
    public class Beer
    {
		public int ID { get; set; }
		public string Name { get; set; }
		public BeerType BeerType { get; set; }
		public BeerPacking BeerPacking { get; set; }
		public double VolumeInLiters { get; set; }
		public DateTime DateOfBottling { get; set; }
		public double AlcoholContentInPercentage { get; set; }
		public double Bitterness { get; set; }
		public string Style { get; set; }
		public string AromaticTasteProfile { get; set; }
		public string Malt { get; set; }
		public List<double> Rating { get; set; }
		public double AverageRating { get; set; }
		public double Popularity { get; set; }
		public string Price { get; set; }
		public string ImageFileName { get; set; }
	}
}

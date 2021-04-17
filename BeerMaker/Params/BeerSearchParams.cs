using BeerMaker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerMaker.Params
{
    public class BeerSearchParams
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
		public double Rating { get; set; }
		public double Popularity { get; set; }
	}
}

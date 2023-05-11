using System;
namespace BreweryManagementSystem.DataContext.Entities
{
	public class BreweryBeerDo
	{
		public Int32 Id { set; get; }
		public Int32 BreweryId { set; get; }
		public Int32 BeerId { set; get; }
		public BeerDo? Beer { set; get; }
		public BreweryDo? Brewery {set; get;}
	}
}


using System;
namespace BreweryManagementSystem.DataContext.Entities
{
	public class BeerDo
	{
		public Int32 Id { set; get; }
		public String? Name {set; get;}
		public Decimal WholeSalePrice { set; get; }
		public Decimal RetailPrice { set; get; }
		public BreweryDo? Brewery { set; get; }
	}
}


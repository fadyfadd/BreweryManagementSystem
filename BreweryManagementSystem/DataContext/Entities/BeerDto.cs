using System;
namespace BreweryManagementSystem.DataContext
{
	public class BeerDto
	{
		public Int32 Id { set; get; }
		public String Name { set; get; } = "";	
		public Int32 BreweryId { set; get; }
	}
}


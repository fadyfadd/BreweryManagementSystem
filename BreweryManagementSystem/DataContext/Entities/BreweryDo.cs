using System;
namespace BreweryManagementSystem.DataContext.Entities
{
	public class BreweryDo
	{
        public Int32 Id { set; get; }
        public String? Name { set; get; }
        public IEnumerable<BeerDo>? Beers { set; get; }
	}
}


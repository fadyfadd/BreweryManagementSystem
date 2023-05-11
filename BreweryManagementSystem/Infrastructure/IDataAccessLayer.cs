using System;
using BreweryManagementSystem.Models;

namespace BreweryManagementSystem.Infrastructure
{
	public interface IDataAccessLayer
	{
		public List<Brewery> GetBeerDataSet();

		public void InsertBeer(Int32 brewerId, String BeerName, Decimal WholeSalePrice, Decimal RetailPrice);

		public void DeleteBeer(Int32 brewerId, Int32 beerId);

    }
}


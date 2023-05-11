using System;
using BreweryManagementSystem.Models;

namespace BreweryManagementSystem.Infrastructure
{
	public interface IBusinessLogic
	{
        public List<Brewery> GetListOfBeerByBrewery();

        public void InsertBeer(Int32 brewerId, String BeerName, Decimal WholeSalePrice, Decimal RetailPrice);

        public void DeleteBeer(Int32 brewerId, Int32 beerId);

    }
}


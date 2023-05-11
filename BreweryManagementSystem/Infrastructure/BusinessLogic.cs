using System;
using BreweryManagementSystem.Models;

namespace BreweryManagementSystem.Infrastructure
{
	public class BusinessLogic : IBusinessLogic
	{
		IDataAccessLayer accessLayer;

		public BusinessLogic(IDataAccessLayer accessLayer)
		{
			this.accessLayer = accessLayer; 
		}

        public List<Brewery> GetListOfBeerByBrewery()
        {
			var data = this.accessLayer.GetBeerDataSet();
			return data; 

        }

        public void InsertBeer(Int32 brewerId, String BeerName, Decimal WholeSalePrice, Decimal RetailPrice)
        {
			accessLayer.InsertBeer(brewerId, BeerName, WholeSalePrice, RetailPrice); 
		}

        public void DeleteBeer(Int32 brewerId, Int32 beerId)
		{
			accessLayer.DeleteBeer(brewerId, beerId);
		}
    }
}


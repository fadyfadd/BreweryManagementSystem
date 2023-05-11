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
    }
}


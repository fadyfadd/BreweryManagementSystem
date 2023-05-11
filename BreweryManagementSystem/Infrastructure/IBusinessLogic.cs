using System;
using BreweryManagementSystem.Models;

namespace BreweryManagementSystem.Infrastructure
{
	public interface IBusinessLogic
	{
        public List<Brewery> GetListOfBeerByBrewery();
         
    }
}


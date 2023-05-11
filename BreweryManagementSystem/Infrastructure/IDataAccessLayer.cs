using System;
using BreweryManagementSystem.Models;

namespace BreweryManagementSystem.Infrastructure
{
	public interface IDataAccessLayer
	{
		public List<Brewery> GetBeerDataSet();
		 
    }
}


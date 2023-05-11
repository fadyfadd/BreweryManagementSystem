using System;
using BreweryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BreweryManagementSystem.Infrastructure
{
	public class DataAccessLayer : IDataAccessLayer
	{
		BreweryManagementSystemContext  context;
          
        public List<Brewery> GetBeerDataSet()
        {

            List<Brewery> output = new List<Brewery>();
            var Breweries = context.Breweries.Include(b => b.BreweryBeers).ThenInclude(b => b.Beer).ToList();

            foreach (var brewery in Breweries)
            {
                Brewery current = new Brewery();
                current.Id = brewery.Id;
                current.Name = brewery.Name;
                current.BreweryBeers = new List<BreweryBeer>();

                foreach (var brewerybeer in brewery.BreweryBeers)
                {
                    current.BreweryBeers.Add(new BreweryBeer() {Id = brewerybeer.Id , Beer = new Beer() { Id = brewerybeer.Beer.Id , Name = brewerybeer.Beer.Name } });                     
                }

                output.Add(current);
            }

            return output;
        }

        public DataAccessLayer(BreweryManagementSystemContext context)
		{		
			this.context = context; 
		}
	}
}


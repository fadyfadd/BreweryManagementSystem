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

        public void InsertBeer(Int32 brewerId, String BeerName, Decimal WholeSalePrice, Decimal RetailPrice)
        {
            var b  = context.Breweries.Where(b => b.Id == brewerId).FirstOrDefault();
            context.BreweryBeers.Add(new BreweryBeer() { Beer = new Beer() { Name = BeerName , WholeSalePrice = WholeSalePrice , RetailPrice = RetailPrice} , Brewery = b });
            context.SaveChanges(); 
        }

        public void DeleteBeer(Int32 brewerId, Int32 beerId)
        {
            var b = context.BreweryBeers.Where(b => b.Brewery.Id == brewerId && b.Beer.Id == beerId).FirstOrDefault();

            if (b != null)
                context.BreweryBeers.Remove(b);

            var c = context.Beers.Where(b => b.Id == beerId).FirstOrDefault();

            if (c != null)
                context.Beers.Remove(c); 

            context.SaveChanges(); 

        }

    }
}


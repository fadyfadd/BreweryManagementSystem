using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BreweryManagementSystem.Models;

public partial class BreweryManagementSystemContext : DbContext
{  
 

    public virtual DbSet<Beer> Beers { get; set; }

    public virtual DbSet<Brewery> Breweries { get; set; }

    public virtual DbSet<BreweryBeer> BreweryBeers { get; set; }

    public virtual DbSet<WholeSaler> WholeSalers { get; set; }

    public virtual DbSet<WholeSalerBeer> WholeSalerBeers { get; set; }

    public virtual DbSet<WholeSalerStock> WholeSalerStocks { get; set; }

   
}

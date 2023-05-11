using System;
using System.Collections.Generic;

namespace BreweryManagementSystem.Models;

public partial class Beer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? WholeSalePrice { get; set; }

    public decimal? RetailPrice { get; set; }

    public virtual BreweryBeer? BreweryBeer { get; set; }

    public virtual ICollection<WholeSalerBeer> WholeSalerBeers { get; set; } = new List<WholeSalerBeer>();
}

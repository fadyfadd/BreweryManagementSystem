using System;
using System.Collections.Generic;

namespace BreweryManagementSystem.Models;

public partial class Brewery
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<BreweryBeer> BreweryBeers { get; set; } = new List<BreweryBeer>();
}

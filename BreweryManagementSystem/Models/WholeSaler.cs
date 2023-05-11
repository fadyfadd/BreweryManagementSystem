using System;
using System.Collections.Generic;

namespace BreweryManagementSystem.Models;

public partial class WholeSaler
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<WholeSalerBeer> WholeSalerBeers { get; set; } = new List<WholeSalerBeer>();
}

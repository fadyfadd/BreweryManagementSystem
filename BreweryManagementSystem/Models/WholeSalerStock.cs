using System;
using System.Collections.Generic;

namespace BreweryManagementSystem.Models;

public partial class WholeSalerStock
{
    public int Id { get; set; }

    public int? DefinedBeerId { get; set; }

    public int? Quantity { get; set; }

    public virtual WholeSalerBeer? DefinedBeer { get; set; }
}

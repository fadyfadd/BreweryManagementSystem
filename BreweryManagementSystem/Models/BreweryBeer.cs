using System;
using System.Collections.Generic;

namespace BreweryManagementSystem.Models;

public partial class BreweryBeer
{
    public int Id { get; set; }

    public int? BeerId { get; set; }

    public int? BreweryId { get; set; }

    public virtual Beer? Beer { get; set; }

    public virtual Brewery? Brewery { get; set; }
}

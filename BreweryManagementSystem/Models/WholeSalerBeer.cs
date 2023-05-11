using System;
using System.Collections.Generic;

namespace BreweryManagementSystem.Models;

public partial class WholeSalerBeer
{
    public int Id { get; set; }

    public int? WholeSalerId { get; set; }

    public int? BeerId { get; set; }

    public virtual Beer? Beer { get; set; }

    public virtual WholeSaler? WholeSaler { get; set; }

    public virtual ICollection<WholeSalerStock> WholeSalerStocks { get; set; } = new List<WholeSalerStock>();
}

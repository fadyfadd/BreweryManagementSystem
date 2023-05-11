﻿using System;
namespace BreweryManagementSystem.DataContext
{
    public class BreweryDto
    {
        public Int32 Id { set; get; }
        public String? Name { set; get; }
        public IEnumerable<BeerDto>? Beers { set; get; }
    }
}

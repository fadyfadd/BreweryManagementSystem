using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreweryManagementSystem.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BreweryManagementSystem.Controllers
{
    public class BreweryController : ControllerBase
    {
        IBusinessLogic businessLogic; 

        public BreweryController(IOptions<AppSettings> config, IBusinessLogic businessLogic)
        {
            this.businessLogic = businessLogic; 
        }

        [HttpGet("ListOfBeerByBrewery")]
        public Object ListOfBeerByBrewery()
        {
            var x = businessLogic.GetListOfBeerByBrewery();

            return x; 
        }

    }
}

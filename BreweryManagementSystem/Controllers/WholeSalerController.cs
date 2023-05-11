using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreweryManagementSystem.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BreweryManagementSystem.Controllers
{  
    public class WholeSalerController : BaseApiController
    {

        public WholeSalerController(IOptions<AppSettings> config , IBusinessLogic businessLogic)
        {
           
          
        }
    }
}


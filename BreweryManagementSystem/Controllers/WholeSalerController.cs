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

        [HttpPost()]
        public  ActionResult<List<String>> Index()
        {
           return new List<String>(); 
        }


        [HttpGet]
        public ActionResult<List<String>> xxxx()
        { 
            return new List<String>();
        }


        [HttpGet("{id}")]
        public ActionResult<List<String>> xxxxs()
        {
            return new List<String>();
        }



    }
}


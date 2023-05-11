using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreweryManagementSystem.Infrastructure;
using BreweryManagementSystem.Models;
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
        public IActionResult ListOfBeerByBrewery()
        {

            try
            {
                var res = businessLogic.GetListOfBeerByBrewery();
                return Ok(res);
            }
            catch (Exception)
            {
                return BadRequest("Error occured during operation");
            }          

             
        }

        [HttpGet("AddBeerByBrewery")]
        public IActionResult AddBeer(Int32 brewerId , String BeerName , Decimal WholeSalePrice , Decimal RetailPrice)
        {

            try
            {              
                businessLogic.InsertBeer(brewerId , BeerName , WholeSalePrice, RetailPrice);
                return Ok("Sucsess");
            }
            catch (Exception ex)
            {
                return BadRequest("Error occured during operation");
            }
           
        }

        [HttpGet("deleteBeerBrewery")]
        public IActionResult DeleteBeer(Int32 brewerId, Int32 beerId)
        {

            try
            {
                businessLogic.DeleteBeer(brewerId , beerId);
                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest("Error occured during operation");
            }

        }



    }
}

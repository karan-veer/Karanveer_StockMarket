using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.UserAPI.Models;
using StockMarket.UserAPI.Services;

namespace StockMarket.UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _service;
        public UserController(IUserService service) => _service = service;

        [HttpGet]
        public IActionResult get() 
        {
            return Ok("User Service");
        }
        [HttpGet]
        [Route("SearchCompany/{SearchText}")]
        public IActionResult SearchCompany(string SearchText) 
        {
            try
            {
                return Ok(_service.SearchCompany(SearchText));
            }
            catch(Exception Ex)
            {
                return StatusCode(500, Ex.Message);
            }
        }
    }
}

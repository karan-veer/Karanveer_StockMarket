using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.AccountAPI.Models;
using StockMarket.AccountAPI.Services;

namespace StockMarket.AccountAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountService _service;

        public AccountController(IAccountService service) => _service = service;

        [HttpGet]
        public IActionResult Get() {

            return Ok("Account Service");
        }
        [HttpPost]
        [Route("Validate")]
        public IActionResult Validate(Users user) {
            try
            {
                Users user = _service.Validate(user.UserName,user.Password);
                if (user == null)
                {
                    return Content("Invalid User");
                }
                else
                {
                    return Ok(user);
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            }


        [HttpPost]
        [Route("AddUser")]
        public IActionResult AddUser(Users item)
        {
            try 
            {
                _service.AddUser(item);
                return Ok(); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        [Route("UpdateUser")]
        public IActionResult UpdateUser(Users item)
        {
            try 
            {
                _service.UpdateUser(item);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}

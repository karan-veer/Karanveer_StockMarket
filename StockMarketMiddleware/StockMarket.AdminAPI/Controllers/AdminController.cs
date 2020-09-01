using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.AdminAPI.Services;
using StockMarket.AdminAPI.Models;
using System.Runtime.InteropServices.WindowsRuntime;

namespace StockMarket.AdminAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IAdminService _service;

        public AdminController(IAdminService service) => _service = service;
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Admin Service");
        }

        [HttpGet]
        [Route("GetAllCompany")]
        public IActionResult GetAllCompany()
        {
            try
            {
                return Ok(_service.GetAllCompany());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("GetCompanyById/{id}")]
        public IActionResult GetCompanyById(string id)
        {
            try
            {
                return Ok(_service.GetCompanyById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("AddCompany")]
        public IActionResult AddCompany(Company item)
        {
            try
            {
                _service.AddCompany(item);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        [Route("UpdateCompany")]
        public IActionResult UpdateComapny(Company item)
        {
            try
            {
                _service.UpdateCompany(item);
                return Ok();

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteCompany/{id}")]
        public IActionResult DeleteCompany(string id)
        {
            try
            {
                _service.DeleteCompany(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}

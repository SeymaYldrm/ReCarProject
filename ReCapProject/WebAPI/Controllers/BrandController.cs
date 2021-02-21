using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost("BrandAdd")]
        public IActionResult BrandAdd(Brand brand)
        {
            var result = _brandService.Add(brand);
            
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("BrandDelete")]
        public IActionResult BrandDelete(Brand brand)
        {
            var result = _brandService.Delete(brand);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("BrandUpdate")]
        public IActionResult BrandUpdate(Brand brand)
        {
            var result = _brandService.Update(brand);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getBrandAll")]
        public IActionResult GetCustomerAll()
        {
            var result = _brandService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getBrandById")]
        public IActionResult GetBrandById(int id)
        {
            var result = _brandService.GetById(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}

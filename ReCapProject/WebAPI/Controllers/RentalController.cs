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
    public class RentalController : ControllerBase
    {
        IRentalService _rentalService;

        public RentalController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpPost("RentalAdd")]
        public IActionResult RentalAdd(Rental rental)
        {
            var result = _rentalService.Add(rental);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("RentalDelete")]
        public IActionResult RentalDelete(Rental rental)
        {
            var result = _rentalService.Delete(rental);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("RentalUpdate")]
        public IActionResult RentalUpdate(Rental rental)
        {
            var result = _rentalService.Update(rental);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getRentalAll")]
        public IActionResult GetCustomerAll()
        {
            var result = _rentalService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getRentalById")]
        public IActionResult GetRentalById(int id)
        {
            var result = _rentalService.GetById(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}

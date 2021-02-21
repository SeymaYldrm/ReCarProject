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
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();

            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            var result = _carService.GetById(id);

            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("carAdd")]
        public IActionResult CarAdd(Car car)
        {
            var result = _carService.Add(car);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("carDelete")]
        public IActionResult CarDelete(Car car)
        {
            var result = _carService.Delete(car);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getByDailyPrice/{min}/{max}")]
        public IActionResult GetByDailyPrice(int min, int max)
        {
            var result = _carService.GetByDailyPrice(min,max);

            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getByModelYear")]
        public IActionResult GetByModelYear(int year)
        {
            var result = _carService.GetByModelYear(year);

            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("CarUpdate")]
        public IActionResult CarUpdate(Car car)
        {
            var result = _carService.Update(car);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}

using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        IColorService _colorService;

        public ColorController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpPost("ColorAdd")]
        public IActionResult ColorAdd(Color color)
        {
            var result = _colorService.Add(color);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("ColorDelete")]
        public IActionResult ColorDelete(Color color)
        {
            var result = _colorService.Delete(color);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("ColorUpdate")]
        public IActionResult ColorUpdate(Color color)
        {
            var result = _colorService.Update(color);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getColorAll")]
        public IActionResult GetCustomerAll()
        {
            var result = _colorService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getColorById")]
        public IActionResult GetColorById(int id)
        {
            var result = _colorService.GetById(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}

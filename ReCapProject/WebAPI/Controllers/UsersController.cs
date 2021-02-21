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
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("UserAdd")]
        public IActionResult UserAdd(User user)
        {
            var result = _userService.Add(user);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("UserDelete")]
        public IActionResult UserDelete(User user)
        {
            var result = _userService.Delete(user);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("UserUpdate")]
        public IActionResult UserUpdate(User user)
        {
            var result = _userService.Update(user);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getUserAll")]
        public IActionResult GetCustomerAll()
        {
            var result = _userService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getUserById")]
        public IActionResult GetUserById(int id)
        {
            var result = _userService.GetById(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}

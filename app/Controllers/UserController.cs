using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DTOs;
using app.Sevices.Abstract;
using Microsoft.AspNetCore.Mvc;
namespace restapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<UserDTO>>>> GetAllUsers()
        {
            return Ok(await _userService.GetAllUsers());
        }

        [HttpPost("AddUser")]
        public async Task<ActionResult<bool>> AddUser([FromBody]UserDTO user)
        {
            return Ok(await _userService.AddUser(user));
        }

        [HttpPut("UpdateUser")]
        public async Task<ActionResult<bool>> UpdateUser(UserDTO user)
        {
            return Ok(await _userService.UpdateUser(user));
        }

        [HttpGet("CheckIfUserExists/{email}/{password}")]
        public async Task<ActionResult<bool>> CheckIfUserExists(string email, string password)
        {
            return Ok(await _userService.CheckIfUserExists(email,password));
        }

        [HttpGet("FindUser/{email}/{password}")]
        public async Task<ActionResult<ServiceResponse<UserDTO>>> FindUser(string email, string password)
        {
            return Ok(await _userService.FindUser(email,password));
        }

        [HttpDelete("DeleteUser/{id}")]
        public async Task<ActionResult<bool>> DeleteUser(int id)
        {
            return Ok(await _userService.DeleteUser(id));
        }

    }
}
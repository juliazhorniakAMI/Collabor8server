using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DTOs;
using app.ModelsDTO.User;
using app.Sevices.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace restapi.Controllers
{
// wch - the following code is needed for authorization  
// ------------------------------------------------------
    [Authorize]
// wch - the previous code is needed for authorization  
// ------------------------------------------------------

    [ApiController]
    [Route("User")]
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

        [AllowAnonymous]
        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<bool>>> Register([FromBody] UserDTO user)
        {
            var response = await _userService.Register(user);
            if (!response.Success)
            {

                return BadRequest(response);

            }
            return Ok(response);
        }

        [HttpPut("UpdateUser")]
        public async Task<ActionResult<bool>> UpdateUser(UserDTO user)
        {
            return Ok(await _userService.UpdateUser(user));
        }

        [HttpGet("GetUser/{userId}")]
        public async Task<ActionResult<ServiceResponse<UserDashboardDTO>>> GetUser(int userId)
        {
            return Ok(await _userService.GetUser(userId));
        }
        [HttpGet("CheckIfUserExists/{email}")]
        public async Task<ActionResult<bool>> CheckIfUserExists(string email)
        {
            return Ok(await _userService.CheckIfUserExists(email));
        }

        [AllowAnonymous]
        [HttpGet("Login/{email}/{password}")]
        public async Task<ActionResult<ServiceResponse<UserDTO>>> Login(string email, string password)
        {
            var response = await _userService.Login(email, password);
            if (!response.Success)
            {

                return BadRequest(response);

            }
            return Ok(response);
           
        }

        [HttpDelete("DeleteUser/{userId}")]
        public async Task<ActionResult<bool>> DeleteUser(int userId)
        {
            return Ok(await _userService.DeleteUser(userId));
        }

    }
}
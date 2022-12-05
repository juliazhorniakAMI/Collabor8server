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
    [Route("api/[controller]")]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<RoleDTO>>>> GetAllRoles()
        {
            return Ok(await _roleService.GetAllRoles());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<RoleDTO>>> GetRoleById(int id)
        {
            return Ok(await _roleService.GetRoleById(id));
        }

        [HttpPost]
        public async Task<ActionResult<bool>> AddRole(RoleDTO role)
        {
            return Ok(await _roleService.AddRole(role));
        }

        [HttpPut]
        public async Task<ActionResult<bool>> UpdateRole(RoleDTO role)
        {
            return Ok(await _roleService.UpdateRole(role));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteRole(int id)
        {
            return Ok(await _roleService.DeleteRole(id));
        }

    }
}
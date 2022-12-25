using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DLL.Models.Enums;
using app.ModelsDTO;
using app.Sevices.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace app.Controllers
{
    [Route("[controller]")]
    public class C8orProjectController : Controller
    {
        private readonly IC8orProjectService _cpService;
        public C8orProjectController(IC8orProjectService cpService)
        {
            _cpService = cpService;
        }
        
        [HttpGet("GetListProjectsForC8or/{direction}/{userId}")]
        public async Task<ActionResult<ServiceResponse<List<C8orProjectDTO>>>> GetListProjectsForC8or(Direction direction,int userId)
        {
            return Ok(await _cpService.GetListProjectsForC8or(direction,userId));
        }

         [HttpGet("GetListC8orsForPjt/{direction}/{userId}")]
        public async Task<ActionResult<ServiceResponse<List<C8orProjectDTO>>>> GetListC8orsForPjt(Direction direction, int userId)
        {
            return Ok(await _cpService.GetListC8orsForPjt(direction,userId));
        }

        [HttpPost("C8orProject")]
        public async Task<ActionResult<bool>> AddC8orProject([FromBody]C8orProjectDTO cp)
        {
            return Ok(await _cpService.AddC8orProject(cp));
        }
          
    }
}
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
        
        [HttpGet("GetListProjectsForAllC8or/{direction}/{userId}")]
        public async Task<ActionResult<ServiceResponse<List<C8orProjectDTO>>>> GetListProjectsForAllC8or(Direction direction,int userId)
        {
            return Ok(await _cpService.GetListProjectsForAllC8or(direction,userId));
        }

         [HttpGet("GetListC8orsForAllPjt/{direction}/{userId}")]
        public async Task<ActionResult<ServiceResponse<List<C8orProjectDTO>>>> GetListC8orsForAllPjt(Direction direction, int userId)
        {
            return Ok(await _cpService.GetListC8orsForAllPjt(direction,userId));
        }
        [HttpGet("GetListProjectsForOneC8or/{direction}/{c8orId}")]
        public async Task<ActionResult<ServiceResponse<List<C8orProjectDTO>>>> GetListProjectsForOneC8or(Direction direction,int c8orId)
        {
            return Ok(await _cpService.GetListProjectsForOneC8or(direction,c8orId));
        }

         [HttpGet("GetListC8orsForOnePjt/{direction}/{pId}")]
        public async Task<ActionResult<ServiceResponse<List<C8orProjectDTO>>>> GetListC8orsForOnePjt(Direction direction, int pId)
        {
            return Ok(await _cpService.GetListC8orsForOnePjt(direction,pId));
        }

        [HttpPost("C8orProject")]
        public async Task<ActionResult<ServiceResponse<bool>>> AddC8orProject([FromBody]C8orProjectBrowseDTO cp)
        {
            return Ok(await _cpService.AddC8orProject(cp));
        }

        [HttpPut("UpdateC8orProject")]
        public async Task<ActionResult<bool>> UpdateC8orPjt(C8orProjectDashboardDTO cp)
        {
            return Ok(await _cpService.UpdateC8orPjt(cp));
        }

        [HttpDelete("Delete/{UserId}/{sphereId}/{pjtId}")]
        public async Task<ActionResult<bool>> DeleteC8orProject(int UserId,string sphereId,int pjtId)
        {
            return Ok(await _cpService.DeleteC8orProject(UserId, sphereId, pjtId));
        }

          
    }
}
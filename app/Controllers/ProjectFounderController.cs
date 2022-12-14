using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;
using app.Sevices.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace app.Controllers
{
    [Route("[controller]")]
    public class ProjectFounderController : Controller
    {
        private readonly IProjectFounderService _pfService;
        public ProjectFounderController(IProjectFounderService pfService)
        {
            _pfService = pfService;
        }

        [HttpGet("{founderId}",Name ="GetAllProjects")]
        public async Task<ActionResult<ServiceResponse<List<ProjectDTO>>>> GetAllPjtsByFounderId(int founderId)
        {
            return Ok(await _pfService.GetAllPjtsByFounderId(founderId));
        }

        [HttpGet("{pjtId}",Name ="GetAllFoundersByPjtId")]
        public async Task<ActionResult<ServiceResponse<List<ProjectFounderDTO>>>> GetAllFoundersByPjrtId(int pjtId)
        {
            return Ok(await _pfService.GetFoundersByProjectId(pjtId));
        }

       [HttpPost("{founderId}/{pjtId}")]
        public async Task<ActionResult<bool>> AddFounderToProject(int founderId,int pjtId)
        {
            return Ok(await _pfService.AddFounderToProject(founderId,pjtId));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteFounderFromProject(int id)
        {
            return Ok(await _pfService.DeleteFounderFromProject(id));
        }

    }
}
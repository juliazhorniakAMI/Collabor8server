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
    public class ProjectController : Controller
    {
       private readonly IProjectService _projectService;
        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }
    
        [HttpPost]
        public async Task<ActionResult<bool>> AddProject([FromBody]ProjectDTO p)
        {
            return Ok(await _projectService.AddProject(p));
        }

        [HttpPut]
        public async Task<ActionResult<bool>> UpdateProject(ProjectDTO p)
        {
            return Ok(await _projectService.UpdateProject(p));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteProject(int id)
        {
            return Ok(await _projectService.DeleteProject(id));
        }

    }
}
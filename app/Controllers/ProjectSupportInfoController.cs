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
    public class ProjectSupportInfoController : Controller
    {
         private readonly IProjectSupportInfoService _supportService;
        public ProjectSupportInfoController(IProjectSupportInfoService supportService)
        {
            _supportService = supportService;
        }

        [HttpGet("GetAllInfoByProjectId/{pjtId}")]
        public async Task<ActionResult<ServiceResponse<List<ProjectSupportInfoDTO>>>> GetAllInfoByProjectId(int pjtId)
        {
            return Ok(await _supportService.GetAllInfoByProjectId(pjtId));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<bool>>> AddSupportInfo([FromBody]ProjectSupportInfoDTO psi)
        {
            return Ok(await _supportService.AddSupportInfo(psi));
        }
        
        [HttpPut]
        public async Task<ActionResult<bool>> UpdateInfoForProject(ProjectSupportInfoDTO psi)
        {
            return Ok(await _supportService.UpdateInfoForProject(psi));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteInfoFromProject(int id)
        {
            return Ok(await _supportService.DeleteInfoFromProject(id));
        }
    }
}
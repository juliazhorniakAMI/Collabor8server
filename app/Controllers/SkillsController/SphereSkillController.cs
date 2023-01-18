using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;
using app.Sevices.Abstract.Skill;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace app.Controllers.SkillsController
{
    [Route("[controller]")]
    public class SphereSkillController : Controller
    {
         private readonly ISphereSkillService _sphereSkillService;

        public SphereSkillController(ISphereSkillService sphereSkillService)
        {
            _sphereSkillService = sphereSkillService;
        }

        [HttpGet("GetSkillsBySphereId/{sphereId}")]
        public async Task<ActionResult<ServiceResponse<List<SkillDTO>>>> GetSkillsBySphereId(string sphereId)
        {
            return Ok(await _sphereSkillService.GetSkillsBySphereId(sphereId));
        }
    }
}
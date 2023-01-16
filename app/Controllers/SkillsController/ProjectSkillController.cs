using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO.Skills;
using app.Sevices.Abstract.Skill;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace app.Controllers.SkillsController
{
    [Route("[controller]")]
    public class ProjectSkillController : Controller
    { private readonly IProjectSkillService _pjtskillService;
        public ProjectSkillController(IProjectSkillService pjtskillService)
        {
            _pjtskillService = pjtskillService;
        }

        [HttpGet("GetProjectSkills/{pjtId}")]
        public async Task<ActionResult<ServiceResponse<List<ProjectSkillDTO>>>> GetProjectSkills(int pjtId)
        {
            return Ok(await _pjtskillService.GetAll(pjtId));
        }

        [HttpPost("AddProjectSkill/{pjtId}/{skillId}")]
        public async Task<ActionResult<ServiceResponse<bool>>> AddProjectSkill(int pjtId,int skillId)
        {
            return Ok(await _pjtskillService.AddProjectSkill(pjtId,skillId));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteProjectSkill(int id)
        {
            return Ok(await _pjtskillService.DeleteProjectSkill(id));
        }
    }
}
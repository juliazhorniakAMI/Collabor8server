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

namespace app.Controllers.SkillController
{
    [Route("[controller]")]
    public class C8orSkillController : Controller
    {
       private readonly IC8orSkillService _c8orskillService;
        public C8orSkillController(IC8orSkillService c8orskillService)
        {
            _c8orskillService = c8orskillService;
        }

        [HttpGet("GetMySkills/{c8orId}")]
        public async Task<ActionResult<ServiceResponse<List<C8orSkillDTO>>>> GetMySkills(int c8orId)
        {
            return Ok(await _c8orskillService.GetAll(c8orId));
        }

        [HttpPost("{c8orId}/{skillId}")]
        public async Task<ActionResult<ServiceResponse<bool>>> AddC8orSkill(int c8orId,int skillId)
        {
            return Ok(await _c8orskillService.AddC8orSkill(c8orId,skillId));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteC8orSkill(int id)
        {
            return Ok(await _c8orskillService.DeleteC8orSkill(id));
        }
      
    }
}
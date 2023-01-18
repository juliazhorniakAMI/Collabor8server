using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;

namespace app.Sevices.Abstract.Skill
{
    public interface ISphereSkillService
    {
      Task<ServiceResponse<List<SkillDTO>>> GetSkillsBySphereId(string sphereId);
    
    }
}
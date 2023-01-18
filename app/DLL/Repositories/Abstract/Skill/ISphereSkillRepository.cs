using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;

namespace app.DLL.Repositories.Abstract.Skill
{
    public interface ISphereSkillRepository
    {
      Task<ServiceResponse<List<SkillDTO>>> GetSkillsBySphereId(string sphereId);
        
    }
}
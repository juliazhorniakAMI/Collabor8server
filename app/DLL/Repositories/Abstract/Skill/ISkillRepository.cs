using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;

namespace app.DLL.Repositories.Abstract
{
    public interface ISkillRepository
    {
          Task<ServiceResponse<List<SkillDTO>>> GetAllSkills();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO.Skills;
namespace app.Sevices.Abstract.Skill
{
    public interface IC8orSkillService
    {
        Task<ServiceResponse<List<C8orSkillDTO>>> GetAll(int c8or);
        Task<ServiceResponse<bool>> AddC8orSkill(C8orSkillDTO c);
        Task<bool> DeleteC8orSkill(C8orSkillDTO c);
    }
}
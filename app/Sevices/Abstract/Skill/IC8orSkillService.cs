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
        Task<bool> AddC8orSkill(int c8orId,int skillId);
        Task<bool> DeleteC8orSkill(int id);
    }
}
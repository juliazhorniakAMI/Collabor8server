using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO.Skills;
namespace app.Sevices.Abstract.Skill
{
    public interface IProjectSkillService
    {
        Task<ServiceResponse<List<ProjectSkillDTO>>> GetAll(int pjtId);
        Task<bool> AddProjectSkill(int pjtId,int skillId);
        Task<bool> DeleteProjectSkill(int id);
    }
}
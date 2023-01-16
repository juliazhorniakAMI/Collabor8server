using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO.Skills;

namespace app.DLL.Repositories.Abstract.Skill
{
    public interface IProjectSkillRepository
    {
        Task<ServiceResponse<List<ProjectSkillDTO>>> GetAll(int pjtId);
        Task<ServiceResponse<bool>> AddProjectSkill(int pjtId, int skillId);
        Task<bool> DeleteProjectSkill(int id);

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DLL.Repositories.Abstract.Skill;
using app.ModelsDTO.Skills;
using app.Sevices.Abstract.Skill;
namespace app.Sevices.Impl.Skill
{
    public class ProjectSkillService:IProjectSkillService
    {  private readonly IProjectSkillRepository _Repository;
        public ProjectSkillService(IProjectSkillRepository Repository)
        {
            _Repository=Repository;       
        }
        public Task<ServiceResponse<bool>> AddProjectSkill(int pjtId, int skillId)
        {
           return _Repository.AddProjectSkill(pjtId,skillId);
        }
        public Task<bool> DeleteProjectSkill(int id)
        {
            return _Repository.DeleteProjectSkill(id);
        }
        public Task<ServiceResponse<List<ProjectSkillDTO>>> GetAll(int pjtId)
        {
           return _Repository.GetAll(pjtId);
        }
    }
}
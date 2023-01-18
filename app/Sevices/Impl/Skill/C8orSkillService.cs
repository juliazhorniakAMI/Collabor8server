using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO.Skills;
using app.Sevices.Abstract.Skill;
using app.DLL.Repositories.Abstract.Skill;
namespace app.Sevices.Impl.Skill
{
    public class C8orSkillService : IC8orSkillService
    {
        private readonly IC8orSkillRepository _Repository;
        public C8orSkillService(IC8orSkillRepository Repository)
        {
            _Repository=Repository;       
        }
        public Task<ServiceResponse<bool>> AddC8orSkill(C8orSkillDTO c)
        {
            return _Repository.AddC8orSkill(c);
        }
        public Task<bool> DeleteC8orSkill(C8orSkillDTO c)
        {
             return _Repository.DeleteC8orSkill(c);
        }

        public Task<ServiceResponse<List<C8orSkillDTO>>> GetAll(int c8or)
        {
             return _Repository.GetAll(c8or);
        }
    }
}
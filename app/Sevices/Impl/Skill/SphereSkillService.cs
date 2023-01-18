using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DLL.Repositories.Abstract.Skill;
using app.ModelsDTO;
using app.Sevices.Abstract.Skill;

namespace app.Sevices.Impl.Skill
{
    public class SphereSkillService : ISphereSkillService
    {
        private readonly ISphereSkillRepository _Repository;
        public SphereSkillService(ISphereSkillRepository Repository)
        {
            _Repository=Repository;       
        }
        public Task<ServiceResponse<List<SkillDTO>>> GetSkillsBySphereId(string sphereId)
        {
           return _Repository.GetSkillsBySphereId(sphereId);
        }
    }
}
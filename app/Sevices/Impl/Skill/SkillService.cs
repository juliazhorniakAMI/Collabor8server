using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DLL.Repositories.Abstract;
using app.ModelsDTO;
using app.Sevices.Abstract;

namespace app.Sevices.Impl
{
    public class SkillService : ISkillService
    {
          private readonly ISkillRepository _Repository;
            public SkillService(ISkillRepository Repository)
        {
            _Repository=Repository;       
        }
        public Task<ServiceResponse<List<SkillDTO>>> GetAllSkills()
        {
           return _Repository.GetAllSkills();
        }
    }
}
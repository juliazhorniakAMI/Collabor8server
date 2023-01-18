using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Context;
using app.DLL.Models;
using app.DLL.Repositories.Abstract.Skill;
using app.ModelsDTO;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace app.DLL.Repositories.Impl.Skill
{
    public class SphereSkillRepository : GenericKeyRepository<int, SphereSkill, DataContext>, ISphereSkillRepository
    { 
         private readonly IMapper _mapper;
          public SphereSkillRepository(DataContext context, IMapper mapper) : base(context)
        {
           _mapper = mapper  ;
        }
        public async Task<ServiceResponse<List<SkillDTO>>> GetSkillsBySphereId(string sphereId)
        {
             return new ServiceResponse<List<SkillDTO>>
            {
                Data = await Context.SphereSkills.Where(x => x.SphereId == sphereId)
               .Select(c => _mapper.Map<SkillDTO>(c)).ToListAsync()
            };    
        }
    }
}
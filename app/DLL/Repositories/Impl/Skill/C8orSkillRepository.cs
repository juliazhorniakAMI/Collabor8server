using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Context;
using app.Controllers.SkillController;
using app.DLL.Repositories.Abstract.Skill;
using app.ModelsDTO.Skills;
using AutoMapper;
using app.DLL.Models;
using Microsoft.EntityFrameworkCore;

namespace app.DLL.Repositories.Impl.Skill
{
    public class C8orSkillRepository : GenericKeyRepository<int,Models.C8orSkill, DataContext>, IC8orSkillRepository
    {
        private readonly IMapper _mapper;
        public C8orSkillRepository(DataContext context, IMapper mapper) : base(context)
        {
           _mapper = mapper  ;
        }
        public async Task<ServiceResponse<bool>> AddC8orSkill(C8orSkillDTO c)
        {
            C8orSkill r= _mapper.Map<C8orSkillDTO, C8orSkill>(c);
            return await Add(r); 
        }

        public async Task<bool> DeleteC8orSkill(C8orSkillDTO c)
        {
            var cs = await Context.C8orSkills.FirstAsync(x=>(x.UserId==c.UserId && x.SphereId==c.SphereId && x.SkillId==c.SkillId));
            return await Delete(cs);
        }

        public async Task<Models.ServiceResponse<List<C8orSkillDTO>>> GetAll(int c8or)
        {
              return new ServiceResponse<List<C8orSkillDTO>>
            {
                Data = await Context.C8orSkills.Where(x=>x.UserId==c8or).Include(x=>x.Skill).Select(c => _mapper.Map<C8orSkillDTO>(c)).ToListAsync()
            };
        }
    }
}
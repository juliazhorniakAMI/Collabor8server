using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Context;
using app.DLL.Models;
using app.DLL.Repositories.Abstract.Skill;
using app.ModelsDTO.Skills;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace app.DLL.Repositories.Impl.Skill
{
    public class ProjectSkillRepository : GenericKeyRepository<int,Models.ProjectSkill, DataContext>,IProjectSkillRepository
    {
        private readonly IMapper _mapper;
        public ProjectSkillRepository(DataContext context, IMapper mapper) : base(context)
        {
           _mapper = mapper  ;
        }
        public async Task<ServiceResponse<bool>> AddProjectSkill(int pjtId, int skillId)
        {
             return await Add(new Models.ProjectSkill(){ProjectId=pjtId});    
            //return await Add(new Models.ProjectSkill(){ProjectId=pjtId,SkillId=skillId});    
        }
        public async Task<bool> DeleteProjectSkill(int id)
        {
            var cs = await GetById(id);
            return await Delete(cs);
        }
        public async Task<ServiceResponse<List<ProjectSkillDTO>>> GetAll(int pjtId)
        {
              return new ServiceResponse<List<ProjectSkillDTO>>
            {
                Data = await Context.ProjectSkills.Where(x=>x.ProjectId==pjtId).Include(x=>x.Skill).Select(c => _mapper.Map<ProjectSkillDTO>(c)).ToListAsync()
            };
        }
    }
}
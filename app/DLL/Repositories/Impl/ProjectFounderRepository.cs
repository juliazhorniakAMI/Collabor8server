using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Context;
using app.DLL.Models;
using app.DLL.Repositories.Abstract;
using app.ModelsDTO;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace app.DLL.Repositories.Impl.Skill
{
    public class ProjectFounderRepository : GenericKeyRepository<int, ProjectFounder, DataContext>, IProjectFounderRepository
    {
        private readonly IMapper _mapper;
        public ProjectFounderRepository(DataContext context, IMapper mapper) : base(context)
        {
           _mapper = mapper  ;
        }
        public async Task<bool> AddFounderToProject(int founderId, int pjtId)
        {
             return await Add(new ProjectFounder(){FounderId=founderId,ProjectId=pjtId});
        }
        public async Task<bool> DeleteFounderFromProject(int id)
        {
              var fp = await GetById(id);
            return await Delete(fp);
        }
        public async Task<ServiceResponse<List<ProjectFounderDTO>>> GetAllPjtsByFounderId(int founderId)
        {
           return  new ServiceResponse<List<ProjectFounderDTO>>
            {
                Data = await Context.ProjectFounders.Include(x=>x.Project)
                .ThenInclude(x=>x.PM)
                .ThenInclude(x=>x.User).Include(x=>x.Founder)
                .Select(c => _mapper.Map<ProjectFounderDTO>(c)).Where(x=>x.FounderId==founderId).ToListAsync()
            };
        }
        public async Task<ServiceResponse<List<ProjectFounderDTO>>> GetFoundersByProjectId(int pjtId)
        {
             return  new ServiceResponse<List<ProjectFounderDTO>>
            {
                Data = await Context.ProjectFounders.Include(x=>x.Project)
                .ThenInclude(x=>x.PM)
                .ThenInclude(x=>x.User) .Include(x=>x.Founder)
                .ThenInclude(x=>x.User).Select(c => _mapper.Map<ProjectFounderDTO>(c)).Where(x=>x.ProjectId==pjtId).ToListAsync()
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Context;
using app.DLL.Models;
using app.DLL.Models.Enums;
using app.DLL.Repositories.Abstract;
using app.ModelsDTO;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace app.DLL.Repositories.Impl
{
    public class C8orProjectRepository : GenericKeyRepository<int, C8orProject, DataContext>, IC8orProjectRepository
    {
         private readonly IMapper _mapper;
          public C8orProjectRepository(DataContext context, IMapper mapper) : base(context)
        {
           _mapper = mapper  ;
        }
        public async Task<bool> AddC8orProject(C8orProjectDTO cp)
        {
            C8orProject r= _mapper.Map<C8orProjectDTO, C8orProject>(cp);
            return await Add(r); 
        }
        public async Task<ServiceResponse<List<C8orProjectDTO>>> GetListProjectsForC8or(Direction direction, int userId)
        { 
              return new ServiceResponse<List<C8orProjectDTO>>
            {
                Data = await Context.C8orsProjects.Where(x =>(x.Collabor8or.UserId == userId && x.Direction==direction)).Include(x => x.Collabor8or).ThenInclude(x => x.User).Include(x=>x.Project)
               .Select(c => _mapper.Map<C8orProjectDTO>(c)).ToListAsync()
            };    
          
        }
          public async Task<ServiceResponse<List<C8orProjectDTO>>> GetListC8orsForPjt(Direction direction, int userId)
        { 
              return new ServiceResponse<List<C8orProjectDTO>>
            {
                Data = await Context.C8orsProjects.Where(x => (x.Project.Founders.Any(x=>x.UserId==userId) && x.Direction==direction) ).Include(x=>x.Project).ThenInclude(x=>x.Founders).ThenInclude(x => x.User)
               .Select(c => _mapper.Map<C8orProjectDTO>(c)).ToListAsync()
            };    
          
        }
    }
}
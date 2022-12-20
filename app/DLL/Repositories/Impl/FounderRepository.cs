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
namespace app.DLL.Repositories.Impl
{
    public class FounderRepository : GenericKeyRepository<int, Founder, DataContext>, IFounderRepository
    {   private readonly IMapper _mapper;
        public FounderRepository(DataContext context, IMapper mapper) : base(context)
        {
           _mapper = mapper  ;
        }
        public async Task<bool> AddFounder(FounderDTO founder)
        {
            Founder r= _mapper.Map<FounderDTO, Founder>(founder);
            return await Add(r);     
        }
         public async Task<bool> AddOtherFounders(PostOtherFoundersDTO founder)
        {
            Founder r= _mapper.Map<PostOtherFoundersDTO, Founder>(founder);
            return await Add(r);     
        }
        public async Task<ServiceResponse<List<FounderDTO>>> GetFoundersByProjectId(int pjtId,int userId)
        {
             return  new ServiceResponse<List<FounderDTO>>
            {
                Data = await Context.Founders.Where(x=>(x.ProjectId==pjtId && x.UserId!=userId)).Include(x=>x.Project).Select(c => _mapper.Map<FounderDTO>(c)).ToListAsync()
            };
        }
        public async Task<bool> DeleteFounder(int id)
        {
            var p = await GetById(id);
            return await Delete(p);
        }
        public async Task<bool> UpdateFounder(FounderDTO founder)
        {
            var existingFounder =  Context.Founders.First(x => x.Id == founder.Id);
            existingFounder.BackgroundSummary = founder.BackgroundSummary;
            existingFounder.Resume = founder.Resume;
            existingFounder.Project = _mapper.Map<ProjectDTO, Project>(founder.Project);
            return await Update(existingFounder);
        }
        public async Task<ServiceResponse<List<FounderDTO>>> GetFoundersByUserId(int userId)
        {
          return new ServiceResponse<List<FounderDTO>>
            {
                Data = await Context.Founders.Where(x => x.UserId == userId)
                .Include(x => x.User).Include(x=>x.Project).Select(c => _mapper.Map<FounderDTO>(c)).ToListAsync()
            };       
        }
    }
}
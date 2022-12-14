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
        public async Task<bool> AddFounder(int userId)
        {
             return await Add(new Founder(){UserId=userId});
        }

        public bool CheckIfFounderCreated(int userId)
        {
             return Context.Founders.Any(x => x.UserId == userId);
        }

        public async Task<FounderDTO> GetFounderByUserId(int userId)
        {
             return _mapper.Map<Founder, FounderDTO>(await Context.Founders.Where(x => x.UserId == userId)
                .Include(x => x.User).FirstAsync());
        }
        public async Task<bool> UpdateFounder(FounderDTO founder)
        {
            var existingFounder =  Context.Founders.First(x => x.Id == founder.Id);
            existingFounder.BackgroundSummary = founder.BackgroundSummary;
            existingFounder.Resume = founder.Resume;
            return await Update(existingFounder);
        }
    }
}
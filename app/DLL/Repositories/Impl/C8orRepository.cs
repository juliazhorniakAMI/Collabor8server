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
    public class C8orRepository:  GenericKeyRepository<int, Collabor8or, DataContext>,IC8orRepository
    {
        private readonly IMapper _mapper;
          public C8orRepository(DataContext context, IMapper mapper) : base(context)
        {
           _mapper = mapper  ;
        }
        public async Task<bool> AddC8or(int userId)
        {
            return await Add(new Collabor8or(){UserId=userId});
        }
        public bool CheckIfC8orCreated(int userId)
        {
             return Context.Collabor8ors.Any(x => x.UserId == userId);
        }
        public async Task<Collabor8orDTO> GetC8orByUserId(int userId)
        {
             return _mapper.Map<Collabor8or, Collabor8orDTO>(await Context.Collabor8ors.Where(x => x.UserId == userId)
                .Include(x => x.User).FirstAsync());
        }
          public async Task<bool> UpdateC8or(Collabor8orDTO c8or)
        { 
            var existingC8or =  Context.Collabor8ors.First(x => x.Id == c8or.Id);
            existingC8or.BackgroundSummary = c8or.BackgroundSummary;
            existingC8or.Resume = c8or.Resume;
            return await Update(existingC8or);
        }
    }
}


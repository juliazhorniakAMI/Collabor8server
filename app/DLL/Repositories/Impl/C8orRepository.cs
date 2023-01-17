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
        public async Task<ServiceResponse<bool>> AddC8or(Collabor8orDTO c)
        {
            Collabor8or r= _mapper.Map<Collabor8orDTO, Collabor8or>(c);
            return await Add(r);     
        }
        public async Task<ServiceResponse<List<Collabor8orDTO>>> GetC8orsByUserId(int userId)
        {
          return  new ServiceResponse<List<Collabor8orDTO>>
            {
                Data = await Context.Collabor8ors.Where(x => x.UserId == userId)
                .Include(x => x.User).Select(c => _mapper.Map<Collabor8orDTO>(c)).ToListAsync()
            };       
        }
          public async Task<bool> UpdateC8or(Collabor8orDTO c8or)
        { 
            var existingC8or =  Context.Collabor8ors.First(x => x.UserId == c8or.Id);
            existingC8or.BackgroundSummary = c8or.BackgroundSummary;
            existingC8or.Resume = c8or.Resume;
            return await Update(existingC8or);
        }
          public async Task<bool> DeleteC8or(int id)
        {
           var user = await GetById(id);
            return await Delete(user);
        }
        public async Task<ServiceResponse<List<Collabor8orDTO>>> GetAllCollabor8ors()
        {
             return  new ServiceResponse<List<Collabor8orDTO>>
            {
                Data = await Context.Collabor8ors.Include(x=>x.User).Select(c => _mapper.Map<Collabor8orDTO>(c)).ToListAsync()
            };
        }
    }
}


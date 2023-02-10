using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using app.Context;
using app.DLL.Models;
using app.DLL.Repositories.Abstract;
using app.ModelsDTO;
using app.ModelsDTO.C8or;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace app.DLL.Repositories.Impl
{
    public class C8orRepository:  GenericKeyRepository<int, Collabor8or, DataContext>,IC8orRepository
    {
        private readonly IMapper _mapper;
         private readonly IHttpContextAccessor _httpContextAccessor;
          public C8orRepository(DataContext context, IMapper mapper,IHttpContextAccessor httpContextAccessor) : base(context)
        {
           _mapper = mapper  ;
           _httpContextAccessor = httpContextAccessor;
        }
         private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
        public async Task<ServiceResponse<bool>> AddC8or(Collabor8orDTO c)
        {
            Collabor8or r= _mapper.Map<Collabor8orDTO, Collabor8or>(c);
            return await Add(r);     
        }
        public async Task<ServiceResponse<List<Collabor8orDTO>>> GetC8orsByUserId()
        {
          return  new ServiceResponse<List<Collabor8orDTO>>
            {
                Data = await Context.Collabor8ors.Where(x => x.UserId == GetUserId())
                .Include(x => x.User).Select(c => _mapper.Map<Collabor8orDTO>(c)).ToListAsync()
            };       
        }
          public async Task<bool> UpdateC8or(Collabor8orUpdateDTO c8or)
        { 
            var existingC8or = await  Context.Collabor8ors.FirstAsync(x => x.UserId == c8or.UserId && x.SphereId==c8or.SphereId);
            existingC8or.SphereId = c8or.SphereId;
            existingC8or.BackgroundSummary = c8or.BackgroundSummary;
            existingC8or.Resume = c8or.Resume;
            return await Update(existingC8or);
        }
          public async Task<bool> DeleteC8or(int id,string sphere)
        {
           var user = await Context.Collabor8ors.FirstAsync(x=>(x.UserId==id && x.SphereId==sphere));
            return await Delete(user);
        }
        public async Task<ServiceResponse<List<Collabor8orDTO>>> GetAllCollabor8ors()
        {
            var list = await Context.Collabor8ors.Include(x=>x.User).Include(x=>x.C8orSkill).ToListAsync();
             return new ServiceResponse<List<Collabor8orDTO>>
            {
              Data = list.Select( c =>  _mapper.Map<Collabor8orDTO>(c)).ToList()
            };
        }
    }
}


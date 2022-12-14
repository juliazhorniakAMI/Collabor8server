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
    public class PMRepository : GenericKeyRepository<int, PM, DataContext>, IPMRepository
    {    private readonly IMapper _mapper;
          public PMRepository(DataContext context, IMapper mapper) : base(context)
        {
           _mapper = mapper  ;
        }
        public async Task<bool> Addpm(int userId)
        {
             return await Add(new PM(){UserId=userId});
        }
         public bool CheckIfPMCreated(int userId)
        {
             return Context.PMs.Any(x => x.UserId == userId);
        }
        public async Task<PMDTO> GetPMByUserId(int userId)
        {
            return _mapper.Map<PM,PMDTO>(await Context.PMs.Where(x => x.UserId == userId)
                .Include(x => x.User).FirstAsync());
        }
    }
}
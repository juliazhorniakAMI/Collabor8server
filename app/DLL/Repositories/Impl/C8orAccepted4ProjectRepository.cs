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
    public class C8orAccepted4ProjectRepository : GenericKeyRepository<int, C8orAccepted4Project, DataContext>, IC8orAccepted4ProjectRepository
    {
        private readonly IMapper _mapper;
        public C8orAccepted4ProjectRepository(DataContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }
        public async Task<bool> AddAcceptedC8or4Project(C8orAccepted4ProjectDTO cp)
        {
            C8orAccepted4Project r = _mapper.Map<C8orAccepted4ProjectDTO, C8orAccepted4Project>(cp);
            return await Add(r);
        }
        public async Task<C8orAccepted4ProjectDTO> GetAcceptedC8or4ProjectById(int id)
        {
            var p = await GetById(id);
            C8orAccepted4ProjectDTO r = _mapper.Map<C8orAccepted4Project, C8orAccepted4ProjectDTO>(p);
            return r;
        }
        public async Task<bool> CancelAcceptedC8or(int id)
        {
            var p = await GetById(id);
            return await Delete(p);
        }
        public async Task<ServiceResponse<List<C8orAccepted4ProjectDTO>>> GetAcceptedMyC8rs4PrjtsByUserId(int userId)
        {
            return new ServiceResponse<List<C8orAccepted4ProjectDTO>>
            {
                Data = await Context.C8orsAccepted4Project.Where(x => (x.Collabor8or.UserId == userId)).Include(x => x.Collabor8or).ThenInclude(x => x.User)
               .Select(c => _mapper.Map<C8orAccepted4ProjectDTO>(c)).ToListAsync()
            };
        }
        public async Task<ServiceResponse<List<C8orAccepted4ProjectDTO>>> GetAcceptedC8rs4MyPrjtsByUserId(int userId)
        {
            return new ServiceResponse<List<C8orAccepted4ProjectDTO>>
            {
                Data = await Context.C8orsAccepted4Project.Where(x => (x.Project.Founders.Any(x => x.UserId == userId))).Include(x => x.Project).ThenInclude(x => x.Founders).ThenInclude(x => x.User)
               .Select(c => _mapper.Map<C8orAccepted4ProjectDTO>(c)).ToListAsync()
            };
        }
    }
}
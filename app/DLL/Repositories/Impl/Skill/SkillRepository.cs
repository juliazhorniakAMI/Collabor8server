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
    public class SkillRepository:  GenericKeyRepository<int, SkillDTO, DataContext>,ISkillRepository
    {
          private readonly IMapper _mapper;
          public SkillRepository(DataContext context, IMapper mapper) : base(context)
        {
           _mapper = mapper  ;
        }
        public async Task<ServiceResponse<List<SkillDTO>>> GetAllSkills()
        {
            return  new ServiceResponse<List<SkillDTO>>
            {
                Data = await Context.Skills.Select(c => _mapper.Map<SkillDTO>(c)).ToListAsync()
            };
        }
    }
}
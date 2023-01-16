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
    public class ProjectSupportInfoRepository : GenericKeyRepository<int, ProjectSupportInfo, DataContext>, IProjectSupportInfoRepository
    {
        private readonly IMapper _mapper;
        public ProjectSupportInfoRepository(DataContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<ProjectSupportInfoDTO>>> GetAllInfoByProjectId(int pjtId)
        {
            return new ServiceResponse<List<ProjectSupportInfoDTO>>
            {
                Data = await Context.ProjectSupportInfo.Where(x => x.ProjectId == pjtId)
                .Select(c => _mapper.Map<ProjectSupportInfoDTO>(c)).ToListAsync()
            };
        }
        public async Task<ServiceResponse<bool>> AddSupportInfo(ProjectSupportInfoDTO psi)
        {
           ProjectSupportInfo r= _mapper.Map<ProjectSupportInfoDTO, ProjectSupportInfo>(psi);
            return await Add(r);         
        }
        public async Task<bool> UpdateInfoForProject(ProjectSupportInfoDTO psi)
        {
            var existingpsi = Context.ProjectSupportInfo.First(x => x.Id == psi.Id);
            existingpsi.Idea = psi.Idea;
            return await Update(existingpsi);
        }
        public async Task<bool> DeleteInfoFromProject(int id)
        {
            var p = await GetById(id);
            return await Delete(p);
        }
    }
}
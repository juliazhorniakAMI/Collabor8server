using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DLL.Repositories.Abstract;
using app.ModelsDTO;
using app.Sevices.Abstract;

namespace app.Sevices.Impl
{
    public class ProjectSupportInfoService : IProjectSupportInfoService
    {
         private readonly IProjectSupportInfoRepository _Repository;
            public ProjectSupportInfoService(IProjectSupportInfoRepository Repository)
        {
            _Repository=Repository;       
        }

        public Task<ServiceResponse<bool>> AddSupportInfo(ProjectSupportInfoDTO psi)
        {
            return _Repository.AddSupportInfo(psi);
        }

        public Task<bool> DeleteInfoFromProject(int id)
        {
           return _Repository. DeleteInfoFromProject(id);
        }
        public Task<ServiceResponse<List<ProjectSupportInfoDTO>>> GetAllInfoByProjectId(int pjtId)
        {
            return _Repository.GetAllInfoByProjectId(pjtId);
        }
        public Task<bool> UpdateInfoForProject(ProjectSupportInfoDTO psi)
        {
           return _Repository.UpdateInfoForProject(psi);
        }
    }
}